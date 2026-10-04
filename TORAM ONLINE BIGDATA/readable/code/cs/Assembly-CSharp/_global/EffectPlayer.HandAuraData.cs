// Assembly: Assembly-CSharp.dll
// Namespace: 
private class EffectPlayer.HandAuraData // TypeDefIndex: 239
{
	// Fields
	private List<int> takeUids; // 0x10
	[CompilerGenerated]
	private SkillId <SkillId>k__BackingField; // 0x18

	// Properties
	public SkillId SkillId { get; set; }
	public int[] TakeUids { get; }
	public bool IsEnd { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x22ADB94 Offset: 0x22A9B94 VA: 0x22ADB94
	public SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x22ADB9C Offset: 0x22A9B9C VA: 0x22ADB9C
	private void set_SkillId(SkillId value) { }

	// RVA: 0x22AC390 Offset: 0x22A8390 VA: 0x22AC390
	public int[] get_TakeUids() { }

	// RVA: 0x22AC76C Offset: 0x22A876C VA: 0x22AC76C
	public bool get_IsEnd() { }

	// RVA: 0x22AC3FC Offset: 0x22A83FC VA: 0x22AC3FC
	public void .ctor(SkillId skillId) { }

	// RVA: 0x22AC48C Offset: 0x22A848C VA: 0x22AC48C
	public void AddTakeUid(int uid) { }

	// RVA: 0x22AC714 Offset: 0x22A8714 VA: 0x22AC714
	public void RemoveTakeUid(int uid) { }
}
