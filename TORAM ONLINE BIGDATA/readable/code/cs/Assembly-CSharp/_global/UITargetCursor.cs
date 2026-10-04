// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITargetCursor : MonoBehaviour // TypeDefIndex: 6577
{
	// Fields
	[SerializeField]
	private GameObject leftArrow; // 0x20
	[SerializeField]
	private GameObject rightArrow; // 0x28
	[SerializeField]
	private GameObject baseArea; // 0x30
	private float size; // 0x38
	private GameObject traceObject; // 0x40
	private PlayerDataManager playerDataManager; // 0x48
	private UITweener[] tweener; // 0x50
	private BoxCollider boxCollider; // 0x58
	private Vector2 savePosition; // 0x60
	private float dragTimer; // 0x68
	private byte dragCommand; // 0x6C
	private bool pressTarget; // 0x6D

	// Methods

	// RVA: 0x198D3F0 Offset: 0x19893F0 VA: 0x198D3F0
	private void Awake() { }

	// RVA: 0x198D498 Offset: 0x1989498 VA: 0x198D498
	private void Start() { }

	// RVA: 0x198D4BC Offset: 0x19894BC VA: 0x198D4BC
	public void Update() { }

	// RVA: 0x198DC2C Offset: 0x1989C2C VA: 0x198DC2C
	private int SelectCommand(Vector2 currentPosition) { }

	// RVA: 0x198D998 Offset: 0x1989998 VA: 0x198D998
	private void Command(int command) { }

	// RVA: 0x198DCB4 Offset: 0x1989CB4 VA: 0x198DCB4
	private void OnPress(bool press) { }

	// RVA: 0x198DE5C Offset: 0x1989E5C VA: 0x198DE5C
	private void OnDrag(Vector2 drag) { }

	// RVA: 0x198DEEC Offset: 0x1989EEC VA: 0x198DEEC
	public void .ctor() { }
}
