// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameMarketCardManager : MonoBehaviour // TypeDefIndex: 5695
{
	// Fields
	[SerializeField]
	private UICardGameMarketCard marketCard; // 0x20
	private List<UICardGameCardBase> marketCardList; // 0x28
	[CompilerGenerated]
	private UICardGameBattlePanelManager <uiManager>k__BackingField; // 0x30

	// Properties
	public UICardGameBattlePanelManager uiManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17C9448 Offset: 0x17C5448 VA: 0x17C9448
	public UICardGameBattlePanelManager get_uiManager() { }

	[CompilerGenerated]
	// RVA: 0x17C9450 Offset: 0x17C5450 VA: 0x17C9450
	public void set_uiManager(UICardGameBattlePanelManager value) { }

	// RVA: 0x17C9458 Offset: 0x17C5458 VA: 0x17C9458
	private void Awake() { }

	// RVA: 0x17BA9A8 Offset: 0x17B69A8 VA: 0x17BA9A8
	public void Initialize(UICardGameBattlePanelManager manager) { }

	// RVA: 0x17C9484 Offset: 0x17C5484 VA: 0x17C9484
	public void CreateMarketCard(CardGamePlayerCard cardData) { }

	// RVA: 0x17BBAB0 Offset: 0x17B7AB0 VA: 0x17BBAB0
	public void CreateMarketCardData(bool inAnime, List<CardGamePlayerCard> cardData, float height) { }

	// RVA: 0x17BC0D4 Offset: 0x17B80D4 VA: 0x17BC0D4
	public void AddMarketCard(UICardGamePlayerCard uiCard) { }

	// RVA: 0x17BF110 Offset: 0x17BB110 VA: 0x17BF110
	public UICardGamePlayerCard RemoveMarketCard(int uniqueId) { }

	// RVA: 0x17BEF7C Offset: 0x17BAF7C VA: 0x17BEF7C
	public UICardGameCardBase DestroyMarketCard(int marketId) { }

	// RVA: 0x17BACA8 Offset: 0x17B6CA8 VA: 0x17BACA8
	public void DestroyMarketCardAll() { }

	[IteratorStateMachine(typeof(UICardGameMarketCardManager.<SaleCard>d__14))]
	// RVA: 0x17C1BF0 Offset: 0x17BDBF0 VA: 0x17C1BF0
	public IEnumerator SaleCard() { }

	// RVA: 0x17C9298 Offset: 0x17C5298 VA: 0x17C9298
	public void DisplayMarketCard() { }

	// RVA: 0x17BF6F4 Offset: 0x17BB6F4 VA: 0x17BF6F4
	public void DisplayCard(float interval, float height, float time) { }

	// RVA: 0x17BF260 Offset: 0x17BB260 VA: 0x17BF260
	public void SetEnabled(bool enable) { }

	// RVA: 0x17C97E8 Offset: 0x17C57E8 VA: 0x17C97E8
	public void .ctor() { }
}
