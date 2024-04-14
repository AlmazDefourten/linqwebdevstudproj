using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=linqwebdevnew;User Id=postgres;Password=123654gg;");

using var db = new ApplicationDbContext(optionsBuilder.Options);
var input = Convert.ToInt32(Console.ReadLine());
switch (input)
{
    case 4:
        FourEx();
        break;
    case 14:
        FourteenEx();
        break;
    case 25:
        TwentyFiveEx();
        break;
    case 36:
        ThirtySixEx();
        break;
    case 47:
        FortySeventh();
        break;
    case 58:
        FiftyEighth();
        break;
    case 69:
        SixtyNine();
        break;
    case 73:
        SeventyThree();
        break;
    case 80:
        Eighty();
        break;
    case 91:
        NintyOne();
        break;
    default:
        throw new ArgumentException("Дурачок чтоле? Цифры вводи, необучаемый");
}
return;

void FourEx()
{
    var result = db.Clients.GroupBy(x => x.Code)
        .Select(x => new { x.Key, sum = x.Sum(y => y.ClassesDurationInHours) })
        .OrderByDescending(x => x.sum).ThenBy(x => x.Key);

    foreach (var el in result)
    {
        Console.WriteLine(el.sum + " " + el.Key);
    }
}

void FourteenEx()
{
    var result = db.Abits.GroupBy(x => x.Year)
        .Where(x => x.Count() > 1)
        .Select(x => new { a = x.FirstOrDefault() });

    foreach (var el in result.ToList())
    {
        Debug.Assert(el.a != null, "el.a != null");
        Console.WriteLine(el.a.Year);
    }
    Console.WriteLine(result.Count());
}

void TwentyFiveEx()
{
    var groupedDebts = db.Debitors
        .GroupBy(d => d.HouseApartmentNumber / 4 + 1) // Группировка по номеру подъезда
        .Select(g => new
        {
            EntranceNumber = g.Key,
            TotalDebt = g.Sum(d => d.Debt)
        })
        .OrderByDescending(g => g.TotalDebt)
        .First();

    Console.WriteLine($"Номер подъезда: {groupedDebts.EntranceNumber}, Суммарная задолженность: {groupedDebts.TotalDebt:0.00}");
}

/*Исходная последовательность содержит сведения о
задолжниках по оплате коммунальных услуг, живущих в
144-квартирном 9-этажном доме. Каждый элемент последо-
вательности включает следующие поля:
<Номер квартиры> <Фамилия> <Задолженность>
Задолженность указывается в виде дробного числа (целая
часть — рубли, дробная часть — копейки). В каждом подъезде на каждом этаже располагаются по 4 квартиры. Для
каждого из 9 этажей дома найти задолжников, долг которых не
больше величины средней задолженности по данному этажу,
и вывести сведения о них: номер этажа, задолженность (вы-водится с двумя дробными знаками), фамилия, номер
квартиры. Жильцы, не имеющие долга, при вычислении средней задолженности не учитываются. Сведения о каждом задолжнике выводить на отдельной строке и упорядочивать по
возрастанию номеров этажей, а для одинаковых этажей — по возрастанию размера задолженности. Считать, что в наборе
исходных данных все задолженности имеют различные значения.*/
void ThirtySixEx()
{
    var result = db.Debitors
        .GroupBy(d => (d.HouseApartmentNumber - 1) / 4 % 9 + 1) // Группировка по этажам
        .Select(g => new
        {
            FloorNumber = g.Key,
            AverageDebt = g.Average(d => d.Debt),
            TenantsWithDebtNotMoreThanAverageOnFloor = g
                .Where(d => d.Debt != 0)
                .Where(d => d.Debt < g.Average(d1 => d1.Debt))
                .OrderBy(d => d.Debt)
                .ToList()
        })
        .OrderBy(g => g.FloorNumber);

    foreach (var floor in result)
    {
        foreach (var tenant in floor.TenantsWithDebtNotMoreThanAverageOnFloor)
        {
            Console.WriteLine("Этаж " + floor.FloorNumber + " Задолженность " + tenant.Debt.ToString("0.00") + 
                              " Фамилия " + tenant.LastName + " Номер квартиры " + tenant.HouseApartmentNumber);
        }
    }
}

/*
 * Вывести данные обо всех АЗС, предлагавших не менее двух
марок бензина (вначале выводится название компании, затем
название улицы, затем количество предлагавшихся марок
бензина). Сведения о каждой АЗС выводить на новой строке
и упорядочивать по названиям компаний в алфавитном по-
рядке, а для одинаковых компаний — по названиям улиц
(также в алфавитном порядке). Если ни одной требуемой
АЗС не найдено, то записать в результирующий файл строку
«Нет».
 */
