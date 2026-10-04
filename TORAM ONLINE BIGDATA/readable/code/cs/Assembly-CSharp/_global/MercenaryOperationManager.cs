// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryOperationManager // TypeDefIndex: 694
{
	// Fields
	private Game game; // 0x10
	private PlayerDataManager pDataManager; // 0x18
	private ReconnectionManager reconnection; // 0x20
	private List<IReceiver<OperationResponseBase>> receiverList; // 0x28
	[CompilerGenerated]
	private PartnerDataManager <PartnerData>k__BackingField; // 0x30
	[CompilerGenerated]
	private OperationReceiver<ParameterGetActionSettingResponse> <PartnerRegisterReciver>k__BackingField; // 0x38
	[CompilerGenerated]
	private OperationReceiver<ParameterChangeActionSettingResponse> <PartnerChangeActionReciver>k__BackingField; // 0x40
	[CompilerGenerated]
	private OperationReceiver<MercenaryRegisterGetResponse> <MercenaryRegisterGetReceiver>k__BackingField; // 0x48
	[CompilerGenerated]
	private OperationReceiver<MercenaryRegisterResponse> <MercenaryRegisterReceiver>k__BackingField; // 0x50
	[CompilerGenerated]
	private OperationReceiver<MercenaryEmploymentListResponse> <MercenaryEmploymentListReceiver>k__BackingField; // 0x58
	[CompilerGenerated]
	private OperationReceiver<MercenaryJoinResponse> <MercenaryJoinReceiver>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <IsBanParty>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsNoChange>k__BackingField; // 0x69
	[CompilerGenerated]
	private bool <IsValueWrong>k__BackingField; // 0x6A
	[CompilerGenerated]
	private bool <IsPartnerAbnormalStatus>k__BackingField; // 0x6B
	[CompilerGenerated]
	private GameReturnCode <JoinReturnCode>k__BackingField; // 0x6C

	// Properties
	public PartnerDataManager PartnerData { get; set; }
	public OperationReceiver<ParameterGetActionSettingResponse> PartnerRegisterReciver { get; set; }
	public OperationReceiver<ParameterChangeActionSettingResponse> PartnerChangeActionReciver { get; set; }
	public OperationReceiver<MercenaryRegisterGetResponse> MercenaryRegisterGetReceiver { get; set; }
	public OperationReceiver<MercenaryRegisterResponse> MercenaryRegisterReceiver { get; set; }
	public OperationReceiver<MercenaryEmploymentListResponse> MercenaryEmploymentListReceiver { get; set; }
	public OperationReceiver<MercenaryJoinResponse> MercenaryJoinReceiver { get; set; }
	public bool IsBanParty { get; set; }
	public bool IsNoChange { get; set; }
	public bool IsValueWrong { get; set; }
	public bool IsPartnerAbnormalStatus { get; set; }
	public GameReturnCode JoinReturnCode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1AC49AC Offset: 0x1AC09AC VA: 0x1AC49AC
	public PartnerDataManager get_PartnerData() { }

	[CompilerGenerated]
	// RVA: 0x1AC49B4 Offset: 0x1AC09B4 VA: 0x1AC49B4
	private void set_PartnerData(PartnerDataManager value) { }

	[CompilerGenerated]
	// RVA: 0x1AC49BC Offset: 0x1AC09BC VA: 0x1AC49BC
	public OperationReceiver<ParameterGetActionSettingResponse> get_PartnerRegisterReciver() { }

	[CompilerGenerated]
	// RVA: 0x1AC49C4 Offset: 0x1AC09C4 VA: 0x1AC49C4
	private void set_PartnerRegisterReciver(OperationReceiver<ParameterGetActionSettingResponse> value) { }

	[CompilerGenerated]
	// RVA: 0x1AC49CC Offset: 0x1AC09CC VA: 0x1AC49CC
	public OperationReceiver<ParameterChangeActionSettingResponse> get_PartnerChangeActionReciver() { }

	[CompilerGenerated]
	// RVA: 0x1AC49D4 Offset: 0x1AC09D4 VA: 0x1AC49D4
	private void set_PartnerChangeActionReciver(OperationReceiver<ParameterChangeActionSettingResponse> value) { }

	[CompilerGenerated]
	// RVA: 0x1AC49DC Offset: 0x1AC09DC VA: 0x1AC49DC
	public OperationReceiver<MercenaryRegisterGetResponse> get_MercenaryRegisterGetReceiver() { }

	[CompilerGenerated]
	// RVA: 0x1AC49E4 Offset: 0x1AC09E4 VA: 0x1AC49E4
	private void set_MercenaryRegisterGetReceiver(OperationReceiver<MercenaryRegisterGetResponse> value) { }

	[CompilerGenerated]
	// RVA: 0x1AC49EC Offset: 0x1AC09EC VA: 0x1AC49EC
	public OperationReceiver<MercenaryRegisterResponse> get_MercenaryRegisterReceiver() { }

	[CompilerGenerated]
	// RVA: 0x1AC49F4 Offset: 0x1AC09F4 VA: 0x1AC49F4
	private void set_MercenaryRegisterReceiver(OperationReceiver<MercenaryRegisterResponse> value) { }

	[CompilerGenerated]
	// RVA: 0x1AC49FC Offset: 0x1AC09FC VA: 0x1AC49FC
	public OperationReceiver<MercenaryEmploymentListResponse> get_MercenaryEmploymentListReceiver() { }

	[CompilerGenerated]
	// RVA: 0x1AC4A04 Offset: 0x1AC0A04 VA: 0x1AC4A04
	private void set_MercenaryEmploymentListReceiver(OperationReceiver<MercenaryEmploymentListResponse> value) { }

	[CompilerGenerated]
	// RVA: 0x1AC4A0C Offset: 0x1AC0A0C VA: 0x1AC4A0C
	public OperationReceiver<MercenaryJoinResponse> get_MercenaryJoinReceiver() { }

	[CompilerGenerated]
	// RVA: 0x1AC4A14 Offset: 0x1AC0A14 VA: 0x1AC4A14
	private void set_MercenaryJoinReceiver(OperationReceiver<MercenaryJoinResponse> value) { }

	[CompilerGenerated]
	// RVA: 0x1AC4A1C Offset: 0x1AC0A1C VA: 0x1AC4A1C
	public bool get_IsBanParty() { }

	[CompilerGenerated]
	// RVA: 0x1AC4A24 Offset: 0x1AC0A24 VA: 0x1AC4A24
	private void set_IsBanParty(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1AC4A30 Offset: 0x1AC0A30 VA: 0x1AC4A30
	public bool get_IsNoChange() { }

	[CompilerGenerated]
	// RVA: 0x1AC4A38 Offset: 0x1AC0A38 VA: 0x1AC4A38
	private void set_IsNoChange(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1AC4A44 Offset: 0x1AC0A44 VA: 0x1AC4A44
	public bool get_IsValueWrong() { }

	[CompilerGenerated]
	// RVA: 0x1AC4A4C Offset: 0x1AC0A4C VA: 0x1AC4A4C
	private void set_IsValueWrong(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1AC4A58 Offset: 0x1AC0A58 VA: 0x1AC4A58
	public bool get_IsPartnerAbnormalStatus() { }

	[CompilerGenerated]
	// RVA: 0x1AC4A60 Offset: 0x1AC0A60 VA: 0x1AC4A60
	private void set_IsPartnerAbnormalStatus(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1AC4A6C Offset: 0x1AC0A6C VA: 0x1AC4A6C
	public GameReturnCode get_JoinReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x1AC4A74 Offset: 0x1AC0A74 VA: 0x1AC4A74
	private void set_JoinReturnCode(GameReturnCode value) { }

	// RVA: 0x1AC4A7C Offset: 0x1AC0A7C VA: 0x1AC4A7C
	public void .ctor(Game engine) { }

	// RVA: 0x1AC501C Offset: 0x1AC101C VA: 0x1AC501C
	public void PartnerJoin(byte partnerNo, StanceType type) { }

	// RVA: 0x1AC50BC Offset: 0x1AC10BC VA: 0x1AC50BC
	public void OnPertnerJoin(PartnerJoinResponse response) { }

	// RVA: 0x1AC5118 Offset: 0x1AC1118 VA: 0x1AC5118
	public OperationReceiver<ParameterGetActionSettingResponse> PartnerParameterRegisterGet(byte getParamId, Action<Game, ParameterGetActionSettingResponse> response) { }

	// RVA: 0x1AC51FC Offset: 0x1AC11FC VA: 0x1AC51FC
	public OperationReceiver<ParameterGetActionSettingResponse> PartnerParameterRegister(byte parameterId, Dictionary<short, byte> registerSkills, Action<Game, ParameterGetActionSettingResponse> response) { }

	// RVA: 0x1AC52F4 Offset: 0x1AC12F4 VA: 0x1AC52F4
	public OperationReceiver<ParameterChangeActionSettingResponse> PartnerParameterSkillSettings(byte parameterId, Dictionary<short, byte> registerSkills, Action<Game, ParameterChangeActionSettingResponse> response) { }

	// RVA: -1 Offset: -1
	public void OnPartnerRegsterGet<T>(Game game, T responseFormat) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DB070 Offset: 0x26D7070 VA: 0x26DB070
	|-MercenaryOperationManager.OnPartnerRegsterGet<object>
	*/

	// RVA: 0x1AC53EC Offset: 0x1AC13EC VA: 0x1AC53EC
	public OperationReceiver<MercenaryJoinResponse> MercenaryJoin(int gold, MercenaryEmploymentType type, int mercenaryId, DateTime register) { }

	// RVA: 0x1AC54D4 Offset: 0x1AC14D4 VA: 0x1AC54D4
	public OperationReceiver<MercenaryJoinResponse> MercenaryJoin(int gold, MercenaryEmploymentType type, int mercenaryId, DateTime register, Action<Game, MercenaryJoinResponse> callback) { }

	// RVA: 0x1AC556C Offset: 0x1AC156C VA: 0x1AC556C
	public void OnMercenaryJoin(Game game, MercenaryJoinResponse response) { }

	// RVA: 0x1AC5704 Offset: 0x1AC1704 VA: 0x1AC5704
	public OperationReceiver<MercenaryRegisterGetResponse> MercenaryRegisterGet() { }

	// RVA: 0x1AC57A8 Offset: 0x1AC17A8 VA: 0x1AC57A8
	public OperationReceiver<MercenaryRegisterGetResponse> MercenaryRegisterGet(Action<Game, MercenaryRegisterGetResponse> callback) { }

	// RVA: 0x1AC5810 Offset: 0x1AC1810 VA: 0x1AC5810
	public void OnMercenaryRegisterGet(Game game, MercenaryRegisterGetResponse response) { }

	// RVA: 0x1AC5814 Offset: 0x1AC1814 VA: 0x1AC5814
	public OperationReceiver<MercenaryRegisterResponse> MercenaryRegister(StanceType type, Dictionary<short, byte> skills, Action<Game, MercenaryRegisterResponse> callBack) { }

	// RVA: 0x1AC5914 Offset: 0x1AC1914 VA: 0x1AC5914
	public void OnMercenaryRegister(Game game, MercenaryRegisterResponse response) { }

	// RVA: 0x1AC5918 Offset: 0x1AC1918 VA: 0x1AC5918
	public OperationReceiver<MercenaryEmploymentListResponse> MercenaryEmploymentList(MercenaryEmploymentType type) { }

	// RVA: 0x1AC59D0 Offset: 0x1AC19D0 VA: 0x1AC59D0
	public OperationReceiver<MercenaryEmploymentListResponse> MercenaryEmploymentList(MercenaryEmploymentType type, Action<Game, MercenaryEmploymentListResponse> callback) { }

	// RVA: 0x1AC5A48 Offset: 0x1AC1A48 VA: 0x1AC5A48
	public void OnMercenaryEmploymentList(Game game, MercenaryEmploymentListResponse response) { }

	// RVA: 0x1AC5A4C Offset: 0x1AC1A4C VA: 0x1AC5A4C
	public void OnOperationFailure(PartyOperationCode subcode, GameReturnCode gameReturnCode) { }

	// RVA: 0x1AC5AE0 Offset: 0x1AC1AE0 VA: 0x1AC5AE0
	public void OnOperationFailure(MercenaryOperationCode subcode) { }

	// RVA: 0x1AC5BA8 Offset: 0x1AC1BA8 VA: 0x1AC5BA8
	public void OnReturnCodeBanParty() { }

	// RVA: 0x1AC5BB4 Offset: 0x1AC1BB4 VA: 0x1AC5BB4
	public void OnReturnCodeNoChange() { }

	// RVA: 0x1AC5BC0 Offset: 0x1AC1BC0 VA: 0x1AC5BC0
	public void OnReturnCodeValueWrong() { }

	// RVA: 0x1AC4284 Offset: 0x1AC0284 VA: 0x1AC4284
	public void CompanionCheckRespawnTime(ArchetypeUid uid) { }

	// RVA: 0x1AC5570 Offset: 0x1AC1570 VA: 0x1AC5570
	private void Receive(Game game, OperationResponseBase response) { }
}
