List<Cores> lista = new List<Cores>(); // Criando uma lista do enum
string corEspera;

Console.WriteLine("\t\t\tLISTA DE ESPERA DO HOSPITAL\n");

do
{
    Console.Write("Informe a cor (stop para parar): ");
    corEspera = Console.ReadLine().ToUpper(); 

    if (corEspera == "STOP")
    {
        break;
    }
    else if (corEspera.Equals("VERMELHO") || corEspera.Equals("VM"))
    {
        lista.Add(Cores.VERMELHO); // Adicionando a cor vermelha na lista
    }
    else if (corEspera.Equals("AMARELO") || corEspera.Equals("AM"))
    {
        lista.Add(Cores.AMARELO); // Adicionando a cor amarela na lista
    }
    else if (corEspera.Equals("VERDE") || corEspera.Equals("VR"))
    {
        lista.Add(Cores.VERDE); // Adicionando a cor verde na lista
    }
    else if (corEspera.Equals("AZUL") || corEspera.Equals("AZ"))
    {
        lista.Add(Cores.AZUL); // Adicionando a cor azul na lista
    }

} while (true);

lista.Sort(); // Ordenando a lista
Console.Write("\nPrioridade de cores: ");

foreach (Cores cor in lista) {
    Console.Write(cor + " "); // Mostrando os valores da lista
}

enum Cores { // Atribuindo os valores do enum e a prioridade das cores
    VERMELHO = 0,
    AMARELO = 1,
    VERDE = 2,
    AZUL = 3,
}



