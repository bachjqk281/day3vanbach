using DAOVANBACH.Models;

namespace DAOVANBACH.Data
{
    public class SeedData
    {
        //Gia lap du lieu ban dau database
        public static List<Category> category = new List<Category>()
{
    new Category(){Id=1,Name="Category 1",Description="Description 1"},
    new Category(){Id=2,Name="Category 2",Description="Description 2"},
    new Category(){Id=3,Name="Category 3",Description="Description 3"},
    new Category(){Id=4,Name="Category 4",Description="Description 4"},
    new Category(){Id=5,Name="Category 5",Description="Description 5"},
};

    }
}
