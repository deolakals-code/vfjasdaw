// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterChange : PacketBase // TypeDefIndex: 11985
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 108)]
	public byte ParamId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3772508 Offset: 0x376E508 VA: 0x3772508
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3772510 Offset: 0x376E510 VA: 0x3772510
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x3772518 Offset: 0x376E518 VA: 0x3772518
	public void set_ParamId(byte value) { }

	// RVA: 0x3772520 Offset: 0x376E520 VA: 0x3772520 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3772528 Offset: 0x376E528 VA: 0x3772528 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3772648 Offset: 0x376E648 VA: 0x3772648 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
