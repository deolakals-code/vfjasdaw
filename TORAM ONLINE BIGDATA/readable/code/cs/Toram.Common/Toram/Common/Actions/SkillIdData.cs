// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillIdData : UnityHashBase // TypeDefIndex: 13194
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

	// RVA: 0x36C53F4 Offset: 0x36C13F4 VA: 0x36C53F4
	public void .ctor() { }

	// RVA: 0x36C53FC Offset: 0x36C13FC VA: 0x36C53FC
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36C5404 Offset: 0x36C1404 VA: 0x36C5404
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C540C Offset: 0x36C140C VA: 0x36C540C
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C5414 Offset: 0x36C1414 VA: 0x36C5414
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36C541C Offset: 0x36C141C VA: 0x36C541C
	public void set_LocalId(byte value) { }

	// RVA: 0x36C5424 Offset: 0x36C1424 VA: 0x36C5424 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C542C Offset: 0x36C142C VA: 0x36C542C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C55D8 Offset: 0x36C15D8 VA: 0x36C55D8 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
