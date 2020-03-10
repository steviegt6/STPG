using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace STPG.Tiles
{
	public class PrismiteGemTile : ModTile
	{
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
			drop = mod.ItemType("PrismiteGem");
			Main.tileSpelunker[Type] = true;
		}
	}
}
