using System;
using System.Threading;

class Program
{
    static Random random = new Random();
    // this remembers which sword i have during this playthrough
    static bool hasRuneblade = false;
    // change this to true when testing so the story does not keep waiting
    static bool fastText = false;
    static bool metRebel = false;
    static bool knightsDefeated = false;
    static bool enteredTower = false;
    static bool mageDefeated = false;
    static bool kingDefeated = false;

    static void Main()
    {
        // the game starts here and follows the story in order
        // these flags are kept while the game is open, not saved to a file
        say("welcome");


        say("========================");
        say("   the last runeblade");
        say("========================");

        say("1 = normal story speed");
        say("2 = fast text for testing or replaying");
        fastText = readChoice(2) == 2;
        pause(4000);
        Console.Clear();

        Console.Write("enter your name: ");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            name = "traveller";
        }

        say("welcome " + name, 1500);

        Console.Clear();

        say("you sprint across a rocky mountain path.", 2000);

        say("something is chasing you.", 1800);

        say("you look back for only a second.", 1800);

        say("your foot slips.", 1500);

        say("you fall over the edge of the mountain.", 2500);

        Console.Clear();

        say("...", 1500);

        say("you wake up inside a dark cave beside a dying fire.", 2200);

        say("a cloaked figure turns the corner.", 1800);

        say("\"so, you're awake...\"", 1800);

        say("you try to stand, but your legs give out.", 1800);

        say("\"don't. your treatment isn't finished.\"", 2000);

        say("\"that was quite a fall. you're lucky i found you.\"", 2200);

        say("the figure removes their hood, revealing an old, withered woman.", 2200);

        say("she begins treating your wounds with herbs and strange liquids.", 2200);

        say("\"the kingdom isn't safe anymore. not under our new 'king'.\"", 2400);

        say("she places an old sword beside you.", 1800);

        say("\"being saved by a witch comes with a price.\"", 2200);

        say("\"my magic is keeping you alive. do what i ask, or it won't for long.\"", 2500);

        say(name + ": what do you want?", 1800);

        say("\"find the king. end his rule.\"", 2200);

        say(name + ": with this?", 1500);

        say("you look at the old sword.", 1800);

        say("the witch shakes her head.", 1500);

        say("\"there is another weapon.\"", 1800);

        say("\"the runeblade.\"", 2000);

        say("\"an old weapon people have mostly forgotten.\"", 2000);

        say("\"find it. you'll need it if you want any chance against the king.\"", 2400);

        Console.Clear();

        say("you received: old sword", 1800);

        say("\"before you leave, you should probably remember how to fight.\"", 2000);

        say("\"your sword and magic both deal damage.\"", 1800);

        say("\"different enemies have different weaknesses.\"", 2000);

        say("\"if you block, you'll have more time to watch how they fight.\"", 2200);

        say("\"you might notice what they're weak to.\"", 2200);

        say("\"try not to die.\"", 1800);

        say("a strange noise comes from the entrance of the cave...", 2000);

        say("a goblin runs inside!", 1800);

        say("\"well... good timing.\"", 1500);
        // health starts at 20 for each fight so the encounters stay simple
        say("you recover to 20 health before each fight.");
        say("if you lose, you can retry that fight without restarting the story.");
        bool won = combatStart("goblin");


        pause(1800);
        Console.Clear();

        say("\"not bad.\"", 1500);

        say("\"greyhaven is a few miles east.\"", 2000);

        say("\"someone there might know more about your runeblade.\"", 2200);

        say("you take the old sword and leave the cave.", 2200);

        Console.Clear();

        say("========================");
        say("    road to greyhaven");
        say("========================", 1800);

        say("the mountain path slowly turns into an old road.", 2000);

        say("you continue towards greyhaven.", 1800);

        won = roadEncounter();

        pause(2000);
        Console.Clear();

        say("eventually, stone walls appear in the distance.", 2000);

        say("you have reached greyhaven.", 2200);

        Console.Clear();

        say("========================");
        say("       greyhaven");
        say("========================", 2000);

        say("greyhaven is a small town surrounded by old stone walls.", 2200);

        say("people fill the streets.", 1800);

        say("to your left is an old inn.", 1800);

        say("to your right is a busy market.", 1800);

        // 0 is not a valid answer, so the menu keeps asking until i choose 1 or 2
        int greyhavenChoice = 0;

        while (greyhavenChoice != 1 && greyhavenChoice != 2)
        {
            Console.WriteLine();
            say("1 = go left to the inn");
            say("2 = go right to the market");

            Console.Write("choose: ");

            try
            {
                greyhavenChoice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                greyhavenChoice = 0;
            }
        }

        if (greyhavenChoice == 1)
        {
            greyhavenInn(name);
        }
        else
        {
            greyhavenMarket(name);
        }

        Console.Clear();

        say("you now know where to look.", 1800);

        say("the old ruins north of greyhaven.", 2200);

        say("you leave through the northern gate.", 2000);

        Console.Clear();

        say("a man in heavy armour stands in the middle of the road.", 2000);

        say("the king's crest is painted across his shield.", 2000);

        say("\"stop.\"", 1400);

        say("\"by order of the king, travellers using this road must pay.\"", 2200);

        say(name + ": pay what?", 1500);

        say("\"whatever you have.\"", 1800);

        say(name + ": i'm not giving you anything.", 1800);

        say("the knight draws his sword.", 1800);

        say("\"then i'll take it.\"", 1800);

        won = combatStart("corrupt knight");


        pause(1800);

