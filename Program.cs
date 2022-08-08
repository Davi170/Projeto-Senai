using System.Collections.Generic;
using System;

List<string> Nomes = new List<string>();
Nomes.Add("Davi");
Nomes.Add("Pedro");
Nomes.Add("Paulo");
Nomes.Add("Palamidas");
Nomes.Add("Fleymes");
Nomes.Add("Airon");
Nomes.Add("Kakeoin");
Nomes.Add("Pounareff");
Nomes.Add("Avdol");
Nomes.Add("Jotaro");
Nomes.Add("Jhosef");
Nomes.Add("Capitain");
Nomes.Add("Mauricio");
Nomes.Add("Jao");
Nomes.Add("Rimuro");

List<string> SobreN = new List<string>();
SobreN.Add("Monteiro");
SobreN.Add("Spercosk");
SobreN.Add("Vieira");
SobreN.Add("Sobala");
SobreN.Add("Bacia");
SobreN.Add("Antaro");
SobreN.Add("Jasmin");
SobreN.Add("Jambierre");
SobreN.Add("Muhamed");
SobreN.Add("Kujo");
SobreN.Add("Joestar");
SobreN.Add("Patria");
SobreN.Add("Souza");
SobreN.Add("Mago");
SobreN.Add("Tempest");

List<string> Coisas = new List<string>();
Coisas.Add("Telhas");
Coisas.Add("Celulares");
Coisas.Add("Teclados");
Coisas.Add("Balas");
Coisas.Add("Nargiles");
Coisas.Add("Consolos");
Coisas.Add("Cintos de castidades");
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
Adj.Add("Gordox");
Adj.Add("Puta");
Adj.Add("Cachorra");
Adj.Add("Linguicera");
Adj.Add("Feia");
Adj.Add("Gostosa");
Adj.Add("Peituda");
Adj.Add("Perfeito");
Adj.Add("Obeso");
Adj.Add("Pauzudo");
Adj.Add("Extrovertido");
Adj.Add("Maliciosa");
Adj.Add("Pererecuda");
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