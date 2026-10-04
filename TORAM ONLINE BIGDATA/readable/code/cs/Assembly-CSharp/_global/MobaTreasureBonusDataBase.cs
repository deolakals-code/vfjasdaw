// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class MobaTreasureBonusDataBase // TypeDefIndex: 2117
{
	// Fields
	private readonly byte level; // 0x10

	// Properties
	public abstract MobaTreasureBonusType Type { get; }
	public abstract MobaTreasureBonusGroup Group { get; }
	public abstract int Value { get; }
	public abstract bool Duplicate { get; }
	public byte Level { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MobaTreasureBonusType get_Type();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract MobaTreasureBonusGroup get_Group();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Value();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_Duplicate();

	// RVA: 0x2146ADC Offset: 0x2142ADC VA: 0x2146ADC
	public byte get_Level() { }

	// RVA: 0x2146AB4 Offset: 0x2142AB4 VA: 0x2146AB4
	public void .ctor(byte level) { }
}
