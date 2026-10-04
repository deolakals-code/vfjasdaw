// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPopBaseWindow : MonoBehaviour // TypeDefIndex: 8833
{
	// Fields
	[SerializeField]
	private Transform messageParent; // 0x20
	[SerializeField]
	private Transform titleParent; // 0x28
	[SerializeField]
	private GameObject popObject; // 0x30
	[SerializeField]
	private UISprite colorbackPanel; // 0x38
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x40
	private PopBaseWindow popBaseWindow; // 0x48

	// Properties
	public Transform MessageParent { get; }
	public Transform TitleParent { get; }
	public GameObject PopObject { get; }
	public bool IsClose { get; set; }

	// Methods

	// RVA: 0x1E2EE0C Offset: 0x1E2AE0C VA: 0x1E2EE0C
	public static UIPopBaseWindow CreatePopUpWindow() { }

	// RVA: 0x1E2EE5C Offset: 0x1E2AE5C VA: 0x1E2EE5C
	public static UIPopBaseWindow CreatePopUpWindow(Transform parent) { }

	// RVA: 0x1E2EFF8 Offset: 0x1E2AFF8 VA: 0x1E2EFF8
	public Transform get_MessageParent() { }

	// RVA: 0x1E2F000 Offset: 0x1E2B000 VA: 0x1E2F000
	public Transform get_TitleParent() { }

	// RVA: 0x1E2F008 Offset: 0x1E2B008 VA: 0x1E2F008
	public GameObject get_PopObject() { }

	[CompilerGenerated]
	// RVA: 0x1E2F010 Offset: 0x1E2B010 VA: 0x1E2F010
	private void set_IsClose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E2F01C Offset: 0x1E2B01C VA: 0x1E2F01C
	public bool get_IsClose() { }

	// RVA: 0x1E2F024 Offset: 0x1E2B024 VA: 0x1E2F024
	public void Initialize(PopBaseWindow popBaseWindow) { }

	// RVA: 0x1E2F038 Offset: 0x1E2B038 VA: 0x1E2F038
	public void Initialize(PopBaseWindow popBaseWindow, Color color) { }

	// RVA: 0x1E2F1B8 Offset: 0x1E2B1B8 VA: 0x1E2F1B8
	public void Open() { }

	// RVA: 0x1E2F21C Offset: 0x1E2B21C VA: 0x1E2F21C
	public void MessageAction(int id) { }

	// RVA: 0x1E2F234 Offset: 0x1E2B234 VA: 0x1E2F234
	public int MessageCheck() { }

	// RVA: 0x1E2F24C Offset: 0x1E2B24C VA: 0x1E2F24C
	private void Update() { }

	// RVA: 0x1E2F264 Offset: 0x1E2B264 VA: 0x1E2F264
	public void Close() { }

	// RVA: 0x1E2F2E4 Offset: 0x1E2B2E4 VA: 0x1E2F2E4
	public void Closed() { }

	// RVA: 0x1E2F360 Offset: 0x1E2B360 VA: 0x1E2F360
	public void .ctor() { }
}
