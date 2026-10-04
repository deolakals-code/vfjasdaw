// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightPlayerManager : BlackKnightCharacterManagerBase // TypeDefIndex: 4165
{
	// Fields
	private PlayerAnimation playerAnimation; // 0xB0
	private BlackKnightPlayerSkillBase currentSkill; // 0xB8
	private TakeController takeController; // 0xC0
	private Dictionary<int, BlackKnightPlayerManager.SkillActionData> skillPlayTakeList; // 0xC8
	private BlackKnightPlayerManager.SkillActionData currentSkillData; // 0xD0
	private List<BlackKnightPlayerManager.SkillActionData> invokePlaceSkillList; // 0xD8
	private BlackKnightHitCheckManager hitManager; // 0xE0
	private BlackKnightMobObjectManager mobObjManager; // 0xE8
	private CharacterBoneManager boneManager; // 0xF0
	private List<BlackKnightPlayerManager.BulletData> bulletList; // 0xF8
	protected CountUpIdManager localIdManager; // 0x100
	private BlackKnightPlayerStatus playerStatus; // 0x108
	private BlackKnightPlayerManager.StateFlag stateFlag; // 0x110
	private BlackKnightPlayerManager.StateFlag lastActType; // 0x114
	private bool isDashable; // 0x118
	private float dashEndTimer; // 0x11C
	private readonly float dashEndTime; // 0x120
	private readonly float dashableTime; // 0x124
	private readonly float nextDashTime; // 0x128
	private float baseDashSpeed; // 0x12C
	private float dashMaxSpeed; // 0x130
	private bool isEquipAirRunner; // 0x134
	private bool isEquipSkyRun; // 0x135
	private bool isEquipContactImpact; // 0x136
	private bool isInvokeContactImpact; // 0x137
	private readonly Dictionary<BlackKnightPlayerManager.MoveActionType, float> moveSpeedList; // 0x138
	private float moveSpeed; // 0x140
	private float knockBackTimer; // 0x144
	private readonly float deadMoveTime; // 0x148
	private Shader[] shaderList; // 0x150
	private BlackKnightMobManagerBase lastAttackMob; // 0x158
	private float dTime; // 0x160
	private readonly int inputBias; // 0x164
	[CompilerGenerated]
	private int <SubdueCount>k__BackingField; // 0x168
	[CompilerGenerated]
	private int <HitCount>k__BackingField; // 0x16C
	[CompilerGenerated]
	private int <DamageCount>k__BackingField; // 0x170

	// Properties
	public override BlackKnightCharacterManagerBase.CharacterType CharaType { get; }
	public BlackKnightPlayerStatus PlayerStatus { get; }
	public bool IsInputLock { get; }
	public override float ContactSize { get; }
	public TakeController TakeController { get; }
	public int SubdueCount { get; set; }
	public int HitCount { get; set; }
	public int DamageCount { get; set; }
	public BlackKnightPlayerManager.StateFlag LastActType { get; }

	// Methods

	// RVA: 0x2499370 Offset: 0x2495370 VA: 0x2499370 Slot: 5
	public override BlackKnightCharacterManagerBase.CharacterType get_CharaType() { }

	// RVA: 0x2499378 Offset: 0x2495378 VA: 0x2499378
	public BlackKnightPlayerStatus get_PlayerStatus() { }

	// RVA: 0x2499380 Offset: 0x2495380 VA: 0x2499380
	public bool get_IsInputLock() { }

	// RVA: 0x24993F0 Offset: 0x24953F0 VA: 0x24993F0 Slot: 6
	public override float get_ContactSize() { }

	// RVA: 0x2499414 Offset: 0x2495414 VA: 0x2499414
	public TakeController get_TakeController() { }

	[CompilerGenerated]
	// RVA: 0x249941C Offset: 0x249541C VA: 0x249941C
	public int get_SubdueCount() { }

	[CompilerGenerated]
	// RVA: 0x2499424 Offset: 0x2495424 VA: 0x2499424
	private void set_SubdueCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x249942C Offset: 0x249542C VA: 0x249942C
	public int get_HitCount() { }

	[CompilerGenerated]
	// RVA: 0x2499434 Offset: 0x2495434 VA: 0x2499434
	private void set_HitCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x249943C Offset: 0x249543C VA: 0x249943C
	public int get_DamageCount() { }

	[CompilerGenerated]
	// RVA: 0x2499444 Offset: 0x2495444 VA: 0x2499444
	private void set_DamageCount(int value) { }

	// RVA: 0x249944C Offset: 0x249544C VA: 0x249944C
	public BlackKnightPlayerManager.StateFlag get_LastActType() { }

	// RVA: 0x2499454 Offset: 0x2495454 VA: 0x2499454 Slot: 8
	public override void Initialize(GameObject obj, GuideRail guide, float posData, bool isRight, float height) { }

	// RVA: 0x249821C Offset: 0x249421C VA: 0x249821C
	public void SetManager(BlackKnightHitCheckManager manager, BlackKnightMobObjectManager mobManager) { }

	// RVA: 0x2499FF4 Offset: 0x2495FF4 VA: 0x2499FF4 Slot: 9
	public override void Update() { }

	// RVA: 0x249A6D8 Offset: 0x24966D8 VA: 0x249A6D8
	private void InputMove() { }

	// RVA: 0x249B170 Offset: 0x2497170 VA: 0x249B170
	private float CalcDashMoveSpeed() { }

	// RVA: 0x249B504 Offset: 0x2497504 VA: 0x249B504
	private bool CheckValidInputMove(Vector2 stick) { }

	// RVA: 0x249AC64 Offset: 0x2496C64 VA: 0x249AC64
	private void CheckAnimation() { }

	// RVA: 0x249B6BC Offset: 0x24976BC VA: 0x249B6BC
	public void OnPlayerJump(bool isImpactJump) { }

	// RVA: 0x249B0C4 Offset: 0x24970C4 VA: 0x249B0C4
	public void OnPlayerDashEnd() { }

	// RVA: 0x249B99C Offset: 0x249799C VA: 0x249B99C
	public void OnPlayerDashForceEnd() { }

	// RVA: 0x249B9B8 Offset: 0x24979B8 VA: 0x249B9B8
	public void OnPlayerDashEndStart() { }

	// RVA: 0x249B9E4 Offset: 0x24979E4 VA: 0x249B9E4
	public void OnPlayerDash() { }

	// RVA: 0x249C2A8 Offset: 0x24982A8 VA: 0x249C2A8
	public void OnPlayerAttack() { }

	// RVA: 0x249B584 Offset: 0x2497584 VA: 0x249B584
	public bool CheckInAngle(float angle, Vector2 from, Vector2 to) { }

	// RVA: 0x249C5F4 Offset: 0x24985F4 VA: 0x249C5F4
	public void OnPlayerMagic() { }

	// RVA: 0x249C65C Offset: 0x249865C VA: 0x249C65C Slot: 20
	public override void OnDamaged(SkillDamageData damage) { }

	// RVA: 0x249C8E4 Offset: 0x24988E4 VA: 0x249C8E4
	private void ActionStop() { }

	// RVA: 0x249CAF0 Offset: 0x2498AF0 VA: 0x249CAF0 Slot: 21
	public override void OnDead() { }

	// RVA: 0x249CB80 Offset: 0x2498B80 VA: 0x249CB80 Slot: 19
	protected override void OnActionCancel() { }

	// RVA: 0x249B98C Offset: 0x249798C VA: 0x249B98C
	public void MoveStop() { }

	// RVA: 0x249CD50 Offset: 0x2498D50 VA: 0x249CD50
	public void SetMoveSpeed(float move) { }

	// RVA: 0x249B1C0 Offset: 0x24971C0 VA: 0x249B1C0
	public bool CheckLookRailVec() { }

	// RVA: 0x2495C38 Offset: 0x2491C38 VA: 0x2495C38
	public bool CheckIsInvinsible() { }

	// RVA: 0x2496148 Offset: 0x2492148 VA: 0x2496148
	public bool InvokeContactImpactSkill() { }

	// RVA: 0x249BFBC Offset: 0x2497FBC VA: 0x249BFBC
	public bool UseSkill(BlackKnightSkillId id) { }

	// RVA: 0x249D02C Offset: 0x249902C VA: 0x249D02C
	public void RemovePlaceSkill(BlackKnightSkillId id) { }

	// RVA: 0x249CDB0 Offset: 0x2498DB0 VA: 0x249CDB0
	private void PlaySkillTake(BlackKnightPlayerSkillBase skill, GameObject target) { }

	// RVA: 0x249D1C4 Offset: 0x24991C4 VA: 0x249D1C4
	private void PlayNextSkillTake(BlackKnightPlayerManager.SkillActionData skillData, SkillLinkedTake nextTake, int parentId, bool isMainData) { }

	// RVA: 0x249B42C Offset: 0x249742C VA: 0x249B42C
	private void RemoveBulletData(BlackKnightPlayerManager.BulletData data) { }

	// RVA: 0x249CD60 Offset: 0x2498D60 VA: 0x249CD60
	public bool UseMp(int useMp) { }

	// RVA: 0x249D1B8 Offset: 0x24991B8 VA: 0x249D1B8
	protected int conversionMotionSpeed(int speed) { }

	// RVA: 0x249D4A0 Offset: 0x24994A0 VA: 0x249D4A0 Slot: 12
	protected override void OnPlayAnimation(int id, WrapMode mode, float speed) { }

	// RVA: 0x249D4C0 Offset: 0x24994C0 VA: 0x249D4C0 Slot: 13
	protected override void OnPlayAnimNatural() { }

	// RVA: 0x249D4E4 Offset: 0x24994E4 VA: 0x249D4E4 Slot: 14
	protected override void OnPlayAnimRun() { }

	// RVA: 0x249D508 Offset: 0x2499508 VA: 0x249D508 Slot: 15
	protected override void OnPlayAnimBattleWait() { }

	// RVA: 0x249D52C Offset: 0x249952C VA: 0x249D52C Slot: 16
	protected override void OnPlayAnimBattleRun() { }

	// RVA: 0x249D550 Offset: 0x2499550 VA: 0x249D550 Slot: 17
	protected override void OnPlayAnimDead() { }

	// RVA: 0x249D574 Offset: 0x2499574 VA: 0x249D574 Slot: 18
	protected override void OnPlayAnimNonCrossFade(int id, WrapMode mode, float speed) { }

	// RVA: 0x249D594 Offset: 0x2499594 VA: 0x249D594
	public void ForcePlayWaitAnimation() { }

	// RVA: 0x249D5BC Offset: 0x24995BC VA: 0x249D5BC
	public Transform GetBone(int id) { }

	// RVA: 0x249D5D8 Offset: 0x24995D8 VA: 0x249D5D8
	protected void onTakeEvent(int uid, TakeEventType eventType, int param) { }

	// RVA: 0x249DBE0 Offset: 0x2499BE0 VA: 0x249DBE0
	private void TakeEnd(BlackKnightPlayerManager.SkillActionData skillData) { }

	// RVA: 0x249D154 Offset: 0x2499154 VA: 0x249D154
	private void StopPlaceSkillAction(BlackKnightPlayerManager.SkillActionData skillData) { }

	// RVA: 0x249E188 Offset: 0x249A188 VA: 0x249E188
	private void StopSkillAction(BlackKnightPlayerManager.SkillActionData skillData) { }

	// RVA: 0x249E480 Offset: 0x249A480 VA: 0x249E480
	private void playEndTake(BlackKnightPlayerManager.SkillActionData skillData) { }

	// RVA: 0x2494FE8 Offset: 0x2490FE8 VA: 0x2494FE8
	public bool CheckStateFlag(BlackKnightPlayerManager.StateFlag flag) { }

	// RVA: 0x2499FE4 Offset: 0x2495FE4 VA: 0x2499FE4
	public void ValidFlag(BlackKnightPlayerManager.StateFlag flag) { }

	// RVA: 0x249B0B4 Offset: 0x24970B4 VA: 0x249B0B4
	public void InvalidFlag(BlackKnightPlayerManager.StateFlag flag) { }

	// RVA: 0x249E67C Offset: 0x249A67C VA: 0x249E67C Slot: 25
	public override void OnActionHit(BlackKnightSkillActionBase action) { }

	// RVA: 0x249E904 Offset: 0x249A904 VA: 0x249E904
	public BlackKnightMobManagerBase GetLastAttackMob() { }

	// RVA: 0x2495C64 Offset: 0x2491C64 VA: 0x2495C64
	public void AddDamage(BlackKnightPlayerSkillBase skill) { }

	// RVA: 0x249E914 Offset: 0x249A914 VA: 0x249E914
	protected BlackKnightPlayerManager.SkillActionData playHitTake(BlackKnightPlayerManager.SkillActionData skillData, BlackKnightSkillActionBase.DamageData damageData) { }

	// RVA: 0x249DF80 Offset: 0x2499F80 VA: 0x249DF80
	private void playEventTake(BlackKnightPlayerManager.SkillActionData skillData) { }

	// RVA: 0x249EAC8 Offset: 0x249AAC8 VA: 0x249EAC8 Slot: 26
	protected override void OnDicpose() { }

	// RVA: 0x2497F50 Offset: 0x2493F50 VA: 0x2497F50
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x249EACC Offset: 0x249AACC VA: 0x249EACC
	private void <CheckAnimation>b__65_0(int uid, TakeEventType type, int param) { }

	[CompilerGenerated]
	// RVA: 0x249EB00 Offset: 0x249AB00 VA: 0x249EB00
	private void <OnPlayerJump>b__66_0(int uid, TakeEventType type, int param) { }

	[CompilerGenerated]
	// RVA: 0x249EB34 Offset: 0x249AB34 VA: 0x249EB34
	private void <OnPlayerDash>b__70_1() { }

	[CompilerGenerated]
	// RVA: 0x249EC0C Offset: 0x249AC0C VA: 0x249EC0C
	private void <OnPlayerDash>b__70_0(int uid, TakeEventType type, int param) { }
}
