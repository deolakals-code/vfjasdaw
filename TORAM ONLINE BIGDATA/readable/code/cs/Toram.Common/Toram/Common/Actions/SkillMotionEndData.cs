// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillMotionEndData : SkillIdData // TypeDefIndex: 13132
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28

	// Properties
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36AEE98 Offset: 0x36AAE98 VA: 0x36AEE98
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36AEEA0 Offset: 0x36AAEA0 VA: 0x36AEEA0
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36AEEA8 Offset: 0x36AAEA8 VA: 0x36AEEA8
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36AEEB0 Offset: 0x36AAEB0 VA: 0x36AEEB0
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36AEEB8 Offset: 0x36AAEB8 VA: 0x36AEEB8
	public void set_Rotation(short value) { }

	// RVA: 0x36AEEC0 Offset: 0x36AAEC0 VA: 0x36AEEC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AEEC8 Offset: 0x36AAEC8 VA: 0x36AEEC8 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36AEFD8 Offset: 0x36AAFD8 VA: 0x36AEFD8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
