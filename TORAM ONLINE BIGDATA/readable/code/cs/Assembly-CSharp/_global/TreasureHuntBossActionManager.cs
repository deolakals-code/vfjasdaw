// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class TreasureHuntBossActionManager : TreasureHuntMobActionManagerBase, IBossParts // TypeDefIndex: 1150
{
	// Fields
	private TreasureHuntBossBattleStatus battleStatus; // 0x170
	[CompilerGenerated]
	private Dictionary<byte, MobPartsStatus> <UsePartsList>k__BackingField; // 0x178
	[CompilerGenerated]
	private short <AreaLevel>k__BackingField; // 0x180
	[CompilerGenerated]
	private float <PartsAttackTime>k__BackingField; // 0x184

	// Properties
	public Dictionary<byte, MobPartsStatus> UsePartsList { get; set; }
	public short AreaLevel { get; set; }
	public MobActionManagerBase MobAct { get; }
	public float PartsAttackTime { get; set; }
	public bool EnablePartsAttack { get; }
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F66DE4 Offset: 0x1F62DE4 VA: 0x1F66DE4 Slot: 106
	public Dictionary<byte, MobPartsStatus> get_UsePartsList() { }

	[CompilerGenerated]
	// RVA: 0x1F66DEC Offset: 0x1F62DEC VA: 0x1F66DEC
	private void set_UsePartsList(Dictionary<byte, MobPartsStatus> value) { }

	[CompilerGenerated]
	// RVA: 0x1F66DFC Offset: 0x1F62DFC VA: 0x1F66DFC
	public short get_AreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x1F66E04 Offset: 0x1F62E04 VA: 0x1F66E04
	public void set_AreaLevel(short value) { }

	// RVA: 0x1F66E0C Offset: 0x1F62E0C VA: 0x1F66E0C
	public MobActionManagerBase get_MobAct() { }

	[CompilerGenerated]
	// RVA: 0x1F66E10 Offset: 0x1F62E10 VA: 0x1F66E10 Slot: 107
	public float get_PartsAttackTime() { }

	[CompilerGenerated]
	// RVA: 0x1F66E18 Offset: 0x1F62E18 VA: 0x1F66E18
	private void set_PartsAttackTime(float value) { }

	// RVA: 0x1F66E20 Offset: 0x1F62E20 VA: 0x1F66E20 Slot: 108
	public bool get_EnablePartsAttack() { }

	// RVA: 0x1F66E30 Offset: 0x1F62E30 VA: 0x1F66E30 Slot: 109
	public void SetPartsMaster(byte id, MobStatusMaster master, int hp) { }

	// RVA: 0x1F66F5C Offset: 0x1F62F5C VA: 0x1F66F5C Slot: 110
	public MobPartsStatus GetPartsStatus(byte id) { }

	// RVA: 0x1F66FF0 Offset: 0x1F62FF0 VA: 0x1F66FF0 Slot: 111
	public void UpdatePartsHp(byte id, int hp) { }

	// RVA: 0x1F670A0 Offset: 0x1F630A0 VA: 0x1F670A0 Slot: 112
	public void SetPartAttackTime(float time) { }

	// RVA: 0x1F670A8 Offset: 0x1F630A8 VA: 0x1F670A8 Slot: 113
	public void ClearParts() { }

	// RVA: 0x1F670F8 Offset: 0x1F630F8 VA: 0x1F670F8 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F67100 Offset: 0x1F63100 VA: 0x1F67100 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F67108 Offset: 0x1F63108 VA: 0x1F67108 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1F67354 Offset: 0x1F63354 VA: 0x1F67354 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F67710 Offset: 0x1F63710 VA: 0x1F67710 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F677A4 Offset: 0x1F637A4 VA: 0x1F677A4 Slot: 73
	protected override void Update() { }

	// RVA: 0x1F67BB4 Offset: 0x1F63BB4 VA: 0x1F67BB4 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F682F8 Offset: 0x1F642F8 VA: 0x1F682F8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F68358 Offset: 0x1F64358 VA: 0x1F68358
	private void <AddAbnormalState>b__31_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1F6842C Offset: 0x1F6442C VA: 0x1F6842C
	private void <AddAbnormalState>b__31_1(AbnormalData data) { }
}
