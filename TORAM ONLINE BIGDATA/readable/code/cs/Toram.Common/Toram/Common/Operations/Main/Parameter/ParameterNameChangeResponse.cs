// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterNameChangeResponse : PacketBase // TypeDefIndex: 11994
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ParamName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 108)]
	public byte ParamId { get; set; }
	[PacketParameter(Code = 109, IsOptional = True)]
	public string ParamName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3773BD0 Offset: 0x376FBD0 VA: 0x3773BD0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3773BD8 Offset: 0x376FBD8 VA: 0x3773BD8
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x3773BE0 Offset: 0x376FBE0 VA: 0x3773BE0
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3773BE8 Offset: 0x376FBE8 VA: 0x3773BE8
	public string get_ParamName() { }

	[CompilerGenerated]
	// RVA: 0x3773BF0 Offset: 0x376FBF0 VA: 0x3773BF0
	public void set_ParamName(string value) { }

	// RVA: 0x3773BF8 Offset: 0x376FBF8 VA: 0x3773BF8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3773C00 Offset: 0x376FC00 VA: 0x3773C00 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3773DA4 Offset: 0x376FDA4 VA: 0x3773DA4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
