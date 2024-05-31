string? frase;
Console.Write("Digite uma flase:");
frase = Console.ReadLine();

string? FraseComDislalia = frase?
.Replace("r", "l")
.Replace("R", "L");

Console.WriteLine(FraseComDislalia);