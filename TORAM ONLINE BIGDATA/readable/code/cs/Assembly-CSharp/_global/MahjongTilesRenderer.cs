// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongTilesRenderer : MonoBehaviour // TypeDefIndex: 4444
{
	// Fields
	[SerializeField]
	private Material material; // 0x20
	[SerializeField]
	private Mesh mesh; // 0x28
	[SerializeField]
	private float area; // 0x30
	[SerializeField]
	private float testScale; // 0x34
	[SerializeField]
	private GameObject riichiStick; // 0x38
	private Dictionary<int, MahjongTilesRenderer.TileTrans> list; // 0x40
	private int uidCurrent; // 0x48
	private Camera topViewCamera; // 0x50

	// Properties
	public Camera TopViewCamera { get; }
	public bool IsTopViewCamera { get; }
	public GameObject RiichiStick { get; }
	public Texture TilesTexture { get; }

	// Methods

	// RVA: 0x24F4D98 Offset: 0x24F0D98 VA: 0x24F4D98
	public Camera get_TopViewCamera() { }

	// RVA: 0x24F09B4 Offset: 0x24EC9B4 VA: 0x24F09B4
	public bool get_IsTopViewCamera() { }

	// RVA: 0x24F4DA0 Offset: 0x24F0DA0 VA: 0x24F4DA0
	public GameObject get_RiichiStick() { }

	// RVA: 0x24F4DA8 Offset: 0x24F0DA8 VA: 0x24F4DA8
	public Texture get_TilesTexture() { }

	// RVA: 0x24F4E48 Offset: 0x24F0E48 VA: 0x24F4E48
	private void Awake() { }

	// RVA: 0x24EEA78 Offset: 0x24EAA78 VA: 0x24EEA78
	public int AddTile(Vector3 position, Quaternion rotation, Vector3 scale, int index, out MahjongTilesRenderer.TileTrans tile) { }

	// RVA: 0x24ECE98 Offset: 0x24E8E98 VA: 0x24ECE98
	public int AddDiscardTile(int uid, byte type, bool isRed, Vector3 position, Quaternion rotation, Matrix4x4 araMatrix, bool isRiichi, bool isPlayAnim) { }

	// RVA: 0x24F3748 Offset: 0x24EF748 VA: 0x24F3748
	public int AddTile(int uid, byte type, bool isRed, Vector3 position, Quaternion rotation, Vector3 scale, int index, out MahjongTilesRenderer.TileTrans tile) { }

	// RVA: 0x24F5300 Offset: 0x24F1300 VA: 0x24F5300
	public void UpdateTile(int uid, byte type, bool isRed, Vector3 position, Quaternion rotation, Vector3 scale, int index) { }

	// RVA: 0x24ED744 Offset: 0x24E9744 VA: 0x24ED744
	public bool UpdateServerTile(int uid, int serverUid, byte type, bool isRed, out MahjongTilesRenderer.TileTrans updateTile) { }

	// RVA: 0x24F094C Offset: 0x24EC94C VA: 0x24F094C
	public bool TryGetValue(int uid, out MahjongTilesRenderer.TileTrans tile) { }

	// RVA: 0x24F55D0 Offset: 0x24F15D0 VA: 0x24F55D0
	public bool TryGetTargetIdTiles(int id, out MahjongTilesRenderer.TileTrans[] tiles) { }

	// RVA: 0x24F588C Offset: 0x24F188C VA: 0x24F588C
	public void ChangePickUpTiles(int id) { }

	// RVA: 0x24ED474 Offset: 0x24E9474 VA: 0x24ED474
	public void ChangeLastTile(int uid = 2147483647) { }

	// RVA: 0x24ED344 Offset: 0x24E9344 VA: 0x24ED344
	public bool RemoveTitle(int uid) { }

	// RVA: 0x24F59F0 Offset: 0x24F19F0 VA: 0x24F59F0
	public void Clear() { }

	// RVA: 0x24F5A48 Offset: 0x24F1A48 VA: 0x24F5A48
	public void ChangeTopViewCamera() { }

	// RVA: 0x24F5AE4 Offset: 0x24F1AE4 VA: 0x24F5AE4
	private void OnRenderObject() { }

	// RVA: 0x24F60C0 Offset: 0x24F20C0 VA: 0x24F60C0
	public void .ctor() { }
}
