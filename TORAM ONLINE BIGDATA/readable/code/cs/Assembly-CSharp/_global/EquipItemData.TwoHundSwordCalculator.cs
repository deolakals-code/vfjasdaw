// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.TwoHundSwordCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 551
{
	// Fields
	private SkillMasteryBase mastery; // 0x18

	// Methods

	// RVA: 0x18F2404 Offset: 0x18EE404 VA: 0x18F2404
	public void .ctor(ItemData item) { }

	// RVA: 0x18F78DC Offset: 0x18F38DC VA: 0x18F78DC Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18F79F8 Offset: 0x18F39F8 VA: 0x18F79F8 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18F7D08 Offset: 0x18F3D08 VA: 0x18F7D08 Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18F7F08 Offset: 0x18F3F08 VA: 0x18F7F08 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18F81C8 Offset: 0x18F41C8 VA: 0x18F81C8 Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18F82E8 Offset: 0x18F42E8 VA: 0x18F82E8 Slot: 10
	public override bool CorrectHit(ref int hit) { }

	// RVA: 0x18F8308 Offset: 0x18F4308 VA: 0x18F8308 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18F8310 Offset: 0x18F4310 VA: 0x18F8310 Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18F8318 Offset: 0x18F4318 VA: 0x18F8318 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
