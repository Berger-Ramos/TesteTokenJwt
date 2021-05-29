using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteToken.Starter;
using TesteToken.Starter.Transacional;
namespace TesteToken
{
    class Program
    {


        static void Main(string[] args)
        {
            try
            {
                Console.Write("Cliente Id : ");
                string clientId = Console.ReadLine();
                Console.Write("Client Secret : ");
                string ClientScret = Console.ReadLine();
                User user = new User()
                {
                    Client_Id = clientId,
                    Client_Secret = ClientScret
                };

                Console.WriteLine("App em andamento");

                Console.WriteLine(TesteTokenStarter.GenerateToken(user));

                Console.ReadKey();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
