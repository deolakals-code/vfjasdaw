// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShortcutManager : Singleton<ShortcutManager> // TypeDefIndex: 5400
{
	// Fields
	public readonly byte ShortcutWeaponNum; // 0x20
	public static readonly int TotalListButtonNum; // 0x0
	public static readonly int ListPageNum; // 0x4
	public const int ListButtonNum = 5;
	public static readonly int ShortcutButtonNum; // 0x8
	public const int ShortcutSetNum = 3;
	public static readonly int FixedShortcutButtonNum; // 0xC
	private PlayerDataManager playerDataManager; // 0x28
	private int parameterSlot; // 0x30
	private Dictionary<ShortcutManager.ShortcutListType, Dictionary<int, ShortcutManager.ShortcutSaveData>> shortcutList; // 0x38
	private Dictionary<ShortcutManager.ShortcutListType, int> shortcutPanelViewFlag; // 0x40
	private Dictionary<int, int> currentShortcutSetList; // 0x48
	private UIShortcutListManager shortcutListManager; // 0x50
	private int prevShortcutSetId; // 0x58
	private SystemTextManager systemLocalizeManager; // 0x60
	[CompilerGenerated]
	private OtherPlayerActionManager <targetOtherPlayer>k__BackingField; // 0x68

	// Properties
	public UIShortcutListManager ShortcutListManager { get; }
	public int PrevShortcutSetId { get; }
	public SystemTextManager systemTextManager { get; }
	public OtherPlayerActionManager targetOtherPlayer { get; set; }

	// Methods

	// RVA: 0x17547DC Offset: 0x17507DC VA: 0x17547DC
	public UIShortcutListManager get_ShortcutListManager() { }

	// RVA: 0x17547E4 Offset: 0x17507E4 VA: 0x17547E4
	public int get_PrevShortcutSetId() { }

	// RVA: 0x17547EC Offset: 0x17507EC VA: 0x17547EC
	public SystemTextManager get_systemTextManager() { }

	[CompilerGenerated]
	// RVA: 0x17548D8 Offset: 0x17508D8 VA: 0x17548D8
	public OtherPlayerActionManager get_targetOtherPlayer() { }

	[CompilerGenerated]
	// RVA: 0x17548E0 Offset: 0x17508E0 VA: 0x17548E0
	private void set_targetOtherPlayer(OtherPlayerActionManager value) { }

	// RVA: 0x17548E8 Offset: 0x17508E8 VA: 0x17548E8
	private void Awake() { }

	// RVA: 0x17563B4 Offset: 0x17523B4 VA: 0x17563B4
	public void Initialize() { }

	// RVA: 0x1756BC8 Offset: 0x1752BC8 VA: 0x1756BC8
	public void SetParamInitialize(int playerParameterSlot) { }

	// RVA: 0x17576DC Offset: 0x17536DC VA: 0x17576DC
	private ShortcutManager.ShortcutListType GetButtonWeaponType(ShortcutManager.ShortcutListType typeId) { }

	// RVA: 0x1756E94 Offset: 0x1752E94 VA: 0x1756E94
	private bool LoadShortcut(int characterSlot, ShortcutManager.ShortcutListType listType, int max) { }

	// RVA: 0x1757348 Offset: 0x1753348 VA: 0x1757348
	private void LoadShortcutSet(ShortcutManager.ShortcutListType type) { }

	// RVA: 0x1756808 Offset: 0x1752808 VA: 0x1756808
	private int LoadShortcutView(int characterSlot, ShortcutManager.ShortcutListType listType) { }

	// RVA: 0x175748C Offset: 0x175348C VA: 0x175748C
	public void SaveShortcutData(bool addWeapon) { }

	// RVA: 0x17577D4 Offset: 0x17537D4 VA: 0x17577D4
	private void SaveShortcutData(int characterSlot, ShortcutManager.ShortcutListType listType) { }

	// RVA: 0x1757EE4 Offset: 0x1753EE4 VA: 0x1757EE4
	public void SaveShortcutSet() { }

	// RVA: 0x1757FF8 Offset: 0x1753FF8 VA: 0x1757FF8
	public void DeleteSlotShortcutData(int characterSlot) { }

	// RVA: 0x17585A4 Offset: 0x17545A4 VA: 0x17585A4
	public ShortcutData GetShortcutButton(int id) { }

	// RVA: 0x17587F0 Offset: 0x17547F0 VA: 0x17587F0
	public void PushShortcutButton(int id) { }

	// RVA: 0x1758808 Offset: 0x1754808 VA: 0x1758808
	public bool ChangeShortcutButton(int position, ShortcutData.ShortcutType type, int id, bool overrideFlag, bool allButton) { }

	// RVA: 0x17588CC Offset: 0x17548CC VA: 0x17588CC
	public int GetNextShortcutId(ShortcutManager.ShortcutSetChangeType type) { }

	// RVA: 0x17589E8 Offset: 0x17549E8 VA: 0x17589E8
	public string GetNextShortcutSetText(int id) { }

	// RVA: 0x17546C8 Offset: 0x17506C8 VA: 0x17546C8
	public void ChangeShortcutSetId(int id) { }

	// RVA: 0x1758B14 Offset: 0x1754B14 VA: 0x1758B14
	public void ChangeShortcutSetId(int id, int prevId) { }

	// RVA: 0x1758B8C Offset: 0x1754B8C VA: 0x1758B8C
	public ShortcutData GetShortcutPanelButton(int index, int pageId) { }

	// RVA: 0x1753858 Offset: 0x174F858 VA: 0x1753858
	public void ShortcutPanelOpen() { }

	// RVA: 0x1758D08 Offset: 0x1754D08 VA: 0x1758D08
	public void ShortcutPanelClear() { }

	// RVA: 0x1754754 Offset: 0x1750754 VA: 0x1754754
	public void ShortcutPanelClose() { }

	// RVA: 0x1758D14 Offset: 0x1754D14 VA: 0x1758D14
	public bool ChangeShortcutPanel(int position, ShortcutData.ShortcutType type, int id, bool overrideFlag, bool allButton) { }

	// RVA: 0x1758DC8 Offset: 0x1754DC8 VA: 0x1758DC8
	public void ChangeShortcutPanelView(int view) { }

	// RVA: 0x1758E70 Offset: 0x1754E70 VA: 0x1758E70
	public int GetShortcutPanelView() { }

	// RVA: 0x1758724 Offset: 0x1754724 VA: 0x1758724
	public int GetShortcutSetId() { }

	// RVA: 0x1758F14 Offset: 0x1754F14 VA: 0x1758F14
	public void TargetPlayerOpen(GameObject targetObject) { }

	// RVA: 0x1759D6C Offset: 0x1755D6C VA: 0x1759D6C
	public void TargetPlayerOpen(int pageId) { }

	// RVA: 0x1759DB8 Offset: 0x1755DB8 VA: 0x1759DB8
	public void ChatTypePanelOpne() { }

	// RVA: 0x1756A74 Offset: 0x1752A74 VA: 0x1756A74
	public void AllSetGuardAvoid() { }

	// RVA: 0x175ACB8 Offset: 0x1756CB8 VA: 0x175ACB8
	public void TargetAutoMemberOpen(int page) { }

	// RVA: 0x1759F2C Offset: 0x1755F2C VA: 0x1759F2C
	private void ShortcutChatPanelOpen() { }

	// RVA: 0x175A5FC Offset: 0x17565FC VA: 0x175A5FC
	private void WaitingShortcutChatPanelOpen(SmithUIMaterialBase basePanel) { }

	// RVA: 0x175B3B8 Offset: 0x17573B8 VA: 0x175B3B8
	public void ShortcutChatTargetOpen(bool isGmTarget) { }

	// RVA: 0x175BDD8 Offset: 0x1757DD8 VA: 0x175BDD8
	public void ShortcutChatTargetOpen(SmithUIMaterialBase smithBase) { }

	// RVA: 0x175BB40 Offset: 0x1757B40 VA: 0x175BB40
	private bool interdiction_display() { }

	// RVA: 0x175C314 Offset: 0x1758314 VA: 0x175C314
	public void TargetMercenaryOpen() { }

	// RVA: 0x175C328 Offset: 0x1758328 VA: 0x175C328
	public void TargetPartnerOpen() { }

	// RVA: 0x175910C Offset: 0x175510C VA: 0x175910C
	private void ShortcutPanelOpen(ShortcutManager.ShortcutListType type, int pageId, int num, bool close) { }

	// RVA: 0x17568EC Offset: 0x17528EC VA: 0x17568EC
	private bool ShortcutRemove(ShortcutManager.ShortcutListType listType, int position, ShortcutData.ShortcutType type, int id, bool overrideFlag) { }

	// RVA: 0x175C33C Offset: 0x175833C VA: 0x175C33C
	public void .ctor() { }

	// RVA: 0x175C440 Offset: 0x1758440 VA: 0x175C440
	private static void .cctor() { }
}
