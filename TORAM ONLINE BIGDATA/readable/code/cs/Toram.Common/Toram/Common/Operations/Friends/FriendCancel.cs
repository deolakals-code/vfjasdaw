// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendCancel : PacketBase // TypeDefIndex: 11642
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 99)]
	public int SenderId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x372A2C0 Offset: 0x37262C0 VA: 0x372A2C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372A2C8 Offset: 0x37262C8 VA: 0x372A2C8
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x372A2D0 Offset: 0x37262D0 VA: 0x372A2D0
	public void set_SenderId(int value) { }

	// RVA: 0x372A2D8 Offset: 0x37262D8 VA: 0x372A2D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372A2E0 Offset: 0x37262E0 VA: 0x372A2E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372A400 Offset: 0x3726400 VA: 0x372A400 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
