int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

for(int i=firstNum; i<=secondNum;i++)
{ 
string currentNum=i.ToString();
    int evenSum = 0;
    int oddSum = 0;

    for (int j=0;j<currentNum.Length;j++)
    {if (j % 2 == 0)
        {
            evenSum += currentNum[j];
        }
    if(j%2==1)
        {
            oddSum += currentNum[j];
        }

    }

    if(evenSum==oddSum)
    {
        Console.Write(i + " ");
    }
}