// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaTreasureBonusDiaryOfAdventurer : MobaTreasureBonusDataBase // TypeDefIndex: 2120
{
	// Fields
	private readonly MobaTreasureBonusType type; // 0x12
	private readonly int value; // 0x14

	// Properties
	public override MobaTreasureBonusType Type { get; }
	public override MobaTreasureBonusGroup Group { get; }
	public override bool Duplicate { get; }
	public override int Value { get; }

	// Methods

	// RVA: 0x2146BD8 Offset: 0x2142BD8 VA: 0x2146BD8 Slot: 4
	public override MobaTreasureBonusType get_Type() { }

	// RVA: 0x2146BE0 Offset: 0x2142BE0 VA: 0x2146BE0 Slot: 5
	public override MobaTreasureBonusGroup get_Group() { }

	// RVA: 0x2146BE8 Offset: 0x2142BE8 VA: 0x2146BE8 Slot: 7
	public override bool get_Duplicate() { }

	// RVA: 0x2146BF0 Offset: 0x2142BF0 VA: 0x2146BF0 Slot: 6
	public override int get_Value() { }

	// RVA: 0x2146BF8 Offset: 0x2142BF8 VA: 0x2146BF8
	public void .ctor(byte level) { }
}
