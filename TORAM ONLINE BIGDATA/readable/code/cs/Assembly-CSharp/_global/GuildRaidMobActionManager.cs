// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class GuildRaidMobActionManager : EnemyMobActionManagerBase, IRoomEndMobActionManager // TypeDefIndex: 887
{
	// Fields
	protected IMobStatusCalculator battleStatus; // 0x158
	private bool isRoomEnd; // 0x160

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override float MoveSpeed { get; }
	public override bool IsBoss { get; }

	// Methods

	// RVA: 0x1EF90A8 Offset: 0x1EF50A8 VA: 0x1EF90A8 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1EF7DF8 Offset: 0x1EF3DF8 VA: 0x1EF7DF8 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1EF90B0 Offset: 0x1EF50B0 VA: 0x1EF90B0 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1EF90B8 Offset: 0x1EF50B8 VA: 0x1EF90B8 Slot: 73
	protected override void Update() { }

	// RVA: 0x1EF915C Offset: 0x1EF515C VA: 0x1EF915C Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1EF93B4 Offset: 0x1EF53B4 VA: 0x1EF93B4 Slot: 95
	public void ActionEnd() { }

	// RVA: 0x1EF94B8 Offset: 0x1EF54B8 VA: 0x1EF94B8 Slot: 96
	public virtual void UpdateHpGage(int hpGage) { }

	// RVA: 0x1EF8394 Offset: 0x1EF4394 VA: 0x1EF8394
	public void .ctor() { }
}
