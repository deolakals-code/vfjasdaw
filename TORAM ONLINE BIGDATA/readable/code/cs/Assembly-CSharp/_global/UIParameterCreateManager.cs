// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIParameterCreateManager : UIBasePanel // TypeDefIndex: 6829
{
	// Fields
	private UICharacterModelManager characterModelManager; // 0x30
	private UIParameterCreateManager.ParameterPageType pageType; // 0x38
	private GameObject backgroundObject; // 0x40
	[SerializeField]
	private GameObject fadePanelObject; // 0x48
	[SerializeField]
	private UIIruna2AnchorSimple missionPanelAnchor; // 0x50
	[SerializeField]
	private UIIruna2AnchorSimple resultButtonAnchor; // 0x58
	[SerializeField]
	private UIToggle missionToggle; // 0x60
	private bool closed; // 0x68

	// Methods

	// RVA: 0x1A0E638 Offset: 0x1A0A638 VA: 0x1A0E638
	private void Start() { }

	// RVA: 0x1A0E6C4 Offset: 0x1A0A6C4 VA: 0x1A0E6C4
	private void Update() { }

	[IteratorStateMachine(typeof(UIParameterCreateManager.<CreateParameterLoad>d__11))]
	// RVA: 0x1A0E658 Offset: 0x1A0A658 VA: 0x1A0E658
	private IEnumerator CreateParameterLoad() { }

	// RVA: 0x1A0E720 Offset: 0x1A0A720 VA: 0x1A0E720
	private void OnDestroy() { }

	// RVA: 0x1A0E8E8 Offset: 0x1A0A8E8 VA: 0x1A0E8E8
	private void ChangePage(int add) { }

	// RVA: 0x1A0EB4C Offset: 0x1A0AB4C VA: 0x1A0EB4C
	private void NewParameterRegister() { }

	// RVA: 0x1A0EBE8 Offset: 0x1A0ABE8 VA: 0x1A0EBE8
	private void ParameterCreateCancel() { }

	[IteratorStateMachine(typeof(UIParameterCreateManager.<ReLogin>d__16))]
	// RVA: 0x1A0EAC4 Offset: 0x1A0AAC4 VA: 0x1A0EAC4
	private IEnumerator ReLogin(Action call) { }

	// RVA: 0x1A0EC60 Offset: 0x1A0AC60 VA: 0x1A0EC60
	public void OnClockResultButton() { }

	// RVA: 0x1A0EC78 Offset: 0x1A0AC78 VA: 0x1A0EC78 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A0EC8C Offset: 0x1A0AC8C VA: 0x1A0EC8C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A0EC90 Offset: 0x1A0AC90 VA: 0x1A0EC90
	public void .ctor() { }
}
