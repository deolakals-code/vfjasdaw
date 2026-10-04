// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameManager : UIBasePanelConnection // TypeDefIndex: 5685
{
	// Fields
	public const UIMainManager.UIElicitFlag CardGameFlag = 49164;
	private CardGameManager gameManager; // 0x30
	private UICardGameLobbyPanelManager lobbyPanel; // 0x38
	private UICardGameResultPanelManager resultPanel; // 0x40
	private UICardGameBattlePanelManager battlePanel; // 0x48
	private IUICardGamePanel activePanel; // 0x50
	private Action returnShortcut; // 0x58
	[CompilerGenerated]
	private bool <IsPopWindow>k__BackingField; // 0x60

	// Properties
	public bool IsPopWindow { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17C788C Offset: 0x17C388C VA: 0x17C788C
	public bool get_IsPopWindow() { }

	[CompilerGenerated]
	// RVA: 0x17C7894 Offset: 0x17C3894 VA: 0x17C7894
	public void set_IsPopWindow(bool value) { }

	// RVA: 0x17C78A0 Offset: 0x17C38A0 VA: 0x17C78A0
	private GameObject loadPanel(string prefabPath) { }

	// RVA: 0x17C7AA0 Offset: 0x17C3AA0 VA: 0x17C7AA0
	private void Awake() { }

	// RVA: 0x17C7F2C Offset: 0x17C3F2C VA: 0x17C7F2C
	private void Update() { }

	// RVA: 0x17C8000 Offset: 0x17C4000 VA: 0x17C8000
	private void OnDestroy() { }

	// RVA: 0x17C80A0 Offset: 0x17C40A0 VA: 0x17C80A0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17C829C Offset: 0x17C429C VA: 0x17C829C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17C83B0 Offset: 0x17C43B0 VA: 0x17C83B0 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x17C8438 Offset: 0x17C4438 VA: 0x17C8438
	public bool JoinGame(byte state) { }

	// RVA: 0x17C86EC Offset: 0x17C46EC VA: 0x17C86EC
	public void InitStartGame(List<CardGameBossCard> bossDatas, int turnCount, int spina, List<CardGamePlayerCard> handCards, List<CardGamePlayerCard> marketCards, byte drawCard, float timer) { }

	// RVA: 0x17C877C Offset: 0x17C477C VA: 0x17C877C
	public void ResetField(bool isInit, bool isLastChance, bool isLastChanceSelecter, byte turnCount, int spina, List<CardGamePlayerCard> handCards, List<CardGamePlayerCard> marketCards, byte[] drawUuids, float timer) { }

	// RVA: 0x17C87A8 Offset: 0x17C47A8 VA: 0x17C87A8
	public void ResetTrunEndField(List<byte> turnEndMarketBuy, List<byte> turnEndMarketSell, CardGameTurnCardData turnEndAttack) { }

	// RVA: 0x17C87C0 Offset: 0x17C47C0 VA: 0x17C87C0
	public void UpdateResetTimer(float timer) { }

	// RVA: 0x17C87D8 Offset: 0x17C47D8 VA: 0x17C87D8
	public void PhaseBattle(bool isNonTarget, bool isSpecialCard, byte turnCount) { }

	// RVA: 0x17C880C Offset: 0x17C480C VA: 0x17C880C
	public void PhaseResult(bool isLastChance, bool isLastChanceUser, byte turnCount, int spina, List<CardGamePlayerCard> handCards, List<CardGamePlayerCard> marketCards, byte drawUuid, float timer) { }

	// RVA: 0x17C8848 Offset: 0x17C4848 VA: 0x17C8848
	public void LastChanceThread(bool lastChanceSelector, byte turnCount, byte type, int spina, int hand, int timer, List<CardGamePlayerCard> drawEffectCard, CardGamePlayerCard drawCard, CardGameBossCard bossDatas) { }

	// RVA: 0x17C8888 Offset: 0x17C4888 VA: 0x17C8888
	public void GameFinishWait() { }

	// RVA: 0x17C88A0 Offset: 0x17C48A0 VA: 0x17C88A0
	public void GameFinish() { }

	[IteratorStateMachine(typeof(UICardGameManager.<OpenResultPanel>d__28))]
	// RVA: 0x17C88A8 Offset: 0x17C48A8 VA: 0x17C88A8
	public IEnumerator OpenResultPanel(CardGameResultData result, Dictionary<int, short> total, byte accumulationCount) { }

	// RVA: 0x17C897C Offset: 0x17C497C VA: 0x17C897C
	public void GameResultEnd() { }

	// RVA: 0x17C8998 Offset: 0x17C4998 VA: 0x17C8998
	public void GameRestart() { }

	// RVA: 0x17C89A0 Offset: 0x17C49A0 VA: 0x17C89A0
	public void UpdateGameSetting(CardGameSettingData setting) { }

	// RVA: 0x17C8A44 Offset: 0x17C4A44 VA: 0x17C8A44
	public void DestroyCardAll() { }

	// RVA: 0x17C8A5C Offset: 0x17C4A5C VA: 0x17C8A5C
	public void AttackPlayerCard(int uniqueId, bool recycle) { }

	// RVA: 0x17C8A84 Offset: 0x17C4A84 VA: 0x17C8A84
	public void CancelAttack(int playerId, bool recycle) { }

	// RVA: 0x17C8AAC Offset: 0x17C4AAC VA: 0x17C8AAC
	public void DeadBossCard(int uniqueId) { }

	// RVA: 0x17C8ACC Offset: 0x17C4ACC VA: 0x17C8ACC
	public void UpdateBossUI(int uniqueId, CardGameBossCard cardData, bool damage) { }

	// RVA: 0x17C8AF0 Offset: 0x17C4AF0 VA: 0x17C8AF0
	public void SetActiveHpUI(int uniqueId) { }

	// RVA: 0x17C8B10 Offset: 0x17C4B10 VA: 0x17C8B10
	public void OtherPlayerAttack(int uniqueId) { }

	// RVA: 0x17C8B30 Offset: 0x17C4B30 VA: 0x17C8B30
	public void OnClickLeave() { }

	// RVA: 0x17C8B60 Offset: 0x17C4B60 VA: 0x17C8B60
	public void SetReturnShortcut(Action action) { }

	// RVA: 0x17C8B68 Offset: 0x17C4B68 VA: 0x17C8B68
	public void OpenInfoWindow() { }

	// RVA: 0x17C8BA0 Offset: 0x17C4BA0 VA: 0x17C8BA0
	public void OnWarningLabel(string str) { }

	// RVA: 0x17C8BB8 Offset: 0x17C4BB8 VA: 0x17C8BB8
	public void OnRewardIcon(int bossId, int spina) { }

	// RVA: 0x17C8BD0 Offset: 0x17C4BD0 VA: 0x17C8BD0
	public void OpenBattleTelop(bool isDynamic, string text, string[] addText) { }

	// RVA: 0x17C8BEC Offset: 0x17C4BEC VA: 0x17C8BEC
	public void SetBeforeResult(byte accumulationCount, Dictionary<int, string> userName, Dictionary<int, short> gameScore, Dictionary<int, short> roomScore) { }

	[IteratorStateMachine(typeof(UICardGameManager.<ConnectionThread>d__46))]
	// RVA: 0x17BDFE8 Offset: 0x17B9FE8 VA: 0x17BDFE8
	public IEnumerator ConnectionThread(Func<bool> check, Action callback) { }

	[IteratorStateMachine(typeof(UICardGameManager.<PopWindow>d__47))]
	// RVA: 0x17C8C2C Offset: 0x17C4C2C VA: 0x17C8C2C
	public IEnumerator PopWindow(string titleText, string messageText, Action<int> callback) { }

	// RVA: 0x17C85BC Offset: 0x17C45BC VA: 0x17C85BC
	private void ChangePanel(IUICardGamePanel nextPane) { }

	// RVA: 0x17C7F0C Offset: 0x17C3F0C VA: 0x17C7F0C
	private void Leave() { }

	[IteratorStateMachine(typeof(UICardGameManager.<LeaveWait>d__50))]
	// RVA: 0x17C8D0C Offset: 0x17C4D0C VA: 0x17C8D0C
	private IEnumerator LeaveWait() { }

	// RVA: 0x17C8DA0 Offset: 0x17C4DA0 VA: 0x17C8DA0
	public void .ctor() { }
}
