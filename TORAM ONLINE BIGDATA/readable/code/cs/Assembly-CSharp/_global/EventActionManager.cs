// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EventActionManager : Singleton<EventActionManager>, ISceneChangeManager // TypeDefIndex: 3816
{
	// Fields
	private Dictionary<GameObject, EventActionBase.EventActionDataBase> actionList; // 0x20
	private Dictionary<int, EventActionBase> eventActionList; // 0x28
	private List<int> lockActionId; // 0x30
	private GameObject playerObject; // 0x38

	// Properties
	public bool IsPlayerEvent { get; }
	public bool IsPlayerEventCameraLock { get; }

	// Methods

	// RVA: 0x23EC8FC Offset: 0x23E88FC VA: 0x23EC8FC
	public bool get_IsPlayerEvent() { }

	// RVA: 0x23EC974 Offset: 0x23E8974 VA: 0x23EC974
	public bool get_IsPlayerEventCameraLock() { }

	// RVA: 0x23ECA78 Offset: 0x23E8A78 VA: 0x23ECA78
	private void Start() { }

	// RVA: 0x23ECAD0 Offset: 0x23E8AD0 VA: 0x23ECAD0
	private void AddEventList(EventActionBase[] eventAction, bool allCheck) { }

	// RVA: 0x23ECBE0 Offset: 0x23E8BE0 VA: 0x23ECBE0
	public void AddEventAction(int id, EventActionBase eventAction) { }

	// RVA: 0x23EB6B4 Offset: 0x23E76B4 VA: 0x23EB6B4
	public void RemoveEventAction(int id) { }

	// RVA: 0x23ECCAC Offset: 0x23E8CAC VA: 0x23ECCAC
	public void StartEventAction(int id, GameObject moveObject) { }

	// RVA: 0x23ECE18 Offset: 0x23E8E18 VA: 0x23ECE18
	public bool CheckEventActionObject(GameObject obj) { }

	// RVA: 0x23ECE70 Offset: 0x23E8E70 VA: 0x23ECE70
	public void EventActionLock(int id, bool lockFlag) { }

	// RVA: 0x23ED1C8 Offset: 0x23E91C8 VA: 0x23ED1C8
	public void FocusActionEnd(GameObject obj) { }

	// RVA: 0x23ED340 Offset: 0x23E9340 VA: 0x23ED340 Slot: 4
	public void OnEnter() { }

	// RVA: 0x23ED4A8 Offset: 0x23E94A8 VA: 0x23ED4A8 Slot: 5
	public void OnLeave() { }

	// RVA: 0x23ED80C Offset: 0x23E980C VA: 0x23ED80C
	private void Update() { }

	// RVA: 0x23EDCC8 Offset: 0x23E9CC8 VA: 0x23EDCC8
	public void .ctor() { }
}
