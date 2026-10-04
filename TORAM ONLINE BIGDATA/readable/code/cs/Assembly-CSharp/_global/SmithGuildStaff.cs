// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithGuildStaff : UIBasePanelControl, IShop // TypeDefIndex: 8493
{
	// Fields
	[SerializeField]
	private GameObject processingObj; // 0x58
	private bool isClosed; // 0x60
	private SmithUIMaterialBase nowShowObj; // 0x68

	// Properties
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	// RVA: 0x1D88CE4 Offset: 0x1D84CE4 VA: 0x1D88CE4
	private void Awake() { }

	// RVA: 0x1D88DCC Offset: 0x1D84DCC VA: 0x1D88DCC
	private void Start() { }

	// RVA: 0x1D891E8 Offset: 0x1D851E8 VA: 0x1D891E8
	private void CloseSmith() { }

	// RVA: 0x1D891F4 Offset: 0x1D851F4 VA: 0x1D891F4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1D89200 Offset: 0x1D85200 VA: 0x1D89200 Slot: 14
	public int get_ShopId() { }

	// RVA: 0x1D89208 Offset: 0x1D85208 VA: 0x1D89208 Slot: 15
	public void set_ShopId(int value) { }

	// RVA: 0x1D8920C Offset: 0x1D8520C VA: 0x1D8920C Slot: 16
	public string get_ShopName() { }

	// RVA: 0x1D89254 Offset: 0x1D85254 VA: 0x1D89254 Slot: 17
	public void set_ShopName(string value) { }

	// RVA: 0x1D89258 Offset: 0x1D85258 VA: 0x1D89258 Slot: 18
	public bool get_IsClosed() { }

	// RVA: 0x1D89260 Offset: 0x1D85260 VA: 0x1D89260 Slot: 19
	public void set_IsClosed(bool value) { }

	// RVA: 0x1D8926C Offset: 0x1D8526C VA: 0x1D8926C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D89274 Offset: 0x1D85274 VA: 0x1D89274
	private void <Start>b__4_0() { }
}
