using E_Commerce.DataBase;
using E_Commerce.Entities.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E_Commerce
{
    public class Program : Exception
    {
        
        public static  void ProLife((string peo, int leo)[] val)
        {
            Console.WriteLine(val.GetLength(0));
            
        }
        public static async Task Main()
        {

            Tuple<string, int> tuple = new Tuple<string, int>()
            {

            } ;
            

            var anonim = new
            {
                Nam = " Aziz ",
                LastName = "Rakhmanov",
                BirthDate = String.Format("2001:11:27")
            };

            Console.WriteLine(anonim.BirthDate);

           // StorageBroker broker = new StorageBroker();

           // var user = await broker.Users.FirstOrDefaultAsync(p => p.Name  == "50Cent");

           
           // UserDb userDb = new UserDb();

           //await userDb.RemoveAsync(user);   


            //var ur = await broker.Users.FirstOrDefaultAsync(p => p.Name == "50Cent");
            //Console.WriteLine(ur.LastName);


            //           UserDb userDb = new UserDb();

            //           /* await userDb.CreateAsync(new User()
            //            {
            //                Id = Guid.NewGuid(),
            //                Name = "50Cent",
            //                LastName = "Jackson",
            //                Email = "50Cent@Gmail.com",
            //                ClassCondition = Entities.Enums.ClassCondition.Dead,
            //                BirthDate = DateTime.Now,
            //                PasswordCode = "Pro life"
            //            });


        }
    }
}