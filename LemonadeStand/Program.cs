namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //member variable(has a)


            //constructor

            //member variables (Can do)


            Console.WriteLine("Welcome to Mike's Summertime Lemonade stand");
            Game newGame = new Game();
            newGame.Startgame();
            Store store = new Store();
            Player player = new Player();
            WeatherForecastGenerator weatherGenerator = new WeatherForecastGenerator();

            // Generate and display a daily weather forecast
            Weather dailyWeather = weatherGenerator.GenerateRandomWeather();
            weatherGenerator.DisplayWeatherForecast(dailyWeather);

            Console.WriteLine("\nWeekly Weather Forecast:");

            // Generate and display a weekly weather forecast
            Weather[] weeklyForecast = weatherGenerator.GenerateWeeklyWeatherForecast();
            weatherGenerator.DisplayWeeklyWeatherForecast(weeklyForecast);





        }
    }
}

