// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterDelete : PacketBase // TypeDefIndex: 11987
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 108)]
	public byte ParamId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3772930 Offset: 0x376E930 VA: 0x3772930
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3772938 Offset: 0x376E938 VA: 0x3772938
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x3772940 Offset: 0x376E940 VA: 0x3772940
	public void set_ParamId(byte value) { }

	// RVA: 0x3772948 Offset: 0x376E948 VA: 0x3772948 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3772950 Offset: 0x376E950 VA: 0x3772950 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3772A70 Offset: 0x376EA70 VA: 0x3772A70 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
