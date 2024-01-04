using System.Globalization;
using Aula_5.Models;


using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
       // Horas de uso de eletrônicos por dia e o número de refeições com carne:
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
        Console.WriteLine($"{nome}");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
  public double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
  {
    
    double km = quilometrosPorDia * 365 * 0.2;
    double hs = horasDeEletronicos * 0.1;
    double carne = refeicoesComCarne * 0.5;
    
    return km + hs + carne; 
    
  }

}

























//  // Pergunta ao usuário quantos jogos deseja adicionar:
//         int quantidadeJogos = int.Parse(Console.ReadLine());

//         // TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
       
//        string[] nomesJogos = new string[quantidadeJogos];  

//         // TODO: Crei um Loop para adicionar jogos conforme a quantidade especificada:
       
//        for(int i = 0; i < quantidadeJogos; i++)
//        {
//          AdicionarJogo(i, nomesJogos);
//        }

//         ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    

//     static void AdicionarJogo(int indice, string[] nomes)
//     {
//         // Entrada do nome do jogo
//         nomes[indice] = Console.ReadLine();
//     }

//     static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
//     {
//         string listaNomes = string.Join(", ", nomes);
//         Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {listaNomes} ao catalogo.");
//     }


























// string titulo;
// string descricao;
// string dataVencimento;

// titulo = Console.ReadLine();
// descricao = Console.ReadLine();

// if (descricao.Length > 50)
// {
//     Console.WriteLine("Descricao ultrapassa limite de caracteres.");
// }
// else
// {
//  dataVencimento = Console.ReadLine();
//  Console.WriteLine($"{titulo} ate {dataVencimento}");

// }




























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP","São Paulo");
// estados.Add("BA","Bahia");
// estados.Add("MG","Minas Gerais");

// foreach(var item in estados){

//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");

// }

// Console.WriteLine("----------------");


// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach(var item in estados){

//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");

// }

































// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha){

//     Console.WriteLine(item);
// }


// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}"); 


// foreach(int item in pilha){

//     Console.WriteLine(item);

// }























// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila){
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); 

// foreach(int item in fila){
//     Console.WriteLine(item);
// }





















// try{


// string[] linhas = File.ReadAllLines("Arquivos/arquivosLeitura.txt");

// foreach(string linha in linhas){
//     Console.WriteLine(linha);
// }

// }catch(Exception ex){

//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }





















// string dataString = "2022-04-17 18:00";

// DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
// CultureInfo.InvariantCulture, 
// DateTimeStyles.None, out DateTime data);

// Console.WriteLine(data);























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N3"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// double numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// double data = 14032005;
// Console.WriteLine(data.ToString("DD/MM/YYYY"));


























// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);




































// Pessoa p1 = new Pessoa("Leandro", "Stutz");
// Pessoa p2 = new Pessoa(nome:"Maria Vitoria", sobrenome:"Duarte");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
































// Pessoa p1 = new Pessoa();
// p1.Nome = "Leandro";
// p1.Sobrenome = "Stutz";
// p1.Idade = 18;
// p1.Apresentar();