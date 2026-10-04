// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaEditEnhancePanel : MonoBehaviour, UIMobaEditBasePanel // TypeDefIndex: 6053
{
	// Fields
	[SerializeField]
	private GameObject titleBasePanel; // 0x20
	[SerializeField]
	private GameObject windowBaseFramePanel; // 0x28
	[SerializeField]
	private UISprite[] windowBaseFrameVerticals; // 0x30
	[SerializeField]
	private UISprite windowBasePanel; // 0x38
	[SerializeField]
	private UISprite glassSubIcon; // 0x40
	[SerializeField]
	private UILabel goldLabel; // 0x48
	[SerializeField]
	private UILabel haveAbilityNumLabel; // 0x50
	[SerializeField]
	private UISprite tierIcon; // 0x58
	[SerializeField]
	private UILabel tierLabel; // 0x60
	[SerializeField]
	private GameObject sellButtonElement; // 0x68
	[SerializeField]
	private GameObject buyButtonElement; // 0x70
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x78
	[SerializeField]
	private GameObject[] scrollAreaObjs; // 0x80
	private bool isOpenWindow; // 0x88
	private Dictionary<int, int> sellButtonList; // 0x90
	private Dictionary<int, int> buyButtonList; // 0x98
	private MobaRoomData mobaRoomData; // 0xA0
	private const int maxTier = 4;
	private List<MobaRoomData.MobaAbilityMasterData> masterDataList; // 0xA8
	private ItemPropertyTextManager itemPropertyTextManager; // 0xB0
	private SystemTextManager systemTextManager; // 0xB8
	private UIMobaMainGamePanel mainPanel; // 0xC0

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x18750D8 Offset: 0x18710D8 VA: 0x18750D8 Slot: 9
	public bool get_IsActive() { }

	// RVA: 0x18750F8 Offset: 0x18710F8 VA: 0x18750F8 Slot: 4
	public void Initialize(MobaRoomData mobaRoomData, UIMobaMainGamePanel mainPanel) { }

	[IteratorStateMachine(typeof(UIMobaEditEnhancePanel.<FadeIn>d__25))]
	// RVA: 0x18752D4 Offset: 0x18712D4 VA: 0x18752D4 Slot: 7
	public IEnumerator FadeIn() { }

	[IteratorStateMachine(typeof(UIMobaEditEnhancePanel.<FadeOut>d__26))]
	// RVA: 0x1875368 Offset: 0x1871368 VA: 0x1875368 Slot: 8
	public IEnumerator FadeOut() { }

	[IteratorStateMachine(typeof(UIMobaEditEnhancePanel.<PushLeftTopButton>d__27))]
	// RVA: 0x18753FC Offset: 0x18713FC VA: 0x18753FC Slot: 5
	public IEnumerator PushLeftTopButton(Action<bool> stayCheck) { }

	[IteratorStateMachine(typeof(UIMobaEditEnhancePanel.<PushRightTopButton>d__28))]
	// RVA: 0x18754AC Offset: 0x18714AC VA: 0x18754AC Slot: 6
	public IEnumerator PushRightTopButton(Action<bool> stayCheck) { }

	// RVA: 0x187555C Offset: 0x187155C VA: 0x187555C
	public void OnGlassIcon() { }

	// RVA: 0x187585C Offset: 0x187185C VA: 0x187585C
	public void OnSellElement(int param) { }

	// RVA: 0x187595C Offset: 0x187195C VA: 0x187595C
	public void OnBuyElement(int param) { }

	// RVA: 0x18755CC Offset: 0x18715CC VA: 0x18755CC
	private void ChangeFrameSize(bool isOpen) { }

	// RVA: 0x1875A5C Offset: 0x1871A5C VA: 0x1875A5C
	private void UpdateGold() { }

	// RVA: 0x1875A94 Offset: 0x1871A94 VA: 0x1875A94
	private void UpdateHaveAbilityNum() { }

	// RVA: 0x1875ACC Offset: 0x1871ACC VA: 0x1875ACC
	private void UpdateScrollPanel() { }

	// RVA: 0x1876770 Offset: 0x1872770 VA: 0x1876770
	private GameObject CreateButton(GameObject buttonObj, int abilityId, string abiText, string gold, Vector3 pos, UnityAction<int> action) { }

	// RVA: 0x1876948 Offset: 0x1872948 VA: 0x1876948
	private string GetTierIconName(int tier) { }

	// RVA: 0x18769CC Offset: 0x18729CC VA: 0x18769CC
	private void ChangeScrollActive(bool isActive) { }

	[IteratorStateMachine(typeof(UIMobaEditEnhancePanel.<Buy>d__39))]
	// RVA: 0x18759E0 Offset: 0x18719E0 VA: 0x18759E0
	private IEnumerator Buy(int param) { }

	[IteratorStateMachine(typeof(UIMobaEditEnhancePanel.<Sell>d__40))]
	// RVA: 0x18758E0 Offset: 0x18718E0 VA: 0x18758E0
	private IEnumerator Sell(int param) { }

	// RVA: 0x1876A74 Offset: 0x1872A74 VA: 0x1876A74
	public void .ctor() { }
}
