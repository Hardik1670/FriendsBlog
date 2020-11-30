using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcFriendsSite.Data;
using MvcFriendsSite.Models;

namespace UserProfile.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcFriendsSiteContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcFriendsSiteContext>>()))
            {
                // Look for any movies.
                if (context.UserModel.Any())
                {
                    return;   // DB has been seeded
                }

                context.UserModel.AddRange(
                    new UserModel
                    {
                        userName = "David",
                        gender = "Male",
                        alias="david",
                        website="david.com",
                        socialWebsite="social.com/david",
                        email = "david@gmail.com",
                        dob = DateTime.Parse("1992-12-2"),

                    },
                                      new UserModel
                                      {
                                          userName = "Andrew",
                                          gender = "Male",
                                          alias = "Andrew",
                                          website = "Andrew.com",
                                          socialWebsite = "social.com/Andrew",
                                          email = "andrew@gmail.com",
                                          dob = DateTime.Parse("1994-12-6"),

                                      }


                );
                context.SaveChanges();
            }
        }

    }
}
