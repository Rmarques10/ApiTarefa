using CosumidorConsole;
using Flurl.Http;

string url = "https://localhost:7182/";

Console.WriteLine("Vamos incluir");

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

//flurl
await endpoint.PostJsonAsync(tarefa1);
await endpoint.PostJsonAsync(tarefa2);


//Ler a lista
IEnumerable<Item> listaTarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();

foreach (var item in listaTarefas)
{
    Console.WriteLine($"A Tarefa: {item.Nome} está {item.Finalizado}");
}


//Altera
Console.WriteLine("Vamos Alterar, digite um ID: ");

int id = Convert.ToInt32(Console.ReadLine());
string endpointAlterar = url + $"api/TarefaItems/{id}";

Item tarefa3 = new Item();
tarefa3.Id = 1;
tarefa3.Nome = "Estudar alterar";
tarefa3.Finalizado = true;

await endpointAlterar.PutJsonAsync(tarefa3);

//Ler a lista
Console.WriteLine();

listaTarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();

foreach (var item in listaTarefas)
{
    Console.WriteLine($"A Tarefa: {item.Nome} está {item.Finalizado}");
}

//Deletar um item da lista

string endpointDeletar = url + $"api/TarefaItems/2";
await endpointDeletar.DeleteAsync();

//Ler a lista
Console.WriteLine();
Console.WriteLine("Vamos deletar");
listaTarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();

foreach (var item in listaTarefas)
{
    Console.WriteLine($"A Tarefa: {item.Nome} está {item.Finalizado}");
}

Console.WriteLine("Aperte Qualquer tecla para finalizar a aplicação");
Console.Read();