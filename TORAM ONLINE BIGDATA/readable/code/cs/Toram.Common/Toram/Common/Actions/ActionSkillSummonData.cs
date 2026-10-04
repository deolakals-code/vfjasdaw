// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class ActionSkillSummonData : UnityHashBase // TypeDefIndex: 13108
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 39)]
	public short SkillId { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 10)]
	public short[] Position { get; set; }
	[UnityHash(Code = 11)]
	public short Rotation { get; set; }

	// Methods

	// RVA: 0x36A3A78 Offset: 0x369FA78 VA: 0x36A3A78 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36A3A80 Offset: 0x369FA80 VA: 0x36A3A80
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36A3A88 Offset: 0x369FA88 VA: 0x36A3A88
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A3A90 Offset: 0x369FA90 VA: 0x36A3A90
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36A3A98 Offset: 0x369FA98 VA: 0x36A3A98
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A3AA0 Offset: 0x369FAA0 VA: 0x36A3AA0
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36A3AA8 Offset: 0x369FAA8 VA: 0x36A3AA8
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A3AB0 Offset: 0x369FAB0 VA: 0x36A3AB0
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36A3AB8 Offset: 0x369FAB8 VA: 0x36A3AB8
	public void set_Rotation(short value) { }

	// RVA: 0x36A3AC0 Offset: 0x369FAC0 VA: 0x36A3AC0
	public void .ctor() { }

	// RVA: 0x36A3AC8 Offset: 0x369FAC8 VA: 0x36A3AC8 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36A3C78 Offset: 0x369FC78 VA: 0x36A3C78 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
