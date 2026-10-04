// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaTreasureBonusDetectionSlab : MobaTreasureBonusDataBase // TypeDefIndex: 2119
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

	// RVA: 0x2146B60 Offset: 0x2142B60 VA: 0x2146B60 Slot: 4
	public override MobaTreasureBonusType get_Type() { }

	// RVA: 0x2146B68 Offset: 0x2142B68 VA: 0x2146B68 Slot: 5
	public override MobaTreasureBonusGroup get_Group() { }

	// RVA: 0x2146B70 Offset: 0x2142B70 VA: 0x2146B70 Slot: 7
	public override bool get_Duplicate() { }

	// RVA: 0x2146B78 Offset: 0x2142B78 VA: 0x2146B78 Slot: 6
	public override int get_Value() { }

	// RVA: 0x2146B80 Offset: 0x2142B80 VA: 0x2146B80
	public void .ctor(byte level) { }
}
