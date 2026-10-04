// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISpecialStorageWithdrawPanel : MonoBehaviour, IUISpecialStoragePanel // TypeDefIndex: 7983
{
	// Fields
	[SerializeField]
	private UILabel popText; // 0x20
	[SerializeField]
	private UILabel limitText; // 0x28
	[SerializeField]
	private UILabel gamePointTypeText; // 0x30
	[SerializeField]
	private UILabel withdrawPointTypeText; // 0x38
	[SerializeField]
	private UILabel gamePointText; // 0x40
	[SerializeField]
	private UILabel withdrawPointText; // 0x48
	[SerializeField]
	private UILabel withdrawFeeText; // 0x50
	[SerializeField]
	private UIImageButton buttonImage; // 0x58
	[SerializeField]
	private UILabel buttonText; // 0x60
	[SerializeField]
	private UILabel warningText; // 0x68
	private BankDepositType selectedItem; // 0x70
	private BankType selectedItemBankType; // 0x74
	private long storagePoint; // 0x78
	private int gamePoint; // 0x80
	private int gameMaxPoint; // 0x84
	private int withdrawPoint; // 0x88
	private int oneSetData; // 0x8C
	private int withdrawCount; // 0x90
	private int withdrawFee; // 0x94
	private string warningLocalize; // 0x98
	private string unitLocalize; // 0xA0
	private string pointLocalize; // 0xA8
	private UISpecialStorageManager manager; // 0xB0
	private SystemTextManager systemTextManager; // 0xB8

	// Methods

	// RVA: 0x1C8B778 Offset: 0x1C87778 VA: 0x1C8B778 Slot: 4
	public int GetMainPanelFlag() { }

	// RVA: 0x1C8B780 Offset: 0x1C87780 VA: 0x1C8B780 Slot: 5
	public void Initialize(UISpecialStorageManager manager) { }

	// RVA: 0x1C8B878 Offset: 0x1C87878 VA: 0x1C8B878 Slot: 6
	public bool ChangeActivate() { }

	// RVA: 0x1C8BF70 Offset: 0x1C87F70 VA: 0x1C8BF70 Slot: 7
	public void OnClickAsobimoMarket() { }

	// RVA: 0x1C8BFC8 Offset: 0x1C87FC8 VA: 0x1C8BFC8
	public void AddParam(int add) { }

	// RVA: 0x1C8C1E0 Offset: 0x1C881E0 VA: 0x1C8C1E0
	public void OnClickResult() { }

	[IteratorStateMachine(typeof(UISpecialStorageWithdrawPanel.<WithdrawConnect>d__30))]
	// RVA: 0x1C8C3BC Offset: 0x1C883BC VA: 0x1C8C3BC
	private IEnumerator WithdrawConnect(int count) { }

	// RVA: 0x1C8C460 Offset: 0x1C88460 VA: 0x1C8C460 Slot: 8
	public bool OnLeftTopButton() { }

	// RVA: 0x1C8C550 Offset: 0x1C88550 VA: 0x1C8C550
	public void .ctor() { }
}
