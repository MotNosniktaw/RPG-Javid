using System;

namespace RPG.Engine
{
    public class Sprite
    {
        public int Height = 0;
        public int Width = 0;

        public Sprite(string fileName)
        {
            if (!Load(fileName))
            {
                Create(8, 8);
            }
        }

        private bool Load(string fileName)
        {
            return true;
        }

        private void Create(int w, int h)
        {
            Height = h;
            Width = w;
        }
    }
}