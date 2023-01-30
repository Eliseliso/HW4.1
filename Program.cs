int numberA = GetNum("Введите число A: ");
int numberB = GetNum("Введите число B: ");
Raise(numberA, numberB);
void Raise(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(numberA + "->" + result);
}
int GetNum(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
