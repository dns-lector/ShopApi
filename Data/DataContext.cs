using Microsoft.EntityFrameworkCore;

namespace ShopApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasIndex(c => c.Slug).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(c => c.Slug).IsUnique();

            Guid glassId = Guid.Parse("25044C03-549F-4A52-86C3-975196966AA1");
            Guid officeId = Guid.Parse("D6B69746-B24C-4F42-927B-78C1D539AF38");
            Guid stoneId = Guid.Parse("62BAB42B-3652-42F6-B3C1-221CE296D66D");
            Guid woodId = Guid.Parse("FD7CC5C1-3543-4BD6-B36C-64CF7E8F9030");
            modelBuilder.Entity<Category>().HasData([
                new() { Id = glassId, Name="Вироби зі скла", Slug="glass", ImageUrl ="glass.jpg",
                    Description="Декоративні та сувенірні товари зі скла", IsActive=true },
                new() { Id = officeId, Name="Товари для офісу", Slug="office", ImageUrl ="office.jpg",
                    Description="Сувенірні товари для встановлення на стіл", IsActive=true },
                new() { Id = stoneId, Name="Вироби з каменю", Slug="stone", ImageUrl ="stone.jpg",
                        Description="Декоративні та сувенірні товари з каменю", IsActive=true },
                new() { Id = woodId, Name="Вироби з деревини", Slug="wood", ImageUrl ="wood.jpg",
                        Description="Практичні та декоративні товари з деревини", IsActive=true }
            ]);
            modelBuilder.Entity<Product>().HasData([
                new(){Id=Guid.NewGuid(), CategoryId=glassId, IsActive=true,
                    ImageUrl="glass1.png", Slug="glass1", Name="Сфера з ялинкою", Description="Декоративна скляна сфера з ялинкою", PriceCent=32050},
                    new(){Id=Guid.NewGuid(), CategoryId=glassId, IsActive=true,
                    ImageUrl="glass2.jpg", Slug="glass2", Name="Бик", Description="Фігурка бика з кольорового скла", PriceCent=41000},
                    new(){Id=Guid.NewGuid(), CategoryId=glassId, IsActive=true,
                    ImageUrl="glass3.jpg", Slug="glass3", Name="Гелікоптер", Description="Декоративна скляна сфера з гелікоптером", PriceCent=33050},
                    new(){Id=Guid.NewGuid(), CategoryId=glassId, IsActive=true,
                    ImageUrl="glass4.jpeg", Slug="glass4", Name="Лис", Description="Фігурка лисиці з кольорового скла", PriceCent=25000},
                    new(){Id=Guid.NewGuid(), CategoryId=glassId, IsActive=true,
                    ImageUrl="glass5.jpg", Slug="glass5", Name="Цукерниця", Description="Скляна настільна форма для цукерок", PriceCent=37000},
                    new(){Id=Guid.NewGuid(), CategoryId=glassId, IsActive=true,
                    ImageUrl="glass6.jpg", Slug="glass6", Name="Пава", Description="Фігурка павича з кольорового скла", PriceCent=19000},
                    new(){Id=Guid.NewGuid(), CategoryId=glassId, IsActive=true,
                    ImageUrl="glass7.jpg", Slug="glass7", Name="Кіт", Description="Фігурка кота з прозорого скла", PriceCent=41050},
                    new(){Id=Guid.NewGuid(), CategoryId=glassId, IsActive=true,
                    ImageUrl="glass8.jpg", Slug="glass8", Name="Ваги", Description="Декоративна скляна сфера з терезами", PriceCent=34000},

                    new(){Id=Guid.NewGuid(), CategoryId=officeId, IsActive=true,
                    ImageUrl="office1.jpeg", Slug="office1", Name="Вершник", Description="Декоративний настільний маятник у формі вершника", PriceCent=39050},
                    new(){Id=Guid.NewGuid(), CategoryId=officeId, IsActive=true,
                    ImageUrl="office2.jpg", Slug="office2", Name="Маятник Ньютона", Description="Декоративний настільний маятник Ньютона", PriceCent=42000},
                    new(){Id=Guid.NewGuid(), CategoryId=officeId, IsActive=true,
                    ImageUrl="office3.jpg", Slug="office3", Name="Сонцеворот", Description="Декоративна настільна фігурка", PriceCent=33000},
                    new(){Id=Guid.NewGuid(), CategoryId=officeId, IsActive=true,
                    ImageUrl="office4.jpg", Slug="office4", Name="Маятник Жордана", Description="Декоративний настільний маятник у формі Жордана", PriceCent=37500},
                    new(){Id=Guid.NewGuid(), CategoryId=officeId, IsActive=true,
                    ImageUrl="office5.jpeg", Slug="office5", Name="Штурвал", Description="Прес для паперів у формі штурвалу", PriceCent=34550},
                    new(){Id=Guid.NewGuid(), CategoryId=officeId, IsActive=true,
                    ImageUrl="office6.jpg", Slug="office6", Name="Система", Description="Декоративний настільний маятник у формі планетарної системи", PriceCent=32500},
                    new(){Id=Guid.NewGuid(), CategoryId=officeId, IsActive=true,
                    ImageUrl="office7.jpg", Slug="office7", Name="Маятник", Description="Декоративний настільний маятник у формі орбітальних кульок", PriceCent=35000},

                    new(){Id=Guid.NewGuid(), CategoryId=stoneId, IsActive=true,
                    ImageUrl="stone1.jpg", Slug="stone1", Name="Цукорниця", Description="Посуд-цукорниця з природнього каменю", PriceCent=35000},
                    new(){Id=Guid.NewGuid(), CategoryId=stoneId, IsActive=true,
                    ImageUrl="stone2.jpg", Slug="stone2", Name="Груша", Description="Декоративна фігурка у формі груши з природнього каменю", PriceCent=40000},
                    new(){Id=Guid.NewGuid(), CategoryId=stoneId, IsActive=true,
                    ImageUrl="stone3.jpg", Slug="stone3", Name="Сова", Description="Фігурка-амулет у формі сови", PriceCent=30000},

                    new(){Id=Guid.NewGuid(), CategoryId=woodId, IsActive=true,
                    ImageUrl="wood1.jpg", Slug="wood1", Name="Кошик", Description="Кошик з дерева середнього розміру", PriceCent=48000},
                    new(){Id=Guid.NewGuid(), CategoryId=woodId, IsActive=true,
                    ImageUrl="wood2.jpg", Slug="wood2", Name="Булава", Description="Сувенір - булава з дерева", PriceCent=85000},
                    new(){Id=Guid.NewGuid(), CategoryId=woodId, IsActive=true,
                    ImageUrl="wood3.jpg", Slug="wood3", Name="Кухолі", Description="Набір кухолів з дерева", PriceCent=21000},
                    new(){Id=Guid.NewGuid(), CategoryId=woodId, IsActive=true,
                    ImageUrl="wood4.jpg", Slug="wood4", Name="Черепаха", Description="Настільна підставка для олівців з черепахою", PriceCent=42050},
                    new(){Id=Guid.NewGuid(), CategoryId=woodId, IsActive=true,
                    ImageUrl="wood5.jpeg", Slug="wood5", Name="Леви", Description="Декоративний твір з дерева", PriceCent=54000},
                ]);
        }
    }
}
