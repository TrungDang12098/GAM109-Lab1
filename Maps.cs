using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Maps
    {
        public string Name;
        public string ID;
        public string _inGame = "Lien minh huyen thoai";

        public Maps(string id, string name) 
        {
            Name = name;
            ID = id;
        }
        public string ShowData()
        {
            return "ID: " + ID + " |Name: " + Name + " |inGame: " + _inGame;
        }

    }
}
