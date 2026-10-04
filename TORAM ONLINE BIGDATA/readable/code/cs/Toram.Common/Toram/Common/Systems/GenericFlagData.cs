// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems
public class GenericFlagData : UnityHashBase // TypeDefIndex: 11246
{
	// Fields
	[CompilerGenerated]
	private byte <FlagId>k__BackingField; // 0x19
	[CompilerGenerated]
	private string <Data>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 200)]
	public byte FlagId { get; set; }
	[UnityHash(Code = 199)]
	public string Data { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36CEB64 Offset: 0x36CAB64 VA: 0x36CEB64
	public void .ctor() { }

	// RVA: 0x36CEB6C Offset: 0x36CAB6C VA: 0x36CEB6C
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36CEB74 Offset: 0x36CAB74 VA: 0x36CEB74
	public byte get_FlagId() { }

	[CompilerGenerated]
	// RVA: 0x36CEB7C Offset: 0x36CAB7C VA: 0x36CEB7C
	public void set_FlagId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36CEB84 Offset: 0x36CAB84 VA: 0x36CEB84
	public string get_Data() { }

	[CompilerGenerated]
	// RVA: 0x36CEB8C Offset: 0x36CAB8C VA: 0x36CEB8C
	public void set_Data(string value) { }

	// RVA: 0x36CEB94 Offset: 0x36CAB94 VA: 0x36CEB94 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36CEB9C Offset: 0x36CAB9C VA: 0x36CEB9C Slot: 3
	public override string ToString() { }

	// RVA: 0x36CEC24 Offset: 0x36CAC24 VA: 0x36CEC24 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36CEDD0 Offset: 0x36CADD0 VA: 0x36CEDD0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
