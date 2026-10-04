// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendRequestResponse : PacketBase // TypeDefIndex: 11644
{
	// Fields
	[CompilerGenerated]
	private FriendData <FriendData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 173)]
	public FriendData FriendData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x372A764 Offset: 0x3726764 VA: 0x372A764
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372A76C Offset: 0x372676C VA: 0x372A76C
	public FriendData get_FriendData() { }

	[CompilerGenerated]
	// RVA: 0x372A774 Offset: 0x3726774 VA: 0x372A774
	public void set_FriendData(FriendData value) { }

	// RVA: 0x372A77C Offset: 0x372677C VA: 0x372A77C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x372A898 Offset: 0x3726898 VA: 0x372A898
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x372A914 Offset: 0x3726914 VA: 0x372A914 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372A91C Offset: 0x372691C VA: 0x372A91C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372A9B4 Offset: 0x37269B4 VA: 0x372A9B4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
