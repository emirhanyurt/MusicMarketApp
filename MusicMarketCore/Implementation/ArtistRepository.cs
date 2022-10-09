using MusicMarketCore.Contracts;
using MusicMarketCore.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketCore.Implementation
{
    public class ArtistRepository : RepositoryBase<Artist>, IArtistRepository
    {
        public ArtistRepository(Context ctx) : base(ctx)
        {
        }
    }
}
