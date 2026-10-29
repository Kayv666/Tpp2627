using System.Formats.Asn1;

class Character
{
    string name;
    int hp;
    int power;
    static int count;
    public Character(string name, int hp,int power){
        this.name=name;
        this.hp=hp;
        this.power=power;
        count++;
    }
    public string Name
    {
        get{return name;}
    }
    public int Hp
    {
        get{return hp;}
    }
        public int Power
    {
        get{return power;}
    }
    private void TakeDamage(int damage)
    {
        hp=Hp-damage;
    }
    public void Attack(Character target)
    {
        target.TakeDamage(this.power);
        if(target.IsAlive()){Console.WriteLine($"{target.name} было нанесено {this.power} урона");}
        else{Console.WriteLine($"{target.Name} умер");}
    }
    public bool IsAlive()
    {
        if (Hp>0){return true;}
        else {return false;}
    }
    public void GetStatus()
    {
        Console.WriteLine($"У {this.name} {this.hp} здоровья и {this.power} силы");
    }
    public static void HowMany()
    {
        Console.WriteLine($"Было создано {count} персонажей");
    }
    public static void IsValidStats(Character check)
    {
        if (check.Hp <= 0)
        {
            Console.WriteLine("Недопустимое значение здоровья. Здоровье меняется на 1");
            check.hp=1;
        }
        if (check.Power <= 0)
        {
            Console.WriteLine("Недопустимое значение силы. Сила меняется на 1");
            check.power=1;
        }
    }

}
class Player : Character
{
    string name;
    int hp;
    int power;
    public Player(string name, int hp, int power) : base(name, hp, power)
    {
        
    }
}
class Enemy : Character
{
    string name;
    int hp;
    int power;
    public Enemy(string name,int hp, int power):base(name,hp,power){}
}
internal class Program
{
    private static void Main(string[] args)
    {
       
    }
}