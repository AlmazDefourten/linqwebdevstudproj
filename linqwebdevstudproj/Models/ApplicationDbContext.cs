using linqwebdevstudproj.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = null!;
    public DbSet<Abit> Abits { get; set; } = null!;
    public DbSet<Debitor> Debitors { get; set; } = null!;
    
    public DbSet<GasStation> GasStations { get; set; } = null!;
    
    public DbSet<Ege> EgeMarks { get; set; } = null!;

    public DbSet<SchoolStudent> SchoolStudents { get; set; } = null!;

    public DbSet<Buyer> Buyers { get; set; } = null!;

    public DbSet<DiscountInfo> DiscountInfos { get; set; } = null!;

    public DbSet<Good> Goods { get; set; } = null!;

    public DbSet<Purchase> Purchases { get; set; } = null!;

    public DbSet<GoodClassification> GoodClassifications { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();   // создаем базу данных при первом обращении
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>().HasData(
            new Client {Id = 1, Code = 1, Year = 2023, MonthNumber = 7,ClassesDurationInHours = 25},
            new Client {Id = 2,Code = 1, Year = 2023, MonthNumber = 8,ClassesDurationInHours = 4},
            new Client {Id = 3,Code = 1, Year = 2024, MonthNumber = 1,ClassesDurationInHours = 5},
            new Client {Id = 4,Code = 2, Year = 2024, MonthNumber = 1,ClassesDurationInHours = 6},
            new Client {Id = 5,Code = 2, Year = 2024, MonthNumber = 2,ClassesDurationInHours = 12},
            new Client {Id = 6,Code = 3, Year = 2022, MonthNumber = 5,ClassesDurationInHours = 11},
            new Client {Id = 7,Code = 3, Year = 2023, MonthNumber = 11,ClassesDurationInHours = 67},
            new Client {Id = 8,Code = 4, Year = 2024, MonthNumber = 2,ClassesDurationInHours = 55},
            new Client {Id = 9,Code = 5, Year = 2024, MonthNumber = 2,ClassesDurationInHours = 55}
        );
        
        modelBuilder.Entity<Abit>().HasData(
            new Abit { Id = 1, Year = 2023, SchoolNumber = 123, LastName = "Smith" },
            new Abit { Id = 2, Year = 2023, SchoolNumber = 456, LastName = "Johnson" },
            new Abit { Id = 3, Year = 2024, SchoolNumber = 789, LastName = "Williams" },
            new Abit { Id = 4, Year = 2024, SchoolNumber = 101, LastName = "Jones" },
            new Abit { Id = 5, Year = 2024, SchoolNumber = 202, LastName = "Brown" },
            new Abit { Id = 6, Year = 2022, SchoolNumber = 303, LastName = "Davis" },
            new Abit { Id = 7, Year = 2023, SchoolNumber = 404, LastName = "Miller" },
            new Abit { Id = 8, Year = 2024, SchoolNumber = 505, LastName = "Wilson" },
            new Abit { Id = 10, Year = 2023, SchoolNumber = 607, LastName = "Moored" },
            new Abit { Id = 11, Year = 2023, SchoolNumber = 608, LastName = "Moorea" },
            new Abit { Id = 9, Year = 2024, SchoolNumber = 609, LastName = "Moorew" }
        );
        
        modelBuilder.Entity<Debitor>().HasData(
            new Debitor { Id = 1, LastName = "Smith", Debt = 100.50m, HouseApartmentNumber = 1 },
            new Debitor { Id = 2, LastName = "Johnson", Debt = 200.75m, HouseApartmentNumber = 2 },
            new Debitor { Id = 3, LastName = "Williams", Debt = 150.25m, HouseApartmentNumber = 3 },
            new Debitor { Id = 4, LastName = "Jones", Debt = 300.00m, HouseApartmentNumber = 4 },
            new Debitor { Id = 5, LastName = "Brown", Debt = 75.20m, HouseApartmentNumber = 5 },
            new Debitor { Id = 6, LastName = "Davis", Debt = 180.90m, HouseApartmentNumber = 6 },
            new Debitor { Id = 7, LastName = "Miller", Debt = 250.30m, HouseApartmentNumber = 7 },
            new Debitor { Id = 8, LastName = "Wilson", Debt = 120.60m, HouseApartmentNumber = 8 },
            new Debitor { Id = 9, LastName = "Moored", Debt = 90.40m, HouseApartmentNumber = 9 },
            new Debitor { Id = 10, LastName = "Moorea", Debt = 175.80m, HouseApartmentNumber = 10 },
            new Debitor { Id = 11, LastName = "Moorew", Debt = 210.45m, HouseApartmentNumber = 11 },
            new Debitor { Id = 12, LastName = "Moorex", Debt = 800.70m, HouseApartmentNumber = 12 },
            new Debitor { Id = 13, LastName = "Moorey", Debt = 300.25m, HouseApartmentNumber = 13 }, 
            new Debitor { Id = 14, LastName = "Moorez", Debt = 150.80m, HouseApartmentNumber = 14 }, 
            new Debitor { Id = 15, LastName = "Moorea", Debt = 275.60m, HouseApartmentNumber = 15 }, 
            new Debitor { Id = 16, LastName = "Mooreb", Debt = 90.70m, HouseApartmentNumber = 16 }, 
            new Debitor { Id = 17, LastName = "Moorec", Debt = 180.30m, HouseApartmentNumber = 17 }, 
            new Debitor { Id = 18, LastName = "Moored", Debt = 250.90m, HouseApartmentNumber = 18 }, 
            new Debitor { Id = 19, LastName = "Mooree", Debt = 120.40m, HouseApartmentNumber = 19 }, 
            new Debitor { Id = 20, LastName = "Mooref", Debt = 200.75m, HouseApartmentNumber = 20 }, 
            new Debitor { Id = 21, LastName = "Mooreg", Debt = 350.20m, HouseApartmentNumber = 21 }, 
            new Debitor { Id = 22, LastName = "Mooreh", Debt = 125.60m, HouseApartmentNumber = 22 }, 
            new Debitor { Id = 23, LastName = "Moorei", Debt = 275.30m, HouseApartmentNumber = 23 }, 
            new Debitor { Id = 24, LastName = "Moorej", Debt = 150.90m, HouseApartmentNumber = 24 }, 
            new Debitor { Id = 25, LastName = "Moorek", Debt = 400.40m, HouseApartmentNumber = 25 }, 
            new Debitor { Id = 26, LastName = "Moorel", Debt = 180.75m, HouseApartmentNumber = 26 }, 
            new Debitor { Id = 27, LastName = "Moorem", Debt = 500000.60m, HouseApartmentNumber = 27 }, 
            new Debitor { Id = 28, LastName = "Mooren", Debt = 500.25m, HouseApartmentNumber = 28 }, 
            new Debitor { Id = 29, LastName = "Mooreo", Debt = 190.80m, HouseApartmentNumber = 29 }, 
            new Debitor { Id = 30, LastName = "Moorep", Debt = 5.70m, HouseApartmentNumber = 30 },
            new Debitor { Id = 31, LastName = "Moors", Debt = 2.70m, HouseApartmentNumber = 31 },
            new Debitor { Id = 32, LastName = "Mooreaa", Debt = 3.70m, HouseApartmentNumber = 32 },
            new Debitor { Id = 33, LastName = "Mooreab", Debt = 4.70m, HouseApartmentNumber = 33 },
            new Debitor { Id = 34, LastName = "Mooreac", Debt = 5.70m, HouseApartmentNumber = 34 },
            new Debitor { Id = 35, LastName = "Mooread", Debt = 6.70m, HouseApartmentNumber = 35 },
            new Debitor { Id = 36, LastName = "Mooreae", Debt = 7.70m, HouseApartmentNumber = 36 },
            new Debitor { Id = 37, LastName = "Mooreaf", Debt = 8.70m, HouseApartmentNumber = 37 },
            new Debitor { Id = 38, LastName = "Mooreag", Debt = 9.70m, HouseApartmentNumber = 38 },
            new Debitor { Id = 39, LastName = "Mooreah", Debt = 10.70m, HouseApartmentNumber = 39 },
            new Debitor { Id = 40, LastName = "Mooreai", Debt = 11.70m, HouseApartmentNumber = 40 },
            new Debitor { Id = 41, LastName = "Mooreaj", Debt = 12.70m, HouseApartmentNumber = 41 },
            new Debitor { Id = 42, LastName = "Mooreak", Debt = 13.70m, HouseApartmentNumber = 42 },
            new Debitor { Id = 43, LastName = "Mooreal", Debt = 14.70m, HouseApartmentNumber = 43 },
            new Debitor { Id = 44, LastName = "Mooream", Debt = 15.70m, HouseApartmentNumber = 44 },
            new Debitor { Id = 45, LastName = "Moorean", Debt = 16.70m, HouseApartmentNumber = 45 },
            new Debitor { Id = 46, LastName = "Mooreao", Debt = 17.70m, HouseApartmentNumber = 46 },
            new Debitor { Id = 47, LastName = "Mooreap", Debt = 18.70m, HouseApartmentNumber = 47 },
            new Debitor { Id = 48, LastName = "Mooreaq", Debt = 19.70m, HouseApartmentNumber = 48 },
            new Debitor { Id = 49, LastName = "Moorear", Debt = 20.70m, HouseApartmentNumber = 49 },
            new Debitor { Id = 50, LastName = "Mooreas", Debt = 21.70m, HouseApartmentNumber = 50 },
            new Debitor { Id = 51, LastName = "Mooreat", Debt = 22.70m, HouseApartmentNumber = 51 },
            new Debitor { Id = 52, LastName = "Mooreau", Debt = 23.70m, HouseApartmentNumber = 52 },
            new Debitor { Id = 53, LastName = "Mooreav", Debt = 24.70m, HouseApartmentNumber = 53 },
            new Debitor { Id = 54, LastName = "Mooreaw", Debt = 25.70m, HouseApartmentNumber = 54 },
            new Debitor { Id = 55, LastName = "Mooreax", Debt = 26.70m, HouseApartmentNumber = 55 },
            new Debitor { Id = 56, LastName = "Mooreay", Debt = 27.70m, HouseApartmentNumber = 56 },
            new Debitor { Id = 57, LastName = "Mooreaz", Debt = 28.70m, HouseApartmentNumber = 57 },
            new Debitor { Id = 58, LastName = "Mooreba", Debt = 29.70m, HouseApartmentNumber = 58 },
            new Debitor { Id = 59, LastName = "Moorebb", Debt = 30.70m, HouseApartmentNumber = 59 },
            new Debitor { Id = 60, LastName = "Moorebc", Debt = 31.70m, HouseApartmentNumber = 60 },
            new Debitor { Id = 61, LastName = "Moorebd", Debt = 32.70m, HouseApartmentNumber = 61 },
            new Debitor { Id = 62, LastName = "Moorebe", Debt = 33.70m, HouseApartmentNumber = 62 },
            new Debitor { Id = 63, LastName = "Moorebf", Debt = 34.70m, HouseApartmentNumber = 63 },
            new Debitor { Id = 64, LastName = "Moorebg", Debt = 35.70m, HouseApartmentNumber = 64 },
            new Debitor { Id = 65, LastName = "Moorebh", Debt = 36.70m, HouseApartmentNumber = 65 },
            new Debitor { Id = 66, LastName = "Moorebi", Debt = 37.70m, HouseApartmentNumber = 66 },
            new Debitor { Id = 67, LastName = "Moorebj", Debt = 38.70m, HouseApartmentNumber = 67 },
            new Debitor { Id = 68, LastName = "Moorebk", Debt = 39.70m, HouseApartmentNumber = 68 },
            new Debitor { Id = 69, LastName = "Moorebl", Debt = 0m, HouseApartmentNumber = 69 },
            new Debitor { Id = 70, LastName = "Moorebm", Debt = 0m, HouseApartmentNumber = 70 },
            new Debitor { Id = 71, LastName = "Moorebn", Debt = 42.70m, HouseApartmentNumber = 71 },
            new Debitor { Id = 72, LastName = "Moorebo", Debt = 43.70m, HouseApartmentNumber = 72 },
            new Debitor { Id = 73, LastName = "Moorebp", Debt = 44.70m, HouseApartmentNumber = 73 },
            new Debitor { Id = 74, LastName = "Moorebq", Debt = 45.70m, HouseApartmentNumber = 74 },
            new Debitor { Id = 75, LastName = "Moorebr", Debt = 46.70m, HouseApartmentNumber = 75 },
            new Debitor { Id = 76, LastName = "Moorebs", Debt = 47.70m, HouseApartmentNumber = 76 },
            new Debitor { Id = 77, LastName = "Moorebt", Debt = 48.70m, HouseApartmentNumber = 77 },
            new Debitor { Id = 78, LastName = "Moorebu", Debt = 49.70m, HouseApartmentNumber = 78 },
            new Debitor { Id = 79, LastName = "Moorebv", Debt = 50.70m, HouseApartmentNumber = 79 },
            new Debitor { Id = 80, LastName = "Moorebw", Debt = 51.70m, HouseApartmentNumber = 80 },
            new Debitor { Id = 81, LastName = "Moorebx", Debt = 52.70m, HouseApartmentNumber = 81 },
            new Debitor { Id = 82, LastName = "Mooreby", Debt = 53.70m, HouseApartmentNumber = 82 },
            new Debitor { Id = 83, LastName = "Moorebz", Debt = 54.70m, HouseApartmentNumber = 83 },
            new Debitor { Id = 84, LastName = "Mooreca", Debt = 55.70m, HouseApartmentNumber = 84 },
            new Debitor { Id = 85, LastName = "Moorecb", Debt = 56.70m, HouseApartmentNumber = 85 },
            new Debitor { Id = 86, LastName = "Moorecc", Debt = 57.70m, HouseApartmentNumber = 86 },
            new Debitor { Id = 87, LastName = "Moorecd", Debt = 58.70m, HouseApartmentNumber = 87 },
            new Debitor { Id = 88, LastName = "Moorece", Debt = 59.70m, HouseApartmentNumber = 88 },
            new Debitor { Id = 89, LastName = "Moorecf", Debt = 60.70m, HouseApartmentNumber = 89 },
            new Debitor { Id = 90, LastName = "Moorecg", Debt = 61.70m, HouseApartmentNumber = 90 },
            new Debitor { Id = 91, LastName = "Moorech", Debt = 62.70m, HouseApartmentNumber = 91 },
            new Debitor { Id = 92, LastName = "Mooreci", Debt = 63.70m, HouseApartmentNumber = 92 },
            new Debitor { Id = 93, LastName = "Moorecj", Debt = 64.70m, HouseApartmentNumber = 93 },
            new Debitor { Id = 94, LastName = "Mooreck", Debt = 70.50m, HouseApartmentNumber = 94 },
            new Debitor { Id = 95, LastName = "Moorecl", Debt = 65.20m, HouseApartmentNumber = 95 },
            new Debitor { Id = 96, LastName = "Moorecm", Debt = 80.90m, HouseApartmentNumber = 96 },
            new Debitor { Id = 97, LastName = "Moorecn", Debt = 75.30m, HouseApartmentNumber = 97 },
            new Debitor { Id = 98, LastName = "Mooreco", Debt = 85.60m, HouseApartmentNumber = 98 },
            new Debitor { Id = 99, LastName = "Moorecp", Debt = 72.40m, HouseApartmentNumber = 99 },
            new Debitor { Id = 100, LastName = "Moorecq", Debt = 78.75m, HouseApartmentNumber = 100 },
            new Debitor { Id = 101, LastName = "Moorecr", Debt = 77.20m, HouseApartmentNumber = 101 },
            new Debitor { Id = 102, LastName = "Moorecs", Debt = 73.90m, HouseApartmentNumber = 102 },
            new Debitor { Id = 103, LastName = "Moorect", Debt = 79.30m, HouseApartmentNumber = 103 },
            new Debitor { Id = 104, LastName = "Moorecu", Debt = 74.60m, HouseApartmentNumber = 104 },
            new Debitor { Id = 105, LastName = "Moorecv", Debt = 81.80m, HouseApartmentNumber = 105 },
            new Debitor { Id = 106, LastName = "Moorecw", Debt = 76.45m, HouseApartmentNumber = 106 },
            new Debitor { Id = 107, LastName = "Moorecx", Debt = 82.70m, HouseApartmentNumber = 107 },
            new Debitor { Id = 108, LastName = "Moorecy", Debt = 71.40m, HouseApartmentNumber = 108 },
            new Debitor { Id = 109, LastName = "Moorecz", Debt = 84.20m, HouseApartmentNumber = 109 },
            new Debitor { Id = 110, LastName = "Mooreda", Debt = 68.90m, HouseApartmentNumber = 110 },
            new Debitor { Id = 111, LastName = "Mooredb", Debt = 83.60m, HouseApartmentNumber = 111 },
            new Debitor { Id = 112, LastName = "Mooredc", Debt = 69.75m, HouseApartmentNumber = 112 },
            new Debitor { Id = 113, LastName = "Mooredd", Debt = 86.30m, HouseApartmentNumber = 113 },
            new Debitor { Id = 114, LastName = "Moorede", Debt = 67.50m, HouseApartmentNumber = 114 },
            new Debitor { Id = 115, LastName = "Mooredf", Debt = 88.40m, HouseApartmentNumber = 115 },
            new Debitor { Id = 116, LastName = "Mooredg", Debt = 66.20m, HouseApartmentNumber = 116 },
            new Debitor { Id = 117, LastName = "Mooredh", Debt = 89.60m, HouseApartmentNumber = 117 },
            new Debitor { Id = 118, LastName = "Mooredi", Debt = 65.70m, HouseApartmentNumber = 118 },
            new Debitor { Id = 119, LastName = "Mooredj", Debt = 90.80m, HouseApartmentNumber = 119 },
            new Debitor { Id = 120, LastName = "Mooredk", Debt = 64.40m, HouseApartmentNumber = 120 },
            new Debitor { Id = 121, LastName = "Mooredl", Debt = 92.20m, HouseApartmentNumber = 121 },
            new Debitor { Id = 122, LastName = "Mooredm", Debt = 63.30m, HouseApartmentNumber = 122 },
            new Debitor { Id = 123, LastName = "Mooredn", Debt = 94.50m, HouseApartmentNumber = 123 },
            new Debitor { Id = 124, LastName = "Mooredo", Debt = 95.70m, HouseApartmentNumber = 124 },
            new Debitor { Id = 125, LastName = "Mooredp", Debt = 96.80m, HouseApartmentNumber = 125 },
            new Debitor { Id = 126, LastName = "Mooredq", Debt = 97.90m, HouseApartmentNumber = 126 },
            new Debitor { Id = 127, LastName = "Mooredr", Debt = 98.10m, HouseApartmentNumber = 127 },
            new Debitor { Id = 128, LastName = "Mooreds", Debt = 99.20m, HouseApartmentNumber = 128 },
            new Debitor { Id = 129, LastName = "Mooredt", Debt = 100.30m, HouseApartmentNumber = 129 },
            new Debitor { Id = 130, LastName = "Mooredu", Debt = 101.40m, HouseApartmentNumber = 130 },
            new Debitor { Id = 131, LastName = "Mooredv", Debt = 102.50m, HouseApartmentNumber = 131 },
            new Debitor { Id = 132, LastName = "Mooredw", Debt = 103.60m, HouseApartmentNumber = 132 },
            new Debitor { Id = 133, LastName = "Mooredx", Debt = 104.70m, HouseApartmentNumber = 133 },
            new Debitor { Id = 134, LastName = "Mooredy", Debt = 105.80m, HouseApartmentNumber = 134 },
            new Debitor { Id = 135, LastName = "Mooredz", Debt = 106.90m, HouseApartmentNumber = 135 },
            new Debitor { Id = 136, LastName = "Mooreea", Debt = 107.10m, HouseApartmentNumber = 136 },
            new Debitor { Id = 137, LastName = "Mooreeb", Debt = 108.20m, HouseApartmentNumber = 137 },
            new Debitor { Id = 138, LastName = "Mooreec", Debt = 109.30m, HouseApartmentNumber = 138 },
            new Debitor { Id = 139, LastName = "Mooreed", Debt = 110.40m, HouseApartmentNumber = 139 },
            new Debitor { Id = 140, LastName = "Mooreee", Debt = 111.50m, HouseApartmentNumber = 140 },
            new Debitor { Id = 141, LastName = "Mooreef", Debt = 112.60m, HouseApartmentNumber = 141 },
            new Debitor { Id = 142, LastName = "Mooreeg", Debt = 113.70m, HouseApartmentNumber = 142 },
            new Debitor { Id = 143, LastName = "Mooreeh", Debt = 114.80m, HouseApartmentNumber = 143 },
            new Debitor { Id = 144, LastName = "Mooreei", Debt = 0.01m, HouseApartmentNumber = 144 }
        );
        
        modelBuilder.Entity<GasStation>().HasData(
            new GasStation { Id = 1, Company = "gasa", Cost = 55, Mark = 92, Street = "streeta" },
            new GasStation { Id = 2, Company = "gasa", Cost = 60, Mark = 95, Street = "streeta" },
            new GasStation { Id = 3, Company = "gasa", Cost = 65, Mark = 98, Street = "streeta" },
            new GasStation { Id = 4, Company = "gasa", Cost = 58, Mark = 92, Street = "streetd" },
            new GasStation { Id = 5, Company = "gasb", Cost = 62, Mark = 95, Street = "streete" },
            new GasStation { Id = 6, Company = "gasc", Cost = 70, Mark = 98, Street = "streetf" },
            new GasStation { Id = 7, Company = "gasa", Cost = 56, Mark = 92, Street = "streetg" },
            new GasStation { Id = 8, Company = "gasb", Cost = 63, Mark = 95, Street = "streeth" },
            new GasStation { Id = 9, Company = "gasc", Cost = 68, Mark = 98, Street = "streeti" },
            new GasStation { Id = 10, Company = "gasa", Cost = 59, Mark = 92, Street = "streetj" },
            new GasStation { Id = 11, Company = "gasb", Cost = 64, Mark = 95, Street = "streetk" },
            new GasStation { Id = 12, Company = "gasc", Cost = 72, Mark = 98, Street = "streetl" },
            new GasStation { Id = 13, Company = "gasa", Cost = 57, Mark = 92, Street = "streetm" },
            new GasStation { Id = 14, Company = "gasb", Cost = 66, Mark = 95, Street = "streetn" },
            new GasStation { Id = 15, Company = "gasc", Cost = 75, Mark = 98, Street = "streeto" },
            new GasStation { Id = 16, Company = "gasa", Cost = 54, Mark = 92, Street = "streetp" },
            new GasStation { Id = 17, Company = "gasb", Cost = 61, Mark = 95, Street = "streetq" },
            new GasStation { Id = 18, Company = "gasc", Cost = 69, Mark = 98, Street = "streetr" },
            new GasStation { Id = 19, Company = "gasa", Cost = 55, Mark = 92, Street = "streets" },
            new GasStation { Id = 20, Company = "gasb", Cost = 67, Mark = 95, Street = "streett" },
            new GasStation { Id = 21, Company = "gasc", Cost = 73, Mark = 98, Street = "streetu" },
            new GasStation { Id = 22, Company = "gasa", Cost = 58, Mark = 92, Street = "streetv" },
            new GasStation { Id = 23, Company = "gasb", Cost = 65, Mark = 95, Street = "streetw" },
            new GasStation { Id = 24, Company = "gasc", Cost = 78, Mark = 98, Street = "streetx" },
            new GasStation { Id = 25, Company = "gasa", Cost = 56, Mark = 92, Street = "streety" },
            new GasStation { Id = 26, Company = "gasb", Cost = 62, Mark = 95, Street = "streetz" },
            new GasStation { Id = 27, Company = "gasa", Cost = 71, Mark = 98, Street = "streeta1" },
            new GasStation { Id = 28, Company = "gasb", Cost = 59, Mark = 92, Street = "streetb1" },
            new GasStation { Id = 29, Company = "gasc", Cost = 70, Mark = 95, Street = "streetc1" },
            new GasStation { Id = 30, Company = "gasa", Cost = 77, Mark = 98, Street = "streetd1" }
        );
        
        /*
         * Исходная последовательность содержит сведения о
            результатах сдачи учащимися ЕГЭ по математике, русскому
            языку и информатике (в указанном порядке). Каждый эле-
            мент последовательности включает следующие поля:
            <Фамилия> <Инициалы> <Номер школы> <Баллы
            ЕГЭ>
            Баллы ЕГЭ представляют собой три целых числа в диапазоне
            от 0 до 100, которые отделяются друг от друга одним пробе-
            лом.
         */
        modelBuilder.Entity<Ege>().HasData(
            new Ege { Id = 1, SchoolNumber = 1, Mark1 = 20, Mark2 = 95, Mark3 = 55, LastName = "Mironov", Initials = "MIO" },
            new Ege { Id = 2, SchoolNumber = 1, Mark1 = 20, Mark2 = 82, Mark3 = 60, LastName = "Ivanov", Initials = "IVA" },
            new Ege { Id = 3, SchoolNumber = 1, Mark1 = 20, Mark2 = 90, Mark3 = 65, LastName = "Petrov", Initials = "PET" },
            new Ege { Id = 4, SchoolNumber = 1, Mark1 = 20, Mark2 = 30, Mark3 = 70, LastName = "Sidorov", Initials = "SID" },
            new Ege { Id = 5, SchoolNumber = 1, Mark1 = 100, Mark2 = 78, Mark3 = 72, LastName = "Kuznetsov", Initials = "KUZ" },
            new Ege { Id = 6, SchoolNumber = 2, Mark1 = 72, Mark2 = 88, Mark3 = 68, LastName = "Popov", Initials = "POP" },
            new Ege { Id = 7, SchoolNumber = 3, Mark1 = 90, Mark2 = 85, Mark3 = 75, LastName = "Smirnov", Initials = "SMI" },
            new Ege { Id = 8, SchoolNumber = 3, Mark1 = 78, Mark2 = 92, Mark3 = 80, LastName = "Volkov", Initials = "VOL" },
            new Ege { Id = 9, SchoolNumber = 3, Mark1 = 40, Mark2 = 90, Mark3 = 77, LastName = "Kozlov", Initials = "KOZ" },
            new Ege { Id = 10, SchoolNumber = 4, Mark1 = 72, Mark2 = 80, Mark3 = 65, LastName = "Lebedev", Initials = "LEB" },
            new Ege { Id = 11, SchoolNumber = 4, Mark1 = 77, Mark2 = 85, Mark3 = 70, LastName = "Egorov", Initials = "EGO" },
            new Ege { Id = 12, SchoolNumber = 4, Mark1 = 68, Mark2 = 78, Mark3 = 62, LastName = "Alekseev", Initials = "ALE" },
            new Ege { Id = 13, SchoolNumber = 5, Mark1 = 85, Mark2 = 90, Mark3 = 80, LastName = "Novikov", Initials = "NOV" },
            new Ege { Id = 14, SchoolNumber = 5, Mark1 = 80, Mark2 = 85, Mark3 = 75, LastName = "Morozov", Initials = "MOR" },
            new Ege { Id = 15, SchoolNumber = 5, Mark1 = 75, Mark2 = 78, Mark3 = 70, LastName = "Kovalyov", Initials = "KOV" },
            new Ege { Id = 16, SchoolNumber = 6, Mark1 = 90, Mark2 = 95, Mark3 = 85, LastName = "Fedorov", Initials = "FED" },
            new Ege { Id = 17, SchoolNumber = 6, Mark1 = 88, Mark2 = 92, Mark3 = 80, LastName = "Sergeev", Initials = "SER" },
            new Ege { Id = 18, SchoolNumber = 6, Mark1 = 82, Mark2 = 88, Mark3 = 75, LastName = "Pavlov", Initials = "PAV" },
            new Ege { Id = 19, SchoolNumber = 7, Mark1 = 78, Mark2 = 80, Mark3 = 70, LastName = "Makarov", Initials = "MAK" },
            new Ege { Id = 20, SchoolNumber = 7, Mark1 = 85, Mark2 = 88, Mark3 = 75, LastName = "Nikitin", Initials = "NIK" },
            new Ege { Id = 21, SchoolNumber = 7, Mark1 = 72, Mark2 = 75, Mark3 = 68, LastName = "Zaitsev", Initials = "ZAI" },
            new Ege { Id = 22, SchoolNumber = 8, Mark1 = 90, Mark2 = 92, Mark3 = 85, LastName = "Bogdanov", Initials = "BOG" },
            new Ege { Id = 23, SchoolNumber = 8, Mark1 = 88, Mark2 = 90, Mark3 = 82, LastName = "Vasiliev", Initials = "VAS" },
            new Ege { Id = 24, SchoolNumber = 8, Mark1 = 85, Mark2 = 88, Mark3 = 80, LastName = "Kiselev", Initials = "KIS" },
            new Ege { Id = 25, SchoolNumber = 9, Mark1 = 75, Mark2 = 78, Mark3 = 70, LastName = "Stepanov", Initials = "STE" },
            new Ege { Id = 26, SchoolNumber = 9, Mark1 = 80, Mark2 = 85, Mark3 = 75, LastName = "Titov", Initials = "TIT" },
            new Ege { Id = 27, SchoolNumber = 9, Mark1 = 68, Mark2 = 72, Mark3 = 65, LastName = "Kuzmin", Initials = "KUZ" },
            new Ege { Id = 28, SchoolNumber = 10, Mark1 = 40, Mark2 = 90, Mark3 = 80, LastName = "Kalinin", Initials = "KAL" },
            new Ege { Id = 29, SchoolNumber = 10, Mark1 = 20, Mark2 = 85, Mark3 = 75, LastName = "Sorokin", Initials = "SOR" },
            new Ege { Id = 30, SchoolNumber = 10, Mark1 = 75, Mark2 = 10, Mark3 = 70, LastName = "Belov", Initials = "BEL" }
        );
        
        modelBuilder.Entity<SchoolStudent>().HasData(
            new SchoolStudent { Id = 1, LastName = "Dmitriev", Initials = "DMI", Mark = 4, Class = 1, Subject = "Алгебра" },
            new SchoolStudent { Id = 2, LastName = "Dmitriev", Initials = "DMI", Mark = 3, Class = 1, Subject = "Информатика" },
            new SchoolStudent { Id = 3, LastName = "Dmitriev", Initials = "DMI", Mark = 5, Class = 1, Subject = "Геометрия" },

            new SchoolStudent { Id = 4, LastName = "Semyonov", Initials = "SEM", Mark = 2, Class = 1, Subject = "Геометрия" },
            new SchoolStudent { Id = 5, LastName = "Semyonov", Initials = "SEM", Mark = 2, Class = 1, Subject = "Алгебра" },
            new SchoolStudent { Id = 6, LastName = "Semyonov", Initials = "SEM", Mark = 2, Class = 1, Subject = "Информатика" },

            new SchoolStudent { Id = 7, LastName = "Voronov", Initials = "VOR", Mark = 3, Class = 1, Subject = "Геометрия" },
            new SchoolStudent { Id = 8, LastName = "Voronov", Initials = "VOR", Mark = 2, Class = 1, Subject = "Информатика" },
            new SchoolStudent { Id = 9, LastName = "Voronov", Initials = "VOR", Mark = 4, Class = 1, Subject = "Алгебра" },

            new SchoolStudent { Id = 10, LastName = "Ivanov", Initials = "IVA", Mark = 4, Class = 2, Subject = "Алгебра" },
            new SchoolStudent { Id = 11, LastName = "Ivanov", Initials = "IVA", Mark = 3, Class = 2, Subject = "Информатика" },
            new SchoolStudent { Id = 12, LastName = "Ivanov", Initials = "IVA", Mark = 5, Class = 2, Subject = "Геометрия" },

            new SchoolStudent { Id = 13, LastName = "Petrov", Initials = "PET", Mark = 2, Class = 2, Subject = "Геометрия" },
            new SchoolStudent { Id = 14, LastName = "Petrov", Initials = "PET", Mark = 4, Class = 2, Subject = "Алгебра" },
            new SchoolStudent { Id = 15, LastName = "Petrov", Initials = "PET", Mark = 5, Class = 2, Subject = "Информатика" },

            new SchoolStudent { Id = 16, LastName = "Kuznetsov", Initials = "KUZ", Mark = 3, Class = 2, Subject = "Геометрия" },
            new SchoolStudent { Id = 17, LastName = "Kuznetsov", Initials = "KUZ", Mark = 4, Class = 2, Subject = "Информатика" },
            new SchoolStudent { Id = 18, LastName = "Kuznetsov", Initials = "KUZ", Mark = 2, Class = 2, Subject = "Алгебра" },

            new SchoolStudent { Id = 19, LastName = "Popov", Initials = "POP", Mark = 5, Class = 3, Subject = "Алгебра" },
            new SchoolStudent { Id = 20, LastName = "Popov", Initials = "POP", Mark = 3, Class = 3, Subject = "Информатика" },
            new SchoolStudent { Id = 21, LastName = "Popov", Initials = "POP", Mark = 4, Class = 3, Subject = "Геометрия" },

            new SchoolStudent { Id = 22, LastName = "Smirnov", Initials = "SMI", Mark = 2, Class = 3, Subject = "Геометрия" },
            new SchoolStudent { Id = 23, LastName = "Smirnov", Initials = "SMI", Mark = 4, Class = 3, Subject = "Алгебра" },
            new SchoolStudent { Id = 24, LastName = "Smirnov", Initials = "SMI", Mark = 5, Class = 3, Subject = "Информатика" },

            new SchoolStudent { Id = 25, LastName = "Volkov", Initials = "VOL", Mark = 3, Class = 3, Subject = "Геометрия" },
            new SchoolStudent { Id = 26, LastName = "Volkov", Initials = "VOL", Mark = 2, Class = 3, Subject = "Информатика" },
            new SchoolStudent { Id = 27, LastName = "Volkov", Initials = "VOL", Mark = 4, Class = 3, Subject = "Алгебра" }
        );

        var buyers = new List<Buyer>
        {
            new Buyer { Id = 1, Street = "First", BornYear = 2000 },
            new Buyer { Id = 2, Street = "First", BornYear = 1995 },
            new Buyer { Id = 3, Street = "First", BornYear = 1988 },
            new Buyer { Id = 4, Street = "First", BornYear = 1992 },
            new Buyer { Id = 5, Street = "Second", BornYear = 1990 },
            new Buyer { Id = 6, Street = "Second", BornYear = 1998 },
            new Buyer { Id = 7, Street = "Second", BornYear = 2002 },
            new Buyer { Id = 8, Street = "Second", BornYear = 1985 },
            new Buyer { Id = 9, Street = "Third", BornYear = 1993 },
            new Buyer { Id = 10, Street = "Third", BornYear = 1997 },
            new Buyer { Id = 11, Street = "Third", BornYear = 2001 },
            new Buyer { Id = 12, Street = "Third", BornYear = 1989 },
            new Buyer { Id = 13, Street = "Fourth", BornYear = 1996 },
            new Buyer { Id = 14, Street = "Fourth", BornYear = 1991 },
            new Buyer { Id = 15, Street = "Fourth", BornYear = 1987 },
            new Buyer { Id = 16, Street = "Fourth", BornYear = 2003 },
            new Buyer { Id = 17, Street = "Fifth", BornYear = 1994 },
            new Buyer { Id = 18, Street = "Fifth", BornYear = 1999 },
            new Buyer { Id = 19, Street = "Fifth", BornYear = 2004 },
            new Buyer { Id = 20, Street = "Fifth", BornYear = 1986 }
        };
        modelBuilder.Entity<Buyer>().HasData(
            buyers.ToArray()
        );

        modelBuilder.Entity<DiscountInfo>().HasData(
            new DiscountInfo { Id = 1, BuyerId = buyers[0].Id, DiscountInPercents = 20, ShopName = "First",  },
            new DiscountInfo { Id = 2,BuyerId= buyers[1].Id, DiscountInPercents = 15, ShopName = "Second" },
            new DiscountInfo { Id = 3,BuyerId= buyers[2].Id, DiscountInPercents = 10, ShopName = "Third" },
            new DiscountInfo { Id = 4,BuyerId= buyers[3].Id, DiscountInPercents = 30, ShopName = "Fourth" },
            new DiscountInfo { Id = 5,BuyerId= buyers[4].Id, DiscountInPercents = 25, ShopName = "Fifth" },
            new DiscountInfo { Id = 6,BuyerId= buyers[5].Id, DiscountInPercents = 20, ShopName = "First" },
            new DiscountInfo { Id = 7,BuyerId= buyers[6].Id, DiscountInPercents = 15, ShopName = "Second" },
            new DiscountInfo { Id = 8,BuyerId= buyers[7].Id, DiscountInPercents = 10, ShopName = "Third" },
            new DiscountInfo { Id = 9,BuyerId= buyers[8].Id, DiscountInPercents = 30, ShopName = "Fourth" },
            new DiscountInfo { Id = 10,BuyerId= buyers[9].Id, DiscountInPercents = 25, ShopName = "Fifth" },
            new DiscountInfo { Id = 11,BuyerId= buyers[3].Id, DiscountInPercents = 20, ShopName = "First" },
            new DiscountInfo { Id = 12,BuyerId= buyers[11].Id, DiscountInPercents = 15, ShopName = "Second" },
            new DiscountInfo { Id = 13,BuyerId= buyers[12].Id, DiscountInPercents = 10, ShopName = "Third" },
            new DiscountInfo { Id = 14,BuyerId= buyers[2].Id, DiscountInPercents = 30, ShopName = "Fourth" },
            new DiscountInfo { Id = 15,BuyerId= buyers[14].Id, DiscountInPercents = 25, ShopName = "Fifth" },
            new DiscountInfo { Id = 16,BuyerId= buyers[1].Id, DiscountInPercents = 20, ShopName = "First" },
            new DiscountInfo { Id = 17,BuyerId= buyers[16].Id, DiscountInPercents = 15, ShopName = "Second" },
            new DiscountInfo { Id = 18,BuyerId= buyers[8].Id, DiscountInPercents = 10, ShopName = "Third" },
            new DiscountInfo { Id = 19,BuyerId= buyers[8].Id, DiscountInPercents = 30, ShopName = "Fourth" },
            new DiscountInfo { Id = 20,BuyerId= buyers[8].Id, DiscountInPercents = 25, ShopName = "Fifth" }
        );

        modelBuilder.Entity<Good>().HasData(
            new Good { Id = 1, ShopName = "First", Cost = 50, Article = "AA111-1111" },
            new Good { Id = 2, ShopName = "First", Cost = 60, Article = "BB222-2222" },
            new Good { Id = 3, ShopName = "First", Cost = 70, Article = "CC333-3333" },
            new Good { Id = 4, ShopName = "First", Cost = 55, Article = "DD444-4444" },
            new Good { Id = 5, ShopName = "First", Cost = 45, Article = "EE555-5555" },
            new Good { Id = 6, ShopName = "Second", Cost = 40, Article = "FF666-6666" },
            new Good { Id = 7, ShopName = "Second", Cost = 65, Article = "GG777-7777" },
            new Good { Id = 8, ShopName = "Second", Cost = 75, Article = "HH888-8888" },
            new Good { Id = 9, ShopName = "Second", Cost = 58, Article = "II999-9999" },
            new Good { Id = 10, ShopName = "Second", Cost = 48, Article = "JJ000-0000" },
            new Good { Id = 11, ShopName = "Third", Cost = 55, Article = "KK111-1111" },
            new Good { Id = 12, ShopName = "Third", Cost = 70, Article = "LL222-2222" },
            new Good { Id = 13, ShopName = "Third", Cost = 80, Article = "MM333-3333" },
            new Good { Id = 14, ShopName = "Third", Cost = 63, Article = "NN444-4444" },
            new Good { Id = 15, ShopName = "Third", Cost = 42, Article = "OO555-5555" },
            new Good { Id = 16, ShopName = "Fourth", Cost = 45, Article = "PP666-6666" },
            new Good { Id = 17, ShopName = "Fourth", Cost = 68, Article = "QQ777-7777" },
            new Good { Id = 18, ShopName = "Fourth", Cost = 78, Article = "RR888-8888" },
            new Good { Id = 19, ShopName = "Fourth", Cost = 60, Article = "SS999-9999" },
            new Good { Id = 20, ShopName = "Fourth", Cost = 50, Article = "TT000-0000" }
        );

        modelBuilder.Entity<Purchase>().HasData(
            new Purchase { Id = 1, Article = "AA111-1111", BuyerId = 1, ShopName = "First" },
            new Purchase { Id = 2, Article = "AA111-1111", BuyerId = 1, ShopName = "First" },
            new Purchase { Id = 3, Article = "AA111-1111", BuyerId = 3, ShopName = "First" },
            new Purchase { Id = 4, Article = "DD444-4444", BuyerId = 4, ShopName = "First" },
            new Purchase { Id = 5, Article = "EE555-5555", BuyerId = 5, ShopName = "First" },
            new Purchase { Id = 6, Article = "FF666-6666", BuyerId = 2, ShopName = "Second" },
            new Purchase { Id = 7, Article = "GG777-7777", BuyerId = 7, ShopName = "Second" },
            new Purchase { Id = 8, Article = "HH888-8888", BuyerId = 2, ShopName = "Second" },
            new Purchase { Id = 9, Article = "II999-9999", BuyerId = 9, ShopName = "Second" },
            new Purchase { Id = 10, Article = "JJ000-0000", BuyerId = 4, ShopName = "Second" },
            new Purchase { Id = 11, Article = "KK111-1111", BuyerId = 4, ShopName = "Third" },
            new Purchase { Id = 12, Article = "LL222-2222", BuyerId = 6, ShopName = "Third" },
            new Purchase { Id = 13, Article = "MM333-3333", BuyerId = 2, ShopName = "Third" },
            new Purchase { Id = 14, Article = "NN444-4444", BuyerId = 6, ShopName = "Third" },
            new Purchase { Id = 15, Article = "OO555-5555", BuyerId = 3, ShopName = "Third" },
            new Purchase { Id = 16, Article = "PP666-6666", BuyerId = 3, ShopName = "Fourth" },
            new Purchase { Id = 17, Article = "QQ777-7777", BuyerId = 6, ShopName = "Fourth" },
            new Purchase { Id = 18, Article = "RR888-8888", BuyerId = 3, ShopName = "Fourth" },
            new Purchase { Id = 19, Article = "SS999-9999", BuyerId = 5, ShopName = "Fourth" },
            new Purchase { Id = 20, Article = "TT000-0000", BuyerId = 5, ShopName = "Fourth" }
        );

        modelBuilder.Entity<GoodClassification>().HasData(
            new GoodClassification { Id = 1, Article = "AA111-1111", Category = "Food", Country = "Russia" },
            new GoodClassification { Id = 2, Article = "BB222-2222", Category = "Household", Country = "China" },
            new GoodClassification { Id = 3, Article = "CC333-3333", Category = "Food", Country = "USA" },
            new GoodClassification { Id = 4, Article = "DD444-4444", Category = "Household", Country = "China" },
            new GoodClassification { Id = 5, Article = "EE555-5555", Category = "Food", Country = "USA" },
            new GoodClassification { Id = 6, Article = "FF666-6666", Category = "Household", Country = "Russia" },
            new GoodClassification { Id = 7, Article = "GG777-7777", Category = "Food", Country = "China" },
            new GoodClassification { Id = 8, Article = "HH888-8888", Category = "Household", Country = "USA" },
            new GoodClassification { Id = 9, Article = "II999-9999", Category = "Food", Country = "Russia" },
            new GoodClassification { Id = 10, Article = "JJ000-0000", Category = "Household", Country = "China" },
            new GoodClassification { Id = 11, Article = "KK111-1111", Category = "Food", Country = "USA" },
            new GoodClassification { Id = 12, Article = "LL222-2222", Category = "Household", Country = "Russia" },
            new GoodClassification { Id = 13, Article = "MM333-3333", Category = "Food", Country = "China" },
            new GoodClassification { Id = 14, Article = "NN444-4444", Category = "Household", Country = "USA" },
            new GoodClassification { Id = 15, Article = "OO555-5555", Category = "Food", Country = "Russia" },
            new GoodClassification { Id = 16, Article = "PP666-6666", Category = "Household", Country = "China" },
            new GoodClassification { Id = 17, Article = "QQ777-7777", Category = "Food", Country = "USA" },
            new GoodClassification { Id = 18, Article = "RR888-8888", Category = "Household", Country = "Russia" },
            new GoodClassification { Id = 19, Article = "SS999-9999", Category = "Food", Country = "China" },
            new GoodClassification { Id = 20, Article = "TT000-0000", Category = "Household", Country = "USA" }
        );
    }
}