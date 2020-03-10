using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace STPG.Items
{
	public class PrismiteGem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Prismite");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 18;
			item.maxStack = 999;
			item.scale = 1.2f;
			item.value = Item.sellPrice(0, 0, 30, 0);
			item.rare = ItemRarityID.Expert; //-13
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			//item.createTile = base.mod.TileType("PlacedGem");
			item.placeStyle = 1;
		}
	}
}
