using System.Reflection;

using HarmonyLib;

using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Root;

using UnityModManagerNet;

namespace PFKModTemplate
{
    public static class Main
    {
        internal static UnityModManager.ModEntry Mod;

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            Mod = modEntry;

            var harmony = new Harmony(modEntry.Info.Id);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            return true;
        }

        [HarmonyPatch(typeof(LibraryScriptableObject), "LoadDictionary")]
        public static class LibraryScriptableObject_LoadDictionary_Patch
        {
            private static bool s_loaded = false;

            public static void Postfix()
            {
                if (s_loaded)
                {
                    return;
                }

                s_loaded = true;

                // The root blueprint has a large number of configuration and default values.
                BlueprintRoot root = ResourcesLibrary.TryGetBlueprint<BlueprintRoot>(
                    "2d77316c72b9ed44f888ceefc2a131f6"
                );
            }
        }
    }
}