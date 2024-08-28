using KlikkerSpill;

ClickerGame game = new ClickerGame();
CommandSet commands = new CommandSet(game);

while (true)
{
    Console.Clear();
    Console.WriteLine("Kommandoer:\r\n- SPACE = klikk(og få poeng)\r\n" +
        "- K = kjøp oppgradering øker poeng per klikk koster 10 poeng\r\n" +
        "- S = kjøp superoppgradering øker \'poeng per klikk\' for den vanlige oppgraderingen. koster 100 poeng\r\n" +
        "- X = avslutt applikasjonen");

    Console.WriteLine($"Du har {game.GetPoints()} poeng.");
    Console.WriteLine("Trykk tast for ønsket kommando.");
    var command = Console.ReadKey().KeyChar;
    commands.RunCommand(command);
}



