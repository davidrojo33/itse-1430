﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {
        public SqlProductDatabase( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;

        protected override Product AddCore( Product product )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = "AddProduct";
                cmd.CommandType = CommandType.StoredProcedure;

                //Add paramter 1
                var parameter = new SqlParameter("@name", SqlDbType.NVarChar);
                parameter.Value = product.Name;
                cmd.Parameters.Add(parameter);

                //Add paramter 2
                cmd.Parameters.AddWithValue("@price", product.Price);

                var result = Convert.ToInt32(cmd.ExecuteScalar());

                product.Id = result;
                return product;
            };
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        protected override void DeleteCore( int id )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "DeleteProduct";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@id", id);

                //No results
                cmd.ExecuteNonQuery();
            };
        }

        protected override IEnumerable<Product> GetAllCore()
        {
            var ds = new DataSet();

            using (var conn = GetConnection())
            {
                var cmd = new SqlCommand("GetProducts", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(ds);
            };

            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if (table != null)
            {
                return from r in table.Rows.OfType<DataRow>()
                       select new Product() {
                           Id = Convert.ToInt32(r[0]), // ordinal convert
                           Name = r["Name"].ToString(), // by name, convert
                           Price = r.Field<decimal>("Price"),
                       };
            };

            return Enumerable.Empty<Product>();
        }

        protected override Product GetCore( int id )
        {
            using (var conn = GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "GetProducts";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var productId = reader.GetInt32(0);
                    if (productId == id)
                    {
                        var ordinal = reader.GetOrdinal("Name");

                        return new Product() {
                            Id = productId,
                            Name = GetString(reader, "Name"),
                            Price = reader.GetFieldValue<decimal>(3),
                        };
                    };
                };
            }

            return null;
        }

        private string GetString( IDataReader reader, string name )
        {
            var ordinal = reader.GetOrdinal(name);

            if (reader.IsDBNull(ordinal))
                return "";
            return reader.GetString(ordinal);
        }

        protected override Product UpdateCore( int id, Product product )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "UpdateProduct";
                cmd.CommandType = CommandType.StoredProcedure;

                //Add paramter 1
                var parameter = new SqlParameter("@name", SqlDbType.NVarChar);
                parameter.Value = product.Name;
                cmd.Parameters.Add(parameter);

                //Add paramter 2
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@id", id);

                //No results
                cmd.ExecuteNonQuery();
            };

            return product;
        }

        protected override void RemoveCore( int id )
        {
            throw new NotImplementedException();
        }

        protected override Product UpdateCore( Product existing, Product newItem )
        {
            throw new NotImplementedException();
        }
    }
}
