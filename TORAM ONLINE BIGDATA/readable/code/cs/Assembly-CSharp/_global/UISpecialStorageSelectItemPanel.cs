// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISpecialStorageSelectItemPanel : MonoBehaviour, IUISpecialStoragePanel // TypeDefIndex: 7972
{
	// Fields
	[SerializeField]
	private UILabel pointLabel; // 0x20
	[SerializeField]
	private UISprite pointIcon; // 0x28
	[SerializeField]
	private UISprite pointBar; // 0x30
	[SerializeField]
	private UISprite pointMaxBar; // 0x38
	[SerializeField]
	private UILabel[] limitLabel; // 0x40
	[SerializeField]
	private UIImageButton[] buttonLabel; // 0x48
	[SerializeField]
	private UILabel[] itemLabel; // 0x50
	[SerializeField]
	private BankDepositType[] selectItemTypes; // 0x58
	private int selectedItem; // 0x60
	private UISpecialStorageManager manager; // 0x68
	private SystemTextManager systemTextManager; // 0x70

	// Properties
	public BankDepositType SelectedItem { get; }

	// Methods

	// RVA: 0x1C81594 Offset: 0x1C7D594 VA: 0x1C81594
	public BankDepositType get_SelectedItem() { }

	// RVA: 0x1C888C4 Offset: 0x1C848C4 VA: 0x1C888C4 Slot: 4
	public int GetMainPanelFlag() { }

	// RVA: 0x1C888CC Offset: 0x1C848CC VA: 0x1C888CC Slot: 5
	public void Initialize(UISpecialStorageManager manager) { }

	// RVA: 0x1C889C4 Offset: 0x1C849C4 VA: 0x1C889C4
	public void ChangeSelectMaterial(int add) { }

	// RVA: 0x1C88A50 Offset: 0x1C84A50 VA: 0x1C88A50
	private void UpdateSelectParam(int selectMaterial) { }

	// RVA: 0x1C890EC Offset: 0x1C850EC VA: 0x1C890EC
	public void OnClickDeposit() { }

	// RVA: 0x1C891EC Offset: 0x1C851EC VA: 0x1C891EC
	public void OnClickWithdraw() { }

	// RVA: 0x1C892EC Offset: 0x1C852EC VA: 0x1C892EC Slot: 6
	public bool ChangeActivate() { }

	// RVA: 0x1C8938C Offset: 0x1C8538C VA: 0x1C8938C Slot: 7
	public void OnClickAsobimoMarket() { }

	// RVA: 0x1C894F4 Offset: 0x1C854F4 VA: 0x1C894F4 Slot: 8
	public bool OnLeftTopButton() { }

	// RVA: 0x1C895E4 Offset: 0x1C855E4 VA: 0x1C895E4
	public void .ctor() { }
}
