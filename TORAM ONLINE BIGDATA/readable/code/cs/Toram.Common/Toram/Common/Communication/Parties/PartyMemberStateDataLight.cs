// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Parties
public class PartyMemberStateDataLight : BinaryBase, IPartyMemberStateData // TypeDefIndex: 13004
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <FieldType>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <RoomId>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <Weapon>k__BackingField; // 0x36
	[CompilerGenerated]
	private byte <SubWeapon>k__BackingField; // 0x37
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <AdditionalId>k__BackingField; // 0x3C

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public string UserName { get; set; }
	public int FieldId { get; set; }
	public byte FieldType { get; set; }
	public int RoomId { get; set; }
	public short Level { get; set; }
	public byte Weapon { get; set; }
	public byte SubWeapon { get; set; }
	public byte State { get; set; }
	public int AdditionalId { get; set; }

	// Methods

	// RVA: 0x368B90C Offset: 0x368790C VA: 0x368B90C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x368B914 Offset: 0x3687914 VA: 0x368B914 Slot: 8
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x368B91C Offset: 0x368791C VA: 0x368B91C
	protected void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368B924 Offset: 0x3687924 VA: 0x368B924 Slot: 9
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x368B92C Offset: 0x368792C VA: 0x368B92C
	protected void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368B934 Offset: 0x3687934 VA: 0x368B934 Slot: 10
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x368B93C Offset: 0x368793C VA: 0x368B93C
	protected void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x368B944 Offset: 0x3687944 VA: 0x368B944 Slot: 11
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x368B94C Offset: 0x368794C VA: 0x368B94C
	protected void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368B954 Offset: 0x3687954 VA: 0x368B954 Slot: 12
	public byte get_FieldType() { }

	[CompilerGenerated]
	// RVA: 0x368B95C Offset: 0x368795C VA: 0x368B95C
	protected void set_FieldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368B964 Offset: 0x3687964 VA: 0x368B964 Slot: 13
	public int get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x368B96C Offset: 0x368796C VA: 0x368B96C
	protected void set_RoomId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368B974 Offset: 0x3687974 VA: 0x368B974 Slot: 14
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x368B97C Offset: 0x368797C VA: 0x368B97C
	protected void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x368B984 Offset: 0x3687984 VA: 0x368B984 Slot: 15
	public byte get_Weapon() { }

	[CompilerGenerated]
	// RVA: 0x368B98C Offset: 0x368798C VA: 0x368B98C
	protected void set_Weapon(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368B994 Offset: 0x3687994 VA: 0x368B994 Slot: 16
	public byte get_SubWeapon() { }

	[CompilerGenerated]
	// RVA: 0x368B99C Offset: 0x368799C VA: 0x368B99C
	protected void set_SubWeapon(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368B9A4 Offset: 0x36879A4 VA: 0x368B9A4 Slot: 17
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x368B9AC Offset: 0x36879AC VA: 0x368B9AC
	protected void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368B9B4 Offset: 0x36879B4 VA: 0x368B9B4 Slot: 18
	public int get_AdditionalId() { }

	[CompilerGenerated]
	// RVA: 0x368B9BC Offset: 0x36879BC VA: 0x368B9BC
	protected void set_AdditionalId(int value) { }

	// RVA: 0x368B9C4 Offset: 0x36879C4 VA: 0x368B9C4 Slot: 3
	public override string ToString() { }

	// RVA: 0x368BA84 Offset: 0x3687A84 VA: 0x368BA84 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368BB8C Offset: 0x3687B8C VA: 0x368BB8C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
