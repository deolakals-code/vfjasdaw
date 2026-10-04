// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FriendManager.FriendState // TypeDefIndex: 1827
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x14
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x16
	[CompilerGenerated]
	private string <TimeText>k__BackingField; // 0x18
	[CompilerGenerated]
	private DateTime <Time>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <LoginDate>k__BackingField; // 0x38
	public int FieldId; // 0x40
	public byte FieldType; // 0x44

	// Properties
	public int Id { get; set; }
	public short Level { get; set; }
	public byte State { get; set; }
	public string TimeText { get; set; }
	public DateTime Time { get; set; }
	public string UserName { get; set; }
	public int WorldId { get; set; }
	public DateTime LoginDate { get; set; }
	public bool IsReserve { get; }
	public bool IsOnline { get; }
	public bool IsAnotherWorld { get; }

	// Methods

	// RVA: 0x20E9D28 Offset: 0x20E5D28 VA: 0x20E9D28
	public void .ctor() { }

	// RVA: 0x20E93D4 Offset: 0x20E53D4 VA: 0x20E93D4
	public void .ctor(int id, bool isReserve) { }

	// RVA: 0x20E9008 Offset: 0x20E5008 VA: 0x20E9008
	public void .ctor(int id, short lv, byte state, string timeText, DateTime time, string name, int worldId, DateTime loginDate, int fieldId, byte fieldType) { }

	// RVA: 0x20E93CC Offset: 0x20E53CC VA: 0x20E93CC
	public void ChangeState(byte state) { }

	// RVA: 0x20E9DC8 Offset: 0x20E5DC8 VA: 0x20E9DC8
	public void SetLevel(short lv) { }

	// RVA: 0x20E9DD0 Offset: 0x20E5DD0 VA: 0x20E9DD0
	public void SetWorldId(int worldId) { }

	[CompilerGenerated]
	// RVA: 0x20EB244 Offset: 0x20E7244 VA: 0x20EB244
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x20EB24C Offset: 0x20E724C VA: 0x20EB24C
	private void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x20EB254 Offset: 0x20E7254 VA: 0x20EB254
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x20EB25C Offset: 0x20E725C VA: 0x20EB25C
	private void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x20EB264 Offset: 0x20E7264 VA: 0x20EB264
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x20EB26C Offset: 0x20E726C VA: 0x20EB26C
	private void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x20EB274 Offset: 0x20E7274 VA: 0x20EB274
	public string get_TimeText() { }

	[CompilerGenerated]
	// RVA: 0x20EB27C Offset: 0x20E727C VA: 0x20EB27C
	private void set_TimeText(string value) { }

	[CompilerGenerated]
	// RVA: 0x20EB284 Offset: 0x20E7284 VA: 0x20EB284
	public DateTime get_Time() { }

	[CompilerGenerated]
	// RVA: 0x20EB28C Offset: 0x20E728C VA: 0x20EB28C
	private void set_Time(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x20EB294 Offset: 0x20E7294 VA: 0x20EB294
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x20EB29C Offset: 0x20E729C VA: 0x20EB29C
	private void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x20EB2A4 Offset: 0x20E72A4 VA: 0x20EB2A4
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x20EB2AC Offset: 0x20E72AC VA: 0x20EB2AC
	private void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x20EB2B4 Offset: 0x20E72B4 VA: 0x20EB2B4
	public DateTime get_LoginDate() { }

	[CompilerGenerated]
	// RVA: 0x20EB2BC Offset: 0x20E72BC VA: 0x20EB2BC
	private void set_LoginDate(DateTime value) { }

	// RVA: 0x20E93BC Offset: 0x20E53BC VA: 0x20E93BC
	public bool get_IsReserve() { }

	// RVA: 0x20E9DD8 Offset: 0x20E5DD8 VA: 0x20E9DD8
	public bool get_IsOnline() { }

	// RVA: 0x20EB2C4 Offset: 0x20E72C4 VA: 0x20EB2C4
	public bool get_IsAnotherWorld() { }
}
