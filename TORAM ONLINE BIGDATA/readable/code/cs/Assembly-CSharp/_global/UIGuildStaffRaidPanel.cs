// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffRaidPanel : MonoBehaviour, UIGuildStaffBasePanel, IUIGuildRaidStaminRecoveryPanelReceiver // TypeDefIndex: 6699
{
	// Fields
	[SerializeField]
	private GameObject tpoPanelObj; // 0x20
	[SerializeField]
	private UIImageButton checkItemButton; // 0x28
	[SerializeField]
	private GameObject checkItemButtonObject; // 0x30
	[SerializeField]
	private UISprite[] staminaIcons; // 0x38
	[SerializeField]
	private UIIcon[] enemyBaseIcon; // 0x40
	[SerializeField]
	private GameObject itemViewPanel; // 0x48
	[SerializeField]
	private UILabel itemNameLabel; // 0x50
	[SerializeField]
	private UIIcon itemIcon; // 0x58
	[SerializeField]
	private UILabel itemTextLabel; // 0x60
	[SerializeField]
	private GameObject copyItemCategoryObject; // 0x68
	[SerializeField]
	private GameObject staminaRecoveryButton; // 0x70
	private UIGuildStaffRaidPanel.PanelState panelState; // 0x78
	private UIGuildStaffMainManager manager; // 0x80
	private IUIGuildStaffRaidPanelController iManager; // 0x88
	private SystemTextManager systemTextManager; // 0x90
	private GuildManager guildManager; // 0x98
	private PlayerDataManager playerDataManager; // 0xA0
	private UIGuildRaidStaminaRecoveryPanel staminaRecoveryPanel; // 0xA8

	// Methods

	// RVA: 0x19BDACC Offset: 0x19B9ACC VA: 0x19BDACC Slot: 4
	public void Initialize(UIGuildStaffMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x19BE04C Offset: 0x19BA04C VA: 0x19BE04C
	public void Initialize(IUIGuildStaffRaidPanelController manager, SystemTextManager systemTextManager) { }

	// RVA: 0x19BDB08 Offset: 0x19B9B08 VA: 0x19BDB08
	public void Initialize(SystemTextManager systemTextManager) { }

	// RVA: 0x19BE090 Offset: 0x19BA090 VA: 0x19BE090 Slot: 8
	public void FadeIn() { }

	[IteratorStateMachine(typeof(UIGuildStaffRaidPanel.<FadeOut>d__23))]
	// RVA: 0x19BE410 Offset: 0x19BA410 VA: 0x19BE410 Slot: 9
	public IEnumerator FadeOut() { }

	// RVA: 0x19BE4A4 Offset: 0x19BA4A4 VA: 0x19BE4A4 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x19BE4AC Offset: 0x19BA4AC VA: 0x19BE4AC Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x19BE58C Offset: 0x19BA58C VA: 0x19BE58C Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x19BE1A8 Offset: 0x19BA1A8 VA: 0x19BE1A8
	private void ChangePanelState(UIGuildStaffRaidPanel.PanelState panelState) { }

	// RVA: 0x19BE594 Offset: 0x19BA594 VA: 0x19BE594
	public void OnClick_ItemView() { }

	// RVA: 0x19BE614 Offset: 0x19BA614 VA: 0x19BE614
	public void OnClick_TopView() { }

	// RVA: 0x19BE694 Offset: 0x19BA694 VA: 0x19BE694
	public void OnClick_EnterLobby() { }

	// RVA: 0x19BEAFC Offset: 0x19BAAFC VA: 0x19BEAFC
	public void OnClick_RecoveryStamina() { }

	// RVA: 0x19BEBC0 Offset: 0x19BABC0 VA: 0x19BEBC0 Slot: 10
	public void OnUpdatePanel() { }

	// RVA: 0x19BEBC8 Offset: 0x19BABC8 VA: 0x19BEBC8 Slot: 11
	public void SetActiveOrbPanel(bool flag) { }

	// RVA: 0x19BECE0 Offset: 0x19BACE0 VA: 0x19BECE0
	public void .ctor() { }
}
