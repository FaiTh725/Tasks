using Taks.Storages;
using Taks.Users;

DataBase<Player> dataBasePlayers = new DataBase<Player>();

dataBasePlayers.AddUser(new Player("123", 2, false));
dataBasePlayers.AddUser(new Player("134", 3, true));
dataBasePlayers.AddUser(new Player("1HW3", 1, false));

Console.WriteLine(dataBasePlayers.RemoveUser(2));

dataBasePlayers.BanUser(1);
dataBasePlayers.UnbanUser(1);

foreach (var playes in dataBasePlayers)
{
    Console.WriteLine(playes);
}

try
{
    Player player = dataBasePlayers.GetUserFromId(3);

    Console.WriteLine(player.NickName);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
