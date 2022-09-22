int x = 10;
int y = x;
y -= 5;

Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");

//másolás tétele
int[] tomb_1 = { 1, 2, 3, 4, 5, 6 };
int[] tomb_2 = new int[tomb_1.Length];

for (int i = 0; i < tomb_1.Length; i++)
{
    tomb_2[i] = tomb_1[i];
}

Console.Write("\nt1: ");
foreach (var e in tomb_1)
    Console.Write(e + ", ");
tomb_2[2] = 100;
Console.Write("\nt2: ");
foreach (var e in tomb_2)
    Console.Write(e + ", ");

//datetime

DateTime datum = new DateTime(2001, 09, 11, 13, 12, 00);
Console.WriteLine(datum.ToLongDateString() + " " + datum.ToShortTimeString());
Console.WriteLine(datum.ToString("yyyy-MMM-dd, tt hh:mm"));

var szul = new DateTime(1990, 07, 11);
Console.WriteLine(szul);

var szaznappalkesobb = szul.AddDays(100);
Console.WriteLine(szaznappalkesobb);

bool szokoev = DateTime.IsLeapYear(2004);
Console.WriteLine(szokoev);



//value type == érték típus
//reference type = referencia típus