// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(MobAnimation))]
[RequireComponent(typeof(FadeAnimationManager))]
public class GuildRaidBossMobActionManager : GuildRaidMobActionManager, IBossParts, IMobLevelFluctuation, IRaidBossMobGauge // TypeDefIndex: 882
{
	// Fields
	[CompilerGenerated]
	private Dictionary<byte, MobPartsStatus> <UsePartsList>k__BackingField; // 0x168
	[CompilerGenerated]
	private float <PartsAttackTime>k__BackingField; // 0x170
	[CompilerGenerated]
	private bool <EnablePartsAttack>k__BackingField; // 0x174
	[CompilerGenerated]
	private int <HpGage>k__BackingField; // 0x178
	[CompilerGenerated]
	private int <HpGageUpLimit>k__BackingField; // 0x17C
	private GuildRaidBossMobBattleStatus battleStatus; // 0x180
	private Dictionary<AbnormalType, int> addAbnormalCountList; // 0x188
	private int mobLevel; // 0x190
	private int flinchAdaptation; // 0x194
	private int tumbleAdaptation; // 0x198
	private int stunAdaptation; // 0x19C

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }
	public Dictionary<byte, MobPartsStatus> UsePartsList { get; set; }
	public float PartsAttackTime { get; set; }
	public bool EnablePartsAttack { get; set; }
	public int HpGage { get; set; }
	public int HpGageUpLimit { get; set; }

	// Methods

	// RVA: 0x1EF35CC Offset: 0x1EEF5CC VA: 0x1EF35CC Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1EF35D4 Offset: 0x1EEF5D4 VA: 0x1EF35D4 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1EF35DC Offset: 0x1EEF5DC VA: 0x1EF35DC Slot: 10
	public override float get_MoveSpeed() { }

	[CompilerGenerated]
	// RVA: 0x1EF3680 Offset: 0x1EEF680 VA: 0x1EF3680 Slot: 97
	public Dictionary<byte, MobPartsStatus> get_UsePartsList() { }

	[CompilerGenerated]
	// RVA: 0x1EF3688 Offset: 0x1EEF688 VA: 0x1EF3688
	private void set_UsePartsList(Dictionary<byte, MobPartsStatus> value) { }

	[CompilerGenerated]
	// RVA: 0x1EF3698 Offset: 0x1EEF698 VA: 0x1EF3698 Slot: 98
	public float get_PartsAttackTime() { }

	[CompilerGenerated]
	// RVA: 0x1EF36A0 Offset: 0x1EEF6A0 VA: 0x1EF36A0
	private void set_PartsAttackTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x1EF36A8 Offset: 0x1EEF6A8 VA: 0x1EF36A8 Slot: 99
	public bool get_EnablePartsAttack() { }

	[CompilerGenerated]
	// RVA: 0x1EF36B0 Offset: 0x1EEF6B0 VA: 0x1EF36B0
	private void set_EnablePartsAttack(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1EF36BC Offset: 0x1EEF6BC VA: 0x1EF36BC Slot: 106
	public int get_HpGage() { }

	[CompilerGenerated]
	// RVA: 0x1EF36C4 Offset: 0x1EEF6C4 VA: 0x1EF36C4
	private void set_HpGage(int value) { }

	[CompilerGenerated]
	// RVA: 0x1EF36CC Offset: 0x1EEF6CC VA: 0x1EF36CC Slot: 107
	public int get_HpGageUpLimit() { }

	[CompilerGenerated]
	// RVA: 0x1EF36D4 Offset: 0x1EEF6D4 VA: 0x1EF36D4
	private void set_HpGageUpLimit(int value) { }

	// RVA: 0x1EF36DC Offset: 0x1EEF6DC VA: 0x1EF36DC Slot: 72
	protected override void Awake() { }

	// RVA: 0x1EF37C8 Offset: 0x1EEF7C8 VA: 0x1EF37C8 Slot: 73
	protected override void Update() { }

	// RVA: 0x1EF3810 Offset: 0x1EEF810 VA: 0x1EF3810 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1EF3C8C Offset: 0x1EEFC8C VA: 0x1EF3C8C Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1EF4FB4 Offset: 0x1EF0FB4 VA: 0x1EF4FB4
	public void InitializeHpGage(int hpGage, int hpGageUpLimit) { }

	// RVA: 0x1EF4FC0 Offset: 0x1EF0FC0 VA: 0x1EF4FC0 Slot: 96
	public override void UpdateHpGage(int hpGage) { }

	// RVA: 0x1EF5084 Offset: 0x1EF1084 VA: 0x1EF5084
	public void InitializeAbnormalHitList(AbnormalHitData[] abnormalHitDatas) { }

	// RVA: 0x1EF5150 Offset: 0x1EF1150 VA: 0x1EF5150 Slot: 100
	public void SetPartsMaster(byte id, MobStatusMaster master, int hp) { }

	// RVA: 0x1EF52A8 Offset: 0x1EF12A8 VA: 0x1EF52A8 Slot: 101
	public MobPartsStatus GetPartsStatus(byte id) { }

	// RVA: 0x1EF5404 Offset: 0x1EF1404 VA: 0x1EF5404 Slot: 102
	public void UpdatePartsHp(byte id, int hp) { }

	// RVA: 0x1EF54B4 Offset: 0x1EF14B4 VA: 0x1EF54B4 Slot: 103
	public void SetPartAttackTime(float time) { }

	// RVA: 0x1EF54BC Offset: 0x1EF14BC VA: 0x1EF54BC Slot: 104
	public void ClearParts() { }

	// RVA: 0x1EF550C Offset: 0x1EF150C VA: 0x1EF550C Slot: 105
	public void SetMobLevel(int level) { }

	// RVA: 0x1EF5514 Offset: 0x1EF1514 VA: 0x1EF5514 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1EF5D58 Offset: 0x1EF1D58 VA: 0x1EF5D58
	public void SyncAbnormalHit(AbnormalType type, int count) { }

	// RVA: 0x1EF5E34 Offset: 0x1EF1E34 VA: 0x1EF5E34
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1EF5EC4 Offset: 0x1EF1EC4 VA: 0x1EF5EC4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1EF5ED4 Offset: 0x1EF1ED4 VA: 0x1EF5ED4
	private void <AddAbnormalState>b__45_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1EF5F30 Offset: 0x1EF1F30 VA: 0x1EF5F30
	private void <AddAbnormalState>b__45_1(AbnormalData data) { }
}
