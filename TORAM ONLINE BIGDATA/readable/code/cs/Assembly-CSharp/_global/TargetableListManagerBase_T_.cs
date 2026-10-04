// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class TargetableListManagerBase<T> : MonoBehaviour // TypeDefIndex: 4652
{
	// Fields
	protected static T instance; // 0x0
	protected List<GameObject> itemList; // 0x0

	// Properties
	public static T Instance { get; }
	public ReadOnlyCollection<GameObject> Items { get; }
	public int ItemCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA4230 Offset: 0x2CA0230 VA: 0x2CA4230
	|-TargetableListManagerBase<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<GameObject> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA4478 Offset: 0x2CA0478 VA: 0x2CA4478
	|-TargetableListManagerBase<object>.get_Items
	*/

	// RVA: -1 Offset: -1
	public int get_ItemCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA44C8 Offset: 0x2CA04C8 VA: 0x2CA44C8
	|-TargetableListManagerBase<object>.get_ItemCount
	*/

	// RVA: -1 Offset: -1
	public bool ItemContains(GameObject item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA4510 Offset: 0x2CA0510 VA: 0x2CA4510
	|-TargetableListManagerBase<object>.ItemContains
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual void AddObject(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA4568 Offset: 0x2CA0568 VA: 0x2CA4568
	|-TargetableListManagerBase<object>.AddObject
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual List<GameObject> GetInCameraTargets(Vector3 pos, float rad, float height) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA4614 Offset: 0x2CA0614 VA: 0x2CA4614
	|-TargetableListManagerBase<object>.GetInCameraTargets
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual ValueTuple<GameObject, float> GetNearInCameraTarget(Vector3 pos, float rad, float height, GameObject exclusions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA49C8 Offset: 0x2CA09C8 VA: 0x2CA49C8
	|-TargetableListManagerBase<object>.GetNearInCameraTarget
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public virtual ValueTuple<GameObject, float> GetFarInCameraTarget(Vector3 pos, float rad, float height, GameObject exclusions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA4D64 Offset: 0x2CA0D64 VA: 0x2CA4D64
	|-TargetableListManagerBase<object>.GetFarInCameraTarget
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual GameObject GetNearTarget(Vector3 pos, float rad, float height) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5100 Offset: 0x2CA1100 VA: 0x2CA5100
	|-TargetableListManagerBase<object>.GetNearTarget
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5338 Offset: 0x2CA1338 VA: 0x2CA5338
	|-TargetableListManagerBase<object>..ctor
	*/
}
