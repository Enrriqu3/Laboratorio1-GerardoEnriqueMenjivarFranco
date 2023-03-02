using Laboratorio1__GerardoEnriqueMenjivarFranco.Entidades;
using Laboratorio1__GerardoEnriqueMenjivarFranco.Negocio;

Persona persona = new Persona();
ClsPersona edad = new ClsPersona();

Console.WriteLine("Ingrese su nombre");
String Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
string Edad = Console.ReadLine();
int edadd = Convert.ToInt32(Edad);
Console.WriteLine("Ingrese su sexo H(Hombre), M(Mujer)");
String Sexo = Console.ReadLine();
Console.WriteLine("Ingrese su peso");
string Peso = Console.ReadLine();
int pesoo = Convert.ToInt32(Peso);
Console.WriteLine("Ingrese su altura");
String Altura = Console.ReadLine();
double Altu = Convert.ToDouble(Altura);

persona.Altura = Altu;
persona.Nombre = Nombre;
persona.Peso = pesoo;
persona.Edad = edadd;

String Resultado = edad.calcularIMC(persona);
Console.WriteLine(Resultado);

String Result = edad.EsMayorDeEdad(persona);
Console.WriteLine(Result);






