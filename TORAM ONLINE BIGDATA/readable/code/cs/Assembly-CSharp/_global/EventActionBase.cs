// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class EventActionBase : MonoBehaviour // TypeDefIndex: 3815
{
	// Fields
	[SerializeField]
	protected int actionId; // 0x20
	[SerializeField]
	protected int connectId; // 0x24
	private GameObject eventArea; // 0x28
	[SerializeField]
	protected Vector3 eventAreaSize; // 0x30
	[SerializeField]
	protected float moveTime; // 0x3C
	[SerializeField]
	protected AnimationCurve animationCurve; // 0x40
	[SerializeField]
	protected int startMotion; // 0x48
	[SerializeField]
	protected int loopMotion; // 0x4C
	[SerializeField]
	protected float startEndMotionTime; // 0x50
	[SerializeField]
	protected int endMotion; // 0x54
	[SerializeField]
	protected EventActionBase.BitFlag bitFlag; // 0x58
	[SerializeField]
	protected EventActionBase.CameraType cameraType; // 0x5C
	[SerializeField]
	protected Vector3 cameraParam; // 0x60
	[SerializeField]
	protected EventActionBase.RotationType rotationType; // 0x6C
	[SerializeField]
	protected Vector3 rotParam; // 0x70
	[SerializeField]
	protected Vector3 startPosition; // 0x7C
	[SerializeField]
	protected Vector3 endPosition; // 0x88
	private GameObject effectModel; // 0x98

	// Properties
	public int ActionId { get; }
	protected bool autoCreateEventArea { get; }
	protected bool misalignmentCheck { get; }
	protected bool fieldCollCheck { get; }
	protected bool walkStartPosition { get; }
	protected bool effectPopUp { get; }
	protected bool tapAction { get; }
	protected bool autoStart { get; }
	public bool IsCameraLock { get; }

	// Methods

	// RVA: 0x23EAC88 Offset: 0x23E6C88 VA: 0x23EAC88
	public int get_ActionId() { }

	// RVA: 0x23EAC90 Offset: 0x23E6C90 VA: 0x23EAC90
	protected bool get_autoCreateEventArea() { }

	// RVA: 0x23E8EBC Offset: 0x23E4EBC VA: 0x23E8EBC
	protected bool get_misalignmentCheck() { }

	// RVA: 0x23EAC9C Offset: 0x23E6C9C VA: 0x23EAC9C
	protected bool get_fieldCollCheck() { }

	// RVA: 0x23EACA8 Offset: 0x23E6CA8 VA: 0x23EACA8
	protected bool get_walkStartPosition() { }

	// RVA: 0x23EACB4 Offset: 0x23E6CB4 VA: 0x23EACB4
	protected bool get_effectPopUp() { }

	// RVA: 0x23EACC0 Offset: 0x23E6CC0 VA: 0x23EACC0
	protected bool get_tapAction() { }

	// RVA: 0x23EACCC Offset: 0x23E6CCC VA: 0x23EACCC
	protected bool get_autoStart() { }

	// RVA: 0x23EACD8 Offset: 0x23E6CD8 VA: 0x23EACD8
	public bool get_IsCameraLock() { }

	// RVA: 0x23EACE8 Offset: 0x23E6CE8 VA: 0x23EACE8
	private void Start() { }

	// RVA: 0x23EACEC Offset: 0x23E6CEC VA: 0x23EACEC
	public void AddEventArea() { }

	// RVA: 0x23EAF68 Offset: 0x23E6F68 VA: 0x23EAF68
	private void SetEffect(GameObject model) { }

	// RVA: 0x23EB2A8 Offset: 0x23E72A8 VA: 0x23EB2A8
	public void ClearEventArea() { }

	// RVA: 0x23EB608 Offset: 0x23E7608 VA: 0x23EB608
	private void OnDestroy() { }

	// RVA: 0x23EB70C Offset: 0x23E770C VA: 0x23EB70C
	public EventActionBase.EventActionDataBase AddEvent(GameObject obj) { }

	// RVA: 0x23EB9D0 Offset: 0x23E79D0 VA: 0x23EB9D0 Slot: 4
	protected virtual EventActionBase.EventActionDataBase AddActionEvent(GameObject obj) { }

	// RVA: 0x23EB9D8 Offset: 0x23E79D8 VA: 0x23EB9D8
	public TakeClip GetTakeClip() { }

	// RVA: 0x23E8FA0 Offset: 0x23E4FA0 VA: 0x23E8FA0
	protected void .ctor() { }
}
