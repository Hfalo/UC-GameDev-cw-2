string heroName = "Eula Lawrence";
string heroElement = "Cryo";

string villianName = "Tartaglia";
string villianElement = "Hydro";

int Cryo = 100;
int Hydro = 50;

if (Cryo > Hydro)
{
    Console.WriteLine(heroName + " wins !");
}
else if (Cryo == Hydro)
{
    Console.WriteLine("No one wins, better luck next time");
}
else if (Cryo < Hydro)
{
    Console.WriteLine(villianName + " wins !");
}


// excersice 2

float Playerspeed = 5.5f;

Setspeed(2.5f);

void Setspeed(float speed)
{
    Console.WriteLine("old speed : " + Playerspeed);
    Playerspeed = speed;
    Console.WriteLine("new speed : " + Playerspeed);
}


