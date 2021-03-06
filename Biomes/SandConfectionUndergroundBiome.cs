using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Biomes
{
    public class SandConfectionUndergroundBiome : ModBiome
    {
        public override string BestiaryIcon => "Biomes/BestiaryIcon6";

        public override string BackgroundPath => "Biomes/ConfectionUndergroundDesertMapBackground";

        public override Color? BackgroundColor => base.BackgroundColor;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Confection Cave Desert");
        }
    }
}
