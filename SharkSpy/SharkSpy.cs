using Harmony;
using System.Reflection;

[ModTitle("SharkSpy")]
[ModDescription("Wearing the shark's head will keep the shark from attacking you while you're in the water.")]
[ModAuthor("AquatikJustice")]
[ModVersion("1.0")]
[RaftVersion("1.03")]
public class SharkSpy : Mod
{
    HarmonyInstance instance;
    public static bool isWearingHat = Slot_Equip.GetEquipSlotWithTag(EquipSlotType.Hat);

    public void Start()
    {
        instance = HarmonyInstance.Create("com.aquatikjustice.SharkSpy");
        instance.PatchAll(Assembly.GetExecutingAssembly());
    }

    public static void Log(string text)
    {
        //RConsole.Log($"<b><color=#129aab>{text}</color></b>");
    }
}