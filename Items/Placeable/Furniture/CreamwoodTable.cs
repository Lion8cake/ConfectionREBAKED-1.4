using TheConfectionRebirth.Tiles;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace TheConfectionRebirth.Items.Placeable.Furniture
{
	public class CreamwoodTable : ModItem
	{
		public override void SetStaticDefaults() 
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 20;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = Mod.Find<ModTile>("CreamwoodTable").Type;
		}
		
		public override void AddRecipes()
		{
			CreateRecipe(1).AddIngredient(null, "CreamWood", 8).AddTile(TileID.WorkBenches).Register();
		}
	}
}