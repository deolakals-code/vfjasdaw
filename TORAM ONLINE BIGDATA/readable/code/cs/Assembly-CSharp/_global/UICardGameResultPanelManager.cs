// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameResultPanelManager : MonoBehaviour, IUICardGamePanel // TypeDefIndex: 5726
{
	// Fields
	[SerializeField]
	private GameObject resultPanel; // 0x20
	[SerializeField]
	private GameObject scorePanel; // 0x28
	[SerializeField]
	private GameObject elementBase; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private GameObject telopPanel; // 0x40
	[SerializeField]
	private UILabel telopCenterLabel; // 0x48
	[SerializeField]
	private TweenScale telopAnimation; // 0x50
	[SerializeField]
	private InactiveTimer telopInactiveTimer; // 0x58
	private UICardGameResultPanel cardGameResultPanel; // 0x60
	private CardGameManager gameManager; // 0x68
	private UICardGameManager uiManager; // 0x70
	private SystemTextManager systemTextManager; // 0x78

	// Methods

	// RVA: 0x17D0EB8 Offset: 0x17CCEB8 VA: 0x17D0EB8 Slot: 4
	public void Initialize(UICardGameManager uiManager, CardGameManager gameManager) { }

	// RVA: 0x17D1024 Offset: 0x17CD024 VA: 0x17D1024 Slot: 7
	public bool OnLeftTop() { }

	// RVA: 0x17D102C Offset: 0x17CD02C VA: 0x17D102C Slot: 8
	public bool OnRightTop() { }

	// RVA: 0x17D1034 Offset: 0x17CD034 VA: 0x17D1034 Slot: 5
	public void PanelDisable() { }

	// RVA: 0x17D1058 Offset: 0x17CD058 VA: 0x17D1058 Slot: 6
	public void PanelEnable() { }

	[IteratorStateMachine(typeof(UICardGameResultPanelManager.<OpenResultPanel>d__17))]
	// RVA: 0x17D107C Offset: 0x17CD07C VA: 0x17D107C
	public IEnumerator OpenResultPanel(CardGameResultData result, Dictionary<int, short> roomTotal, byte accumulationCount) { }

	// RVA: 0x17D1150 Offset: 0x17CD150 VA: 0x17D1150
	public void GameResultEnd() { }

	// RVA: 0x17D11FC Offset: 0x17CD1FC VA: 0x17D11FC
	private void PopTelop(string label) { }

	// RVA: 0x17D1288 Offset: 0x17CD288 VA: 0x17D1288
	public void .ctor() { }
}
