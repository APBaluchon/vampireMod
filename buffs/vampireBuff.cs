using Terraria.ID;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace vampireMod.buffs
{
    internal class vampireBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
            DisplayName.SetDefault("Vampire !");
            Description.SetDefault("You are now a vampire.");

        }



        public override void Update(Player player, ref int buffIndex)
        {
            if (Main.dayTime)
            {
                if (player.HasBuff(buffIndex))
                {
                    if (Collision.CanHitLine(player.position, 1, 1, new Vector2(player.position.X, 0), 1, 1));
                    {
                        player.Hurt(PlayerDeathReason.ByCustomReason("Burned by the sun !"), 1, -player.direction);
                    }
                }
                else
                {
                    player.AddBuff(buffIndex, 1);
                }
            }

        }
    }
}
