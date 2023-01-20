int input_int(string msg)
{
    Console.Write(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int a = input_int ("Put day of a week number: ");
if (a > 5 && a < 8) 
{
    Console.WriteLine("yes");
}
if (a > 0 && a < 6) 
{
    Console.WriteLine("No");
}
else 
{
    Console.WriteLine("Week has only 7 days");
}