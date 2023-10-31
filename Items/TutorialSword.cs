using Terraria;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Items
{
	public class TutorialSword : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.TutorialMod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 1000;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.PlayerHit;
			Item.autoReuse = true;
			
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddIngredient(ItemID.StoneBlock, 10);
			recipe.AddTile(TileID.Dirt);
			recipe.Register();
		}
	}
}