// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildTransferWindow : MonoBehaviour // TypeDefIndex: 7178
{
	// Fields
	[SerializeField]
	private UILabel mainLabel; // 0x20
	[SerializeField]
	private UISlider progressSlider; // 0x28
	[SerializeField]
	private GameObject checkObject; // 0x30
	[SerializeField]
	private GameObject progressObject; // 0x38
	[SerializeField]
	private UILabel progressTextLabel; // 0x40
	[SerializeField]
	private UILabel cancelButtonLabel; // 0x48
	[SerializeField]
	private UIButtonMessage cancelButtonMessage; // 0x50
	private Action<string> callback; // 0x58
	private Action<string> inputCallback; // 0x60
	private UIBasePanelControl TopControl; // 0x68
	private SystemTextManager systemTextManager; // 0x70

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x1AB59E4 Offset: 0x1AB19E4 VA: 0x1AB59E4
	public bool get_IsActive() { }

	// RVA: 0x1AB5A04 Offset: 0x1AB1A04 VA: 0x1AB5A04
	private void Awake() { }

	// RVA: 0x1AB5AEC Offset: 0x1AB1AEC VA: 0x1AB5AEC
	public void Open(string memberName, UIBasePanelControl topControl) { }

	// RVA: 0x1AB5C98 Offset: 0x1AB1C98 VA: 0x1AB5C98
	public void OnClose() { }

	[IteratorStateMachine(typeof(UIGuildTransferWindow.<StartProgress>d__16))]
	// RVA: 0x1AB5CBC Offset: 0x1AB1CBC VA: 0x1AB5CBC
	public IEnumerator StartProgress(int id, Action<int> callback) { }

	// RVA: 0x1AA7CFC Offset: 0x1AA3CFC VA: 0x1AA7CFC
	public void FinishTrans() { }

	// RVA: 0x1AB5D74 Offset: 0x1AB1D74 VA: 0x1AB5D74
	public void OnCancel() { }

	// RVA: 0x1AB5D78 Offset: 0x1AB1D78 VA: 0x1AB5D78
	public void .ctor() { }
}
