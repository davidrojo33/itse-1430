using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public class MemoryGameDatabase : GameDatabase
    {

        protected override Game AddCore( Game game )
        {
            game.Id = ++_nextId;
            _items.Add(Clone(game));

            return game;
        }

        protected override void DeleteCore( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                _items.RemoveAt(index);
        }

        protected override Game GetCore( int id )
        {
           
            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        //public Game[] GetAll()
        protected override IEnumerable<Game> GetAllCore()
        {

            foreach (var item in _items)
                yield return Clone(item);
        }

        protected override Game UpdateCore( int id, Game game )
        {
            var index = GetIndex(id);

            game.Id = id;
            var existing = _items[index];
            Clone(existing, game);

            return game;
        }

        private Game Clone( Game game )
        {
            var newGame = new Game();
            Clone(newGame, game);

            return newGame;
        }

        private void Clone( Game target, Game source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Description = source.Description;
            target.Price = source.Price;
            target.Owned = source.Owned;
            target.Completed = source.Completed;
        }

        private int GetIndex( int id )
        {
            for (var index = 0; index < _items.Count; ++index)
                    return index;

            return -1;
        }

        //Arrays are so 90s
        //private readonly Game[] _items = new Game[100];

        //ArrayLists are so 00s
        //private readonly ArrayList _items = new ArrayList();

        private readonly List<Game> _items = new List<Game>();
        //private readonly Collection<Game> _items = new Collection<Game>();

        private int _nextId = 0;
    }
}

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
