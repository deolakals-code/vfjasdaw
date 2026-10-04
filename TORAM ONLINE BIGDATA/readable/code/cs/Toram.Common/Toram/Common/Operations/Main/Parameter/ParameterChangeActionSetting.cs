// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterChangeActionSetting : OperationRequestBase // TypeDefIndex: 11980
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<short, byte> <Skills>k__BackingField; // 0x28

	// Properties
	public byte ParamId { get; set; }
	public Dictionary<short, byte> Skills { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3771534 Offset: 0x376D534 VA: 0x3771534
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377153C Offset: 0x376D53C VA: 0x377153C
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x3771544 Offset: 0x376D544 VA: 0x3771544
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377154C Offset: 0x376D54C VA: 0x377154C
	public Dictionary<short, byte> get_Skills() { }

	[CompilerGenerated]
	// RVA: 0x3771554 Offset: 0x376D554 VA: 0x3771554
	public void set_Skills(Dictionary<short, byte> value) { }

	// RVA: 0x377155C Offset: 0x376D55C VA: 0x377155C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3771564 Offset: 0x376D564 VA: 0x3771564 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377156C Offset: 0x376D56C VA: 0x377156C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3771624 Offset: 0x376D624 VA: 0x3771624 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
