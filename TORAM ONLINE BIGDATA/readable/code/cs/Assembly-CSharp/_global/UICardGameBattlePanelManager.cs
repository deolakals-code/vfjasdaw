// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameBattlePanelManager : MonoBehaviour, IUICardGamePanel, IUICardGameNavigationPanelClick // TypeDefIndex: 5667
{
	// Fields
	[SerializeField]
	private UICardGamePlayerCardManager playerCard; // 0x20
	[SerializeField]
	private UICardGameBossCardManager bossCard; // 0x28
	[SerializeField]
	private UICardGameMarketCardManager marketCard; // 0x30
	[SerializeField]
	private BoxCollider marketArea; // 0x38
	[SerializeField]
	private BoxCollider playerArea; // 0x40
	[SerializeField]
	private GameObject changeDisplayArea; // 0x48
	[SerializeField]
	private UILabel warningLabel; // 0x50
	[SerializeField]
	private UISprite rewardIcon; // 0x58
	[SerializeField]
	private UISprite rewardMarketIcon; // 0x60
	[SerializeField]
	private GameObject windowPanel; // 0x68
	[SerializeField]
	private GameObject topPanel; // 0x70
	[SerializeField]
	private GameObject resultWaitLabel; // 0x78
	[SerializeField]
	private Transform pcTrans; // 0x80
	[SerializeField]
	private GameObject telopPanel; // 0x88
	[SerializeField]
	private TweenScale telopAnimation; // 0x90
	[SerializeField]
	private UILabel telopTitleLabel; // 0x98
	[SerializeField]
	private UILabel telopSubLabel; // 0xA0
	[SerializeField]
	private UILabel telopCenterLabel; // 0xA8
	[SerializeField]
	private UILabel telopCenterDynamicLabel; // 0xB0
	[SerializeField]
	private InactiveTimer telopInactiveTimer; // 0xB8
	[SerializeField]
	private TweenPosition telopCardAnimation; // 0xC0
	[SerializeField]
	private UITexture telopCardTexture; // 0xC8
	[SerializeField]
	private GameObject lastChanceSelectPanel; // 0xD0
	[SerializeField]
	private UILabel lastChanceSelectLabel; // 0xD8
	[SerializeField]
	private UILabel lastChanceSelectText; // 0xE0
	[SerializeField]
	private UISprite lastChanceSelectIcon; // 0xE8
	[SerializeField]
	private GameObject lastChanceWaitPanel; // 0xF0
	private CardGameManager gameManager; // 0xF8
	private UICardGameManager uiManager; // 0x100
	private GameObject bossTelop; // 0x108
	private Camera uiCamera; // 0x110
	private UICardGameBattlePanelManager.DisplayFlag displayFlag; // 0x118
	private UICardGameBattlePanelManager.DisplayMode displayMode; // 0x11C
	private Dictionary<UICardGameBattlePanelManager.DisplayMode, UICardGameBattlePanelManager.DisplayData> displayData; // 0x120
	private UICardGameNavigationPanel navigationPanel; // 0x128
	private SystemTextManager systemTextManager; // 0x130
	private int selectLastChanceId; // 0x138
	private Action timeUpAction; // 0x140
	private UICardGameBattlePanelManager.CardGamePhase nowphase; // 0x148
	[CompilerGenerated]
	private UICardGameCardBase <SelectCard>k__BackingField; // 0x150
	private UIPopWindow giveupWindow; // 0x158

	// Properties
	public UICardGameCardBase SelectCard { get; set; }
	public UICardGameBattlePanelManager.DisplayMode DispMode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17B9F9C Offset: 0x17B5F9C VA: 0x17B9F9C
	public UICardGameCardBase get_SelectCard() { }

	[CompilerGenerated]
	// RVA: 0x17B9FA4 Offset: 0x17B5FA4 VA: 0x17B9FA4
	private void set_SelectCard(UICardGameCardBase value) { }

	// RVA: 0x17B9FB4 Offset: 0x17B5FB4 VA: 0x17B9FB4
	public UICardGameBattlePanelManager.DisplayMode get_DispMode() { }

	// RVA: 0x17B9FBC Offset: 0x17B5FBC VA: 0x17B9FBC
	private void Awake() { }

	// RVA: 0x17BA400 Offset: 0x17B6400 VA: 0x17BA400
	private void Update() { }

	// RVA: 0x17BA628 Offset: 0x17B6628 VA: 0x17BA628 Slot: 4
	public void Initialize(UICardGameManager uiManager, CardGameManager gameManager) { }

	// RVA: 0x17BAA38 Offset: 0x17B6A38 VA: 0x17BAA38 Slot: 7
	public bool OnLeftTop() { }

	// RVA: 0x17BAC20 Offset: 0x17B6C20 VA: 0x17BAC20 Slot: 8
	public bool OnRightTop() { }

	// RVA: 0x17BAC28 Offset: 0x17B6C28 VA: 0x17BAC28 Slot: 5
	public void PanelDisable() { }

	// RVA: 0x17BB018 Offset: 0x17B7018 VA: 0x17BB018 Slot: 6
	public void PanelEnable() { }

	// RVA: 0x17BB0B8 Offset: 0x17B70B8 VA: 0x17BB0B8
	private void PopTelop(string title, string subText) { }

	// RVA: 0x17BB208 Offset: 0x17B7208 VA: 0x17BB208
	private void PopTelop(string label) { }

	// RVA: 0x17BB270 Offset: 0x17B7270 VA: 0x17BB270
	private void PopDynamicPopTelop(string label) { }

	// RVA: 0x17BB124 Offset: 0x17B7124 VA: 0x17BB124
	private void PopTelopData(string title, string subText, string center, string dynamicCenter) { }

	[IteratorStateMachine(typeof(UICardGameBattlePanelManager.<GameStartThread>d__61))]
	// RVA: 0x17BB2D8 Offset: 0x17B72D8 VA: 0x17BB2D8
	public IEnumerator GameStartThread(List<CardGameBossCard> bossDatas, int turnCount, int spina, List<CardGamePlayerCard> handCards, List<CardGamePlayerCard> marketCards, byte drawCardId, float timer) { }

	[IteratorStateMachine(typeof(UICardGameBattlePanelManager.<PlayPhaseThread>d__62))]
	// RVA: 0x17BB3E8 Offset: 0x17B73E8 VA: 0x17BB3E8
	private IEnumerator PlayPhaseThread(int turnCount, CardGamePlayerCard drawCard, int hand, float timer) { }

	// RVA: 0x17BB4C0 Offset: 0x17B74C0 VA: 0x17BB4C0
	public void ResetField(bool isInit, bool isLastChance, bool isLastChanceSelecter, byte turnCount, int spina, List<CardGamePlayerCard> handCards, List<CardGamePlayerCard> marketCards, byte[] drawUuids, float timer) { }

	// RVA: 0x17BC780 Offset: 0x17B8780 VA: 0x17BC780
	public void ResetTrunEndField(List<byte> turnEndMarketBuy, List<byte> turnEndMarketSell, CardGameTurnCardData turnEndAttack) { }

	// RVA: 0x17BCAC4 Offset: 0x17B8AC4 VA: 0x17BCAC4
	private bool SetAttackList(byte targetId, List<byte> cardId) { }

	// RVA: 0x17BCC98 Offset: 0x17B8C98 VA: 0x17BCC98
	public void UpdateResetTimer(float timer) { }

	[IteratorStateMachine(typeof(UICardGameBattlePanelManager.<PhaseBattle>d__67))]
	// RVA: 0x17BCCC8 Offset: 0x17B8CC8 VA: 0x17BCCC8
	public IEnumerator PhaseBattle(bool isNonTarget, bool isSpecialCard, byte turnCount) { }

	[IteratorStateMachine(typeof(UICardGameBattlePanelManager.<PhaseResult>d__68))]
	// RVA: 0x17BCD8C Offset: 0x17B8D8C VA: 0x17BCD8C
	public IEnumerator PhaseResult(bool isLastChance, bool isLastCheneUser, byte turnCount, int spina, List<CardGamePlayerCard> handCards, List<CardGamePlayerCard> marketCards, byte drawUuid, float timer) { }

	[IteratorStateMachine(typeof(UICardGameBattlePanelManager.<LastChanceThread>d__69))]
	// RVA: 0x17BCEA8 Offset: 0x17B8EA8 VA: 0x17BCEA8
	public IEnumerator LastChanceThread(bool lastChanceSelector, byte turnCount, byte type, int spina, int hand, int timer, List<CardGamePlayerCard> drawEffectCard, CardGamePlayerCard drawCard, CardGameBossCard bossDatas) { }

	// RVA: 0x17BCFD4 Offset: 0x17B8FD4 VA: 0x17BCFD4
	public void GameFinishWait() { }

	// RVA: 0x17BC2AC Offset: 0x17B82AC VA: 0x17BC2AC
	public void SetPhaseStartUI(UICardGameBattlePanelManager.CardGamePhase phase) { }

	// RVA: 0x17BC27C Offset: 0x17B827C VA: 0x17BC27C
	public void SetDisplayFlag(UICardGameBattlePanelManager.DisplayFlag flag) { }

	// RVA: 0x17BBA84 Offset: 0x17B7A84 VA: 0x17BBA84
	public void DestroyCardAll() { }

	// RVA: 0x17BD31C Offset: 0x17B931C VA: 0x17BD31C
	public void AttackPlayerCard(int uniqueId, bool recycle) { }

	// RVA: 0x17BD33C Offset: 0x17B933C VA: 0x17BD33C
	public void CancelAttack(int playerId, bool recycle) { }

	// RVA: 0x17BD35C Offset: 0x17B935C VA: 0x17BD35C
	public void DeadBossCard(int uniqueId) { }

	// RVA: 0x17BD40C Offset: 0x17B940C VA: 0x17BD40C
	public void UpdateBossUI(int uniqueId, CardGameBossCard cardData, bool damage) { }

	// RVA: 0x17BD524 Offset: 0x17B9524 VA: 0x17BD524
	public void SetActiveHpUI(int uniqueId) { }

	// RVA: 0x17BD5D8 Offset: 0x17B95D8 VA: 0x17BD5D8
	public void OtherPlayerAttack(int uniqueId) { }

	// RVA: 0x17BD688 Offset: 0x17B9688 VA: 0x17BD688
	public bool GetBossPosition(int bossId, out Vector3 position) { }

	// RVA: 0x17BD84C Offset: 0x17B984C VA: 0x17BD84C Slot: 9
	public void OnClickMarketButton() { }

	// RVA: 0x17BD904 Offset: 0x17B9904 VA: 0x17BD904 Slot: 10
	public void OnClickBattleButton() { }

	// RVA: 0x17BD9B8 Offset: 0x17B99B8 VA: 0x17BD9B8 Slot: 11
	public void OnClickPhaseEndButton() { }

	// RVA: 0x17BDB98 Offset: 0x17B9B98 VA: 0x17BDB98
	public void OnClickPhaseEndWndYes() { }

	// RVA: 0x17BDCBC Offset: 0x17B9CBC VA: 0x17BDCBC
	public void OnClickPhaseEndWndNo() { }

	// RVA: 0x17BDD84 Offset: 0x17B9D84 VA: 0x17BDD84
	public void OnClickChangeDesplayAll() { }

	// RVA: 0x17BC4C4 Offset: 0x17B84C4 VA: 0x17BC4C4
	public void OnClick_LastChanceSelectId(int add) { }

	// RVA: 0x17BDE48 Offset: 0x17B9E48 VA: 0x17BDE48
	public void OnClick_LastChanceSelected() { }

	// RVA: 0x17BE084 Offset: 0x17BA084 VA: 0x17BE084
	public void TimeUpAction() { }

	// RVA: 0x17BE0A0 Offset: 0x17BA0A0 VA: 0x17BE0A0
	public void OnWarningLabel(string str) { }

	// RVA: 0x17BE114 Offset: 0x17BA114 VA: 0x17BE114
	public void OnRewardIcon(int bossId, int spina) { }

	// RVA: 0x17BE398 Offset: 0x17BA398 VA: 0x17BE398
	public void OpenBattleTelop(bool isDynamic, string text, string[] addText) { }

	// RVA: 0x17BE5C4 Offset: 0x17BA5C4 VA: 0x17BE5C4
	public bool SetSelectCard(UICardGameCardBase card, bool isHandCard) { }

	// RVA: 0x17BE72C Offset: 0x17BA72C VA: 0x17BE72C
	public void ReleaseSelectCard(UICardGameCardBase card) { }

	// RVA: 0x17BE76C Offset: 0x17BA76C VA: 0x17BE76C
	public void HitCheckSelectCard(Vector3 pos) { }

	// RVA: 0x17BC704 Offset: 0x17B8704 VA: 0x17BC704
	private void SetEnabledUI(bool enable) { }

	// RVA: 0x17BA4BC Offset: 0x17B64BC VA: 0x17BA4BC
	private void DisplayCard() { }

	[IteratorStateMachine(typeof(UICardGameBattlePanelManager.<moveRewardIcon>d__98))]
	// RVA: 0x17BE2E0 Offset: 0x17BA2E0 VA: 0x17BE2E0
	private IEnumerator moveRewardIcon(Vector3 start, Vector3 end, int spina) { }

	[IteratorStateMachine(typeof(UICardGameBattlePanelManager.<moveSpinaRewardIcon>d__99))]
	// RVA: 0x17BF83C Offset: 0x17BB83C VA: 0x17BF83C
	private IEnumerator moveSpinaRewardIcon(int num) { }

	// RVA: 0x17BE6C4 Offset: 0x17BA6C4 VA: 0x17BE6C4
	private void SetMarketArea(bool active) { }

	// RVA: 0x17BE694 Offset: 0x17BA694 VA: 0x17BE694
	private void SetPlayerArea(bool active) { }

	// RVA: 0x17BF8E0 Offset: 0x17BB8E0 VA: 0x17BF8E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17BF8E8 Offset: 0x17BB8E8 VA: 0x17BF8E8
	private void <OnLeftTop>b__53_0() { }

	[CompilerGenerated]
	// RVA: 0x17BFAB4 Offset: 0x17BBAB4 VA: 0x17BFAB4
	private void <OnLeftTop>b__53_1() { }
}
