// 4.- Contador de Palabras

using System.Text.RegularExpressions;

string text = "         un texto      que tiene     palabras    ";
int n=0;

//text = text.Trim();
text=Regex.Replace(text, @"\s+", " ").Trim();
var words = text.Split(' ');
n=words.Length;

Console.WriteLine("Numero de Palabras: " + n);