// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.MagictoolCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 555
{
	// Methods

	// RVA: 0x18F24C4 Offset: 0x18EE4C4 VA: 0x18F24C4
	public void .ctor(ItemData item) { }

	// RVA: 0x18FA368 Offset: 0x18F6368 VA: 0x18FA368 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18FA424 Offset: 0x18F6424 VA: 0x18FA424 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18FA710 Offset: 0x18F6710 VA: 0x18FA710 Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18FA9FC Offset: 0x18F69FC VA: 0x18FA9FC Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18FAC10 Offset: 0x18F6C10 VA: 0x18FAC10 Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FAD3C Offset: 0x18F6D3C VA: 0x18FAD3C Slot: 10
	public override bool CorrectHit(ref int hit) { }

	// RVA: 0x18FAD5C Offset: 0x18F6D5C VA: 0x18FAD5C Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18FAF90 Offset: 0x18F6F90 VA: 0x18FAF90 Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FB120 Offset: 0x18F7120 VA: 0x18FB120 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
