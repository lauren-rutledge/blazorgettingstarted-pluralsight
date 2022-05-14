using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }
        public List<Country> Countries { get; set; }
        public List<JobCategory> JobCategories { get; set; }
        
        private void InitializeJobCategories()
        {
            JobCategories = new()
            {
                new() { JobCategoryId = 1, JobCategoryName = "Pie research" },
                new() { JobCategoryId = 2, JobCategoryName = "Sales" },
                new() { JobCategoryId = 3, JobCategoryName = "Management" },
                new() { JobCategoryId = 4, JobCategoryName = "Store staff" },
                new() { JobCategoryId = 5, JobCategoryName = "Finance" },
                new() { JobCategoryId = 6, JobCategoryName = "QA" },
                new() { JobCategoryId = 7, JobCategoryName = "IT" },
                new() { JobCategoryId = 8, JobCategoryName = "Cleaning" },
                new() { JobCategoryId = 9, JobCategoryName = "Bakery" }
            };
        }

        private void InitializeCountries()
        {
            Countries = new()
            {
                new() { CountryId = 1, Name = "Belgium" },
                new() { CountryId = 2, Name = "Netherlands" },
                new() { CountryId = 3, Name = "USA" },
                new() { CountryId = 4, Name = "Japan" },
                new() { CountryId = 5, Name = "China" },
                new() { CountryId = 6, Name = "UK" },
                new() { CountryId = 7, Name = "France" },
                new() { CountryId = 8, Name = "Brazil" }
            };
        }

        private void InitializeEmployees()
        {
            var e1 = new Employee
            {
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1989, 3, 11),

            }
        }
    }
}