bool Woman = true;
int Age = 18;
string name = "Ewa";

if (Woman == true && Age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && Age == 31)
{
    Console.WriteLine("Ewa, lat 31");
}
else if (Woman == false && Age < 18) 
{
    Console.WriteLine("Niepelnoletni men");
}
