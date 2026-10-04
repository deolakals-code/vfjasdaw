// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIInfoWindow : UIBasePanel // TypeDefIndex: 6533
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor viewWindow; // 0x30
	[SerializeField]
	private UILabel indexlabel; // 0x38
	[SerializeField]
	private GameObject nextObject; // 0x40
	[SerializeField]
	private UILabel nextlabel; // 0x48
	[SerializeField]
	private GameObject retrunObject; // 0x50
	[SerializeField]
	private UILabel retrunlabel; // 0x58
	[SerializeField]
	private Transform labelParent; // 0x60
	private int page; // 0x68
	[SerializeField]
	private UILabel viewText; // 0x70
	[SerializeField]
	private UITexture viewTexture; // 0x78
	private string texturePath; // 0x80
	private int pageNum; // 0x88
	private bool laoding; // 0x8C
	private bool close; // 0x8D
	private List<UIInfoWindow.LabelPosition> labelList; // 0x90
	private GameObject loadingObject; // 0x98

	// Properties
	public bool Closed { get; }

	// Methods

	// RVA: 0x196E184 Offset: 0x196A184 VA: 0x196E184
	public bool get_Closed() { }

	// RVA: 0x196E18C Offset: 0x196A18C VA: 0x196E18C
	public void LoadInfoWindow(string path, int num, byte index) { }

	// RVA: 0x196E364 Offset: 0x196A364 VA: 0x196E364
	public void AddText(byte page, string text, byte position) { }

	// RVA: 0x196E4E0 Offset: 0x196A4E0 VA: 0x196E4E0
	public void AddText(byte page, string text, Vector3 position) { }

	// RVA: 0x196E600 Offset: 0x196A600 VA: 0x196E600
	private void NextPage() { }

	// RVA: 0x196E6E0 Offset: 0x196A6E0 VA: 0x196E6E0
	private void RetrunPage() { }

	[IteratorStateMachine(typeof(UIInfoWindow.<LoadingTexture>d__24))]
	// RVA: 0x196E2E8 Offset: 0x196A2E8 VA: 0x196E2E8
	private IEnumerator LoadingTexture(int vec) { }

	// RVA: 0x196E7CC Offset: 0x196A7CC VA: 0x196E7CC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x196E7D0 Offset: 0x196A7D0 VA: 0x196E7D0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x196E7D4 Offset: 0x196A7D4 VA: 0x196E7D4
	public void .ctor() { }
}
