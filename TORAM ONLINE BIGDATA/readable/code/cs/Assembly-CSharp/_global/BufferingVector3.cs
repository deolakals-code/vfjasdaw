// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BufferingVector3 // TypeDefIndex: 1636
{
	// Fields
	private Transform targetTransform; // 0x10
	private List<Vector3> bufferingList; // 0x18
	private float acceptRange; // 0x20
	private Vector3 offset; // 0x24

	// Properties
	public string name { get; }
	public Vector3 position { get; }
	public GameObject gameObject { get; }
	public Transform sourceTransform { get; }

	// Methods

	// RVA: 0x209EFA4 Offset: 0x209AFA4 VA: 0x209EFA4
	public string get_name() { }

	// RVA: 0x209EFC0 Offset: 0x209AFC0 VA: 0x209EFC0
	public Vector3 get_position() { }

	// RVA: 0x209F044 Offset: 0x209B044 VA: 0x209F044
	public GameObject get_gameObject() { }

	// RVA: 0x209F060 Offset: 0x209B060 VA: 0x209F060
	public Transform get_sourceTransform() { }

	// RVA: 0x209F068 Offset: 0x209B068 VA: 0x209F068
	public void .ctor(Transform target) { }

	// RVA: 0x209F1C8 Offset: 0x209B1C8 VA: 0x209F1C8
	public void .ctor(Transform target, Vector3 offset) { }

	// RVA: 0x209F290 Offset: 0x209B290 VA: 0x209F290
	public void ReSetTarget(Transform target) { }

	// RVA: 0x209F29C Offset: 0x209B29C VA: 0x209F29C
	public void Clear() { }

	// RVA: 0x209F2EC Offset: 0x209B2EC VA: 0x209F2EC
	public bool MoveNext() { }

	// RVA: 0x209F4E0 Offset: 0x209B4E0 VA: 0x209F4E0
	public void SnapshotBuffering() { }

	// RVA: 0x209F140 Offset: 0x209B140 VA: 0x209F140
	private void Init(Transform target, Vector3 offset) { }

	[CompilerGenerated]
	// RVA: 0x209F784 Offset: 0x209B784 VA: 0x209F784
	private bool <SnapshotBuffering>b__17_0(Vector3 x) { }
}
