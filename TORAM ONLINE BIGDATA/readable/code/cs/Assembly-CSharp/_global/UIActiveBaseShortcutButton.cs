// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIActiveBaseShortcutButton : MonoBehaviour // TypeDefIndex: 6475
{
	// Fields
	private UIIconBase iconBase; // 0x20
	protected IUILabel iTypeLabel; // 0x28
	private IUILabel iExtensionLabel; // 0x30
	private bool isInit; // 0x38
	private PlayerDataManager playerManager; // 0x40
	private SystemTextManager systemManager; // 0x48
	private ItemTextManager itemManager; // 0x50
	[CompilerGenerated]
	private ShortcutData.ShortcutType <ShortcutType>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <ShortcutId>k__BackingField; // 0x5C

	// Properties
	protected PlayerDataManager playerDataManager { get; }
	protected SystemTextManager systemTextManager { get; }
	protected ItemTextManager itemTextManager { get; }
	public ShortcutData.ShortcutType ShortcutType { get; set; }
	public int ShortcutId { get; set; }

	// Methods

	// RVA: 0x194A140 Offset: 0x1946140 VA: 0x194A140
	protected PlayerDataManager get_playerDataManager() { }

	// RVA: 0x194A1C4 Offset: 0x19461C4 VA: 0x194A1C4
	protected SystemTextManager get_systemTextManager() { }

	// RVA: 0x194A2B0 Offset: 0x19462B0 VA: 0x194A2B0
	protected ItemTextManager get_itemTextManager() { }

	[CompilerGenerated]
	// RVA: 0x194A39C Offset: 0x194639C VA: 0x194A39C
	protected void set_ShortcutType(ShortcutData.ShortcutType value) { }

	[CompilerGenerated]
	// RVA: 0x194A3A4 Offset: 0x19463A4 VA: 0x194A3A4
	public ShortcutData.ShortcutType get_ShortcutType() { }

	[CompilerGenerated]
	// RVA: 0x194A3AC Offset: 0x19463AC VA: 0x194A3AC
	protected void set_ShortcutId(int value) { }

	[CompilerGenerated]
	// RVA: 0x194A3B4 Offset: 0x19463B4 VA: 0x194A3B4
	public int get_ShortcutId() { }

	// RVA: 0x194A3BC Offset: 0x19463BC VA: 0x194A3BC Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x194A3C0 Offset: 0x19463C0 VA: 0x194A3C0
	protected void Initialize(UIIconBase icon, IUILabel iBaseLabel, IUILabel iExLabel) { }

	// RVA: 0x194A410 Offset: 0x1946410 VA: 0x194A410 Slot: 5
	protected virtual void SetSprite(string name) { }

	// RVA: 0x194A414 Offset: 0x1946414 VA: 0x194A414
	private void Update() { }

	// RVA: 0x194A4B4 Offset: 0x19464B4 VA: 0x194A4B4 Slot: 6
	public virtual void SetShortcutButton(ShortcutData.ShortcutType type, int id) { }

	// RVA: 0x194A820 Offset: 0x1946820 VA: 0x194A820 Slot: 7
	protected virtual void GuardAvoid() { }

	// RVA: 0x194AA00 Offset: 0x1946A00 VA: 0x194AA00 Slot: 8
	protected virtual void ScreenshotButton() { }

	// RVA: 0x194AB9C Offset: 0x1946B9C VA: 0x194AB9C Slot: 9
	protected virtual void ItemButton(int id) { }

	// RVA: 0x194AD7C Offset: 0x1946D7C VA: 0x194AD7C Slot: 10
	protected virtual void EmotionButton(int id) { }

	// RVA: 0x194AF80 Offset: 0x1946F80 VA: 0x194AF80 Slot: 11
	protected virtual void SkillButton(int skillid) { }

	// RVA: 0x194B308 Offset: 0x1947308 VA: 0x194B308
	public void SetSkillLabel(int skillid) { }

	// RVA: 0x194B330 Offset: 0x1947330 VA: 0x194B330 Slot: 12
	protected virtual void SetSkillLabelData(int skillid, out bool isOverMp, out int mpCost) { }

	// RVA: 0x194B5F0 Offset: 0x19475F0 VA: 0x194B5F0 Slot: 13
	protected virtual void ActionButton(int id) { }

	// RVA: 0x194B6C8 Offset: 0x19476C8 VA: 0x194B6C8 Slot: 14
	protected virtual void ShortcutSetButton(int id) { }

	// RVA: 0x194B884 Offset: 0x1947884 VA: 0x194B884 Slot: 15
	protected virtual bool CheckAvatarSkillButton(ItemData equipItem, int skillId) { }

	// RVA: 0x194BB90 Offset: 0x1947B90 VA: 0x194BB90 Slot: 16
	protected virtual void MenuButton(int menuId) { }

	// RVA: 0x194C000 Offset: 0x1948000 VA: 0x194C000 Slot: 17
	protected virtual void FishButton() { }

	// RVA: 0x194C20C Offset: 0x194820C VA: 0x194C20C Slot: 18
	protected virtual void OtherButton(int id) { }

	// RVA: 0x194C3E0 Offset: 0x19483E0 VA: 0x194C3E0 Slot: 19
	protected virtual void ClearButton() { }

	// RVA: 0x194C578 Offset: 0x1948578 VA: 0x194C578
	public void .ctor() { }
}
