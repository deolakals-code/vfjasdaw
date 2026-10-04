// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongKickoutMemberResponse : OperationResponseBase // TypeDefIndex: 12353
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20

	// Properties
	public int ArchetypeId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35F97BC Offset: 0x35F57BC VA: 0x35F97BC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F97C4 Offset: 0x35F57C4 VA: 0x35F97C4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x35F97CC Offset: 0x35F57CC VA: 0x35F97CC
	public void set_ArchetypeId(int value) { }

	// RVA: 0x35F97D4 Offset: 0x35F57D4 VA: 0x35F97D4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F97DC Offset: 0x35F57DC VA: 0x35F97DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F97E4 Offset: 0x35F57E4 VA: 0x35F97E4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F9884 Offset: 0x35F5884 VA: 0x35F9884 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
