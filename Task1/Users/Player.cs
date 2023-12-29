using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Taks.Interfaces;

namespace Taks.Users
{
    public class Player : IUser
    { 
        private static uint countUsers = 0;

        public uint Id { get; init; }
        public string NickName { get; set; }
        public int Level { get; set; }
        public bool IsBanned { get; set; }


        public Player(string nickName, int level, bool isBanned = false)
        {
            countUsers++;

            Id = countUsers;
            NickName = nickName;
            Level = level;
            IsBanned = isBanned;
        }


        public override string ToString()
        {
            string isBannedToString = IsBanned ? "да" : "нет";

            return $"Id {Id}, ник {NickName}, уровень {Level}, забанен {isBannedToString}";
        }
    }
}
