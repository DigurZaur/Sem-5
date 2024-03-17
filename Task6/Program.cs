// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введенных букв гласных.

System.Console.WriteLine("Введите строчку");
string userPrint = System.Console.ReadLine();

string vowels = "aoiue";
int count = 0;

foreach (var item in userPrint)
{
    if(vowels.Contains(item))
    {
        count++;
    }
}

System.Console.WriteLine(count);    