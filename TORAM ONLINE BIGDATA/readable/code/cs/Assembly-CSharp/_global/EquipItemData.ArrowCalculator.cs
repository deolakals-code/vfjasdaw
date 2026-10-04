// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.ArrowCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 558
{
	// Methods

	// RVA: 0x18F2584 Offset: 0x18EE584 VA: 0x18F2584
	public void .ctor(ItemData item) { }

	// RVA: 0x18FC830 Offset: 0x18F8830 VA: 0x18FC830 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18FC834 Offset: 0x18F8834 VA: 0x18FC834 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18FC83C Offset: 0x18F883C VA: 0x18FC83C Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18FC844 Offset: 0x18F8844 VA: 0x18FC844 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18FC84C Offset: 0x18F884C VA: 0x18FC84C Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FC854 Offset: 0x18F8854 VA: 0x18FC854 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18FCA88 Offset: 0x18F8A88 VA: 0x18FCA88 Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FCC18 Offset: 0x18F8C18 VA: 0x18FCC18 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
