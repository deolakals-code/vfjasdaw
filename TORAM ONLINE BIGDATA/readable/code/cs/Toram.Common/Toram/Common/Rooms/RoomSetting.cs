// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public class RoomSetting : UnityHashBase // TypeDefIndex: 11297
{
	// Fields
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x19
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x1A

	// Properties
	[UnityHash(Code = 43, IsOptional = True)]
	public byte Flag { get; set; }
	[UnityHash(Code = 29, IsOptional = True)]
	public short Level { get; set; }
	public bool IsBattle { get; }
	public bool IsAnnihilated { get; }
	public bool IsRoomEnd { get; }
	public bool IsRandom { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36DA500 Offset: 0x36D6500 VA: 0x36DA500
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36DA508 Offset: 0x36D6508 VA: 0x36DA508
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36DA510 Offset: 0x36D6510 VA: 0x36DA510
	protected void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DA518 Offset: 0x36D6518 VA: 0x36DA518
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x36DA520 Offset: 0x36D6520 VA: 0x36DA520
	protected void set_Level(short value) { }

	// RVA: 0x36DA528 Offset: 0x36D6528 VA: 0x36DA528
	public bool get_IsBattle() { }

	// RVA: 0x36DA534 Offset: 0x36D6534 VA: 0x36DA534
	public bool get_IsAnnihilated() { }

	// RVA: 0x36DA540 Offset: 0x36D6540 VA: 0x36DA540
	public bool get_IsRoomEnd() { }

	// RVA: 0x36DA54C Offset: 0x36D654C VA: 0x36DA54C
	public bool get_IsRandom() { }

	// RVA: 0x36DA558 Offset: 0x36D6558 VA: 0x36DA558
	public void SetRandom(bool isRandom) { }

	// RVA: 0x36DA578 Offset: 0x36D6578 VA: 0x36DA578 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36DA580 Offset: 0x36D6580 VA: 0x36DA580 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36DA7B0 Offset: 0x36D67B0 VA: 0x36DA7B0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