        say("the knight falls.", 1600);

        say("you look at the king's crest on his armour.", 1800);

        say("the witch wasn't lying about this kingdom.", 2200);

        Console.Clear();

        say("========================");
        say("       the ruins");
        say("========================", 2000);

        say("you follow the road until the trees begin to disappear.", 2200);

        say("broken stone buildings rise from the ground ahead.", 2200);

        say("you have reached the ruins.", 1800);

        say("you step through what remains of an old doorway.", 1800);

        say("bones are scattered across the floor.", 1800);

        say("one of the piles begins to move.", 1800);

        say("a skeleton pulls itself together.", 1800);

        won = combatStart("skeleton");


        pause(1800);

        say("the skeleton falls apart.", 1600);

        say("you continue deeper into the ruins.", 2000);

        say("eventually you find a staircase leading underground.", 2200);

        say("cold air rises from below.", 1800);

        say("you begin walking down.", 2000);

        Console.Clear();

        say("at the bottom is a huge stone door.", 2000);

        say("you push it open.", 2200);

        say("a massive room is revealed.", 1800);

        say("stone statues line both walls.", 2200);

        say("knights, warriors and creatures carved from dark stone.", 2200);

        say("at the centre of the room is a pedestal.", 2000);

        say("a huge greatsword is buried inside it.", 2200);

        say("faint blue markings glow across the blade.", 2200);

        say(name + ": that has to be it...", 2000);

        say("you slowly approach the runeblade.", 2200);

        say("thud.", 1200);

        say("you stop.", 1400);

        say("stone cracks behind the pedestal.", 2000);

        say("the largest statue in the room begins to move.", 2200);

        say("dust falls from its shoulders.", 1800);

        say("its eyes begin glowing.", 1800);

        say("the stone guardian pulls a giant weapon from the ground.", 2200);

        say("========================");
        say("    guardian golem");
        say("========================", 1800);

        golemFirstPhase();

        Console.Clear();

        say("the golem hits you again.", 1800);

        say("your sword flies from your hand.", 1800);

        say("you crash onto the stone floor.", 2000);

        say("you try to stand.", 1600);

        say("you can't.", 1600);

        say("the runeblade is only a few feet away.", 2000);

        say("you begin dragging yourself towards it.", 2000);

        say("the golem walks closer.", 1700);

        say("thud.", 1000);

        say("thud.", 1000);

        say("your hand reaches towards the glowing blade.", 2000);

        say("the golem raises its weapon above you.", 2200);

        say("you grab the runeblade.", 1600);

        say("the golem swings.", 1200);

        say("clang!", 1200);

        say("you raise the runeblade just in time.", 1800);

        say("the golem's weapon shatters against the blade.", 2400);

        say("pieces of stone explode across the room.", 2000);

        say("the markings on the runeblade glow brighter.", 2000);

        say("you force yourself back onto your feet.", 1800);

        hasRuneblade = true;

        Console.Clear();

        say("========================");
        say(" runeblade acquired");
        say("========================", 1800);

        say("the golem charges again.", 1600);

        say("this time, you can fight back.", 1800);

        won = golemSecondPhase();
        while (won == false)
        {
            retryEncounter();
            won = golemSecondPhase();
        }


        pause(1800);
        Console.Clear();

        say("the golem freezes.", 1600);

        say("cracks spread across its body.", 1800);

        say("the entire statue collapses.", 2200);

        say("you look down at the runeblade.", 1800);

        say("its glow slowly fades.", 1800);

        say("you won...", 1600);

        say("but barely.", 2000);

        say("your whole body hurts.", 1800);

        say("you slowly make your way out of the ruins.", 2200);

        Console.Clear();

        say("you finally reach the surface.", 1800);

        say("you can barely stay on your feet.", 2000);

        say("you hear voices nearby.", 1800);

        say("\"look! human!\"", 1600);

        say("a group of goblins step onto the path.", 2000);

        say("normally they wouldn't be much of a problem.", 2000);

        say("right now, you can barely lift the runeblade.");
        say("you drag its heavy blade along the path.", 2200);

        say("the goblins surround you.", 1800);

        say("one hits you from behind.", 1800);

        say("everything goes dark.", 3000);

        hasRuneblade = false;

        Console.Clear();

        say("...", 1500);

        say("you wake inside a wooden cage.", 2000);

        say("your weapons are gone.", 1800);

        say("goblins move around outside.", 1800);

        say("you try the cage door.", 1600);

        say("locked.", 1500);

        say("hours pass.", 2200);

        say("eventually two goblins approach.", 1800);

        say("\"boss ready.\"", 1600);

        say("\"human come.\"", 1600);

        say("they open the cage.", 1500);

        say("your hands are tied and they drag you across the camp.", 2200);

        say("you stop in front of a huge tent.", 2200);

        say("the goblins push you inside.", 1800);

        Console.Clear();

        say("the tent is much larger than it looked from outside.", 2200);

        say("torches burn along the walls.", 1800);

        say("at the far end sits a massive troll.", 2200);

        say("its throne is made from broken planks, barrels and old crates.", 2400);

        say("the troll looks down at you.", 1800);

        say("behind the throne, hanging from the wall...", 2000);

        say("is the runeblade.", 2200);

        say("the troll leans forward.", 1800);

        say("\"this human found shiny sword?\"", 2000);

        say("a goblin nods.", 1400);

        say("\"found human nearly dead.\"", 1800);

        say("the troll laughs.", 1800);

        say("\"weak.\"", 1500);

