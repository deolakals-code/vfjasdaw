// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class CaptureManager : Singleton<CaptureManager>, ISceneChangeManager // TypeDefIndex: 1177
{
	// Fields
	private List<CaptureTargetBase> targetList; // 0x20

	// Properties
	public bool IsCapture { get; }

	// Methods

	// RVA: 0x1F79208 Offset: 0x1F75208 VA: 0x1F79208
	public bool get_IsCapture() { }

	// RVA: 0x1F79258 Offset: 0x1F75258 VA: 0x1F79258
	public void Clear() { }

	// RVA: 0x1F793E4 Offset: 0x1F753E4 VA: 0x1F793E4
	public void Remove(CaptureTargetBase capt) { }

	// RVA: 0x1F79460 Offset: 0x1F75460 VA: 0x1F79460
	public bool TryGetTargetGauge(int mobUId, out ICaptureTimer target) { }

	// RVA: 0x1F79564 Offset: 0x1F75564 VA: 0x1F79564
	public bool TryGetTarget(int mobUId, out CaptureTargetBase target) { }

	// RVA: 0x1F79668 Offset: 0x1F75668 VA: 0x1F79668
	public bool CheckCaptureEnable(EnemyMobActionManagerBase target, PlayerActionManagerBase player, IList<ItemData> itemList, out int popLabel) { }

	// RVA: 0x1F797C0 Offset: 0x1F757C0 VA: 0x1F797C0
	public CaptureTargetBase CreateCaptureTarget(EnemyMobActionManagerBase target, PlayerActionManagerBase player) { }

	// RVA: 0x1F79A18 Offset: 0x1F75A18 VA: 0x1F79A18
	public CaptureTargetBase CreateCaptureTarget(EnemyMobActionManagerBase target, PlayerActionManagerBase player, CaptureStartEvent captureStart) { }

	// RVA: 0x1F79944 Offset: 0x1F75944 VA: 0x1F79944
	private bool StartCapture(CaptureTargetBase target, PlayerActionManagerBase player) { }

	[IteratorStateMachine(typeof(CaptureManager.<UpdateCaptureTarget>d__11))]
	// RVA: 0x1F79BB8 Offset: 0x1F75BB8 VA: 0x1F79BB8
	private IEnumerator UpdateCaptureTarget(CaptureTargetBase newTarget) { }

	// RVA: 0x1F79C68 Offset: 0x1F75C68 VA: 0x1F79C68 Slot: 4
	public void OnEnter() { }

	// RVA: 0x1F79C6C Offset: 0x1F75C6C VA: 0x1F79C6C Slot: 5
	public void OnLeave() { }

	// RVA: 0x1F79DC4 Offset: 0x1F75DC4 VA: 0x1F79DC4
	public void .ctor() { }
}
