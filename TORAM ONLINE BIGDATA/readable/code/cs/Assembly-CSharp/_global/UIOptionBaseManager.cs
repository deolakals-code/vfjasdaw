// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIOptionBaseManager : UIBasePanel // TypeDefIndex: 7514
{
	// Fields
	private int initSelect; // 0x2C
	private bool initFlag; // 0x30
	protected int selectType; // 0x34
	protected UIScrollWindow scrollListWindow; // 0x38
	[SerializeField]
	protected GameObject optionButton; // 0x40
	protected Dictionary<int, UIOptionButton> buttonList; // 0x48
	protected int indexId; // 0x50
	protected Vector3 position; // 0x54
	protected UIPopBaseWindow popWindow; // 0x60
	protected InactiveTimer popWindowInactiveTimer; // 0x68
	protected bool cancelCheck; // 0x70
	protected float scrollHeight; // 0x74
	protected float baseHeight; // 0x78
	protected float initPlusHeight; // 0x7C
	protected string optionLabelTopText; // 0x80
	protected bool isSendOptionOperation; // 0x88
	protected const float FlagHeight = 150;
	protected const float SelectBarHeight = 180;
	protected const float ColorHeight = 350;

	// Properties
	public bool InitFlag { get; }
	public int InitSelect { get; set; }

	// Methods

	// RVA: 0x1B7B55C Offset: 0x1B7755C VA: 0x1B7B55C
	public bool get_InitFlag() { }

	// RVA: 0x1B7B564 Offset: 0x1B77564 VA: 0x1B7B564
	public int get_InitSelect() { }

	// RVA: 0x1B7B56C Offset: 0x1B7756C VA: 0x1B7B56C
	public void set_InitSelect(int value) { }

	// RVA: 0x1B7B580 Offset: 0x1B77580 VA: 0x1B7B580
	private void Awake() { }

	// RVA: 0x1B7B590 Offset: 0x1B77590 VA: 0x1B7B590
	private void Start() { }

	// RVA: 0x1B7BB7C Offset: 0x1B77B7C VA: 0x1B7BB7C Slot: 7
	protected virtual void Initialize() { }

	// RVA: 0x1B78728 Offset: 0x1B74728 VA: 0x1B78728
	protected void AddFlagButton(int type, bool flag) { }

	// RVA: 0x1B7BB80 Offset: 0x1B77B80 VA: 0x1B7BB80
	protected void AddFlagButton(int type, bool flag, string onText, string offText, bool isFlagDouble = False, string flagText) { }

	// RVA: 0x1B797B4 Offset: 0x1B757B4 VA: 0x1B797B4
	protected void AddWarningFlagButton(int type, bool flag) { }

	// RVA: 0x1B7BEC0 Offset: 0x1B77EC0 VA: 0x1B7BEC0
	protected void AddWarningFlagButton(int type, bool flag, string onText, string offText) { }

	// RVA: 0x1B796C4 Offset: 0x1B756C4 VA: 0x1B796C4
	protected void AddPercentButton(int type, byte percent, int start, float power) { }

	// RVA: 0x1B7884C Offset: 0x1B7484C VA: 0x1B7884C
	protected void AddColorButton(int type, Color32 color) { }

	// RVA: 0x1B79744 Offset: 0x1B75744 VA: 0x1B79744
	protected void AddSelectButton(int type, byte select, int num) { }

	// RVA: 0x1B7977C Offset: 0x1B7577C VA: 0x1B7977C
	protected void AddReverseSelectButton(int type, byte select, int num) { }

	// RVA: 0x1B7C264 Offset: 0x1B78264 VA: 0x1B7C264
	private UIOptionButton AddSelectButtonCreate(int type, byte select, int num) { }

	// RVA: 0x1B793B8 Offset: 0x1B753B8 VA: 0x1B793B8
	protected void AddSelectExButton(int type, byte select, int num) { }

	// RVA: 0x1B7C4CC Offset: 0x1B784CC VA: 0x1B7C4CC
	protected void AddSelectExButton(int type, byte select, int num, string mes) { }

	// RVA: 0x1B787B0 Offset: 0x1B747B0 VA: 0x1B787B0
	protected void AddSelectButton(int type, byte select, string[] textList) { }

	// RVA: 0x1B7C870 Offset: 0x1B78870 VA: 0x1B7C870
	protected void AddSelectExButton(int type, byte select, string[] textList, string[] textExList) { }

	// RVA: 0x1B7C918 Offset: 0x1B78918 VA: 0x1B7C918 Slot: 8
	protected virtual void AddBitCheckBoxButton(int type, byte bit, int num, Vector2[] pos, bool bitFlash) { }

	// RVA: 0x1B7CCF4 Offset: 0x1B78CF4 VA: 0x1B7CCF4
	protected void AddSelectAndFlagButton(int type, byte select, int num, bool flag, string checkBoxText) { }

	// RVA: 0x1B79040 Offset: 0x1B75040 VA: 0x1B79040
	protected void AddBitCheckBoxAndFlagButton(int type, byte bit, int num, Vector2[] pos, bool bitFlash, bool isActive) { }

	// RVA: 0x1B7D088 Offset: 0x1B79088 VA: 0x1B7D088
	protected void AddSwitchButton(int type, byte bit, string mesKey) { }

	// RVA: 0x1B7D130 Offset: 0x1B79130 VA: 0x1B7D130
	protected void AddSwitchButton(int type, byte[] bit, string mes) { }

	// RVA: 0x1B7BDC0 Offset: 0x1B77DC0 VA: 0x1B7BDC0
	protected UIOptionButton AddButton(string localize, int type) { }

	// RVA: 0x1B7C800 Offset: 0x1B78800 VA: 0x1B7C800
	protected UIOptionButton AddButton(string label, string mes, int type) { }

	// RVA: 0x1B7D664 Offset: 0x1B79664 VA: 0x1B7D664 Slot: 9
	protected virtual UIOptionButton AddButtonEx(string label, string mes, int type) { }

	// RVA: 0x1B7D8E0 Offset: 0x1B798E0 VA: 0x1B7D8E0
	protected void AddFlagButton(int type, bool flag, float height) { }

	// RVA: 0x1B7D984 Offset: 0x1B79984 VA: 0x1B7D984
	protected void AddFlagButton(int type, bool flag, string onText, string offText, float height) { }

	// RVA: 0x1B7DA74 Offset: 0x1B79A74 VA: 0x1B7DA74
	protected void AddFlagButton(int type, bool flag, string onText, string offText, bool isFlagDouble, float height) { }

	// RVA: 0x1B7DAB8 Offset: 0x1B79AB8 VA: 0x1B7DAB8
	protected void AddFlagButton(int type, bool flag, string onText, string offText, bool isFlagDouble, string flagText, float height) { }

	// RVA: 0x1B7DAF8 Offset: 0x1B79AF8 VA: 0x1B7DAF8 Slot: 10
	protected virtual void AddBitCheckBoxButton(int type, byte bit, int num, Vector2[] pos, bool bitFlash, float height) { }

	// RVA: 0x1B7DB3C Offset: 0x1B79B3C VA: 0x1B7DB3C
	protected void AddSelectBarButton(int type, byte select, int num, int defaultParam, float height) { }

	// RVA: 0x1B7DBEC Offset: 0x1B79BEC VA: 0x1B7DBEC
	protected void AddSelectBarButton(int type, byte select, string[] textList, int defaultParam, float height) { }

	// RVA: 0x1B7DC9C Offset: 0x1B79C9C VA: 0x1B7DC9C
	protected void AddSelectBarExButton(int type, byte select, string[] textList, string[] textExList, int defaultParam, float height) { }

	// RVA: 0x1B7DD54 Offset: 0x1B79D54 VA: 0x1B7DD54
	protected void AddColorButton(int type, Color32 color, Color32 defaultColor, float height, bool isTextColorUpdate = False) { }

	// RVA: 0x1B7DE6C Offset: 0x1B79E6C VA: 0x1B7DE6C
	protected void AddSwitchButton(int type, int select, int textNum, float height) { }

	// RVA: 0x1B7E0D8 Offset: 0x1B7A0D8 VA: 0x1B7E0D8
	protected void AddSwitchButton(int type, int select, string[] text, string[] textEx, float height) { }

	// RVA: 0x1B7E1A0 Offset: 0x1B7A1A0 VA: 0x1B7E1A0
	protected void AddPercentButton(int type, byte percent, int start, float power, float height) { }

	// RVA: 0x1B7E1D8 Offset: 0x1B7A1D8 VA: 0x1B7E1D8
	protected void AddSelectBarAndFlagButton(int type, byte select, int defaultParam, int num, string[] textList, bool flag, string checkBoxText, float height) { }

	// RVA: 0x1B7E2DC Offset: 0x1B7A2DC VA: 0x1B7E2DC
	protected UIOptionButton AddButtonExHeight(string label, string mes, int type, float height) { }

	// RVA: 0x1B7E328 Offset: 0x1B7A328 VA: 0x1B7E328
	protected void AddBitCheckBoxAndFlagButton(int type, byte bit, int num, Vector2[] pos, bool bitFlash, bool isActive, float height) { }

	// RVA: 0x1B7E368 Offset: 0x1B7A368 VA: 0x1B7E368
	protected void AddReverseSelectButton(int type, byte select, int num, int defaultParam, float height) { }

	// RVA: 0x1B7E42C Offset: 0x1B7A42C VA: 0x1B7E42C
	protected void AddWarningFlagButton(int type, bool flag, float height) { }

	// RVA: 0x1B7D9C8 Offset: 0x1B799C8 VA: 0x1B7D9C8
	private void SetButtonHeight(int type, float height) { }

	// RVA: 0x1B7E4D0 Offset: 0x1B7A4D0 VA: 0x1B7E4D0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B7E5E8 Offset: 0x1B7A5E8 VA: 0x1B7E5E8 Slot: 6
	public override void OnRightTopButton() { }

	[IteratorStateMachine(typeof(UIOptionBaseManager.<PushTopButton>d__68))]
	// RVA: 0x1B7E56C Offset: 0x1B7A56C VA: 0x1B7E56C
	private IEnumerator PushTopButton(UIActiveState nextActive) { }

	[IteratorStateMachine(typeof(UIOptionBaseManager.<SendAvatarOptionOperation>d__69))]
	// RVA: 0x1B7E688 Offset: 0x1B7A688 VA: 0x1B7E688
	private IEnumerator SendAvatarOptionOperation() { }

	// RVA: 0x1B7A1D8 Offset: 0x1B761D8 VA: 0x1B7A1D8
	protected void PopWindowOpen() { }

	// RVA: 0x1B7A538 Offset: 0x1B76538 VA: 0x1B7A538
	protected void PopWindowClose() { }

	// RVA: 0x1B7E71C Offset: 0x1B7A71C VA: 0x1B7E71C
	protected void ChangeEnableScrollWindow(bool isEnable) { }

	// RVA: 0x1B7E774 Offset: 0x1B7A774 VA: 0x1B7E774
	public void OnClickColorButton(int id, int param) { }

	// RVA: 0x1B7E98C Offset: 0x1B7A98C VA: 0x1B7E98C
	public void ColorButton(Color color) { }

	// RVA: 0x1B7EA70 Offset: 0x1B7AA70 VA: 0x1B7EA70
	public void OnClickFlagButton(int id, int param) { }

	// RVA: 0x1B7EB38 Offset: 0x1B7AB38 VA: 0x1B7EB38
	public void OnClickWarningFlagButton(int id, int param) { }

	[IteratorStateMachine(typeof(UIOptionBaseManager.<PopWarningFlagWindow>d__77))]
	// RVA: 0x1B7EC30 Offset: 0x1B7AC30 VA: 0x1B7EC30
	private IEnumerator PopWarningFlagWindow(int param, bool isChangeFlag = True) { }

	// RVA: 0x1B7ECE0 Offset: 0x1B7ACE0 VA: 0x1B7ECE0 Slot: 11
	public virtual void OnBitCheckBoxButton(int id, int bitParam, string[] textList, Vector2[] position) { }

	// RVA: 0x1B7EEB4 Offset: 0x1B7AEB4 VA: 0x1B7EEB4
	public void BitCheckBoxButton(int param) { }

	// RVA: 0x1B7EF48 Offset: 0x1B7AF48 VA: 0x1B7EF48 Slot: 12
	public virtual void OnClickPercentButton(int id, int param, int startParam, float powerParam) { }

	// RVA: 0x1B7F11C Offset: 0x1B7B11C VA: 0x1B7F11C
	public void PercentButton(int param) { }

	// RVA: 0x1B7F260 Offset: 0x1B7B260 VA: 0x1B7F260 Slot: 13
	public virtual void OnClickSelectButton(int id, int addParam, int param, string[] textList) { }

	// RVA: 0x1B7F434 Offset: 0x1B7B434 VA: 0x1B7F434 Slot: 14
	public virtual void OnClickSelectAndFlagButton(int id, int addParam, int param, string[] textList, string checkBoxText, bool flag) { }

	// RVA: 0x1B7F61C Offset: 0x1B7B61C VA: 0x1B7F61C
	public void SelectButton(int param) { }

	// RVA: 0x1B7F72C Offset: 0x1B7B72C VA: 0x1B7F72C
	public void SelectAndFlagButton(int param, bool subParam) { }

	// RVA: 0x1B7F87C Offset: 0x1B7B87C VA: 0x1B7F87C
	public void OnBitCheckBoxAndFlagButton(int id, int bitParam, string[] textList, Vector2[] position) { }

	// RVA: 0x1B7FA50 Offset: 0x1B7BA50 VA: 0x1B7FA50
	private void BitCheckBoxAndFlagButton(int param) { }

	// RVA: 0x1B7FAE4 Offset: 0x1B7BAE4 VA: 0x1B7FAE4 Slot: 15
	public virtual void OnClickSwitchButton(int type, int bitParam, string[] textList, string[] textExList, int paramNum) { }

	// RVA: 0x1B7FC70 Offset: 0x1B7BC70 VA: 0x1B7FC70
	protected void SwichButton(int param, int num) { }

	// RVA: 0x1B7FD18 Offset: 0x1B7BD18 VA: 0x1B7FD18
	protected void SetSelectTypeId(int id) { }

	// RVA: 0x1B7FD20 Offset: 0x1B7BD20 VA: 0x1B7FD20
	public void OnNewClickFlagButton(int id, int param) { }

	// RVA: 0x1B805EC Offset: 0x1B7C5EC VA: 0x1B805EC
	private void FlagButton(int param) { }

	// RVA: 0x1B806A0 Offset: 0x1B7C6A0 VA: 0x1B806A0 Slot: 16
	public virtual void OnNewBitCheckBoxButton(int id, int bitParam, string[] textList, Vector2[] position) { }

	// RVA: 0x1B80890 Offset: 0x1B7C890 VA: 0x1B80890 Slot: 17
	public virtual void OnNewClickSelectBarButton(int id, int defaultParam, int addParam, int param, string[] textList) { }

	// RVA: 0x1B80A84 Offset: 0x1B7CA84 VA: 0x1B80A84
	public void OnNewClickColorButton(int id, int param) { }

	// RVA: 0x1B80D2C Offset: 0x1B7CD2C VA: 0x1B80D2C Slot: 18
	public virtual void OnNewClickSwitchButton(int id, int defaultParam, int addParam, int param, string[] textList) { }

	// RVA: 0x1B80F1C Offset: 0x1B7CF1C VA: 0x1B80F1C
	protected void SwitchButton(int param) { }

	// RVA: 0x1B80FD0 Offset: 0x1B7CFD0 VA: 0x1B80FD0 Slot: 19
	public virtual void OnNewClickPercentButton(int id, int defaultParam, int start, float power) { }

	// RVA: 0x1B811C8 Offset: 0x1B7D1C8 VA: 0x1B811C8 Slot: 20
	public virtual void OnNewClickSelectAndFlagButton(int id, int addParam, int param, int defaultParam, string[] textList, string checkBoxText, bool flag) { }

	// RVA: 0x1B813EC Offset: 0x1B7D3EC VA: 0x1B813EC
	protected void OnNewClickCallBack(int id, Action<Transform> createAction) { }

	// RVA: 0x1B814C4 Offset: 0x1B7D4C4 VA: 0x1B814C4
	public void OnNewBitCheckBoxAndFlagButton(int id, int bitParam, string[] textList, Vector2[] position) { }

	// RVA: 0x1B816B4 Offset: 0x1B7D6B4 VA: 0x1B816B4
	public void OnNewClickWarningFlagButton(int id, int param) { }

	// RVA: 0x1B80080 Offset: 0x1B7C080 VA: 0x1B80080
	protected void UpdateScrollList(int indexId, float height, bool isOpen) { }

	// RVA: 0x1B818D8 Offset: 0x1B7D8D8 VA: 0x1B818D8
	protected GameObject SettingObject(GameObject obj, Vector2 pos, float scale, Transform parent) { }

	// RVA: 0x1B81A20 Offset: 0x1B7DA20 VA: 0x1B81A20 Slot: 21
	protected virtual bool SetFlag(bool setFlag) { }

	// RVA: 0x1B81A28 Offset: 0x1B7DA28 VA: 0x1B81A28 Slot: 22
	protected virtual bool SetColor(Color setColor) { }

	// RVA: 0x1B81A30 Offset: 0x1B7DA30 VA: 0x1B81A30 Slot: 23
	protected virtual bool SetParam(int setParam) { }

	// RVA: 0x1B81A38 Offset: 0x1B7DA38 VA: 0x1B81A38 Slot: 24
	protected virtual string GetEnumType(int enumType) { }

	// RVA: 0x1B81A54 Offset: 0x1B7DA54 VA: 0x1B81A54 Slot: 25
	protected virtual bool CheckWarningPop(int param) { }

	// RVA: 0x1B78A08 Offset: 0x1B74A08 VA: 0x1B78A08
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B81A5C Offset: 0x1B7DA5C VA: 0x1B81A5C
	private void <OnNewClickWarningFlagButton>b__102_0(int retParam) { }
}
