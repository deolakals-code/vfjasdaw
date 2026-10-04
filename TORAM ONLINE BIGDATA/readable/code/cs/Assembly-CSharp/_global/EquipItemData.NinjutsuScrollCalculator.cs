// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.NinjutsuScrollCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 562
{
	// Methods

	// RVA: 0x18F2614 Offset: 0x18EE614 VA: 0x18F2614
	public void .ctor(ItemData item) { }

	// RVA: 0x18FE3B0 Offset: 0x18FA3B0 VA: 0x18FE3B0 Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FE3B8 Offset: 0x18FA3B8 VA: 0x18FE3B8 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18FE3C0 Offset: 0x18FA3C0 VA: 0x18FE3C0 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }

	// RVA: 0x18FE3C8 Offset: 0x18FA3C8 VA: 0x18FE3C8 Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FE3D0 Offset: 0x18FA3D0 VA: 0x18FE3D0 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18FE3D8 Offset: 0x18FA3D8 VA: 0x18FE3D8 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18FE3E0 Offset: 0x18FA3E0 VA: 0x18FE3E0 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18FE3E4 Offset: 0x18FA3E4 VA: 0x18FE3E4 Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }
}
