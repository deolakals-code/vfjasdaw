// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class TreasureHuntMobActionManager : TreasureHuntMobActionManagerBase // TypeDefIndex: 1152
{
	// Fields
	protected TreasureHuntMobBattleStatus battleStatus; // 0x170

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1F69934 Offset: 0x1F65934 VA: 0x1F69934 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F6993C Offset: 0x1F6593C VA: 0x1F6993C Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F69944 Offset: 0x1F65944 VA: 0x1F69944 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1F699E8 Offset: 0x1F659E8 VA: 0x1F699E8 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F69AE4 Offset: 0x1F65AE4 VA: 0x1F69AE4 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F69AEC Offset: 0x1F65AEC VA: 0x1F69AEC Slot: 73
	protected override void Update() { }

	// RVA: 0x1F69C74 Offset: 0x1F65C74 VA: 0x1F69C74 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F6A31C Offset: 0x1F6631C VA: 0x1F6A31C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F6A374 Offset: 0x1F66374 VA: 0x1F6A374
	private void <AddAbnormalState>b__10_0(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1F6A3C4 Offset: 0x1F663C4 VA: 0x1F6A3C4
	private void <AddAbnormalState>b__10_1(AbnormalData data) { }
}
