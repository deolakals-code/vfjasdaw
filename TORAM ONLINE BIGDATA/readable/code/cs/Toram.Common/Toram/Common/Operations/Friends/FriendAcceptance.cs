// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendAcceptance : PacketBase // TypeDefIndex: 11637
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 99)]
	public int SenderId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37295E4 Offset: 0x37255E4 VA: 0x37295E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37295EC Offset: 0x37255EC VA: 0x37295EC
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x37295F4 Offset: 0x37255F4 VA: 0x37295F4
	public void set_SenderId(int value) { }

	// RVA: 0x37295FC Offset: 0x37255FC VA: 0x37295FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3729604 Offset: 0x3725604 VA: 0x3729604 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3729724 Offset: 0x3725724 VA: 0x3729724 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
