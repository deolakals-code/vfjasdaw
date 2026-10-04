// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Matching
public class MahjongKickoutMemberEvent : EventSubBase // TypeDefIndex: 12847
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20

	// Properties
	public int ArchetypeId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36681C8 Offset: 0x36641C8 VA: 0x36681C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36681D0 Offset: 0x36641D0 VA: 0x36681D0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36681D8 Offset: 0x36641D8 VA: 0x36681D8
	public void set_ArchetypeId(int value) { }

	// RVA: 0x36681E0 Offset: 0x36641E0 VA: 0x36681E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36681E8 Offset: 0x36641E8 VA: 0x36681E8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36681F0 Offset: 0x36641F0 VA: 0x36681F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3668290 Offset: 0x3664290 VA: 0x3668290 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
