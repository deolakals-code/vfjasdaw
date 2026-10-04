// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Friend
public class FriendRemoveEvent : PacketBase // TypeDefIndex: 12852
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <SenderName>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 99)]
	public int SenderId { get; set; }
	[PacketParameter(Code = 100)]
	public string SenderName { get; set; }
	[PacketParameter(Code = 81, IsOptional = True)]
	public short ReturnCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36690BC Offset: 0x36650BC VA: 0x36690BC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36690C4 Offset: 0x36650C4 VA: 0x36690C4
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x36690CC Offset: 0x36650CC VA: 0x36690CC
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36690D4 Offset: 0x36650D4 VA: 0x36690D4
	public string get_SenderName() { }

	[CompilerGenerated]
	// RVA: 0x36690DC Offset: 0x36650DC VA: 0x36690DC
	public void set_SenderName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36690E4 Offset: 0x36650E4 VA: 0x36690E4
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x36690EC Offset: 0x36650EC VA: 0x36690EC
	public void set_ReturnCode(short value) { }

	// RVA: 0x36690F4 Offset: 0x36650F4 VA: 0x36690F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36690FC Offset: 0x36650FC VA: 0x36690FC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36692F8 Offset: 0x36652F8 VA: 0x36692F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
