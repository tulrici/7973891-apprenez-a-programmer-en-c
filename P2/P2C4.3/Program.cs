using P2C4._3;

try
{
    List<int> temperaturesEnregistreDegresCelcius = new List<int>();

    foreach (string stringRepresentationTemperature in args)
    {
        int temperature = int.Parse(stringRepresentationTemperature);
        temperaturesEnregistreDegresCelcius.Add(temperature);
    }

    int moyenneTemperature = MathSimple.CalculMoyenne(temperaturesEnregistreDegresCelcius);
    Console.WriteLine("La température moyenne est " + moyenneTemperature);
}
catch (FormatException)
{
    Console.WriteLine("C'est pas le bon format.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Ah non ! On ne divise pas par zéro ici.");
}
catch (Exception)
{
    Console.WriteLine("Mais enfin... Faut mettre des entiers numériques en arguments !");
}
