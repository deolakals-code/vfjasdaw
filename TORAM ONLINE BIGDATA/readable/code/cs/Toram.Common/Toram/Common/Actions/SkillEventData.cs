// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillEventData : UnityHashBase // TypeDefIndex: 13120
{
	// Fields
	[CompilerGenerated]
	private short <SkillID>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <SkillEventId>k__BackingField; // 0x1E
	[CompilerGenerated]
	private Dictionary<int, int> <Value>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 39, IsOptional = False)]
	public short SkillID { get; set; }
	[UnityHash(Code = 23, IsOptional = False)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 18, IsOptional = False)]
	public short SkillEventId { get; set; }
	[UnityHash(Code = 55, IsOptional = False)]
	public Dictionary<int, int> Value { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36AAC88 Offset: 0x36A6C88 VA: 0x36AAC88
	public void .ctor() { }

	// RVA: 0x36AAC90 Offset: 0x36A6C90 VA: 0x36AAC90
	public void .ctor(Dictionary<object, object> hash) { }

	[CompilerGenerated]
	// RVA: 0x36AAC98 Offset: 0x36A6C98 VA: 0x36AAC98
	public short get_SkillID() { }

	[CompilerGenerated]
	// RVA: 0x36AACA0 Offset: 0x36A6CA0 VA: 0x36AACA0
	public void set_SkillID(short value) { }

	[CompilerGenerated]
	// RVA: 0x36AACA8 Offset: 0x36A6CA8 VA: 0x36AACA8
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36AACB0 Offset: 0x36A6CB0 VA: 0x36AACB0
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AACB8 Offset: 0x36A6CB8 VA: 0x36AACB8
	public short get_SkillEventId() { }

	[CompilerGenerated]
	// RVA: 0x36AACC0 Offset: 0x36A6CC0 VA: 0x36AACC0
	public void set_SkillEventId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36AACC8 Offset: 0x36A6CC8 VA: 0x36AACC8
	public Dictionary<int, int> get_Value() { }

	[CompilerGenerated]
	// RVA: 0x36AACD0 Offset: 0x36A6CD0 VA: 0x36AACD0
	public void set_Value(Dictionary<int, int> value) { }

	// RVA: 0x36AACD8 Offset: 0x36A6CD8 VA: 0x36AACD8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AACE0 Offset: 0x36A6CE0 VA: 0x36AACE0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36AB070 Offset: 0x36A7070 VA: 0x36AB070 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
