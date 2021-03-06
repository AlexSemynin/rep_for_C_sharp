﻿using System;
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
            MagicWarrior ilya = new MagicWarrior("Ilya", "Ork", 110);
            petya.HealhtDown();
            petya.Show();
            ilya.Show();
            Console.WriteLine(petya.Name);
            Warrior.DisplayCount(); // К статическим методам можно обращаться напрямую по имени класса
            Console.ReadKey();
        }
    }
    public class Warrior
    {
        //Поля
        private int health = 100;
        private string name;
        protected string race;
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
        public Warrior(string thisName, string thisRace, int thisLVL) : this(thisName, thisRace)  // перегруженный конструктор, ccылается на конструктор с 2-мя входными параметами
        {                                                                                         //конструктор текущий(this)
            this.lvl = thisLVL;
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
           /// set{ name = value; }
        } 
        //Автоматическое свойство ???
        public int Race { get; set; }

        public void Rage()
        {
            Console.WriteLine("RARARA");
            name = "RARA";
        }

        public int HP { get; set; }
    }
    class MagicWarrior : Warrior
    {
        private int magic = 100;
        private Warrior _warrior;

        //Конструктор дочернего класса
        public MagicWarrior(string thisName1, string thisRace, int thisMagic) : base(thisName1, thisRace)
        {
            this.magic = thisMagic;
            _warrior = new Warrior();
        }

        public int GetHP()
        {
            return _warrior.HP + 100;
        }

        public void Show()
        {
            Console.Write($"Hero is {Name};\n Race is {race} Magic is {magic}\n");
        }

        private int _i;

        public int i2 { get { return _i; } private set { } }

        public int T { get; set; }

        public void Click()
        {
            _i++;
        }

        public int GetClickCount()
        {
            return i;
        }
    }
}
