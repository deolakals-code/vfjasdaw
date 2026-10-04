// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillSummonsRemoveData : UnityHashBase // TypeDefIndex: 13196
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <ForceRemove>k__BackingField; // 0x1D
	[CompilerGenerated]
	private ArchetypeUid <RemoveServant>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public short SkillId { get; set; }
	public byte LocalId { get; set; }
	public bool ForceRemove { get; set; }
	public ArchetypeUid RemoveServant { get; set; }

	// Methods

	// RVA: 0x36C5D0C Offset: 0x36C1D0C VA: 0x36C5D0C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36C5D14 Offset: 0x36C1D14 VA: 0x36C5D14
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C5D1C Offset: 0x36C1D1C VA: 0x36C5D1C
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C5D24 Offset: 0x36C1D24 VA: 0x36C5D24
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36C5D2C Offset: 0x36C1D2C VA: 0x36C5D2C
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C5D34 Offset: 0x36C1D34 VA: 0x36C5D34
	public bool get_ForceRemove() { }

	[CompilerGenerated]
	// RVA: 0x36C5D3C Offset: 0x36C1D3C VA: 0x36C5D3C
	public void set_ForceRemove(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36C5D48 Offset: 0x36C1D48 VA: 0x36C5D48
	public ArchetypeUid get_RemoveServant() { }

	[CompilerGenerated]
	// RVA: 0x36C5D50 Offset: 0x36C1D50 VA: 0x36C5D50
	public void set_RemoveServant(ArchetypeUid value) { }

	// RVA: 0x36C5D58 Offset: 0x36C1D58 VA: 0x36C5D58
	public void .ctor() { }

	// RVA: 0x36C5D60 Offset: 0x36C1D60 VA: 0x36C5D60 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36C5F68 Offset: 0x36C1F68 VA: 0x36C5F68 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
