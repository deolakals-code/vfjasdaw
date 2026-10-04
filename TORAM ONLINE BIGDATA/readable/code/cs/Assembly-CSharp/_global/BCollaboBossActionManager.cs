// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class BCollaboBossActionManager : BCollaboMobActionManager, IBossParts, IMobLevelFluctuation, IRaidBossMobGauge // TypeDefIndex: 843
{
	// Fields
	[CompilerGenerated]
	private int <MobLevel>k__BackingField; // 0x168
	[CompilerGenerated]
	private int <HpGage>k__BackingField; // 0x16C
	[CompilerGenerated]
	private int <HpGageUpLimit>k__BackingField; // 0x170
	[CompilerGenerated]
	private Dictionary<byte, MobPartsStatus> <UsePartsList>k__BackingField; // 0x178
	[CompilerGenerated]
	private float <PartsAttackTime>k__BackingField; // 0x180
	private BCollaboBossMobBattleStatus battleStatus; // 0x188
	private SkinBreakParts parts; // 0x190

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }
	public int MobLevel { get; set; }
	public int HpGage { get; set; }
	public int HpGageUpLimit { get; set; }
	public Dictionary<byte, MobPartsStatus> UsePartsList { get; set; }
	public float PartsAttackTime { get; set; }
	public bool EnablePartsAttack { get; }

	// Methods

	// RVA: 0x1EC59B4 Offset: 0x1EC19B4 VA: 0x1EC59B4 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1EC59BC Offset: 0x1EC19BC VA: 0x1EC59BC Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1EC59C4 Offset: 0x1EC19C4 VA: 0x1EC59C4 Slot: 10
	public override float get_MoveSpeed() { }

	[CompilerGenerated]
	// RVA: 0x1EC5B4C Offset: 0x1EC1B4C VA: 0x1EC5B4C
	public int get_MobLevel() { }

	[CompilerGenerated]
	// RVA: 0x1EC5B54 Offset: 0x1EC1B54 VA: 0x1EC5B54
	private void set_MobLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x1EC5B5C Offset: 0x1EC1B5C VA: 0x1EC5B5C Slot: 106
	public int get_HpGage() { }

	[CompilerGenerated]
	// RVA: 0x1EC5B64 Offset: 0x1EC1B64 VA: 0x1EC5B64
	private void set_HpGage(int value) { }

	[CompilerGenerated]
	// RVA: 0x1EC5B6C Offset: 0x1EC1B6C VA: 0x1EC5B6C Slot: 107
	public int get_HpGageUpLimit() { }

	[CompilerGenerated]
	// RVA: 0x1EC5B74 Offset: 0x1EC1B74 VA: 0x1EC5B74
	private void set_HpGageUpLimit(int value) { }

	[CompilerGenerated]
	// RVA: 0x1EC5B7C Offset: 0x1EC1B7C VA: 0x1EC5B7C Slot: 98
	public Dictionary<byte, MobPartsStatus> get_UsePartsList() { }

	[CompilerGenerated]
	// RVA: 0x1EC5B84 Offset: 0x1EC1B84 VA: 0x1EC5B84
	private void set_UsePartsList(Dictionary<byte, MobPartsStatus> value) { }

	[CompilerGenerated]
	// RVA: 0x1EC5B94 Offset: 0x1EC1B94 VA: 0x1EC5B94 Slot: 99
	public float get_PartsAttackTime() { }

	[CompilerGenerated]
	// RVA: 0x1EC5B9C Offset: 0x1EC1B9C VA: 0x1EC5B9C
	private void set_PartsAttackTime(float value) { }

	// RVA: 0x1EC5BA4 Offset: 0x1EC1BA4 VA: 0x1EC5BA4 Slot: 100
	public bool get_EnablePartsAttack() { }

	// RVA: 0x1EC5BB4 Offset: 0x1EC1BB4 VA: 0x1EC5BB4 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1EC5C88 Offset: 0x1EC1C88 VA: 0x1EC5C88 Slot: 73
	protected override void Update() { }

	// RVA: 0x1EC5DA8 Offset: 0x1EC1DA8 VA: 0x1EC5DA8 Slot: 105
	public void ClearParts() { }

	// RVA: 0x1EC5E80 Offset: 0x1EC1E80 VA: 0x1EC5E80 Slot: 102
	public MobPartsStatus GetPartsStatus(byte id) { }

	// RVA: 0x1EC5F28 Offset: 0x1EC1F28 VA: 0x1EC5F28 Slot: 104
	public void SetPartAttackTime(float time) { }

	// RVA: 0x1EC5F2C Offset: 0x1EC1F2C VA: 0x1EC5F2C Slot: 101
	public void SetPartsMaster(byte id, MobStatusMaster master, int hp) { }

	// RVA: 0x1EC6128 Offset: 0x1EC2128 VA: 0x1EC6128 Slot: 103
	public void UpdatePartsHp(byte id, int hp) { }

	// RVA: 0x1EC6214 Offset: 0x1EC2214 VA: 0x1EC6214 Slot: 95
	public void SetMobLevel(int level) { }

	// RVA: 0x1EC621C Offset: 0x1EC221C VA: 0x1EC621C Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1EC78E0 Offset: 0x1EC38E0 VA: 0x1EC78E0 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1EC7C44 Offset: 0x1EC3C44 VA: 0x1EC7C44
	public void InitializeHpGage(int hpGage, int hpGageUpLimit) { }

	// RVA: 0x1EC7C50 Offset: 0x1EC3C50 VA: 0x1EC7C50
	public void UpdateHpGage(int hpGage) { }

	// RVA: 0x1EC7D14 Offset: 0x1EC3D14 VA: 0x1EC7D14 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1EC8464 Offset: 0x1EC4464 VA: 0x1EC8464
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1EC8474 Offset: 0x1EC4474 VA: 0x1EC8474
	private void <AddAbnormalState>b__42_1(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1EC84D0 Offset: 0x1EC44D0 VA: 0x1EC84D0
	private void <AddAbnormalState>b__42_0(AbnormalData data) { }
}
