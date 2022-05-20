using System;

class Program {
    public static void Main (string[] args) {
        if (args[0] == "ckp")
            Console.WriteLine(Console.ReadKey().KeyChar);
    }
}