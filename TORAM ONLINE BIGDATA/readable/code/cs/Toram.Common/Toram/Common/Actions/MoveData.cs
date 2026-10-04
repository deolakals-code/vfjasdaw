// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MoveData : UnityHashBase, IMoveData // TypeDefIndex: 13188
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Speed>k__BackingField; // 0x2A
	[CompilerGenerated]
	private bool <IsSpeed>k__BackingField; // 0x2C

	// Properties
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public short Speed { get; set; }
	public bool IsSpeed { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C3058 Offset: 0x36BF058 VA: 0x36C3058
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36C3060 Offset: 0x36BF060 VA: 0x36C3060 Slot: 7
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36C3068 Offset: 0x36BF068 VA: 0x36C3068 Slot: 11
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C3070 Offset: 0x36BF070 VA: 0x36C3070 Slot: 8
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36C3078 Offset: 0x36BF078 VA: 0x36C3078 Slot: 12
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C3080 Offset: 0x36BF080 VA: 0x36C3080 Slot: 9
	public short get_Speed() { }

	[CompilerGenerated]
	// RVA: 0x36C3088 Offset: 0x36BF088 VA: 0x36C3088 Slot: 13
	public void set_Speed(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C3090 Offset: 0x36BF090 VA: 0x36C3090 Slot: 10
	public bool get_IsSpeed() { }

	[CompilerGenerated]
	// RVA: 0x36C3098 Offset: 0x36BF098 VA: 0x36C3098
	private void set_IsSpeed(bool value) { }

	// RVA: 0x36C30A4 Offset: 0x36BF0A4 VA: 0x36C30A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C30AC Offset: 0x36BF0AC VA: 0x36C30AC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C33B0 Offset: 0x36BF3B0 VA: 0x36C33B0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
