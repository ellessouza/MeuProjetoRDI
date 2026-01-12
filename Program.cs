
Console.Write("Digite qual tabuada você deseja ver (1 a 10): ");
        
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero >= 1 && numero <= 10)
            {
                Console.WriteLine($"\n--- Tabuada do {numero} ---");

                for (int j = 10; j >= 1; j--)
                {
                    Console.WriteLine($"{numero} x {j} = {numero * j}");
                }
            }
            else
            {
                Console.WriteLine("Erro: Por favor, insira um valor entre 1 e 10.");
            }
        }
        else
        {
            Console.WriteLine("Erro: Entrada inválida. Digite apenas números.");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
