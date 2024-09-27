// ***** Variáveis *****
string nome = "Ronaldo Domingues"; // Quando se tratar de uma cadeia de caracteres eles devem estar entre aspas dupla ("")
Console.WriteLine(nome);

int idade = 38;
Console.WriteLine(idade);

double valorDouble = 200.99;
Console.WriteLine(valorDouble);

decimal valorDecimal = 200.99m; // Por padrão o C# entende valores como sendo do tipo double, para informar que se trata de um decimal é necessário adicionar m logo após o valor
Console.WriteLine(valorDecimal);

float valorFloat = 200.99f; // Por padrão o C# entende valores como sendo do tipo double, para informar que se trata de um decimal é necessário adicionar f logo após o valor
Console.WriteLine(valorFloat); 

char flag = 'y'; // Quando se tratar de um único caracter ele deve estar entre aspas simples ('')
Console.WriteLine(flag);

bool ativo = true; // Retorno de um booleano pode ser true ou false
Console.WriteLine(ativo); 

var idadeNova = 39; // Tipo genérico, assume automáticamente o tipo do valor atribuído a variável
Console.WriteLine(idadeNova); 

// ***** Constantes *****
const string descricao = "Curso CSHARP"; // Não permite alteração do valor atribuído posteriormente
Console.WriteLine(descricao);

// ***** Comentários *****

// Para comentários em uma única linha

/*
  Para comentários em 
  multiplas linhas
*/

// ***** Operadores artitméticos *****
var valor01 = 2;
var valor02 = 2;

var soma = valor01 + valor02;
Console.WriteLine(soma);

var subtracao = valor01 - valor02;
Console.WriteLine(subtracao);

var multiplicacao = valor01 * valor02;
Console.WriteLine(multiplicacao);

var divisao = valor01 / valor02;
Console.WriteLine(divisao);

// ***** Operadores relacionais *****
var igual = valor01 == valor02;
Console.WriteLine(igual);

var maior = valor01 > valor02;
Console.WriteLine(maior);

var menor = valor01 < valor02;
Console.WriteLine(menor);

var maiorIgual = valor01 >= valor02;
Console.WriteLine(maiorIgual);

var menorIgual = valor01 <= valor02;
Console.WriteLine(menorIgual);

var diferente = valor01 != valor02;
Console.WriteLine(diferente);

// ***** Operadores lógicos *****
var and = 10 > 2 && 2 > 1;
Console.WriteLine(and);

var or = 10 > 2 || 2 < 1;
Console.WriteLine(or);

var not = !(3 > 2);
Console.WriteLine(not);

// ***** Operador ternário *****
var funcionario = false;
var ternario = funcionario ? "Funcionário Ativo" : "Funcionário Inativo";
Console.WriteLine(ternario);













