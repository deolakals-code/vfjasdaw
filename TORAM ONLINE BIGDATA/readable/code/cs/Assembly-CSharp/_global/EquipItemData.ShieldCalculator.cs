// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.ShieldCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 557
{
	// Methods

	// RVA: 0x18F2524 Offset: 0x18EE524 VA: 0x18F2524
	public void .ctor(ItemData item) { }

	// RVA: 0x18FC488 Offset: 0x18F8488 VA: 0x18FC488 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18FC48C Offset: 0x18F848C VA: 0x18FC48C Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18FC494 Offset: 0x18F8494 VA: 0x18FC494 Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18FC49C Offset: 0x18F849C VA: 0x18FC49C Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18FC4A4 Offset: 0x18F84A4 VA: 0x18FC4A4 Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FC4AC Offset: 0x18F84AC VA: 0x18FC4AC Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18FC688 Offset: 0x18F8688 VA: 0x18FC688 Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FC778 Offset: 0x18F8778 VA: 0x18FC778 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
