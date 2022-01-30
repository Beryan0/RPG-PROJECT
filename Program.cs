﻿// See https://aka.ms/new-console-template for more information
namespace PROJETO_RPG;
using static System.Console;
using PROJETO_RPG.src.classes;

class Program
{

    static void Main(string[] args)
    {
        Choose();


        // string? nome = ReadLine();
        // int id = int.Parse(ReadLine());
    }
    static void Choose()
    {
        Menu();
        string choose = ReadLine();

        while (choose != "X".ToUpper())
        {
            switch (choose)
            {
                case "1":
                    WriteLine($"{Environment.NewLine}Choose your name:");
                    Character.Creation(ReadLine());
                    break;
                case "2":
                    WriteLine($"{Environment.NewLine}Choose your weapon:");
                    Weapons.ChooseWeapon(int.Parse(ReadLine()));
                    break;
                case "3":
                    WriteLine($"{Environment.NewLine}Choose monster:");
                    Monsters.ChooseMonster(int.Parse(ReadLine()));
                    break;
                case "4":
                    Monsters.List(Monsters.monster);
                    break;
                case "5":
                    Weapons.List(Weapons.weapon);
                    break;
                // case "6":
                //     Console.Clear();
                //     break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            Menu();
            choose = ReadLine().ToUpper();
        }

    }
    static void Menu()
    {
        WriteLine(@$"
Welcome, choose your option
1- Create your character
2- Choose your weapon
3- Choose monster to fight
4- List Monsters
5- List Weapons
6- Open game tutorial
7- Go to battle
X- Leave");
    }
}


