using System;

class MainClass {
    public static void Main (string[] args) {
        string name;

        Console.Writeline ("Please enter your name:");
        name = Console.ReadLine();
        Console.Writeline("Hello " + name + "!");
    }
}