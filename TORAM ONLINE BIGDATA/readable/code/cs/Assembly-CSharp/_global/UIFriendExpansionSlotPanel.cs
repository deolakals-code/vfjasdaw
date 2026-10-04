// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFriendExpansionSlotPanel : MonoBehaviour // TypeDefIndex: 7075
{
	// Fields
	[SerializeField]
	private GameObject[] panelObjs; // 0x20
	[SerializeField]
	private UIImageButton[] buttons; // 0x28
	[SerializeField]
	private UILabel[] buttonLabels; // 0x30
	[SerializeField]
	private UILabel buyTextLabel; // 0x38
	[SerializeField]
	private UILabel buyMaxTextLabel; // 0x40
	[SerializeField]
	private UISlider loadingBar; // 0x48
	[SerializeField]
	private UILabel resultLabel; // 0x50
	[SerializeField]
	private UIIruna2Anchor orbPanelAnchor; // 0x58
	[SerializeField]
	private UILabel orbNumLabel; // 0x60
	private UIFriendExpansionSlotPanel.PanelState panelState; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private Action closeAction; // 0x78
	private UIBasePanelControl control; // 0x80
	private OrbManager orbManager; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	private const int AddSlotNum = 10;

	// Methods

	// RVA: 0x1A8A974 Offset: 0x1A86974 VA: 0x1A8A974
	private void Start() { }

	// RVA: 0x1A8AAA8 Offset: 0x1A86AA8 VA: 0x1A8AAA8
	public void Open(Action closeAction, UIBasePanelControl control) { }

	// RVA: 0x1A8B38C Offset: 0x1A8738C VA: 0x1A8B38C
	public void Close() { }

	// RVA: 0x1A8B410 Offset: 0x1A87410 VA: 0x1A8B410
	public void OnExpansionSlotButton() { }

	// RVA: 0x1A8B418 Offset: 0x1A87418 VA: 0x1A8B418
	public void OnWindowButton() { }

	// RVA: 0x1A8AD18 Offset: 0x1A86D18 VA: 0x1A8AD18
	private void ChangePanelState(UIFriendExpansionSlotPanel.PanelState panelState) { }

	// RVA: 0x1A8B504 Offset: 0x1A87504 VA: 0x1A8B504
	private void ChangeButton(UIFriendExpansionSlotPanel.ButtonType type) { }

	[IteratorStateMachine(typeof(UIFriendExpansionSlotPanel.<StartDelayToResult>d__25))]
	// RVA: 0x1A8B57C Offset: 0x1A8757C VA: 0x1A8B57C
	private IEnumerator StartDelayToResult() { }

	[IteratorStateMachine(typeof(UIFriendExpansionSlotPanel.<BuySlot>d__26))]
	// RVA: 0x1A8B610 Offset: 0x1A87610 VA: 0x1A8B610
	private IEnumerator BuySlot() { }

	// RVA: 0x1A8B6A4 Offset: 0x1A876A4 VA: 0x1A8B6A4
	public void .ctor() { }
}
