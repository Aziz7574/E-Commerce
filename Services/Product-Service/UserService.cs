using E_Commerce.DataBase;
using E_Commerce.Entities.Classes;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace E_Commerce.Services.Product_Service
{
    public class UserService
    {
        private readonly UserDb productDb;

        public UserService()
        {
            productDb = new UserDb();
        }

       /* public async Task<User> AddAsync(User user)
        {

            if (user.Equals(null))
            {
                var result = await productDb.CreateAsync(user);
                return result;
            }
            

        }*/
    }

}
