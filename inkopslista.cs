// jag har skapat listor till varor respektive pris.
List<string> varor = [];
List<int> pris = [];

// meddelandet för menyn
Console.WriteLine("Väkommen Till inköpslistan");
// bool är lagt till false så att den körs tills den blir klar 
bool klar = false;
// deklarerat totalpris
int totalPris = 0;
// while loopen som körs till det blir true 
while (!klar)
{
    Console.WriteLine(" Skriv in din vara: ");
    string vara = Console.ReadLine()!;

    Console.WriteLine(" Skriv in priset: ");
    // om priset inte är ett heltal så skickas meddelandet för att ange en siffra och den börjar om
    if (!int.TryParse(Console.ReadLine(), out int priset))
    {
    Console.WriteLine("Ange en siffra >:( ");
    continue;   

    }

    varor.Add(vara);
    pris.Add(priset);

// priset adderas till totalpriset
    totalPris +=priset;

// for loop för att skriva ut varor i listan och priserna i prislistan.
    for (int i = 0; i < varor.Count; i++)
    {
        Console.WriteLine($"{i+1}. {varor[i]} - {pris[i]} kr");

    }
    Console.WriteLine($"Totalt: {totalPris}");

    Console.Write("Ta bort något vara? JA/NEJ: ");
    string? taBortVara = Console.ReadLine()!.ToUpper();
    if (taBortVara =="JA")
    {
        Console.WriteLine("Ange nummer: ");
        string? num = Console.ReadLine();

        // duplicerat if satsen som visar varorlistan samt totala priset efter att man vill fortsätta 
        if (int.TryParse(num, out int inputAsNumber))
        {

            varor.RemoveAt(inputAsNumber - 1);
             for (int i = 0; i < varor.Count; i++)
    {
        Console.WriteLine($"{i+1}. {varor[i]} - {pris[i]} kr");

    }
    Console.WriteLine($"Totalt: {totalPris}");

        }

    }
// för att avsluta while loopen sätts klar till true om användaren trycker S 
    Console.WriteLine("För att avsluta tryck S. Annars Y: ");
    string avsluta = Console.ReadLine()!.ToLower();
    if (avsluta == "s")
    {
        klar = true;
    }
// console.clear() gör att displayen blir ren och att man kan fortsätta skriva in varor i ren console.
    Console.Clear();


}