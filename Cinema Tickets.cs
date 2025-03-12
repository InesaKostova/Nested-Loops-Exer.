string name = Console.ReadLine();
int studentsCount = 0;
int standardsCount = 0;
int kidsCount = 0;
int allTickets = 0;

while (name != "Finish")
{
    int freePlace = int.Parse(Console.ReadLine());
    string typeTickets = "";

    while (freePlace > allTickets)
    {
        typeTickets = Console.ReadLine();
        if (typeTickets == "End")
        {
            break;
        }
        allTickets++;
        if (typeTickets =="standard")
        {
            standardsCount++;
        }
        else if (typeTickets =="student")
        {
            studentsCount++;
        }
        else
        {
            kidsCount++;
        }

    }
    Console.WriteLine($"{name} - {(double)allTickets/freePlace*100:F2}% full.");
    name = Console.ReadLine();
    allTickets = 0;
}
int ticketsAfterAllFilms = standardsCount + studentsCount + kidsCount;
Console.WriteLine($"Total tickets: {ticketsAfterAllFilms}");
Console.WriteLine($"{(double)studentsCount/ticketsAfterAllFilms*100:F2}% student tickets.");
Console.WriteLine($"{(double)standardsCount/ticketsAfterAllFilms*100:F2}% standard tickets.");
Console.WriteLine($"{(double)kidsCount/ticketsAfterAllFilms*100:F2}% kids tickets.");


