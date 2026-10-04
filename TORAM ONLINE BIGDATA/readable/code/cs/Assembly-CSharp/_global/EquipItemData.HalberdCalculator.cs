// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.HalberdCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 561
{
	// Fields
	private SkillMasteryBase mastery; // 0x18

	// Methods

	// RVA: 0x18F25B4 Offset: 0x18EE5B4 VA: 0x18F25B4
	public void .ctor(ItemData item) { }

	// RVA: 0x18FD938 Offset: 0x18F9938 VA: 0x18FD938 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18FDA04 Offset: 0x18F9A04 VA: 0x18FDA04 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18FDD30 Offset: 0x18F9D30 VA: 0x18FDD30 Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FDEF0 Offset: 0x18F9EF0 VA: 0x18FDEF0 Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18FE168 Offset: 0x18FA168 VA: 0x18FE168 Slot: 10
	public override bool CorrectHit(ref int hit) { }

	// RVA: 0x18FE188 Offset: 0x18FA188 VA: 0x18FE188 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18FE398 Offset: 0x18FA398 VA: 0x18FE398 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18FE3A0 Offset: 0x18FA3A0 VA: 0x18FE3A0 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }

	// RVA: 0x18FE3A8 Offset: 0x18FA3A8 VA: 0x18FE3A8 Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }
}
