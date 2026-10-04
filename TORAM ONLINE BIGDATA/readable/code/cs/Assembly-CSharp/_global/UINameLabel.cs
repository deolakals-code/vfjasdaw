// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINameLabel : MonoBehaviour // TypeDefIndex: 9009
{
	// Fields
	[CompilerGenerated]
	private Transform <TraceObject>k__BackingField; // 0x20
	private Renderer[] traceObjectRenderers; // 0x28
	private ModelObjectBase traceObjectModel; // 0x30
	[SerializeField]
	private BoxCollider tapCollider; // 0x38
	protected float size; // 0x40
	protected float colSize; // 0x44
	protected TargetManager.TargetType targetType; // 0x48
	[SerializeField]
	protected GameObject nameObject; // 0x50
	protected IUILabel nameLabel; // 0x58
	private IUILabel[] selfAllLables; // 0x60
	protected bool tapEnabled; // 0x68
	protected PlayerDataManager playerDataManager; // 0x70
	protected float radLimit; // 0x78
	private bool top; // 0x7C
	protected UIGLLabel clickLabel; // 0x80

	// Properties
	public Transform TraceObject { get; set; }
	private bool IsVisibleTraceObject { get; }
	protected BoxCollider TapCollider { get; }
	protected virtual bool ActiveFlag { get; }
	public virtual bool IsEnabled { get; }
	protected virtual bool IsCorrectPosInView { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E902D8 Offset: 0x1E8C2D8 VA: 0x1E902D8
	protected void set_TraceObject(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x1E902E0 Offset: 0x1E8C2E0 VA: 0x1E902E0
	public Transform get_TraceObject() { }

	// RVA: 0x1E902E8 Offset: 0x1E8C2E8 VA: 0x1E902E8
	private bool get_IsVisibleTraceObject() { }

	// RVA: 0x1E90404 Offset: 0x1E8C404 VA: 0x1E90404
	protected BoxCollider get_TapCollider() { }

	// RVA: 0x1E9040C Offset: 0x1E8C40C VA: 0x1E9040C Slot: 4
	protected virtual bool get_ActiveFlag() { }

	// RVA: 0x1E90414 Offset: 0x1E8C414 VA: 0x1E90414 Slot: 5
	public virtual bool get_IsEnabled() { }

	// RVA: 0x1E9041C Offset: 0x1E8C41C VA: 0x1E9041C Slot: 6
	protected virtual bool get_IsCorrectPosInView() { }

	// RVA: 0x1E90424 Offset: 0x1E8C424 VA: 0x1E90424
	protected void SetTapCollider(BoxCollider collider) { }

	// RVA: 0x1E8A698 Offset: 0x1E86698 VA: 0x1E8A698
	public void Initialize(Transform traceObject, float size, string name, TargetManager.TargetType targetType, bool topPosition) { }

	// RVA: 0x1E9042C Offset: 0x1E8C42C VA: 0x1E9042C
	public bool PositionUpdate(float dist, Plane[] planes) { }

	// RVA: 0x1E90BD4 Offset: 0x1E8CBD4 VA: 0x1E90BD4 Slot: 7
	protected virtual bool GetLabelChange() { }

	// RVA: 0x1E90BDC Offset: 0x1E8CBDC VA: 0x1E90BDC Slot: 8
	protected virtual void StatusUpdate() { }

	// RVA: 0x1E90BE0 Offset: 0x1E8CBE0 VA: 0x1E90BE0 Slot: 9
	protected virtual void OnClick() { }

	// RVA: 0x1E90E4C Offset: 0x1E8CE4C VA: 0x1E90E4C
	protected void CreateClickLabel(float posY = 35) { }

	// RVA: 0x1E8E514 Offset: 0x1E8A514 VA: 0x1E8E514
	public void .ctor() { }
}
