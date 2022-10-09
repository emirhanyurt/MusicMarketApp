using MusicMarketBussines.Contracts;
using MusicMarketBussines.Implementation;
using MusicMarketCommon.Mappings;
using MusicMarketCore.Contracts;
using MusicMarketCore.Implementation;

namespace MusicMarketUI.Extentions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection service)
        {
            service.AddTransient<IUnitOfWork, UnitOfWork>();
            service.AddTransient<IMusicBussinesEnginee, MusicBussinesEnginee>();
            service.AddTransient<IArtistBussinesEnginee, ArtistBussinesEnginee>();
            service.AddAutoMapper(typeof(Map));
            return service;
        }
    }
}
