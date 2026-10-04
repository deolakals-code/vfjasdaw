// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterCreate : PacketBase // TypeDefIndex: 11986
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 108)]
	public byte ParamId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x377271C Offset: 0x376E71C VA: 0x377271C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3772724 Offset: 0x376E724 VA: 0x3772724
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x377272C Offset: 0x376E72C VA: 0x377272C
	public void set_ParamId(byte value) { }

	// RVA: 0x3772734 Offset: 0x376E734 VA: 0x3772734 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377273C Offset: 0x376E73C VA: 0x377273C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377285C Offset: 0x376E85C VA: 0x377285C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
