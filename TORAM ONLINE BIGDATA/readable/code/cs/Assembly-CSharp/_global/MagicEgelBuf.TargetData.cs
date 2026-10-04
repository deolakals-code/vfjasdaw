// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MagicEgelBuf.TargetData // TypeDefIndex: 3235
{
	// Fields
	[CompilerGenerated]
	private int <SkillId>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x14
	private List<GameObject> targetList; // 0x18

	// Properties
	public int SkillId { get; set; }
	public byte LocalId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x233AD3C Offset: 0x2336D3C VA: 0x233AD3C
	public int get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x233AD44 Offset: 0x2336D44 VA: 0x233AD44
	private void set_SkillId(int value) { }

	[CompilerGenerated]
	// RVA: 0x233AD4C Offset: 0x2336D4C VA: 0x233AD4C
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x233AD54 Offset: 0x2336D54 VA: 0x233AD54
	private void set_LocalId(byte value) { }

	// RVA: 0x233A970 Offset: 0x2336970 VA: 0x233A970
	public void .ctor(int skillId, byte localId) { }

	// RVA: 0x233AD5C Offset: 0x2336D5C VA: 0x233AD5C
	public void .ctor(SkillIdData skillIdData) { }

	// RVA: 0x233AA10 Offset: 0x2336A10 VA: 0x233AA10
	public void AddTarget(GameObject target) { }

	// RVA: 0x233A94C Offset: 0x233694C VA: 0x233A94C
	public bool Contains(int skillId, byte localId) { }

	// RVA: 0x233AB6C Offset: 0x2336B6C VA: 0x233AB6C
	public bool Contains(SkillIdData skillIdData) { }
}
