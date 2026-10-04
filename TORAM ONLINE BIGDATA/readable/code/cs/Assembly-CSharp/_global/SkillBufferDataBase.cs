// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class SkillBufferDataBase // TypeDefIndex: 3309
{
	// Fields
	[CompilerGenerated]
	private byte <Level>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsSelfAction>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <IsDamageCancel>k__BackingField; // 0x12
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x13
	[CompilerGenerated]
	private float <LeftTime>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <BufEffectTakeUid>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <BuffEffectActive>k__BackingField; // 0x1C

	// Properties
	public abstract SkillId SkillId { get; }
	public byte Level { get; set; }
	public bool IsSelfAction { get; set; }
	public virtual bool IsViewSelfIcon { get; }
	public virtual bool IsRange { get; }
	public bool IsDamageCancel { get; set; }
	public virtual bool IsAbnormalDamageCancel { get; }
	public bool IsEnd { get; set; }
	public float LeftTime { get; set; }
	public virtual int BufEffectTakeId { get; }
	public int BufEffectTakeUid { get; set; }
	public virtual SkillBufferFlag Flag { get; }
	public virtual bool IsPutUpWeapon { get; }
	public bool BuffEffectActive { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract SkillId get_SkillId();

	[CompilerGenerated]
	// RVA: 0x23453C8 Offset: 0x23413C8 VA: 0x23453C8
	public byte get_Level() { }

	[CompilerGenerated]
	// RVA: 0x23453D0 Offset: 0x23413D0 VA: 0x23453D0
	protected void set_Level(byte value) { }

	[CompilerGenerated]
	// RVA: 0x23453D8 Offset: 0x23413D8 VA: 0x23453D8
	public bool get_IsSelfAction() { }

	[CompilerGenerated]
	// RVA: 0x23453E0 Offset: 0x23413E0 VA: 0x23453E0
	private void set_IsSelfAction(bool value) { }

	// RVA: 0x23453EC Offset: 0x23413EC VA: 0x23453EC Slot: 5
	public virtual bool get_IsViewSelfIcon() { }

	// RVA: 0x23453F4 Offset: 0x23413F4 VA: 0x23453F4 Slot: 6
	public virtual bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x23453FC Offset: 0x23413FC VA: 0x23453FC
	public bool get_IsDamageCancel() { }

	[CompilerGenerated]
	// RVA: 0x2345404 Offset: 0x2341404 VA: 0x2345404
	protected void set_IsDamageCancel(bool value) { }

	// RVA: 0x2345410 Offset: 0x2341410 VA: 0x2345410 Slot: 7
	public virtual bool get_IsAbnormalDamageCancel() { }

	[CompilerGenerated]
	// RVA: 0x2345418 Offset: 0x2341418 VA: 0x2345418
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x2345420 Offset: 0x2341420 VA: 0x2345420
	private void set_IsEnd(bool value) { }

	[CompilerGenerated]
	// RVA: 0x234542C Offset: 0x234142C VA: 0x234542C
	public float get_LeftTime() { }

	[CompilerGenerated]
	// RVA: 0x2345434 Offset: 0x2341434 VA: 0x2345434
	protected void set_LeftTime(float value) { }

	// RVA: 0x234543C Offset: 0x234143C VA: 0x234543C Slot: 8
	public virtual int get_BufEffectTakeId() { }

	[CompilerGenerated]
	// RVA: 0x2345444 Offset: 0x2341444 VA: 0x2345444
	public int get_BufEffectTakeUid() { }

	[CompilerGenerated]
	// RVA: 0x234544C Offset: 0x234144C VA: 0x234544C
	private void set_BufEffectTakeUid(int value) { }

	// RVA: 0x2345454 Offset: 0x2341454 VA: 0x2345454 Slot: 9
	public virtual SkillBufferFlag get_Flag() { }

	// RVA: 0x234545C Offset: 0x234145C VA: 0x234545C Slot: 10
	public virtual bool get_IsPutUpWeapon() { }

	[CompilerGenerated]
	// RVA: 0x2345464 Offset: 0x2341464 VA: 0x2345464
	public bool get_BuffEffectActive() { }

	[CompilerGenerated]
	// RVA: 0x234546C Offset: 0x234146C VA: 0x234546C
	protected void set_BuffEffectActive(bool value) { }

	// RVA: 0x2340070 Offset: 0x233C070 VA: 0x2340070
	protected void .ctor(byte lv, bool self) { }

	// RVA: 0x233F194 Offset: 0x233B194 VA: 0x233F194
	public void End() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Updata();

	// RVA: 0x2345478 Offset: 0x2341478 VA: 0x2345478
	public int GetParam(SkillBufferId id) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetParam(int id);

	// RVA: 0x2345484 Offset: 0x2341484 VA: 0x2345484 Slot: 13
	public virtual void OnDamage(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2345488 Offset: 0x2341488 VA: 0x2345488
	public void OnBufEffectTakePlay(int uid) { }

	// RVA: 0x2345490 Offset: 0x2341490 VA: 0x2345490 Slot: 14
	public virtual Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x2345498 Offset: 0x2341498 VA: 0x2345498 Slot: 15
	public virtual void OnCall(int takeUid, int param) { }

	// RVA: 0x234549C Offset: 0x234149C VA: 0x234549C Slot: 16
	public virtual bool CheckTakeSkip(int takeUid, int param) { }

	// RVA: 0x23454A4 Offset: 0x23414A4 VA: 0x23454A4 Slot: 17
	public virtual void OnLeave() { }

	// RVA: 0x23454A8 Offset: 0x23414A8 VA: 0x23454A8 Slot: 18
	public virtual bool CheckUnableEquipChange() { }

	// RVA: 0x23454C4 Offset: 0x23414C4 VA: 0x23454C4 Slot: 19
	public virtual bool CheckChangeEquipRemove() { }

	// RVA: 0x23454E0 Offset: 0x23414E0 VA: 0x23454E0 Slot: 20
	public virtual void SetActive(bool active) { }
}
