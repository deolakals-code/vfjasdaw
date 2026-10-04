// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipItemData.ShortSwordCalculator : EquipItemData.WeaponTypeCalculatorBase // TypeDefIndex: 559
{
	// Methods

	// RVA: 0x18F2554 Offset: 0x18EE554 VA: 0x18F2554
	public void .ctor(ItemData item) { }

	// RVA: 0x18FCCD0 Offset: 0x18F8CD0 VA: 0x18FCCD0 Slot: 5
	protected override void calcEqAtkBonus(PlayerStatusBase status, ref float eqAtkRate, ref int eqAtk) { }

	// RVA: 0x18FCCD4 Offset: 0x18F8CD4 VA: 0x18FCCD4 Slot: 6
	protected override int calcAtkParam(PlayerStatusBase status, int baseAtkUp, float atkRate, int atk) { }

	// RVA: 0x18FCCDC Offset: 0x18F8CDC VA: 0x18FCCDC Slot: 7
	protected override int calcMatkParam(PlayerStatusBase status, int baseMatkUp, float matkRate, int matk) { }

	// RVA: 0x18FCCE4 Offset: 0x18F8CE4 VA: 0x18FCCE4 Slot: 8
	protected override int calcAspdParam(PlayerStatusBase status, float aspdRate, int aspd) { }

	// RVA: 0x18FCCEC Offset: 0x18F8CEC VA: 0x18FCCEC Slot: 9
	public override int CalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FCCF4 Offset: 0x18F8CF4 VA: 0x18FCCF4 Slot: 11
	public override int CalcSubAtk(PlayerStatusBase status) { }

	// RVA: 0x18FCED0 Offset: 0x18F8ED0 VA: 0x18FCED0 Slot: 12
	public override int SubCalcStable(PlayerStatusBase status) { }

	// RVA: 0x18FD060 Offset: 0x18F9060 VA: 0x18FD060 Slot: 13
	public override int SubCalcMatk(PlayerStatusBase status) { }
}
