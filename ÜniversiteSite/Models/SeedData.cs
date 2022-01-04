using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ÜniversiteSite.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            Context context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<Context>();

            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }

            if (!context.Blogs.Any()) {
                context.Blogs.AddRange(
                    new Blog {
                        BlogTitle = "Kayak", 
                        BlogContent = "A boat for one person"
                    },
                    new Blog {
                        BlogTitle = "Lifejacket",
                        BlogContent = "Protective and fashionable"
                    },
                    new Blog {
                        BlogTitle = "Soccer Ball",
                        BlogContent = "FIFA-approved size and weight"
                    },
                    new Blog {
                        BlogTitle = "Corner Flags",
                        BlogContent = "Give your playing field a professional touch"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
