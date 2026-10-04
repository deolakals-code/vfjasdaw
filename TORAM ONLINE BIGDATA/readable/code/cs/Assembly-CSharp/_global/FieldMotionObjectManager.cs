// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldMotionObjectManager : Singleton<FieldMotionObjectManager>, ISceneChangeManager // TypeDefIndex: 3929
{
	// Fields
	private Dictionary<int, LinkAnimationObject> eventAnimationList; // 0x20
	private Dictionary<GameObject, int> eventObjectList; // 0x28
	private List<int> lockAnimationId; // 0x30

	// Methods

	// RVA: 0x241379C Offset: 0x240F79C VA: 0x241379C
	private void Start() { }

	// RVA: 0x24137F4 Offset: 0x240F7F4 VA: 0x24137F4
	public void AddEventAnimation(int id, LinkAnimationObject eventAnimation) { }

	// RVA: 0x24138C0 Offset: 0x240F8C0 VA: 0x24138C0
	public void RemoveEventAnimation(int id) { }

	// RVA: 0x2413918 Offset: 0x240F918 VA: 0x2413918
	public bool CheckLockEvent(int id) { }

	// RVA: 0x2413970 Offset: 0x240F970 VA: 0x2413970
	public void EndEventAnimation(int id) { }

	// RVA: 0x2413B08 Offset: 0x240FB08 VA: 0x2413B08
	public void EndEventAnimation(GameObject model) { }

	// RVA: 0x2413B84 Offset: 0x240FB84 VA: 0x2413B84
	public bool StartEventAnimation(int id, GameObject model, bool movePos, bool man) { }

	// RVA: 0x2413B94 Offset: 0x240FB94 VA: 0x2413B94
	public bool StartEventAnimation(int id, GameObject model, bool movePos, bool man, bool sendPos) { }

	// RVA: 0x2413F68 Offset: 0x240FF68 VA: 0x2413F68 Slot: 4
	public void OnEnter() { }

	// RVA: 0x2414134 Offset: 0x2410134 VA: 0x2414134 Slot: 5
	public void OnLeave() { }

	// RVA: 0x2414364 Offset: 0x2410364 VA: 0x2414364
	public void .ctor() { }
}
