using SistemaDeHospedagem.models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = [];

Pessoa p1 = new(nome: "Hóspede 1");
Pessoa p2 = new(nome: "Hóspede 2");
Pessoa p3 = new(nome: "Hóspede 3");
Pessoa p4 = new(nome: "Hóspede 4");
Pessoa p5 = new(nome: "Hóspede 5");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite1 = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite suite2 = new(tipoSuite: "Comum", capacidade: 4, valorDiaria: 20);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva1 = new(diasReservados: 5);
reserva1.CadastrarSuite(suite1);
reserva1.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva1.CalcularValorDiaria()}");

// Cadastra na lista de hóspedes
hospedes.Add(p3);
hospedes.Add(p4);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva2 = new(diasReservados: 10);
reserva2.CadastrarSuite(suite2);
reserva2.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva2.CalcularValorDiaria()}");

// Cria uma nova reserva, passando a suíte e os hóspedes
try {
    Reserva reserva3 = new(diasReservados: 1);
    reserva1.CadastrarSuite(suite1);
    reserva1.CadastrarHospedes(hospedes);
    
} catch(Exception e) {
    Console.WriteLine("Erro ao criar reserva: " + e.Message);
}