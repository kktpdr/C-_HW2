int input_int(string msg)
{
    Console.Write(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int A = input_int ("Put a number: ");
int a = A;
if (a<100)
{
    Console.WriteLine($"{a} haven't 3d digit");
} 
int res = -1;
while (a > 999)
{
    a = a/10;
    res = a % 10;
    
}
Console.WriteLine($"The last number of {A} is {res}");