void FortySeventh()
{
    var result = db.GasStations
        .GroupBy(x => x.Company + " " + x.Street)
        .Where(x => x.Count() >= 2)
        .Select(x => new
        {
            Count = x.Count(), 
            Company = x.Key.Split(" ", StringSplitOptions.None)[0], 
            Street = x.Key.Split(" ", StringSplitOptions.None)[1]
        })
        .ToList();

    foreach (var gasStation in result)
    {
        Console.WriteLine("Компания " + gasStation.Company + " Улица " + gasStation.Street + " Количество марок бензина " + gasStation.Count);
    }
}

/*
 * Для каждой школы найти трех первых учащихся (в ал-
фавитном порядке), набравших менее 50 баллов хотя бы по
одному из предметов, и вывести их фамилию, инициалы и
номер школы. Сведения о каждом учащемся выводить на от-
дельной строке и упорядочивать в алфавитном порядке фа-
милий и инициалов, а при их совпадении — по возрастанию
номера школы. Если для некоторой школы имеется менее
трех учащихся, удовлетворяющих указанным условиям, то
вывести сведения обо всех таких учащихся. Если в исходном
наборе нет ни одного учащегося, удовлетворяющего указан-
ным условиям, то записать в результирующий файл текст
«Требуемые учащиеся не найдены».
 */
void FiftyEighth()
{
    var result = db.EgeMarks
        .GroupBy(x => x.SchoolNumber)
        .Select(g => new
        {
            SchoolNumber = g.Key,
            FirstThree = g.OrderBy(x => x.LastName)
                .Where(x =>
                    x.Mark1 < 50 ||
                    x.Mark2 < 50 ||
                    x.Mark3 < 50
                )
                .Take(3)
                .ToList()
        })
        .ToList()
        .SelectMany(x => x.FirstThree)
        .OrderBy(x => x.LastName)
        .ThenBy(x => x.Initials)
        .ThenBy(g => g.SchoolNumber)
        .ToList();

    if (!result.Any())
    {
        Console.WriteLine("Требуемые учащиеся не найдены");
    }
    
    foreach (var ege in result)
    {
            Console.WriteLine(ege.LastName + " " + ege.Initials + " Номер школы: " + ege.SchoolNumber);
    }
}

/*
 * Исходная последовательность содержит сведения
об оценках учащихся по трем предметам: алгебре, геометрии
и информатике. Каждый элемент последовательности содер-
жит данные об одной оценке и включает следующие поля:
<Класс> <Фамилия> <Инициалы> <Название
предмета> <Оценка>
Полных однофамильцев (с совпадающей фамилией и ини-
циалами) среди учащихся нет. Класс задается целым числом,
оценка — целое число в диапазоне 2–5. Название предмета
указывается с заглавной буквы. Для каждого класса найти
злостных двоечников — учащихся, получивших в данном
классе максимальное суммарное число двоек по всем пред-
метам (число не должно быть нулевым). Вывести сведения о
каждом из злостных двоечников: фамилию, инициалы, номер
класса и полученное число двоек. Сведения о каждом двоеч-
нике выводить на отдельной строке и располагать в алфавит-
ном порядке их фамилий и инициалов (сортировку по клас-
сам не проводить). Если в наборе исходных данных нет ни
одной двойки, то записать в результирующий файл текст
«Требуемые учащиеся не найдены».
*/
void SixtyNine()
{
    var result = db.SchoolStudents
        .GroupBy(x => x.Class)
        .Select(g => new
        {
            Class = g.Key,
            GroupedByStudents = g.GroupBy(x => x.Initials)
                .Select(gg => new
                {
                    Student = gg.FirstOrDefault(),
                    CountOfFGrade = gg.Count(x => x.Mark == 2),
                }).Where(x => x.CountOfFGrade == g
                    .GroupBy(x => x.Initials)
                    .Select(h => h.Count(x => x.Mark == 2)).Max())
        })
        .ToList();

    if (!result.Any())
    {
        Console.WriteLine("Требуемые учащиеся не найдены");
    }
    
    foreach (var res in result)
    {
        foreach (var student in res.GroupedByStudents)
        {
            Console.WriteLine(student.Student.LastName +
                              student.Student.Initials +
                              " Класс " + res.Class + " Двоек: "
                              + student.CountOfFGrade);
        }
    }
}

