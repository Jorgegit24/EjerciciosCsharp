// 5.- Contar numeros

using System.Text.RegularExpressions;

String text = "asdsd5789ad57sd505sa87d14626834712798sadasd";
//Contar las letras
//string pattern = @"[a-z]" ;
//Contar los numeros
string pattern = @"[7]";

var regex = new Regex(pattern) ;
int n = regex.Matches(text).Count() ;

Console.WriteLine("cantidad: " + n) ;
