// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class GuildReserveData : UnityHashBase // TypeDefIndex: 12991
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x38
	[CompilerGenerated]
	private DateTime <Time>k__BackingField; // 0x40

	// Properties
	[UnityHash(Code = 74)]
	public int ArchetypeId { get; set; }
	[UnityHash(Code = 66)]
	public string UserName { get; set; }
	[UnityHash(Code = 219)]
	public int GuildId { get; set; }
	[UnityHash(Code = 220)]
	public string GuildName { get; set; }
	[UnityHash(Code = 83, IsOptional = True)]
	public string Message { get; set; }
	[UnityHash(Code = 172)]
	public DateTime Time { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x368936C Offset: 0x368536C VA: 0x368936C
	public void .ctor() { }

	// RVA: 0x3689374 Offset: 0x3685374 VA: 0x3689374
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x368937C Offset: 0x368537C VA: 0x368937C
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3689384 Offset: 0x3685384 VA: 0x3689384
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368938C Offset: 0x368538C VA: 0x368938C
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3689394 Offset: 0x3685394 VA: 0x3689394
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x368939C Offset: 0x368539C VA: 0x368939C
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x36893A4 Offset: 0x36853A4 VA: 0x36893A4
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36893AC Offset: 0x36853AC VA: 0x36893AC
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x36893B4 Offset: 0x36853B4 VA: 0x36893B4
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36893BC Offset: 0x36853BC VA: 0x36893BC
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x36893C4 Offset: 0x36853C4 VA: 0x36893C4
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x36893CC Offset: 0x36853CC VA: 0x36893CC
	public DateTime get_Time() { }

	[CompilerGenerated]
	// RVA: 0x36893D4 Offset: 0x36853D4 VA: 0x36893D4
	public void set_Time(DateTime value) { }

	// RVA: 0x36893DC Offset: 0x36853DC VA: 0x36893DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36893E4 Offset: 0x36853E4 VA: 0x36893E4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3689794 Offset: 0x3685794 VA: 0x3689794 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
