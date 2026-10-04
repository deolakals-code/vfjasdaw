// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GeneralStoreCompleteDialog : MonoBehaviour // TypeDefIndex: 8330
{
	// Fields
	[SerializeField]
	private UILabel MessageLabel; // 0x20
	[SerializeField]
	private UILabel TitleLabel; // 0x28
	[SerializeField]
	private string StoreName; // 0x30
	[SerializeField]
	private UIScrollWindow multiScrollWindow; // 0x38
	[SerializeField]
	private GameObject multiFrame; // 0x40
	[SerializeField]
	private GameObject multiScrollBar; // 0x48
	[SerializeField]
	private GameObject multiOriginal; // 0x50
	[CompilerGenerated]
	private Action CloseCallFunc; // 0x58
	private UIBasePanelControl topButtonControl; // 0x60

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D225D4 Offset: 0x1D1E5D4 VA: 0x1D225D4
	public void add_CloseCallFunc(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1D22670 Offset: 0x1D1E670 VA: 0x1D22670
	public void remove_CloseCallFunc(Action value) { }

	// RVA: 0x1D2270C Offset: 0x1D1E70C VA: 0x1D2270C
	private void Start() { }

	// RVA: 0x1D22710 Offset: 0x1D1E710 VA: 0x1D22710
	private void Update() { }

	// RVA: 0x1D22714 Offset: 0x1D1E714 VA: 0x1D22714
	public void InitData(int id, string name, int Count, bool isBuy, UIBasePanelControl topControl) { }

	// RVA: 0x1D22A34 Offset: 0x1D1EA34 VA: 0x1D22A34
	public void InitData(ItemData[] items, ItemTextManager itemTextManager, UIBasePanelControl topControl) { }

	// RVA: 0x1D231F0 Offset: 0x1D1F1F0 VA: 0x1D231F0
	public void Close() { }

	// RVA: 0x1D232CC Offset: 0x1D1F2CC VA: 0x1D232CC
	public void .ctor() { }
}
