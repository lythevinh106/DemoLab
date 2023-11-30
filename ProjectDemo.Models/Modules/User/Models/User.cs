using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ProjectDemo.Models.Modules.User.Models
{
    public class User : Contracts.ITable, Contracts.ISeedable
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(1000)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string UserName { get; set; }

        public string Password { get; set; }

        [MaxLength(1000)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Phone { get; set; }

        [MaxLength(1000)]
        public string Address { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public IList Seed()
        {
            var users = new List<User>(
                Enumerable.Range(1, 300).Select(idx => new User
                {
                    Id = idx,
                    Name = $"Customer {idx}",
                    UserName = $"user{idx}",
                    Password = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
                    Email = $"user{idx}@yopmail.com",
                    Phone = $"0123456789{idx}",
                    Address = $"Address {idx}",
                    CreatedDate = DateTime.Parse("2023-11-30 17:46:41.5240297"),
                    UpdatedDate = DateTime.Parse("2023-11-30 17:46:41.5240297")
                }));

            //users.Add(new User()
            //{
            //    Id = 301,
            //    Name = $"Customer 301",
            //    UserName = $"user301",
            //    Password = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
            //    Email = $"user301@yopmail.com",
            //    Phone = $"0123456789301",
            //    Address = $"Address 301",
            //    CreatedDate = DateTime.Parse("2023-11-30 17:46:41.5240297"),
            //    UpdatedDate = DateTime.Parse("2023-11-30 17:46:41.5240297")
            //});

            return users;
        }
    }
}
