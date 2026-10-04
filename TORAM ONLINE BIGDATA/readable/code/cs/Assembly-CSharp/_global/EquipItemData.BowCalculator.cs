// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.BowCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 552
{
	// Fields
	private SkillMasteryBase shootMastery; // 0x18

	// Methods

	// RVA: 0x18F2434 Offset: 0x18EE434 VA: 0x18F2434
	public void .ctor(ItemData item) { }

	// RVA: 0x18F8320 Offset: 0x18F4320 VA: 0x18F8320 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18F843C Offset: 0x18F443C VA: 0x18F843C Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18F885C Offset: 0x18F485C VA: 0x18F885C Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18F8A5C Offset: 0x18F4A5C VA: 0x18F8A5C Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18F8C74 Offset: 0x18F4C74 VA: 0x18F8C74 Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18F8EDC Offset: 0x18F4EDC VA: 0x18F8EDC Slot: 10
	public override bool CorrectHit(ref int hit) { }

	// RVA: 0x18F8EFC Offset: 0x18F4EFC VA: 0x18F8EFC Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18F8F04 Offset: 0x18F4F04 VA: 0x18F8F04 Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18F8F0C Offset: 0x18F4F0C VA: 0x18F8F0C Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
