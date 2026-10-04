// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithTransfer : SmithUIMaterialBase // TypeDefIndex: 8570
{
	// Fields
	[SerializeField]
	private GameObject[] panelObjs; // 0x68
	[SerializeField]
	private SmithTransferSelectWeapon[] selectWeapons; // 0x70
	[SerializeField]
	private UIImageButton selectNextButton; // 0x78
	[SerializeField]
	private UILabel[] detailLabels; // 0x80
	[SerializeField]
	private SmithTransferSelectWeapon checkWeapon; // 0x88
	[SerializeField]
	private UILabel checkSuccessRateLabel; // 0x90
	[SerializeField]
	private UILabel[] checkPropertyLabels; // 0x98
	[SerializeField]
	private UISprite[] checkPropertyIcons; // 0xA0
	[SerializeField]
	private UILabel[] checkGoldLabels; // 0xA8
	[SerializeField]
	private SmithTransferCheckItemElement checkItemElement; // 0xB0
	[SerializeField]
	private UIImageButton checkEnterButton; // 0xB8
	[SerializeField]
	private UIScrollWindow checkItemScrollWindow; // 0xC0
	[SerializeField]
	private GameObject strengthEffectParent; // 0xC8
	[SerializeField]
	private GameObject strengthEffectBackground; // 0xD0
	[SerializeField]
	private GameObject checkNoSelectLabel; // 0xD8
	[SerializeField]
	private ItemIcon resultItemIcon; // 0xE0
	[SerializeField]
	private UILabel[] resultPropertyLabels; // 0xE8
	[SerializeField]
	private UISprite resultPropertyIcon; // 0xF0
	[SerializeField]
	private UISlider waitSlider; // 0xF8
	private SmithTransfer.PanelState panelState; // 0x100
	private ItemSelector itemSelector; // 0x108
	private SmithTransferSelectWeapon.SelectType selectType; // 0x110
	private Dictionary<short, int> transferPropertyFreeRateList; // 0x118
	private static Dictionary<int, Tuple<int, byte>> transferPropertySupportList; // 0x0
	private Dictionary<int, SmithTransferCheckItemElement> supportItemElementList; // 0x120
	private int nowSuccessRate; // 0x128
	private UIPopWindow errorPopWindow; // 0x130
	private const int orbItemId = 1000243;
	private ItemRandomPropertyTextManager itemRandomPropTextManager; // 0x138
	private Coroutine waitCoroutine; // 0x140

	// Methods

	// RVA: 0x1DABA7C Offset: 0x1DA7A7C VA: 0x1DABA7C
	private void Start() { }

	// RVA: 0x1DAC4A4 Offset: 0x1DA84A4 VA: 0x1DAC4A4
	protected void Update() { }

	// RVA: 0x1DAC560 Offset: 0x1DA8560 VA: 0x1DAC560
	private void OnDestroy() { }

	// RVA: 0x1DAC654 Offset: 0x1DA8654 VA: 0x1DAC654
	public void OnSelectNext() { }

	// RVA: 0x1DAE0F4 Offset: 0x1DAA0F4 VA: 0x1DAE0F4
	public void OnDetailOk() { }

	// RVA: 0x1DAE114 Offset: 0x1DAA114 VA: 0x1DAE114
	public void OnCheckEnter() { }

	// RVA: 0x1DAE2F8 Offset: 0x1DAA2F8 VA: 0x1DAE2F8
	public void OnResultOk() { }

	// RVA: 0x1DAE318 Offset: 0x1DAA318 VA: 0x1DAE318
	public void OnWaitCancel() { }

	// RVA: 0x1DAC19C Offset: 0x1DA819C VA: 0x1DAC19C
	private void ChangePanelState(SmithTransfer.PanelState panelState) { }

	// RVA: 0x1DAE338 Offset: 0x1DAA338 VA: 0x1DAE338
	private void OpenSelectItem(SmithTransferSelectWeapon.SelectType selectType) { }

	// RVA: 0x1DAE60C Offset: 0x1DAA60C VA: 0x1DAE60C
	private bool CheckShowItem(ItemData item) { }

	// RVA: 0x1DAE71C Offset: 0x1DAA71C VA: 0x1DAE71C
	private void OnSelectItemData(ItemData itemData, int count) { }

	// RVA: 0x1DAEAE0 Offset: 0x1DAAAE0 VA: 0x1DAEAE0
	private void OpenDetail(int id) { }

	// RVA: 0x1DAEC88 Offset: 0x1DAAC88 VA: 0x1DAEC88
	private void ReturnSelect() { }

	// RVA: 0x1DAD414 Offset: 0x1DA9414 VA: 0x1DAD414
	private int CalcTransferPropertyFree() { }

	// RVA: 0x1DAD678 Offset: 0x1DA9678 VA: 0x1DAD678
	private void UpdateSuccessRate() { }

	// RVA: 0x1DAEDA8 Offset: 0x1DAADA8 VA: 0x1DAEDA8
	private void OnCheckSupportItem() { }

	[IteratorStateMachine(typeof(SmithTransfer.<ConnectTransfer>d__48))]
	// RVA: 0x1DAE28C Offset: 0x1DAA28C VA: 0x1DAE28C
	private IEnumerator ConnectTransfer() { }

	[IteratorStateMachine(typeof(SmithTransfer.<UpdateOrbItem>d__49))]
	// RVA: 0x1DAC144 Offset: 0x1DA8144 VA: 0x1DAC144
	private IEnumerator UpdateOrbItem() { }

	[IteratorStateMachine(typeof(SmithTransfer.<ZeroPercentWait>d__50))]
	// RVA: 0x1DAE220 Offset: 0x1DAA220 VA: 0x1DAE220
	private IEnumerator ZeroPercentWait() { }

	// RVA: 0x1DAEF90 Offset: 0x1DAAF90 VA: 0x1DAEF90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1DAF13C Offset: 0x1DAB13C VA: 0x1DAF13C
	private void <OnSelectNext>b__34_0() { }

	[CompilerGenerated]
	// RVA: 0x1DAF144 Offset: 0x1DAB144 VA: 0x1DAF144
	private void <OnCheckEnter>b__36_0() { }

	[CompilerGenerated]
	// RVA: 0x1DAF184 Offset: 0x1DAB184 VA: 0x1DAF184
	private void <OpenDetail>b__43_0() { }
}
