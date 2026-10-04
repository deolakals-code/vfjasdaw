// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendAcceptanceResponse : PacketBase // TypeDefIndex: 11638
{
	// Fields
	[CompilerGenerated]
	private FriendData <FriendData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 173, IsOptional = True)]
	public FriendData FriendData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37297F8 Offset: 0x37257F8 VA: 0x37297F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3729800 Offset: 0x3725800 VA: 0x3729800
	public FriendData get_FriendData() { }

	[CompilerGenerated]
	// RVA: 0x3729808 Offset: 0x3725808 VA: 0x3729808
	public void set_FriendData(FriendData value) { }

	// RVA: 0x3729810 Offset: 0x3725810 VA: 0x3729810
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x372992C Offset: 0x372592C VA: 0x372992C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37299A8 Offset: 0x37259A8 VA: 0x37299A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37299B0 Offset: 0x37259B0 VA: 0x37299B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3729A48 Offset: 0x3725A48 VA: 0x3729A48 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
