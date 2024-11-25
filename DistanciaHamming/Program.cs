//3.- Distancia de Hamming

string text1 = "patitosw";
string text2 = "paratosa";

int distance = 0;

if (text1.Length != text2.Length)
    throw new Exception("Longitudes Distintas");

for(int i = 0; i < text1.Length; i++)
{
    if (text1[i] != text2[i]) distance++;
}

Console.WriteLine("Distancia es de: " + distance);