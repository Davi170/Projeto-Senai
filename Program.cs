using System.Collections.Generic;
using System;

List<string> Nomes = new List<string>();
Nomes.Add("Davi");
Nomes.Add("Pedro");
Nomes.Add("Paulo");
Nomes.Add("Marcio");
Nomes.Add("Frederico");
Nomes.Add("Amiutom");
Nomes.Add("Jefersom");
Nomes.Add("Carlos");
Nomes.Add("Felipe");
Nomes.Add("Neymar");
Nomes.Add("Jhosef");
Nomes.Add("Fernado");
Nomes.Add("Mauricio");
Nomes.Add("Jao");
Nomes.Add("Marcos");

List<string> SobreN = new List<string>();
SobreN.Add("Sousa");
SobreN.Add("Silva");
SobreN.Add("Vieira");
SobreN.Add("Lopes");
SobreN.Add("Mendes");
SobreN.Add("Machado");
SobreN.Add("Jasmin");
SobreN.Add("Peres");
SobreN.Add("Santos");
SobreN.Add("Carvalho");
SobreN.Add("Rodrgues");
SobreN.Add("Gomes");
SobreN.Add("Fereira");
SobreN.Add("Ribas");
SobreN.Add("Macedo");

List<string> Coisas = new List<string>();
Coisas.Add("Telhas");
Coisas.Add("Celulares");
Coisas.Add("Teclados");
Coisas.Add("Balas");
Coisas.Add("Pulseira");
Coisas.Add("Garrafas");
Coisas.Add("Cintos");
Coisas.Add("Fones");
Coisas.Add("cabos");
Coisas.Add("Cabos sem fios");
Coisas.Add("Telas");
Coisas.Add("Lacinhos");
Coisas.Add("Sapatos");
Coisas.Add("Mascaras");
Coisas.Add("Facas de Dois Gumes");

List<string> Adj = new List<string>();
Adj.Add("Gostoso");
Adj.Add("Masculo");
Adj.Add("Fracasado");
Adj.Add("Fortes");
Adj.Add("Cachorra");
Adj.Add("Formosos");
Adj.Add("Feia");
Adj.Add("Encantador");
Adj.Add("Pequenos");
Adj.Add("Perfeito");
Adj.Add("Obeso");
Adj.Add("Bonitos");
Adj.Add("Extrovertido");
Adj.Add("Elegante");
Adj.Add("Generoso");
List<string> Caracteres = new List<string>();

Caracteres.Add("h");
Caracteres.Add("e");
Caracteres.Add("t");
Caracteres.Add("e");
Caracteres.Add("r");
Caracteres.Add("o");
Caracteres.Add("g");
Caracteres.Add("e");
Caracteres.Add("n");
Caracteres.Add("e");
Caracteres.Add("i");
Caracteres.Add("d");
Caracteres.Add("a");
Caracteres.Add("d");
Caracteres.Add("e");
Console.WriteLine(Nomes);

Random rnd = new Random();

int NMrnd = rnd.Next(Nomes.Count);
int SNMrnd = rnd.Next(SobreN.Count);
int ADJrnd = rnd.Next(Adj.Count);
int COIrnd = rnd.Next(Coisas.Count);

int Charnd1 = rnd.Next(Caracteres.Count);
int Charnd2 = rnd.Next(Caracteres.Count);
int Charnd3 = rnd.Next(Caracteres.Count);
int Charnd4 = rnd.Next(Caracteres.Count);


string senha = (Caracteres[Charnd1]) + (Caracteres[Charnd2]) + (Caracteres[Charnd3]) + (Caracteres[Charnd4]);



Console.WriteLine(Nomes[NMrnd]);
Console.WriteLine(SobreN[SNMrnd]);
Console.WriteLine(Adj[ADJrnd]);
Console.WriteLine(Coisas[COIrnd]);
Console.WriteLine(senha);Random rnd = new Random();