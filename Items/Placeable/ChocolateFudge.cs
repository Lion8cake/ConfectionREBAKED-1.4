using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Items.Placeable
{
    public class ChocolateFudge : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chocolate Fudge");
            Tooltip.SetDefault("A honey like chocolate block");
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.maxStack = 999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.ChocolateFudge>();
        }

        public override void AddRecipes()
        {
            CreateRecipe(30).AddIngredient(ModContent.ItemType<Items.Placeable.Creamsand>(), 30).AddIngredient(1134, 1).AddTile(TileID.WorkBenches).Register();
        }
    }
}
