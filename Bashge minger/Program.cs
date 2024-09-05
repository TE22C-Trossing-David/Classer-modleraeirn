Moab moab1 = new Moab();
bool hasUsedAction = false;

int trackLength = 30;

Supermonkey sm1 = new Supermonkey();

int smCount = 0;

while (true)
{
    Console.Clear();

    Console.WriteLine("Press Enter to start Bloons Tower Defence 7");
    Console.ReadLine();

    Console.WriteLine("A MOAB is incomming!! You need to protect the village!\n");
    Console.WriteLine("Press E to buy a Supermonkey that will attack the MOAB\n");
    System.Console.WriteLine("After having bought a Supermonkey, Press enter and the MOAB will advance and the Super Monkey will attack the MOAB\n");

    Console.WriteLine("Press Enter to start to keep going");
    Console.ReadLine();
    Console.Clear();

    while (moab1.Hp >= 0 && moab1.DistanceTraveled <= trackLength)
    {
        hasUsedAction = false;
        while (hasUsedAction == false)
        {
            System.Console.WriteLine("E: Buy Super Monkey");
            System.Console.WriteLine("BLANK: End turn");
            string input = Console.ReadLine().ToLower();
            Console.Clear();

            if (input.StartsWith("e"))
            {
                smCount++;
                hasUsedAction = true;
                Console.WriteLine("You bought a Supermonkey");
                System.Console.WriteLine("You now have " + smCount + " Super Monkeys");

            }

            else if (input.StartsWith(""))
            {
                int totalSMDamage = SMDamage(sm1.Damage, sm1.AttackSpeed, smCount);
                moab1.Hp -= totalSMDamage;
                moab1.DistanceTraveled += moab1.Speed;
                System.Console.WriteLine("You delt " + totalSMDamage + " damage to the MOAB");
                System.Console.WriteLine("The MOAB now has " + moab1.Hp + " health left");
                System.Console.WriteLine("The MOAB has advanced " + moab1.DistanceTraveled + " Spaces out of " + trackLength + "\n");
                hasUsedAction = true;

            }

        }
    }

    if (moab1.Hp <= 0)
    {
        moab1.Hp = 0;
        System.Console.WriteLine("WOOWIEE!! YOU KILLED THE MOAB");
    }

    if (moab1.DistanceTraveled >= trackLength)
    {
        System.Console.WriteLine("The MOAB managed to sneak through your defences.");
    }

    System.Console.WriteLine("Click ENTER to play again");
    Console.ReadLine();


}

int SMDamage(int Damage, int AttackSpeed, int smCount)
{
    int smTotalDamage = Damage * AttackSpeed * smCount;
    return smTotalDamage;
}