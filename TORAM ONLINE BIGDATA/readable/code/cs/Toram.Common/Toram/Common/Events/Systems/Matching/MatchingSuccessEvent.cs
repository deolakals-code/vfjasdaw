// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems.Matching
public class MatchingSuccessEvent : EventSubBase // TypeDefIndex: 12738
{
	// Fields
	[CompilerGenerated]
	private byte <MatchingType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RoomId>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <RoomChange>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 78)]
	public byte MatchingType { get; set; }
	[PacketParameter(Code = 36)]
	public int RoomId { get; set; }
	[PacketParameter(Code = 20)]
	public bool RoomChange { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x364DD58 Offset: 0x3649D58 VA: 0x364DD58
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364DD60 Offset: 0x3649D60 VA: 0x364DD60
	public byte get_MatchingType() { }

	[CompilerGenerated]
	// RVA: 0x364DD68 Offset: 0x3649D68 VA: 0x364DD68
	public void set_MatchingType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x364DD70 Offset: 0x3649D70 VA: 0x364DD70
	public int get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x364DD78 Offset: 0x3649D78 VA: 0x364DD78
	public void set_RoomId(int value) { }

	[CompilerGenerated]
	// RVA: 0x364DD80 Offset: 0x3649D80 VA: 0x364DD80
	public bool get_RoomChange() { }

	[CompilerGenerated]
	// RVA: 0x364DD88 Offset: 0x3649D88 VA: 0x364DD88
	public void set_RoomChange(bool value) { }

	// RVA: 0x364DD94 Offset: 0x3649D94 VA: 0x364DD94 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364DD9C Offset: 0x3649D9C VA: 0x364DD9C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x364DDA4 Offset: 0x3649DA4 VA: 0x364DDA4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364DEB0 Offset: 0x3649EB0 VA: 0x364DEB0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
