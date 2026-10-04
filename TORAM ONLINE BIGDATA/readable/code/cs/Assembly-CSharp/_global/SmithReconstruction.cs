// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithReconstruction : SmithUIMaterialBase // TypeDefIndex: 8543
{
	// Fields
	[SerializeField]
	private UIIruna2AnchorSimple[] MoveObj; // 0x68
	[SerializeField]
	private GameObject DialogCheckObj; // 0x70
	[SerializeField]
	private GameObject DialogWeightCompleteObj; // 0x78
	[SerializeField]
	private GameObject DialogLightWeightCompleteObj; // 0x80
	[SerializeField]
	private UIIruna2AnchorSimple Dialog; // 0x88
	[SerializeField]
	private UIIruna2AnchorSimple MissDialog; // 0x90
	[SerializeField]
	private UILabel ModeLabel; // 0x98
	[SerializeField]
	private ItemIcon NameLabel; // 0xA0
	[SerializeField]
	private ItemIcon OriginNameLabel; // 0xA8
	[SerializeField]
	private GameObject StartButton; // 0xB0
	[SerializeField]
	private GameObject CompleteButton; // 0xB8
	[SerializeField]
	private LocalizeText CostLabel; // 0xC0
	[SerializeField]
	private GameObject reconstructEffectParent; // 0xC8
	[SerializeField]
	private GameObject reconstructEffectBackGround; // 0xD0
	private bool IsWeight; // 0xD8
	private ItemData equipItem; // 0xE0
	private PlayerDataManager playerDataManager; // 0xE8
	private bool isConnect; // 0xF0
	private bool isResponseSuccess; // 0xF1

	// Methods

	// RVA: 0x1DA0B4C Offset: 0x1D9CB4C VA: 0x1DA0B4C
	private void Awake() { }

	[IteratorStateMachine(typeof(SmithReconstruction.<Start>d__21))]
	// RVA: 0x1DA0C54 Offset: 0x1D9CC54 VA: 0x1DA0C54
	private IEnumerator Start() { }

	// RVA: 0x1DA0CE8 Offset: 0x1D9CCE8 VA: 0x1DA0CE8
	private void Update() { }

	// RVA: 0x1DA0CEC Offset: 0x1D9CCEC VA: 0x1DA0CEC
	public void OnLightWeight() { }

	// RVA: 0x1DA108C Offset: 0x1D9D08C VA: 0x1DA108C
	public void OnWeight() { }

	// RVA: 0x1DA113C Offset: 0x1D9D13C VA: 0x1DA113C
	public void OnStartButton() { }

	// RVA: 0x1DA11FC Offset: 0x1D9D1FC VA: 0x1DA11FC
	public void OnCompleteButton() { }

	// RVA: 0x1DA12D8 Offset: 0x1D9D2D8 VA: 0x1DA12D8
	public void OnMissButton() { }

	// RVA: 0x1DA12F8 Offset: 0x1D9D2F8 VA: 0x1DA12F8
	public void ResetDialog() { }

	// RVA: 0x1DA0D9C Offset: 0x1D9CD9C VA: 0x1DA0D9C
	private void MoveObjClose() { }

	// RVA: 0x1DA1344 Offset: 0x1D9D344 VA: 0x1DA1344
	private void MoveObjShow() { }

	// RVA: 0x1DA0FAC Offset: 0x1D9CFAC VA: 0x1DA0FAC
	private void ShowDialog() { }

	// RVA: 0x1DA1174 Offset: 0x1D9D174 VA: 0x1DA1174
	private void CloseDialog() { }

	// RVA: 0x1DA0DFC Offset: 0x1D9CDFC VA: 0x1DA0DFC
	private void SetReconstruction(bool isWeight) { }

	// RVA: 0x1DA13A4 Offset: 0x1D9D3A4 VA: 0x1DA13A4
	private void SetItemName(int itemId) { }

	// RVA: 0x1DA1224 Offset: 0x1D9D224 VA: 0x1DA1224
	private void ToMoveSelect() { }

	[IteratorStateMachine(typeof(SmithReconstruction.<ConnectWait>d__36))]
	// RVA: 0x1DA1190 Offset: 0x1D9D190 VA: 0x1DA1190
	private IEnumerator ConnectWait() { }

	[IteratorStateMachine(typeof(SmithReconstruction.<RemodelingConnect>d__37))]
	// RVA: 0x1DA140C Offset: 0x1D9D40C VA: 0x1DA140C
	private IEnumerator RemodelingConnect(int shopId, short[] position, int customItemUuid, byte customType, TakeController takeController, int takeUid) { }

	// RVA: 0x1DA1500 Offset: 0x1D9D500 VA: 0x1DA1500
	public void .ctor() { }
}
