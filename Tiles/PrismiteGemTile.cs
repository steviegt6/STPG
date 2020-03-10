using Microsoft.Xna.Framework;
using STPG.Items;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using ThoriumMod.Items;
//using static Terraria.ModLoader.ModContent;

namespace STPG.Tiles
{
	public class PrismiteGemTile : ModTile
	{
		private static Mod thorium = ModLoader.GetMod("ThoriumMod");
		static int[] gems = { ItemID.Amber, ItemID.Diamond, ItemID.Ruby, ItemID.Emerald, ItemID.Sapphire, ItemID.Topaz, ItemID.Amethyst, thorium.ItemType("Onyx"), thorium.ItemType("Pearl"), thorium.ItemType("Opal") };
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileStone[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 1200;
			dustType = 236;
			soundType = 21;
			soundStyle = 2;
			//drop = mod.ItemType("PrismiteGem");
			Main.tileSpelunker[Type] = true;
		}
		public override void KillTile(int i, int j, ref bool fail, ref bool effectOnly, ref bool noItem)
		{
			if (Main.rand.Next(1, 6) == 1)
			{
				Item.NewItem(i * 16, j * 16, 32, 48, ItemType<PrismiteGem>());
			}
			else
			{
				int drop = Main.rand.Next(0, gems.Length);
				Item.NewItem(i * 16, j * 16, 32, 48, drop);
			}
		}
	}
}
