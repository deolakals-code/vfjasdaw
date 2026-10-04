// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems.Matching
public class MatchingJoinEvent : EventSubBase // TypeDefIndex: 12736
{
	// Fields
	[CompilerGenerated]
	private byte <MatchingType>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 78)]
	public byte MatchingType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x364D988 Offset: 0x3649988 VA: 0x364D988
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364D990 Offset: 0x3649990 VA: 0x364D990
	public byte get_MatchingType() { }

	[CompilerGenerated]
	// RVA: 0x364D998 Offset: 0x3649998 VA: 0x364D998
	public void set_MatchingType(byte value) { }

	// RVA: 0x364D9A0 Offset: 0x36499A0 VA: 0x364D9A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364D9A8 Offset: 0x36499A8 VA: 0x364D9A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x364D9B0 Offset: 0x36499B0 VA: 0x364D9B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364DA50 Offset: 0x3649A50 VA: 0x364DA50 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
