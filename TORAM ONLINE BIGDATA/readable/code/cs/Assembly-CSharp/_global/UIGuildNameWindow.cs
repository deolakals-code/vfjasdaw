// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildNameWindow : MonoBehaviour // TypeDefIndex: 7147
{
	// Fields
	[SerializeField]
	private UILabel inputLabel; // 0x20
	[SerializeField]
	private TweenColor inputBackTween; // 0x28
	[SerializeField]
	private GameObject inputObject; // 0x30
	[SerializeField]
	private UIImageButton buttonImage; // 0x38
	[SerializeField]
	private UILabel mainLabel; // 0x40
	[SerializeField]
	private UILabel errLabel; // 0x48
	[SerializeField]
	private UILabel printLabel; // 0x50
	private Action<string> callback; // 0x58
	private Action<string> inputCallback; // 0x60
	private UIBasePanelControl TopControl; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private PlayerDataManager playerDataManager; // 0x78

	// Methods

	// RVA: 0x1AA8BD0 Offset: 0x1AA4BD0 VA: 0x1AA8BD0
	private void Awake() { }

	// RVA: 0x1AA8CD8 Offset: 0x1AA4CD8 VA: 0x1AA8CD8
	public void InitializeGuildName() { }

	// RVA: 0x1AA8D28 Offset: 0x1AA4D28 VA: 0x1AA8D28
	public void InitializeGuildName(string defaultName) { }

	// RVA: 0x1AA8D64 Offset: 0x1AA4D64 VA: 0x1AA8D64
	public void Open(bool canCreate, Action<string> inputCallback, Action<string> callback, UIBasePanelControl topControl) { }

	// RVA: 0x1AA8F10 Offset: 0x1AA4F10 VA: 0x1AA8F10
	public void OnSubmit() { }

	// RVA: 0x1AA9050 Offset: 0x1AA5050 VA: 0x1AA9050
	private void OnDetermine() { }

	// RVA: 0x1AA9088 Offset: 0x1AA5088 VA: 0x1AA9088
	public void SetEnableButton(bool isUsable) { }

	// RVA: 0x1AA9174 Offset: 0x1AA5174 VA: 0x1AA9174
	public void OnClose() { }

	// RVA: 0x1AA9198 Offset: 0x1AA5198 VA: 0x1AA9198
	public void .ctor() { }
}
