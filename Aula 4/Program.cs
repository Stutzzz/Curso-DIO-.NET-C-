using Aula_4.Models;


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

























// Console.WriteLine("Percoorrendo o Array com o FOR");

// for(int i = 0; i < listaString.Count;i++){
//     Console.WriteLine($"Posição N° {i} = {listaString[i]}");
// }

// Console.WriteLine("Percoorrendo o Array com o FOREACH");

// int contador = 0;
// foreach(string item in listaString){
//     Console.WriteLine($"Posição N° {contador} = {item}");
//     contador++;
// }































// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;


// int[] arrayDobrados = new int [arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayDobrados, arrayInteiros.Length);



// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// Console.WriteLine("Percoorrendo o Array com o FOR");
// for(int i = 0; i < arrayInteiros.Length; i++ ){
//     Console.WriteLine($"Posição N° {i} = {arrayInteiros[i]}");
// }

// Console.WriteLine(arrayInteiros.Length);
















// Console.WriteLine("Percoorrendo o Array com o FOREACH");
// foreach(int valor in arrayInteiros){
//     Console.WriteLine(valor);

// }






























// string opcao;
// bool exibir = true;

// while(exibir){

//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao){

//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibir = false;
//             break;
//         default:
//             Console.WriteLine("Opção invalida");
//             break;
//     }
// }




























// int soma = 0, numero = 0;


// do{
//     Console.WriteLine("Digite um número: (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;

// }while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");




























// int numero = 5;
// int contador = 0;
// while(contador <=10){
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }























// int numero = 10;


// for(int contador = 0; contador <= 10; contador++){

//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");

// }













//Calculadora calc = new Calculadora();

// calc.Somar(10,30);
// calc.Subtrair(10,30);
// calc.Multiplicar(10,30);
// calc.Dividir(10,30);
// calc.Potencia(10,30);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);
