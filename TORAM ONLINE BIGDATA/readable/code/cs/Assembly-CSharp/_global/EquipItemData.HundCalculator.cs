// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.HundCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 560
{
	// Fields
	private SkillMasteryBase mastery; // 0x18

	// Methods

	// RVA: 0x18F23B0 Offset: 0x18EE3B0 VA: 0x18F23B0
	public void .ctor() { }

	// RVA: 0x18FD118 Offset: 0x18F9118 VA: 0x18FD118 Slot: 4
	public override int CalcSubEqAtk(PlayerStatusBase status) { }

	// RVA: 0x18FD120 Offset: 0x18F9120 VA: 0x18FD120 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18FD1B0 Offset: 0x18F91B0 VA: 0x18FD1B0 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18FD3B0 Offset: 0x18F93B0 VA: 0x18FD3B0 Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18FD5B4 Offset: 0x18F95B4 VA: 0x18FD5B4 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18FD740 Offset: 0x18F9740 VA: 0x18FD740 Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FD850 Offset: 0x18F9850 VA: 0x18FD850 Slot: 10
	public override bool CorrectHit(ref int hit) { }

	// RVA: 0x18FD870 Offset: 0x18F9870 VA: 0x18FD870 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18FD878 Offset: 0x18F9878 VA: 0x18FD878 Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FD880 Offset: 0x18F9880 VA: 0x18FD880 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
