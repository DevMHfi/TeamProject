using System.Net.Http.Headers;
using TeamProject;

DateTime birthDate1 = new DateTime(2006, 10, 17);
DateTime birthDate2 = new DateTime(1607, 10, 10);
DateTime birthDate3 = new DateTime(1998, 5, 23);
DateTime birthDate4 = new DateTime(2003, 4, 21);
DateTime birthDate5 = new DateTime(2010, 5, 10);

Person person1 = new Person("Максим", "Плейбой", birthDate1);
Person person2 = new Person("Иван", "Плейбой", birthDate1);
Person person3 = new Person("Фарид", "Джиджиджинабаев", birthDate2);
Person person4 = new Person("Олег", "Монгол", birthDate3);
Person person5 = new Person("Виктор", "Дудка", birthDate4);
Person person6 = new Person("Александр", "Александр", birthDate5);

Article[] article1 = new Article[3];
Article[] article2 = new Article[1];
Article[] article3 = new Article[1];
Article[] article4 = new Article[1];

article1[0] = new Article(person1, "Убийственная красота", 9.9);
article1[1] = new Article(person2, "Красота требует жертв", 9.9);
article1[2] = new Article(person3, "Страдание как вид искусства", 3);
article2[0] = new Article(person4, "Статья", 5.4);
article3[0] = new Article(person5, "Статья2", 6.9);
article4[0] = new Article(person6, "Статья3", 7.9);

DateTime date1 = new DateTime(2006, 10, 17, 15, 30, 0);
DateTime date2 = new DateTime(2016, 6, 16);
DateTime date3 = new DateTime(2020, 6, 10);
DateTime date4 = new DateTime(2010, 7, 15);

Magazine magazine1 = new Magazine("PlayBoy", Frequancy.Monthly, date1, 1000000, article1);
Magazine magazine2 = new Magazine("Журнал", Frequancy.Weekly, date2, 10000, article2);
Magazine magazine3 = new Magazine("Журнал2", Frequancy.Yearly, date3, 3000000, article3);
Magazine magazine4 = new Magazine();

magazine4.NameOfMagazine = "Журнал3";
magazine4.Frequancy = Frequancy.Monthly;
magazine4.ReliseData = date4;
magazine4.Tirazh = 500000;
magazine4.Articles = article4;

Console.WriteLine(magazine1.ToShortString());
Console.WriteLine("\n" + magazine1[Frequancy.Weekly] + " " + magazine1[Frequancy.Monthly] + " " + magazine1[Frequancy.Yearly] + "\n");
Console.WriteLine(magazine4.ToString());

magazine4.AddArticles(article2);

Console.WriteLine(magazine4.ToString());
DateTime Start1 = DateTime.Now, Start2 = DateTime.Now, Start3 = DateTime.Now, End1 = DateTime.Now, End2 = DateTime.Now, End3 = DateTime.Now;
Magazine[] magaz1 = new Magazine[3];
Magazine[,] magaz2 = new Magazine[2, 3];
Magazine[][] magaz3 = new Magazine[3][];

magaz1[0] = magazine1;
magaz1[1] = magazine2;
magaz1[2] = magazine3;

magaz2[0, 0] = magazine1;
magaz2[0, 1] = magazine2;
magaz2[0, 2] = magazine3;
magaz2[1, 0] = magazine4;
magaz2[1, 1] = magazine1;
magaz2[1, 2] = magazine2;

magaz3[0] = new Magazine[4] { magazine1, magazine2, magazine3, magazine4 };
magaz3[1] = new Magazine[2] { magazine1, magazine2 };
magaz3[2] = new Magazine[3] { magazine1, magazine2, magazine3 };

Start1 = DateTime.Now;
for (int i = 0; i < magaz1.Length; i++)
{
    magaz1[i].Tirazh = 20000;
    magaz1[i].Frequancy = Frequancy.Weekly;
    Console.WriteLine(magaz1[i].Avg);
    Console.WriteLine(magaz1[i].ToShortString());
}
End1 = DateTime.Now;

Start2 = DateTime.Now;
for (int i = 0; i < magaz2.GetLength(0); i++)
{
    for (int j = 0; j < magaz2.GetLength(1); j++)
    {
        magaz2[i, j].Tirazh = 20000;
        magaz2[i, j].Frequancy = Frequancy.Weekly;
        Console.WriteLine(magaz2[i, j].Avg);
        Console.WriteLine(magaz2[i, j].ToShortString());
    }
}
End2 = DateTime.Now;

Start3 = DateTime.Now;
for (int i = 0; i < magaz3.Length; i++)
{
    for (int j = 0; j < magaz3[i].Length; j++)
    {
        magaz3[i][j].Tirazh = 20000;
        magaz3[i][j].Frequancy = Frequancy.Weekly;
        Console.WriteLine(magaz3[i][j].Avg);
        Console.WriteLine(magaz3[i][j].ToShortString());
    }
}
End3 = DateTime.Now;

if (End1.Subtract(Start1) == End2.Subtract(Start2) && End2.Subtract(Start2) == End3.Subtract(Start3))
{
    Console.WriteLine("Данные 3 вида работы с массивом, не отличаются друг от друга по скорости выполнения методов, одномерный массив - {Start1.Subtract(End1)}, двумерный массив - {Start2.Subtract(End2)}, двумерный ступенчатый массив - {Start3.Subtract(End3)}");
}
else
{
    if(End1.Subtract(Start1) < End2.Subtract(Start2))
    {
        if (End1.Subtract(Start1) < End3.Subtract(Start3))
        {
            Console.WriteLine($"Самый быстрый - одномерный массив, одномерный массив - {End1.Subtract(Start1)}, двумерный массив - {End2.Subtract(Start2)}, двумерный ступенчатый массив - {End3.Subtract(Start3)}");
        }
        else
        {
            Console.WriteLine($"Самый быстрый - двумерный ступенчатый массив, одномерный массив - {End1.Subtract(Start1)}, двумерный массив - {End2.Subtract(Start2)}, двумерный ступенчатый массив - {End3.Subtract(Start3)}");
        }
    }
    else
    {
        if (End2.Subtract(Start2) < End3.Subtract(Start3))
        {
            Console.WriteLine($"Самый быстрый - двумерный массив, одномерный массив - {End1.Subtract(Start1)}, двумерный массив - {End2.Subtract(Start2)}, двумерный ступенчатый массив - {End3.Subtract(Start3)}");
        }
        else
        {
            Console.WriteLine($"Самый быстрый - двумерный ступенчатый массив, одномерный массив - {End1.Subtract(Start1)}, двумерный массив - {End2.Subtract(Start2)}, двумерный ступенчатый массив - {End3.Subtract(Start3)}");
        }
    }
}

