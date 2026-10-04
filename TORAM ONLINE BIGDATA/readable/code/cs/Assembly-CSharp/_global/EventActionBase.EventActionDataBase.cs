// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EventActionBase.EventActionDataBase // TypeDefIndex: 3814
{
	// Fields
	protected Transform controlObject; // 0x10
	private TakeController takeController; // 0x18
	private CharacterMove characterMove; // 0x20
	protected EventActionBase eventActionBase; // 0x28
	protected float timer; // 0x30
	protected bool playEndMotion; // 0x34
	protected bool selfPlayer; // 0x35
	private int takeUid; // 0x38

	// Properties
	public GameObject ControlObject { get; }
	public TakeController TakeController { get; }
	public CharacterMove CharacterMove { get; }
	public int ConnectId { get; }
	public bool IsCameraLock { get; }

	// Methods

	// RVA: 0x23EBD60 Offset: 0x23E7D60 VA: 0x23EBD60
	public GameObject get_ControlObject() { }

	// RVA: 0x23EBDE8 Offset: 0x23E7DE8 VA: 0x23EBDE8
	public TakeController get_TakeController() { }

	// RVA: 0x23EBECC Offset: 0x23E7ECC VA: 0x23EBECC
	public CharacterMove get_CharacterMove() { }

	// RVA: 0x23EBFB0 Offset: 0x23E7FB0 VA: 0x23EBFB0
	public int get_ConnectId() { }

	// RVA: 0x23EC030 Offset: 0x23E8030 VA: 0x23EC030
	public bool get_IsCameraLock() { }

	// RVA: 0x23EB7B0 Offset: 0x23E77B0 VA: 0x23EB7B0
	public bool Initialize(GameObject obj, EventActionBase eventAction) { }

	// RVA: 0x23EC0B8 Offset: 0x23E80B8 VA: 0x23EC0B8
	public bool Update() { }

	// RVA: 0x23EC494 Offset: 0x23E8494 VA: 0x23EC494 Slot: 4
	protected virtual Vector3 MoveAction() { }

	// RVA: 0x23EC4BC Offset: 0x23E84BC VA: 0x23EC4BC Slot: 5
	protected virtual Quaternion RotationAction(Vector3 position) { }

	// RVA: 0x23EC694 Offset: 0x23E8694 VA: 0x23EC694 Slot: 6
	protected virtual void CameraAction(Vector3 position, Quaternion rot) { }

	// RVA: 0x23EC758 Offset: 0x23E8758 VA: 0x23EC758 Slot: 7
	public virtual void Skip() { }

	// RVA: 0x23EC75C Offset: 0x23E875C VA: 0x23EC75C Slot: 8
	public virtual void Clear() { }

	// RVA: 0x23E9238 Offset: 0x23E5238 VA: 0x23E9238
	public void .ctor() { }
}
