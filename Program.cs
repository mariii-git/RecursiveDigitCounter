// See https://aka.ms/new-console-template for more information
static int digitcount(int n)
{
    if (n < 10)
        return 1;
    else
        return 1 + digitcount(n / 10);
}
Console.WriteLine(digitcount(1234));
