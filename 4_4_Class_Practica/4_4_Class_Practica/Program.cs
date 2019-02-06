using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_Class_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior noname = new Warrior();
            Warrior petya = new Warrior("Petya", "Human", 2);
            MagicWarrior ilya = new MagicWarrior("Ilya", 110);
            petya.HealhtDown();
            petya.Show();
            ilya.Show();
            Console.WriteLine(petya.Name);
            Warrior.DisplayCount(); // К статическим методам можно обращаться напрямую по имени класса
            Console.ReadKey();
        }
    }
    class Warrior
    {
        //Поля
        private int health = 100;
        private string name;
        private string race;
        int lvl = 1;
        protected static int count = 0;

        //Конструктор
        public Warrior()
        {
            this.name = "noname";
            this.race = "no";
            count++;
        }
        public Warrior(string thisName, string thisRace)
        {
            this.name = thisName;
            this.race = thisRace;
            count++;
        }
        public Warrior(string thisName, string thisRace, int thisLVL)
        {
            this.name = thisName;
            this.race = thisRace;
            this.lvl = thisLVL;
            count++;
        }
        //Методы
        public void Show()
        {
            Console.Write($"Hero is {name};\n level is {lvl};\n health is {health};\n");
        }
        public int HealhtDown()
        {
            return this.health -= 10;
        }
        //static метод
        public static void DisplayCount()
        {
            Console.WriteLine($"Was created {count} warrior");
        }
        //Cвойства
        public string Name
        {
            get { return name; }
            set{ name = value; }
        } 
        //Автоматическое свойство ???
        public int Race { get; set; }
    }
    class MagicWarrior : Warrior
    {
        private int magic = 100;
        //Конструктор дочернего класса
        public MagicWarrior(string thisName1, int thisMagic)
        {
            Name = thisName1;
            this.magic = thisMagic;
        }
        public void Show()
        {
            Console.Write($"Hero is {Name};\n Magic is {magic}");
        }
    }
}
