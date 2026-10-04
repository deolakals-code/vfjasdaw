// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MergeFieldObject // TypeDefIndex: 3983
{
	// Fields
	private const int UNITY_MAX_VERTICES = 60000;
	private List<GameObject> objectLayer; // 0x10
	private Dictionary<string, MergeFieldObject.MergeObject> subMeshList; // 0x18
	private MeshCollider floorColLayer; // 0x20
	private List<Vector3> vertFloorList; // 0x28
	private List<Vector2> uvFloorList; // 0x30
	private List<int> trianglesFloorList; // 0x38
	private int floorOffset; // 0x40
	private MeshCollider wallColLayer; // 0x48
	private List<Vector3> vertWallList; // 0x50
	private List<Vector2> uvWallList; // 0x58
	private List<int> trianglesWallList; // 0x60
	private int wallOffset; // 0x68
	private MeshCollider wallSubColLayer; // 0x70
	private List<Vector3> vertSubWallList; // 0x78
	private List<Vector2> uvSubWallList; // 0x80
	private List<int> trianglesSubWallList; // 0x88
	private int wallSubOffset; // 0x90
	private AnimationClip[] addAnimationClip; // 0x98
	private GameObject cameraWall; // 0xA0
	private GameObject cameraFloor; // 0xA8
	private MeshCollider cameraColLayer; // 0xB0
	private List<Vector3> vertCameraList; // 0xB8
	private List<Vector2> uvCameraList; // 0xC0
	private List<int> trianglesCameraList; // 0xC8
	private int cameraOffset; // 0xD0
	private Transform parentTrans; // 0xD8

	// Methods

	// RVA: 0x242C4A4 Offset: 0x24284A4 VA: 0x242C4A4
	public void .ctor(Transform parentTrans, AnimationClip[] clip) { }

	// RVA: 0x242CA58 Offset: 0x2428A58 VA: 0x242CA58
	public void .ctor(Transform parentTrans, AnimationClip[] clip, bool isNonCollider) { }

	// RVA: 0x242CF0C Offset: 0x2428F0C VA: 0x242CF0C
	public void EnabledSubWall(bool isEnabled) { }

	// RVA: 0x242CFA4 Offset: 0x2428FA4 VA: 0x242CFA4
	public void Clear() { }

	// RVA: 0x242D3D8 Offset: 0x24293D8 VA: 0x242D3D8
	public int SetMapChipObject(GameObject model, Vector3 addVertex, int rot) { }

	// RVA: 0x242D3F0 Offset: 0x24293F0 VA: 0x242D3F0
	public int SetMapChipObject(GameObject model, Vector3 addVertex, int rot, bool isNormal) { }

	// RVA: 0x242E574 Offset: 0x242A574 VA: 0x242E574
	public int SetMapChipMehs(Mesh mesh, string[] materialNames) { }

	// RVA: 0x242E998 Offset: 0x242A998 VA: 0x242E998
	public void SetFloorColChipObject(Mesh mesh, Vector3 addVertex, int rot) { }

	// RVA: 0x242EF24 Offset: 0x242AF24 VA: 0x242EF24
	public void SetFloorColChipObject(Mesh mesh, Vector3 addVertex, int rot, float uv) { }

	// RVA: 0x242EF58 Offset: 0x242AF58 VA: 0x242EF58
	public void SetWallColChipObject(Mesh mesh, Vector3 addVertex, int rot) { }

	// RVA: 0x242EF94 Offset: 0x242AF94 VA: 0x242EF94
	public void SetSubWallColChipObject(Mesh mesh, Vector3 addVertex, int rot) { }

	// RVA: 0x242EFD0 Offset: 0x242AFD0 VA: 0x242EFD0
	public void SetCameraColChipObject(Mesh mesh, Vector3 addVertex, int rot) { }

	// RVA: 0x242E9D4 Offset: 0x242A9D4 VA: 0x242E9D4
	private int SetColChipObject(Mesh mesh, Vector3 addVertex, int rot, List<Vector3> vertices, List<Vector2> uv, List<int> triangle, int offset, float uvCol) { }

	// RVA: 0x242F00C Offset: 0x242B00C VA: 0x242F00C
	public void CreateModel() { }

	// RVA: 0x242C924 Offset: 0x2428924 VA: 0x242C924
	private GameObject CreateGameObject(string name) { }

	// RVA: 0x242F5AC Offset: 0x242B5AC VA: 0x242F5AC
	private Mesh MeshCreate(List<Vector3> vert, List<Vector2> uv, List<int> triangles) { }
}
