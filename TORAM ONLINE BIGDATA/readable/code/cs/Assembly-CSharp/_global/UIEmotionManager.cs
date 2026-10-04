// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEmotionManager : UIBasePanel // TypeDefIndex: 8147
{
	// Fields
	private readonly int maxColumnsNumber; // 0x2C
	private PlayerDataManager playerDataManager; // 0x30
	[SerializeField]
	private GameObject[] actionButtons; // 0x38
	private UIScrollWindow scrollWindow; // 0x40
	[SerializeField]
	private GameObject scrollWindowButton; // 0x48
	[SerializeField]
	private UIIruna2Anchor buttonsAnchor; // 0x50
	[SerializeField]
	private GameObject settingWindow; // 0x58
	[SerializeField]
	private GameObject favoriteSettingButton; // 0x60
	[SerializeField]
	private GameObject dispSwitchButton; // 0x68
	[SerializeField]
	private GameObject checkBox; // 0x70
	[SerializeField]
	private UILabel switchButtonLabel; // 0x78
	[SerializeField]
	private UILabel messageLabel; // 0x80
	[SerializeField]
	private GameObject scrollWindowSimpleButton; // 0x88
	private UIEmotionBar emotionBar; // 0x90
	private Dictionary<int, UISprite> favoriteIconList; // 0x98
	private List<EmotionPlayer.EmotionType> favoriteEmotionList; // 0xA0
	private Dictionary<EmotionPlayer.EmotionType, UILabel> favoriteNumberLabel; // 0xA8
	private Dictionary<int, UIIcon> switchEmotionIconList; // 0xB0
	private bool isSetting; // 0xB8
	private EmotionPlayer.EmotionType[] emotionList; // 0xC0

	// Methods

	// RVA: 0x1CD7E0C Offset: 0x1CD3E0C VA: 0x1CD7E0C
	private void Start() { }

	// RVA: 0x1CD8920 Offset: 0x1CD4920 VA: 0x1CD8920
	private void SetButton(EmotionPlayer.EmotionType id, int no, float x, float y, bool isFade) { }

	// RVA: 0x1CD8D98 Offset: 0x1CD4D98 VA: 0x1CD8D98
	private GameObject CreateScrollWindowButton() { }

	// RVA: 0x1CD8E4C Offset: 0x1CD4E4C VA: 0x1CD8E4C
	public static string SetSimpleIconLabel(int id) { }

	// RVA: 0x1CD8440 Offset: 0x1CD4440 VA: 0x1CD8440
	private void SetScrollButton(bool isInitialize, bool isSimple) { }

	// RVA: 0x1CD8738 Offset: 0x1CD4738 VA: 0x1CD8738
	private void UpdateSwitchButtonLabel(bool isSimpleView) { }

	// RVA: 0x1CD9368 Offset: 0x1CD5368 VA: 0x1CD9368
	private void FavoriteIconSetActive(bool isInvisible) { }

	// RVA: 0x1CD9578 Offset: 0x1CD5578 VA: 0x1CD9578
	private void CloseSettingWindow() { }

	// RVA: 0x1CD86F4 Offset: 0x1CD46F4 VA: 0x1CD86F4
	private void ChangeDispFavorite(bool flag) { }

	// RVA: 0x1CD95E0 Offset: 0x1CD55E0 VA: 0x1CD95E0
	private void ResetFavoriteNumberLabel() { }

	// RVA: 0x1CD87C4 Offset: 0x1CD47C4 VA: 0x1CD87C4
	private void FavoriteNumberLabelUpdate() { }

	// RVA: 0x1CD9754 Offset: 0x1CD5754 VA: 0x1CD9754
	public void SwitchEmotionIcon(int id, EmotionPlayer.EmotionType type) { }

	// RVA: 0x1CD98C8 Offset: 0x1CD58C8 VA: 0x1CD98C8
	private void OnClickButton(int id) { }

	// RVA: 0x1CD9C0C Offset: 0x1CD5C0C VA: 0x1CD9C0C
	private void OnHoverButton(int id) { }

	// RVA: 0x1CD9CB0 Offset: 0x1CD5CB0 VA: 0x1CD9CB0
	private void OnDispButton() { }

	// RVA: 0x1CD9E2C Offset: 0x1CD5E2C VA: 0x1CD9E2C
	private void OnFavoriteSettingButton() { }

	// RVA: 0x1CD9E7C Offset: 0x1CD5E7C VA: 0x1CD9E7C
	private void OnSettingCompleteButton() { }

	// RVA: 0x1CD9F5C Offset: 0x1CD5F5C VA: 0x1CD9F5C
	private void OnSwitchButton() { }

	// RVA: 0x1CDA020 Offset: 0x1CD6020 VA: 0x1CDA020 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CDA150 Offset: 0x1CD6150 VA: 0x1CDA150 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CDA1F0 Offset: 0x1CD61F0 VA: 0x1CDA1F0
	public void .ctor() { }
}
