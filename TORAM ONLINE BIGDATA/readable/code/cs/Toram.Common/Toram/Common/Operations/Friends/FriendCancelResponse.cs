// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendCancelResponse : PacketBase // TypeDefIndex: 11643
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <SenderName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 99)]
	public int SenderId { get; set; }
	[PacketParameter(Code = 100)]
	public string SenderName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x372A4D4 Offset: 0x37264D4 VA: 0x372A4D4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372A4DC Offset: 0x37264DC VA: 0x372A4DC
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x372A4E4 Offset: 0x37264E4 VA: 0x372A4E4
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x372A4EC Offset: 0x37264EC VA: 0x372A4EC
	public string get_SenderName() { }

	[CompilerGenerated]
	// RVA: 0x372A4F4 Offset: 0x37264F4 VA: 0x372A4F4
	public void set_SenderName(string value) { }

	// RVA: 0x372A4FC Offset: 0x37264FC VA: 0x372A4FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372A504 Offset: 0x3726504 VA: 0x372A504 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372A67C Offset: 0x372667C VA: 0x372A67C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
