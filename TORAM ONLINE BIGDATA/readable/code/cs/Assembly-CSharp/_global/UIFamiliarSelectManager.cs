// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFamiliarSelectManager : UIBasePanelConnection // TypeDefIndex: 6799
{
	// Fields
	[SerializeField]
	private Transform popTransPanel; // 0x30
	[SerializeField]
	protected GameObject windowPanel; // 0x38
	[SerializeField]
	protected GameObject[] panelObjs; // 0x40
	[SerializeField]
	private UILabel titleLabel; // 0x48
	[SerializeField]
	protected GameObject windowBackPanel; // 0x50
	[SerializeField]
	protected UILabel messageLabel; // 0x58
	[SerializeField]
	protected GameObject selectButton; // 0x60
	[SerializeField]
	protected UILabel warningLabel; // 0x68
	[SerializeField]
	protected Transform modelParentAnchor; // 0x70
	[SerializeField]
	private GameObject okButton; // 0x78
	[SerializeField]
	protected UILabel okButtonLabel; // 0x80
	[SerializeField]
	private GameObject orbButton; // 0x88
	[SerializeField]
	private UIIruna2Anchor orbAnchor; // 0x90
	[SerializeField]
	private UILabel orbNumLabel; // 0x98
	[SerializeField]
	protected GameObject colorPanel; // 0xA0
	[SerializeField]
	protected GameObject colorTempPanel; // 0xA8
	[SerializeField]
	protected GameObject colorSwitchButton; // 0xB0
	[SerializeField]
	protected UILabel[] colorLabel; // 0xB8
	[SerializeField]
	protected UISprite[] colorSprite; // 0xC0
	[SerializeField]
	private UIIruna2DragPinch dragPinchPanel; // 0xC8
	[SerializeField]
	protected GameObject rushButton; // 0xD0
	[SerializeField]
	protected GameObject rushButtonBatsuIcon; // 0xD8
	[SerializeField]
	protected UILabel rushButtonLabel; // 0xE0
	[SerializeField]
	protected UIToggle[] rushSwitchButtons; // 0xE8
	[SerializeField]
	protected UILabel[] rushSwitchButtonLabels; // 0xF0
	protected byte activedServantId; // 0xF8
	protected byte[] activedServantColorPalletId; // 0x100
	protected int selectedServantId; // 0x108
	protected byte[] selectedServantEditColorPalletId; // 0x110
	protected byte[] selectedServantEditColorPalletSaveId; // 0x118
	private long servantPurchasedBitFlag; // 0x120
	private Dictionary<int, GameObject> cacheModelList; // 0x128
	protected GameObject activeModel; // 0x130
	private AnimationSimple activeModelAnimation; // 0x138
	protected byte actionType; // 0x140
	protected byte nextActionType; // 0x141
	protected bool isLoadingModel; // 0x142
	protected int serviceOrbNum; // 0x144
	protected int tempColorNum; // 0x148
	private byte[] tapAnimationList; // 0x150
	private int tapAniamtionIndex; // 0x158
	private Vector2 tapPosition; // 0x15C
	protected TweenScale checkTweenScale; // 0x168
	private GameObject loadingObject; // 0x170
	private int loadingCount; // 0x178
	protected UIFamiliarSelectManager.MaseterData[] servantModelMaseterList; // 0x180
	protected UIFamiliarSelectManager.PanelState panelState; // 0x188
	protected string settingLabelText; // 0x190
	protected bool isBattleActive; // 0x198
	protected PlayerDataManager playerDataManager; // 0x1A0
	protected int rushFlag; // 0x1A8
	protected float modelPosY; // 0x1AC
	protected float modelPosZ; // 0x1B0
	protected float modelRotX; // 0x1B4
	protected string selectButtonText; // 0x1B8
	protected string buyButtonText; // 0x1C0
	protected bool isInit; // 0x1C8

	// Properties
	protected int SettingRushFlag { get; }

	// Methods

	// RVA: 0x1A01EC4 Offset: 0x19FDEC4 VA: 0x1A01EC4
	protected int get_SettingRushFlag() { }

	[IteratorStateMachine(typeof(UIFamiliarSelectManager.<Start>d__63))]
	// RVA: 0x1A01FD4 Offset: 0x19FDFD4 VA: 0x1A01FD4 Slot: 8
	protected virtual IEnumerator Start() { }

	// RVA: 0x1A02068 Offset: 0x19FE068 VA: 0x1A02068
	private void Update() { }

	// RVA: 0x1A02228 Offset: 0x19FE228 VA: 0x1A02228
	public void PlayModelAnimation() { }

	// RVA: 0x1A02318 Offset: 0x19FE318 VA: 0x1A02318
	public void ReceiveUpdateServantPurchasedBitFlag(long updateFlag) { }

	// RVA: 0x1A02320 Offset: 0x19FE320 VA: 0x1A02320
	public void ReceiveUpdateActiveServant(byte bitId, int color) { }

	// RVA: 0x1A023B4 Offset: 0x19FE3B4 VA: 0x1A023B4
	protected void RepopSelectServant() { }

	// RVA: 0x1A02464 Offset: 0x19FE464 VA: 0x1A02464
	public void OnSelectServant(int add) { }

	[IteratorStateMachine(typeof(UIFamiliarSelectManager.<LoadServantModel>d__70))]
	// RVA: 0x1A02770 Offset: 0x19FE770 VA: 0x1A02770
	private IEnumerator LoadServantModel(int modelId, byte bitId) { }

	// RVA: 0x1A0281C Offset: 0x19FE81C VA: 0x1A0281C Slot: 9
	protected virtual void UpdateServantModel(int bitId, GameObject model) { }

	// RVA: 0x1A02D80 Offset: 0x19FED80 VA: 0x1A02D80 Slot: 10
	protected virtual void UpdateServantModelColor(byte r, byte g, byte b) { }

	// RVA: 0x1A03230 Offset: 0x19FF230 VA: 0x1A03230
	public void OnClickServantPress() { }

	// RVA: 0x1A032A0 Offset: 0x19FF2A0 VA: 0x1A032A0
	public void OnClickServantRelease() { }

	// RVA: 0x1A0334C Offset: 0x19FF34C VA: 0x1A0334C Slot: 11
	public virtual void OnClickEnter() { }

	// RVA: 0x1A037D0 Offset: 0x19FF7D0 VA: 0x1A037D0 Slot: 12
	protected virtual void ChangeFamiliaData(byte id, byte[] colorIds, int flag) { }

	// RVA: 0x1A039E4 Offset: 0x19FF9E4 VA: 0x1A039E4 Slot: 13
	protected virtual void ChangePanelState(UIFamiliarSelectManager.PanelState panelState) { }

	// RVA: 0x1A03BC4 Offset: 0x19FFBC4 VA: 0x1A03BC4
	protected void SetTitle(string title) { }

	// RVA: 0x1A02D64 Offset: 0x19FED64 VA: 0x1A02D64
	protected void SetMessage(string mes) { }

	[IteratorStateMachine(typeof(UIFamiliarSelectManager.<CloseSaveData>d__80))]
	// RVA: 0x1A03BE0 Offset: 0x19FFBE0 VA: 0x1A03BE0 Slot: 14
	protected virtual IEnumerator CloseSaveData(UIActiveState nextActiveState) { }

	// RVA: 0x1A03998 Offset: 0x19FF998 VA: 0x1A03998
	protected int ConvertColorPallet(byte[] colorIds) { }

	// RVA: 0x1A03C84 Offset: 0x19FFC84 VA: 0x1A03C84
	public void OnRush() { }

	// RVA: 0x1A03CA4 Offset: 0x19FFCA4 VA: 0x1A03CA4
	public void OnChangeFamiliaRushFlag() { }

	// RVA: 0x1A03D00 Offset: 0x19FFD00 VA: 0x1A03D00
	public void OnChangeHighFamiliaRushFlag() { }

	// RVA: 0x1A03D58 Offset: 0x19FFD58 VA: 0x1A03D58
	protected void UpdateRushButton() { }

	// RVA: 0x1A03DD4 Offset: 0x19FFDD4 VA: 0x1A03DD4 Slot: 15
	public virtual void UpdateRushSwitchButton(int flag) { }

	// RVA: 0x1A04010 Offset: 0x1A00010 VA: 0x1A04010 Slot: 16
	protected virtual void ChangeActiveRushButton(bool isActive) { }

	// RVA: 0x1A040A8 Offset: 0x1A000A8 VA: 0x1A040A8 Slot: 17
	protected virtual void PopUpBuyPanel() { }

	// RVA: 0x1A043A4 Offset: 0x1A003A4 VA: 0x1A043A4 Slot: 18
	protected virtual int GetServivePrice() { }

	// RVA: 0x1A043F8 Offset: 0x1A003F8 VA: 0x1A043F8 Slot: 19
	public virtual void OnClickBuyOrb() { }

	// RVA: 0x1A042E4 Offset: 0x1A002E4 VA: 0x1A042E4
	protected void UpdateOrbNumText() { }

	// RVA: 0x1A046E4 Offset: 0x1A006E4 VA: 0x1A046E4 Slot: 20
	protected virtual void PopUpColorPanel() { }

	// RVA: 0x1A04A48 Offset: 0x1A00A48 VA: 0x1A04A48
	public void OnClickSwitchPallet() { }

	// RVA: 0x1A04BA0 Offset: 0x1A00BA0 VA: 0x1A04BA0
	public void OnClickRedColorPallet(int add) { }

	// RVA: 0x1A04CB8 Offset: 0x1A00CB8 VA: 0x1A04CB8
	public void OnClickGreenColorPallet(int add) { }

	// RVA: 0x1A04CC4 Offset: 0x1A00CC4 VA: 0x1A04CC4
	public void OnClickTempColorPallet(int add) { }

	// RVA: 0x1A04D3C Offset: 0x1A00D3C VA: 0x1A04D3C
	public void OnClickBlueColorPallet(int add) { }

	// RVA: 0x1A04BAC Offset: 0x1A00BAC VA: 0x1A04BAC
	private void UpdateColorPallet(byte type, int add) { }

	// RVA: 0x1A04D48 Offset: 0x1A00D48 VA: 0x1A04D48 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A04E6C Offset: 0x1A00E6C VA: 0x1A04E6C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A04F04 Offset: 0x1A00F04 VA: 0x1A04F04
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A051DC Offset: 0x1A011DC VA: 0x1A051DC
	private void <ChangeFamiliaData>b__76_1() { }

	[CompilerGenerated]
	// RVA: 0x1A05378 Offset: 0x1A01378 VA: 0x1A05378
	private void <ChangeFamiliaData>b__76_2() { }

	[CompilerGenerated]
	// RVA: 0x1A0537C Offset: 0x1A0137C VA: 0x1A0537C
	private void <OnClickBuyOrb>b__90_1() { }

	[CompilerGenerated]
	// RVA: 0x1A055F8 Offset: 0x1A015F8 VA: 0x1A055F8
	private void <OnClickBuyOrb>b__90_2() { }
}
