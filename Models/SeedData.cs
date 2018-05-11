using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace JustBooks.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookContext(
                serviceProvider.GetRequiredService<DbContextOptions<BookContext>>()))
            {
                if(context.Book.Any())
                {
                    return;
                }
                context.Book.AddRange(
                    new Book
                    {
                        AuthorFirstName = "John",
                        AuthorLastName = "Doe",
                        Title = "Basketball",
                        Subject = "Sports",
                        Price = 15.60m
                    },
                    new Book
                    {
                        AuthorFirstName = "Jay",
                        AuthorLastName = "Lenno",
                        Title = "Cars",
                        Subject = "Lifestyle",
                        Price = 5.20m
                    },
                    new Book
                    {
                        AuthorFirstName = "Scott",
                        AuthorLastName = "Amack",
                        Title = "Professor",
                        Subject = "Computer Engineering",
                        Price = 20.18m
                    },
                    new Book
                    {
                        AuthorFirstName = "Justin",
                        AuthorLastName = "Wagoner",
                        Title = "Baseball",
                        Subject = "Spors",
                        Price = 6.99m
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
