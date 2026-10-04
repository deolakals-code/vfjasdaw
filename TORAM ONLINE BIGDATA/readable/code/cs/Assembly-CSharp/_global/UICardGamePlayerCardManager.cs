// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGamePlayerCardManager : MonoBehaviour // TypeDefIndex: 5711
{
	// Fields
	[SerializeField]
	private GameObject playerCard; // 0x20
	private List<UICardGamePlayerCard> handCardList; // 0x28
	private ItemTextManager itemTextManager; // 0x30
	private SkillTextManager skillTextManager; // 0x38
	private SystemTextManager systemTextManager; // 0x40
	[CompilerGenerated]
	private UICardGameBattlePanelManager <uiManager>k__BackingField; // 0x48

	// Properties
	public UICardGameBattlePanelManager uiManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17CBDB8 Offset: 0x17C7DB8 VA: 0x17CBDB8
	public UICardGameBattlePanelManager get_uiManager() { }

	[CompilerGenerated]
	// RVA: 0x17CBDC0 Offset: 0x17C7DC0 VA: 0x17CBDC0
	private void set_uiManager(UICardGameBattlePanelManager value) { }

	// RVA: 0x17CBDC8 Offset: 0x17C7DC8 VA: 0x17CBDC8
	public void Initialize(UICardGameBattlePanelManager manager) { }

	[IteratorStateMachine(typeof(UICardGamePlayerCardManager.<AllHandRedraw>d__10))]
	// RVA: 0x17CC02C Offset: 0x17C802C VA: 0x17CC02C
	public IEnumerator AllHandRedraw(List<CardGamePlayerCard> handCards, float height) { }

	// RVA: 0x17CC0EC Offset: 0x17C80EC VA: 0x17CC0EC
	public bool CreateHandCard(CardGamePlayerCard cardData) { }

	// RVA: 0x17CC108 Offset: 0x17C8108 VA: 0x17CC108
	public bool CreateHandCard(CardGamePlayerCard cardData, out UICardGamePlayerCard card) { }

	// RVA: 0x17CC544 Offset: 0x17C8544 VA: 0x17CC544
	public void AddHandCard(UICardGamePlayerCard uiCard) { }

	// RVA: 0x17CC730 Offset: 0x17C8730 VA: 0x17CC730
	public UICardGamePlayerCard RemoveHandCard(int uniqueId) { }

	// RVA: 0x17CC830 Offset: 0x17C8830 VA: 0x17CC830
	public void DestroyHandCardAll() { }

	// RVA: 0x17CC9E4 Offset: 0x17C89E4 VA: 0x17CC9E4
	public void DisplayHandCard(float interval, float height, float time) { }

	// RVA: 0x17CCB28 Offset: 0x17C8B28 VA: 0x17CCB28
	public void Attack(int uniqueId, bool recycle) { }

	// RVA: 0x17CCCC0 Offset: 0x17C8CC0 VA: 0x17CCCC0
	public void ReserveAttack(int playerId, int bossId, bool active) { }

	// RVA: 0x17CCD80 Offset: 0x17C8D80 VA: 0x17CCD80
	public void CancelAttack(int uniqueId, bool recycle) { }

	// RVA: 0x17CCE48 Offset: 0x17C8E48 VA: 0x17CCE48
	public void CheckCardList(List<CardGamePlayerCard> handList) { }

	// RVA: 0x17CD284 Offset: 0x17C9284 VA: 0x17CD284
	public void CloseCard() { }

	// RVA: 0x17CD388 Offset: 0x17C9388 VA: 0x17CD388
	public void OpenCard() { }

	// RVA: 0x17CD48C Offset: 0x17C948C VA: 0x17CD48C
	public void ActiveTargetLine(bool active) { }

	// RVA: 0x17CD570 Offset: 0x17C9570 VA: 0x17CD570
	public void SetEnabled(bool enable) { }

	// RVA: 0x17CC710 Offset: 0x17C8710 VA: 0x17CC710
	private void DisplayPlayerCard() { }

	// RVA: 0x17CC37C Offset: 0x17C837C VA: 0x17CC37C
	private UICardGamePlayerCard GetUIPlayerCard(int uniqueId) { }

	// RVA: 0x17CC454 Offset: 0x17C8454 VA: 0x17CC454
	private UICardGamePlayerCard GetPlayerCardUI(CardGamePlayerCard cardData) { }

	// RVA: 0x17CD65C Offset: 0x17C965C VA: 0x17CD65C
	private string GetCardName(byte type, int id) { }

	[IteratorStateMachine(typeof(UICardGamePlayerCardManager.<DestroyHandCard>d__29))]
	// RVA: 0x17CCC38 Offset: 0x17C8C38 VA: 0x17CCC38
	private IEnumerator DestroyHandCard(UICardGamePlayerCard obj) { }

	// RVA: 0x17CD7B8 Offset: 0x17C97B8 VA: 0x17CD7B8
	public void .ctor() { }
}
