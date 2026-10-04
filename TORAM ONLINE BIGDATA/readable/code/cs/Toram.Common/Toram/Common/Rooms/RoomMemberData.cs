// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public class RoomMemberData : BinaryBase, IRoomMember // TypeDefIndex: 11291
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TeamId>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsPartyLeader>k__BackingField; // 0x29
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x2A
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <RoomType>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x32
	[CompilerGenerated]
	private short <WeaponType>k__BackingField; // 0x34
	[CompilerGenerated]
	private short <SubWeaponType>k__BackingField; // 0x36

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public string UserName { get; set; }
	public byte TeamId { get; set; }
	public bool IsPartyLeader { get; set; }
	public byte State { get; set; }
	public int FieldId { get; set; }
	public byte RoomType { get; set; }
	public short Level { get; set; }
	public short WeaponType { get; set; }
	public short SubWeaponType { get; set; }

	// Methods

	// RVA: 0x36D849C Offset: 0x36D449C VA: 0x36D849C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36D84A4 Offset: 0x36D44A4 VA: 0x36D84A4 Slot: 8
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36D84AC Offset: 0x36D44AC VA: 0x36D84AC
	private void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D84B4 Offset: 0x36D44B4 VA: 0x36D84B4 Slot: 9
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36D84BC Offset: 0x36D44BC VA: 0x36D84BC
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D84C4 Offset: 0x36D44C4 VA: 0x36D84C4 Slot: 10
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x36D84CC Offset: 0x36D44CC VA: 0x36D84CC
	private void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36D84D4 Offset: 0x36D44D4 VA: 0x36D84D4
	public byte get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x36D84DC Offset: 0x36D44DC VA: 0x36D84DC
	protected void set_TeamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D84E4 Offset: 0x36D44E4 VA: 0x36D84E4 Slot: 14
	public bool get_IsPartyLeader() { }

	[CompilerGenerated]
	// RVA: 0x36D84EC Offset: 0x36D44EC VA: 0x36D84EC
	private void set_IsPartyLeader(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36D84F8 Offset: 0x36D44F8 VA: 0x36D84F8 Slot: 11
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x36D8500 Offset: 0x36D4500 VA: 0x36D8500
	protected void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D8508 Offset: 0x36D4508 VA: 0x36D8508 Slot: 15
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x36D8510 Offset: 0x36D4510 VA: 0x36D8510
	protected void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D8518 Offset: 0x36D4518 VA: 0x36D8518 Slot: 16
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x36D8520 Offset: 0x36D4520 VA: 0x36D8520
	private void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D8528 Offset: 0x36D4528 VA: 0x36D8528 Slot: 12
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x36D8530 Offset: 0x36D4530 VA: 0x36D8530
	protected void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x36D8538 Offset: 0x36D4538 VA: 0x36D8538 Slot: 13
	public short get_WeaponType() { }

	[CompilerGenerated]
	// RVA: 0x36D8540 Offset: 0x36D4540 VA: 0x36D8540
	protected void set_WeaponType(short value) { }

	[CompilerGenerated]
	// RVA: 0x36D8548 Offset: 0x36D4548 VA: 0x36D8548 Slot: 17
	public short get_SubWeaponType() { }

	[CompilerGenerated]
	// RVA: 0x36D8550 Offset: 0x36D4550 VA: 0x36D8550
	protected void set_SubWeaponType(short value) { }

	// RVA: 0x36D8558 Offset: 0x36D4558 VA: 0x36D8558
	public bool IsMember(byte type, int id) { }

	// RVA: 0x36D857C Offset: 0x36D457C VA: 0x36D857C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D874C Offset: 0x36D474C VA: 0x36D874C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
