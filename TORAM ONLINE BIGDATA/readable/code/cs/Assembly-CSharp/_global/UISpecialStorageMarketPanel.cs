// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISpecialStorageMarketPanel : MonoBehaviour, IUISpecialStoragePanel // TypeDefIndex: 7971
{
	// Fields
	[SerializeField]
	private UILabel popText; // 0x20
	[SerializeField]
	private UISprite storagePointIcon; // 0x28
	[SerializeField]
	private UISprite storagePointBar; // 0x30
	[SerializeField]
	private UILabel storagePointText; // 0x38
	[SerializeField]
	private UILabel sendPointTypeText; // 0x40
	[SerializeField]
	private UILabel sendPointText; // 0x48
	[SerializeField]
	private GameObject selectButtonAnchor; // 0x50
	[SerializeField]
	private UIImageButton buttonImage; // 0x58
	[SerializeField]
	private UILabel buttonText; // 0x60
	[SerializeField]
	private UISprite categoryIcon; // 0x68
	[SerializeField]
	private UISprite categoryButtonIcon; // 0x70
	private BankDepositType selectedItem; // 0x78
	private BankType selectedItemBankType; // 0x7C
	private long storagePoint; // 0x80
	private int depositPoint; // 0x88
	private int oneSetData; // 0x8C
	private long maxPoint; // 0x90
	private string unitLocalize; // 0x98
	private string pointLocalize; // 0xA0
	private UISpecialStorageManager manager; // 0xA8
	private SystemTextManager systemTextManager; // 0xB0

	// Methods

	// RVA: 0x1C87454 Offset: 0x1C83454 VA: 0x1C87454 Slot: 4
	public int GetMainPanelFlag() { }

	// RVA: 0x1C8745C Offset: 0x1C8345C VA: 0x1C8745C Slot: 5
	public void Initialize(UISpecialStorageManager manager) { }

	// RVA: 0x1C87554 Offset: 0x1C83554 VA: 0x1C87554 Slot: 6
	public bool ChangeActivate() { }

	// RVA: 0x1C87B24 Offset: 0x1C83B24 VA: 0x1C87B24 Slot: 7
	public void OnClickAsobimoMarket() { }

	// RVA: 0x1C87B7C Offset: 0x1C83B7C VA: 0x1C87B7C
	public void AddParam(int add) { }

	// RVA: 0x1C87CCC Offset: 0x1C83CCC VA: 0x1C87CCC
	public void OnClickResult() { }

	[IteratorStateMachine(typeof(UISpecialStorageMarketPanel.<DepositConnect>d__27))]
	// RVA: 0x1C87CEC Offset: 0x1C83CEC VA: 0x1C87CEC
	private IEnumerator DepositConnect() { }

	// RVA: 0x1C87D80 Offset: 0x1C83D80 VA: 0x1C87D80 Slot: 8
	public bool OnLeftTopButton() { }

	// RVA: 0x1C87E70 Offset: 0x1C83E70 VA: 0x1C87E70
	public void .ctor() { }
}
