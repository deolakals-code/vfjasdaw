// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.KatanaCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 563
{
	// Fields
	private SkillMasteryBase mastery; // 0x18

	// Methods

	// RVA: 0x18F25E4 Offset: 0x18EE5E4 VA: 0x18F25E4
	public void .ctor(ItemData item) { }

	// RVA: 0x18FE3EC Offset: 0x18FA3EC VA: 0x18FE3EC Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18FE4B4 Offset: 0x18FA4B4 VA: 0x18FE4B4 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18FE7C4 Offset: 0x18FA7C4 VA: 0x18FE7C4 Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FE988 Offset: 0x18FA988 VA: 0x18FE988 Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18FEB98 Offset: 0x18FAB98 VA: 0x18FEB98 Slot: 10
	public override bool CorrectHit(ref int hit) { }

	// RVA: 0x18FEBB8 Offset: 0x18FABB8 VA: 0x18FEBB8 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18FEDD0 Offset: 0x18FADD0 VA: 0x18FEDD0 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18FF2E4 Offset: 0x18FB2E4 VA: 0x18FF2E4 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }

	// RVA: 0x18FF2EC Offset: 0x18FB2EC VA: 0x18FF2EC Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }
}
