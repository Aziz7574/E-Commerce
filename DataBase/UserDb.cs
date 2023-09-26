
using E_Commerce.Entities.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace E_Commerce.DataBase
{
    public class UserDb
    {
        private StorageBroker _broker;

        public UserDb()
        {
            _broker = new StorageBroker();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> CreateAsync(User user)
        {
            if (user is null)
            {
                throw new InvalidClientException();
            }
            else
            {
                Validate(
                    (Rule: IsInValid(user.Id), Parameter: nameof(user.Id)),
                    (Rule: IsInValid(user.Id), Parameter: nameof(user.Name))
                    );


                await _broker.Users.AddAsync(user);
                var result = await _broker.SaveChangesAsync();
                if (result == 1)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<User> GetSingleAsync(Expression<Func<User, bool>> expression) =>
              await _broker.Users.FirstOrDefaultAsync(expression);


        /// <summary>
        /// row found by lastId is changed to user
        /// </summary>
        /// <param name="lastId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> UpdateAsync(Expression<Func<User, bool>> expression, User user)
        {
            User inDb = await _broker.Users.FirstOrDefaultAsync(expression);
            if (inDb is null)
            {
                var result = await CreateAsync(user);
                return result;
            }
            else
            {
                inDb.Id = inDb.Id;
                inDb.Name = user.Name;
                inDb.BirthDate = user.BirthDate;
                inDb.LastName = user.LastName;
                inDb.Email = user.Email;
                inDb.ClassCondition = user.ClassCondition;
                var result = await _broker.SaveChangesAsync();
                if (result == 1)
                    return user;
                else
                    return null;
            }

        }




        /* public async Task<User> RemoveAsync(Expression<Func<User, bool>> expression)
         {

             var result = _broker.Users.Remove(expression);
         }*/

        private dynamic IsInValid(Guid id) => new
        {
            Condition = id == default,
            Message = "Message is required"
        };

        private dynamic IsInvalid(string text) => new
        {
            Condition = string.IsNullOrWhiteSpace(text),
            Message = "Text is required"
        };

        public void Validate(params(dynamic Rule,string Parameter)[] validations)
        {
            InvalidClientException invalidClientException = new InvalidClientException();

            foreach ((dynamic rule,string parameter) in validations) 
            {
                if (rule.Condition)
                {
                    invalidClientException.UpsertDataList(
                        key: parameter,
                        value: rule.Message
                        );
                }

            }
            invalidClientException.ThrowIfContainsError();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> RemoveAsync(User user)
        {

            _broker.Users.Remove(user);

            var result = await _broker.SaveChangesAsync();
            if (result == 1) return user;
            else return null;
        }

    }
}
