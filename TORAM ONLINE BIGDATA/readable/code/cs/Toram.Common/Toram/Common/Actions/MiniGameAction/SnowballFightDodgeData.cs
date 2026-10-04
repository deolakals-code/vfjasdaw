// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions.MiniGameAction
public class SnowballFightDodgeData : UnityHashBase // TypeDefIndex: 13230
{
	// Fields
	[CompilerGenerated]
	private int <Uuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <Angle>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <BallNum>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 4)]
	public int Uuid { get; set; }
	[UnityHash(Code = 11)]
	public short Angle { get; set; }
	public byte MiniGame { get; }
	public short[] Position { get; set; }
	public byte BallNum { get; set; }

	// Methods

	// RVA: 0x36E72C8 Offset: 0x36E32C8 VA: 0x36E72C8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36E72D0 Offset: 0x36E32D0 VA: 0x36E72D0
	public int get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x36E72D8 Offset: 0x36E32D8 VA: 0x36E72D8
	public void set_Uuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36E72E0 Offset: 0x36E32E0 VA: 0x36E72E0
	public short get_Angle() { }

	[CompilerGenerated]
	// RVA: 0x36E72E8 Offset: 0x36E32E8 VA: 0x36E72E8
	public void set_Angle(short value) { }

	// RVA: 0x36E72F0 Offset: 0x36E32F0 VA: 0x36E72F0 Slot: 7
	public byte get_MiniGame() { }

	[CompilerGenerated]
	// RVA: 0x36E72F8 Offset: 0x36E32F8 VA: 0x36E72F8
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36E7300 Offset: 0x36E3300 VA: 0x36E7300
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36E7308 Offset: 0x36E3308 VA: 0x36E7308
	public byte get_BallNum() { }

	[CompilerGenerated]
	// RVA: 0x36E7310 Offset: 0x36E3310 VA: 0x36E7310
	public void set_BallNum(byte value) { }

	// RVA: 0x36E7318 Offset: 0x36E3318 VA: 0x36E7318
	public void .ctor() { }

	// RVA: 0x36E7320 Offset: 0x36E3320 VA: 0x36E7320
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36E7328 Offset: 0x36E3328 VA: 0x36E7328 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36E7534 Offset: 0x36E3534 VA: 0x36E7534 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
