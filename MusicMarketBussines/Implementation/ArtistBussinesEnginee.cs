using AutoMapper;
using MusicMarketBussines.Contracts;
using MusicMarketCommon.ViewModel;
using MusicMarketCore.Contracts;
using MusicMarketCore.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketBussines.Implementation
{
    public class ArtistBussinesEnginee : IArtistBussinesEnginee
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArtistBussinesEnginee(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ArtistVM>> GetAllArtist()
        {
            var data = await _unitOfWork.Artists.GetAllAsync();
            return _mapper.Map<IEnumerable<ArtistVM>>(data);
        }

        
    }
}
