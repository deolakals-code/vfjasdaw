// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICharacterNameChangeManager : UIBasePanel // TypeDefIndex: 7502
{
	// Fields
	private GameObject backgroundObject; // 0x30
	[SerializeField]
	private GameObject fadePanelObject; // 0x38
	[SerializeField]
	private GameObject cameraObject; // 0x40
	[SerializeField]
	private UILabel orbLabel; // 0x48
	[SerializeField]
	private UILabel orbWrrLabel; // 0x50
	[SerializeField]
	private UIIruna2Anchor mainAnchor; // 0x58
	[SerializeField]
	private GameObject startPanel; // 0x60
	[SerializeField]
	private UILabel buyLabel; // 0x68
	[SerializeField]
	private GameObject inputPanel; // 0x70
	[SerializeField]
	private UIInput inputData; // 0x78
	[SerializeField]
	private UILabel inputLabel; // 0x80
	[SerializeField]
	private UIImageButton enterButton; // 0x88
	[SerializeField]
	private GameObject waitPanel; // 0x90
	[SerializeField]
	private UILabel popLabel; // 0x98
	[SerializeField]
	private UISprite waitBar; // 0xA0
	[SerializeField]
	private UIIruna2Anchor orbAnchor; // 0xA8
	private int step; // 0xB0
	private string defaultName; // 0xB8
	private string settingName; // 0xC0
	private GameObject clonePlayer; // 0xC8
	private int useOrbNum; // 0xD0
	private int orbNum; // 0xD4
	private bool useItem; // 0xD8
	private bool isLeave; // 0xD9
	private float leaveWaitTime; // 0xDC
	private FunctionLimitManager functionLimitManager; // 0xE0
	private UIPopWindow errorPopWindow; // 0xE8

	// Methods

	[IteratorStateMachine(typeof(UICharacterNameChangeManager.<Start>d__27))]
	// RVA: 0x1B75628 Offset: 0x1B71628 VA: 0x1B75628
	private IEnumerator Start() { }

	// RVA: 0x1B7569C Offset: 0x1B7169C VA: 0x1B7569C
	private void Update() { }

	// RVA: 0x1B75754 Offset: 0x1B71754 VA: 0x1B75754
	private void OnStratButton() { }

	// RVA: 0x1B75804 Offset: 0x1B71804 VA: 0x1B75804
	private bool inputCheck() { }

	// RVA: 0x1B75AE8 Offset: 0x1B71AE8 VA: 0x1B75AE8
	public void OnPress() { }

	[IteratorStateMachine(typeof(UICharacterNameChangeManager.<inputWait>d__32))]
	// RVA: 0x1B75B08 Offset: 0x1B71B08 VA: 0x1B75B08
	private IEnumerator inputWait() { }

	// RVA: 0x1B75B7C Offset: 0x1B71B7C VA: 0x1B75B7C
	private void OnCheckNameButton() { }

	// RVA: 0x1B75D78 Offset: 0x1B71D78 VA: 0x1B75D78
	private void OnCheckNameCancelButton() { }

	[IteratorStateMachine(typeof(UICharacterNameChangeManager.<OnCheckNameWaitButton>d__35))]
	// RVA: 0x1B75CE8 Offset: 0x1B71CE8 VA: 0x1B75CE8
	private IEnumerator OnCheckNameWaitButton(string name) { }

	[IteratorStateMachine(typeof(UICharacterNameChangeManager.<GameLogin>d__36))]
	// RVA: 0x1B75E7C Offset: 0x1B71E7C VA: 0x1B75E7C
	private IEnumerator GameLogin() { }

	// RVA: 0x1B75EF0 Offset: 0x1B71EF0 VA: 0x1B75EF0
	public void OpenErrorPopWindow() { }

	// RVA: 0x1B76148 Offset: 0x1B72148 VA: 0x1B76148
	private void OnDestroy() { }

	// RVA: 0x1B76398 Offset: 0x1B72398 VA: 0x1B76398 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B76508 Offset: 0x1B72508 VA: 0x1B76508 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B76514 Offset: 0x1B72514 VA: 0x1B76514
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B7657C Offset: 0x1B7257C VA: 0x1B7657C
	private void <OnCheckNameWaitButton>b__35_0() { }
}
