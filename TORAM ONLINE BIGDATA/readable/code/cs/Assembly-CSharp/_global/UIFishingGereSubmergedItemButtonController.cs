// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingGereSubmergedItemButtonController : MonoBehaviour // TypeDefIndex: 7042
{
	// Fields
	[SerializeField]
	private GameObject[] displayContents; // 0x20
	[SerializeField]
	private UILabel progressTitleLabel; // 0x28
	[SerializeField]
	private UILabel progressValueLabel; // 0x30
	[SerializeField]
	private UISprite clearDecisionIcon; // 0x38
	[SerializeField]
	private UILabel submergedItemTitleLabel; // 0x40
	[SerializeField]
	private UILabel clearDecisionLabel; // 0x48
	[SerializeField]
	private UIIcon submergedItemIcon; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private bool isNeedUpdate; // 0x60
	private GameRecordManager gameRecordManager; // 0x68
	private FishingRandomTargetData targetData; // 0x70
	private ItemTextManager itemTextManager; // 0x78

	// Methods

	// RVA: 0x1A7F604 Offset: 0x1A7B604 VA: 0x1A7F604
	private void Start() { }

	// RVA: 0x1A7F700 Offset: 0x1A7B700 VA: 0x1A7F700
	private void Update() { }

	// RVA: 0x1A7F840 Offset: 0x1A7B840 VA: 0x1A7F840
	public void Initialize(bool isAchievement, bool isNeedUpdate, FishingRandomTargetData targetData) { }

	// RVA: 0x1A8008C Offset: 0x1A7C08C VA: 0x1A8008C
	public void ApplyProgressUI(string titleText, string valueText) { }

	// RVA: 0x1A800D0 Offset: 0x1A7C0D0 VA: 0x1A800D0
	public void ApplySubmergedItemUI(bool isMonthlyUpdate, bool caughtFlag, int itemId, string itemTitle, RewardType rewardType) { }

	// RVA: 0x1A7F9EC Offset: 0x1A7B9EC VA: 0x1A7F9EC
	private void ContentInitialize() { }

	// RVA: 0x1A7F710 Offset: 0x1A7B710 VA: 0x1A7F710
	private void UpdateProgressText() { }

	// RVA: 0x1A80280 Offset: 0x1A7C280 VA: 0x1A80280
	public void .ctor() { }
}
