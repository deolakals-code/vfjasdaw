// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.BowgunCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 553
{
	// Fields
	private SkillMasteryBase mastery; // 0x18

	// Methods

	// RVA: 0x18F2464 Offset: 0x18EE464 VA: 0x18F2464
	public void .ctor(ItemData item) { }

	// RVA: 0x18F8F14 Offset: 0x18F4F14 VA: 0x18F8F14 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18F9030 Offset: 0x18F5030 VA: 0x18F9030 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18F9388 Offset: 0x18F5388 VA: 0x18F9388 Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18F9588 Offset: 0x18F5588 VA: 0x18F9588 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18F979C Offset: 0x18F579C VA: 0x18F979C Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18F9914 Offset: 0x18F5914 VA: 0x18F9914 Slot: 10
	public override bool CorrectHit(ref int hit) { }

	// RVA: 0x18F9934 Offset: 0x18F5934 VA: 0x18F9934 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18F993C Offset: 0x18F593C VA: 0x18F993C Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18F9944 Offset: 0x18F5944 VA: 0x18F9944 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
