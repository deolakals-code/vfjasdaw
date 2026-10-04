// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public class RoomLobbySetting : BinaryBase // TypeDefIndex: 11290
{
	// Fields
	[CompilerGenerated]
	private short <Flag>k__BackingField; // 0x1A
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x1C

	// Properties
	public short Flag { get; set; }
	public short Level { get; set; }
	public bool IsBattle { get; }

	// Methods

	// RVA: 0x36D8284 Offset: 0x36D4284 VA: 0x36D8284
	public void .ctor(bool isForcibly, bool isMatching, bool isSecondParty, short level = 0) { }

	// RVA: 0x36D8318 Offset: 0x36D4318 VA: 0x36D8318
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36D8320 Offset: 0x36D4320 VA: 0x36D8320
	public short get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36D8328 Offset: 0x36D4328 VA: 0x36D8328
	protected void set_Flag(short value) { }

	[CompilerGenerated]
	// RVA: 0x36D8330 Offset: 0x36D4330 VA: 0x36D8330
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x36D8338 Offset: 0x36D4338 VA: 0x36D8338
	protected void set_Level(short value) { }

	// RVA: 0x36D8340 Offset: 0x36D4340 VA: 0x36D8340
	public bool get_IsBattle() { }

	// RVA: 0x36D82FC Offset: 0x36D42FC VA: 0x36D82FC
	private void SetFlag(short flag, bool on) { }

	// RVA: 0x36D834C Offset: 0x36D434C VA: 0x36D834C
	public void ChangeLevel(short level) { }

	// RVA: 0x36D8354 Offset: 0x36D4354 VA: 0x36D8354 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D8460 Offset: 0x36D4460 VA: 0x36D8460 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
