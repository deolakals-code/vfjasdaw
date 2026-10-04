// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AutoMemberAIRetreat // TypeDefIndex: 407
{
	// Fields
	private AutoMemberAIRetreat.RetreatDirectionManager retreatDirection; // 0x10
	private AutoMemberAIRetreat.PreparationRetreat beforeRetreat; // 0x18
	private AutoMemberAIRetreat.AfterRetreat afterRetreat; // 0x20
	private MobRangeAttackCollection rangeData; // 0x28
	private MobRangeAttackCollection.RangeAttackData lastHitRangeData; // 0x30
	private MobRangeAttackCollection.RangeAttackData chackHitRandeData; // 0x38
	protected Transform transform; // 0x40
	protected Transform traceTargetTransform; // 0x48
	protected Vector3 lastRetreatDirection; // 0x50
	protected bool isRetreated; // 0x5C
	protected bool isRetreatToTraceTarget; // 0x5D
	protected bool isRetreatFromTarget; // 0x5E
	private int retreatFlag; // 0x60
	protected PlayerDataManager playerDataManager; // 0x68
	protected AutoMemberActionManager autoMemberActionManager; // 0x70

	// Properties
	public bool IsSurround { get; }
	public bool IsRange { get; }
	public bool IsLine { get; }
	public bool IsMoveAttack { get; }
	public bool IsBreathAttack { get; }
	public bool IsVerticalAttack { get; }
	public bool IsWallAttack { get; }
	public bool IsTranslationAttack { get; }
	public bool IsSectorAttack { get; }
	public bool IsBlackHole { get; }
	public bool IsExplosion { get; }
	public bool IsNone { get; }

	// Methods

	[IteratorStateMachine(typeof(AutoMemberAIRetreat.<GetParam>d__3))]
	// RVA: 0x2562368 Offset: 0x255E368 VA: 0x2562368 Slot: 4
	public virtual IEnumerable<string> GetParam() { }

	// RVA: 0x25623C0 Offset: 0x255E3C0 VA: 0x25623C0
	public void .ctor() { }

	// RVA: 0x25605C0 Offset: 0x255C5C0 VA: 0x25605C0
	public void .ctor(AutoMemberAIRetreat.RetreatDirectionManager direction, AutoMemberAIRetreat.PreparationRetreat before, AutoMemberAIRetreat.AfterRetreat after) { }

	// RVA: 0x2562434 Offset: 0x255E434 VA: 0x2562434
	public bool get_IsSurround() { }

	// RVA: 0x2562440 Offset: 0x255E440 VA: 0x2562440
	public bool get_IsRange() { }

	// RVA: 0x256244C Offset: 0x255E44C VA: 0x256244C
	public bool get_IsLine() { }

	// RVA: 0x2562458 Offset: 0x255E458 VA: 0x2562458
	public bool get_IsMoveAttack() { }

	// RVA: 0x2562464 Offset: 0x255E464 VA: 0x2562464
	public bool get_IsBreathAttack() { }

	// RVA: 0x2562470 Offset: 0x255E470 VA: 0x2562470
	public bool get_IsVerticalAttack() { }

	// RVA: 0x256247C Offset: 0x255E47C VA: 0x256247C
	public bool get_IsWallAttack() { }

	// RVA: 0x2562488 Offset: 0x255E488 VA: 0x2562488
	public bool get_IsTranslationAttack() { }

	// RVA: 0x2562494 Offset: 0x255E494 VA: 0x2562494
	public bool get_IsSectorAttack() { }

	// RVA: 0x25624A0 Offset: 0x255E4A0 VA: 0x25624A0
	public bool get_IsBlackHole() { }

	// RVA: 0x25624AC Offset: 0x255E4AC VA: 0x25624AC
	public bool get_IsExplosion() { }

	// RVA: 0x25624B8 Offset: 0x255E4B8 VA: 0x25624B8
	public bool get_IsNone() { }

	// RVA: 0x25624C8 Offset: 0x255E4C8 VA: 0x25624C8
	public void Initialize(Transform transform, Transform traceTransform) { }

	// RVA: 0x2562574 Offset: 0x255E574 VA: 0x2562574
	public void InitializeRangeList(MobRangeAttackCollection rangeList) { }

	// RVA: 0x256257C Offset: 0x255E57C VA: 0x256257C
	public void InitializeFlag(int retreatFlag) { }

	[Obsolete("MobAttackBase::CheckAIRetreatAttack に変更")]
	// RVA: 0x256267C Offset: 0x255E67C VA: 0x256267C
	private bool CheckRetreatAttack(MobAttackBase mobAttackBase) { }

	// RVA: 0x2562AB0 Offset: 0x255EAB0 VA: 0x2562AB0 Slot: 5
	public virtual AIActionType GetRetreat() { }

	// RVA: 0x2563544 Offset: 0x255F544 VA: 0x2563544
	public AIActionType CheckRetreat() { }

	// RVA: 0x2563554 Offset: 0x255F554 VA: 0x2563554 Slot: 6
	public virtual AIActionType CheckRetreat(Transform trans) { }

	// RVA: 0x25639A4 Offset: 0x255F9A4 VA: 0x25639A4 Slot: 7
	public virtual Vector3 GetRetreatDirection() { }

	// RVA: 0x25639D0 Offset: 0x255F9D0 VA: 0x25639D0 Slot: 8
	public virtual Vector3 GetIdleAction() { }

	// RVA: 0x25639EC Offset: 0x255F9EC VA: 0x25639EC
	public bool CheckAllAttackEnd() { }
}
