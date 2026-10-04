// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISignBoardManager : Singleton<UISignBoardManager>, ISceneChangeManager // TypeDefIndex: 8849
{
	// Fields
	[CompilerGenerated]
	private bool <IsNearOtherSignboard>k__BackingField; // 0x20
	[CompilerGenerated]
	private UIBaseSignBoard <MostNearOtherSignboardData>k__BackingField; // 0x28
	[CompilerGenerated]
	private SignboardPropertyData <MySignboardPropertyData>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsPutUpSamePos>k__BackingField; // 0x38
	public const int PrintBoardMax = 5;
	private List<UIBaseSignBoard> signBoardList; // 0x40
	private UIBaseSignBoard mySignBoard; // 0x48
	private PlayerDataManager playerDataManager; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private ItemTextManager itemTextManager; // 0x60
	private bool signBoardHideFlag; // 0x68
	private bool isStopMySignboard; // 0x69
	private bool isEventComplete; // 0x6A
	private List<OrbItemData> orbItemList; // 0x70
	private const float printHeightMax = 100;
	private UIRecruitmentCristaSlotItem uiRecruitItem; // 0x78
	private Plane[] planes; // 0x80
	private List<KeyValuePair<float, UIBaseSignBoard>> activeBoardPairs; // 0x88
	private OrbItemManager oItemManager; // 0x90
	private bool isLockBoard; // 0x98
	private const int activeTotalHour = 6;
	private const int PrintPartyRecruitmentBoardMax = 3;
	private bool isAllPrint; // 0x99
	private List<UIBaseSignBoard> d3PrintList; // 0xA0
	private bool isForcePutAway; // 0xA8
	private int[] recruitItemFieldIds; // 0xB0
	private int[] bazaarFieldIds; // 0xB8

	// Properties
	public bool IsUseSignBoard { get; }
	public List<UIBaseSignBoard> OtherSignboardList { get; }
	public bool IsNearOtherSignboard { get; set; }
	public UIBaseSignBoard MostNearOtherSignboardData { get; set; }
	public bool IsCloseShortCutPanel { get; }
	public SignboardPropertyData MySignboardPropertyData { get; set; }
	public bool IsPutUpSamePos { get; set; }
	public bool IsMySignboard { get; }
	private OrbItemManager orbItemManager { get; }
	private bool IsActiveCondition { get; }
	private bool IsAllPrint { get; }

	// Methods

	// RVA: 0x1E33AE8 Offset: 0x1E2FAE8 VA: 0x1E33AE8
	public bool get_IsUseSignBoard() { }

	// RVA: 0x1E33B70 Offset: 0x1E2FB70 VA: 0x1E33B70
	public List<UIBaseSignBoard> get_OtherSignboardList() { }

	[CompilerGenerated]
	// RVA: 0x1E33B78 Offset: 0x1E2FB78 VA: 0x1E33B78
	public bool get_IsNearOtherSignboard() { }

	[CompilerGenerated]
	// RVA: 0x1E33B80 Offset: 0x1E2FB80 VA: 0x1E33B80
	private void set_IsNearOtherSignboard(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E33B8C Offset: 0x1E2FB8C VA: 0x1E33B8C
	public UIBaseSignBoard get_MostNearOtherSignboardData() { }

	[CompilerGenerated]
	// RVA: 0x1E33B94 Offset: 0x1E2FB94 VA: 0x1E33B94
	private void set_MostNearOtherSignboardData(UIBaseSignBoard value) { }

	// RVA: 0x1E33B9C Offset: 0x1E2FB9C VA: 0x1E33B9C
	public bool get_IsCloseShortCutPanel() { }

	[CompilerGenerated]
	// RVA: 0x1E33DB0 Offset: 0x1E2FDB0 VA: 0x1E33DB0
	public SignboardPropertyData get_MySignboardPropertyData() { }

	[CompilerGenerated]
	// RVA: 0x1E33DB8 Offset: 0x1E2FDB8 VA: 0x1E33DB8
	private void set_MySignboardPropertyData(SignboardPropertyData value) { }

	[CompilerGenerated]
	// RVA: 0x1E33DC0 Offset: 0x1E2FDC0 VA: 0x1E33DC0
	public bool get_IsPutUpSamePos() { }

	[CompilerGenerated]
	// RVA: 0x1E33DC8 Offset: 0x1E2FDC8 VA: 0x1E33DC8
	private void set_IsPutUpSamePos(bool value) { }

	// RVA: 0x1E334D0 Offset: 0x1E2F4D0 VA: 0x1E334D0
	public bool get_IsMySignboard() { }

	// RVA: 0x1E33DD4 Offset: 0x1E2FDD4 VA: 0x1E33DD4
	private OrbItemManager get_orbItemManager() { }

	// RVA: 0x1E33E40 Offset: 0x1E2FE40 VA: 0x1E33E40
	private bool get_IsActiveCondition() { }

	// RVA: 0x1E33EA4 Offset: 0x1E2FEA4 VA: 0x1E33EA4
	private bool get_IsAllPrint() { }

	// RVA: 0x1E33EAC Offset: 0x1E2FEAC VA: 0x1E33EAC
	private void Start() { }

	// RVA: 0x1E340A4 Offset: 0x1E300A4 VA: 0x1E340A4
	private void Update() { }

	// RVA: 0x1E341D8 Offset: 0x1E301D8 VA: 0x1E341D8
	private void LateUpdate() { }

	// RVA: 0x1E34290 Offset: 0x1E30290 VA: 0x1E34290
	private void OnRenderObject() { }

	// RVA: 0x1E34480 Offset: 0x1E30480 VA: 0x1E34480
	public void ChangeWaitPanel() { }

	// RVA: 0x1E312E4 Offset: 0x1E2D2E4 VA: 0x1E312E4
	public bool CheckLimitedSignBoard() { }

	// RVA: 0x1E3461C Offset: 0x1E3061C VA: 0x1E3461C
	public bool CheckCanPutUp(SignboardType type, out UISignBoardManager.PutUpReturnCode returnCode) { }

	// RVA: 0x1E34A18 Offset: 0x1E30A18 VA: 0x1E34A18
	public void SetAllPrintFlag(bool isAllPrint) { }

	// RVA: 0x1E34A1C Offset: 0x1E30A1C VA: 0x1E34A1C
	public void RenderD2Board(Camera camera) { }

	// RVA: 0x1E34BB4 Offset: 0x1E30BB4 VA: 0x1E34BB4
	public bool CheckWaitUIState(UIActiveState state) { }

	// RVA: 0x1E34BC0 Offset: 0x1E30BC0 VA: 0x1E34BC0
	public void AddOtherSignBoard(GameObject tracePlayerObject, SignboardPropertyData boardData) { }

	// RVA: 0x1E34F64 Offset: 0x1E30F64 VA: 0x1E34F64
	public void AddPartyRecruitmentBoard(int recruitmentId, int partyLeaderId, string partyName) { }

	// RVA: 0x1E3507C Offset: 0x1E3107C VA: 0x1E3507C
	public void AddPartyRecruitmentBoard(GameObject traceObject, int recruitmentId, int archetypeId, string name) { }

	// RVA: 0x1E352FC Offset: 0x1E312FC VA: 0x1E352FC
	public void DestroyPartyRecruitmentBoard(int recruitmentId) { }

	// RVA: 0x1E355F0 Offset: 0x1E315F0 VA: 0x1E355F0
	public void PutUpSlotExpansion(ItemSelectData data, int gold, int recruitItemId) { }

	// RVA: 0x1E35680 Offset: 0x1E31680 VA: 0x1E35680
	public void PutUpCristaExtraction(ItemSelectData data, int gold, int slotNo) { }

	// RVA: 0x1E35710 Offset: 0x1E31710 VA: 0x1E35710
	public void PutUpReinforceCristaAttach(ItemSelectData data, int gold, int slotNo, ItemSelectData cristaData) { }

	// RVA: 0x1E357B4 Offset: 0x1E317B4 VA: 0x1E357B4
	public void PutUpBazaar() { }

	// RVA: 0x1E35820 Offset: 0x1E31820 VA: 0x1E35820
	public void PutAway(bool isPropertyCheck = True) { }

	// RVA: 0x1E35894 Offset: 0x1E31894 VA: 0x1E35894
	public void StopSignBoard() { }

	// RVA: 0x1E35940 Offset: 0x1E31940 VA: 0x1E35940
	public void ExecuteSlotExpansion(int targetId, int itemId, DateTime time) { }

	// RVA: 0x1E359D0 Offset: 0x1E319D0 VA: 0x1E359D0
	public void ExecuteCristaExtraction(int targetId, int itemId, DateTime time) { }

	// RVA: 0x1E35A60 Offset: 0x1E31A60 VA: 0x1E35A60
	public void ExeCutesignboardOfReinforceCristaAttach(int targetId, int itemId, DateTime time) { }

	// RVA: 0x1E35AF0 Offset: 0x1E31AF0 VA: 0x1E35AF0
	public void ExeCutesignboardOfBazaar(int targetId, byte slotIndex, int num, bool isNotEnoughCancel, int autoLockFlag, DateTime time) { }

	// RVA: 0x1E35BB0 Offset: 0x1E31BB0 VA: 0x1E35BB0
	public void CheckSignBoard() { }

	// RVA: 0x1E35C00 Offset: 0x1E31C00 VA: 0x1E35C00
	public void PutUpResponse(PutUpSignboardResponse response) { }

	// RVA: 0x1E35F34 Offset: 0x1E31F34 VA: 0x1E35F34
	public void PutAwayResponse(PutAwaySignboardResponse response) { }

	// RVA: 0x1E36614 Offset: 0x1E32614 VA: 0x1E36614
	public void CheckResponse(CheckSignboardResponse response) { }

	// RVA: 0x1E367A0 Offset: 0x1E327A0 VA: 0x1E367A0
	public void EventSignboard(SignboardEvent events) { }

	// RVA: 0x1E36944 Offset: 0x1E32944 VA: 0x1E36944
	public void HideSignBoard(bool hideFlag) { }

	// RVA: 0x1E36950 Offset: 0x1E32950 VA: 0x1E36950
	public bool CheckNearCreateBoard() { }

	// RVA: 0x1E36868 Offset: 0x1E32868 VA: 0x1E36868
	public void EventComplete() { }

	// RVA: 0x1E36AC8 Offset: 0x1E32AC8 VA: 0x1E36AC8
	public bool ChangeIsSamePos() { }

	// RVA: 0x1E35528 Offset: 0x1E31528 VA: 0x1E35528
	public void DestroyMySignBoard() { }

	// RVA: 0x1E36AE0 Offset: 0x1E32AE0 VA: 0x1E36AE0
	public void SignBoardLeave() { }

	// RVA: 0x1E36CD8 Offset: 0x1E32CD8 VA: 0x1E36CD8
	public void DeleteSignboardType(SignboardType type) { }

	// RVA: 0x1E36790 Offset: 0x1E32790 VA: 0x1E36790
	public void ForcePutAwayMyBoard(bool isPropertyCheck = True) { }

	// RVA: 0x1E35C28 Offset: 0x1E31C28 VA: 0x1E35C28
	private void AddMySignBoard(SignboardType type) { }

	// RVA: 0x1E36F64 Offset: 0x1E32F64 VA: 0x1E36F64
	private bool UpdateGLPrintList() { }

	// RVA: 0x1E341DC Offset: 0x1E301DC VA: 0x1E341DC
	private void SignBoardUpdate() { }

	// RVA: 0x1E37218 Offset: 0x1E33218 VA: 0x1E37218
	private void MySignBoardUpdate() { }

	// RVA: 0x1E374F4 Offset: 0x1E334F4 VA: 0x1E374F4
	private void UpdateActiveBoardList() { }

	// RVA: 0x1E37BE4 Offset: 0x1E33BE4 VA: 0x1E37BE4
	private void PrintOtherSignboard() { }

	// RVA: 0x1E36020 Offset: 0x1E32020 VA: 0x1E36020
	private void UiUpdateAfterPutAway(PutAwaySignboardResponse response) { }

	// RVA: 0x1E37DEC Offset: 0x1E33DEC VA: 0x1E37DEC
	private Plane[] CalculateFrustumPlanes(Camera camera, Plane[] nowPlane) { }

	// RVA: 0x1E361A0 Offset: 0x1E321A0 VA: 0x1E361A0
	private void AfterPutAway(PutAwaySignboardResponse response) { }

	// RVA: 0x1E34958 Offset: 0x1E30958 VA: 0x1E34958
	private bool CheckOpenMap(SignboardType type) { }

	// RVA: 0x1E38018 Offset: 0x1E34018 VA: 0x1E38018 Slot: 4
	public void OnEnter() { }

	// RVA: 0x1E3801C Offset: 0x1E3401C VA: 0x1E3801C Slot: 5
	public void OnLeave() { }

	// RVA: 0x1E38034 Offset: 0x1E34034 VA: 0x1E38034
	public void .ctor() { }
}
