string name = "Ewa";
char sex = 'M';  // 'M'- mężczyzna, 'W'- kobieta
var age = 17;


if (name == "Ewa" && age == 33)
{
    Console.WriteLine(name + ",lat " + age);
}
else if (sex == 'W' && age < 29)
{
    Console.WriteLine("Kobieta poniżej 30 lat ");
}
else if (sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("zmień wartości zmiennych");
}
