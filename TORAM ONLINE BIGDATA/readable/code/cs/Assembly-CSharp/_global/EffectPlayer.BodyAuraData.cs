// Assembly: Assembly-CSharp.dll
// Namespace: 
private class EffectPlayer.BodyAuraData // TypeDefIndex: 240
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
	// RVA: 0x22ADBA4 Offset: 0x22A9BA4 VA: 0x22ADBA4
	public SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x22ADBAC Offset: 0x22A9BAC VA: 0x22ADBAC
	private void set_SkillId(SkillId value) { }

	// RVA: 0x22ACF58 Offset: 0x22A8F58 VA: 0x22ACF58
	public int[] get_TakeUids() { }

	// RVA: 0x22AD514 Offset: 0x22A9514 VA: 0x22AD514
	public bool get_IsEnd() { }

	// RVA: 0x22ACFC4 Offset: 0x22A8FC4 VA: 0x22ACFC4
	public void .ctor(SkillId skillId) { }

	// RVA: 0x22AD054 Offset: 0x22A9054 VA: 0x22AD054
	public void AddTakeUid(int uid) { }

	// RVA: 0x22AD4BC Offset: 0x22A94BC VA: 0x22AD4BC
	public void RemoveTakeUid(int uid) { }
}
