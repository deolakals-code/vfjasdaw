// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaTreasureBonusSafetyRibbon : MobaTreasureBonusDataBase // TypeDefIndex: 2127
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

	// RVA: 0x2146FD0 Offset: 0x2142FD0 VA: 0x2146FD0 Slot: 4
	public override MobaTreasureBonusType get_Type() { }

	// RVA: 0x2146FD8 Offset: 0x2142FD8 VA: 0x2146FD8 Slot: 5
	public override MobaTreasureBonusGroup get_Group() { }

	// RVA: 0x2146FE0 Offset: 0x2142FE0 VA: 0x2146FE0 Slot: 7
	public override bool get_Duplicate() { }

	// RVA: 0x2146FE8 Offset: 0x2142FE8 VA: 0x2146FE8 Slot: 6
	public override int get_Value() { }

	// RVA: 0x2146FF0 Offset: 0x2142FF0 VA: 0x2146FF0
	public void .ctor(byte level) { }
}
