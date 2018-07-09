using Harmony;

[HarmonyPatch(typeof(Shark))]
[HarmonyPatch("ChangeState")]
class Patch_Shark_ChangeState
{
    static public void Postfix(Shark __instance)
    {
        if (__instance.state == SharkState.AttackPlayer && SharkSpy.isWearingHat)
        {
            __instance.ChangeState(SharkState.PassiveSurface);
        }
    }
}
