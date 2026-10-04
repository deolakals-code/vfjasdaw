// Assembly: Assembly-CSharp.dll
// Namespace: 
protected class BeragelungDebuffBase.DebuffData // TypeDefIndex: 849
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x14
	[CompilerGenerated]
	private float <EffectTime>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsMine>k__BackingField; // 0x1C

	// Properties
	public int ArchetypeId { get; set; }
	public int Level { get; set; }
	public float EffectTime { get; set; }
	public bool IsMine { get; set; }
	public bool IsEnd { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1ECDEE8 Offset: 0x1EC9EE8 VA: 0x1ECDEE8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x1ECDEF0 Offset: 0x1EC9EF0 VA: 0x1ECDEF0
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ECDEF8 Offset: 0x1EC9EF8 VA: 0x1ECDEF8
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1ECDF00 Offset: 0x1EC9F00 VA: 0x1ECDF00
	private void set_Level(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ECDF08 Offset: 0x1EC9F08 VA: 0x1ECDF08
	public float get_EffectTime() { }

	[CompilerGenerated]
	// RVA: 0x1ECDF10 Offset: 0x1EC9F10 VA: 0x1ECDF10
	public void set_EffectTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x1ECDF18 Offset: 0x1EC9F18 VA: 0x1ECDF18
	public bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x1ECDF20 Offset: 0x1EC9F20 VA: 0x1ECDF20
	private void set_IsMine(bool value) { }

	// RVA: 0x1ECDD78 Offset: 0x1EC9D78 VA: 0x1ECDD78
	public bool get_IsEnd() { }

	// RVA: 0x1ECD7F8 Offset: 0x1EC97F8 VA: 0x1ECD7F8
	public void .ctor(int archetypeId, int level, float effectTime, bool mine) { }

	// RVA: 0x1ECDD68 Offset: 0x1EC9D68 VA: 0x1ECDD68
	public void Update(float dTime) { }
}
