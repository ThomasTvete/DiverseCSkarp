
using Bossfight;


GameCharacter hero = new GameCharacter("Thomas", 100, 20, 40, false);
GameCharacter boss = new GameCharacter("Terje", 400, 0, 10, true);

int fight = 0;

Console.WriteLine(@" __  __              __          __                                                     
/\ \/\ \            /\ \        /\ \                                                    
\ \ \/'/'    ___    \_\ \     __\ \ \/'\      __      ___ ___   _____      __    ___    
 \ \ , <    / __`\  /'_` \  /'__`\ \ , <    /'__`\  /' __` __`\/\ '__`\  /'__`\/' _ `\  
  \ \ \\`\ /\ \L\ \/\ \L\ \/\  __/\ \ \\`\ /\ \L\.\_/\ \/\ \/\ \ \ \L\ \/\  __//\ \/\ \ 
   \ \_\ \_\ \____/\ \___,_\ \____\\ \_\ \_\ \__/.\_\ \_\ \_\ \_\ \ ,__/\ \____\ \_\ \_\
    \/_/\/_/\/___/  \/__,_ /\/____/ \/_/\/_/\/__/\/_/\/_/\/_/\/_/\ \ \/  \/____/\/_/\/_/
                                                                  \ \_\                 
                                                                   \/_/");
Console.WriteLine("Velkommen til Kodekampen!");
Console.WriteLine($"Underdogen {hero.Name} mot kodemiljøets egen Goliat, {boss.Name}!");
Console.ReadKey(true);

while (hero.Health > 0 && boss.Health > 0)
{
    int turn = fight % 2;
    
    if(turn == 0) hero.Engage(boss);
    else boss.Engage(hero);
    fight++;
}
if(hero.Health <= 0) Console.WriteLine($"{boss.Name} vant!");
else if (boss.Health <= 0) Console.WriteLine($"{hero.Name} vant!");
Console.ReadKey(true);
