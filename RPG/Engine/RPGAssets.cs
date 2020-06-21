using System.Collections.Generic;

namespace RPG.Engine
{
    public class RPGAssets
    {
        public RPGAssets()
        {
            LoadSprites();
        }

        private IDictionary<string, Sprite> MapSprites { get; set; } = new Dictionary<string, Sprite>();

        private void Load(string name, string fileName)
        {
            var s = new Sprite(fileName);
            MapSprites[name] = s;
        }

        private void LoadSprites()
        {
            Load("village", "./Assets/Graphics/toml_spritesheetdark.spr");
        }

        public Sprite GetSprite(string name)
        {
            return MapSprites[name];
        }
    }
}