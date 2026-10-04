// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.TreasureHunt
public class TreasureHuntUpdateBonusEvent : EventSubBase // TypeDefIndex: 12798
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomSupportUseData[] <BonusList>k__BackingField; // 0x30

	// Properties
	[PacketClass(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketClass(Code = 66)]
	public string UserName { get; set; }
	[PacketClass(Code = 206, IsOptional = True)]
	public RoomSupportUseData[] BonusList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365B67C Offset: 0x365767C VA: 0x365B67C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365B684 Offset: 0x3657684 VA: 0x365B684
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x365B68C Offset: 0x365768C VA: 0x365B68C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x365B694 Offset: 0x3657694 VA: 0x365B694
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x365B69C Offset: 0x365769C VA: 0x365B69C
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x365B6A4 Offset: 0x36576A4 VA: 0x365B6A4
	public RoomSupportUseData[] get_BonusList() { }

	[CompilerGenerated]
	// RVA: 0x365B6AC Offset: 0x36576AC VA: 0x365B6AC
	public void set_BonusList(RoomSupportUseData[] value) { }

	// RVA: 0x365B6B4 Offset: 0x36576B4 VA: 0x365B6B4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x365B7A4 Offset: 0x36577A4 VA: 0x365B7A4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x365B830 Offset: 0x3657830 VA: 0x365B830 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365B838 Offset: 0x3657838 VA: 0x365B838 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365B840 Offset: 0x3657840 VA: 0x365B840 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365B900 Offset: 0x3657900 VA: 0x365B900 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
