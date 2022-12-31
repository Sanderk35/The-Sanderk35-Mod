using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using TheSanderk35Mod.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

namespace TheSanderk35Mod
{
    // These are the mods required for our Mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our Mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our Mod Is associated with
    [BepInProcess("Rounds.exe")]
    public class TutorialMod :  BaseUnityPlugin
    {
        private const string ModId = "com.My.Mod.Id";
        private const string ModName = "The Sanderk35 Mod";
        public const string Version = "1.0.2"; // What version are we On (major.minor.patch)?
        public const string ModInitials = "TSM";

        void Awake()
        {
            // Use this to call any harmony patch files your Mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            CustomCard.BuildCard<Minigun>();
        }
    }
}
