// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillCancelData : UnityHashBase // TypeDefIndex: 13193
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1C

	// Properties
	[UnityHash(Code = 39)]
	public short SkillId { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C50D0 Offset: 0x36C10D0 VA: 0x36C50D0
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36C50D8 Offset: 0x36C10D8 VA: 0x36C50D8
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C50E0 Offset: 0x36C10E0 VA: 0x36C50E0
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C50E8 Offset: 0x36C10E8 VA: 0x36C50E8
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36C50F0 Offset: 0x36C10F0 VA: 0x36C50F0
	public void set_LocalId(byte value) { }

	// RVA: 0x36C50F8 Offset: 0x36C10F8 VA: 0x36C50F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C5100 Offset: 0x36C1100 VA: 0x36C5100 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C52AC Offset: 0x36C12AC VA: 0x36C52AC Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
