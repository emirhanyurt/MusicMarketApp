using MusicMarketCore.Contracts;
using MusicMarketCore.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketCore.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private MusicRepository _musicRepository;
        private ArtistRepository _artistRepository;
        public UnitOfWork(Context context)
        {
          this._context = context;
            
        }

        public IMusicRepository Musics => _musicRepository ?? new MusicRepository(_context);
        public IArtistRepository Artists => _artistRepository ?? new ArtistRepository(_context);

        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
