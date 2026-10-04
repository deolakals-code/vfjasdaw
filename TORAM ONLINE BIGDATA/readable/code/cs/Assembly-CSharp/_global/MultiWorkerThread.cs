// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MultiWorkerThread : MonoBehaviour, IWorkerThread // TypeDefIndex: 5608
{
	// Fields
	[SerializeField]
	private int ThreadNum; // 0x20
	private MultiWorkerThread.ThreadManager[] threadArray; // 0x28
	private Queue<Action> actionList; // 0x30

	// Methods

	// RVA: 0x17A5814 Offset: 0x17A1814 VA: 0x17A5814
	private void Awake() { }

	// RVA: 0x17A5A10 Offset: 0x17A1A10 VA: 0x17A5A10
	private void OnApplicationQuit() { }

	// RVA: 0x17A5DE8 Offset: 0x17A1DE8 VA: 0x17A5DE8
	public void OnDestroy() { }

	// RVA: 0x17A5E70 Offset: 0x17A1E70 VA: 0x17A5E70
	public void Update() { }

	// RVA: 0x17A5FEC Offset: 0x17A1FEC VA: 0x17A5FEC Slot: 5
	public void AddMainThreadAction(Action action) { }

	// RVA: 0x17A60EC Offset: 0x17A20EC VA: 0x17A60EC Slot: 4
	public CustomYieldInstruction AddTask(ITask task) { }

	// RVA: 0x17A6554 Offset: 0x17A2554 VA: 0x17A6554
	private void ForcedEnd() { }

	// RVA: 0x17A65B0 Offset: 0x17A25B0 VA: 0x17A65B0
	public void .ctor() { }
}
