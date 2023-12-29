using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Taks.Interfaces;
using Taks.Users;

namespace Taks.Storages
{
    public class DataBase<T> : IEnumerable<T> 
        where T : class, IUser 
    {
        private List<T> users;


        public DataBase()
        {
            users = new List<T>();
        }


        public void AddUser(T newUser)
        {
            if(newUser is not null)
            {
                users.Add(newUser);
            }
            else
            {
                throw new NullReferenceException("added user has the value null");
            }
        }

        public T GetUserFromId(uint idUser)
        {
            T entry = default(T);

            entry = users.Where(x => x.Id == idUser).First();

            return entry;
        }

        /// <summary>
        /// returns true if the player was deleted by id
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public bool RemoveUser(uint idUser)
        {
            T deleteEntry = GetUserFromId(idUser);

            return users.Remove(deleteEntry);
        }

        /// <summary>
        /// returns true if the player is successfully found and banned
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public bool BanUser(uint idUser)
        {
            T user = GetUserFromId(idUser);

            if (user is not null)
            {
                user.IsBanned = true;

                return true;
            }

            return false;
        }

        /// <summary>
        /// returns true if the player is successfully found and UNbanned
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public bool UnbanUser(uint idUser)
        {
            T user = GetUserFromId(idUser);

            if (user is not null)
            {
                user.IsBanned = false;

                return true;
            }
            
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
