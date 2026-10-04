// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ParameterManager : Singleton<ParameterManager> // TypeDefIndex: 5402
{
	// Fields
	[CompilerGenerated]
	private bool <IsConnection>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsError>k__BackingField; // 0x21
	[CompilerGenerated]
	private ParameterManager.ParameterErrorType <ParameterErrorTypeLog>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <ParameterMaxSlot>k__BackingField; // 0x28
	private SystemTextManager systemTextManager; // 0x30
	private bool isCreateParameter; // 0x38
	private Dictionary<byte, ParameterData> parameterDataList; // 0x40
	private Dictionary<byte, ParameterStatus> parameterStatusList; // 0x48
	private byte[] orderList; // 0x50
	private PlayerDataManager playerData; // 0x58
	[CompilerGenerated]
	private bool <IsLoginSecondParameter>k__BackingField; // 0x60

	// Properties
	public bool IsConnection { get; set; }
	public bool IsError { get; set; }
	public ParameterManager.ParameterErrorType ParameterErrorTypeLog { get; set; }
	public byte ParameterMaxSlot { get; set; }
	private SystemTextManager SystemTextMgr { get; }
	private PlayerDataManager PlayerData { get; }
	public int ParameterCount { get; }
	public bool IsCreateParameter { get; }
	public int CreatedParameterCount { get; }
	public bool IsLoginSecondParameter { get; set; }
	public int GetOtherParamId { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x175C6A8 Offset: 0x17586A8 VA: 0x175C6A8
	private void set_IsConnection(bool value) { }

	[CompilerGenerated]
	// RVA: 0x175C6B4 Offset: 0x17586B4 VA: 0x175C6B4
	public bool get_IsConnection() { }

	[CompilerGenerated]
	// RVA: 0x175C6BC Offset: 0x17586BC VA: 0x175C6BC
	private void set_IsError(bool value) { }

	[CompilerGenerated]
	// RVA: 0x175C6C8 Offset: 0x17586C8 VA: 0x175C6C8
	public bool get_IsError() { }

	[CompilerGenerated]
	// RVA: 0x175C6D0 Offset: 0x17586D0 VA: 0x175C6D0
	private void set_ParameterErrorTypeLog(ParameterManager.ParameterErrorType value) { }

	[CompilerGenerated]
	// RVA: 0x175C6D8 Offset: 0x17586D8 VA: 0x175C6D8
	public ParameterManager.ParameterErrorType get_ParameterErrorTypeLog() { }

	[CompilerGenerated]
	// RVA: 0x175C6E0 Offset: 0x17586E0 VA: 0x175C6E0
	private void set_ParameterMaxSlot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x175C6E8 Offset: 0x17586E8 VA: 0x175C6E8
	public byte get_ParameterMaxSlot() { }

	// RVA: 0x175C6F0 Offset: 0x17586F0 VA: 0x175C6F0
	private SystemTextManager get_SystemTextMgr() { }

	// RVA: 0x175C7DC Offset: 0x17587DC VA: 0x175C7DC
	private PlayerDataManager get_PlayerData() { }

	// RVA: 0x175C860 Offset: 0x1758860 VA: 0x175C860
	public int get_ParameterCount() { }

	// RVA: 0x175C8B8 Offset: 0x17588B8 VA: 0x175C8B8
	public bool get_IsCreateParameter() { }

	// RVA: 0x175C8C0 Offset: 0x17588C0 VA: 0x175C8C0
	public int get_CreatedParameterCount() { }

	[CompilerGenerated]
	// RVA: 0x175CA18 Offset: 0x1758A18 VA: 0x175CA18
	public bool get_IsLoginSecondParameter() { }

	[CompilerGenerated]
	// RVA: 0x175CA20 Offset: 0x1758A20 VA: 0x175CA20
	private void set_IsLoginSecondParameter(bool value) { }

	// RVA: 0x175CA2C Offset: 0x1758A2C VA: 0x175CA2C
	public bool ParameterGetList() { }

	// RVA: 0x175CA40 Offset: 0x1758A40 VA: 0x175CA40
	public void ReceiveParameterGetList(ParameterGetListResponse response) { }

	// RVA: 0x175CCD4 Offset: 0x1758CD4 VA: 0x175CCD4
	public bool ParameterOrderReset() { }

	// RVA: 0x175CCE8 Offset: 0x1758CE8 VA: 0x175CCE8
	public void ReceiveParameterOrderReset(ParameterOrderResetResponse response) { }

	// RVA: 0x175CAE0 Offset: 0x1758AE0 VA: 0x175CAE0
	private void UpdateParameterData(ParameterData[] list, byte slotNum, byte[] sort) { }

	// RVA: 0x175CD14 Offset: 0x1758D14 VA: 0x175CD14
	public void UpdateParameterOrder(byte[] order) { }

	// RVA: 0x175CE30 Offset: 0x1758E30 VA: 0x175CE30
	public ParameterData GetParameterData(byte paramId) { }

	// RVA: 0x175CEDC Offset: 0x1758EDC VA: 0x175CEDC
	private bool ParameterCheck(byte paramId) { }

	// RVA: 0x175CF58 Offset: 0x1758F58 VA: 0x175CF58
	public bool ParameterCreate(byte paramId) { }

	// RVA: 0x175CFDC Offset: 0x1758FDC VA: 0x175CFDC
	public void ReceiveParameterCreate() { }

	// RVA: 0x175CFEC Offset: 0x1758FEC VA: 0x175CFEC
	public void ExitParameterCreate() { }

	// RVA: 0x175CFF4 Offset: 0x1758FF4 VA: 0x175CFF4
	public bool ParameterChange(byte paramId) { }

	// RVA: 0x175D0C4 Offset: 0x17590C4 VA: 0x175D0C4
	public void ReceiveParameterChange() { }

	// RVA: 0x175D0CC Offset: 0x17590CC VA: 0x175D0CC
	public bool ParameterGetStatus(byte paramId) { }

	// RVA: 0x175D18C Offset: 0x175918C VA: 0x175D18C
	public void ReceiveParameterGetStatus(ParameterGetStatusResponse response) { }

	// RVA: 0x175D1F8 Offset: 0x17591F8 VA: 0x175D1F8
	public ParameterStatus GetParameterStatus(byte paramId) { }

	// RVA: 0x175D270 Offset: 0x1759270 VA: 0x175D270
	public bool ParameterNameChange(byte paramId, string changeName) { }

	// RVA: 0x175D590 Offset: 0x1759590 VA: 0x175D590
	public void ReceiveParameterNameChange(byte paramId, string paramName) { }

	// RVA: 0x175D60C Offset: 0x175960C VA: 0x175D60C
	public bool ParameterDelete(byte paramId) { }

	// RVA: 0x175D6DC Offset: 0x17596DC VA: 0x175D6DC
	public void ReceiveParameterDelete(byte paramId) { }

	// RVA: 0x175D95C Offset: 0x175995C VA: 0x175D95C
	public void ReceiveParameterFailed(byte operationCode, short returnCode) { }

	// RVA: 0x175D9DC Offset: 0x17599DC VA: 0x175D9DC
	public void ReceiveParameterFailed(byte operationCode, byte subCode, short returnCode) { }

	// RVA: 0x175DBB4 Offset: 0x1759BB4 VA: 0x175DBB4
	public void UpdateParameterSlotMax(byte parameterSlot) { }

	// RVA: 0x175DBBC Offset: 0x1759BBC VA: 0x175DBBC
	public void RegistLoginOfNewParameter() { }

	// RVA: 0x175DBDC Offset: 0x1759BDC VA: 0x175DBDC
	public void RegistDone() { }

	// RVA: 0x175DBE4 Offset: 0x1759BE4 VA: 0x175DBE4
	public int get_GetOtherParamId() { }

	// RVA: 0x175DDCC Offset: 0x1759DCC VA: 0x175DDCC
	public byte GetOrderParamegerId(byte index) { }

	// RVA: 0x175DE08 Offset: 0x1759E08 VA: 0x175DE08
	public bool CheckUpdateParameterOrder(byte[] order) { }

	// RVA: 0x175DE90 Offset: 0x1759E90 VA: 0x175DE90
	public void .ctor() { }
}
