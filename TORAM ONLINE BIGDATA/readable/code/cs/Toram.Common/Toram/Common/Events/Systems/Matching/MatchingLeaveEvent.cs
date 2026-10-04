// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems.Matching
public class MatchingLeaveEvent : EventSubBase // TypeDefIndex: 12737
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

	// RVA: 0x364DB70 Offset: 0x3649B70 VA: 0x364DB70
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364DB78 Offset: 0x3649B78 VA: 0x364DB78
	public byte get_MatchingType() { }

	[CompilerGenerated]
	// RVA: 0x364DB80 Offset: 0x3649B80 VA: 0x364DB80
	public void set_MatchingType(byte value) { }

	// RVA: 0x364DB88 Offset: 0x3649B88 VA: 0x364DB88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364DB90 Offset: 0x3649B90 VA: 0x364DB90 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x364DB98 Offset: 0x3649B98 VA: 0x364DB98 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364DC38 Offset: 0x3649C38 VA: 0x364DC38 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
