// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.RodCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 554
{
	// Methods

	// RVA: 0x18F2494 Offset: 0x18EE494 VA: 0x18F2494
	public void .ctor(ItemData item) { }

	// RVA: 0x18F994C Offset: 0x18F594C VA: 0x18F994C Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18F9A08 Offset: 0x18F5A08 VA: 0x18F9A08 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18F9CF8 Offset: 0x18F5CF8 VA: 0x18F9CF8 Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18F9FE4 Offset: 0x18F5FE4 VA: 0x18F9FE4 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18FA1FC Offset: 0x18F61FC VA: 0x18FA1FC Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FA330 Offset: 0x18F6330 VA: 0x18FA330 Slot: 10
	public override bool CorrectHit(ref int hit) { }

	// RVA: 0x18FA350 Offset: 0x18F6350 VA: 0x18FA350 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18FA358 Offset: 0x18F6358 VA: 0x18FA358 Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FA360 Offset: 0x18F6360 VA: 0x18FA360 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
