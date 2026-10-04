// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChangeEnterWorldManager : MonoBehaviour // TypeDefIndex: 5145
{
	// Fields
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x20
	[SerializeField]
	private UIScrollBar scrollBar; // 0x28
	[SerializeField]
	private UISprite scrollForeground; // 0x30
	[SerializeField]
	private GameObject pcKeyLabel; // 0x38
	[SerializeField]
	private UILabel channelLabel; // 0x40
	[SerializeField]
	private UILabel channelStateLabel; // 0x48
	[SerializeField]
	private GameObject admissionButton; // 0x50
	[SerializeField]
	private UILabel admissionLabel; // 0x58
	[SerializeField]
	private UISprite iconSprite; // 0x60
	[SerializeField]
	private UISprite nameBack; // 0x68
	[SerializeField]
	private GameObject elementObject; // 0x70
	[SerializeField]
	private float elementHeight; // 0x78
	[SerializeField]
	private Transform windowPanel; // 0x80
	private WorldLoginData[] worldList; // 0x88
	private SystemTextManager systemTextManager; // 0x90

	// Methods

	// RVA: 0x25F94B8 Offset: 0x25F54B8 VA: 0x25F94B8
	public void Initialize(WorldLoginData[] worldList) { }

	// RVA: 0x25F9994 Offset: 0x25F5994 VA: 0x25F9994
	private void changeWorldState(int worldId, byte worldType, byte state) { }

	// RVA: 0x25FA1B0 Offset: 0x25F61B0 VA: 0x25FA1B0
	private void setWorldTypeAnother() { }

	// RVA: 0x25FA2C4 Offset: 0x25F62C4 VA: 0x25FA2C4
	private void OnClick(int param) { }

	[IteratorStateMachine(typeof(ChangeEnterWorldManager.<PopUpWatiWindow>d__19))]
	// RVA: 0x25FA2E4 Offset: 0x25F62E4 VA: 0x25FA2E4
	private IEnumerator PopUpWatiWindow(int _worldId) { }

	// RVA: 0x25FA388 Offset: 0x25F6388 VA: 0x25FA388
	private void openPopup() { }

	// RVA: 0x25FA4B4 Offset: 0x25F64B4 VA: 0x25FA4B4
	private void onClosePopup() { }

	// RVA: 0x25FA1B4 Offset: 0x25F61B4 VA: 0x25FA1B4
	private void openItemWarningPopup() { }

	[IteratorStateMachine(typeof(ChangeEnterWorldManager.<ItemWarningPopupWindow>d__23))]
	// RVA: 0x25FA4D4 Offset: 0x25F64D4 VA: 0x25FA4D4
	private IEnumerator ItemWarningPopupWindow(UIPopBaseWindow window) { }

	// RVA: 0x25FA584 Offset: 0x25F6584 VA: 0x25FA584
	private void ScrollActive(bool active) { }

	// RVA: 0x25FA5DC Offset: 0x25F65DC VA: 0x25FA5DC
	public void .ctor() { }
}
