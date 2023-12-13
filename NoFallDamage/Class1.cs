using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using NoFallDamage.Patches;

namespace NoFallDamage
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class NoFallDamageClass : BaseUnityPlugin
    {
        private const string modGUID = "jaceob.NoFallDamage";
        private const string modName = "No Fall Damage";
        private const string modVersion = "1.0.1";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static NoFallDamageClass instance;

        internal ManualLogSource logSource;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            logSource = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            logSource.LogInfo("No Fall Damage mod started!");

            harmony.PatchAll(typeof(NoFallDamageClass));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }
    }
}
