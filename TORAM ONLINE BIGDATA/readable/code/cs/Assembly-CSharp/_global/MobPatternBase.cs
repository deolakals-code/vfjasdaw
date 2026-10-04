// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class MobPatternBase // TypeDefIndex: 737
{
	// Fields
	protected readonly MobActionPattern pattern; // 0x10
	protected readonly EnemyMobActionManagerBase mobActionManager; // 0x18
	protected readonly GameObject actor; // 0x20
	protected GameObject target; // 0x28
	protected Vector3 targetPos; // 0x30
	protected float chargeTime; // 0x3C
	protected float startSoundTime; // 0x40
	protected float attackTime; // 0x44
	protected List<long> archetypeList; // 0x48
	private bool isFirstAttack; // 0x50
	[CompilerGenerated]
	private MobPatternBase.FirstHitState <FirstHit>k__BackingField; // 0x54
	[CompilerGenerated]
	private float <SpecialDamegeRate>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <AbnormalPercent>k__BackingField; // 0x5C
	[CompilerGenerated]
	private int <SupportValue>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <IsAttackable>k__BackingField; // 0x64
	[CompilerGenerated]
	private bool <IsAttackHit>k__BackingField; // 0x65
	[CompilerGenerated]
	private bool <IsDamaged>k__BackingField; // 0x66
	[CompilerGenerated]
	private float <PlaySpeed>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x6C
	[CompilerGenerated]
	private bool <IsChargeAttack>k__BackingField; // 0x6D

	// Properties
	public MobActionPattern Pattern { get; }
	public GameObject Target { get; }
	public Vector3 TargetPos { get; }
	public abstract bool VisibleAttackArea { get; }
	public virtual KnockBackResistType KnockBackResist { get; }
	public float ChargeTime { get; }
	public List<long> ArchetypeList { get; }
	protected MobPatternBase.FirstHitState FirstHit { get; set; }
	public virtual bool IsTargetDirection { get; }
	public virtual bool IsTarget { get; }
	public float SpecialDamegeRate { get; set; }
	public int AbnormalPercent { get; set; }
	public int SupportValue { get; set; }
	public bool IsAttackable { get; set; }
	public bool IsAttackHit { get; set; }
	public bool IsDamaged { get; set; }
	public virtual bool IsDead { get; }
	public virtual bool IsAttackTargetOtherMob { get; }
	public virtual bool IsHitMySelf { get; }
	public virtual bool IsIgnoreDefResist { get; }
	public virtual bool IsForceAddAbnormal { get; }
	public virtual bool IsForceAddAbnormalApplyToPlayer { get; }
	public virtual bool IsDisplayDamageLabel { get; }
	public float PlaySpeed { get; set; }
	public bool IsSkipMissed { get; }
	public bool IsValid { get; set; }
	public bool IsAttackingDamageInvalid { get; }
	public bool IsAttackingMissing { get; }
	public virtual bool IsChargeAttack { get; set; }

	// Methods

	// RVA: 0x1B98C04 Offset: 0x1B94C04 VA: 0x1B98C04
	public MobActionPattern get_Pattern() { }

	// RVA: 0x1B98C0C Offset: 0x1B94C0C VA: 0x1B98C0C
	public GameObject get_Target() { }

	// RVA: 0x1B98C14 Offset: 0x1B94C14 VA: 0x1B98C14
	public Vector3 get_TargetPos() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_VisibleAttackArea();

	// RVA: 0x1B98C20 Offset: 0x1B94C20 VA: 0x1B98C20 Slot: 5
	public virtual KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1B98C28 Offset: 0x1B94C28 VA: 0x1B98C28
	public float get_ChargeTime() { }

	// RVA: 0x1B98C30 Offset: 0x1B94C30 VA: 0x1B98C30
	public List<long> get_ArchetypeList() { }

	[CompilerGenerated]
	// RVA: 0x1B98C38 Offset: 0x1B94C38 VA: 0x1B98C38
	protected MobPatternBase.FirstHitState get_FirstHit() { }

	[CompilerGenerated]
	// RVA: 0x1B98C40 Offset: 0x1B94C40 VA: 0x1B98C40
	protected void set_FirstHit(MobPatternBase.FirstHitState value) { }

	// RVA: 0x1B98C48 Offset: 0x1B94C48 VA: 0x1B98C48 Slot: 6
	public virtual bool get_IsTargetDirection() { }

	// RVA: 0x1B98C68 Offset: 0x1B94C68 VA: 0x1B98C68 Slot: 7
	public virtual bool get_IsTarget() { }

	[CompilerGenerated]
	// RVA: 0x1B98C70 Offset: 0x1B94C70 VA: 0x1B98C70
	public float get_SpecialDamegeRate() { }

	[CompilerGenerated]
	// RVA: 0x1B98C78 Offset: 0x1B94C78 VA: 0x1B98C78
	protected void set_SpecialDamegeRate(float value) { }

	[CompilerGenerated]
	// RVA: 0x1B98C80 Offset: 0x1B94C80 VA: 0x1B98C80
	public int get_AbnormalPercent() { }

	[CompilerGenerated]
	// RVA: 0x1B98C88 Offset: 0x1B94C88 VA: 0x1B98C88
	protected void set_AbnormalPercent(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B98C90 Offset: 0x1B94C90 VA: 0x1B98C90
	public int get_SupportValue() { }

	[CompilerGenerated]
	// RVA: 0x1B98C98 Offset: 0x1B94C98 VA: 0x1B98C98
	protected void set_SupportValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B98CA0 Offset: 0x1B94CA0 VA: 0x1B98CA0
	public bool get_IsAttackable() { }

	[CompilerGenerated]
	// RVA: 0x1B98CA8 Offset: 0x1B94CA8 VA: 0x1B98CA8
	protected void set_IsAttackable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B98CB4 Offset: 0x1B94CB4 VA: 0x1B98CB4
	public bool get_IsAttackHit() { }

	[CompilerGenerated]
	// RVA: 0x1B98CBC Offset: 0x1B94CBC VA: 0x1B98CBC
	protected void set_IsAttackHit(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B98CC8 Offset: 0x1B94CC8 VA: 0x1B98CC8
	public bool get_IsDamaged() { }

	[CompilerGenerated]
	// RVA: 0x1B98CD0 Offset: 0x1B94CD0 VA: 0x1B98CD0
	protected void set_IsDamaged(bool value) { }

	// RVA: 0x1B98CDC Offset: 0x1B94CDC VA: 0x1B98CDC Slot: 8
	public virtual bool get_IsDead() { }

	// RVA: 0x1B98CE4 Offset: 0x1B94CE4 VA: 0x1B98CE4 Slot: 9
	public virtual bool get_IsAttackTargetOtherMob() { }

	// RVA: 0x1B98CEC Offset: 0x1B94CEC VA: 0x1B98CEC Slot: 10
	public virtual bool get_IsHitMySelf() { }

	// RVA: 0x1B98CF4 Offset: 0x1B94CF4 VA: 0x1B98CF4 Slot: 11
	public virtual bool get_IsIgnoreDefResist() { }

	// RVA: 0x1B98CFC Offset: 0x1B94CFC VA: 0x1B98CFC Slot: 12
	public virtual bool get_IsForceAddAbnormal() { }

	// RVA: 0x1B98D04 Offset: 0x1B94D04 VA: 0x1B98D04 Slot: 13
	public virtual bool get_IsForceAddAbnormalApplyToPlayer() { }

	// RVA: 0x1B98D0C Offset: 0x1B94D0C VA: 0x1B98D0C Slot: 14
	public virtual bool get_IsDisplayDamageLabel() { }

	[CompilerGenerated]
	// RVA: 0x1B98D14 Offset: 0x1B94D14 VA: 0x1B98D14
	public float get_PlaySpeed() { }

	[CompilerGenerated]
	// RVA: 0x1B98D1C Offset: 0x1B94D1C VA: 0x1B98D1C
	private void set_PlaySpeed(float value) { }

	// RVA: 0x1B98D24 Offset: 0x1B94D24 VA: 0x1B98D24
	public bool get_IsSkipMissed() { }

	[CompilerGenerated]
	// RVA: 0x1B98D44 Offset: 0x1B94D44 VA: 0x1B98D44
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x1B98D4C Offset: 0x1B94D4C VA: 0x1B98D4C
	protected void set_IsValid(bool value) { }

	// RVA: 0x1B98D58 Offset: 0x1B94D58 VA: 0x1B98D58
	public bool get_IsAttackingDamageInvalid() { }

	// RVA: 0x1B98D8C Offset: 0x1B94D8C VA: 0x1B98D8C
	public bool get_IsAttackingMissing() { }

	[CompilerGenerated]
	// RVA: 0x1B98DC0 Offset: 0x1B94DC0 VA: 0x1B98DC0 Slot: 15
	public virtual bool get_IsChargeAttack() { }

	[CompilerGenerated]
	// RVA: 0x1B98DC8 Offset: 0x1B94DC8 VA: 0x1B98DC8 Slot: 16
	protected virtual void set_IsChargeAttack(bool value) { }

	// RVA: 0x1B98DD4 Offset: 0x1B94DD4 VA: 0x1B98DD4
	protected void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase mobAct, GameObject target) { }

	// RVA: 0x1B98DDC Offset: 0x1B94DDC VA: 0x1B98DDC
	protected void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase mobAct, GameObject target, float playSpeed) { }

	// RVA: 0x1B98F44 Offset: 0x1B94F44 VA: 0x1B98F44 Slot: 17
	public virtual void Initialize(bool other) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void ActionCancel();

	// RVA: 0x1B98F48 Offset: 0x1B94F48 VA: 0x1B98F48
	public PatternCommand Update() { }

	// RVA: 0x1B9918C Offset: 0x1B9518C VA: 0x1B9918C Slot: 19
	protected virtual void OnChargeUpdate(bool end) { }

	// RVA: 0x1B99190 Offset: 0x1B95190 VA: 0x1B99190 Slot: 20
	protected virtual bool OnPreUpdate() { }

	// RVA: 0x1B99198 Offset: 0x1B95198 VA: 0x1B99198 Slot: 21
	protected virtual void OnAttackStart() { }

	// RVA: 0x1B9919C Offset: 0x1B9519C VA: 0x1B9919C Slot: 22
	protected virtual void OnAttackWait() { }

	// RVA: 0x1B991A0 Offset: 0x1B951A0 VA: 0x1B991A0 Slot: 23
	protected virtual void OnAttack() { }

	// RVA: -1 Offset: -1 Slot: 24
	protected abstract PatternCommand OnPostUpdate();

	// RVA: 0x1B991A4 Offset: 0x1B951A4 VA: 0x1B991A4 Slot: 25
	public virtual void LateUpdate() { }

	// RVA: 0x1B991A8 Offset: 0x1B951A8 VA: 0x1B991A8 Slot: 26
	public virtual void OnEnd() { }

	// RVA: 0x1B991AC Offset: 0x1B951AC VA: 0x1B991AC Slot: 27
	public virtual void OnAttackDamage() { }

	// RVA: 0x1B991B8 Offset: 0x1B951B8 VA: 0x1B991B8 Slot: 28
	public virtual void OnDamage(bool isPlayerManagerd) { }

	// RVA: 0x1B991C4 Offset: 0x1B951C4 VA: 0x1B991C4 Slot: 29
	public virtual bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1B99218 Offset: 0x1B95218 VA: 0x1B99218 Slot: 30
	public virtual bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1B99220 Offset: 0x1B95220 VA: 0x1B99220 Slot: 31
	public virtual bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1B99228 Offset: 0x1B95228 VA: 0x1B99228 Slot: 32
	public virtual bool CheckRayArea(Vector3 position, Vector3 ray, float dist) { }

	// RVA: 0x1B90900 Offset: 0x1B8C900 VA: 0x1B90900
	public bool CheckAttackStartSkip() { }

	// RVA: 0x1B99230 Offset: 0x1B95230 VA: 0x1B99230 Slot: 33
	protected virtual bool CheckFirstHitMiss() { }

	// RVA: 0x1B994A4 Offset: 0x1B954A4 VA: 0x1B994A4
	protected long ConversionArchetype(byte type, int id) { }

	// RVA: 0x1B994B4 Offset: 0x1B954B4 VA: 0x1B994B4
	public bool CheckMainTarget(GameObject target) { }

	// RVA: 0x1B9955C Offset: 0x1B9555C VA: 0x1B9955C Slot: 34
	protected virtual MobActionPattern GetBulletPattern() { }

	// RVA: 0x1B995FC Offset: 0x1B955FC VA: 0x1B995FC Slot: 35
	public virtual float[] GetAttackRange() { }
}
