// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DebugCollisionManager : Singleton<DebugCollisionManager>, ISceneChangeManager // TypeDefIndex: 1772
{
	// Fields
	private const string managerObjectName = "DebugCollisionManager";
	private const float checkInterval = 0.5;
	private DebugCollisionManager.ViewCollision[] viewCollision; // 0x20
	private float checkTimer; // 0x28

	// Methods

	// RVA: 0x20CDA4C Offset: 0x20C9A4C VA: 0x20CDA4C
	public static void CreateDebugCollisionManager() { }

	// RVA: 0x20CDAE4 Offset: 0x20C9AE4 VA: 0x20CDAE4 Slot: 4
	public void OnEnter() { }

	// RVA: 0x20CDD6C Offset: 0x20C9D6C VA: 0x20CDD6C Slot: 5
	public void OnLeave() { }

	// RVA: 0x20CDDA0 Offset: 0x20C9DA0 VA: 0x20CDDA0
	private void Awake() { }

	// RVA: 0x20CDEE0 Offset: 0x20C9EE0 VA: 0x20CDEE0
	private void Start() { }

	// RVA: 0x20CDF40 Offset: 0x20C9F40 VA: 0x20CDF40
	private void OnDestroy() { }

	// RVA: 0x20CE228 Offset: 0x20CA228 VA: 0x20CE228
	private void Update() { }

	// RVA: 0x20CE4DC Offset: 0x20CA4DC VA: 0x20CE4DC
	public void Add(MeshCollider collider) { }

	// RVA: 0x20CD794 Offset: 0x20C9794 VA: 0x20CD794
	public void Renew(DebugCollisionCheck check, MeshCollider collider, DebugCollisionManager.CollisionNumber number) { }

	// RVA: 0x20CD4A8 Offset: 0x20C94A8 VA: 0x20CD4A8
	public void Destroy(MeshCollider collider, DebugCollisionManager.CollisionNumber number) { }

	// RVA: 0x20CF050 Offset: 0x20CB050 VA: 0x20CF050
	public void ButtonAction(DebugCollisionManager.CollisionNumber number) { }

	// RVA: 0x20CDF44 Offset: 0x20C9F44 VA: 0x20CDF44
	private void ClearCollision() { }

	// RVA: 0x20CEEF8 Offset: 0x20CAEF8 VA: 0x20CEEF8
	private int[] MakeIndices(int[] triangles) { }

	// RVA: 0x20CE7F8 Offset: 0x20CA7F8 VA: 0x20CE7F8
	private bool LayerToNumber(int layer, out DebugCollisionManager.CollisionNumber number) { }

	// RVA: 0x20CE8C4 Offset: 0x20CA8C4 VA: 0x20CE8C4
	private bool Contains(DebugCollisionManager.CollisionNumber number, MeshCollider collider) { }

	// RVA: 0x20CE31C Offset: 0x20CA31C VA: 0x20CE31C
	private void CheckAddCollision(int[] layers) { }

	// RVA: 0x20CE94C Offset: 0x20CA94C VA: 0x20CE94C
	private GameObject CreateClone(MeshCollider collider, DebugCollisionManager.CollisionNumber number) { }

	// RVA: 0x20CF74C Offset: 0x20CB74C VA: 0x20CF74C
	private void CreateGrid(Vector3 pos, Vector3 grid) { }

	// RVA: 0x20CDC60 Offset: 0x20C9C60 VA: 0x20CDC60
	private void AddMapCollider() { }

	// RVA: 0x20CFEE0 Offset: 0x20CBEE0 VA: 0x20CFEE0
	public void .ctor() { }
}
