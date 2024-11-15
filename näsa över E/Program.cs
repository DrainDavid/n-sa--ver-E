

// if(6 > 3) 
// {
// Console.WriteLine("Hello World");
// }


// string username = "";
// string password = "";


// while (!(username == "Kalleanka" && password == "12345"))
// {

//     username = Console.ReadLine();
//     password = Console.ReadLine();

//     if (username == "Kalleanka" && password == "12345")
//     {
//         Console.WriteLine("welcome");
//     }

//     else
//     {
//         Console.WriteLine("Wrong Username or pasword");
//     }


// }


// int antal = 0;
// while (antal <= 32)
// {
//     Console.WriteLine("Hello world");
//     antal++;
// }
// Console.ReadLine();


// int ja = 0;

// while (ja <= 5)
// {
// string tal = Console.ReadLine();
// int i = int.Parse(tal);

// if (i > 5)
// {
// Console.WriteLine("Högre en 5");
// }

// ja++;
// }


// while(!int.TryParse(Console.ReadLine(),out int result));



int r = 593;
string g = "";
int Gissa = 0;

while(!(Gissa == 593))
{

Console.WriteLine("Gissa numret din manga");

g = Console.ReadLine();
Gissa = int.Parse(g);

if (Gissa == r)
{
 Console.WriteLine("Du gissade rätt");
}

if (Gissa > r)
{
    Console.WriteLine("För högt");
}

if (Gissa < r)
{
    Console.WriteLine("För Lågt");
}





}
Console.ReadLine();