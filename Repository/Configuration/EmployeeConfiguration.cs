using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
            (
                new Employee
                {
                    Id = new Guid("3cea0a3a-0bc8-4e82-ae1d-87b0d83a8f46"),
                    Name = "Sam Raiden",
                    Age = 26,
                    Position = "Software Developer",
                    CompanyId = new Guid("aee463b1-87db-4931-b04f-f5e2e64eeee6")
                },
                new Employee
                {
                    Id = new Guid("394a480b-3131-4d31-bddd-6aaa8a687db0"),
                    Name = "Sam Raiden",
                    Age = 26,
                    Position = "Software Developer",
                    CompanyId = new Guid("aee463b1-87db-4931-b04f-f5e2e64eeee6")
                },
                new Employee
                {
                    Id = new Guid("4100a7b7-317e-4835-aaf7-a60888578634"),
                    Name = "Kan Miller",
                    Age = 35,
                    Position = "Administrator",
                    CompanyId = new Guid("70094f01-5669-4cc4-807c-dfdd4c9767c0")
                }
            );
        }
    }
}