// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SnowballSearching : MonoBehaviour // TypeDefIndex: 4520
{
	// Fields
	private float searchAngle; // 0x20
	private float searchCos; // 0x24
	private MiniGameRoomData roomData; // 0x28
	private List<GameObject> scoutList; // 0x30
	private PlayerDataManager playerDataManager; // 0x38
	private const float defaultRadius = 25;
	private Vector3 camForward; // 0x40

	// Properties
	public GameObject MostNearObject { get; }
	public List<GameObject> ScoutList { get; }

	// Methods

	// RVA: 0x2511784 Offset: 0x250D784 VA: 0x2511784
	public GameObject get_MostNearObject() { }

	// RVA: 0x2511A60 Offset: 0x250DA60 VA: 0x2511A60
	public List<GameObject> get_ScoutList() { }

	// RVA: 0x2511A68 Offset: 0x250DA68 VA: 0x2511A68
	private void Awake() { }

	// RVA: 0x2511B84 Offset: 0x250DB84 VA: 0x2511B84
	private void Update() { }

	// RVA: 0x251211C Offset: 0x250E11C VA: 0x251211C
	private void OnDestroy() { }

	// RVA: 0x2512120 Offset: 0x250E120 VA: 0x2512120
	public void Initialize() { }

	// RVA: 0x2511E08 Offset: 0x250DE08 VA: 0x2511E08
	private void UpdateSearch() { }

	// RVA: 0x2512248 Offset: 0x250E248 VA: 0x2512248
	private bool IsInAutoSphere(GameObject obj) { }

	// RVA: 0x25124B8 Offset: 0x250E4B8 VA: 0x25124B8
	private bool IsScoutObject(GameObject obj) { }

	// RVA: 0x2512634 Offset: 0x250E634 VA: 0x2512634
	private bool IsRangeAngle(Vector3 forward, Vector3 dir, float cos) { }

	// RVA: 0x25126F8 Offset: 0x250E6F8 VA: 0x25126F8
	public void .ctor() { }
}
