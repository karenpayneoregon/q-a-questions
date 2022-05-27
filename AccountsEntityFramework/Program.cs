using System;
using System.Linq;
using AccountsEntityFramework.Models;
using Newtonsoft.Json;

namespace AccountsEntityFramework
{
    partial class Program
    {
        static void Main(string[] args)
        {

            using var context = new Context.Context();

            var account = IncomingAccount();
            context.Add(account);
            context.SaveChanges();

            Console.WriteLine($"Id for new account {account.Id}");

            
            var accountList = context.Account.ToList();

            foreach (var item in accountList)
            {
                Console.WriteLine($"Id: {item.Id}");
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($"\t{role}");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Mock-up an <see cref="Account"/>
        /// </summary>
        static Account IncomingAccount()
        {
            Account account = new ()
            {
                Active = true,
                CreatedDate = new DateTime(2013,1,20),
                Email = "james@example.com",
                Roles = new []{"User", "Admin"}
            };

            return JsonConvert.DeserializeObject<Account>(
                JsonConvert.SerializeObject(account, Formatting.Indented));
        }
    }
}
