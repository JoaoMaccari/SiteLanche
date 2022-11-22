namespace SiteLanche;

public class program
{
    public static void Main(string[] args)
    {
        CreatHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreatHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });
   
}

  