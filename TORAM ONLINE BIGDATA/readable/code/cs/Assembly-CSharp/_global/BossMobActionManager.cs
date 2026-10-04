// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(MobAnimation))]
[RequireComponent(typeof(FadeAnimationManager))]
public class BossMobActionManager : EnemyMobActionManagerBase, IBossParts // TypeDefIndex: 847
{
	// Fields
	private IMobStatusCalculator battleStatus; // 0x158
	[CompilerGenerated]
	private float <PartsAttackTime>k__BackingField; // 0x160
	[CompilerGenerated]
	private Dictionary<byte, MobPartsStatus> <UsePartsList>k__BackingField; // 0x168

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public bool EnablePartsAttack { get; }
	public float PartsAttackTime { get; set; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }
	public Dictionary<byte, MobPartsStatus> UsePartsList { get; set; }
	public override bool IsNearRoomStart { get; }

	// Methods

	// RVA: 0x1ECA570 Offset: 0x1EC6570 VA: 0x1ECA570 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1ECA578 Offset: 0x1EC6578 VA: 0x1ECA578 Slot: 97
	public bool get_EnablePartsAttack() { }

	[CompilerGenerated]
	// RVA: 0x1ECA588 Offset: 0x1EC6588 VA: 0x1ECA588 Slot: 96
	public float get_PartsAttackTime() { }

	[CompilerGenerated]
	// RVA: 0x1ECA590 Offset: 0x1EC6590 VA: 0x1ECA590
	private void set_PartsAttackTime(float value) { }

	// RVA: 0x1ECA598 Offset: 0x1EC6598 VA: 0x1ECA598 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1ECA5A0 Offset: 0x1EC65A0 VA: 0x1ECA5A0 Slot: 10
	public override float get_MoveSpeed() { }

	[CompilerGenerated]
	// RVA: 0x1ECA724 Offset: 0x1EC6724 VA: 0x1ECA724 Slot: 95
	public Dictionary<byte, MobPartsStatus> get_UsePartsList() { }

	[CompilerGenerated]
	// RVA: 0x1ECA72C Offset: 0x1EC672C VA: 0x1ECA72C
	private void set_UsePartsList(Dictionary<byte, MobPartsStatus> value) { }

	// RVA: 0x1ECA73C Offset: 0x1EC673C VA: 0x1ECA73C Slot: 71
	public override bool get_IsNearRoomStart() { }

	// RVA: 0x1ECA744 Offset: 0x1EC6744 VA: 0x1ECA744 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1ECA7D0 Offset: 0x1EC67D0 VA: 0x1ECA7D0 Slot: 73
	protected override void Update() { }

	// RVA: 0x1ECA87C Offset: 0x1EC687C VA: 0x1ECA87C Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1ECADAC Offset: 0x1EC6DAC VA: 0x1ECADAC Slot: 99
	public MobPartsStatus GetPartsStatus(byte id) { }

	// RVA: 0x1ECAF20 Offset: 0x1EC6F20 VA: 0x1ECAF20 Slot: 98
	public void SetPartsMaster(byte id, MobStatusMaster master, int hp) { }

	// RVA: 0x1ECB0BC Offset: 0x1EC70BC VA: 0x1ECB0BC Slot: 100
	public void UpdatePartsHp(byte id, int hp) { }

	// RVA: 0x1ECB16C Offset: 0x1EC716C VA: 0x1ECB16C Slot: 101
	public void SetPartAttackTime(float time) { }

	// RVA: 0x1ECB174 Offset: 0x1EC7174 VA: 0x1ECB174 Slot: 102
	public void ClearParts() { }

	// RVA: 0x1ECB2B4 Offset: 0x1EC72B4 VA: 0x1ECB2B4 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1ECBA28 Offset: 0x1EC7A28 VA: 0x1ECBA28
	private float ResistCollection(AbnormalType type, float orgResist) { }

	// RVA: 0x1ECBB54 Offset: 0x1EC7B54 VA: 0x1ECBB54
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1ECBBD8 Offset: 0x1EC7BD8 VA: 0x1ECBBD8 Slot: 79
	public override void UpdateHp(int hp) { }

	// RVA: 0x1ECBCE8 Offset: 0x1EC7CE8 VA: 0x1ECBCE8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1ECBCF0 Offset: 0x1EC7CF0 VA: 0x1ECBCF0
	private void <AddAbnormalState>b__27_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1ECBD40 Offset: 0x1EC7D40 VA: 0x1ECBD40
	private void <AddAbnormalState>b__27_1(AbnormalData data) { }
}
