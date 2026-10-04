// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillPopUpWindow : PopBaseWindow // TypeDefIndex: 8832
{
	// Fields
	private static readonly int maxLevel; // 0x0
	private static readonly int LimiteTextDelimitingCount; // 0x4
	private static readonly int AllWeapon; // 0x8
	private static readonly int Hand; // 0xC
	private int selectSkillId; // 0x20
	private int skillLevel; // 0x24
	private string lowerMessage; // 0x28
	private string buttonLabelText; // 0x30
	private bool isDefaultWindow; // 0x38
	private SkillTextManagerData skillTextManagerData; // 0x40
	private int messageAction; // 0x48
	private GameObject skillIcon; // 0x50
	private UILabel titleLabel; // 0x58
	private UILabel pageLabel; // 0x60
	private GameObject levelUpButton; // 0x68
	private GameObject TopLine; // 0x70
	private UILabel levelUpLabel; // 0x78
	private UIButtonSendMessage[] pointButton; // 0x80
	private GameObject labelObj; // 0x88
	private GameObject spriteObj; // 0x90
	private GameObject iconObj; // 0x98
	private GameObject limitIconObj; // 0xA0
	private GameObject uiButton; // 0xA8
	private bool canLevelUp; // 0xB0
	private SkillPopUpWindow.PointFlag pointFlag; // 0xB4
	private float intervalTime; // 0xB8
	private int nowPage; // 0xBC
	private List<GameObject> pageParentList; // 0xC0
	private List<SkillEqLimitFlag> limitFlags; // 0xC8
	private int mpCost; // 0xD0
	private bool isOverMp; // 0xD4
	private int skillPoint; // 0xD8
	private int useSkillPoint; // 0xDC
	private bool isAvatarSkill; // 0xE0
	private float limitUpdateTime; // 0xE4
	private float limitSwitchWaitTime; // 0xE8
	private int currentDisplayLimit; // 0xEC
	private SkillPopUpWindow.LimitDisplayState limitState; // 0xF0
	private UILabel limitTextLabel; // 0xF8
	private List<UISkillEquipLimitIcon> equiplimitIconList; // 0x100

	// Methods

	// RVA: 0x1E2A248 Offset: 0x1E26248 VA: 0x1E2A248
	public void .ctor(int skillId, int level, GameObject icon) { }

	// RVA: 0x1E2A3F4 Offset: 0x1E263F4 VA: 0x1E2A3F4
	public void .ctor(int skillId, int skillLv, string message, string buttonLabel, GameObject icon) { }

	// RVA: 0x1E2A5C8 Offset: 0x1E265C8 VA: 0x1E2A5C8
	public void .ctor(int skillId, int skillLv, string message, string buttonLabel, GameObject icon, bool isAvatarSkill) { }

	// RVA: 0x1E2A5EC Offset: 0x1E265EC VA: 0x1E2A5EC Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E2B4C4 Offset: 0x1E274C4 VA: 0x1E2B4C4 Slot: 5
	public override void Update() { }

	// RVA: 0x1E2BE04 Offset: 0x1E27E04 VA: 0x1E2BE04 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E2C130 Offset: 0x1E28130 VA: 0x1E2C130 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E2A84C Offset: 0x1E2684C VA: 0x1E2A84C
	private void CreateSkillPopUpWindow() { }

	// RVA: 0x1E2C138 Offset: 0x1E28138 VA: 0x1E2C138
	private void CreateOkButton(string text) { }

	// RVA: 0x1E2DE68 Offset: 0x1E29E68 VA: 0x1E2DE68
	private void CreateInfoParent() { }

	// RVA: 0x1E2C1F8 Offset: 0x1E281F8 VA: 0x1E2C1F8
	private void CreateSkillPopupPage(SkillMasterData skillMasterData) { }

	// RVA: 0x1E2C5E8 Offset: 0x1E285E8 VA: 0x1E2C5E8
	private void CreateMainPage(string messageText, SkillType type) { }

	// RVA: 0x1E2E64C Offset: 0x1E2A64C VA: 0x1E2E64C
	private void SetSkillTypeText(SkillType type, UILabel typeLabel, UILabel Message) { }

	// RVA: 0x1E2D120 Offset: 0x1E29120 VA: 0x1E2D120
	private void CreateDetailPage(SkillTreeType skillTreeType) { }

	// RVA: 0x1E2D658 Offset: 0x1E29658 VA: 0x1E2D658
	private void CreateLevelUpPage() { }

	// RVA: 0x1E2E1A8 Offset: 0x1E2A1A8 VA: 0x1E2E1A8
	private void SetLimitTypeIcon(UISkillEquipLimitIcon icon, SkillEqLimitFlag flag) { }

	// RVA: 0x1E2E7A0 Offset: 0x1E2A7A0 VA: 0x1E2E7A0
	private string GetItemTypName(SkillTextManagerData.SkillIconInfo iconInfo) { }

	// RVA: 0x1E2E8E8 Offset: 0x1E2A8E8 VA: 0x1E2E8E8
	private void SetEquipBonusIcon(UIIcon icon, SkillTextManagerData.SkillIconInfo iconInfo) { }

	// RVA: 0x1E2BF10 Offset: 0x1E27F10 VA: 0x1E2BF10
	private void PageSwitch() { }

	// RVA: 0x1E2EBC8 Offset: 0x1E2ABC8 VA: 0x1E2EBC8
	private void SetLevelUpButtonActive() { }

	// RVA: 0x1E2EA34 Offset: 0x1E2AA34 VA: 0x1E2EA34
	private void SetLevelUpText() { }

	// RVA: 0x1E2B700 Offset: 0x1E27700 VA: 0x1E2B700
	private void UpdateUseSkillPoint() { }

	// RVA: 0x1E2B97C Offset: 0x1E2797C VA: 0x1E2B97C
	private void LimitObjectsFade(float duration, float alpha) { }

	// RVA: 0x1E2BA98 Offset: 0x1E27A98 VA: 0x1E2BA98
	private void LimitTextLabelUpdate() { }

	// RVA: 0x1E2EC88 Offset: 0x1E2AC88 VA: 0x1E2EC88
	public void SetButtonEnabled(bool isEnabled) { }

	// RVA: 0x1E2ECEC Offset: 0x1E2ACEC VA: 0x1E2ECEC
	public void SetButtonMessageIcon(string iconName, Vector3 pos) { }

	// RVA: 0x1E2EDBC Offset: 0x1E2ADBC VA: 0x1E2EDBC
	private static void .cctor() { }
}
