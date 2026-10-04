// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlackKnightTitleManager : UIBasePanelConnection // TypeDefIndex: 5867
{
	// Fields
	[SerializeField]
	private GameObject[] panelObject; // 0x30
	[SerializeField]
	private UITexture titlePanel; // 0x38
	[SerializeField]
	private UIBlackKnightSaveDataButton selectButton; // 0x40
	[SerializeField]
	private Camera viewportCamera; // 0x48
	[SerializeField]
	private UISprite fadePanelObject; // 0x50
	[SerializeField]
	private GameObject enterWindowPanel; // 0x58
	private UIScrollWindow allScrollList; // 0x60
	private byte panelState; // 0x68
	private BlackKnightRoomData roomData; // 0x70
	private UIPopBaseWindow popWindow; // 0x78
	private bool cancelCheck; // 0x80

	// Properties
	private bool isInRoom { get; }

	// Methods

	// RVA: 0x180CAC4 Offset: 0x1808AC4 VA: 0x180CAC4
	private bool get_isInRoom() { }

	// RVA: 0x180CB20 Offset: 0x1808B20 VA: 0x180CB20
	public void OpenSelectCharacterPanel() { }

	[IteratorStateMachine(typeof(UIBlackKnightTitleManager.<Start>d__15))]
	// RVA: 0x180CB2C Offset: 0x1808B2C VA: 0x180CB2C
	private IEnumerator Start() { }

	// RVA: 0x180CBC0 Offset: 0x1808BC0 VA: 0x180CBC0
	private void CameraSettings() { }

	// RVA: 0x180CD94 Offset: 0x1808D94 VA: 0x180CD94
	private void OnDestroy() { }

	// RVA: 0x180CE8C Offset: 0x1808E8C VA: 0x180CE8C
	private void ActivePanel(UIBlackKnightTitleManager.PanelStateType acitvePanelState) { }

	// RVA: 0x180D04C Offset: 0x180904C VA: 0x180D04C
	private void CreateCharacterList() { }

	[IteratorStateMachine(typeof(UIBlackKnightTitleManager.<FadeOut>d__20))]
	// RVA: 0x180D5C4 Offset: 0x18095C4 VA: 0x180D5C4
	private IEnumerator FadeOut() { }

	[IteratorStateMachine(typeof(UIBlackKnightTitleManager.<Leave>d__21))]
	// RVA: 0x180D658 Offset: 0x1809658 VA: 0x180D658
	private IEnumerator Leave() { }

	[IteratorStateMachine(typeof(UIBlackKnightTitleManager.<GameStart>d__22))]
	// RVA: 0x180D6EC Offset: 0x18096EC VA: 0x180D6EC
	private IEnumerator GameStart() { }

	// RVA: 0x180D780 Offset: 0x1809780 VA: 0x180D780
	public void OnClick_Title() { }

	// RVA: 0x180D978 Offset: 0x1809978 VA: 0x180D978
	public void OnClick_Select_Character(int saveId) { }

	// RVA: 0x180DB34 Offset: 0x1809B34 VA: 0x180DB34
	public void OnEnter(int param) { }

	// RVA: 0x180DD24 Offset: 0x1809D24 VA: 0x180DD24 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x180DDF4 Offset: 0x1809DF4 VA: 0x180DDF4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x180DEC4 Offset: 0x1809EC4 VA: 0x180DEC4 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x180DEC8 Offset: 0x1809EC8 VA: 0x180DEC8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x180DF2C Offset: 0x1809F2C VA: 0x180DF2C
	private void <OnClick_Title>b__23_1() { }

	[CompilerGenerated]
	// RVA: 0x180DF34 Offset: 0x1809F34 VA: 0x180DF34
	private void <OnClick_Select_Character>b__24_1() { }
}
