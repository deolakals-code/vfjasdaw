// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public class RoomGroupMemberStateData : UnityHashBase, IRoomMember // TypeDefIndex: 11295
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsPartyLeader>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x32
	[CompilerGenerated]
	private short <WeaponType>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x36
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <RoomType>k__BackingField; // 0x3C
	[CompilerGenerated]
	private short <SubWeaponType>k__BackingField; // 0x3E

	// Properties
	[UnityHash(Code = 74)]
	public int ArchetypeId { get; set; }
	[UnityHash(Code = 55, IsOptional = True)]
	public byte ArchetypeType { get; set; }
	[UnityHash(Code = 66, IsOptional = True)]
	public string UserName { get; set; }
	[UnityHash(Code = 43, IsOptional = True)]
	public bool IsPartyLeader { get; set; }
	[UnityHash(Code = 29, IsOptional = True)]
	public short Level { get; set; }
	[UnityHash(Code = 45, IsOptional = True)]
	public short WeaponType { get; set; }
	[UnityHash(Code = 44, IsOptional = True)]
	public byte State { get; set; }
	[UnityHash(Code = 60, IsOptional = True)]
	protected int FieldId { set; }
	[UnityHash(Code = 105, IsOptional = True)]
	private byte RoomType { set; }
	[UnityHash(Code = 214, IsOptional = True)]
	public short SubWeaponType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36D9318 Offset: 0x36D5318 VA: 0x36D9318
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36D9320 Offset: 0x36D5320 VA: 0x36D9320 Slot: 8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36D9328 Offset: 0x36D5328 VA: 0x36D9328
	protected void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D9330 Offset: 0x36D5330 VA: 0x36D9330 Slot: 7
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36D9338 Offset: 0x36D5338 VA: 0x36D9338
	protected void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D9340 Offset: 0x36D5340 VA: 0x36D9340 Slot: 9
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x36D9348 Offset: 0x36D5348 VA: 0x36D9348
	protected void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36D9350 Offset: 0x36D5350 VA: 0x36D9350 Slot: 13
	public bool get_IsPartyLeader() { }

	[CompilerGenerated]
	// RVA: 0x36D9358 Offset: 0x36D5358 VA: 0x36D9358
	protected void set_IsPartyLeader(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36D9364 Offset: 0x36D5364 VA: 0x36D9364 Slot: 11
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x36D936C Offset: 0x36D536C VA: 0x36D936C
	protected void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x36D9374 Offset: 0x36D5374 VA: 0x36D9374 Slot: 12
	public short get_WeaponType() { }

	[CompilerGenerated]
	// RVA: 0x36D937C Offset: 0x36D537C VA: 0x36D937C
	protected void set_WeaponType(short value) { }

	[CompilerGenerated]
	// RVA: 0x36D9384 Offset: 0x36D5384 VA: 0x36D9384 Slot: 10
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x36D938C Offset: 0x36D538C VA: 0x36D938C
	protected void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D9394 Offset: 0x36D5394 VA: 0x36D9394
	protected void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D939C Offset: 0x36D539C VA: 0x36D939C
	private void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D93A4 Offset: 0x36D53A4 VA: 0x36D93A4 Slot: 14
	public short get_SubWeaponType() { }

	[CompilerGenerated]
	// RVA: 0x36D93AC Offset: 0x36D53AC VA: 0x36D93AC
	protected void set_SubWeaponType(short value) { }

	// RVA: 0x36D93B4 Offset: 0x36D53B4 VA: 0x36D93B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36D93BC Offset: 0x36D53BC VA: 0x36D93BC Slot: 3
	public override string ToString() { }

	// RVA: 0x36D95AC Offset: 0x36D55AC VA: 0x36D95AC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36D9C50 Offset: 0x36D5C50 VA: 0x36D9C50 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
