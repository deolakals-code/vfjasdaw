// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class NewWaveBossActionManager : NewWaveMobActionManagerBase, IBossParts // TypeDefIndex: 1046
{
	// Fields
	private NewWaveBossBattleStatus _status; // 0x158
	private int mobLevel; // 0x160
	[CompilerGenerated]
	private Dictionary<byte, MobPartsStatus> <UsePartsList>k__BackingField; // 0x168
	[CompilerGenerated]
	private float <PartsAttackTime>k__BackingField; // 0x170
	[CompilerGenerated]
	private bool <EnablePartsAttack>k__BackingField; // 0x174

	// Properties
	public override bool IsBoss { get; }
	public override IMobStatusCalculator MobBattleStatus { get; }
	public Dictionary<byte, MobPartsStatus> UsePartsList { get; set; }
	public float PartsAttackTime { get; set; }
	public bool EnablePartsAttack { get; set; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1F3A150 Offset: 0x1F36150 VA: 0x1F3A150 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F3A158 Offset: 0x1F36158 VA: 0x1F3A158 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	[CompilerGenerated]
	// RVA: 0x1F3A160 Offset: 0x1F36160 VA: 0x1F3A160 Slot: 108
	public Dictionary<byte, MobPartsStatus> get_UsePartsList() { }

	[CompilerGenerated]
	// RVA: 0x1F3A168 Offset: 0x1F36168 VA: 0x1F3A168
	private void set_UsePartsList(Dictionary<byte, MobPartsStatus> value) { }

	[CompilerGenerated]
	// RVA: 0x1F3A178 Offset: 0x1F36178 VA: 0x1F3A178 Slot: 109
	public float get_PartsAttackTime() { }

	[CompilerGenerated]
	// RVA: 0x1F3A180 Offset: 0x1F36180 VA: 0x1F3A180
	private void set_PartsAttackTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x1F3A188 Offset: 0x1F36188 VA: 0x1F3A188 Slot: 110
	public bool get_EnablePartsAttack() { }

	[CompilerGenerated]
	// RVA: 0x1F3A190 Offset: 0x1F36190 VA: 0x1F3A190
	private void set_EnablePartsAttack(bool value) { }

	// RVA: 0x1F3A19C Offset: 0x1F3619C VA: 0x1F3A19C Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1F3A3DC Offset: 0x1F363DC VA: 0x1F3A3DC Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F3A468 Offset: 0x1F36468 VA: 0x1F3A468 Slot: 73
	protected override void Update() { }

	// RVA: 0x1F3A5F8 Offset: 0x1F365F8 VA: 0x1F3A5F8 Slot: 107
	public override void SetMobLevel(int level) { }

	// RVA: 0x1F3A600 Offset: 0x1F36600 VA: 0x1F3A600 Slot: 99
	public override void ReceiveMove(Vector3 pos, float UpdateTime, bool isReconnect) { }

	// RVA: 0x1F3A604 Offset: 0x1F36604 VA: 0x1F3A604 Slot: 100
	public override void ReceiveMove(Vector3 pos, float rot, float UpdateTime, bool isReconnect) { }

	// RVA: 0x1F3A6F8 Offset: 0x1F366F8 VA: 0x1F3A6F8 Slot: 111
	public void SetPartsMaster(byte id, MobStatusMaster master, int hp) { }

	// RVA: 0x1F3A84C Offset: 0x1F3684C VA: 0x1F3A84C Slot: 112
	public MobPartsStatus GetPartsStatus(byte id) { }

	// RVA: 0x1F3A9A8 Offset: 0x1F369A8 VA: 0x1F3A9A8 Slot: 113
	public void UpdatePartsHp(byte id, int hp) { }

	// RVA: 0x1F3AA48 Offset: 0x1F36A48 VA: 0x1F3AA48 Slot: 114
	public void SetPartAttackTime(float time) { }

	// RVA: 0x1F3AA50 Offset: 0x1F36A50 VA: 0x1F3AA50 Slot: 115
	public void ClearParts() { }

	// RVA: 0x1F3AAA0 Offset: 0x1F36AA0 VA: 0x1F3AAA0 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F3B4E0 Offset: 0x1F374E0 VA: 0x1F3B4E0 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F3B844 Offset: 0x1F37844 VA: 0x1F3B844
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1F3B8C8 Offset: 0x1F378C8 VA: 0x1F3B8C8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F3B8D8 Offset: 0x1F378D8 VA: 0x1F3B8D8
	private void <AddAbnormalState>b__30_1(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1F3B928 Offset: 0x1F37928 VA: 0x1F3B928
	private void <AddAbnormalState>b__30_0(AbnormalData data) { }
}
