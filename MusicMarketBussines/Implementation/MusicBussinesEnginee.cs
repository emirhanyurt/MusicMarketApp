using MusicMarketBussines.Contracts;
using MusicMarketCore.Contracts;
using MusicMarketCore.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketBussines.Implementation
{
    public class MusicBussinesEnginee : IMusicBussinesEnginee
    {
        private readonly IUnitOfWork _unitOfWork;

        public MusicBussinesEnginee(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Music> GetMusicById(int id)
        {
            return await _unitOfWork.Musics.GetByIdAsync(id);
        }
    }
}
