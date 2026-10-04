// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MyHomeItem : MonoBehaviour // TypeDefIndex: 3970
{
	// Fields
	[SerializeField]
	private Vector4 chipSize; // 0x20
	[SerializeField]
	private int flag; // 0x30
	[SerializeField]
	private byte systemType; // 0x34
	private bool init; // 0x35
	private List<Renderer> render; // 0x38

	// Properties
	public Vector4 ChipSize { get; }
	public int Flag { get; }
	public byte SystemType { get; }

	// Methods

	// RVA: 0x24298A4 Offset: 0x24258A4 VA: 0x24298A4
	public Vector4 get_ChipSize() { }

	// RVA: 0x24298B0 Offset: 0x24258B0 VA: 0x24298B0
	public int get_Flag() { }

	// RVA: 0x24298B8 Offset: 0x24258B8 VA: 0x24298B8
	public byte get_SystemType() { }

	// RVA: 0x24298C0 Offset: 0x24258C0 VA: 0x24298C0
	private void Initialize() { }

	// RVA: 0x2429A3C Offset: 0x2425A3C VA: 0x2429A3C
	private void Awake() { }

	// RVA: 0x2429A40 Offset: 0x2425A40 VA: 0x2429A40
	public void UpdateViewArea(bool view) { }

	// RVA: 0x2429BA0 Offset: 0x2425BA0 VA: 0x2429BA0
	public void .ctor() { }
}
