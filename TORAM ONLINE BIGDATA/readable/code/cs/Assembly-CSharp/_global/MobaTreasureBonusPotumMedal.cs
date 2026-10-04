// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaTreasureBonusPotumMedal : MobaTreasureBonusDataBase // TypeDefIndex: 2125
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

	// RVA: 0x2146EDC Offset: 0x2142EDC VA: 0x2146EDC Slot: 4
	public override MobaTreasureBonusType get_Type() { }

	// RVA: 0x2146EE4 Offset: 0x2142EE4 VA: 0x2146EE4 Slot: 5
	public override MobaTreasureBonusGroup get_Group() { }

	// RVA: 0x2146EEC Offset: 0x2142EEC VA: 0x2146EEC Slot: 7
	public override bool get_Duplicate() { }

	// RVA: 0x2146EF4 Offset: 0x2142EF4 VA: 0x2146EF4 Slot: 6
	public override int get_Value() { }

	// RVA: 0x2146EFC Offset: 0x2142EFC VA: 0x2146EFC
	public void .ctor(byte level) { }
}
