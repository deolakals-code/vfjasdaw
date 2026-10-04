// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class ScoreAttackBossActionManager : EnemyMobActionManagerBase, IBossParts, IMobLevelFluctuation, IRoomEndMobActionManager // TypeDefIndex: 1127
{
	// Fields
	[CompilerGenerated]
	private Dictionary<byte, MobPartsStatus> <UsePartsList>k__BackingField; // 0x158
	[CompilerGenerated]
	private float <PartsAttackTime>k__BackingField; // 0x160
	[CompilerGenerated]
	private bool <EnablePartsAttack>k__BackingField; // 0x164
	protected IMobStatusCalculator battleStatus; // 0x168
	private int mobLevel; // 0x170
	private TakeController controller; // 0x178
	private bool isRoomEnd; // 0x180

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }
	public Dictionary<byte, MobPartsStatus> UsePartsList { get; set; }
	public float PartsAttackTime { get; set; }
	public bool EnablePartsAttack { get; set; }
	public override bool IsNearRoomStart { get; }
	private TakeController takeController { get; }

	// Methods

	// RVA: 0x1F4AB74 Offset: 0x1F46B74 VA: 0x1F4AB74 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F4AB7C Offset: 0x1F46B7C VA: 0x1F4AB7C Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F4AB84 Offset: 0x1F46B84 VA: 0x1F4AB84 Slot: 10
	public override float get_MoveSpeed() { }

	[CompilerGenerated]
	// RVA: 0x1F4ADAC Offset: 0x1F46DAC VA: 0x1F4ADAC Slot: 95
	public Dictionary<byte, MobPartsStatus> get_UsePartsList() { }

	[CompilerGenerated]
	// RVA: 0x1F4ADB4 Offset: 0x1F46DB4 VA: 0x1F4ADB4
	private void set_UsePartsList(Dictionary<byte, MobPartsStatus> value) { }

	[CompilerGenerated]
	// RVA: 0x1F4ADC4 Offset: 0x1F46DC4 VA: 0x1F4ADC4 Slot: 96
	public float get_PartsAttackTime() { }

	[CompilerGenerated]
	// RVA: 0x1F4ADCC Offset: 0x1F46DCC VA: 0x1F4ADCC
	private void set_PartsAttackTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x1F4ADD4 Offset: 0x1F46DD4 VA: 0x1F4ADD4 Slot: 97
	public bool get_EnablePartsAttack() { }

	[CompilerGenerated]
	// RVA: 0x1F4ADDC Offset: 0x1F46DDC VA: 0x1F4ADDC
	private void set_EnablePartsAttack(bool value) { }

	// RVA: 0x1F4ADE8 Offset: 0x1F46DE8 VA: 0x1F4ADE8 Slot: 71
	public override bool get_IsNearRoomStart() { }

	// RVA: 0x1F4ADF0 Offset: 0x1F46DF0 VA: 0x1F4ADF0
	private TakeController get_takeController() { }

	// RVA: 0x1F4AE94 Offset: 0x1F46E94 VA: 0x1F4AE94 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F4AF20 Offset: 0x1F46F20 VA: 0x1F4AF20 Slot: 73
	protected override void Update() { }

	// RVA: 0x1F4B030 Offset: 0x1F47030 VA: 0x1F4B030 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F4B484 Offset: 0x1F47484 VA: 0x1F4B484
	public void UpdateLevel(int level) { }

	// RVA: 0x1F4B604 Offset: 0x1F47604 VA: 0x1F4B604 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1F4C8F8 Offset: 0x1F488F8 VA: 0x1F4C8F8 Slot: 99
	public MobPartsStatus GetPartsStatus(byte id) { }

	// RVA: 0x1F4CA6C Offset: 0x1F48A6C VA: 0x1F4CA6C Slot: 98
	public void SetPartsMaster(byte id, MobStatusMaster master, int hp) { }

	// RVA: 0x1F4CC08 Offset: 0x1F48C08 VA: 0x1F4CC08 Slot: 100
	public void UpdatePartsHp(byte id, int hp) { }

	// RVA: 0x1F4CCB8 Offset: 0x1F48CB8 VA: 0x1F4CCB8 Slot: 101
	public void SetPartAttackTime(float time) { }

	// RVA: 0x1F4CCC0 Offset: 0x1F48CC0 VA: 0x1F4CCC0 Slot: 102
	public void ClearParts() { }

	// RVA: 0x1F4CD10 Offset: 0x1F48D10 VA: 0x1F4CD10 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F4D47C Offset: 0x1F4947C VA: 0x1F4D47C
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1F4D500 Offset: 0x1F49500 VA: 0x1F4D500 Slot: 103
	public void SetMobLevel(int level) { }

	// RVA: 0x1F4D508 Offset: 0x1F49508 VA: 0x1F4D508 Slot: 104
	public void ActionEnd() { }

	// RVA: 0x1F4D624 Offset: 0x1F49624 VA: 0x1F4D624
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F4D634 Offset: 0x1F49634 VA: 0x1F4D634
	private void <AddAbnormalState>b__36_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1F4D684 Offset: 0x1F49684 VA: 0x1F4D684
	private void <AddAbnormalState>b__36_1(AbnormalData data) { }
}
