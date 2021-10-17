using System;

namespace GAME_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("||||||||||   o('3')o   Welcome to Spirited Away Game : Trapped in Spirit World   o('3')o  |||||||||");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("What is Your Name ?");
            Console.WriteLine("ENTER YOUR NICKNAME -");
            Knight Player = new Knight();
            Player.name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Hi " +Player.name+ " ! ");
            Console.WriteLine("In Spirit World, Haku will be guide you to finding your home back. ");
            Console.WriteLine("But you have to save your parents first who are now kidnapped by Yubaba.");
            Console.WriteLine("There are many things that you have to go through so that you can return back to your world.");
            Console.WriteLine("Are you ready for this adventure? [yes/no]");
            string bReady = Console.ReadLine();
            if(bReady == "yes")
            {
                Enemy1 enemy1 = new Enemy1("Baby Bo");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.WriteLine(" |||||||||||||||    ▼  ▼  ▼    Chapter 1 : The Lost Pith     ▼  ▼  ▼      |||||||||||||||");
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.WriteLine("Suddenly you wake up in a strange room...");
                Console.WriteLine("Mysterious man brought you a tea, 'Finally you woke up. Drink this tea!'. ");
                Console.WriteLine("You are confused, 'Where is this? Where are my parents?'. ");
                Console.WriteLine("Mysterious man stood up and stretched out his hand, 'My name is  Haku, I'm your friend...");
                Console.WriteLine("...you are trapped in the spirit world. Your parents are now kidnapped by Yubaba, an evil witch who likes to curse humans.' ");
                Console.WriteLine(Player.name+" were shocked, 'No!!! What about my parents?!'. ");
                Console.WriteLine("Haku said, 'you have to save your parents, and return you to your world.' ");
                Console.WriteLine("Finally " +Player.name+ " went to the bathhouse, but was blocked by "+enemy1.Name+", 'Hey there's a human!'. ");
                Console.WriteLine(enemy1.Name+" said, 'Kill him/her!'");
                Console.WriteLine("             Choose your action "+Player.name+" !                ");
                Console.WriteLine("             1. Strike Attack                ");
                Console.WriteLine("             2. Bash             ");
                Console.WriteLine("             3. Defend               ");
                Console.WriteLine("             4. Go Away              ");
                Console.WriteLine("             5. Use Potion               ");

                Console.WriteLine("");
                while (!Player.IsDead && !enemy1.IsDead){
                     string playerAction = Console.ReadLine();
                     switch (playerAction)
                     {
                        case "1" :
                        Player.StrikeAttack();
                        Console.WriteLine(Player.name+" is doing Strike Attack");
                        enemy1.GetHit(Player.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        enemy1.Attack(enemy1.AttackPower);
                        Console.Write("Player Health :"+Player.Health+" | Baby Bo Health ; "+enemy1.Health+"\n");
                        break;
                        case "2" :
                        Player.Bash();
                        Console.WriteLine(Player.name+" is doing Bash");
                        enemy1.GetHit(Player.AttackPower);
                        Console.WriteLine(enemy1.Name+" going to next turns");
                        Console.Write("Player Health :"+Player.Health+" | Baby Bo Health ; "+enemy1.Health+"\n");
                        break;
                        case "3" :
                        Player.UseHealthPotion() ;
                        Console.WriteLine(Player.name+" use health potion");
                        Console.WriteLine("Regenarate Mana "+Player.name+" ");
                        enemy1.Attack(Player.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        Console.Write("Player Health :"+Player.Mana+" |  Baby Bo Health ; "+enemy1.Health+"\n");
                        break;
                        case "4" :
                        Player.UseManaPotion() ;
                        Console.WriteLine(Player.name+" use mana potion");
                        Console.WriteLine("Regenarate Mana "+Player.name+" ");
                        enemy1.Attack(Player.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        Console.Write("Player Health :"+Player.Mana+" | Baby Bo Health ; "+enemy1.mana+"\n");
                        break;
                        case "5" :
                        Console.WriteLine(Player.name+" is go away...");
                        break;
                    }
                }
            }else{
                Console.WriteLine(Player.name+ "Exit The Spirit World...");
                Console.Read();
            }
                Enemy2 enemy2 = new Enemy2("No Face");
                Console.WriteLine("Do you want to continue this advanture? [yes/no]");
                string fready = Console.ReadLine();
                if (fready == "yes") 
                {

                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("||||||||||||||||  ▼  ▼  ▼   Chapter 2 : A Brave Soul That Dares to Conquer Everything    ▼  ▼  ▼   |||||||||||||||");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You can beat Baby Bo and he turns into a fat little mouse.");
                Console.WriteLine("You entered the bathhouse of the spirits. ");
                Console.WriteLine("There is filled with scary-odd spirits and ugly-frogs workers.");
                Console.WriteLine("You walk in fear...");
                Console.WriteLine("Suddenly a black spirit with a white-red mask is following you. ");
                Console.WriteLine("Then the spirit turned into a scary giant, 'HAHAHA I am the  "+enemy2.Name+" who will eat you!'. ");
                Console.WriteLine("Finally " +Player.name+ " bravely fought "+enemy2.Name+". ");
                Console.WriteLine(enemy2.Name+" 'Im hungry and Im going to eat you!.");
                Console.WriteLine("             Choose your action "+Player.name+" !                ");
                Console.WriteLine("             1. Strike Attack                ");
                Console.WriteLine("             2. Bash             ");
                Console.WriteLine("             3. Use Health Potion               ");
                Console.WriteLine("             4. Use Mana Potion             ");
                Console.WriteLine("             5. Go Away               ");


                while (!Player.IsDead && !enemy2.IsDead){
                     string playerAction = Console.ReadLine();
                     switch (playerAction)
                     {
                        case "1" :
                        Player.StrikeAttack();
                        Console.WriteLine(Player.name+" is doing Strike Attack");
                        enemy2.GetHit(Player.AttackPower);
                        Player.GetHit(enemy2.AttackPower);
                        enemy2.Attack(enemy2.AttackPower);
                        Console.Write("Player Health :"+Player.Health+" | No Face Health ; "+enemy2.Health+"\n");
                        break;
                        case "2" :
                        Player.Bash();
                        Console.WriteLine(Player.name+" is doing Bash");
                        enemy2.GetHit(Player.AttackPower);
                        Console.WriteLine(enemy2.Name+" going to next turns");
                        Console.Write("Player Health :"+Player.Health+" | No Face Health ; "+enemy2.Health+"\n");
                        break;
                        case "3" :
                        Player.UseHealthPotion() ;
                        Console.WriteLine(Player.name+" use health potion");
                        Console.WriteLine("Regenarate Mana "+Player.name+" ");
                        enemy2.Attack(Player.AttackPower);
                        Player.GetHit(enemy2.AttackPower);
                        Console.Write("Player Health :"+Player.Mana+" |  No Face Health ; "+enemy2.Health+"\n");
                        break;
                        case "4" :
                        Player.UseManaPotion() ;
                        Console.WriteLine(Player.name+" use mana potion");
                        Console.WriteLine("Regenarate Mana "+Player.name+" ");
                        enemy2.Attack(Player.AttackPower);
                        Player.GetHit(enemy2.AttackPower);
                        Console.Write("Player Health :"+Player.Mana+" | No Face Health ; "+enemy2.mana+"\n");
                        break;
                        case "5" :
                        Console.WriteLine(Player.name+" is go away...");
                        break;
                    }
                }
            }else{
                 Console.WriteLine(Player.name+ "Exit The Spirit World...");
                Console.Read();
            }

                Enemy3 enemy3 = new Enemy3("Zeniba");
                Console.WriteLine("Do you want to continue this advanture? [yes/no]");
                string gready = Console.ReadLine();
                if (gready == "yes") 
                {

                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("||||||||||||||||     ▼  ▼  ▼     Chaper 3 : There is No Other Choice     ▼  ▼  ▼      |||||||||||||||");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("The bathhouse goes into chaos when No Face got vomiting because he fail.");
                Console.WriteLine("Immediately they called the head of the bathhouse. ");
                Console.WriteLine("'YUBABA!!! THERE'S A HUMAN HERE! Shout everyone.");
                Console.WriteLine("Suddenly an old woman in a blue dress coming.");
                Console.WriteLine("Everyone ran scared, 'Yubaba has come! Run!!!'. ");
                Console.WriteLine("She come closer 'Im sorry, Im "+enemy3.Name+". Im Yubaba's twin, I  who was cursed to fight you...' ");
                Console.WriteLine(Player.name+" was shocked, but had no other choice to fight "+enemy3.Name+". ");
                Console.WriteLine(enemy3.Name+" 'I'm sorry, I have to kill you!'. ");
                Console.WriteLine("             Choose your action "+Player.name+" !                ");
                Console.WriteLine("             1. Strike Attack                ");
                Console.WriteLine("             2. Bash             ");
                Console.WriteLine("             3. Use Health Potion               ");
                Console.WriteLine("             4. Use Mana Potion             ");
                Console.WriteLine("             5. Go Away               ");




                while (!Player.IsDead && !enemy3.IsDead){
                     string playerAction = Console.ReadLine();
                     switch (playerAction)
                     {
                        case "1" :
                        Player.StrikeAttack();
                        Console.WriteLine(Player.name+" is doing Strike Attack");
                        enemy3.GetHit(Player.AttackPower);
                        Player.GetHit(enemy3.AttackPower);
                        enemy3.Attack(enemy3.AttackPower);
                        Console.Write("Player Health :"+Player.Health+" | Zeniba Health ; "+enemy3.Health+"\n");
                        break;
                        case "2" :
                        Player.Bash();
                        Player.Experience += 0.3f;
                        Console.WriteLine(Player.name+" is doing bash");
                        enemy3.GetHit(Player.AttackPower);
                        Console.WriteLine(enemy3.Name+" going to next turns");
                        Console.Write("Player Health :"+Player.Health+" | Zeniba Health ; "+enemy3.Health+"\n");
                        break;
                        case "3" :
                        Player.UseHealthPotion() ;
                        Console.WriteLine(Player.name+" use health potion");
                        Console.WriteLine("Regenarate Mana "+Player.name+" ");
                        enemy3.Attack(Player.AttackPower);
                        Player.GetHit(enemy3.AttackPower);
                        Console.Write("Player Health :"+Player.Mana+" | Zeniba Health ; "+enemy3.mana+"\n");
                        break;
                        case "4" :
                        Player.UseManaPotion() ;
                        Console.WriteLine(Player.name+" use mana potion");
                        Console.WriteLine("Regenarate Mana "+Player.name+" ");
                        enemy3.Attack(Player.AttackPower);
                        Player.GetHit(enemy3.AttackPower);
                        Console.Write("Player Health :"+Player.Mana+" | Zeniba Health ; "+enemy3.mana+"\n");
                        break;
                        case "5" :
                        Console.WriteLine(Player.name+" is running away...");
                        break;
                    }
                }
            }

                SpiritBoss boss = new SpiritBoss("Yubaba");

                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("||||||||||||||||    ▼  ▼  ▼    Chapter 4 : For Those Who Dare to Hope     ▼  ▼  ▼     |||||||||||||||");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("Zeniba turned into a holy-white light, 'thank you for freeing me.' and she went.");
                Console.WriteLine("Suddenly " +boss.Name+ " came, 'So this is a troublemaker human?!'. ");
                Console.WriteLine("'I came here because you kidnapped y parents! And I just want to go home!'. ");
                Console.WriteLine(boss.Name+ " 'HAHAHAHA if you want your parents back, you have to fight me first!'. ");
                Console.WriteLine(Player.name+" doesn't care, he steels his heart to brave for fight " +boss.Name+ ". ");
                Console.WriteLine("Haku said, 'you have to save your parents, and return you to your world.'. ");
                Console.WriteLine(boss.Name+ " 'You're just a weak human! You won't be able to fight me!'. ");
                Console.WriteLine("             Choose your action "+Player.name+" !                ");
                Console.WriteLine("             1. Strike Attack                ");
                Console.WriteLine("             2. Bash             ");
                Console.WriteLine("             3. Use Health Potion               ");
                Console.WriteLine("             4. Use Mana Potion             ");
                Console.WriteLine("             5. Go Away               ");

                while (!Player.IsDead && !boss.Death){
                     string playerAction = Console.ReadLine();
                     switch (playerAction)
                     {
                        case "1" :
                        Player.StrikeAttack();
                        Console.WriteLine(Player.name+" is doing Strike Attack");
                        boss.GetHit(Player.AttackPower);
                        Player.GetHit(boss.AttackPower);
                        boss.Attack(boss.AttackPower = Player.AttackPower * 3);
                        Console.Write("Player Health :"+Player.Health+" | Yubaba Health ; "+boss.Health+"\n");
                        break;
                        case "2" :
                        Player.Bash();
                        Player.Experience += 0.3f;
                        Console.WriteLine(Player.name+" is doing bash");
                        boss.GetHit(Player.AttackPower);
                        Console.WriteLine(boss.Name+" going to next turns");
                        Console.Write("Player Health :"+Player.Health+" | Yuababa Health ; "+boss.Health+"\n");
                        break;
                        case "3" :
                        Player.UseHealthPotion() ;
                        Console.WriteLine(Player.name+" use mana potion");
                        Console.WriteLine("Regenarate Mana "+Player.name+" ");
                        boss.Attack(Player.AttackPower);
                        Player.GetHit(boss.AttackPower);
                        Console.Write("Player Health :"+Player.Mana+" | Yubaba Health ; "+boss.Health+"\n");
                        break;
                        case "4" :
                        Player.UseManaPotion() ;
                        Console.WriteLine(Player.name+" use mana potion");
                        Console.WriteLine("Regenarate Mana "+Player.name+" ");
                        boss.Attack(Player.AttackPower);
                        Player.GetHit(boss.AttackPower);
                        Console.Write("Player Health :"+Player.Mana+" | Yubaba Health ; "+boss.mana+"\n");
                        break;
                        case "5" :
                        Console.WriteLine(Player.name+" is go away...");
                        break;
                    }
                }
            }
        }

    class Knight { 
        public int Health { get ; set; }
        public int Mana { get ; set; }
        public string name { get ; set; }
        public int AttackPower { get ; set; }
        public int Stunned { get ; set; }
        public int SkillSlot { get ; set; }
        public bool IsDead { get ; set; }
        public bool IsRunningAway{ get ; set; }
        public float Experience { get ; set; }
        Random rnd = new Random();
        public Knight(){
            Health = 1000;
            AttackPower = 40;
            IsDead = false;
            Experience = 0f;
            name = "New Player";
        }

        public void StrikeAttack () {
            AttackPower = AttackPower + rnd.Next(1,11);
        }

        public void Bash () {
            if(SkillSlot > 0){
                Stunned = 0;
                Console.WriteLine("Bash!!!");
                AttackPower = AttackPower + rnd.Next(60,71);
                SkillSlot--;
            }else{
                Console.WriteLine("You don't have anrgy!");
            }
        }

         public void GetHit (int hitValue){
             if (Stunned == 0) {
             Console.WriteLine(name+" get hit by "+hitValue);
             Health = Health - hitValue;
            }else Stunned--;
            if(Health <=0){
                 Health = 0;
                 Die();
            
            }    
        }

        public void UseHealthPotion (){
            Health = Health + 50;
            AttackPower = 0;
        }
        public void UseManaPotion (){
            Mana = Mana + 5;
            AttackPower = 0;
        }
        public void GoAway (){
            IsRunningAway = IsDead = true;
        }

        public void Die () {
            Console.WriteLine("is losing his/her soul, and fading away...");
            IsDead = true ;
        }
    }

    

    class Enemy1
    {
        public string Name { get ; set; }
        public int Health { get ; set; }
        public int AttackPower { get ; set; }
        public bool IsDead { get ; set; }
        public int mana { get ; set; }
        public int Stunned { get ; set; }
        Random rnd = new Random();

        public Enemy1(string name){
            Health = 100;
            Name = name;
        }

        public void Attack(int damage){
        if (Stunned == 0){
            AttackPower = rnd.Next(10,21);
        }
        else{
            AttackPower = 0;
            Stunned--;
        }
    }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health =Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die ();
            }
        }
        
        public void Die(){
            Console.WriteLine(Name= "the spirit was changing into a dust and died.");
            IsDead = true;
        }
    }

    class Enemy2 
    {
        public string Name { get ; set; }
        public int Health { get ; set; }
        public int AttackPower { get ; set; }
        public int mana { get ; set; }
        public int Stunned { get ; set; }
        public bool IsDead { get ; set; }
        Random rnd = new Random ();

        public Enemy2(string name){
            Health = 250;
            Name = name;
        }

       public void Attack(int damage){
        if (Stunned == 0){
            AttackPower = rnd.Next(10,21);
        }
        else{
            AttackPower = 0;
            Stunned--;
        }
    }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health -hitValue;

            if (Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Die (){
            Console.WriteLine(Name= "is losing his/her soul, and fading away");
            IsDead =  true;
        }
    }


    class Enemy3
    {
        public string Name { get ; set; }
        public int Health { get ; set; }
        public int mana { get ; set; }
        public int AttackPower { get ; set; }
        public int Stunned { get ; set; }
        public bool IsDead { get ; set; }
        Random rnd = new Random ();

        public Enemy3(string name){
            Health = 300;
            Name = name;
        }

        public void Attack(int damage){
        if (Stunned == 0){
            AttackPower = rnd.Next(10,21);
        }
        else{
            AttackPower = 0;
            Stunned--;
        }
    }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+ "get hit by"+hitValue);
            Health = Health - hitValue;

            if (Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Die(){
            Console.WriteLine(Name= "is losing his/her soul, and fading away");
            IsDead = true;
        }

    }
    
    class SpiritBoss
    {
        public string Name { get ; set; }
        public int Health { get ; set; }
        public int AttackPower { get ; set; }
        public int Stunned { get ; set; }
        public int mana { get ; set; }
        public bool Death { get ; set; }
        Random rnd = new Random ();

        public SpiritBoss(string name)
        {
            Health = 1000;
            Name = name;
        }

       public void Attack(int damage){
        if (Stunned == 0){
            AttackPower = rnd.Next(10,21);
        }
        else{
            AttackPower = 0;
            Stunned--;
        }
    }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" Get Hit = "+hitValue+" Damage");
            Health = Health - hitValue;
            if (Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Die(){
            Console.WriteLine(Name=" is losing his/her soul, and fading away ");
            Death = true;
        }
    }
}

