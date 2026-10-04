// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(UILabel))]
public class UILabelSizeControl : MonoBehaviour // TypeDefIndex: 120
{
	// Fields
	[SerializeField]
	private Vector3 scale; // 0x20
	[SerializeField]
	private int width; // 0x2C
	private UILabel label; // 0x30
	private int holdWidth; // 0x38

	// Properties
	public int LimitWidth { get; }
	public Vector3 Scale { get; }

	// Methods

	// RVA: 0x1EDCFE8 Offset: 0x1ED8FE8 VA: 0x1EDCFE8
	public int get_LimitWidth() { }

	// RVA: 0x1EDCFF0 Offset: 0x1ED8FF0 VA: 0x1EDCFF0
	public Vector3 get_Scale() { }

	// RVA: 0x1EDCFFC Offset: 0x1ED8FFC VA: 0x1EDCFFC
	private void Awake() { }

	// RVA: 0x1EDD054 Offset: 0x1ED9054 VA: 0x1EDD054
	private void Update() { }

	// RVA: 0x1EDD058 Offset: 0x1ED9058 VA: 0x1EDD058
	private void UpdateSizeControl() { }

	// RVA: 0x1EDD0EC Offset: 0x1ED90EC VA: 0x1EDD0EC
	public void Initialize(Vector3 scale, int width) { }

	// RVA: 0x1EDD0FC Offset: 0x1ED90FC VA: 0x1EDD0FC
	public void ForceSizeControl() { }

	// RVA: 0x1EDD1B0 Offset: 0x1ED91B0 VA: 0x1EDD1B0
	public void .ctor() { }
}
