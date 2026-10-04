// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.OneHundSwordCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 550
{
	// Fields
	private SkillMasteryBase mastery; // 0x18

	// Methods

	// RVA: 0x18F23D4 Offset: 0x18EE3D4 VA: 0x18F23D4
	public void .ctor(ItemData item) { }

	// RVA: 0x18F61DC Offset: 0x18F21DC VA: 0x18F61DC Slot: 4
	public override int CalcSubEqAtk(PlayerStatusBase status) { }

	// RVA: 0x18F6368 Offset: 0x18F2368 VA: 0x18F6368 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18F6484 Offset: 0x18F2484 VA: 0x18F6484 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18F6A60 Offset: 0x18F2A60 VA: 0x18F6A60 Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18F6C60 Offset: 0x18F2C60 VA: 0x18F6C60 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18F6F20 Offset: 0x18F2F20 VA: 0x18F6F20 Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18F70E4 Offset: 0x18F30E4 VA: 0x18F70E4 Slot: 10
	public override bool CorrectHit(ref int hit) { }

	// RVA: 0x18F7104 Offset: 0x18F3104 VA: 0x18F7104 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18F76CC Offset: 0x18F36CC VA: 0x18F76CC Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18F78D4 Offset: 0x18F38D4 VA: 0x18F78D4 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
