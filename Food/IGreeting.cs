using Microsoft.Extensions.Configuration;

namespace Food
{
    public interface IGreeting
    {
        string GreetingOfTheDay();
    }

    public class Greeting : IGreeting
    {
        private IConfiguration _configuration;

        public Greeting(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GreetingOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}