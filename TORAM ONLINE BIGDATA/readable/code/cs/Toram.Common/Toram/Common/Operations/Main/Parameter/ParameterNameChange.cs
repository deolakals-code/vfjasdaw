// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterNameChange : PacketBase // TypeDefIndex: 11993
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ParamName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 108)]
	public byte ParamId { get; set; }
	[PacketParameter(Code = 109)]
	public string ParamName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3773940 Offset: 0x376F940 VA: 0x3773940
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3773948 Offset: 0x376F948 VA: 0x3773948
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x3773950 Offset: 0x376F950 VA: 0x3773950
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3773958 Offset: 0x376F958 VA: 0x3773958
	public string get_ParamName() { }

	[CompilerGenerated]
	// RVA: 0x3773960 Offset: 0x376F960 VA: 0x3773960
	public void set_ParamName(string value) { }

	// RVA: 0x3773968 Offset: 0x376F968 VA: 0x3773968 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3773970 Offset: 0x376F970 VA: 0x3773970 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3773AE8 Offset: 0x376FAE8 VA: 0x3773AE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
