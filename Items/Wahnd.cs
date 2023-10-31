using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace TutorialMod.Items
{
    public class Wahnd : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 500;
            Item.DamageType = DamageClass.Magic;
        }
    }
}
