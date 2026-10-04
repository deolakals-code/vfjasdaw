// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.KnuckleCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 556
{
	// Fields
	private SkillMasteryBase mastery; // 0x18

	// Methods

	// RVA: 0x18F24F4 Offset: 0x18EE4F4 VA: 0x18F24F4
	public void .ctor(ItemData item) { }

	// RVA: 0x18FB354 Offset: 0x18F7354 VA: 0x18FB354 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18FB470 Offset: 0x18F7470 VA: 0x18FB470 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18FB78C Offset: 0x18F778C VA: 0x18FB78C Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18FBA20 Offset: 0x18F7A20 VA: 0x18FBA20 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18FBD70 Offset: 0x18F7D70 VA: 0x18FBD70 Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FBEA4 Offset: 0x18F7EA4 VA: 0x18FBEA4 Slot: 10
	public override bool CorrectHit(ref int hit) { }

	// RVA: 0x18FBEC4 Offset: 0x18F7EC4 VA: 0x18FBEC4 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18FC11C Offset: 0x18F811C VA: 0x18FC11C Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FC220 Offset: 0x18F8220 VA: 0x18FC220 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
