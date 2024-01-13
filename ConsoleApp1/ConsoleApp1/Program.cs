bool Woman = true;
int age = 18;
string name = "Ewa";

if (Woman == true && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 31)
{
    Console.WriteLine("Ewa, lat 31");
}
else if (Woman == false && age < 18) 
{
    Console.WriteLine("Niepelnoletni men");
}
