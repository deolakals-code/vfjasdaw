// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PoisonMixer : SkillMasteryBase // TypeDefIndex: 3482
{
	// Methods

	// RVA: 0x235D820 Offset: 0x2359820 VA: 0x235D820
	public void .ctor(SkillData skillData) { }

	// RVA: 0x235D850 Offset: 0x2359850 VA: 0x235D850 Slot: 4
	public override int GetMasteryParam(MasteryId id) { }

	// RVA: 0x235D858 Offset: 0x2359858 VA: 0x235D858
	public static bool CheckActive(PlayerStatusBase status, out byte skillLv) { }

	// RVA: 0x235D968 Offset: 0x2359968 VA: 0x235D968
	public static float GetDeathReceptionSingleAttackSkillRate(byte lv, PlayerStatusBase status) { }

	// RVA: 0x235D9D0 Offset: 0x23599D0 VA: 0x235D9D0
	public static float GetDeathReceptionRangeAttackSkillRate(byte lv, PlayerStatusBase status) { }

	// RVA: 0x235DA38 Offset: 0x2359A38 VA: 0x235DA38
	public static void EffectiveAbnormalPoison(SkillDamageData damageData, byte lv) { }
}
