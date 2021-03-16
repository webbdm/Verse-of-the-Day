using Microsoft.Extensions.DependencyInjection;


namespace webbdm_verse_of_the_day.Services
{
    public static class ServiceRegistrations
    {
        public static void UseServices(this IServiceCollection services)
        {
            services.AddHttpClient<IBibleService, BibleService>();
        }
    }
}