// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongKickoutMember : OperationRequestBase // TypeDefIndex: 12352
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20

	// Properties
	public int ArchetypeId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35F95D4 Offset: 0x35F55D4 VA: 0x35F95D4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F95DC Offset: 0x35F55DC VA: 0x35F95DC
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x35F95E4 Offset: 0x35F55E4 VA: 0x35F95E4
	public void set_ArchetypeId(int value) { }

	// RVA: 0x35F95EC Offset: 0x35F55EC VA: 0x35F95EC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F95F4 Offset: 0x35F55F4 VA: 0x35F95F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F95FC Offset: 0x35F55FC VA: 0x35F95FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F969C Offset: 0x35F569C VA: 0x35F969C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
