// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISpecialStorageDepositPanel : MonoBehaviour, IUISpecialStoragePanel // TypeDefIndex: 7950
{
	// Fields
	[SerializeField]
	private UILabel popText; // 0x20
	[SerializeField]
	private UILabel limitText; // 0x28
	[SerializeField]
	private UILabel gamePointTypeText; // 0x30
	[SerializeField]
	private UILabel depositPointTypeText; // 0x38
	[SerializeField]
	private UILabel gamePointText; // 0x40
	[SerializeField]
	private UILabel depositPointText; // 0x48
	[SerializeField]
	private GameObject selectButtonAnchor; // 0x50
	[SerializeField]
	private UIImageButton buttonImage; // 0x58
	[SerializeField]
	private UILabel buttonText; // 0x60
	private BankDepositType selectedItem; // 0x68
	private BankType selectedItemBankType; // 0x6C
	private long storagePoint; // 0x70
	private long storageMaxPoint; // 0x78
	private int gamePoint; // 0x80
	private int depositPoint; // 0x84
	private int oneSetData; // 0x88
	private int depositCount; // 0x8C
	private int depositResetDays; // 0x90
	private string unitLocalize; // 0x98
	private string pointLocalize; // 0xA0
	private UISpecialStorageManager manager; // 0xA8
	private SystemTextManager systemTextManager; // 0xB0

	// Methods

	// RVA: 0x1C80E48 Offset: 0x1C7CE48 VA: 0x1C80E48 Slot: 4
	public int GetMainPanelFlag() { }

	// RVA: 0x1C80E50 Offset: 0x1C7CE50 VA: 0x1C80E50 Slot: 5
	public void Initialize(UISpecialStorageManager manager) { }

	// RVA: 0x1C80F48 Offset: 0x1C7CF48 VA: 0x1C80F48 Slot: 6
	public bool ChangeActivate() { }

	// RVA: 0x1C817DC Offset: 0x1C7D7DC VA: 0x1C817DC Slot: 7
	public void OnClickAsobimoMarket() { }

	// RVA: 0x1C81834 Offset: 0x1C7D834 VA: 0x1C81834
	public void AddParam(int add) { }

	// RVA: 0x1C81998 Offset: 0x1C7D998 VA: 0x1C81998
	public void OnClickResult() { }

	[IteratorStateMachine(typeof(UISpecialStorageDepositPanel.<DepositConnect>d__28))]
	// RVA: 0x1C81B70 Offset: 0x1C7DB70 VA: 0x1C81B70
	private IEnumerator DepositConnect() { }

	// RVA: 0x1C81C04 Offset: 0x1C7DC04 VA: 0x1C81C04 Slot: 8
	public bool OnLeftTopButton() { }

	// RVA: 0x1C81CF4 Offset: 0x1C7DCF4 VA: 0x1C81CF4
	public void .ctor() { }
}
