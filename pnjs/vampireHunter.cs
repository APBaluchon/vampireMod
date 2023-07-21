using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.ModLoader.Utilities;

namespace vampireMod.pnjs
{
    internal class vampireHunter : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.Clothier];
        }

        public override void SetDefaults()
        {
            NPC.width = 18;
            NPC.height = 40;
            NPC.damage = 14;
            NPC.defense = 6;
            NPC.lifeMax = 120;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.aiStyle = NPCAIStyleID.Fighter;
            NPC.friendly = false;

            AIType = NPCAIStyleID.Fighter;
            AnimationType = NPCAIStyleID.Fighter;


        }

        public override void AI()
        {
            Lighting.AddLight(NPC.position, TorchID.White);
        }
    }   
}
