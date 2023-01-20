int input_int(string msg)
{
    Console.Write(msg);
    int x = int.Parse(Console.ReadLine());
    return x;
}
int a = input_int ("Put a number: ");
int b = input_int ("Put b number: ");
int c = input_int ("Put c number: ");
Console.WriteLine(Math.Max(a, Math.Max(b, c)));
