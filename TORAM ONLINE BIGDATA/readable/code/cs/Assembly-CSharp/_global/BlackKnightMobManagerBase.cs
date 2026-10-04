// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class BlackKnightMobManagerBase : BlackKnightCharacterManagerBase // TypeDefIndex: 4199
{
	// Fields
	[CompilerGenerated]
	private bool <IsStopAction>k__BackingField; // 0xAE
	[CompilerGenerated]
	private bool <IsEndDestroy>k__BackingField; // 0xAF
	[CompilerGenerated]
	private readonly int <Hp>k__BackingField; // 0xB0
	[CompilerGenerated]
	private bool <IsInvalidContact>k__BackingField; // 0xB4
	private readonly BlackKnightPlayerManager _player; // 0xB8
	private readonly MobStatusMaster _statusMaster; // 0xC0
	private readonly int _localId; // 0xC8
	protected AIBlackKnightCentralManager ai; // 0xD0
	protected BlackKnightMobSkillManager skillManager; // 0xD8
	protected MobAnimation mobAnimation; // 0xE0
	private Vector3[] baseDamageAreaPointList; // 0xE8
	private Vector3[] damageAreaPointList; // 0xF0
	private int[] damageAreaPointIndex; // 0xF8
	protected float actionDelay; // 0x100
	private float knockBackMoveSpeed; // 0x104
	protected bool isOneHitKill; // 0x108
	protected bool isOutOfRailsSet; // 0x109
	protected bool IsMove3D; // 0x10A
	private float suctionMoveTimer; // 0x10C
	protected readonly int maxUpMoveCountByDamage; // 0x110
	protected int upMoveCountByDamage; // 0x114
	private readonly float[] weightBias; // 0x118
	private List<BlackKnightHitAreaData> hitAreaList; // 0x120
	private GameObject barrierEffectObject; // 0x128
	private Motion barrierEffectMotion; // 0x130

	// Properties
	protected abstract bool IsBoss { get; }
	protected BlackKnightPlayerManager Player { get; }
	protected MobStatusMaster StatusMaster { get; }
	public int LocalId { get; }
	public BlackKnightMobSkillManager.KnockUpResisterState KnockUpResister { get; }
	public BlackKnightSkillActionBase CurrentSkill { get; }
	public Vector3[] DamageAreaPointList { get; }
	public int[] DamageAreaPointIndex { get; }
	public bool IsStopAction { get; set; }
	public bool IsEndDestroy { get; set; }
	public virtual int Hp { get; }
	public string Name { get; }
	public override Vector3 RootPos { get; }
	public bool IsInvalidContact { get; set; }
	public bool SetOutOfRailPos { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract bool get_IsBoss();

	// RVA: 0x24A7A38 Offset: 0x24A3A38 VA: 0x24A7A38
	protected BlackKnightPlayerManager get_Player() { }

	// RVA: 0x24A7A40 Offset: 0x24A3A40 VA: 0x24A7A40
	protected MobStatusMaster get_StatusMaster() { }

	// RVA: 0x24A7A48 Offset: 0x24A3A48 VA: 0x24A7A48
	public int get_LocalId() { }

	// RVA: 0x24A7A50 Offset: 0x24A3A50 VA: 0x24A7A50
	public BlackKnightMobSkillManager.KnockUpResisterState get_KnockUpResister() { }

	// RVA: 0x24A7AC0 Offset: 0x24A3AC0 VA: 0x24A7AC0
	public BlackKnightSkillActionBase get_CurrentSkill() { }

	// RVA: 0x24A7AE0 Offset: 0x24A3AE0 VA: 0x24A7AE0
	public Vector3[] get_DamageAreaPointList() { }

	// RVA: 0x24A7AE8 Offset: 0x24A3AE8 VA: 0x24A7AE8
	public int[] get_DamageAreaPointIndex() { }

	[CompilerGenerated]
	// RVA: 0x24A7AF0 Offset: 0x24A3AF0 VA: 0x24A7AF0
	public bool get_IsStopAction() { }

	[CompilerGenerated]
	// RVA: 0x24A7AF8 Offset: 0x24A3AF8 VA: 0x24A7AF8
	protected void set_IsStopAction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24A7B04 Offset: 0x24A3B04 VA: 0x24A7B04
	public bool get_IsEndDestroy() { }

	[CompilerGenerated]
	// RVA: 0x24A7B0C Offset: 0x24A3B0C VA: 0x24A7B0C
	protected void set_IsEndDestroy(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24A7B18 Offset: 0x24A3B18 VA: 0x24A7B18 Slot: 28
	public virtual int get_Hp() { }

	// RVA: 0x24A7B20 Offset: 0x24A3B20 VA: 0x24A7B20
	public string get_Name() { }

	// RVA: 0x24A7B3C Offset: 0x24A3B3C VA: 0x24A7B3C Slot: 7
	public override Vector3 get_RootPos() { }

	[CompilerGenerated]
	// RVA: 0x24A7BE8 Offset: 0x24A3BE8 VA: 0x24A7BE8
	public bool get_IsInvalidContact() { }

	[CompilerGenerated]
	// RVA: 0x24A7BF0 Offset: 0x24A3BF0 VA: 0x24A7BF0
	protected void set_IsInvalidContact(bool value) { }

	// RVA: 0x24A7BFC Offset: 0x24A3BFC VA: 0x24A7BFC
	public bool get_SetOutOfRailPos() { }

	// RVA: 0x24A2FFC Offset: 0x249EFFC VA: 0x24A2FFC
	public void .ctor(BlackKnightPlayerManager player, MobStatusMaster master, int lcoalId) { }

	// RVA: 0x24A3BB0 Offset: 0x249FBB0 VA: 0x24A3BB0 Slot: 8
	public override void Initialize(GameObject obj, GuideRail guide, float posData, bool isRight, float height) { }

	[IteratorStateMachine(typeof(BlackKnightMobManagerBase.<LoadEffectModel>d__61))]
	// RVA: 0x24A7C04 Offset: 0x24A3C04 VA: 0x24A7C04
	public IEnumerator LoadEffectModel() { }

	// RVA: 0x24A3F10 Offset: 0x249FF10 VA: 0x24A3F10 Slot: 26
	protected override void OnDicpose() { }

	// RVA: 0x24A32F8 Offset: 0x249F2F8 VA: 0x24A32F8 Slot: 9
	public override void Update() { }

	// RVA: 0x24A69BC Offset: 0x24A29BC VA: 0x24A69BC Slot: 10
	public override void MoveUpdate() { }

	// RVA: 0x24A7D5C Offset: 0x24A3D5C VA: 0x24A7D5C
	public void InitializeAI(AIIndicationMaterial mat) { }

	// RVA: 0x24A7E84 Offset: 0x24A3E84 VA: 0x24A7E84 Slot: 29
	public virtual void HitMobToPlayer(BlackKnightHitAreaData hitArea) { }

	// RVA: 0x24A8560 Offset: 0x24A4560 VA: 0x24A8560 Slot: 30
	public virtual BlackKnightHitAreaData[] GetSkillHitAreaData() { }

	// RVA: 0x24A420C Offset: 0x24A020C VA: 0x24A420C Slot: 25
	public override void OnActionHit(BlackKnightSkillActionBase action) { }

	// RVA: 0x24A6150 Offset: 0x24A2150 VA: 0x24A6150
	public void OnInstallationActionHit(BlackKnightMobPatternBase pattern) { }

	// RVA: 0x24A85B0 Offset: 0x24A45B0 VA: 0x24A85B0 Slot: 31
	public virtual void EnterBossRoomStart() { }

	// RVA: 0x24A85B4 Offset: 0x24A45B4 VA: 0x24A85B4 Slot: 32
	public virtual void EnterBossRoom() { }

	// RVA: 0x24A44E8 Offset: 0x24A04E8 VA: 0x24A44E8 Slot: 33
	public virtual void StopAction() { }

	// RVA: 0x24A85B8 Offset: 0x24A45B8 VA: 0x24A85B8
	public void UpdateMoveDist(float moveSpeed) { }

	// RVA: 0x24A4544 Offset: 0x24A0544 VA: 0x24A4544 Slot: 19
	protected override void OnActionCancel() { }

	// RVA: 0x24A85C0 Offset: 0x24A45C0 VA: 0x24A85C0 Slot: 22
	protected override void UpdateAbnormal() { }

	// RVA: 0x24A864C Offset: 0x24A464C VA: 0x24A864C Slot: 24
	protected override bool AddAbnormal(AbnormalType type, float effectTime, float resistTime) { }

	// RVA: 0x24A8F54 Offset: 0x24A4F54 VA: 0x24A8F54 Slot: 23
	protected override void OnEndAbnormal(AbnormalType type) { }

	// RVA: 0x24A9044 Offset: 0x24A5044 VA: 0x24A9044
	public int GetDropGold() { }

	// RVA: 0x24A9060 Offset: 0x24A5060 VA: 0x24A9060
	public MobActionPattern GetActionPattern(int patternId) { }

	// RVA: 0x24A907C Offset: 0x24A507C VA: 0x24A907C Slot: 12
	protected override void OnPlayAnimation(int id, WrapMode mode, float speed) { }

	// RVA: 0x24A909C Offset: 0x24A509C VA: 0x24A909C Slot: 13
	protected override void OnPlayAnimNatural() { }

	// RVA: 0x24A90C0 Offset: 0x24A50C0 VA: 0x24A90C0 Slot: 14
	protected override void OnPlayAnimRun() { }

	// RVA: 0x24A90E4 Offset: 0x24A50E4 VA: 0x24A90E4 Slot: 15
	protected override void OnPlayAnimBattleWait() { }

	// RVA: 0x24A9108 Offset: 0x24A5108 VA: 0x24A9108 Slot: 18
	protected override void OnPlayAnimNonCrossFade(int id, WrapMode mode, float speed) { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void OnActionEnd(BlackKnightMobSkillBase skillBase);

	// RVA: 0x24A9128 Offset: 0x24A5128 VA: 0x24A9128
	private void OnAIEvent(MobBlackKnightAIActionType aiType, float[] paramVals) { }

	// RVA: -1 Offset: -1 Slot: 35
	protected abstract void OnEventSkill(int commandId);

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract void OnEventTargetMove();

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract void OnEventPointMove(float movePoint, int moveMotionId, int flag);

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract void OnEventRotate(int rotateState);

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract void OnEvent3DPointMove(float movePoint);

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract void OnEventPlayerMove(float dist);
}
