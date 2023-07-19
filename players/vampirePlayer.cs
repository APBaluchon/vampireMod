using IL.Terraria;
using Terraria.ModLoader;
using vampireMod.buffs;


namespace vampireMod.players
{
    internal class vampirePlayer : ModPlayer
    {
        public override void OnEnterWorld(Terraria.Player player)
        {
            Player.hairColor = new Microsoft.Xna.Framework.Color(10, 10, 10);
            Player.skinColor = new Microsoft.Xna.Framework.Color(230, 230, 230);
        }
    }
}
