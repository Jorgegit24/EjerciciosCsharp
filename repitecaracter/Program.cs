// 2.- Cuantas veces se repite un caracter

string text = "vdsfadflibafnisdnfaknodasdñmfaddñodfibaujkbasjjd";
char character = 'a';

int n = 0;

/*foreach (var c in text) 
{

    if (c == character)
        n++;
}*/

n = text.Where(c => c == character).Count();

Console.WriteLine($"se repite la letra {character} {n} veces");