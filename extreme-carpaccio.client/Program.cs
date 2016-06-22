namespace xCarpaccio.client
{
    using System;
    using Nancy.Hosting.Self;

    public class Program
    {
        static void Main(String[] args)
        {
            Uri uri =
                new Uri("http://localhost:8090");

            using (NancyHost host = new NancyHost(uri))
            {
                host.Start();

                Console.WriteLine("Your application is running on " + uri);
                Console.WriteLine("Press any [Enter] to close the host.");
                Console.ReadLine();
            }
        }
    }
}
