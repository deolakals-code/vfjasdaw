// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public abstract class EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 549
{
	// Fields
	protected ItemData item; // 0x10

	// Properties
	public ItemDBData.ItemType WeaponType { get; }

	// Methods

	// RVA: 0x18F4704 Offset: 0x18F0704 VA: 0x18F4704
	public ItemDBData.ItemType get_WeaponType() { }

	// RVA: 0x18F471C Offset: 0x18F071C VA: 0x18F471C
	public void .ctor(ItemData item) { }

	// RVA: 0x18F474C Offset: 0x18F074C VA: 0x18F474C
	public int CalcEqAtk(PlayerStatusBase status) { }

	// RVA: 0x18F4DD0 Offset: 0x18F0DD0 VA: 0x18F4DD0 Slot: 4
	public virtual int CalcSubEqAtk(PlayerStatusBase status) { }

	// RVA: 0x18F4E74 Offset: 0x18F0E74 VA: 0x18F4E74
	public int CalcAtk(PlayerStatusBase status, out int plusBaseValue, out int plusValue, out float plusRateValue, out int minusBaseValue, out int minusValue, out float minusRateValue) { }

	// RVA: 0x18F5454 Offset: 0x18F1454 VA: 0x18F5454
	public int CalcMatk(PlayerStatusBase status, out int plusBaseValue, out int plusValue, out float plusRateValue, out int minusBaseValue, out int minusValue, out float minusRateValue) { }

	// RVA: 0x18F5E3C Offset: 0x18F1E3C VA: 0x18F5E3C
	public int CalcAspd(PlayerStatusBase status) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int CalcStable(PlayerStatusBase status);

	// RVA: 0x18F61D4 Offset: 0x18F21D4 VA: 0x18F61D4 Slot: 10
	public virtual bool CorrectHit(ref int hit) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int CalcSubAtk(PlayerStatusBase status);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int SubCalcStable(PlayerStatusBase status);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int SubCalcMatk(PlayerStatusBase status);
}
