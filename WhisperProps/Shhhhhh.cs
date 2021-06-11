using System.Reflection;
using Harmony;

namespace WhisperProps
{
    public class Shhhhhh
    {
        public static void Silence()
        {
            //Initiate the madness
            HarmonyInstance harmonyInstance = HarmonyInstance.Create("legionite.whisperprops.core");
            harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
    internal class Patches
    {
        [HarmonyPatch(typeof(ModuleBooster))]
        [HarmonyPatch("OnPool")]
        private class ShhhhhhushMyChild
        {
            private static void Postfix(ModuleBooster __instance)
            {
                FieldInfo lockGet = typeof(ModuleBooster).GetField("m_BoosterAudioType", BindingFlags.NonPublic | BindingFlags.Instance);
                int m_BoosterAudioType = (int)lockGet.GetValue(__instance);
                if (m_BoosterAudioType == (int)TechAudio.BoosterEngineType.Propeller)
                {
                    lockGet.SetValue(__instance, (int)TechAudio.BoosterEngineType.MediumRotor);
                }
            }
        }
    }
}
