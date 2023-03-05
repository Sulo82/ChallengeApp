string name = "Ewa";
char sex = ';';  // 'M'- mężczyzna, 'W'- kobieta
var age = 33;


if (name == "Ewa" && age == 33)
{
    Console.WriteLine(name + ",lat " + age);
}
if (sex == 'W' && age == 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat ");
}
if (sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("zmień wartości dla pozostałych");
}
