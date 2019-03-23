using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class CharacterDatabase
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

            return character;
        }

        public void Delete( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            var index = GetIndex(id);
            if (index >= 0)
                _items[index] = null;
        }

        public Character Get( int id )
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
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > =.");
            if (character == null)
                throw new ArgumentNullException(nameof(character));
            if (!character.Validate())
                throw new Exception("Character is invalid.");

            var index = GetIndex(id);
            if (index < 0)
                throw new Exception("Character does not exist.");

            var existingIndex = GetIndex(character.Name);
            if (existingIndex >= 0 && existingIndex != index)
                throw new Exception("Character must be unique.");

            character.Id = id;
            var existing = _items[index];
            Clone(existing, character);

            return character;
        }

        private Character Clone( Character character )
        {
            var newCharacter = new Character();
            Clone(newCharacter, character);

            return newCharacter;
        }

        private void Clone( Character target, Character source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Profession = source.Profession;
            target.Race = source.Race;
            target.Attributes = source.Attributes;
        }

        private int GetIndex( int id )
        {
            for (var index = 0; index < _items.Length; ++index)
                if (_items[index]?.Id == id)
                    return index;

            return -1;
        }

        private int GetIndex( string name )
        {
            for (var index = 0; index < _items.Length; ++index)
                if (String.Compare(_items[index]?.Name, name, true) == 0)
                    return index;

            return -1;
        }

        private readonly Character[] _items = new Character[100];
        private int _nextId = 0;
    }
}
