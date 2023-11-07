Dictionary<string, List<int>> historicoBandas = new Dictionary<string, List<int>>(); 

void opcoesMenu()
{

    //Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine(
        "\r\n█▀▄▀█ █▀▀ █▄░█ █░█   █▀▄ █▀▀   █▀█ █▀█ █▀▀ █▀█ █▀▀ █▀\r\n█░▀░█ ██▄ █░▀█ █▄█   █▄▀ ██▄   █▄█ █▀▀ █▄▄ █▄█ ██▄ ▄█");

    Console.WriteLine("\nDigite o número 1 para registrar uma banda.");
    Console.WriteLine("Digite o número 2 para mostrar todas as bandas registradas.");
    Console.WriteLine("Digite o número 3 para avaliar uma banda.");
    Console.WriteLine("Digite o número 4 para exibir a média das avaliações de uma banda.");
    Console.WriteLine("Digite o número 5 para fechar o programa e sair.");

    Console.Write("\nDigite a opção desejada --> ");
    string opcaoUser = Console.ReadLine()!;
    int opcaoUserNumber = int.Parse(opcaoUser)!;

    switch (opcaoUserNumber)
    {
        case 1:
            registraBanda();
            break;
        case 2:
            registroHistoricoBandas();
            break;
        case 3:
            avaliacaoBanda();
            break;
        case 4:
            mediaAvaliacao();
            break;
        case 5:
            fecharPrograma();
            break;
        default:
            opcaoMenuInvalida();
            break;
    }

    void registraBanda()
    {
        Console.Clear();
        Console.WriteLine("você selecionou a opção 1 : REGISTRAR UMA BANDA!");
        Console.Write("\nAgora, digite o nome da banda que você deseja registrar/cadastrar -->  ");
        string nomeDaBanda = Console.ReadLine()!;
        historicoBandas.Add(nomeDaBanda, new List<int>());
        Console.Write($"\nO nome da banda que você acabou de registrar foi : {nomeDaBanda}\n\n\n");

        Console.WriteLine("Tecle qualquer coisa para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        opcoesMenu();
    }

    void registroHistoricoBandas()
    {
        Console.Clear();
        Console.WriteLine("você selecionou a opção 2 : MOSTRAR TODAS AS BANDAS REGISTRADAS!");
        Console.WriteLine("\n\nLista de bandas registradas :");

        foreach (string banda in historicoBandas.Keys)
        {
            Console.WriteLine($"Banda registrada : {banda}");
        }

        Console.WriteLine("\n\nTecle qualquer coisa para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        opcoesMenu();
    }
    
    void avaliacaoBanda()
    {
        Console.Clear();
        Console.WriteLine("você seleciou a opção 3 : AVALIAR BANDA!");
        Console.Write("\n\nDigite o nome da banda que você deseja avaliar -->  ");
        string nomeDaBanda = Console.ReadLine()!;

        if (historicoBandas.ContainsKey(nomeDaBanda))
        {
            Console.WriteLine($"Qual a nota que você deseja avaliar a banda {nomeDaBanda}");
            int notaAvaliacaoBanda = int.Parse(Console.ReadLine()!);
            historicoBandas[nomeDaBanda].Add(notaAvaliacaoBanda);

            Console.WriteLine($"\n\nA nota {notaAvaliacaoBanda} foi salva para a banda {nomeDaBanda}");

            Console.WriteLine("\n\nTecle qualquer coisa para retornar ao menu");
            Console.ReadKey();
            Console.Clear();
            opcoesMenu();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada ou não foi registrada ainda.");
            Console.WriteLine("\n\nTecle qualquer coisa para retornar ao menu");
            Console.ReadKey();
            opcoesMenu();
        }
    }
    void mediaAvaliacao()
    {
        Console.Clear();

        Console.WriteLine("você selecionou a opção 4 : EXIBIR A MEDIA DE TODAS AS AVALIAÇÕES!");
        Console.Write("\n\nDigite o nome da banda que você deseja saber a média --> ");
        string nomeDaBanda = Console.ReadLine()!;

        if (historicoBandas.ContainsKey (nomeDaBanda))
        {
            List<int>notasDabanda = historicoBandas[nomeDaBanda];
            Console.WriteLine($"A média de notas da banda {nomeDaBanda} é {notasDabanda.Average()}");
            Console.WriteLine("\n\nTecle qualquer coisa para retornar ao menu");
            Console.ReadKey();
            Console.Clear();
            opcoesMenu();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada ou não foi registrada ainda");
            Console.WriteLine("\n\nTecle qualquer coisa para retornar ao menu");
            Console.ReadKey();
            Console.Clear(); 
            opcoesMenu();
        }
    }
    
    void fecharPrograma()
    {
        Console.Clear();
        Console.WriteLine("\r\n█░█ █▀█ █▀▀ █▀▀   █▀ █▀▀ █░░ █▀▀ █▀▀ █ █▀█ █▄░█ █▀█ █░█   █▀ ▄▀█ █ █▀█ ░  \r\n▀▄▀ █▄█ █▄▄ ██▄   ▄█ ██▄ █▄▄ ██▄ █▄▄ █ █▄█ █░▀█ █▄█ █▄█   ▄█ █▀█ █ █▀▄ ▄  \r\n\r\n▀█▀ █▀▀ █▀▀ █░░ █▀▀   █▀█ █░█ ▄▀█ █░░ █▀█ █░█ █▀▀ █▀█   █▀▀ █▀█ █ █▀ ▄▀█   █▀█ ▄▀█ █▀█ ▄▀█   █▀▀ █▀▀ █▀▀ █░█ ▄▀█ █▀█\r\n░█░ ██▄ █▄▄ █▄▄ ██▄   ▀▀█ █▄█ █▀█ █▄▄ ▀▀█ █▄█ ██▄ █▀▄   █▄▄ █▄█ █ ▄█ █▀█   █▀▀ █▀█ █▀▄ █▀█   █▀░ ██▄ █▄▄ █▀█ █▀█ █▀▄\r\n\r\n█▀█   █▀█ █▀█ █▀█ █▀▀ █▀█ ▄▀█ █▀▄▀█ ▄▀█\r\n█▄█   █▀▀ █▀▄ █▄█ █▄█ █▀▄ █▀█ █░▀░█ █▀█");
        
    }

    void opcaoMenuInvalida()
    {
        Console.WriteLine("opção digitada invalida, voltando ao menu em 3,2,1...");
        Thread.Sleep(2000);
        Console.Clear();
        opcoesMenu();
    }
}


 
opcoesMenu();