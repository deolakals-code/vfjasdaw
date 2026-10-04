// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class CreateNewParameterResponse : PacketBase // TypeDefIndex: 11399
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 108)]
	public byte ParamId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x370120C Offset: 0x36FD20C VA: 0x370120C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3701214 Offset: 0x36FD214 VA: 0x3701214
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x370121C Offset: 0x36FD21C VA: 0x370121C
	public void set_ParamId(byte value) { }

	// RVA: 0x3701224 Offset: 0x36FD224 VA: 0x3701224 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370122C Offset: 0x36FD22C VA: 0x370122C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370134C Offset: 0x36FD34C VA: 0x370134C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