        say("it stands from the throne.", 1800);

        say("the troll grabs a huge club.", 1800);

        say("you pull against the rope around your hands.", 1800);

        say("the troll walks closer.", 1600);

        say("you pull harder.", 1400);

        say("crack!", 1000);

        say("the rope snaps.", 1400);

        say("you jump backwards.", 1400);

        say("you have no weapon.", 1600);

        say("the troll raises its club.", 1800);

        trollFight();

        hasRuneblade = true;

        pause(1800);
        Console.Clear();

        say("the troll collapses beside its broken throne.", 2200);

        say("the goblins stare at you.", 1800);

        say("then they run.", 1600);

        say("the tent quickly empties.", 1800);

        say("you hold the runeblade tightly.", 1800);

        say("you leave the tent and escape the camp.", 2200);

        Console.Clear();

        say("========================");
        say("     the road ahead");
        say("========================", 1800);

        say("you continue deeper into the kingdom.", 2000);

        say("the runeblade hangs at your side.", 1800);

        say("greyhaven is now far behind you.", 2000);

        say("you follow an old road towards the next town.", 2200);

        won = roadEncounter();

        pause(2200);
        Console.Clear();

        say("after hours of travelling, the trees begin to disappear.", 2200);

        say("buildings rise in the distance.", 1800);

        say("another town.", 1800);

        say("much larger than greyhaven.", 2200);

        say("stone towers rise above its walls.", 1800);

        say("the king's banners hang from the gates.", 2200);

        say("you tighten your grip on the runeblade.", 1800);

        say("then continue towards the town.", 2200);

        Console.Clear();

