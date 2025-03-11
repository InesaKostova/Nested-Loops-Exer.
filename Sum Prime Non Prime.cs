string input = Console.ReadLine();
int sumPrime = 0;
int sumNonPrime = 0;

while(input!="stop")
{
    int num = int.Parse(input);
    if(num < 0 )
    {
        Console.WriteLine($"Number is negative.");
        num = 0;
    }
    bool isPrime = true;
    for(int i=2; i<=num-1;i++)
    {
        if(num==2)
        {
            break;
        }
    if(num % i==0)
        {
          isPrime = false;
            break;
        }
    }
    if(isPrime)
    {
        sumPrime += num;
    }
    else
    {
        sumNonPrime+= num;
    }
    input = Console.ReadLine();
    isPrime = true;

}
Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
