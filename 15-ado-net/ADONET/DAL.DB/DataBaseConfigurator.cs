using Microsoft.Extensions.Configuration;

namespace DAL.DB
{
    public class DataBaseConfigurator
    {
        static public string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("AppConfig.json", optional: true)
            .Build();


            return configuration["ConnectionString"];
        }
    }
}
