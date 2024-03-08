using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Xml.Serialization;

Console.WriteLine("Informe seu peso: ");
int peso = int.Parse(Console.ReadLine());
Console.WriteLine("Informe sua altura: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / (altura * altura);

Console.WriteLine($"seu peso: {peso}\n sua altura: {altura}\n seu imc: {imc:f4}");

string status = string.Empty;

if (imc <= 16.9)
    status = "muito abaixo do peso";
else if (imc <= 17)
    status = "abaixo do peso";
else if (imc <= 18.5)
    status = "peso normal";
else if (imc <= 25)
    status = "acima do peso";
else if (imc <= 30)
    status = "obesidade grau 1";
else if (imc <= 35)
    status = "obesidade grau 2";
else if (imc <= 40)
    status = "obesidade grau 3";

Console.WriteLine(status);