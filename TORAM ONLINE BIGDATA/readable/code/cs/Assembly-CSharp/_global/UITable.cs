// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Table")]
[ExecuteInEditMode]
public class UITable : UIWidgetContainer // TypeDefIndex: 58
{
	// Fields
	public int columns; // 0x20
	public UITable.Direction direction; // 0x24
	public bool sorted; // 0x28
	public bool hideInactive; // 0x29
	public bool keepWithinPanel; // 0x2A
	public bool repositionNow; // 0x2B
	public UITable.OnReposition onReposition; // 0x30
	public Vector2 padding; // 0x38
	private UIPanel mPanel; // 0x40
	private UIDraggablePanel mDrag; // 0x48
	private bool mStarted; // 0x50
	private List<Transform> mChildren; // 0x58

	// Properties
	public List<Transform> children { get; }

	// Methods

	// RVA: 0x17264AC Offset: 0x17224AC VA: 0x17264AC
	public static int SortByName(Transform a, Transform b) { }

	// RVA: 0x17264F4 Offset: 0x17224F4 VA: 0x17264F4
	public List<Transform> get_children() { }

	// RVA: 0x1726818 Offset: 0x1722818 VA: 0x1726818
	private void RepositionVariableSize(List<Transform> children) { }

	// RVA: 0x1726E8C Offset: 0x1722E8C VA: 0x1726E8C
	public void Reposition() { }

	// RVA: 0x172701C Offset: 0x172301C VA: 0x172701C
	private void Start() { }

	// RVA: 0x1727104 Offset: 0x1723104 VA: 0x1727104
	private void LateUpdate() { }

	// RVA: 0x1727118 Offset: 0x1723118 VA: 0x1727118
	public void .ctor() { }
}
