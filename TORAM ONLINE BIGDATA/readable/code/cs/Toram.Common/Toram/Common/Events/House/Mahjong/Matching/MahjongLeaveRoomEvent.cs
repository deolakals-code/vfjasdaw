// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Matching
public class MahjongLeaveRoomEvent : EventSubBase // TypeDefIndex: 12846
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20

	// Properties
	public int ArchetypeId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3667FCC Offset: 0x3663FCC VA: 0x3667FCC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3667FD4 Offset: 0x3663FD4 VA: 0x3667FD4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3667FDC Offset: 0x3663FDC VA: 0x3667FDC
	public void set_ArchetypeId(int value) { }

	// RVA: 0x3667FE4 Offset: 0x3663FE4 VA: 0x3667FE4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3667FEC Offset: 0x3663FEC VA: 0x3667FEC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3667FF4 Offset: 0x3663FF4 VA: 0x3667FF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3668094 Offset: 0x3664094 VA: 0x3668094 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
