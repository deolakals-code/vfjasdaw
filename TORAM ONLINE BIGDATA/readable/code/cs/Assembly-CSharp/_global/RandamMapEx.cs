// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("Iruna2/Render/RandamMapEx")]
public class RandamMapEx : RandamMapBase // TypeDefIndex: 3997
{
	// Fields
	private MergeFieldObject mergeFieldObject; // 0x70
	private byte[] mapData; // 0x78
	private readonly int[] rootWall; // 0x80
	[SerializeField]
	private Vector3 mapBlock; // 0x88
	[SerializeField]
	private float outR; // 0x94
	[SerializeField]
	private int backgroundNum; // 0x98
	[SerializeField]
	private BaseRoomModel[] roomModel; // 0xA0
	[SerializeField]
	private BaseRootModel[] rootModel; // 0xA8
	[SerializeField]
	private AnimationClip[] addAnimationClip; // 0xB0
	private GameObject cameraWall; // 0xB8
	private GameObject cameraFloor; // 0xC0
	[SerializeField]
	private GameObject[] mapBackgroundObject; // 0xC8
	[SerializeField]
	private GameObject backgroundObjectParent; // 0xD0
	private List<GameObject> objectLayer; // 0xD8
	private Color32[] pixel; // 0xE0
	private int miniMapWidth; // 0xE8
	private int miniMapHeight; // 0xEC

	// Methods

	// RVA: 0x246AAF8 Offset: 0x2466AF8 VA: 0x246AAF8
	private void Start() { }

	// RVA: 0x246ACEC Offset: 0x2466CEC VA: 0x246ACEC
	private void EnabledMeshRender(GameObject obj) { }

	// RVA: 0x246ADB8 Offset: 0x2466DB8 VA: 0x246ADB8 Slot: 4
	protected override void RandamCreate(byte[] roomChipList) { }

	// RVA: 0x246BFF8 Offset: 0x2467FF8 VA: 0x246BFF8
	private int BitSearch(int bit, int nomber, int max) { }

	// RVA: 0x246C038 Offset: 0x2468038 VA: 0x246C038
	private int VecMoveRoot(int root, int add) { }

	// RVA: 0x246C050 Offset: 0x2468050 VA: 0x246C050
	private byte MapId(byte chipData) { }

	// RVA: 0x246C058 Offset: 0x2468058 VA: 0x246C058
	private byte MapType(byte chipData) { }

	// RVA: 0x246C060 Offset: 0x2468060 VA: 0x246C060
	private byte MapRot(byte chipData) { }

	// RVA: 0x246C068 Offset: 0x2468068 VA: 0x246C068
	private byte MapChipData(int id, int type, int rot) { }

	// RVA: 0x246C078 Offset: 0x2468078 VA: 0x246C078
	private int[] RoomPositionCreate() { }

	// RVA: 0x246C364 Offset: 0x2468364 VA: 0x246C364 Slot: 5
	public override Vector3 GetMapChipPosition(byte mapChipId, float y) { }

	// RVA: 0x246AF90 Offset: 0x2466F90 VA: 0x246AF90
	private Vector2 RandomMapCreate(byte[] roomId) { }

	// RVA: 0x246C738 Offset: 0x2468738 VA: 0x246C738
	private void SetMiniMapChip(Texture2D tex, int rot, int x, int y) { }

	// RVA: 0x246B610 Offset: 0x2467610 VA: 0x246B610
	private void MapModelMerge() { }

	// RVA: 0x246C3B0 Offset: 0x24683B0 VA: 0x246C3B0
	private void BackgroundObject(int minX, int maxX, int minY, int maxY) { }

	// RVA: 0x246C984 Offset: 0x2468984 VA: 0x246C984
	public void .ctor() { }
}
