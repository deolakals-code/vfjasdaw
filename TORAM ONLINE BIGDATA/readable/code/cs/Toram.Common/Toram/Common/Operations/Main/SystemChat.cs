// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class SystemChat : PacketBase // TypeDefIndex: 11897
{
	// Fields
	[CompilerGenerated]
	private byte <ChannelType>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SystemMessageId>k__BackingField; // 0x22

	// Properties
	public byte ChannelType { get; set; }
	public short SystemMessageId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3760998 Offset: 0x375C998 VA: 0x3760998
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37609A0 Offset: 0x375C9A0 VA: 0x37609A0
	public byte get_ChannelType() { }

	[CompilerGenerated]
	// RVA: 0x37609A8 Offset: 0x375C9A8 VA: 0x37609A8
	public void set_ChannelType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37609B0 Offset: 0x375C9B0 VA: 0x37609B0
	public short get_SystemMessageId() { }

	[CompilerGenerated]
	// RVA: 0x37609B8 Offset: 0x375C9B8 VA: 0x37609B8
	public void set_SystemMessageId(short value) { }

	// RVA: 0x37609C0 Offset: 0x375C9C0 VA: 0x37609C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37609C8 Offset: 0x375C9C8 VA: 0x37609C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3760AD8 Offset: 0x375CAD8 VA: 0x3760AD8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
