// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Friend
public class FriendSenderCancelEvent : PacketBase // TypeDefIndex: 12854
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

	// RVA: 0x36698D0 Offset: 0x36658D0 VA: 0x36698D0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36698D8 Offset: 0x36658D8 VA: 0x36698D8
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x36698E0 Offset: 0x36658E0 VA: 0x36698E0
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36698E8 Offset: 0x36658E8 VA: 0x36698E8
	public string get_SenderName() { }

	[CompilerGenerated]
	// RVA: 0x36698F0 Offset: 0x36658F0 VA: 0x36698F0
	public void set_SenderName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36698F8 Offset: 0x36658F8 VA: 0x36698F8
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3669900 Offset: 0x3665900 VA: 0x3669900
	public void set_ReturnCode(short value) { }

	// RVA: 0x3669908 Offset: 0x3665908 VA: 0x3669908 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3669910 Offset: 0x3665910 VA: 0x3669910 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3669B0C Offset: 0x3665B0C VA: 0x3669B0C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
