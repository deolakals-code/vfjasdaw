// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterGetListResponse : PacketBase // TypeDefIndex: 11990
{
	// Fields
	[CompilerGenerated]
	private byte <ParameterSlot>k__BackingField; // 0x20
	[CompilerGenerated]
	private ParameterData[] <ParameterList>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <ParameterOrder>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 112)]
	public byte ParameterSlot { get; set; }
	[PacketClass(Code = 111, IsOptional = True)]
	public ParameterData[] ParameterList { get; set; }
	[PacketParameter(Code = 153, IsOptional = True)]
	public byte[] ParameterOrder { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37730F8 Offset: 0x376F0F8 VA: 0x37730F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3773100 Offset: 0x376F100 VA: 0x3773100
	public byte get_ParameterSlot() { }

	[CompilerGenerated]
	// RVA: 0x3773108 Offset: 0x376F108 VA: 0x3773108
	public void set_ParameterSlot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3773110 Offset: 0x376F110 VA: 0x3773110
	public ParameterData[] get_ParameterList() { }

	[CompilerGenerated]
	// RVA: 0x3773118 Offset: 0x376F118 VA: 0x3773118
	public void set_ParameterList(ParameterData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3773120 Offset: 0x376F120 VA: 0x3773120
	public byte[] get_ParameterOrder() { }

	[CompilerGenerated]
	// RVA: 0x3773128 Offset: 0x376F128 VA: 0x3773128
	public void set_ParameterOrder(byte[] value) { }

	// RVA: 0x3773130 Offset: 0x376F130 VA: 0x3773130 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3773138 Offset: 0x376F138 VA: 0x3773138 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3773394 Offset: 0x376F394 VA: 0x3773394 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
