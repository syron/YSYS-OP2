using System.Text.Json;
using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using PlayerStore.Models;

namespace PlayerStore.Repositories
{
    public interface IPlayersRepository
    {
        List<Player> ReadUsers();
        void SaveUsers(List<Player> players);
    }
}
