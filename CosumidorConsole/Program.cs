using CosumidorConsole;
using Flurl.Http;

string url = "https://localhost:7182/";

Item tarefa1 = new Item();
tarefa1.Id = 1;
tarefa1.Nome = "Pagar conta";
tarefa1.Finalizado = true;

Item tarefa2 = new Item();
tarefa2.Id = 2;
tarefa2.Nome = "Estudar";
tarefa2.Finalizado = false;

//Gerar uma tarefa
string endpoint = url + "api/TarefaItems";

//retarda a chama e esperar a nossa api estar no ar
Thread.Sleep(new TimeSpan(0, 0, 5));

//flurl
endpoint.PostJsonAsync(tarefa1);
endpoint.PostJsonAsync(tarefa2);
//Ler a lista

//Altera

//Ler a lista

//Deletar um item da lista

//Ler a lista

Console.WriteLine("Aperte Qualquer tecla para finalizar a aplicação");
Console.Read();