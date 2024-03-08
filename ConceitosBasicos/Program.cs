using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Xml.Serialization;

Console.WriteLine("Informe seu peso: ");
int peso = int.Parse(Console.ReadLine());
Console.WriteLine("Informe sua altura: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / (altura *altura);

Console.WriteLine($"seu peso: {peso}\n sua altura: {altura}\n seu imc: {imc}" );

string status = string.Empty;

if (imc <= 16.9);
status = "muito abaixo do peso";

