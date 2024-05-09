using System;
using System.Collections.Generic;
namespace Examples
{
    public interface IWeight
    {
        public float Weight { get; set; }
    }
    public interface ISpeed
    {
        public float Speed { get; set; }
    }
    public interface IUsableWithOneHand
    {
        public void Use();
    }
    public abstract class Organism
    {
        public string Name { get; set; }
        public Organism(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Organism: " + Name;
        }
    }
    public class Plant : Organism
    {
        public float WaterAmount => nutrients.TryGetValue("Water", out float water) ? water : 0;
        public float Length { get; set; }
        protected Dictionary<string, float> nutrients = new Dictionary<string, float>();
        public Plant(string name) : base(name)
        {
        }
        public void AddNutrient(string nutrient, float amount)
        {
            if (amount <= 0) return;
            nutrients.Add(nutrient, amount);
        }
        public void RemoveNutrient(string nutrient)
        {
            if (nutrients.ContainsKey(nutrient))
                nutrients.Remove(nutrient);
        }
        public override string ToString()
        {
            string str = "Plant: " + Name + "\n";
            foreach (KeyValuePair<string, float> nutrient in nutrients)
            {
                str += nutrient.Key + ": " + nutrient.Value + "\n";
            }
            return str;
        }
    }
    public class Fruit : Plant
    {
        public float SugarAmount => nutrients.TryGetValue("Sugar", out float sugar) ? sugar : 0;
        public Fruit(string name) : base(name)
        {
        }
    }
    public class Vegetable : Plant
    {
        public float FiberAmount => nutrients.TryGetValue("Fiber", out float fiber) ? fiber : 0;
        public Vegetable(string name) : base(name)
        {
        }
    }
    public class Animal : Organism, IWeight, ISpeed
    {
        public float Weight { get; set; }
        public float Length { get; set; }
        public float Speed { get; set; }
        public Animal(string name, float weight) : base(name)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            return "Animal: " + Name + ", Weight: " + Weight;
        }
    }
    public class Bird : Animal
    {
        public float WingLength { get; set; }
        public Bird(string name, float weight) : base(name, weight)
        {
        }
    }
    public class Fish : Animal
    {
        public float FinLength { get; set; }
        public Fish(string name, float weight) : base(name, weight)
        {
        }
    }
    public class Object : IWeight
    {
        public float Weight { get; set; }
    }
    public class Vehicle : Object, ISpeed
    {
        public float Speed { get; set; }
    }
    public abstract class Ware : Object
    {

    }
    public class Phone : Ware, IUsableWithOneHand
    {
        public void Use()
        {
            Console.WriteLine("Using phone with one hand");
        }
    }
    public abstract class Computer : Ware
    {
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public abstract void Move();
    }
    public class Laptop : Computer
    {
        public override void Move()
        {
            Console.WriteLine("Moving laptop");
        }
    }
    public class Desktop : Computer
    {
        public override void Move()
        {
            Console.WriteLine("Moving desktop");
        }
    }
    public abstract class KitchenWare : Ware
    {
        public string[] Materials { get; set; }
    }
    public class Knife : KitchenWare, IUsableWithOneHand
    {
        public void Use()
        {
            Console.WriteLine("Using knife with one hand");
        }
    }
    public class Spoon : KitchenWare, IUsableWithOneHand
    {
        public void Use()
        {
            Console.WriteLine("Using spoon with one hand");
        }
    }
    public class Fork : KitchenWare, IUsableWithOneHand
    {
        public void Use()
        {
            Console.WriteLine("Using fork with one hand");
        }
    }
}