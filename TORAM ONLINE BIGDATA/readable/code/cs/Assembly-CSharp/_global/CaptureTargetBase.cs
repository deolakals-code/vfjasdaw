// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class CaptureTargetBase : ICaptureTimer // TypeDefIndex: 1182
{
	// Fields
	private PlayerDataManager playerData; // 0x10
	[CompilerGenerated]
	private MobStatusMaster <TargetMaster>k__BackingField; // 0x18

	// Properties
	protected PlayerDataManager playerDataManager { get; }
	public abstract bool IsEnd { get; }
	public abstract EnemyMobActionManagerBase Target { get; }
	public MobStatusMaster TargetMaster { get; set; }
	public abstract PlayerActionManagerBase Player { get; }
	public abstract int OrgTimer { get; }
	public abstract int MaxGauge { get; }
	public abstract int NowTimer { get; }
	public abstract int NowGauge { get; }
	public abstract int NowRegist { get; }
	public abstract bool Result { get; }

	// Methods

	// RVA: 0x1F7B26C Offset: 0x1F7726C VA: 0x1F7B26C
	protected PlayerDataManager get_playerDataManager() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_IsEnd();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract EnemyMobActionManagerBase get_Target();

	[CompilerGenerated]
	// RVA: 0x1F7B2F0 Offset: 0x1F772F0 VA: 0x1F7B2F0
	public MobStatusMaster get_TargetMaster() { }

	[CompilerGenerated]
	// RVA: 0x1F7B2F8 Offset: 0x1F772F8 VA: 0x1F7B2F8
	protected void set_TargetMaster(MobStatusMaster value) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract PlayerActionManagerBase get_Player();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_OrgTimer();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_MaxGauge();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int get_NowTimer();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int get_NowGauge();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int get_NowRegist();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetServerData(int timer, int gauge, int regist);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_Result();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void AddRegistValue(bool isAttack);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void ForcedEnd();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool Update();

	// RVA: 0x1F7B300 Offset: 0x1F77300 VA: 0x1F7B300 Slot: 21
	public virtual void Dispose() { }

	// RVA: 0x1F7B304 Offset: 0x1F77304 VA: 0x1F7B304 Slot: 5
	public string GetTimeString() { }

	// RVA: 0x1F7B420 Offset: 0x1F77420 VA: 0x1F7B420 Slot: 6
	public float GetTameGaugeRate() { }

	// RVA: 0x1F7B47C Offset: 0x1F7747C VA: 0x1F7B47C Slot: 7
	public float GetResistingRate() { }

	// RVA: 0x1F7B4BC Offset: 0x1F774BC VA: 0x1F7B4BC Slot: 22
	public virtual void CaptureStart(CaptureStartEvent start) { }

	// RVA: 0x1F7AC9C Offset: 0x1F76C9C VA: 0x1F7AC9C Slot: 23
	public virtual void CaptureSuccess(CaptureSuccessEvent success) { }

	// RVA: 0x1F7B550 Offset: 0x1F77550 VA: 0x1F7B550 Slot: 24
	public virtual void CaptureFailed(CaptureFailedEvent failed) { }

	[IteratorStateMachine(typeof(CaptureTargetBase.<Test>d__36))]
	// RVA: 0x1F7B4C8 Offset: 0x1F774C8 VA: 0x1F7B4C8
	private IEnumerator Test(Action callback) { }

	// RVA: 0x1F7B76C Offset: 0x1F7776C VA: 0x1F7B76C
	private void Test2(bool isActor, PlayerDataManager playerDataManager) { }

	// RVA: 0x1F7A750 Offset: 0x1F76750 VA: 0x1F7A750
	protected void .ctor() { }
}
