// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Friend
public class FriendRequestEvent : PacketBase // TypeDefIndex: 12853
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private FriendReserveData <ReserveData>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketClass(Code = 175, IsOptional = True)]
	public FriendReserveData ReserveData { get; set; }
	[PacketParameter(Code = 81, IsOptional = True)]
	public short ReturnCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3669420 Offset: 0x3665420 VA: 0x3669420
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3669428 Offset: 0x3665428 VA: 0x3669428
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3669430 Offset: 0x3665430 VA: 0x3669430
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3669438 Offset: 0x3665438 VA: 0x3669438
	public FriendReserveData get_ReserveData() { }

	[CompilerGenerated]
	// RVA: 0x3669440 Offset: 0x3665440 VA: 0x3669440
	public void set_ReserveData(FriendReserveData value) { }

	[CompilerGenerated]
	// RVA: 0x3669448 Offset: 0x3665448 VA: 0x3669448
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3669450 Offset: 0x3665450 VA: 0x3669450
	public void set_ReturnCode(short value) { }

	// RVA: 0x3669458 Offset: 0x3665458 VA: 0x3669458
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3669578 Offset: 0x3665578 VA: 0x3669578
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36695F4 Offset: 0x36655F4 VA: 0x36695F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36695FC Offset: 0x36655FC VA: 0x36695FC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36697B0 Offset: 0x36657B0 VA: 0x36697B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
