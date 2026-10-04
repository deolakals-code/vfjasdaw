// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShortcutListButton : MonoBehaviour // TypeDefIndex: 6569
{
	// Fields
	[SerializeField]
	private GameObject iconObject; // 0x20
	private UIIcon shortcutIcon; // 0x28
	[SerializeField]
	private UISprite cristaSlot1; // 0x30
	[SerializeField]
	private UISprite cristaSlot2; // 0x38
	[SerializeField]
	private UISprite[] cristaSlotBack; // 0x40
	[SerializeField]
	protected UILabel messageText; // 0x48
	[SerializeField]
	protected UILabel statusText; // 0x50
	[SerializeField]
	private UILabel shortcutTypeLabel; // 0x58
	[SerializeField]
	private UISprite plusIcon; // 0x60
	private PlayerDataManager playerManager; // 0x68
	private SystemTextManager systemManager; // 0x70
	private Action checkAction; // 0x78
	private int checkCost; // 0x80
	private bool isOverMp; // 0x84
	private int saveId; // 0x88

	// Properties
	protected UIIcon icon { get; }
	protected PlayerDataManager playerDataManager { get; }
	protected SystemTextManager systemTextManager { get; }
	private bool IsHistoryMenu { get; }

	// Methods

	// RVA: 0x198512C Offset: 0x198112C VA: 0x198512C
	protected UIIcon get_icon() { }

	// RVA: 0x19851DC Offset: 0x19811DC VA: 0x19851DC
	protected PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1985260 Offset: 0x1981260 VA: 0x1985260
	protected SystemTextManager get_systemTextManager() { }

	// RVA: 0x198534C Offset: 0x198134C VA: 0x198534C
	private bool get_IsHistoryMenu() { }

	// RVA: 0x19853A0 Offset: 0x19813A0 VA: 0x19853A0
	private void Update() { }

	// RVA: 0x19853BC Offset: 0x19813BC VA: 0x19853BC Slot: 4
	public virtual void SetSkillButton(int skillid) { }

	// RVA: 0x1985D20 Offset: 0x1981D20 VA: 0x1985D20
	public void SetAutoSkillButton(int skillid) { }

	// RVA: 0x1985DD4 Offset: 0x1981DD4 VA: 0x1985DD4 Slot: 5
	public virtual void SetSkillButtonLabel() { }

	// RVA: 0x1985A14 Offset: 0x1981A14 VA: 0x1985A14
	private bool CheckAvatarSkillButton(ItemData equipItem, int skillId) { }

	// RVA: 0x1986024 Offset: 0x1982024 VA: 0x1986024
	private void OnSkillCostCheck() { }

	// RVA: 0x19863A0 Offset: 0x19823A0 VA: 0x19863A0
	public void SetItemButton(int itemId) { }

	// RVA: 0x1986508 Offset: 0x1982508 VA: 0x1986508
	private void OnItemCheck() { }

	// RVA: 0x1986510 Offset: 0x1982510 VA: 0x1986510
	public void SetOrbItemButton(int itemId) { }

	// RVA: 0x1986688 Offset: 0x1982688 VA: 0x1986688
	private void OnOrbItemCheck() { }

	// RVA: 0x1986690 Offset: 0x1982690 VA: 0x1986690
	public void SetEquipButton(int itemUid) { }

	// RVA: 0x1986768 Offset: 0x1982768 VA: 0x1986768 Slot: 6
	public virtual void SetMenuButton(int menuId) { }

	// RVA: 0x1987870 Offset: 0x1983870 VA: 0x1987870
	public void SetEmotionButton(int emotionId) { }

	// RVA: 0x19877A4 Offset: 0x19837A4 VA: 0x19877A4
	public void SetNonButton() { }

	// RVA: 0x1987A24 Offset: 0x1983A24 VA: 0x1987A24
	public void SetLockButton() { }

	// RVA: 0x1987AFC Offset: 0x1983AFC VA: 0x1987AFC
	public void SetScreenshotButton() { }

	// RVA: 0x1987BD4 Offset: 0x1983BD4 VA: 0x1987BD4
	public void SetShortcutSetButton(string nextSetText) { }

	// RVA: 0x1987CFC Offset: 0x1983CFC VA: 0x1987CFC
	public void SetGuardAvoidButton(int id) { }

	// RVA: 0x1987E2C Offset: 0x1983E2C VA: 0x1987E2C
	public void SetBazaarButton(int id) { }

	// RVA: 0x1987FEC Offset: 0x1983FEC VA: 0x1987FEC Slot: 7
	protected virtual void SetButton(string message, string status, UIShortcutListButton.ColorType colorId) { }

	// RVA: 0x1988354 Offset: 0x1984354 VA: 0x1988354
	public void SetChatButton(int chatId) { }

	// RVA: 0x19873B4 Offset: 0x19833B4 VA: 0x19873B4
	private bool CheckCanPartyInvite(OtherPlayer otherPlayer, int id, byte type) { }

	// RVA: 0x1988794 Offset: 0x1984794 VA: 0x1988794
	public void SetFishingButton() { }

	// RVA: 0x1988938 Offset: 0x1984938 VA: 0x1988938
	public void SetOtherButton(int id) { }

	// RVA: 0x1988A60 Offset: 0x1984A60 VA: 0x1988A60
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1988ACC Offset: 0x1984ACC VA: 0x1988ACC
	private void <SetBazaarButton>b__42_0() { }
}
