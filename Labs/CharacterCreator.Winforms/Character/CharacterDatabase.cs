using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class CharacterDatabase
    {

        public CharacterDatabase()
        {
            var character = new Character();
            character.Name = "David";
            character.Profession = "Fighter";
            character.Race = "Gnome";
            character.Attributes = "Strong";
            Add(character);

        }

        public Character Add( Character character )
        {
            if (character == null)
                throw new ArgumentException(nameof(character));

            if (!character.Validate())
                throw new Exception("Character is invalid");

            var existing = GetIndex(character.Name);
            if (existing >= 0)
                throw new Exception("Character must be unique.");

            for (var index = 0; index < _items.Length; ++index)
            {
                if (_items[index] == null)
                {
                    character.Id = ++_nextId;
                    _items[index] = Clone(character);
                    break;
                };
            };

            return game;
        }

        public void Delete( int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            var index = GetIndex(id);
            if (index >= 0)
                _items[index] = null;
        }

        public Character Get( int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        public Character[] GetAll()
        {
            int count = 0;
            foreach (var item in _items)
                if (item != null)
                    ++count;

            var tempIndex = 0;
            var temp = new Character[count];
            for (var index = 0; index < _items.Length; ++index)
                if (_items[index] != null)
                    temp[tempIndex++] = Clone(_items[index]);

            return temp;
        }

        public Character Update( int id, Character character )
        {

        }
    }
}
