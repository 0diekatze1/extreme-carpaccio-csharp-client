using System.IO;
using System.Text;

namespace xCarpaccio.client
{
    using Nancy;
    using System;
    using Nancy.ModelBinding;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ => "It works !!! You need to register your server on main server.";

            Post["/order"] = _ =>
            {
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    Console.WriteLine("Order received: {0}", reader.ReadToEnd());
                }
                Order order = null;

                try
                {
                    Order order = this.Bind<Order>();
                }
                catch (Exception e)
                {
                    return null;
                }

                BillCalculator billCalculator = new BillCalculator();

                Bill bill = billCalculator.Calculate(order);

                return bill;
            };

            Post["/feedback"] = _ =>
            {
                Feedback feedback = this.Bind<Feedback>();
                Console.Write("Type: {0}: ", feedback.Type);
                Console.WriteLine(feedback.Content);
                return Negotiate.WithStatusCode(HttpStatusCode.OK);
            };
        }
    }
}