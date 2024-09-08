using DesafioFundamentos.Models;

decimal precoInicial, precoHora;
bool resultadoConversao;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
do {
    Console.Write("Digite o preço inicial: ");
    resultadoConversao = decimal.TryParse(Console.ReadLine(), out precoInicial);

    if(!resultadoConversao) Console.WriteLine("\nValor inválido!\n");

} while(!resultadoConversao);

do {
    Console.Write("Digite o preço por hora: ");
    resultadoConversao = decimal.TryParse(Console.ReadLine(), out precoHora);

    if(!resultadoConversao) Console.WriteLine("\nValor inválido!\n");
    
} while(!resultadoConversao);

Estacionamento estacionamento = new(precoInicial, precoHora);
int opcao;

do {
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículo");
    Console.WriteLine("4 - Encerrar");

    resultadoConversao = int.TryParse(Console.ReadLine(), out opcao);
    if(!resultadoConversao) opcao = 0;

    switch(opcao) {
        
        case 1: 
            estacionamento.AdicionarVeiculo();
            break;

        case 2:
            estacionamento.RemoverVeiculo();
            break;

        case 3:
            estacionamento.ListarVeiculos();
            break;

        case 4:
            Console.WriteLine("Encerrando...");
            break;

        default:
            Console.WriteLine("\nOpção Inválida!\n");
            break;
    }

} while(opcao != 4);

