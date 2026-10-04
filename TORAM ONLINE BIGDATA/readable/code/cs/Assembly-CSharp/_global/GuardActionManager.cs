// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuardActionManager : MonoBehaviour // TypeDefIndex: 333
{
	// Fields
	public const float GuardStartIdleTime = 0.2;
	public const float JustGuardTime = 1;
	public const float GuardSendAngle = 30;
	public const float GuardPowerDownTime = 1;
	public const int MaxRecoveryGuardPower = 10000;
	public const float GuardCrashInvincibility = 2;
	public const float AutoGuardDelayTime = 1;
	private IMainPlayer player; // 0x20
	private PlayerActionManagerBase actionManager; // 0x28
	private BattleManagerBase battleManager; // 0x30
	private CharacterMove charaMove; // 0x38
	private TakeController takeController; // 0x40
	private int guardTakeUid; // 0x48
	private float justGuardTimer; // 0x4C
	private float guardPowerTimer; // 0x50
	private float autoGuardTimer; // 0x54
	private float guardPrevAngle; // 0x58
	private IEnumerator guardAction; // 0x60
	private IEnumerator guardPowerDownAction; // 0x68
	private bool guardWait; // 0x70
	private float _guardPower; // 0x74
	private GuardActionManager.TempData tempData; // 0x78
	[CompilerGenerated]
	private bool <IsGuard>k__BackingField; // 0x80
	[CompilerGenerated]
	private short <GuardSkillId>k__BackingField; // 0x82
	[CompilerGenerated]
	private float <GuardDelay>k__BackingField; // 0x84
	[CompilerGenerated]
	private int <GuardPowerDamage>k__BackingField; // 0x88
	[CompilerGenerated]
	private bool <IsPlayer>k__BackingField; // 0x8C

	// Properties
	public bool IsGuard { get; set; }
	public bool IsSkillGuard { get; }
	public short GuardSkillId { get; set; }
	public bool IsGuardCrash { get; }
	public int GuardPower { get; }
	public float GuardPowerRate { get; }
	public float GuardDelay { get; set; }
	public GuardType GuardType { get; }
	public int GuardPowerDamage { get; set; }
	public int MaxGuardPower { get; }
	public int GuardSpeed { get; }
	public float MaxGuardDelay { get; }
	private SkillActionManagerBase SkillActionManager { get; }
	private bool IsPlayer { get; set; }
	public bool IsAbnormal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x248271C Offset: 0x247E71C VA: 0x248271C
	public bool get_IsGuard() { }

	[CompilerGenerated]
	// RVA: 0x2482724 Offset: 0x247E724 VA: 0x2482724
	private void set_IsGuard(bool value) { }

	// RVA: 0x2482730 Offset: 0x247E730 VA: 0x2482730
	public bool get_IsSkillGuard() { }

	[CompilerGenerated]
	// RVA: 0x2482740 Offset: 0x247E740 VA: 0x2482740
	public short get_GuardSkillId() { }

	[CompilerGenerated]
	// RVA: 0x2482748 Offset: 0x247E748 VA: 0x2482748
	private void set_GuardSkillId(short value) { }

	// RVA: 0x2482750 Offset: 0x247E750 VA: 0x2482750
	public bool get_IsGuardCrash() { }

	// RVA: 0x2482760 Offset: 0x247E760 VA: 0x2482760
	public int get_GuardPower() { }

	// RVA: 0x2482780 Offset: 0x247E780 VA: 0x2482780
	public float get_GuardPowerRate() { }

	[CompilerGenerated]
	// RVA: 0x24828EC Offset: 0x247E8EC VA: 0x24828EC
	public float get_GuardDelay() { }

	[CompilerGenerated]
	// RVA: 0x24828F4 Offset: 0x247E8F4 VA: 0x24828F4
	private void set_GuardDelay(float value) { }

	// RVA: 0x24828FC Offset: 0x247E8FC VA: 0x24828FC
	public GuardType get_GuardType() { }

	[CompilerGenerated]
	// RVA: 0x2482954 Offset: 0x247E954 VA: 0x2482954
	public int get_GuardPowerDamage() { }

	[CompilerGenerated]
	// RVA: 0x248295C Offset: 0x247E95C VA: 0x248295C
	private void set_GuardPowerDamage(int value) { }

	// RVA: 0x2482964 Offset: 0x247E964 VA: 0x2482964
	public int get_MaxGuardPower() { }

	// RVA: 0x2482AA0 Offset: 0x247EAA0 VA: 0x2482AA0
	public int get_GuardSpeed() { }

	// RVA: 0x2482B78 Offset: 0x247EB78 VA: 0x2482B78
	public float get_MaxGuardDelay() { }

	// RVA: 0x2482C54 Offset: 0x247EC54 VA: 0x2482C54
	private SkillActionManagerBase get_SkillActionManager() { }

	[CompilerGenerated]
	// RVA: 0x2482CD4 Offset: 0x247ECD4 VA: 0x2482CD4
	private bool get_IsPlayer() { }

	[CompilerGenerated]
	// RVA: 0x2482CDC Offset: 0x247ECDC VA: 0x2482CDC
	private void set_IsPlayer(bool value) { }

	// RVA: 0x2482CE8 Offset: 0x247ECE8 VA: 0x2482CE8
	public bool get_IsAbnormal() { }

	// RVA: 0x248332C Offset: 0x247F32C VA: 0x248332C
	private void Awake() { }

	// RVA: 0x248345C Offset: 0x247F45C VA: 0x248345C
	private void Start() { }

	// RVA: 0x2483460 Offset: 0x247F460 VA: 0x2483460
	private void Update() { }

	// RVA: 0x24835CC Offset: 0x247F5CC VA: 0x24835CC
	public void OnInputMove() { }

	// RVA: 0x2483610 Offset: 0x247F610 VA: 0x2483610
	public void ChangeField() { }

	// RVA: 0x2483824 Offset: 0x247F824 VA: 0x2483824
	public void ChangeStatus() { }

	// RVA: 0x2483908 Offset: 0x247F908 VA: 0x2483908
	public void ChangeGuardOption() { }

	// RVA: 0x248390C Offset: 0x247F90C VA: 0x248390C
	public void OnDead() { }

	// RVA: 0x2483984 Offset: 0x247F984 VA: 0x2483984
	public void OnRespawn(bool orbRespawn) { }

	// RVA: 0x2483A68 Offset: 0x247FA68 VA: 0x2483A68
	public void OnGuard(GameObject actor, SkillDamageData damageData) { }

	// RVA: 0x24836F0 Offset: 0x247F6F0 VA: 0x24836F0
	public void Initialize() { }

	// RVA: 0x2484104 Offset: 0x2480104 VA: 0x2484104
	public bool CheckGuardEquip() { }

	// RVA: 0x2484284 Offset: 0x2480284 VA: 0x2484284
	public bool CheckGuardStart() { }

	// RVA: 0x2484650 Offset: 0x2480650 VA: 0x2484650
	public bool CheckGuard(MobActionManagerBase mobAction, MobAttackBase action, int damage, out SkillHitReactionType guardType, out bool justGuard) { }

	// RVA: 0x2486290 Offset: 0x2482290 VA: 0x2486290
	public void GuardStart(bool shortcut) { }

	// RVA: 0x2486510 Offset: 0x2482510 VA: 0x2486510
	public void GuardEnd(bool forceEnd) { }

	// RVA: 0x2483500 Offset: 0x247F500 VA: 0x2483500
	public bool CheckGuardTake() { }

	// RVA: 0x2486814 Offset: 0x2482814 VA: 0x2486814
	public int CalcGuard(int damage, out int guardPower) { }

	// RVA: 0x24869FC Offset: 0x24829FC VA: 0x24869FC
	public void SetGuardTakeUid(int uid) { }

	// RVA: 0x2486A04 Offset: 0x2482A04 VA: 0x2486A04
	public void TemporaryEvacuationGuardData() { }

	// RVA: 0x2486A14 Offset: 0x2482A14 VA: 0x2486A14
	public void UndoGuardData() { }

	// RVA: 0x2486A24 Offset: 0x2482A24 VA: 0x2486A24
	public void ReceiveDamage(MobaOtherPlayer otherPlayer, MobaMobResponseData responseData, SkillHitReactionType reaction) { }

	// RVA: 0x2486BEC Offset: 0x2482BEC VA: 0x2486BEC
	public void ReceiveResultGuardPower(int guardPowerRecoveryValue, float afterGuardPower) { }

	// RVA: 0x2483FE0 Offset: 0x247FFE0 VA: 0x2483FE0
	public void DisplayGauge(float seconds) { }

	// RVA: 0x2483548 Offset: 0x247F548 VA: 0x2483548
	private void UpdateGuard() { }

	// RVA: 0x2486BF4 Offset: 0x2482BF4 VA: 0x2486BF4
	private void UpdateGuarding() { }

	// RVA: 0x2486F34 Offset: 0x2482F34 VA: 0x2486F34
	private void UpdateGuardWaiting() { }

	// RVA: 0x2487304 Offset: 0x2483304 VA: 0x2487304
	private bool CheckPairOfShieldsGuard() { }

	[IteratorStateMachine(typeof(GuardActionManager.<StartManualGuard>d__91))]
	// RVA: 0x2486490 Offset: 0x2482490 VA: 0x2486490
	private IEnumerator StartManualGuard(bool shortcut) { }

	// RVA: 0x2483E4C Offset: 0x247FE4C VA: 0x2483E4C
	private void GuardCrash() { }

	[IteratorStateMachine(typeof(GuardActionManager.<GuardPowerDown>d__93))]
	// RVA: 0x2484098 Offset: 0x2480098 VA: 0x2484098
	private IEnumerator GuardPowerDown() { }

	// RVA: 0x2484DAC Offset: 0x2480DAC VA: 0x2484DAC
	private bool CheckFinawGuard() { }

	// RVA: 0x248503C Offset: 0x248103C VA: 0x248503C
	private bool CheckMagicBalkanGuard(MobActionManagerBase mobAction, MobAttackBase action) { }

	// RVA: 0x24857BC Offset: 0x24817BC VA: 0x24857BC
	private bool CheckStormBlazer(MobAttackBase action) { }

	// RVA: 0x2485508 Offset: 0x2481508 VA: 0x2485508
	private bool CheckShieldUpper(MobAttackBase action) { }

	// RVA: 0x2485CB8 Offset: 0x2481CB8 VA: 0x2485CB8
	private bool CheckPairOfShields(MobActionManagerBase mobAction, MobAttackBase action) { }

	// RVA: 0x2485A34 Offset: 0x2481A34 VA: 0x2485A34
	public bool CheckDengerShakeGuard(MobActionManagerBase mobAction, MobAttackBase action) { }

	// RVA: 0x2485024 Offset: 0x2481024 VA: 0x2485024
	private void SkillGuard(SkillId skillId, ref SkillHitReactionType guardType) { }

	// RVA: 0x2482DD4 Offset: 0x247EDD4 VA: 0x2482DD4
	private bool CheckInBlackHole(Transform transform) { }

	// RVA: 0x2487478 Offset: 0x2483478 VA: 0x2487478
	public void .ctor() { }
}