/*
 * Даны последовательности A и C, включающие сле-
дующие поля: A: <Год рождения> <Код потребителя> <Улица
проживания> C: <Код потребителя> <Название магазина>
<Скидка (в процентах)> Свойства последовательностей описаны в преамбуле к дан-
ной подгруппе заданий. Для каждого магазина и каждой
улицы определить количество потребителей, живущих на
этой улице и имеющих скидку в этом магазине (вначале вы-
водится название магазина, затем название улицы, затем ко-
личество потребителей со скидкой). Если для некоторой па-
ры «магазин–улица» потребители со скидкой не найдены, то
данные об этой паре не выводятся. Сведения о каждой паре
«магазин–улица» выводить на новой строке и упорядочивать
по названиям магазинов в алфавитном порядке, а для одина-
ковых названий магазинов — по названиям улиц (также в
алфавитном порядке).
 */
void SeventyThree()
{
    var result = db.DiscountInfos
        .Include(d => d.Buyer)
        .OrderBy(d => d.ShopName)
        .ThenBy(d => d.Buyer.Street)
        .GroupBy(d => new { d.ShopName, d.Buyer.Street })
        .Select(g => new
        {
            ShopName = g.Key.ShopName,
            Street = g.Key.Street,
            Count = g.Count()
        });

    foreach (var item in result)
    {
        Console.WriteLine($"Магазин {item.ShopName} Улица {item.Street} Скидку имеют {item.Count} потребителей");
    }
}

/*
 * Даны последовательности D и E, включающие сле-
дующие поля:
D: <Цена (в рублях)> <Название магазина>
<Артикул товара>
E: <Артикул товара> <Название магазина>
<Код потребителя>
Свойства последовательностей описаны в преамбуле к дан-
ной подгруппе заданий. Для каждой пары «магазин–товар»,
указанной в D, определить суммарную стоимость продаж
этого товара в данном магазине (вначале выводится название
магазина, затем артикул товара, затем суммарная стоимость
его продаж). Если товар ни разу не был продан в некотором
магазине, то для соответствующей пары «магазин–товар» в
качестве суммарной стоимости выводится 0. Сведения о ка-
ждой паре «магазин–товар» выводить на новой строке и упо-
рядочивать по названиям магазинов в алфавитном порядке, а
в случае одинаковых названий — по артикулам товаров
(также в алфавитном порядке).
 */
void Eighty()
{
    var result = db.Goods
        .GroupJoin(db.Purchases,
            good => new { good.ShopName, good.Article },
            purchase => new { purchase.ShopName, purchase.Article },
            (good, purchases) => new
            {
                ShopName = good.ShopName,
                Article = good.Article,
                TotalCost = db.Purchases.Count(p => p.ShopName == good.ShopName && p.Article == good.Article) * good.Cost
            })
        .OrderBy(r => r.ShopName)
        .ThenBy(r => r.Article);

    foreach (var item in result)
    {
        Console.WriteLine($"Магазин {item.ShopName} Артикул {item.Article} Продано на {item.TotalCost}");
    }
}

/*
 * Даны последовательности A, B и E, включающие
следующие поля:
A: <Улица проживания> <Год рождения> <Код
потребителя>
B: <Артикул товара> <Страна-производитель>
<Категория>
E: <Название магазина> <Артикул товара>
<Код потребителя>
Свойства последовательностей описаны в преамбуле к дан-
ной подгруппе заданий. Для каждой улицы и каждой катего-
рии товаров определить количество стран, в которых были
произведены товары данной категории, купленные потреби-
телями, живущими на этой улице (вначале выводится назва-
ние улицы, затем название категории, затем количество
стран). Если для какой-либо категории отсутствует инфор-
мация о товарах, проданных жителям некоторой улицы, то
информация о соответствующей паре «улица–категория» не
выводится. Сведения о каждой паре «улица–категория» вы-
водить на новой строке и упорядочивать по названиям улиц в
алфавитном порядке, а для одинаковых улиц — по названиям
категорий (также в алфавитном порядке).
 */
void NintyOne()
{
    var result = db.Purchases
        .GroupBy(p => new { p.Buyer.Street, db.GoodClassifications.FirstOrDefault(gc => gc.Article == p.Article).Category })
        .Select(g => new
        {
            Street = g.Key.Street,
            Category = g.Key.Category,
            CountryCount = g.Select(p => db.GoodClassifications.FirstOrDefault(gc => gc.Article == p.Article).Country).Distinct().Count()
        })
        .Where(r => r.Category != null)
        .OrderBy(r => r.Street)
        .ThenBy(r => r.Category);

    foreach (var item in result)
    {
        Console.WriteLine($"Улица {item.Street} Категория {item.Category} Количество стран {item.CountryCount}");
    }
}