// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class GuildRaidEntourageMobActionManager : GuildRaidMobActionManager, IMobLevelFluctuation // TypeDefIndex: 885
{
	// Fields
	private int mobLevel; // 0x164
	private int hpGage; // 0x168

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1EF7BB8 Offset: 0x1EF3BB8 VA: 0x1EF7BB8 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1EF7BC0 Offset: 0x1EF3BC0 VA: 0x1EF7BC0 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1EF7BD4 Offset: 0x1EF3BD4 VA: 0x1EF7BD4 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1EF8020 Offset: 0x1EF4020 VA: 0x1EF8020 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1EF8028 Offset: 0x1EF4028 VA: 0x1EF8028 Slot: 97
	public void SetMobLevel(int level) { }

	// RVA: 0x1EF8030 Offset: 0x1EF4030 VA: 0x1EF8030 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1EF82EC Offset: 0x1EF42EC VA: 0x1EF82EC
	public void InitializeHpGage(int hpGage) { }

	// RVA: 0x1EF82F4 Offset: 0x1EF42F4 VA: 0x1EF82F4 Slot: 96
	public override void UpdateHpGage(int hpGage) { }

	// RVA: 0x1EF838C Offset: 0x1EF438C VA: 0x1EF838C
	public void .ctor() { }
}
