using System.Text.Json;
using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using PlayerStore.Models;

namespace PlayerStore.Repositories
{
    public interface IPlayersRepository<T>
    {
        List<T> Read();
        void Save(List<T> listOfItems);
    }
}
