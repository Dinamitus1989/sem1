Console.WriteLine("Введите числа");
string A = Console.ReadLine()!;
string B = Console.ReadLine()!;
int ParsedInput = int.Parse(A);
int ParsedInput1 = int.Parse(B);

if (ParsedInput > ParsedInput1)
{
    Console.WriteLine(A);

}
else
{
    Console.WriteLine(B);
}

