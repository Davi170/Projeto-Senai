using Projeto_Senai.Model;

ExemploSenaiContext context = new ExemploSenaiContext();
while (true)
{
  Console.WriteLine("O que deseja fazer? 1 - Logar ou 2 - Registrar ou 3 - Sair");
  string num = Console.ReadLine();
  if (num == "1")
  {
     Console.WriteLine("Digite seu nome:");
     string nome = Console.ReadLine();

     Console.WriteLine("Digite a sua Senha:");
     string Senha = Console.ReadLine();


     Usuario expectedUser = null;
   foreach (Usuario usuario in db.Usuarios)
   {
     {
        expectedUser = usuario;
     }
   }
     if (expectedUser == null)
     {
        Console.WriteLine("Não existe usuário com esse nome");
        Console.ReadKey(true);
        Console.Clear();
     }
  }
  else if (num == "2")
  {
     Usuario usuario = new Usuario();

     Console.WriteLine("Digite seu nome:");
     usuario.Nome = Console.ReadLine();

     Console.WriteLine("Digite a sua Senha:");
     usuario.Nome = Console.ReadLine();
  }
  else if (num == "3")
  {
     break;
  }
  else
  {
     Console.Clear();
     Console.WriteLine("Operação Invalida");
  }

}