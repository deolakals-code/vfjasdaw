// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(MobAnimation))]
[RequireComponent(typeof(FadeAnimationManager))]
public class NewWaveMobActionManager : NewWaveMobActionManagerBase // TypeDefIndex: 1048
{
	// Fields
	private NewWaveMobBattleStatus _status; // 0x158
	private int mobLevel; // 0x160

	// Properties
	public override bool IsBoss { get; }
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override float MoveSpeed { get; }

	// Methods

	// RVA: 0x1F3CC00 Offset: 0x1F38C00 VA: 0x1F3CC00 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F3CC08 Offset: 0x1F38C08 VA: 0x1F3CC08 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F3CC10 Offset: 0x1F38C10 VA: 0x1F3CC10 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1F3CCB8 Offset: 0x1F38CB8 VA: 0x1F3CCB8 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F3CCC0 Offset: 0x1F38CC0 VA: 0x1F3CCC0 Slot: 73
	protected override void Update() { }

	// RVA: 0x1F3CDD8 Offset: 0x1F38DD8 VA: 0x1F3CDD8 Slot: 107
	public override void SetMobLevel(int level) { }

	// RVA: 0x1F3CDE0 Offset: 0x1F38DE0 VA: 0x1F3CDE0 Slot: 99
	public override void ReceiveMove(Vector3 pos, float UpdateTime, bool isReconnect) { }

	// RVA: 0x1F3CDE4 Offset: 0x1F38DE4 VA: 0x1F3CDE4 Slot: 100
	public override void ReceiveMove(Vector3 pos, float rot, float UpdateTime, bool isReconnect) { }

	// RVA: 0x1F3CED8 Offset: 0x1F38ED8 VA: 0x1F3CED8 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F3D8A8 Offset: 0x1F398A8 VA: 0x1F3D8A8 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F3D9C0 Offset: 0x1F399C0 VA: 0x1F3D9C0
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1F3DA44 Offset: 0x1F39A44 VA: 0x1F3DA44
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F3DA4C Offset: 0x1F39A4C VA: 0x1F3DA4C
	private void <AddAbnormalState>b__13_1(AbnormalData data) { }

	[CompilerGenerated]
	// RVA: 0x1F3DA9C Offset: 0x1F39A9C VA: 0x1F3DA9C
	private void <AddAbnormalState>b__13_0(AbnormalData data) { }
}
