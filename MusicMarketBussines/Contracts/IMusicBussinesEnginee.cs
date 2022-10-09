using MusicMarketCore.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketBussines.Contracts
{
    public interface IMusicBussinesEnginee
    {
        Task<Music> GetMusicById(int id);
    }
}
