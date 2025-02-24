/*
// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }


    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options

do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    //Console.WriteLine($"You selected menu option {menuSelection}.");
    //Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    //readResult = Console.ReadLine();

    switch(menuSelection){
        case "1":
        //pet info
        for(int i =0; i < maxPets; i++){
            if(ourAnimals[i,0] != "ID #: "){
                Console.WriteLine();
                for(int j =0; j<6;j++){
                    Console.WriteLine(ourAnimals[i,j]);
                }
            }
        }
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "2":
        //add agnimal
        string anotherPet = "y";
        int petCount = 0;
        for(int i=0; i<maxPets; i++){
            if(ourAnimals[i,0] != "ID #: "){
                petCount += 1;
            }
        }
        if(petCount < maxPets){
            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
        }
        while(anotherPet == "y" && petCount < maxPets){
            bool validEntry = false;
            do{
                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                readResult = Console.ReadLine();
                if(readResult != null){
                    animalSpecies = readResult.ToLower();
                    if(animalSpecies != "dog" && animalSpecies != "cat"){
                        validEntry = false;
                    }
                    else validEntry = true;
                }
            }while (validEntry == false);
            animalID = animalSpecies.Substring(0,1) + (petCount + 1).ToString();
            do{
                int petAge;
                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                readResult = Console.ReadLine();
                if (readResult != null) {
                    animalAge = readResult;
                }
                if(animalAge != "?"){
                    validEntry = int.TryParse(animalAge, out petAge);
                }
                else validEntry = true;
            }while(validEntry == false);
            do{
                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                readResult = Console.ReadLine();
                if(readResult != null){
                    animalPhysicalDescription = readResult.ToLower();
                    if(animalPhysicalDescription == ""){
                        animalPhysicalDescription = "tbd";
                    }
                }
                
            }while(animalPhysicalDescription == "");
            do{
                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                readResult = Console.ReadLine();
                if(readResult != null){
                    animalPersonalityDescription = readResult.ToLower();
                    if(animalPersonalityDescription == ""){
                        animalPersonalityDescription = "tbd";
                    }
                }
            }while(animalPersonalityDescription == "");
            do{
                Console.WriteLine("Enter a nickname for the pet");
                readResult = Console.ReadLine();
                if(readResult != null){
                    animalNickname = readResult.ToLower();
                    if(animalNickname == ""){
                        animalNickname = "tbd";
                    }
                }
            }while(animalNickname == "");

            ourAnimals[petCount,0] = "ID #: " + animalID;
            ourAnimals[petCount,1] = "Species: " + animalSpecies;
            ourAnimals[petCount,2] = "Age: " + animalAge;
            ourAnimals[petCount,3] = "Nickname: " + animalNickname;
            ourAnimals[petCount,4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[petCount,5] = "Personality: " + animalPersonalityDescription;

            petCount += 1;
            if(petCount < maxPets){
                Console.WriteLine("Do you want to enter info for another pet (y/n)");
                do{
                    readResult = Console.ReadLine();
                    if(readResult != null){
                        anotherPet = readResult.ToLower();
                    }
                } while(anotherPet != "y" && anotherPet != "n");
            }
        }
        if(petCount >= maxPets){
            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
        }
        
        break;

        case "3":
        //physical descripton
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "4":
        //nickname person
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "5":
        //edit ag
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "6":
        //edit personal
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "7":
        //all cat
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "8":
        //all doge
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        default: break;
    }
} while (menuSelection != "exit");


string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach(var pallet in pallets){
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach(var pallet in pallets){
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
if(pallets[0] != null)
Console.WriteLine($"After: {pallets[0].ToLower()}");
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
decimal price2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);

yourDiscount += $"A discount of {((price2 - salePrice)/price2):P2}!"; //inserted
Console.WriteLine(yourDiscount);


int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");



string input = "Pad this";
Console.WriteLine(input.PadRight(12));
Console.WriteLine(input.PadLeft(12,'-'));
Console.WriteLine(input.PadRight(12,'-'));


string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,00.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);


string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";
comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}",currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}",newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);



Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers(){
Random random = new Random();
for(int i = 0; i < 5; i++){
    Console.Write($"{random.Next(1, 100)} ");
}
Console.WriteLine();
}

*/

using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

/* Format and display medicine times */
displayTimes();

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    adjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    adjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
displayTimes();


Console.WriteLine();

void displayTimes(){
/* Format and display medicine times */
foreach (int val in times)
{
    string time = val.ToString();
    int len = time.Length;

    if (len >= 3)
    {
        time = time.Insert(len - 2, ":");
    }
    else if (len == 2)
    {
        time = time.Insert(0, "0:");
    }
    else
    {
        time = time.Insert(0, "0:0");
    }

    Console.Write($"{time} ");
}
}

void adjustTimes(){
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}