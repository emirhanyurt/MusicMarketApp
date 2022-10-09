using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketCore.DbModels
{
    public class Music:BaseEntity
    {
        public int ArtisId { get; set; }
        public Artist Artist { get; set; }
    }
}
