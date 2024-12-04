Random random = new Random();
int cAtk = random.Next(1,11);
int hHealth = 10;
int bHealth = 10;
bool turn = true;
do{
    if(turn){
        bHealth -= cAtk;
        Console.WriteLine($"Monster was damaged and lost {cAtk} health and now has {bHealth} health.");
        turn = false;
    }
    else{
        hHealth -= cAtk;
        Console.WriteLine($"Hero was damaged and lost {cAtk} health and now has {hHealth} health.");
        turn = true;
    }
    cAtk = random.Next(1,11);


} while(hHealth > 0 && bHealth > 0);
if(!turn) Console.WriteLine("Hero wins!");
else Console.WriteLine("Monster wins!");