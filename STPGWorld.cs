using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ModLoader;
using Terraria.World.Generation;

namespace STPG
{
	public class STPGWorld : ModWorld
	{
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("STPG: Generating Prismite Gems...", PrismiteGem));
			}
		}
		private void PrismiteGem(GenerationProgress progress)
		{
			progress.Message = "STPG: Generating Prismite Gems...";
			for (int i = 0; (float)i < (float)((Main.maxTilesX - 200) * Main.maxTilesY) * 0.2f / 7000f; i++)
			{
				WorldGen.TileRunner(WorldGen.genRand.Next(100, Main.maxTilesX - 100), WorldGen.genRand.Next((int)((float)Main.maxTilesY * 0.35f), Main.maxTilesY - 300), WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(3, 6), ModContent.TileType<Tiles.PrismiteGemTile>());
			}
		}
		public STPGWorld()
		{
		}
	}
}