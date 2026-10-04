// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterGetStatus : PacketBase // TypeDefIndex: 11991
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 108)]
	public byte ParamId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37734B8 Offset: 0x376F4B8 VA: 0x37734B8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37734C0 Offset: 0x376F4C0 VA: 0x37734C0
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x37734C8 Offset: 0x376F4C8 VA: 0x37734C8
	public void set_ParamId(byte value) { }

	// RVA: 0x37734D0 Offset: 0x376F4D0 VA: 0x37734D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37734D8 Offset: 0x376F4D8 VA: 0x37734D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37735F8 Offset: 0x376F5F8 VA: 0x37735F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
