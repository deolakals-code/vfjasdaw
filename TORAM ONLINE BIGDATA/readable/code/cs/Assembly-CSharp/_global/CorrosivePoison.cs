// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CorrosivePoison : SkillMasteryBase // TypeDefIndex: 3419
{
	// Methods

	// RVA: 0x23589AC Offset: 0x23549AC VA: 0x23589AC
	public void .ctor(SkillData data) { }

	// RVA: 0x23589DC Offset: 0x23549DC VA: 0x23589DC Slot: 4
	public override int GetMasteryParam(MasteryId id) { }

	// RVA: 0x23589E4 Offset: 0x23549E4 VA: 0x23589E4
	public static int CalcPercent(byte skillLevel, byte poisonLevel) { }

	// RVA: 0x2358A24 Offset: 0x2354A24 VA: 0x2358A24
	public static bool CalcCorrosivePoison(PlayerActionManagerBase playerAction, EnemyMobActionManagerBase mobAction, SkillDamageData damageData, out AbnormalType poisonType) { }
}
