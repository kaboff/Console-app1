bool woman = true;
int age = 18;
string name = "Ewa";

if (woman == true && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 31)
{
    Console.WriteLine("Ewa, lat 31");
}
else if (woman == false && age < 18) 
{
    Console.WriteLine("Niepelnoletni men");
}
