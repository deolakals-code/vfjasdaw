// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Npcs
public class NpcPatternData : BinaryBase // TypeDefIndex: 11157
{
	// Fields
	[CompilerGenerated]
	private byte <ActionType>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <Condition>k__BackingField; // 0x1B
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1C

	// Properties
	public byte ActionType { get; set; }
	public byte Index { get; set; }
	public byte Condition { get; set; }
	public short SkillId { get; set; }

	// Methods

	// RVA: 0x35CBAF0 Offset: 0x35C7AF0 VA: 0x35CBAF0
	public void .ctor() { }

	// RVA: 0x35CBAF8 Offset: 0x35C7AF8 VA: 0x35CBAF8
	public void .ctor(byte actionType, byte index, byte condition, short skillId) { }

	[CompilerGenerated]
	// RVA: 0x35CBB40 Offset: 0x35C7B40 VA: 0x35CBB40
	public byte get_ActionType() { }

	[CompilerGenerated]
	// RVA: 0x35CBB48 Offset: 0x35C7B48 VA: 0x35CBB48
	protected void set_ActionType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CBB50 Offset: 0x35C7B50 VA: 0x35CBB50
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35CBB58 Offset: 0x35C7B58 VA: 0x35CBB58
	protected void set_Index(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CBB60 Offset: 0x35C7B60 VA: 0x35CBB60
	public byte get_Condition() { }

	[CompilerGenerated]
	// RVA: 0x35CBB68 Offset: 0x35C7B68 VA: 0x35CBB68
	protected void set_Condition(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CBB70 Offset: 0x35C7B70 VA: 0x35CBB70
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x35CBB78 Offset: 0x35C7B78 VA: 0x35CBB78
	protected void set_SkillId(short value) { }

	// RVA: 0x35CBB80 Offset: 0x35C7B80 VA: 0x35CBB80 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35CBCB4 Offset: 0x35C7CB4 VA: 0x35CBCB4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