        // these methods continue the story after the original town arrival
        newTown(name);
        roadToTower();
        towerGates();
        wizardTower(name);
        finalCastle(name);
        ending(name);
    }

    // this is the new town after escaping the goblin camp
    static void newTown(string name)
    {
        Console.Clear();
        say("========================");
        say("        ashford");
        say("========================");
        say("you enter ashford through a narrow gate.", 1800);
        say("the streets are quiet. soldiers stand outside the shops.", 1800);
        say("a tower overlooks the rooftops. blue light moves behind its windows.", 2000);
        say("a guard steps in front of you and points at the runeblade.");
        say("guard: that weapon belongs to the king now. hand it over.", 1600);

        say("1 = talk to the guard");
        say("2 = offer your old sword as a bribe");
        say("3 = try to run");
        say("4 = fight");
        int choice = readChoice(4);

        if (choice == 1)
        {
            say(name + ": i just arrived. is this how you welcome everyone?");
            say("guard: only the ones carrying stolen weapons.");
            say("you ask him which law you have broken.");
            say("he reaches for a folded notice and starts looking through it.");
            say("his attention slips away from you for a moment.");
        }
        else if (choice == 2)
        {
            // the old sword is only used in this scene, the runeblade stays with me
            say("you offer him the old sword you recovered from the troll's tent.");
            say("guard: hardly worth anything. still, better than nothing.");
            say("he takes it and turns away to hide it beneath his cloak.");
        }
        else if (choice == 3)
        {
            say("you turn and run between two market stalls.");
            say("a cart rolls across your path. press a within 2 seconds to dodge!");
            if (timedKey(ConsoleKey.A, 2))
            {
                say("you slip around the cart. the guard crashes into it behind you.");
            }
            else
            {
                say("you stumble and the guard catches up. you have to fight.");
                combatStart("corrupt knight");
            }
        }
        else
        {
            say("you grip the runeblade. the guard draws his sword.");
            combatStart("corrupt knight");
            say("the guard falls and someone begins shouting for help.");
        }

        pause(1500);
        say("a hand grabs your sleeve and pulls you into an alley.");
        say("stranger: quiet. unless you want the rest of them coming over.", 1800);
        rebelAlley(name);
    }

    // these answers reveal the plan, but the stranger reacts differently
    static void rebelAlley(string name)
    {
        say("a hooded stranger watches the street until the footsteps pass.");
        say("1 = ask who they are");
        say("2 = tell them to let go");
        say("3 = ask if they work for the king");
        int choice = readChoice(3);

        if (choice == 1)
        {
            say("stranger: my name is rowan. i was hoping you would ask before swinging that thing.");
        }
        else if (choice == 2)
        {
            say("the stranger lets go and takes a step back.");
            say("stranger: fair enough. i'm rowan. i just saved you from a patrol.");
        }
        else
        {
            say("stranger: if i did, you would already be in chains. i'm rowan.");
        }

        pause(1800);
        say("rowan: i work with people who want the king off the throne.");
        say("rowan: he takes food, locks people away and calls it keeping order.");
        say(name + ": then we want the same thing.", 1800);
        say("rowan looks at the markings on your sword.");
        say("rowan: so the runeblade is real. that changes things.");
        say("rowan: the king has two advisors. you need to know about both.", 1800);
        say("rowan: marshal garrick commands his soldiers. cold, stubborn, follows every order.");
        say("rowan: veyran is his mage. clever, arrogant, thinks everyone else is beneath him.");
        say("rowan points towards the tower above the city.");
        say("rowan: veyran lives up there. his magic protects the castle gates.", 1800);

        say("1 = ask how to get into the tower");
        say("2 = ask why rowan cannot go instead");
        int question = readChoice(2);
        if (question == 1)
        {
            say("rowan: take the old hill road. two knights watch the entrance.");
            say("rowan: veyran carries a seal that opens the castle's outer gate.");
        }
        else
        {
            say("rowan: we tried. ordinary blades cannot break his ward.");
            say("rowan: yours might. take the seal he carries when you reach him.");
        }

        say("rowan: one more thing. his ward absorbs spells. watch what your sword does to it.");
        say(name + ": sounds like i'm heading to the tower.");
        say("rowan: i'll get our people ready near the castle. good luck.", 1800);
        metRebel = true;
    }

    // there are 2 encounters here picked from 5 possible events
    static void roadToTower()
    {
        Console.Clear();
        say("========================");
        say("    road to the tower");
        say("========================");
        say("the town noise fades as you climb the hill.", 1600);

        for (int encounter = 0; encounter < 2; encounter++)
        {
            if (encounter == 0)
            {
                say("the tower rises above a line of bare trees.");
            }
            else
            {
                say("you are close now. its shadow stretches across the road.");
            }
            towerRoadEncounter();
        }
    }

    static void towerRoadEncounter()
    {
        // this list holds the five possible things i can meet on the road
        string[] events = { "slime", "skeleton", "goblin", "traveller", "hidden page" };
        string eventChoice = events[random.Next(events.Length)];

        if (eventChoice == "slime")
        {
            say("a slime drops from a wall and blocks the path.");
            combatStart("slime");
        }
        else if (eventChoice == "skeleton")
        {
            say("a skeleton in rusted armour rises beside the road.");
            combatStart("skeleton");
        }
        else if (eventChoice == "goblin")
        {
            say("a goblin tries to grab your sword while you pass.");
            combatStart("goblin");
        }
        else if (eventChoice == "traveller")
        {
            say("a traveller carrying firewood stops beside you.");
            say("traveller: going up there? the knights have heavy shields.");
            say("traveller: that sword looks heavy enough to break one, though.");
            say("you thank them and continue climbing.", 1600);
        }
        else
        {
            say("you notice a folded page tucked beneath a loose stone.");
            say("it shows a blue seal beside a drawing of the castle gate.");
            say("someone has written: the mage keeps the key on his belt.");
            say("you put the page back. now you know what to look for.", 1600);
        }
    }

    static void towerGates()
    {
        say("two knights step away from the tower door.");
        say("neither asks why you are here. they draw their swords.", 1600);
        // each knight is its own checkpoint, so winning the first stays won
        combatStart("tower knight");
        say("the first knight falls. you catch your breath as the other circles you.");
        combatStart("tower knight");
        knightsDefeated = true;
        say("the second knight falls beside the door.");
        say("you take the tower door key from his belt and unlock the entrance.", 1600);
    }

    static void wizardTower(string name)
    {
        if (knightsDefeated == false)
        {
            return;
        }

        enteredTower = true;
        Console.Clear();
        say("========================");
        say("     veyran's tower");
        say("========================");
        say("blue flames burn in bowls along the walls.");
        say("the stairs curl upwards around a deep shaft.", 1800);
        say("a voice drifts down from above.");
        say("veyran: you have made quite a mess of my guards.");
        say("you climb towards the voice, keeping the runeblade close.", 1800);
        say("at the top, a thin man stands beside a window overlooking ashford.");
        say("a blue seal hangs from his belt.");
        say("veyran: a frightened traveller carrying a weapon they barely understand.");
        say(name + ": then explain it.", 1600);
        say("veyran: it was made to break binding spells. including the king's protection.");
        say("veyran: unfortunately for you, he pays me to keep that protection intact.");
        say("he raises his staff. a glowing shield surrounds him.", 1600);

        combatStart("veyran");
        mageDefeated = true;

        say("the runeblade tears through the ward and snaps his staff.");
        say("veyran falls. the blue flames around the room go out.", 1800);
        say("you take the seal from his belt.");
        say("on his desk lies a letter bearing the king's mark.");
        say("it orders every village to send food and prisoners to the castle.");
        say("below it is a drawing of a black crown.", 1800);
        say("veyran's notes say the crown holds the king's binding spells together.");
        say("breaking it will release those bound to him.");
        say("you remember the witch's warning about her magic keeping you alive.");
        say(name + ": i think we need another conversation when this is over.");
        say("you leave the tower and follow the road towards the castle.", 1800);
    }

    static void finalCastle(string name)
    {
        if (enteredTower == false || mageDefeated == false)
        {
            return;
        }

        Console.Clear();
        say("========================");
        say("      the castle");
        say("========================");
        say("by evening you reach a bridge beneath the castle walls.");
        if (metRebel)
        {
            say("rowan waits in the shadow of an abandoned wagon.");
            say("rowan: you actually did it. our people are ready.");
            say("you give rowan the letter from veyran's desk.");
            say("rowan: we'll get the prisoners out. you find the king.");
        }
        pause(1800);
        say("you press the blue seal into a hollow beside the gate.");
        say("the lock opens with a heavy click.");
        say("you enter the courtyard while rowan's people slip towards the cells.", 1800);
        say("a man in black armour waits at the foot of the throne room stairs.");
        say("garrick: veyran always talked too much. i will not make that mistake.");
        say("1 = tell him what the king has done");
        say("2 = tell him to step aside");
        int choice = readChoice(2);
        if (choice == 1)
        {
            say(name + ": people are starving while he fills this castle.");
            say("garrick: my duty is to the crown. not to your opinion of it.");
        }
        else
        {
            say(name + ": this is your chance to walk away.");
            say("garrick: i have stood here for twenty years. i am not moving now.");
        }
        say("the marshal lowers his visor and charges.");
        combatStart("marshal garrick");
        say("garrick's sword falls from his hand. he sinks against the wall.");
        say("you leave him there and climb the stairs.", 1800);

        say("the throne room doors open onto a long red carpet.");
        say("king aldren sits beneath a window of coloured glass.");
        say("his black crown glows as you approach.", 1800);
        say("aldren: the witch sent you, didn't she?");
        say(name + ": she did. but i've seen enough to make my own decision.");
        say("aldren: she made this crown for me. now she sends strangers to undo her mistake.");
        say("aldren: put down the sword. there is a place for you here.");
        say("1 = say you came to end his rule");
        say("2 = ask about the witch's spell");
        int answer = readChoice(2);
        if (answer == 1)
        {
            say(name + ": i didn't come this far to serve you.");
            say("aldren: then you will join the others beneath this castle.");
        }
        else
        {
            say("aldren: her magic is tied to my crown. she cannot raise a hand against me.");
            say("aldren: so she found someone else to carry the blade.");
            say(name + ": then i'll break the crown as well.");
        }
        pause(1800);
        say("the king rises and draws a sword covered in dark markings.");
        say("the runeblade answers with a faint blue glow.");
        combatStart("king aldren");
        kingDefeated = true;
    }

    // this finishes the main quest and explains what happens to the witch's spell
    static void ending(string name)
    {
        if (kingDefeated == false)
        {
            return;
        }

        Console.Clear();
        say("the king drops to his knees. his sword slides across the floor.");
        say("you bring the runeblade down onto the black crown.");
        say("it splits in two.", 2000);
        say("a crack of blue light travels through the room and disappears.");
        say("the pressure in your chest finally lifts.");
        say("you are still breathing.", 1800);
        say("rowan enters with the freed prisoners behind them.");
        say("rowan: it's over. the soldiers are laying down their weapons.");
        say("they take aldren away to answer for what he has done.", 1800);
        say("you return to the witch's cave a few days later.");
        say("she is waiting beside the same small fire.");
        say(name + ": you could have told me the truth.");
        say("witch: yes. i should have.", 1800);
        say("witch: i made the crown to protect the kingdom. he used it to bind us instead.");
        say("witch: when you broke it, the magic holding us both was released.");
        say(name + ": so i won't drop dead if i leave?");
        say("witch: your wounds have healed. your life is yours now.", 1800);

        say("1 = keep the runeblade and travel");
        say("2 = return the runeblade to the ruins");
        int choice = readChoice(2);
        if (choice == 1)
        {
            say("you lift the runeblade. it is still heavy, but you can carry it now.");
            say("there are other roads beyond this kingdom. you want to see them.");
        }
        else
        {
            say("you return to the quiet ruins and place the blade on its pedestal.");
            say("its markings fade. you hope nobody will need it for a long time.");
            hasRuneblade = false;
        }

        pause(1800);
        say("back in ashford, rowan helps the towns choose their own council.");
        say("for the first time in years, the food wagons travel out of the castle.", 2200);
        say("========================");
        say("        the end");
        say("========================");
        say("thanks for playing, " + name + ".");
        say("press enter to close the game.");
        Console.ReadLine();
    }

    // this keeps asking until i enter one of the numbers on the menu
    static int readChoice(int highestChoice)
    {
        int choice = 0;
        while (choice < 1 || choice > highestChoice)
        {
            Console.Write("choose: ");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                choice = 0;
            }
            if (choice < 1 || choice > highestChoice)
            {
                say("enter a number from 1 to " + highestChoice);
            }
        }
        return choice;
    }

    // this is the inn route, mara tells me where the ruins are
    static void greyhavenInn(string name)
    {
        Console.Clear();

        say("========================");
        say("    the lantern inn");
        say("========================", 1800);

        say("you enter the old inn.", 1600);

        say("a woman behind the counter looks up.", 1800);

        say("\"welcome to the lantern.\"", 1600);

        say("\"i'm mara.\"", 1600);

        say("mara: \"you look like you've had a rough journey.\"", 2000);

        say(name + ": i'm looking for the runeblade.", 1800);

        say("mara goes quiet.", 1600);

        say("mara: \"the runeblade?\"", 1600);

        say("mara: \"my grandfather used to tell stories about that thing.\"", 2000);

        say("mara: \"said it belonged to some old warrior before the kingdom fell apart.\"", 2200);

        say(name + ": do you know where it is?", 1800);

        say("mara: \"no. but i know where the stories came from.\"", 2000);

        say("mara: \"there are ruins north of town.\"", 1800);

        say("mara: \"nobody sensible goes there anymore.\"", 1800);

        say(name + ": sounds like the right place.", 1800);

        say("mara: \"that's exactly what i was afraid you'd say.\"", 2000);
    }

    // this is the market route, the map catch changes the dialogue
    static void greyhavenMarket(string name)
    {
        Console.Clear();

        say("========================");
        say("   greyhaven market");
        say("========================", 1800);

        say("you walk through rows of crowded market stalls.", 2000);

        say("one stall is covered in old maps, coins and broken weapons.", 2200);

        say("a thin man waves you over.", 1600);

        say("\"perrin's relics! everything here is probably real!\"", 2200);

        say("perrin: \"probably.\"", 1500);

        say(name + ": have you heard of the runeblade?", 1800);

        say("perrin laughs.", 1400);

        say("perrin: \"the runeblade?\"", 1500);

        say("perrin: \"that's a children's story.\"", 1800);

        say("perrin: \"magic sword, ancient warrior, save the kingdom... all that stuff.\"", 2200);

        say(name + ": so you don't know anything?", 1800);

        say("perrin: \"didn't say that.\"", 1600);

        say("perrin reaches under his stall.", 1600);

        say("he pulls out an old rolled-up map.", 1800);

        say("perrin: \"most versions of the story mention these ruins north of-\"", 2200);

        say("the map slips from his hand.", 1200);

        say("press e to catch it!");
        bool caught = timedKey(ConsoleKey.E, 2);

        if (caught == true)
        {
            say("you catch the map before it hits the ground.", 1800);

            say("perrin: \"not bad.\"", 1500);

            say("perrin: \"maybe you won't die out there after all.\"", 1900);
        }
        else
        {
            say("the map hits the muddy ground.", 1600);

            say("perrin: \"...great.\"", 1400);

            say("he picks it back up.", 1500);
        }

        say("perrin points to a ruined area on the map.", 1800);

        say("perrin: \"here. north of greyhaven.\"", 1800);

        say("perrin: \"if your magic fairy sword exists, that's where i'd look.\"", 2200);

        say(name + ": thanks.", 1400);

        say("perrin: \"if you actually find it, come back.\"", 1800);

        say("perrin: \"i'll pretend i believed you the whole time.\"", 2000);
    }

    // next chooses 1, 2, 3 or 4, so the road enemy can change
    static bool roadEncounter()
    {
        Console.WriteLine();

        int encounter = random.Next(1, 5);
        string enemy = "";

        if (encounter == 1)
        {
            enemy = "slime";

            say("something moves beside the road.", 1400);

            say("a large slime crawls out from the grass.", 1700);
        }
        else if (encounter == 2)
        {
            enemy = "goblin";

            say("you hear movement in the bushes.", 1400);

            say("a goblin jumps onto the road.", 1700);
        }
        else if (encounter == 3)
        {
            enemy = "skeleton";

            say("you pass an old pile of bones.", 1400);

            say("the bones suddenly begin moving.", 1700);
        }
        else
        {
            enemy = "corrupt knight";

            say("a knight wearing the king's crest blocks the road.", 1800);

            say("\"road tax.\"", 1300);

            say("\"hand over your coins.\"", 1600);

            say("you reach for your weapon instead.", 1600);
        }

        return combatStart(enemy);
    }

    // this repeats the same enemy if i lose, without making you start over from the beginning
    static bool combatStart(string enemyType)
    {
        bool won = combatRound(enemyType);
        while (won == false)
        {
            retryEncounter();
            won = combatRound(enemyType);
        }
        return true;
    }

    // each attempt gets fresh health for both me and the enemy
    static bool combatRound(string enemyType)
    {
        int playerHealth = 20;

        int enemyHealth = 15;
        int enemyDamage = 3;

        int swordDamage = 4;
        int magicDamage = 4;

        string weaknessHint = "";

        if (enemyType == "slime")
        {
            enemyHealth = 12;
            enemyDamage = 2;

            swordDamage = 2;
            magicDamage = 6;

            weaknessHint = "the slime reacts badly to magic.";
        }
        else if (enemyType == "goblin")
        {
            enemyHealth = 15;
            enemyDamage = 3;

            swordDamage = 6;
            magicDamage = 3;

            weaknessHint = "the goblin leaves itself open to sword attacks.";
        }
        else if (enemyType == "skeleton")
        {
            enemyHealth = 18;
            enemyDamage = 4;

            swordDamage = 3;
            magicDamage = 6;

            weaknessHint = "magic seems to shake the skeleton apart.";
        }
        else if (enemyType == "corrupt knight")
        {
            enemyHealth = 24;
            enemyDamage = 4;

            swordDamage = 4;
            magicDamage = 7;

            weaknessHint = "magic can get through the gaps in the knight's armour.";
        }

        else if (enemyType == "tower knight")
        {
            enemyHealth = 24;
            enemyDamage = 4;
            swordDamage = 4;
            magicDamage = 6;
            weaknessHint = "the runeblade can split the knight's shield.";
        }
        else if (enemyType == "veyran")
        {
            enemyHealth = 30;
            enemyDamage = 4;
            swordDamage = 6;
            magicDamage = 3;
            weaknessHint = "veyran's ward absorbs magic, but the runeblade cuts it.";
        }
        else if (enemyType == "marshal garrick")
        {
            enemyHealth = 32;
            enemyDamage = 4;
            swordDamage = 4;
            magicDamage = 7;
            weaknessHint = "magic gets through garrick's heavy armour.";
        }
        else if (enemyType == "king aldren")
        {
            enemyHealth = 45;
            enemyDamage = 3;
            swordDamage = 6;
            magicDamage = 4;
            weaknessHint = "the runeblade breaks the magic protecting the king.";
        }

        // finding the runeblade adds 3 damage to every normal sword attack
        if (hasRuneblade == true)
        {
            swordDamage = swordDamage + 3;
        }

        Console.WriteLine();
        say("========================");
        say("      battle start");
        say("========================", 800);

        say("a " + enemyType + " attacks!");

        // the fight continues while both characters still have health
        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine();

            say("you: " + playerHealth + " hp");
            say(enemyType + ": " + enemyHealth + " hp");

            Console.WriteLine();

            if (hasRuneblade == true)
            {
                say("1 = runeblade");
            }
            else
            {
                say("1 = sword");
            }

            say("2 = magic");
            say("3 = shield");

            Console.Write("choose: ");

            int choice;

            // try turns the typed text into a number
            // catch asks again if i type letters instead
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                say("enter 1, 2 or 3");
                continue;
            }

            if (choice == 1)
            {
                enemyHealth = enemyHealth - swordDamage;

                if (hasRuneblade == true)
                {
                    say("you attack with the runeblade!");
                }
                else
                {
                    say("you attack with your sword!");
                }

                say("you dealt " + swordDamage + " damage.");
            }
            else if (choice == 2)
            {
                enemyHealth = enemyHealth - magicDamage;

                say("you use magic!");
                say("you dealt " + magicDamage + " damage.");
            }
            else if (choice == 3)
            {
                say("you raise your shield.");
            }
            else
            {
                say("enter 1, 2 or 3");
                continue;
            }

            // a defeated enemy does not get another attack
            if (enemyHealth <= 0)
            {
                enemyHealth = 0;
                break;
            }

            int damageTaken = enemyDamage;

            if (choice == 3)
            {
                // dividing by 2 halves the hit, whole numbers round down
                damageTaken = enemyDamage / 2;

                if (damageTaken < 1)
                {
                    damageTaken = 1;
                }

                say("your shield reduces the damage.", 600);

                say("while blocking, you watch the enemy carefully...", 700);

                say("hint: " + weaknessHint);
            }

            say(enemyType + " attacks for " + damageTaken + " damage.");

            playerHealth = playerHealth - damageTaken;

            if (playerHealth < 0)
            {
                playerHealth = 0;
            }
        }

        Console.WriteLine();

        if (playerHealth > 0)
        {
            say("you defeated the " + enemyType + "!");
            return true;
        }
        else
        {
            say("you were defeated...");
            return false;
        }
    }

    // this first golem fight lasts 3 turns and is meant to be unwinnable
    // it leads into finding the runeblade instead of a game over
    static void golemFirstPhase()
    {
        int turns = 0;
        int playerHealth = 20;

        while (turns < 3)
        {
            Console.WriteLine();

            say("you: " + playerHealth + " hp");
            say("guardian golem: ??? hp");

            Console.WriteLine();

            say("1 = sword");
            say("2 = magic");
            say("3 = shield");

            Console.Write("choose: ");

            int choice;

            // try turns the typed text into a number
            // catch asks again if i type letters instead
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                say("enter 1, 2 or 3");
                continue;
            }

            if (choice == 1)
            {
                say("you strike the golem with your sword.", 900);

                say("clang!", 700);

                say("your sword doesn't even chip the stone.", 1200);

                say("you dealt 0 damage.");
            }
            else if (choice == 2)
            {
                say("you blast the golem with magic.", 900);

                say("the smoke clears.", 900);

                say("it hasn't even moved.", 1100);

                say("you dealt 0 damage.");
            }
            else if (choice == 3)
            {
                say("you raise your shield.", 800);

                say("the golem's weapon crashes against it.", 900);

                say("your whole body shakes from the impact.");
            }
            else
            {
                say("enter 1, 2 or 3");
                continue;
            }

            if (turns == 0)
            {
            }

            int damage = 6;

            if (choice == 3)
            {
                damage = 3;
            }

            playerHealth = Math.Max(0, playerHealth - damage);

            say("the golem attacks for " + damage + " damage.");

            turns++;

            if (turns == 2)
            {
                say("");
                say("nothing you have can damage it...", 1500);
            }
        }
    }

    // this is the real golem fight after i pick up the runeblade
    static bool golemSecondPhase()
    {
        int playerHealth = 20;
        int golemHealth = 35;


        while (playerHealth > 0 && golemHealth > 0)
        {
            Console.WriteLine();

            say("you: " + playerHealth + " hp");
            say("guardian golem: " + golemHealth + " hp");

            Console.WriteLine();

            say("1 = runeblade");
            say("2 = magic");
            say("3 = shield");

            Console.Write("choose: ");

            int choice;

            // try turns the typed text into a number
            // catch asks again if i type letters instead
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                say("enter 1, 2 or 3");
                continue;
            }

            if (choice == 1)
            {
                golemHealth = golemHealth - 10;

                say("the runeblade cuts straight through the stone!");
                say("you dealt 10 damage.");
            }
            else if (choice == 2)
            {
                golemHealth = golemHealth - 4;

                say("you attack with magic.");
                say("you dealt 4 damage.");
            }
            else if (choice == 3)
            {
                say("you raise your shield.");
            }
            else
            {
                say("enter 1, 2 or 3");
                continue;
            }

            if (golemHealth <= 0)
            {
                break;
            }

            int damage = 4;

            if (choice == 3)
            {
                damage = 2;

                say("your shield reduces the impact.");
                say("hint: the runeblade is cutting through its stone body.");
            }

            playerHealth = Math.Max(0, playerHealth - damage);

            say("the golem attacks for " + damage + " damage.");
        }

        return playerHealth > 0;
    }

    // this part gives me 3 lives to dodge 5 troll attacks
    // pressing a, d or s within 2 seconds counts as a dodge
    static void trollFight()
    {
        bool trollDefeated = false;

        while (trollDefeated == false)
        {
            int health = 3;
            int dodges = 0;

            Console.Clear();

              say("========================");
              say("      troll fight");
              say("========================", 1500);

              say("the runeblade is hanging behind the troll.", 1800);

             say("you need to survive long enough to reach it.", 2000);

              say("you have about 2 seconds to press each dodge key.", 2000);

            while (health > 0 && dodges < 5)
            {
                Console.WriteLine();

                int attack = random.Next(1, 4);

                if (attack == 1)
                {
                    say("the troll swings its club from the right!");
                    say("press a to dodge!");

                    bool dodge = timedKey(ConsoleKey.A, 2);

                    if (dodge == true)
                    {
                        say("you dodge left!");
                        dodges++;
                     }
                      else
                    {
                        say("the club smashes into you!");
                        health--;
                    }
                }
                else if (attack == 2)
                {
                    say("the troll swings its club from the left!");
                    say("press d to dodge!");

                    bool dodge = timedKey(ConsoleKey.D, 2);

                    if (dodge == true)
                    {
                        say("you dodge right!");
                        dodges++;
                    }
                    else
                    {
                        say("the club hits you!");
                        health--;
                    }
                }
                else
                {
                    say("the troll raises its club above its head!");
                    say("press s to dodge back!");

                    bool dodge = timedKey(ConsoleKey.S, 2);

                    if (dodge == true)
                    {
                        say("you jump backwards!");
                        dodges++;
                    }
                    else
                    {
                        say("the club crashes into you!");
                        health--;
                    }
                }

                Console.WriteLine();

                say("health: " + health);
                say("dodges: " + dodges + "/5", 1000);
            }

            if (health <= 0)
            {
                Console.Clear();

                say("the troll knocks you to the ground.", 1800);

                say("you failed to escape its attacks.", 1600);

                retryEncounter();
                continue;
            }

            Console.Clear();

            say("the troll swings again.", 1600);

            say("you dive underneath its club.", 1600);

            say("the club smashes into the wooden throne.", 2000);

            say("planks and barrels collapse everywhere.", 2000);

            say("the troll struggles to pull its weapon free.", 1800);

            say("this is your chance.", 1500);

            say("you run past the troll.", 1500);

            say("you grab the runeblade from the wall.", 2000);

            hasRuneblade = true;

            Console.WriteLine();

              say("========================");
              say(" runeblade recovered");
              say("========================", 1800);

              say("the blade begins glowing.", 1600);

            say("the troll rips its club free.", 1800);

            say("now you can fight back.", 1800);

            say("your old sword and shield are beside the wall too.");
            say("you pick them up before the troll turns around.");

            bool won = trollCombat();
            // losing this part only restarts the armed fight, not the dodging
            while (won == false)
         {
                retryEncounter();
                won = trollCombat();
         }

         if (won == true)
            {
                trollDefeated = true;
            }
        }
    }

    // after the dodges i get my sword back and fight the troll normally
    static bool trollCombat()
    {
        int playerHealth = 20;
        int trollHealth = 35;


        while (playerHealth > 0 && trollHealth > 0)
        {
            Console.WriteLine();

            say("you: " + playerHealth + " hp");
            say("troll: " + trollHealth + " hp");

            Console.WriteLine();

          say("1 = runeblade");
          say("2 = magic");
            say("3 = shield");

            Console.Write("choose: ");

            int choice;

            // try turns the typed text into a number
            // catch asks again if i type letters instead
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                say("enter 1, 2 or 3");
                continue;
            }

         if (choice == 1)
            {
                trollHealth = trollHealth - 9;

                say("you slash the troll with the runeblade!");
                say("you dealt 9 damage.");
            }
            else if (choice == 2)
            {
                trollHealth = trollHealth - 5;

                say("you use magic!");
                say("you dealt 5 damage.");
            }
            else if (choice == 3)
            {
                say("you raise your shield.");
            }
            else
            {
                say("enter 1, 2 or 3");
                continue;
            }

           if (trollHealth <= 0)
            {
                break;
            }

            int damage = 4;

            if (choice == 3)
            {
                damage = 2;

                say("your shield takes most of the hit.");
                say("hint: the runeblade cuts much deeper than your magic.");
            }

            playerHealth = Math.Max(0, playerHealth - damage);

            say("the troll attacks for " + damage + " damage.");
        }

        if (playerHealth > 0)
        {
            Console.Clear();

              say("the troll falls to one knee.", 1800);

             say("you raise the runeblade.", 1500);

                say("the troll tries to stand.", 1500);
 
                say("you strike one final time.", 2000);
  
                say("========================");
                say("     troll defeated");
                say("========================");

            return true;
        }
        else
        {
            return false;
        }
    }

    // this checks for the right key until the time runs out
    // for example timedKey(ConsoleKey.A, 2) gives me 2 seconds to press a
    static bool timedKey(ConsoleKey correctKey, int seconds)
    {
        // clear old key presses so holding a key beforehand does not count
            while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }

        // this sets the time when the dodge window closes
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == correctKey)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // wait a tiny amount between checks instead of checking constantly
            Thread.Sleep(10);
        }

        return false;
    }

    // this is a checkpoint before the current fight, not a disk save
    static void retryEncounter()
    {
        say("you were defeated. press enter to retry this encounter.");
        Console.ReadLine();
        Console.Clear();
    }

    // this prints one line of dialogue so i do not type console.writeline every time
    static void say(string text, int delay = 0)
    {
        ConsoleColor oldColour = Console.ForegroundColor;

      if (text.StartsWith("\"") || text.Contains(":"))
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        else if (text.ToLower().Contains("runeblade") || text.ToLower().Contains("king"))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        Console.WriteLine(text);
        Console.ForegroundColor = oldColour;

        if (fastText == false && delay > 0)
        {
            Thread.Sleep(delay);
        }
    }

    // the number is in milliseconds, so 1000 means a 1 second wait
    static void pause(int time)
    {
        if (fastText == false)
        {
            Thread.Sleep(time);
        }
    }
}



