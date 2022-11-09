using DIO_dotNetDeveloperIntermediario.Models;
using System.Globalization;
using Newtonsoft.Json;
Console.OutputEncoding = System.Text.Encoding.UTF8;

// // ############################################### MÉTODO DE EXTENSÃO
// int numero = 15;
// bool par = false;
// par = numero.EhPar();
// Console.WriteLine($"O número {numero} é " + (par ? "par" : "impar"));

// // ############################################### CLASSE GENÉRICA
// MeuArray<int> arrayInteiro = new MeuArray<int>();
// arrayInteiro.AdicionarElementoArray(30);
// Console.WriteLine(arrayInteiro[0]);
// MeuArray<string> arrayString = new MeuArray<string>();
// arrayString.AdicionarElementoArray("ArrayGenerico");
// Console.WriteLine(arrayInteiro[0]);

// // ############################################### VARIÁVEL DINÂMICA
// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
// variavelDinamica = true;
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// ############################################### DESERIALIZANDO LISTA COM TIPO ANÔNIMO
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });
// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto {venda.Produto}, Preço: {venda.Preco}");
// }

// // ############################################### TIPOS ESPECIAIS - ANÔNIMO
// var tipoAnonimo = new { Nome = "Arthur", Sobrenome = "Galanti", Altura = 1.85 };
// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Altura: {tipoAnonimo.Altura}");

// // ############################################### TIPOS ESPECIAIS - NULL
// bool? desejaReceberEmail = null;
// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu optou por receber e-mail.");
// }

// ############################################### DESERIALIZANDO COM NEWTONJSON E TIPO NULLABLE
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id} " +
//                     $"\nProduto: {venda.Produto} " +
//                     $"\nPreço: {venda.Preco} " +
//                     $"\nData venda: {(venda.DataVenda).ToString("dd/MM/yyyy")} "
//                     + $"\n{(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }

// // ############################################### SERIALIZANDO COM NEWTONJSON
// List<Venda> listaVendas = new List<Venda>();
// Venda v1 = new Venda(1, "Material de escritório", 25.00M);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M);
// listaVendas.Add(v1);
// listaVendas.Add(v2);
// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", serializado);
// Console.WriteLine(serializado);

// // ############################################### IF TERNÁRIO
// int numero = 15;
// bool ehPar = false;
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));

// ***** IF CONVENCIONAL
// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }

// // ############################################### DESCONSTRUTOR
// Pessoa p1 = new Pessoa("Arthur", "Galanti");
// (string nome, string sobrenome) = p1;
// Console.WriteLine($"{nome} {sobrenome}");

// // ############################################### TUPLAS
// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); // DESCARDANDO INFROMAÇÃO COM _
// if (sucesso)
// {
//     Console.WriteLine("Quantidade de linhas do arquivo:");
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

// // ############################################### TUPLAS
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Arthur", "Galanti", 1.85M);
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Arthur", "Galanti", 1.85M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Arthur", "Galanti", 1.85M);
// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");

// // ############################################### DICTIONARY
// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");
// Console.WriteLine(estados["MG"]);
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// Console.WriteLine("*******************");
// estados.Remove("BA");
// estados["SP"] = "Novo valor";
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// string chave = "BA2";
// Console.WriteLine($"Verificando o elemento {chave}");
// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

// // ############################################### PILHAS
// Stack<int> pilha = new Stack<int>();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento {pilha.Pop()}");
// pilha.Push(20);
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// // ############################################### FILAS
// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
// fila.Enqueue(10);
// Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// // ############################################### EXCEÇÕES
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Pasta não encontrada. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("O bloco finally sempre é executado!");
// }

// // ############################################### MANIPULAÇÃO DE DATAS
// string dataString = "2022-04-20 18:00";
// bool sucesso = DateTime.TryParseExact(dataString,
//         "yyyy-MM-dd HH:mm",
//         CultureInfo.InvariantCulture,
//         DateTimeStyles.None,
//         out DateTime data2);
// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data2}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }
// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // dia/mes/ano hora:minuto
// Console.WriteLine(data.ToShortDateString()); // somente data
// Console.WriteLine(data.ToShortTimeString()); // somente hora

// // ############################################### MANIPULAÇÃO DE STRINGS
// decimal valorMonetario = 6541.40M;
// double porcentagem = .3421;
// int numero = 123456;
// Console.WriteLine(valorMonetario.ToString("C4", CultureInfo.CreateSpecificCulture("pt-BR"))); // C4 = Currency 4 casas decimais Return: R$ 6.541,4000
// Console.WriteLine(valorMonetario.ToString("N4", CultureInfo.CreateSpecificCulture("pt-BR"))); // N4 = Number 4 casas decimais Return: 6.541,4000
// Console.WriteLine(porcentagem.ToString("P")); // P = Percentage Return: 34,21%
// Console.WriteLine(numero.ToString("##-##-##")); // Formatação

// // ############################################### UTILIZANDO COLEÇÕES E MÉTODO CONSTRUTOR
// var p1 = new Pessoa(nome: "Arthur", sobrenome: "Galanti");
// var p2 = new Pessoa(nome: "André", sobrenome: "Galanti");
// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();