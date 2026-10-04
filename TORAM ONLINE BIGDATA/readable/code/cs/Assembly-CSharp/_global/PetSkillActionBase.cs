// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class PetSkillActionBase : PlayerAttackBase // TypeDefIndex: 3535
{
	// Fields
	private IOtherPlayerActionManager actarAction; // 0x120
	private Vector3 targetPos; // 0x128
	private int motionSpeed; // 0x134
	private float castTime; // 0x138
	private int loopCount; // 0x13C
	private int element; // 0x140
	[CompilerGenerated]
	private PetAttackPatternData.PatternData <Motiondata>k__BackingField; // 0x148

	// Properties
	public PetAttackPatternData.PatternData Motiondata { get; set; }
	protected abstract bool UseSkillEffect { get; }
	protected abstract int HitTakeId { get; }
	protected virtual int EffectTake { get; }
	private bool IsContinuousAttack { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2364038 Offset: 0x2360038 VA: 0x2364038
	public PetAttackPatternData.PatternData get_Motiondata() { }

	[CompilerGenerated]
	// RVA: 0x2364040 Offset: 0x2360040 VA: 0x2364040
	protected void set_Motiondata(PetAttackPatternData.PatternData value) { }

	// RVA: -1 Offset: -1 Slot: 91
	protected abstract bool get_UseSkillEffect();

	// RVA: -1 Offset: -1 Slot: 92
	protected abstract int get_HitTakeId();

	// RVA: 0x2364050 Offset: 0x2360050 VA: 0x2364050 Slot: 93
	protected virtual int get_EffectTake() { }

	// RVA: 0x2364058 Offset: 0x2360058 VA: 0x2364058
	private bool get_IsContinuousAttack() { }

	// RVA: 0x2364094 Offset: 0x2360094 VA: 0x2364094
	public void PetSkillInitialize(CharacterActionManagerBase action, byte lv, PetAttackPatternData.PatternData motion) { }

	// RVA: 0x236393C Offset: 0x235F93C VA: 0x236393C Slot: 94
	protected virtual void OnPetSkillInitialize(CharacterActionManagerBase action, byte lv, PetAttackPatternData.PatternData motion) { }

	// RVA: 0x2364494 Offset: 0x2360494 VA: 0x2364494 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23639DC Offset: 0x235F9DC VA: 0x23639DC Slot: 95
	public virtual void PetSkillInitilizeOther(PetAttackPatternData.PatternData motion) { }

	// RVA: 0x2363770 Offset: 0x235F770 VA: 0x2363770 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2364510 Offset: 0x2360510 VA: 0x2364510 Slot: 96
	public virtual TakeClip GetTakeClip(GameObject actor, GameObject target) { }

	// RVA: 0x23656F0 Offset: 0x23616F0 VA: 0x23656F0
	private TakeClip GetNormalTake() { }

	// RVA: 0x2365134 Offset: 0x2361134 VA: 0x2365134
	protected TakeClip GetContinuousTakeClip() { }

	// RVA: 0x236455C Offset: 0x236055C VA: 0x236455C
	protected TakeClip GetMoveTakeClip(GameObject actor, GameObject target) { }

	// RVA: 0x2365CE4 Offset: 0x2361CE4 VA: 0x2365CE4 Slot: 85
	protected override bool CheckHit(PlayerStatusBase status, int needHit, int mp, bool isFlash, out bool correct) { }

	// RVA: 0x2365F10 Offset: 0x2361F10 VA: 0x2365F10 Slot: 87
	protected override float CalcStable(SkillAttackType type, int stableSource, bool correctHit, PlayerStatusBase status) { }

	// RVA: 0x2366158 Offset: 0x2362158 VA: 0x2366158 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x2362500 Offset: 0x235E500 VA: 0x2362500
	protected void .ctor() { }
}
