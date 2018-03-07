using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsEF;

namespace DataAccess
{
    public class MyInitializer : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext db)
        {
            base.Seed(db);

            var owner = new Owner
            {
                FirstName = "Tommy",
                LastName = "Stenberg",
                Email = "stenberg@email.com"
            };

            var category = new Category
            {
                CategoryName = "Point'n'Click Adventure"
            };

            var review = new Review
            {
                ReviewText = "This game is a perfect example of the genre, and sets and example to follow for years to come.",
                Source = "My brain",
                SourceType = "Part of the human body",
                Grade = "93%",
                GradeType = "Percentage"
            };
            var software = new Software
            {
                ItemName = "Secret of Monkey Island, The",
                YearOfRelease = 1991,
                Owner = owner,
                Category = category,
                Review = review
            };

            db.Items.Add(software);
            db.SaveChanges();

        }

        

    }
}
