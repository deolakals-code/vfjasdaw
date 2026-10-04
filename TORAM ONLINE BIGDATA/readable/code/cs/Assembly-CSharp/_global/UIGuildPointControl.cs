// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildPointControl : MonoBehaviour, IUIGuild // TypeDefIndex: 7157
{
	// Fields
	private UIGuildPointControl.Menu menuState; // 0x20
	private UIGuildPointControl.BoosterType boosterType; // 0x24
	private UIGuildPointControl.PresentType presentType; // 0x28
	[SerializeField]
	private GameObject mainPanel; // 0x30
	[SerializeField]
	private GameObject cancelPanel; // 0x38
	private UILabel cancelLabel; // 0x40
	private bool cancelFlag; // 0x48
	[SerializeField]
	private GameObject titleObj; // 0x50
	private UILabel titleLabel; // 0x58
	private UISprite titleIcon; // 0x60
	[SerializeField]
	private UILabel MessageLabel; // 0x68
	[SerializeField]
	private GameObject buttonObj; // 0x70
	private UIImageButton imageButton; // 0x78
	private UILabel buttonLabel; // 0x80
	private UIButtonMessage buttonMessage; // 0x88
	[SerializeField]
	private GameObject historyObj; // 0x90
	private UILabel[] historyLabel; // 0x98
	[SerializeField]
	private GameObject waitObj; // 0xA0
	private UILabel waitLabel; // 0xA8
	[SerializeField]
	private GameObject boosterObj; // 0xB0
	[SerializeField]
	private GameObject selectObj; // 0xB8
	private UILabel[] announceLabel; // 0xC0
	[SerializeField]
	private GameObject leftButtonObj; // 0xC8
	[SerializeField]
	private GameObject rightButtonObj; // 0xD0
	[SerializeField]
	private GameObject guildPointObj; // 0xD8
	private UILabel[] guildPointLabel; // 0xE0
	private SystemTextManager systemTextManager; // 0xE8
	private PlayerDataManager playerDataManager; // 0xF0
	private ItemTextManager itemTextManager; // 0xF8
	private UIPopBaseWindow popWindow; // 0x100
	private UIPopWindow errWindow; // 0x108
	private bool windowActiveFlg; // 0x110
	private GuildManager guildManager; // 0x118
	private Action<int> callBack; // 0x120
	private Coroutine checkCoroutine; // 0x128
	[CompilerGenerated]
	private UIBasePanelControl <TopControl>k__BackingField; // 0x130

	// Properties
	public UIBasePanelControl TopControl { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1AA91A0 Offset: 0x1AA51A0 VA: 0x1AA91A0
	public UIBasePanelControl get_TopControl() { }

	[CompilerGenerated]
	// RVA: 0x1AA91A8 Offset: 0x1AA51A8 VA: 0x1AA91A8
	public void set_TopControl(UIBasePanelControl value) { }

	// RVA: 0x1AA91B8 Offset: 0x1AA51B8 VA: 0x1AA91B8
	private void Awake() { }

	// RVA: 0x1AA93A8 Offset: 0x1AA53A8 VA: 0x1AA93A8
	private void Update() { }

	// RVA: 0x1AA9590 Offset: 0x1AA5590 VA: 0x1AA9590
	private void OnDisable() { }

	// RVA: 0x1AA962C Offset: 0x1AA562C VA: 0x1AA962C
	public void Initialize(int param, Action<int> callBack) { }

	// RVA: 0x1AA98E0 Offset: 0x1AA58E0 VA: 0x1AA98E0
	private void InitPanel() { }

	[IteratorStateMachine(typeof(UIGuildPointControl.<checkContribution>d__47))]
	// RVA: 0x1AA9E6C Offset: 0x1AA5E6C VA: 0x1AA9E6C
	private IEnumerator checkContribution() { }

	// RVA: 0x1AAAEB0 Offset: 0x1AA6EB0 VA: 0x1AAAEB0
	private void CovertSuccess(GuildCollectContributionResponse response) { }

	// RVA: 0x1AA9ED8 Offset: 0x1AA5ED8 VA: 0x1AA9ED8
	private void ChangeBoosterLabel() { }

	// RVA: 0x1AAB39C Offset: 0x1AA739C VA: 0x1AAB39C
	private void BoosterSuccess() { }

	// RVA: 0x1AAA938 Offset: 0x1AA6938 VA: 0x1AAA938
	private void ChangePresentLabel() { }

	// RVA: 0x1AAB4B0 Offset: 0x1AA74B0 VA: 0x1AAB4B0
	private void PresentSuccess(GuildPresentResponse response) { }

	// RVA: 0x1AAB694 Offset: 0x1AA7694 VA: 0x1AAB694
	private void onSelectRight() { }

	// RVA: 0x1AAB6D4 Offset: 0x1AA76D4 VA: 0x1AAB6D4
	private void onSelectLeft() { }

	// RVA: 0x1AAB718 Offset: 0x1AA7718 VA: 0x1AAB718
	private void onLoadWindow() { }

	// RVA: 0x1AAB868 Offset: 0x1AA7868 VA: 0x1AAB868
	private void onOK() { }

	[IteratorStateMachine(typeof(UIGuildPointControl.<collectContribution>d__57))]
	// RVA: 0x1AAB908 Offset: 0x1AA7908 VA: 0x1AAB908
	private IEnumerator collectContribution() { }

	[IteratorStateMachine(typeof(UIGuildPointControl.<runBooster>d__58))]
	// RVA: 0x1AAB99C Offset: 0x1AA799C VA: 0x1AAB99C
	private IEnumerator runBooster(GuildBoosterType type) { }

	[IteratorStateMachine(typeof(UIGuildPointControl.<guildPresent>d__59))]
	// RVA: 0x1AABA40 Offset: 0x1AA7A40 VA: 0x1AABA40
	private IEnumerator guildPresent(GuildPresentType type) { }

	[IteratorStateMachine(typeof(UIGuildPointControl.<LoadingBarWindow>d__60))]
	// RVA: 0x1AAB7FC Offset: 0x1AA77FC VA: 0x1AAB7FC
	private IEnumerator LoadingBarWindow() { }

	[IteratorStateMachine(typeof(UIGuildPointControl.<PopUpWindow>d__61))]
	// RVA: 0x1AABB0C Offset: 0x1AA7B0C VA: 0x1AABB0C
	private IEnumerator PopUpWindow(UIPopBaseWindow popWindow, Func<UIPopBaseWindow, bool> theradCheck, Action<int> result) { }

	// RVA: 0x1AABBEC Offset: 0x1AA7BEC VA: 0x1AABBEC
	private bool PopUpWindowCheck(UIPopBaseWindow popWindow) { }

	// RVA: 0x1AABC38 Offset: 0x1AA7C38 VA: 0x1AABC38 Slot: 4
	public void OnClose() { }

	// RVA: 0x1AAB360 Offset: 0x1AA7360 VA: 0x1AAB360
	private void windowClose() { }

	// RVA: 0x1AABC3C Offset: 0x1AA7C3C VA: 0x1AABC3C
	private void AllWindowClose() { }

	// RVA: 0x1AABCC0 Offset: 0x1AA7CC0 VA: 0x1AABCC0
	private void ReturnTopMenu() { }

	// RVA: 0x1AABCF4 Offset: 0x1AA7CF4 VA: 0x1AABCF4
	private void ReturnTopMenu(int param) { }

	// RVA: 0x1AABD38 Offset: 0x1AA7D38 VA: 0x1AABD38
	private void OnDestroy() { }

	// RVA: 0x1AABD9C Offset: 0x1AA7D9C VA: 0x1AABD9C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1AABE40 Offset: 0x1AA7E40 VA: 0x1AABE40
	private void <checkContribution>b__47_0() { }

	[CompilerGenerated]
	// RVA: 0x1AABE74 Offset: 0x1AA7E74 VA: 0x1AABE74
	private void <collectContribution>b__57_0() { }

	[CompilerGenerated]
	// RVA: 0x1AABEA8 Offset: 0x1AA7EA8 VA: 0x1AABEA8
	private void <runBooster>b__58_0() { }

	[CompilerGenerated]
	// RVA: 0x1AABEDC Offset: 0x1AA7EDC VA: 0x1AABEDC
	private void <guildPresent>b__59_0() { }
}
