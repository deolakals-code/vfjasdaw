// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class HighRaidBossActionManager : EnemyMobActionManagerBase, IBossParts, IMobLevelFluctuation // TypeDefIndex: 890
{
	// Fields
	protected IMobStatusCalculator battleStatus; // 0x158
	private int mobLevel; // 0x160
	[CompilerGenerated]
	private Dictionary<byte, MobPartsStatus> <UsePartsList>k__BackingField; // 0x168
	[CompilerGenerated]
	private float <PartsAttackTime>k__BackingField; // 0x170

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }
	public Dictionary<byte, MobPartsStatus> UsePartsList { get; set; }
	public float PartsAttackTime { get; set; }
	public bool EnablePartsAttack { get; }
	public override bool IsNearRoomStart { get; }

	// Methods

	// RVA: 0x1EFA9A8 Offset: 0x1EF69A8 VA: 0x1EFA9A8 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1EFA9B0 Offset: 0x1EF69B0 VA: 0x1EFA9B0 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1EFA9B8 Offset: 0x1EF69B8 VA: 0x1EFA9B8 Slot: 10
	public override float get_MoveSpeed() { }

	[CompilerGenerated]
	// RVA: 0x1EFABE0 Offset: 0x1EF6BE0 VA: 0x1EFABE0 Slot: 95
	public Dictionary<byte, MobPartsStatus> get_UsePartsList() { }

	[CompilerGenerated]
	// RVA: 0x1EFABE8 Offset: 0x1EF6BE8 VA: 0x1EFABE8
	private void set_UsePartsList(Dictionary<byte, MobPartsStatus> value) { }

	[CompilerGenerated]
	// RVA: 0x1EFABF8 Offset: 0x1EF6BF8 VA: 0x1EFABF8 Slot: 96
	public float get_PartsAttackTime() { }

	[CompilerGenerated]
	// RVA: 0x1EFAC00 Offset: 0x1EF6C00 VA: 0x1EFAC00
	private void set_PartsAttackTime(float value) { }

	// RVA: 0x1EFAC08 Offset: 0x1EF6C08 VA: 0x1EFAC08 Slot: 97
	public bool get_EnablePartsAttack() { }

	// RVA: 0x1EFAC18 Offset: 0x1EF6C18 VA: 0x1EFAC18 Slot: 71
	public override bool get_IsNearRoomStart() { }

	// RVA: 0x1EFAC20 Offset: 0x1EF6C20 VA: 0x1EFAC20 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1EFACAC Offset: 0x1EF6CAC VA: 0x1EFACAC Slot: 73
	protected override void Update() { }

	// RVA: 0x1EFAD58 Offset: 0x1EF6D58 VA: 0x1EFAD58 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1EFB178 Offset: 0x1EF7178 VA: 0x1EFB178 Slot: 99
	public MobPartsStatus GetPartsStatus(byte id) { }

	// RVA: 0x1EFB2EC Offset: 0x1EF72EC VA: 0x1EFB2EC Slot: 98
	public void SetPartsMaster(byte id, MobStatusMaster master, int hp) { }

	// RVA: 0x1EFB4B8 Offset: 0x1EF74B8 VA: 0x1EFB4B8 Slot: 100
	public void UpdatePartsHp(byte id, int hp) { }

	// RVA: 0x1EFB568 Offset: 0x1EF7568 VA: 0x1EFB568 Slot: 101
	public void SetPartAttackTime(float time) { }

	// RVA: 0x1EFB570 Offset: 0x1EF7570 VA: 0x1EFB570 Slot: 102
	public void ClearParts() { }

	// RVA: 0x1EFB5C0 Offset: 0x1EF75C0 VA: 0x1EFB5C0 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1EFBCFC Offset: 0x1EF7CFC VA: 0x1EFBCFC
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1EFBD80 Offset: 0x1EF7D80 VA: 0x1EFBD80 Slot: 103
	public void SetMobLevel(int level) { }

	// RVA: 0x1EFBD88 Offset: 0x1EF7D88 VA: 0x1EFBD88
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1EFBD90 Offset: 0x1EF7D90 VA: 0x1EFBD90
	private void <AddAbnormalState>b__28_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1EFBDE0 Offset: 0x1EF7DE0 VA: 0x1EFBDE0
	private void <AddAbnormalState>b__28_1(AbnormalData data) { }
}
