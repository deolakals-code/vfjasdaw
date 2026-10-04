// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMagicBladeExSkillManager : UIBasePanelConnection // TypeDefIndex: 6815
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	[SerializeField]
	private GameObject tweenPanel; // 0x38
	[SerializeField]
	private UILabel mainTitleLabel; // 0x40
	[SerializeField]
	private UILabel tweenTitleLabel; // 0x48
	[SerializeField]
	private GameObject scrollWindowContent; // 0x50
	[SerializeField]
	private GameObject conditionSelectButton; // 0x58
	[SerializeField]
	private GameObject activeSkillSelectButton; // 0x60
	[SerializeField]
	private UIIcon scrollWindowTitleIcon; // 0x68
	[SerializeField]
	private string[] scrollWindowTitleIconSpriteNamas; // 0x70
	[SerializeField]
	private UILabel attentionLabel; // 0x78
	private PlayerDataManager playerDataManager; // 0x80
	private SkillTextManager skillTextManager; // 0x88
	private UIScrollWindow scrollWindow; // 0x90
	private UIIruna2Anchor scrollWindowAnchor; // 0x98
	private float contentStartPosY; // 0xA0
	private float buttonHeight; // 0xA4
	private EnchantedSpellConditionType selectedConditionType; // 0xA8
	private SkillId selectedSkillType; // 0xAC
	private int selectedSkillLevel; // 0xB0
	private EnchantedSpellConditionType beforeSelectConditionType; // 0xB4
	private SkillId beforeSelectSkillType; // 0xB8
	private static readonly SkillId[] ActiveSkillType; // 0x0
	private Dictionary<EnchantedSpellConditionType, string> selectButtonMessages; // 0xC0
	private Dictionary<EnchantedSpellConditionType, string> selectButtonIconSpriteNames; // 0xC8
	private UIMagicBladeExSkillManager.DisplayStatus displayStatus; // 0xD0
	private bool inputLock; // 0xD4
	private int enchantedSpellLevel; // 0xD8
	private ItemDBData.ItemType mainWeaponType; // 0xDC
	private ItemDBData.ItemType subWeaponType; // 0xE0
	private const string attentionMessageId = "MagicBladeExSkillAttentionMessage";
	private const string attentionEquipMessageId = "MagicBladeExSkillAttentionEquipMessage";

	// Methods

	// RVA: 0x1A094C4 Offset: 0x1A054C4 VA: 0x1A094C4
	private void Start() { }

	// RVA: 0x1A094C8 Offset: 0x1A054C8 VA: 0x1A094C8
	private void Initialized() { }

	// RVA: 0x1A095D0 Offset: 0x1A055D0 VA: 0x1A095D0
	private void SetSpellConditionMessage() { }

	// RVA: 0x1A0980C Offset: 0x1A0580C VA: 0x1A0980C
	private void ApplySelectButton(bool isSetCondition) { }

	// RVA: 0x1A09F74 Offset: 0x1A05F74 VA: 0x1A09F74
	private void OpenScrollWindow(bool isSetCondition) { }

	// RVA: 0x1A0AB0C Offset: 0x1A06B0C VA: 0x1A0AB0C
	private void CloseScrollWindow() { }

	// RVA: 0x1A0A05C Offset: 0x1A0605C VA: 0x1A0A05C
	private void CreatScrollWindowButtons(bool isSetCondition) { }

	// RVA: 0x1A099BC Offset: 0x1A059BC VA: 0x1A099BC
	private void SetSpellConditionButtonVisual(GameObject content, int conditionId) { }

	// RVA: 0x1A09BE8 Offset: 0x1A05BE8 VA: 0x1A09BE8
	private void SetSkillButtonVisual(GameObject content, int skillId) { }

	// RVA: 0x1A0AB90 Offset: 0x1A06B90 VA: 0x1A0AB90
	private void OnClickSpellConditionSelectButton(int param) { }

	// RVA: 0x1A0AC10 Offset: 0x1A06C10 VA: 0x1A0AC10
	private void OnClickSkillSelectButton(int param) { }

	[IteratorStateMachine(typeof(UIMagicBladeExSkillManager.<CloseUI>d__43))]
	// RVA: 0x1A0AC90 Offset: 0x1A06C90 VA: 0x1A0AC90
	private IEnumerator CloseUI(bool isLeftButton) { }

	// RVA: 0x1A0AD38 Offset: 0x1A06D38 VA: 0x1A0AD38
	public void OnClickOpenScrollWindow(bool isSetCondition) { }

	// RVA: 0x1A0ADCC Offset: 0x1A06DCC VA: 0x1A0ADCC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A0AE70 Offset: 0x1A06E70 VA: 0x1A0AE70 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A0AEE8 Offset: 0x1A06EE8 VA: 0x1A0AEE8
	public void .ctor() { }

	// RVA: 0x1A0B0CC Offset: 0x1A070CC VA: 0x1A0B0CC
	private static void .cctor() { }

	[IteratorStateMachine(typeof(UIMagicBladeExSkillManager.<<Initialized>g__LoadExSkillData|33_0>d))]
	[CompilerGenerated]
	// RVA: 0x1A09564 Offset: 0x1A05564 VA: 0x1A09564
	private IEnumerator <Initialized>g__LoadExSkillData|33_0() { }
}
