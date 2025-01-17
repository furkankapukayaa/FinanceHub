using FinanceHub.DataAccess.Context;
using FinanceHub.Entity.DomainObjects;

namespace FinanceHub.UserInterface.Events
{
    public class AppSettings
    {
        public FinanceHubContext financeHubContext = new FinanceHubContext();

        public void CreateDemoUser()
        {
            if (financeHubContext.Users.FirstOrDefault(x => x.Email == "furkankapukayaa@gmail.com") != null)
            {
                return;
            }

            User newUser = new User();
            newUser.Name = "Furkan";
            newUser.LastName = "Kapukaya";
            newUser.Email = "furkankapukayaa@gmail.com";
            newUser.Password = "furkan123";
            newUser.Phone = "05555555555";

            financeHubContext.Users.Add(newUser);
            financeHubContext.SaveChanges();

            CreateCategories(newUser.Id);
        }

        public void CreateCategories(string userId)
        {
            Category category = new Category();
            category.Name = "Akaryakıt";
            category.UserId = userId;
            financeHubContext.Categories.Add(category);

            Category category2 = new Category();
            category2.Name = "Market";
            category2.UserId = userId;
            financeHubContext.Categories.Add(category2);

            Category category3 = new Category();
            category3.Name = "Ulaşım";
            category3.UserId = userId;
            financeHubContext.Categories.Add(category3);

            Category category4 = new Category();
            category4.Name = "Sağlık";
            category4.UserId = userId;
            financeHubContext.Categories.Add(category4);

            Category category5 = new Category();
            category5.Name = "Yemek";
            category5.UserId = userId;
            financeHubContext.Categories.Add(category5);

            Category category6 = new Category();
            category6.Name = "Oyun";
            category6.UserId = userId;
            financeHubContext.Categories.Add(category6);

            Category category7 = new Category();
            category7.Name = "Hediye";
            category7.UserId = userId;
            financeHubContext.Categories.Add(category7);

            financeHubContext.SaveChanges();
        }
    }
}