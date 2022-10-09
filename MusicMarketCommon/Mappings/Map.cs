using AutoMapper;
using MusicMarketCommon.ViewModel;
using MusicMarketCore.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketCommon.Mappings
{
    public class Map : Profile
    {
        public Map()
        {
            CreateMap<Music, MusicVM>();
            CreateMap<Artist, ArtistVM>();
            CreateMap<MusicVM, Music>();
            CreateMap<Artist, ArtistVM>();
        }
    }
}
