using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public abstract class GameDatabase : IGameDatabase
    {
        public Game Add( Game game )
        {
            //Validate input
            if (game == null)
                throw new ArgumentException(nameof(game));

            //Game must be valid            
            //new ObjectValidator().Validate(game);
            ObjectValidator.Validate(game);

            //Game names must be unique
            var existing = FindByName(game.Name);
            if (existing != null)
                throw new Exception("Game must be unique.");

            return AddCore(game);
        }

        public void Delete( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            DeleteCore(id);
        }

        public Game Get( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            return GetCore(id);
        }

        public IEnumerable<Game> GetAll()
        {
            return GetAllCore();
        }

        public Game Update( int id, Game game )
        {
            //Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            if (game == null)
                throw new ArgumentNullException(nameof(game));

            //new ObjectValidator().Validate(game);
            ObjectValidator.Validate(game);

            var existing = GetCore(id);
            if (existing != null)
                throw new Exception("Game does not exist.");

            //Game names must be unique            
            var sameName = FindByName(game.Name);
            if (sameName != null && sameName.Id != id)
                throw new Exception("Game must be unique.");

            return UpdateCore(id, game);
        }

        protected abstract Game AddCore( Game game );

        protected abstract void DeleteCore( int id );

        protected virtual Game FindByName( string name )
        {
            //select
            //from
            //where
            // => IEnumerable<T>
            return (from game in GetAllCore()
                    where String.Compare(game.Name, name, true) == 0
                    //orderby game.Name, game.Id descending
                    select game).FirstOrDefault();

            //foreach (var game in GetAllCore())
            //{
            //    if (String.Compare(game.Name, name, true) == 0)
            //        return game;
            //};

            //return null;
        }

        protected abstract Game GetCore( int id );

        protected abstract IEnumerable<Game> GetAllCore();

        protected abstract Game UpdateCore( int id, Game newGame );
    }
}

//if (!game.Validate())
//    throw new Exception("Game is invalid.");
//private readonly Collection<Game> _items = new Collection<Game>();
//var game = new Game();
//game.Name = "DOOM";
//game.Description = "Space Marine";
//game.Price = 49.99M;

//Object initializer
//var game = new Game() {
//    Name = "DOOM",
//    Description = "Space Marine",
//    Price = 49.99M
//};
//Add(game);

//game = new Game() {
//    Name = "Oblivion",
//    Description = "Medieval",
//    Price = 89.99M,
//};
//Add(game);

//Add(new Game() {
//    Name = "Fallout 76",
//    Description = "Failed MMO",
//    Price = 0.01M
//});

////How many games?
//int count = 0;
//foreach (var item in _items)
//    if (item != null)
//        ++count;

//var tempIndex = 0;
//var temp = new Game[count];
//for (var index = 0; index < _items.Length; ++index)
//    if (_items[index] != null)
//        temp[tempIndex++] = Clone(_items[index]);

////Dummy test
//if (String.Compare(game.Name, "Anthem", true) == 0)
//    throw new InvalidOperationException("Only good games are allowed here.");
//if (game.Price > 1000)
//    throw new NotImplementedException();

//for (var index = 0; index < _items.Length; ++index)
//{
//    if (_items[index] == null)
//    {
//        game.Id = ++_nextId;
//        _items[index] = Clone(game);
//        break;
//    };
//};

//if (!game.Validate())
//  throw new Exception("Game is invalid.");

//if (!game.Validate())
//  throw new Exception("Game is invalid");

//public Game[] GetAll()