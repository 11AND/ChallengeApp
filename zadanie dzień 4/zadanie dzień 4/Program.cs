var name = "Ewa";
char sex = 'K';
char sex2 = 'M';
int age = 30;
int age2 = 18;

if (sex == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30lat");
}

else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa , lat 30");
}

else if (sex2 == 'M' && age2 < 18)
{
    Console.WriteLine("Nie pełnoletni mężczyzna");
}


else
{
    Console.WriteLine("Dane nie spełniają żadnego z warunków");
}
