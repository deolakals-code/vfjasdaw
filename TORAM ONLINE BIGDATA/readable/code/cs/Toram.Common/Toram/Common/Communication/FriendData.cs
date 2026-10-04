// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class FriendData : BinaryBase // TypeDefIndex: 12982
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <Region>k__BackingField; // 0x2E
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x2F
	[CompilerGenerated]
	private DateTime <Time>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <LoginDate>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <FieldType>k__BackingField; // 0x44

	// Properties
	public int ArchetypeId { get; set; }
	public string UserName { get; set; }
	public int WorldId { get; set; }
	public short Level { get; set; }
	public byte Region { get; set; }
	public byte State { get; set; }
	public DateTime Time { get; set; }
	public DateTime LoginDate { get; set; }
	public int FieldId { get; set; }
	public byte FieldType { get; set; }

	// Methods

	// RVA: 0x3687204 Offset: 0x3683204 VA: 0x3687204
	public void .ctor() { }

	// RVA: 0x368720C Offset: 0x368320C VA: 0x368720C
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x3687214 Offset: 0x3683214 VA: 0x3687214 Slot: 8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x368721C Offset: 0x368321C VA: 0x368721C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3687224 Offset: 0x3683224 VA: 0x3687224 Slot: 9
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x368722C Offset: 0x368322C VA: 0x368722C
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3687234 Offset: 0x3683234 VA: 0x3687234 Slot: 10
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x368723C Offset: 0x368323C VA: 0x368723C
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3687244 Offset: 0x3683244 VA: 0x3687244 Slot: 11
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x368724C Offset: 0x368324C VA: 0x368724C
	public void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x3687254 Offset: 0x3683254 VA: 0x3687254 Slot: 12
	public byte get_Region() { }

	[CompilerGenerated]
	// RVA: 0x368725C Offset: 0x368325C VA: 0x368725C
	public void set_Region(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3687264 Offset: 0x3683264 VA: 0x3687264 Slot: 13
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x368726C Offset: 0x368326C VA: 0x368726C
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3687274 Offset: 0x3683274 VA: 0x3687274
	public DateTime get_Time() { }

	[CompilerGenerated]
	// RVA: 0x368727C Offset: 0x368327C VA: 0x368727C
	public void set_Time(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3687284 Offset: 0x3683284 VA: 0x3687284 Slot: 14
	public DateTime get_LoginDate() { }

	[CompilerGenerated]
	// RVA: 0x368728C Offset: 0x368328C VA: 0x368728C
	public void set_LoginDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3687294 Offset: 0x3683294 VA: 0x3687294 Slot: 15
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x368729C Offset: 0x368329C VA: 0x368729C
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36872A4 Offset: 0x36832A4 VA: 0x36872A4 Slot: 16
	public byte get_FieldType() { }

	[CompilerGenerated]
	// RVA: 0x36872AC Offset: 0x36832AC VA: 0x36872AC
	public void set_FieldType(byte value) { }

	// RVA: 0x36872B4 Offset: 0x36832B4 VA: 0x36872B4 Slot: 3
	public override string ToString() { }

	// RVA: 0x3687378 Offset: 0x3683378 VA: 0x3687378 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3687530 Offset: 0x3683530 VA: 0x3687530 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
