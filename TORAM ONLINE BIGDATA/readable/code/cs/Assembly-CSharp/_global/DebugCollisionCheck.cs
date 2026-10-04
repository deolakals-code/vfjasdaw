// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DebugCollisionCheck : MonoBehaviour // TypeDefIndex: 1766
{
	// Fields
	private DebugCollisionManager.CollisionNumber number; // 0x20
	private GameObject clone; // 0x28
	private bool isDestroy; // 0x30
	private MeshCollider meshCollider; // 0x38
	private Mesh debugMesh; // 0x40

	// Properties
	public bool IsDestroy { set; }
	public Mesh DebugMesh { set; }

	// Methods

	// RVA: 0x20CD374 Offset: 0x20C9374 VA: 0x20CD374
	public void set_IsDestroy(bool value) { }

	// RVA: 0x20CD380 Offset: 0x20C9380 VA: 0x20CD380
	public void set_DebugMesh(Mesh value) { }

	// RVA: 0x20CD388 Offset: 0x20C9388 VA: 0x20CD388
	private void OnDestroy() { }

	// RVA: 0x20CD5D8 Offset: 0x20C95D8 VA: 0x20CD5D8
	private void Update() { }

	// RVA: 0x20CD9A0 Offset: 0x20C99A0 VA: 0x20CD9A0
	public void Initialize(DebugCollisionManager.CollisionNumber number, GameObject clone, Mesh colMesh) { }

	// RVA: 0x20CDA44 Offset: 0x20C9A44 VA: 0x20CDA44
	public void .ctor() { }
}
