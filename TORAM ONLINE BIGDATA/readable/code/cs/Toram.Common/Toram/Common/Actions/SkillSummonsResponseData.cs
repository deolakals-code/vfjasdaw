// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillSummonsResponseData : UnityHashBase // TypeDefIndex: 13199
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private ArchetypeUid <Servant>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30
	[CompilerGenerated]
	private SupportResultData <SupportData>k__BackingField; // 0x38

	// Properties
	public override byte Code { get; }
	public short SkillId { get; set; }
	public ArchetypeUid Servant { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public SupportResultData SupportData { get; set; }

	// Methods

	// RVA: 0x36C6D08 Offset: 0x36C2D08 VA: 0x36C6D08 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36C6D10 Offset: 0x36C2D10 VA: 0x36C6D10
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C6D18 Offset: 0x36C2D18 VA: 0x36C6D18
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C6D20 Offset: 0x36C2D20 VA: 0x36C6D20
	public ArchetypeUid get_Servant() { }

	[CompilerGenerated]
	// RVA: 0x36C6D28 Offset: 0x36C2D28 VA: 0x36C6D28
	public void set_Servant(ArchetypeUid value) { }

	[CompilerGenerated]
	// RVA: 0x36C6D30 Offset: 0x36C2D30 VA: 0x36C6D30
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36C6D38 Offset: 0x36C2D38 VA: 0x36C6D38
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C6D40 Offset: 0x36C2D40 VA: 0x36C6D40
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36C6D48 Offset: 0x36C2D48 VA: 0x36C6D48
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C6D50 Offset: 0x36C2D50 VA: 0x36C6D50
	public SupportResultData get_SupportData() { }

	[CompilerGenerated]
	// RVA: 0x36C6D58 Offset: 0x36C2D58 VA: 0x36C6D58
	public void set_SupportData(SupportResultData value) { }

	// RVA: 0x36C6D60 Offset: 0x36C2D60 VA: 0x36C6D60
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36C6D68 Offset: 0x36C2D68 VA: 0x36C6D68 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36C6FA8 Offset: 0x36C2FA8 VA: 0x36C6FA8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
