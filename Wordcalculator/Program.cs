Console.Write("Skriv in din mening här :");

string input = Console.ReadLine();

string[] words = input.Split(' ');


int counter = 0;  

foreach (string word in words)
{
    counter++;
}

Console.WriteLine("Antalet ord :" + counter);
