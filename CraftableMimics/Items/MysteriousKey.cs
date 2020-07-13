using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftableMimics.Items
{
    public class MysteriousKey : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Misterious key");
            Tooltip.SetDefault("He slowly shimmers with incomprehensible energy...\nSummons wooden, gold, shadow and ice mimic depending on the biome -\n on the surface, in the underworld, in hell and in caves under snow biome");
        }

        public override void SetDefaults()
        {
            item.maxStack = 20;
            item.rare = ItemRarityID.Red;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
        }

        public override bool UseItem(Player player)
        {
            NPC.NewNPC( (int)player.position.X + player.direction * 200, (int)player.position.Y, NPCID.Mimic);

            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.anyWood = true;
            recipe.AddIngredient(ItemID.GoldBar, 2);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddIngredient(ItemID.IceBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.SoulofLight, 10);
            recipe2.AddIngredient(ItemID.SoulofNight, 10);
            recipe2.AddIngredient(ItemID.Wood, 10);
            recipe2.anyWood = true;
            recipe2.AddIngredient(ItemID.PlatinumBar, 2);
            recipe2.AddIngredient(ItemID.Obsidian, 10);
            recipe2.AddIngredient(ItemID.IceBlock, 10);
            recipe2.AddTile(TileID.WorkBenches);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}