using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks.Interfaces
{
    public interface IUser
    {
        uint Id { get; init; }

        string NickName {  get; set; }

        int Level {  get; set; }

        bool IsBanned { get; set; }

    }
}
