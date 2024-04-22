using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class Player
    {
        private string name;
        private int runs;

        public int Runs
        {
            get { return runs; }
        }
        public Player(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }

        public override string ToString()
        {
            return $"Name : {name}, Runs : {runs}";
        }
    }

    public class Team : IEnumerable
    {
        private Player[] players;

        public Team()
        {
            players = new Player[3];
            players[0] = new Player("Virat", 3000);
            players[1] = new Player("Rohit", 5000);
            players[2] = new Player("Rahul", 2800);
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }

    public class PlayerComapare : IComparer<Player>
    {
        public int Compare(Player? x, Player? y)
        {
            if (x.Runs > y.Runs)
            {
                return 1;
            }
            else if (x.Runs<y.Runs)
            {
                return -1;
            }
            else
            {   
                return 0;
            }
        }
    }
}
