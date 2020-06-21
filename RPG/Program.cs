using System;
using RPG.Engine;
using RPG.Engine.Maps;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            RPGAssets assets = new RPGAssets();
            
            string filePath = @"C:\Users\Tom\Projects\C#\RPG\RPG\Assets\Maps\Level1.txt";
            Map1 map1 = new Map1(filePath, assets.GetSprite("village") , "Potato");
            
            Console.WriteLine(map1.Height);
            Console.WriteLine(map1.Width);
            Console.WriteLine(map1.Name);
        }
    }
}