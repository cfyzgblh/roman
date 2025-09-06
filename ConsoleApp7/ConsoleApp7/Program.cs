using System.Diagnostics;
string puh = "C:\\Users\\Student\\source\\repos\\roman\\txt.txt";
ProcessStartInfo procInfo = new ProcessStartInfo();
procInfo.Arguments = "C:\\Users\\Student\\source\\repos\\roman\\txt.txt";

for (int i =0 ; i < 5; i++)
{
    File.AppendAllText(puh ,"МАрсияне привет");
    Thread.Sleep(1000);
}