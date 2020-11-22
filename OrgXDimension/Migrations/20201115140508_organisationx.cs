using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrgXDimension.Migrations
{
    public partial class organisationx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicatonItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    Attrition = table.Column<string>(nullable: true),
                    BusinessTravel = table.Column<string>(nullable: true),
                    DailyRate = table.Column<int>(nullable: false),
                    Department = table.Column<string>(nullable: true),
                    DistanceFromHome = table.Column<int>(nullable: false),
                    Education = table.Column<int>(nullable: false),
                    EducationField = table.Column<string>(nullable: true),
                    EmployeeCount = table.Column<int>(nullable: false),
                    EmployeeNumber = table.Column<int>(nullable: false),
                    EnvironmentSatisfaction = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    HourlyRate = table.Column<int>(nullable: false),
                    JobInvolvement = table.Column<int>(nullable: false),
                    JobLevel = table.Column<int>(nullable: false),
                    JobRole = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<string>(nullable: true),
                    MonthlyIncome = table.Column<int>(nullable: false),
                    MonthlyRate = table.Column<int>(nullable: false),
                    NumCompaniesWorked = table.Column<int>(nullable: false),
                    Over18 = table.Column<string>(nullable: true),
                    OverTime = table.Column<string>(nullable: true),
                    PercentSalaryHike = table.Column<int>(nullable: false),
                    PerformanceRating = table.Column<int>(nullable: false),
                    RelationshipSatisfaction = table.Column<int>(nullable: false),
                    StandardHours = table.Column<int>(nullable: false),
                    StockOptionLevel = table.Column<int>(nullable: false),
                    TotalWorkingYears = table.Column<int>(nullable: false),
                    TrainingTimesLastYear = table.Column<int>(nullable: false),
                    WorkLifeBalance = table.Column<int>(nullable: false),
                    YearsAtCompany = table.Column<int>(nullable: false),
                    YearsInCurrentRole = table.Column<int>(nullable: false),
                    YearsSinceLastPromotion = table.Column<int>(nullable: false),
                    YearsWithCurrManager = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicatonItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicatonItems");
        }
    }
}
