// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.MyRoomEvent
public class MyRoomEventPetSendData : UnityHashBase // TypeDefIndex: 12534
{
	// Fields
	[CompilerGenerated]
	private long <Uuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <EventId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x38

	// Properties
	[PacketClass(Code = 184)]
	public int MonsterUuid { get; set; }
	[PacketClass(Code = 226)]
	public byte EventId { get; set; }
	[PacketClass(Code = 211)]
	public string Name { get; set; }
	[PacketClass(Code = 205)]
	public int Point { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x361A4D4 Offset: 0x36164D4 VA: 0x361A4D4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x361A4DC Offset: 0x36164DC VA: 0x361A4DC
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x361A4E4 Offset: 0x36164E4 VA: 0x361A4E4
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x361A4EC Offset: 0x36164EC VA: 0x361A4EC
	public byte get_EventId() { }

	[CompilerGenerated]
	// RVA: 0x361A4F4 Offset: 0x36164F4 VA: 0x361A4F4
	public void set_EventId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361A4FC Offset: 0x36164FC VA: 0x361A4FC
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x361A504 Offset: 0x3616504 VA: 0x361A504
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x361A50C Offset: 0x361650C VA: 0x361A50C
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x361A514 Offset: 0x3616514 VA: 0x361A514
	public void set_Point(int value) { }

	// RVA: 0x361A51C Offset: 0x361651C VA: 0x361A51C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x361A524 Offset: 0x3616524 VA: 0x361A524 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x361A7A4 Offset: 0x36167A4 VA: 0x361A7A4 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
