// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffTenantPanel : MonoBehaviour, UIGuildStaffBasePanel // TypeDefIndex: 6716
{
	// Fields
	[SerializeField]
	private GameObject tenantPanelObj; // 0x20
	[SerializeField]
	private GameObject leftButtonObj; // 0x28
	[SerializeField]
	private GameObject rightButtonObj; // 0x30
	[SerializeField]
	private GameObject callButtonObj; // 0x38
	[SerializeField]
	private UISprite callButtonIcon; // 0x40
	[SerializeField]
	private GameObject operationLabelObj; // 0x48
	[SerializeField]
	private GameObject guildFundsButtonObj; // 0x50
	[SerializeField]
	private GameObject fundsPanelObj; // 0x58
	[SerializeField]
	private UILabel inputFundsLabel; // 0x60
	[SerializeField]
	private UIImageButton inputFundsButton; // 0x68
	[SerializeField]
	private GameObject endPanelObj; // 0x70
	[SerializeField]
	private UILabel endFundsLabel; // 0x78
	[SerializeField]
	private GameObject errPanelObj; // 0x80
	[SerializeField]
	private UILabel errPanelLabel; // 0x88
	[SerializeField]
	private UILabel shopNameLabel; // 0x90
	[SerializeField]
	private UILabel shopCostLabel; // 0x98
	[SerializeField]
	private GameObject hideLabelObj; // 0xA0
	[SerializeField]
	private UIInput uiInputObj; // 0xA8
	private readonly byte[] tenantList; // 0xB0
	private UIGuildStaffTenantPanel.PanelState panelState; // 0xB8
	private UIGuildStaffMainManager manager; // 0xC0
	private SystemTextManager systemTextManager; // 0xC8
	private int selectTenantIndex; // 0xD0
	private GuildManager guildManager; // 0xD8
	private UIToggle toggle; // 0xE0
	private bool isUpdate; // 0xE8
	private int unitPrice; // 0xEC
	private int contrihuteGold; // 0xF0
	private readonly int maxFundsPoint; // 0xF4

	// Methods

	// RVA: 0x19C4C1C Offset: 0x19C0C1C VA: 0x19C4C1C Slot: 4
	public void Initialize(UIGuildStaffMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x19C4D68 Offset: 0x19C0D68 VA: 0x19C4D68 Slot: 8
	public void FadeIn() { }

	[IteratorStateMachine(typeof(UIGuildStaffTenantPanel.<FadeOut>d__32))]
	// RVA: 0x19C514C Offset: 0x19C114C VA: 0x19C514C Slot: 9
	public IEnumerator FadeOut() { }

	// RVA: 0x19C51E0 Offset: 0x19C11E0 VA: 0x19C51E0 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x19C51E8 Offset: 0x19C11E8 VA: 0x19C51E8 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x19C5270 Offset: 0x19C1270 VA: 0x19C5270 Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x19C5278 Offset: 0x19C1278 VA: 0x19C5278
	public void ReceiveContrihuteGold(int contrihuteGold) { }

	// RVA: 0x19C5280 Offset: 0x19C1280 VA: 0x19C5280
	private void OnDestroy() { }

	// RVA: 0x19C4EA8 Offset: 0x19C0EA8 VA: 0x19C4EA8
	private void ChangePanelState(UIGuildStaffTenantPanel.PanelState panelState) { }

	// RVA: 0x19C5310 Offset: 0x19C1310 VA: 0x19C5310
	private void OnFundsPlus() { }

	// RVA: 0x19C5500 Offset: 0x19C1500 VA: 0x19C5500
	private void OnClick_SelectLeft() { }

	// RVA: 0x19C5568 Offset: 0x19C1568 VA: 0x19C5568
	private void OnClick_SelectRight() { }

	// RVA: 0x19C4FE4 Offset: 0x19C0FE4 VA: 0x19C4FE4
	private void UpdateSelectTenant(int add) { }

	// RVA: 0x19C55D0 Offset: 0x19C15D0 VA: 0x19C55D0
	private void OnCallShop() { }

	// RVA: 0x19C565C Offset: 0x19C165C VA: 0x19C565C
	private void OnDonation() { }

	// RVA: 0x19C57F8 Offset: 0x19C17F8 VA: 0x19C57F8
	private void OnEndOk() { }

	// RVA: 0x19C53AC Offset: 0x19C13AC VA: 0x19C53AC
	public void OnSubmit() { }

	// RVA: 0x19C585C Offset: 0x19C185C VA: 0x19C585C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19C58F8 Offset: 0x19C18F8 VA: 0x19C58F8
	private void <OnDonation>b__44_1() { }
}
