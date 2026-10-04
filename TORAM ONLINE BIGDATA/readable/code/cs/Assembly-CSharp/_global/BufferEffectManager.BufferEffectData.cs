// Assembly: Assembly-CSharp.dll
// Namespace: 
private class BufferEffectManager.BufferEffectData // TypeDefIndex: 506
{
	// Fields
	public readonly BufferEffectManager.BufferType BufferType; // 0x10
	public readonly int BufferId; // 0x14
	[CompilerGenerated]
	private int <TakeUid>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsLoadComplete>k__BackingField; // 0x1C
	[CompilerGenerated]
	private Action<int, int> <CallSkillAction>k__BackingField; // 0x20
	[CompilerGenerated]
	private Func<int, int, bool> <CheckSkillAction>k__BackingField; // 0x28
	private List<int> takeUidList; // 0x30

	// Properties
	public int TakeUid { get; set; }
	public bool IsLoadComplete { get; set; }
	public Action<int, int> CallSkillAction { get; set; }
	public Func<int, int, bool> CheckSkillAction { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1830068 Offset: 0x182C068 VA: 0x1830068
	private void set_TakeUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x1830070 Offset: 0x182C070 VA: 0x1830070
	public int get_TakeUid() { }

	[CompilerGenerated]
	// RVA: 0x1830078 Offset: 0x182C078 VA: 0x1830078
	public bool get_IsLoadComplete() { }

	[CompilerGenerated]
	// RVA: 0x1830080 Offset: 0x182C080 VA: 0x1830080
	public void set_IsLoadComplete(bool value) { }

	[CompilerGenerated]
	// RVA: 0x183008C Offset: 0x182C08C VA: 0x183008C
	public Action<int, int> get_CallSkillAction() { }

	[CompilerGenerated]
	// RVA: 0x1830094 Offset: 0x182C094 VA: 0x1830094
	public void set_CallSkillAction(Action<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x183009C Offset: 0x182C09C VA: 0x183009C
	public Func<int, int, bool> get_CheckSkillAction() { }

	[CompilerGenerated]
	// RVA: 0x18300A4 Offset: 0x182C0A4 VA: 0x18300A4
	public void set_CheckSkillAction(Func<int, int, bool> value) { }

	// RVA: 0x182CE74 Offset: 0x1828E74 VA: 0x182CE74
	public void .ctor(BufferEffectManager.BufferType bufferType, int bufferId, int takeUid, Action<int, int> callSkillAction, Func<int, int, bool> checkSkillAction) { }

	// RVA: 0x18300AC Offset: 0x182C0AC VA: 0x18300AC
	public void SetTakeUid(int takeUid) { }
}
