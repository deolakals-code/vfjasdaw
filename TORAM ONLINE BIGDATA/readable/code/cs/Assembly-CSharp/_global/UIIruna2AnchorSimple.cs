// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(UIIruna2Anchor))]
public class UIIruna2AnchorSimple : MonoBehaviour // TypeDefIndex: 101
{
	// Fields
	[SerializeField]
	public Vector2 movePosition; // 0x20
	[SerializeField]
	public float moveTime; // 0x28
	[SerializeField]
	public float delay; // 0x2C
	[SerializeField]
	public bool isAutoStart; // 0x30
	private UIIruna2Anchor anchor; // 0x38

	// Properties
	public float SpendTime { get; }
	public UIIruna2Anchor Anchor { get; }

	// Methods

	// RVA: 0x1ED3D1C Offset: 0x1ECFD1C VA: 0x1ED3D1C
	public float get_SpendTime() { }

	// RVA: 0x1ED3D28 Offset: 0x1ECFD28 VA: 0x1ED3D28
	public UIIruna2Anchor get_Anchor() { }

	// RVA: 0x1ED3D30 Offset: 0x1ECFD30 VA: 0x1ED3D30
	private void Awake() { }

	// RVA: 0x1ED3D88 Offset: 0x1ECFD88 VA: 0x1ED3D88
	private void Start() { }

	// RVA: 0x1ED3D98 Offset: 0x1ECFD98 VA: 0x1ED3D98
	public void StartMove() { }

	// RVA: 0x1ED3E04 Offset: 0x1ECFE04 VA: 0x1ED3E04
	public void ReverseMove() { }

	// RVA: 0x1ED3EAC Offset: 0x1ECFEAC VA: 0x1ED3EAC
	public void .ctor() { }
}
