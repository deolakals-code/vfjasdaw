// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class GuildLevelData : UnityHashBase // TypeDefIndex: 12988
{
	// Fields
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <Exp>k__BackingField; // 0x1C

	// Properties
	[UnityHash(Code = 29)]
	public short Level { get; set; }
	[UnityHash(Code = 27)]
	public int Exp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3688AB4 Offset: 0x3684AB4 VA: 0x3688AB4
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3688ABC Offset: 0x3684ABC VA: 0x3688ABC
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x3688AC4 Offset: 0x3684AC4 VA: 0x3688AC4
	protected void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x3688ACC Offset: 0x3684ACC VA: 0x3688ACC
	public int get_Exp() { }

	[CompilerGenerated]
	// RVA: 0x3688AD4 Offset: 0x3684AD4 VA: 0x3688AD4
	protected void set_Exp(int value) { }

	// RVA: 0x3688ADC Offset: 0x3684ADC VA: 0x3688ADC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3688AE4 Offset: 0x3684AE4 VA: 0x3688AE4 Slot: 3
	public override string ToString() { }

	// RVA: 0x3688BA0 Offset: 0x3684BA0 VA: 0x3688BA0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3688D60 Offset: 0x3684D60 VA: 0x3688D60 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
