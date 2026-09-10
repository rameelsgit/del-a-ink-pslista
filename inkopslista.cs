// jag har skapat listor till varor respektive pris.
List<string> varor = [];
List<int> pris = [];

// meddelandet för menyn
Console.WriteLine("Väkommen Till inköpslistan");
// bool är lagt till false så att den körs tills den blir klar 
bool klar = false;

// while loopen som körs till det blir true 
while (!klar)
{
    Console.WriteLine(" Skriv in din vara: ");
    string vara = Console.ReadLine()!;

    Console.WriteLine("Skriv in priset: ");
    int priset = int.Parse(Console.ReadLine()!);

    varor.Add(vara);
    pris.Add(priset);
    // foreach som skriver ut användarens input av saker i varor och kostnad i psris
    int counter = 1;
    foreach (string saker in varor)
    {
        foreach(int kostnad in pris)
        {
                Console.WriteLine($"{counter}. {saker} - {kostnad} kr");

        }
        counter++;
    }
}