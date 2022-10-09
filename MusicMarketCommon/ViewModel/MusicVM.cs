using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketCommon.ViewModel
{
    public class MusicVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ArtistVM Artist { get; set; }
    }
}
