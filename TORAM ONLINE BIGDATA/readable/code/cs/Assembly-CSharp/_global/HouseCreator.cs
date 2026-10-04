// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseCreator : MonoBehaviour // TypeDefIndex: 3938
{
	// Fields
	[SerializeField]
	private MyHomeParts groundModel; // 0x20
	[SerializeField]
	private MyHomeParts backgroundModel; // 0x28
	[SerializeField]
	private MyHomeParts lockgroundModel; // 0x30
	private HousePartitionManager partitionManager; // 0x38
	private float roofAlpha; // 0x40
	private Dictionary<HousePartsModelType, MyHomeParts> partsModel; // 0x48
	private List<GameObject> houseObject; // 0x50
	private MergeFieldObject fieldObject; // 0x58
	private Transform player; // 0x60
	private Transform playerCamera; // 0x68
	private float roofHeight; // 0x70
	private float floorHeight; // 0x74
	private Vector3 point; // 0x78
	private Vector3 partitionSize; // 0x84
	private Vector3 areaSize; // 0x90
	private Texture2D shadowTex; // 0xA0

	// Methods

	// RVA: 0x241868C Offset: 0x241468C VA: 0x241868C
	private void Awake() { }

	// RVA: 0x24186C0 Offset: 0x24146C0 VA: 0x24186C0
	public bool CreateArea(byte floorHeight, Vector3 pointData, Vector3 size, Dictionary<HousePartsModelType, GameObject> modelList) { }

	// RVA: 0x241E294 Offset: 0x241A294 VA: 0x241E294
	public Texture GetFloorTxture() { }

	// RVA: 0x241E29C Offset: 0x241A29C VA: 0x241E29C
	public Texture GetGroundTxture() { }

	// RVA: 0x241C59C Offset: 0x241859C VA: 0x241C59C
	private Texture GetTexture(HousePartsModelType type) { }

	// RVA: 0x241C6F8 Offset: 0x24186F8 VA: 0x241C6F8
	private void SetTexture(HousePartsModelType type, Texture setTexture, string text) { }

	// RVA: 0x241C8C4 Offset: 0x24188C4 VA: 0x241C8C4
	private void SetVector4(HousePartsModelType type, Vector4 setVector4, string text) { }

	// RVA: 0x241CAB8 Offset: 0x2418AB8 VA: 0x241CAB8
	private void SetFloat(HousePartsModelType type, float setFloat, string text) { }

	// RVA: 0x241E2A4 Offset: 0x241A2A4 VA: 0x241E2A4
	public void EnabledSubWall(bool isEnabled) { }

	// RVA: 0x241E2BC Offset: 0x241A2BC VA: 0x241E2BC
	private bool IsNormalCreate(HousePartsModelType type) { }

	// RVA: 0x241D688 Offset: 0x2419688 VA: 0x241D688
	private bool BuyAreaCreate(int x, int z, Vector3 panelSize, Vector3 pos) { }

	// RVA: 0x241CC84 Offset: 0x2418C84 VA: 0x241CC84
	private void RoomCreate(int chipId, Vector3 pos, byte[] floorData) { }

	// RVA: 0x241C36C Offset: 0x241836C VA: 0x241C36C
	private void AddHouseCreatePartsModel(HousePartsModelType type, Transform trans) { }

	// RVA: 0x241C410 Offset: 0x2418410 VA: 0x241C410
	private void AddHouseCreatePartsModel(HousePartsModelType type, GameObject model) { }

	// RVA: 0x241E710 Offset: 0x241A710 VA: 0x241E710
	private bool ListCheck(byte[] list, byte flag) { }

	// RVA: 0x241D61C Offset: 0x241961C VA: 0x241D61C
	private bool ListContains(byte[] list, byte flag) { }

	// RVA: 0x241E4D0 Offset: 0x241A4D0 VA: 0x241E4D0
	private void SetItemModel(HousePartsModelType type, Vector3 pos, int rot, float uvLight) { }

	// RVA: 0x241E950 Offset: 0x241A950 VA: 0x241E950
	private void SetItemModel(HousePartsModelType type, Vector3 pos, int rot, byte[] floorData) { }

	// RVA: 0x241E838 Offset: 0x241A838 VA: 0x241E838
	private void CreateItemModel(HousePartsModelType type, HousePartsModelType maskType, Vector3 pos, int rot) { }

	// RVA: 0x241E744 Offset: 0x241A744 VA: 0x241E744
	private void CreateItemModel(HousePartsModelType type, Vector3 pos, int rot) { }

	// RVA: 0x241F108 Offset: 0x241B108 VA: 0x241F108
	private void CreateItemModel(MyHomeParts mainItem, MyHomeParts maskItem, Vector3 pos, int rot) { }

	// RVA: 0x241E2E4 Offset: 0x241A2E4 VA: 0x241E2E4
	private Mesh CreateMesh(List<Vector3> vs, List<int> f) { }

	// RVA: 0x241E19C Offset: 0x241A19C VA: 0x241E19C
	private Mesh CreateMesh(List<Vector3> vs, List<Color> c, List<Vector2> uv, List<int> f) { }

	// RVA: 0x241F5E8 Offset: 0x241B5E8 VA: 0x241F5E8
	private void Update() { }

	// RVA: 0x241F858 Offset: 0x241B858 VA: 0x241F858
	public void .ctor() { }
}
