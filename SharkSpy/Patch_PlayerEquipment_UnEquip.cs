using Harmony;

[HarmonyPatch(typeof(PlayerEquipment))]
[HarmonyPatch("UnEquip")]
class Patch_PlayerEquipment_UnEquip
{
    static public void Postfix()
    {
        Slot_Equip equipSlotWithTag = Slot_Equip.GetEquipSlotWithTag(EquipSlotType.Hat);

        if (equipSlotWithTag != null)
        {
            SharkSpy.isWearingHat = true;
        }
        else
        {
            SharkSpy.isWearingHat = false;
        }
    }
}