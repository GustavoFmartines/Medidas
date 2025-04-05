        float Km;
        int cm;
        int metros;

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.BackgroundColor = ConsoleColor.Cyan;

Console.WriteLine("--- Equivalência de Medidas --- ");

    Console.ResetColor();


Console.Write(@"
Entre com a medida (em metros): ");
    metros = Convert.ToInt32(Console.ReadLine()!);


        Km = metros / 1000.0f;
        cm = metros * 100;

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.BackgroundColor = ConsoleColor.Cyan;

Console.WriteLine(@"
--- Equivalencia ---");

    Console.ResetColor();

Console.WriteLine($"Metros: {metros}m");
Console.WriteLine($"Centímetros: {cm}cm");
Console.WriteLine($"Quilômetros: {Km}Km");
