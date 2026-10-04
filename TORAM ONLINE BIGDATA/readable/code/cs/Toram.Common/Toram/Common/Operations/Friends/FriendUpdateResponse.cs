// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendUpdateResponse : PacketBase // TypeDefIndex: 11647
{
	// Fields
	[CompilerGenerated]
	private byte <BinaryState>k__BackingField; // 0x20
	[CompilerGenerated]
	private FriendData[] <FriendList>k__BackingField; // 0x28

	// Properties
	public byte BinaryState { get; set; }
	public FriendData[] FriendList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x372AED8 Offset: 0x3726ED8 VA: 0x372AED8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372AEE0 Offset: 0x3726EE0 VA: 0x372AEE0
	public byte get_BinaryState() { }

	[CompilerGenerated]
	// RVA: 0x372AEE8 Offset: 0x3726EE8 VA: 0x372AEE8
	public void set_BinaryState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372AEF0 Offset: 0x3726EF0 VA: 0x372AEF0
	public FriendData[] get_FriendList() { }

	[CompilerGenerated]
	// RVA: 0x372AEF8 Offset: 0x3726EF8 VA: 0x372AEF8
	public void set_FriendList(FriendData[] value) { }

	// RVA: 0x372AF00 Offset: 0x3726F00 VA: 0x372AF00 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372AF08 Offset: 0x3726F08 VA: 0x372AF08 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372B150 Offset: 0x3727150 VA: 0x372B150 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
