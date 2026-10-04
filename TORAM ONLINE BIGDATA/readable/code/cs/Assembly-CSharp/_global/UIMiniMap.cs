// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMiniMap : MonoBehaviour // TypeDefIndex: 6543
{
	// Fields
	[SerializeField]
	private UIAtlas miniAtlas; // 0x20
	[SerializeField]
	private Camera currentCamera; // 0x28
	private Material iconMaterial; // 0x30
	private Material material; // 0x38
	private Shader shader; // 0x40
	private Texture minimapTexture; // 0x48
	private Rect uvRect; // 0x50
	private Rect playerUV; // 0x60
	private Rect cameraUV; // 0x70
	private Rect pointUV; // 0x80
	private Vector3 playerFVec; // 0x90
	private Vector3 playerRVec; // 0x9C
	private Vector3 cameraFVec; // 0xA8
	private Vector3 cameraRVec; // 0xB4
	private float cameraAlpha; // 0xC0
	private List<MiniMapBaseData> minimapPointData; // 0xC8
	private List<MiniMapBaseData> minimapPointRemoveData; // 0xD0
	[SerializeField]
	private Texture[] minimapTextureList; // 0xD8
	private Vector2 rectMiniMap; // 0xE0
	private Vector2 miniMapScale; // 0xE8
	private float miniMapMaskSize; // 0xF0
	private Texture2D[] minimapMaskTextureList; // 0xF8
	private OptionsGraphics optionsGraphics; // 0x100
	private GameObject player; // 0x108
	private Vector3 savePlayerPosition; // 0x110
	private Transform mainCamera; // 0x120
	private float oldRot; // 0x128
	private int miniMapLevel; // 0x12C

	// Properties
	private Texture mainTexture { get; set; }
	public int MiniMapLevel { get; set; }

	// Methods

	// RVA: 0x1973914 Offset: 0x196F914 VA: 0x1973914
	private Texture get_mainTexture() { }

	// RVA: 0x197391C Offset: 0x196F91C VA: 0x197391C
	private void set_mainTexture(Texture value) { }

	// RVA: 0x19739E0 Offset: 0x196F9E0 VA: 0x19739E0
	private void Start() { }

	// RVA: 0x1973D00 Offset: 0x196FD00 VA: 0x1973D00
	public void set_MiniMapLevel(int value) { }

	// RVA: 0x1973DF0 Offset: 0x196FDF0 VA: 0x1973DF0
	public int get_MiniMapLevel() { }

	// RVA: 0x1973DF8 Offset: 0x196FDF8 VA: 0x1973DF8
	public Texture GetWorldMapTexture() { }

	// RVA: 0x1973EAC Offset: 0x196FEAC VA: 0x1973EAC
	public void SetMiniMapTexture(Texture[] tex, Vector2 size) { }

	// RVA: 0x1973F18 Offset: 0x196FF18 VA: 0x1973F18
	public void InitMiniMapMaskTexntre() { }

	// RVA: 0x1974218 Offset: 0x1970218 VA: 0x1974218
	public void ClearMiniMapMask() { }

	// RVA: 0x1974280 Offset: 0x1970280 VA: 0x1974280
	private void PassMaskUpdate(Vector3 position) { }

	// RVA: 0x197438C Offset: 0x197038C VA: 0x197438C
	public Vector3 CheckMiniMapPosition(Vector3 position, bool maskUpdate) { }

	// RVA: 0x1974534 Offset: 0x1970534 VA: 0x1974534
	public void AddMiniMapPoint(MiniMapBaseData data) { }

	// RVA: 0x19745FC Offset: 0x19705FC VA: 0x19745FC
	public void RemoveData(GameObject traceObject) { }

	// RVA: 0x197471C Offset: 0x197071C VA: 0x197471C
	public void ChangeControllerPlayer(GameObject changePlayer) { }

	// RVA: 0x197472C Offset: 0x197072C VA: 0x197472C
	public void Clear() { }

	// RVA: 0x197479C Offset: 0x197079C VA: 0x197479C
	private void LateUpdate() { }

	// RVA: 0x1974F04 Offset: 0x1970F04 VA: 0x1974F04
	public void OnRenderObject() { }

	// RVA: 0x1975614 Offset: 0x1971614 VA: 0x1975614
	public void .ctor() { }
}
