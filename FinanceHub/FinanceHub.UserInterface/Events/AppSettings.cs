using FinanceHub.DataAccess.Context;
using FinanceHub.Entity.DomainObjects;

namespace FinanceHub.UserInterface.Events
{
    public class AppSettings
    {
        public FinanceHubContext financeHubContext = new FinanceHubContext();

        public void AllProcess()
        {
            CreateDemoUser();
            CreateCategories();
        }
        public void CreateDemoUser()
        {
            User newUser = new User();
            newUser.Name = "Furkan";
            newUser.LastName = "Kapukaya";
            newUser.Email = "furkankapukayaa@gmail.com";
            newUser.Password = "furkan123";
            newUser.Phone = "05555555555";

            financeHubContext.Users.Add(newUser);
            financeHubContext.SaveChanges();
        }

        public void CreateCategories()
        {
            Category category = new Category();
            category.Name = "Akaryakıt";
            financeHubContext.Categories.Add(category);

            Category category2 = new Category();
            category2.Name = "Market";
            financeHubContext.Categories.Add(category2);

            Category category3 = new Category();
            category3.Name = "Ulaşım";
            financeHubContext.Categories.Add(category3);

            Category category4 = new Category();
            category4.Name = "Sağlık";
            financeHubContext.Categories.Add(category4);

            Category category5 = new Category();
            category5.Name = "Yemek";
            financeHubContext.Categories.Add(category5);

            Category category6 = new Category();
            category6.Name = "Oyun";
            financeHubContext.Categories.Add(category6);

            Category category7 = new Category();
            category7.Name = "Hediye";
            financeHubContext.Categories.Add(category7);

            financeHubContext.SaveChanges();
        }
    }
}