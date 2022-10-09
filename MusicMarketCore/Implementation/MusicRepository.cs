using MusicMarketCore.Contracts;
using MusicMarketCore.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketCore.Implementation
{
    public class MusicRepository : RepositoryBase<Music>, IMusicRepository
    {
        public MusicRepository(Context ctx) : base(ctx)
        {
        }
    }
}
