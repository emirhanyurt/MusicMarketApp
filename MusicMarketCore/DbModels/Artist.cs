using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketCore.DbModels
{
    public class Artist:BaseEntity
    {
        public Artist()
        {
            Music = new Collection<Music>();
        }

        public ICollection<Music> Music { get; set; }
    }
}
