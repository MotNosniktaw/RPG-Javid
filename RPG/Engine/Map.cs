using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace RPG.Engine
{
    public class Map
    {
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;
        public string Name { get; set; } = "";
        public Sprite Sprite { get; set; } = null;

        private int[] Indices = null;
        private bool[] Solids = null;

        public Map(string filePath, Sprite sprite, string name)
        {
            Create(filePath, sprite, name);
        }

        public int GetIndex(int x, int y)
        {
            if (x >= 0 && x < Width && y >= 0 && y < Height)
            {
                return Indices[y * Width + x];
            }
            else
            {
                return 0;
            }
        }

        public bool GetSolid(int x, int y)
        {
            if (x >= 0 && x < Width && y >= 0 && y < Height)
            {
                return Solids[y * Width + x];
            }
            else
            {
                return true;
            }
        }

        public void Create(string fileData, Sprite sprite, string name)
        {
            Sprite = sprite;
            Name = name;

            if (File.Exists(fileData))
            {
                string text = File.ReadAllText(fileData);
                var words = text.Split(" ");

                Width = Int32.Parse(words[0]);
                Height = Int32.Parse(words[1]);

                var counter = 2;

                var indicesList = new List<int>();
                var solidsList = new List<bool>();
                
                while (counter < words.Length)
                {
                    indicesList.Add(Int32.Parse(words[counter]));
                    counter++;
                    solidsList.Add(words[counter] == "1");
                    counter++;
                }

                Indices = indicesList.ToArray();
                Solids = solidsList.ToArray();
            }
            else
            {
                Console.WriteLine("No File");
            }
            
        }
    }

}