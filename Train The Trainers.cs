int jury = int.Parse(Console.ReadLine());
string name=Console.ReadLine();

double allScore = 0;
int countScore = 0;
double presentationScore = 0;

while(name!="Finish")
{
for(int i=1; i<=jury;i++)
    {double score=double.Parse(Console.ReadLine());
        allScore += score;
        presentationScore += score;
        countScore++;
 }
Console.WriteLine($"{name} - {presentationScore/jury:F2}.");
    name= Console.ReadLine();
    presentationScore = 0;
}
Console.WriteLine($"Student's final assessment is {allScore/countScore:F2}.");
