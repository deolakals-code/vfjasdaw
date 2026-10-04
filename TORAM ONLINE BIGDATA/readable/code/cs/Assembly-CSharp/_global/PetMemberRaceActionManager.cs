// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetMemberRaceActionManager : CharacterActionManagerBase // TypeDefIndex: 1323
{
	// Fields
	private const short dashSEId = 302;
	private const short jumpSEId = 111;
	private const short stepSEId = 109;
	private const short hitSEId = 101;
	private const short burstSEId = 115;
	private const short burstRecoverySEId = 406;
	private const short recoverySEId = 405;
	private ArchetypeUid archetypeUid; // 0x58
	private float size; // 0x60
	private Vector3 moveForward; // 0x64
	private float jump; // 0x70
	private float stepTimer; // 0x74
	private Vector3 stepMove; // 0x78
	private float speedGauge; // 0x84
	private PetRaceRoomData room; // 0x88
	private bool isDash; // 0x90
	private float burstTimer; // 0x94
	private int burstTakeUid; // 0x98
	private float petStamina; // 0x9C
	private byte personal; // 0xA0
	private int petStaminBonusRate; // 0xA4
	private AnimationBase animationBase; // 0xA8
	private bool isHitWall; // 0xB0
	private float rateStr; // 0xB4
	private float rateInt; // 0xB8
	private float rateVit; // 0xBC
	private float rateAgi; // 0xC0
	private float rateDex; // 0xC4
	private PetArchetype petArchetype; // 0xC8
	private float routineConnectTime; // 0xD0
	private WallCollision lastCol; // 0xD8
	private bool reJoin; // 0xE0
	private PetRaceMaster master; // 0xE8

	// Properties
	public override float Size { get; }
	public override bool IsDead { get; }
	public override float MoveSpeed { get; }
	public float MaxSpeed { get; }
	public float StaminaRate { get; }
	public float BurstTimeRate { get; }
	private float itemRecoveryStaminaRate { get; }
	private float jumpUp { get; }
	private float defaultSpeed { get; }
	private float maxSpeed { get; }
	private float acceleration { get; }
	private float maxStamina { get; }
	private float recoveryStamina { get; }
	private float dashStamina { get; }
	private float jumpStamina { get; }
	private float jumpDownSpeed { get; }
	private float stepStamina { get; }
	private float stepDownSpeed { get; }
	private float hitStamina { get; }
	private float hitDownSpeed { get; }
	private float downSpeed { get; }
	private float downBurstSpeed { get; }
	private float stepDist { get; }
	private float stepTime { get; }
	private float burstTime { get; }
	private float burstRecoveryStamina { get; }

	// Methods

	// RVA: 0x1FB47B8 Offset: 0x1FB07B8 VA: 0x1FB47B8
	public static bool CheckPetRaceEntry(int stamina, int train) { }

	// RVA: 0x1FC2F64 Offset: 0x1FBEF64 VA: 0x1FC2F64 Slot: 4
	public override float get_Size() { }

	// RVA: 0x1FC2F6C Offset: 0x1FBEF6C VA: 0x1FC2F6C Slot: 7
	public override bool get_IsDead() { }

	// RVA: 0x1FC2F74 Offset: 0x1FBEF74 VA: 0x1FC2F74 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1FC2FC0 Offset: 0x1FBEFC0 VA: 0x1FC2FC0
	public float get_MaxSpeed() { }

	// RVA: 0x1FC3030 Offset: 0x1FBF030 VA: 0x1FC3030
	public float get_StaminaRate() { }

	// RVA: 0x1FC307C Offset: 0x1FBF07C VA: 0x1FC307C
	public float get_BurstTimeRate() { }

	// RVA: 0x1FC30E0 Offset: 0x1FBF0E0 VA: 0x1FC30E0
	private float get_itemRecoveryStaminaRate() { }

	// RVA: 0x1FC311C Offset: 0x1FBF11C VA: 0x1FC311C
	private float get_jumpUp() { }

	// RVA: 0x1FC2FA4 Offset: 0x1FBEFA4 VA: 0x1FC2FA4
	private float get_defaultSpeed() { }

	// RVA: 0x1FC3004 Offset: 0x1FBF004 VA: 0x1FC3004
	private float get_maxSpeed() { }

	// RVA: 0x1FC3138 Offset: 0x1FBF138 VA: 0x1FC3138
	private float get_acceleration() { }

	// RVA: 0x1FC3050 Offset: 0x1FBF050 VA: 0x1FC3050
	private float get_maxStamina() { }

	// RVA: 0x1FC3164 Offset: 0x1FBF164 VA: 0x1FC3164
	private float get_recoveryStamina() { }

	// RVA: 0x1FC3190 Offset: 0x1FBF190 VA: 0x1FC3190
	private float get_dashStamina() { }

	// RVA: 0x1FC31BC Offset: 0x1FBF1BC VA: 0x1FC31BC
	private float get_jumpStamina() { }

	// RVA: 0x1FC31E8 Offset: 0x1FBF1E8 VA: 0x1FC31E8
	private float get_jumpDownSpeed() { }

	// RVA: 0x1FC3214 Offset: 0x1FBF214 VA: 0x1FC3214
	private float get_stepStamina() { }

	// RVA: 0x1FC3240 Offset: 0x1FBF240 VA: 0x1FC3240
	private float get_stepDownSpeed() { }

	// RVA: 0x1FC326C Offset: 0x1FBF26C VA: 0x1FC326C
	private float get_hitStamina() { }

	// RVA: 0x1FC329C Offset: 0x1FBF29C VA: 0x1FC329C
	private float get_hitDownSpeed() { }

	// RVA: 0x1FC32CC Offset: 0x1FBF2CC VA: 0x1FC32CC
	private float get_downSpeed() { }

	// RVA: 0x1FC32F8 Offset: 0x1FBF2F8 VA: 0x1FC32F8
	private float get_downBurstSpeed() { }

	// RVA: 0x1FC3314 Offset: 0x1FBF314 VA: 0x1FC3314
	private float get_stepDist() { }

	// RVA: 0x1FC3330 Offset: 0x1FBF330 VA: 0x1FC3330
	private float get_stepTime() { }

	// RVA: 0x1FC309C Offset: 0x1FBF09C VA: 0x1FC309C
	private float get_burstTime() { }

	// RVA: 0x1FC334C Offset: 0x1FBF34C VA: 0x1FC334C
	private float get_burstRecoveryStamina() { }

	// RVA: 0x1FB8DE8 Offset: 0x1FB4DE8 VA: 0x1FB8DE8
	public void Initialize(Archetype archetype, PetMemberSettingBase setting) { }

	// RVA: 0x1FC3364 Offset: 0x1FBF364 VA: 0x1FC3364
	private void Update() { }

	// RVA: 0x1FC3B14 Offset: 0x1FBFB14 VA: 0x1FC3B14
	private void LateUpdate() { }

	// RVA: 0x1FC41B4 Offset: 0x1FC01B4 VA: 0x1FC41B4
	private bool StaminaAction(float useStamina) { }

	// RVA: 0x1FC4350 Offset: 0x1FC0350 VA: 0x1FC4350
	private void ActionSpeedDown(float downSpeed) { }

	// RVA: 0x1FC4384 Offset: 0x1FC0384 VA: 0x1FC4384
	public bool MoveAction(Vector3 dir) { }

	// RVA: 0x1FC43CC Offset: 0x1FC03CC VA: 0x1FC43CC
	public bool JumpAction() { }

	// RVA: 0x1FC46C0 Offset: 0x1FC06C0 VA: 0x1FC46C0
	public bool SpeedUpAction() { }

	// RVA: 0x1FC4AEC Offset: 0x1FC0AEC VA: 0x1FC4AEC
	public bool StepAction(Vector3 dir) { }

	// RVA: 0x1FC4F08 Offset: 0x1FC0F08 VA: 0x1FC4F08
	public void UpdateStamina(float stamina) { }

	[IteratorStateMachine(typeof(PetMemberRaceActionManager.<GetParam>d__97))]
	// RVA: 0x1FC4F50 Offset: 0x1FC0F50 VA: 0x1FC4F50
	public IEnumerable<string> GetParam() { }

	// RVA: 0x1FC4FC4 Offset: 0x1FC0FC4 VA: 0x1FC4FC4 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1FC4FC8 Offset: 0x1FC0FC8 VA: 0x1FC4FC8 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1FC4FD0 Offset: 0x1FC0FD0 VA: 0x1FC4FD0 Slot: 17
	public override void OnDead() { }

	// RVA: 0x1FC4FD4 Offset: 0x1FC0FD4 VA: 0x1FC4FD4
	public void .ctor() { }
}
