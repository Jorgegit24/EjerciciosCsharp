// 1.- Invertir una cadena

string text = "pato";
string textresult = "";

/*for (int i = text.Length - 1; i>=0; i--)
{
    textresult += text[i];
}*/


char[]chars = text.ToCharArray();
Array.Reverse(chars);
textresult = new string(chars);



Console.WriteLine(textresult);