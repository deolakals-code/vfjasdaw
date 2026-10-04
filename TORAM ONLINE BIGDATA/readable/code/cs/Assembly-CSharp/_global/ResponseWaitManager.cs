// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ResponseWaitManager : Singleton<ResponseWaitManager> // TypeDefIndex: 2058
{
	// Fields
	private Dictionary<OperationCode, ResponseWaitManager.ResponseFlag> operationChain; // 0x20
	private Dictionary<MarketOperationCode, ResponseWaitManager.ResponseMarketFlag> marketOperationChain; // 0x28
	private Dictionary<GuildOperationCode, ResponseWaitManager.ResponseGuildFlag> guildOperationChain; // 0x30
	private Dictionary<SignboardOperationCode, ResponseWaitManager.ResponseSignboardFlag> boardOperationChain; // 0x38
	private Dictionary<RoomOperationCode, ResponseWaitManager.ResponseRoomFlag> roomOperationChain; // 0x40
	private Dictionary<PartyOperationCode, ResponseWaitManager.ResponsePartyFlag> partyOperationChain; // 0x48
	private Dictionary<ResponseWaitManager.ResponseFlag, GameReturnCode> operationFailureList; // 0x50
	private Dictionary<ResponseWaitManager.ResponseMarketFlag, GameReturnCode> marketOperationFailureList; // 0x58
	private Dictionary<ResponseWaitManager.ResponseGuildFlag, GameReturnCode> guildOperationFailureList; // 0x60
	private Dictionary<ResponseWaitManager.ResponseSignboardFlag, GameReturnCode> boardOperationFailureList; // 0x68
	private Dictionary<ResponseWaitManager.ResponseRoomFlag, GameReturnCode> roomOperationFailureList; // 0x70
	private Dictionary<ResponseWaitManager.ResponsePartyFlag, GameReturnCode> partyOperationFailureList; // 0x78
	private long Flag; // 0x80
	private int MarketFlag; // 0x88
	private int GuildFlag; // 0x8C
	private int SignboardFlag; // 0x90
	private int RoomFlag; // 0x94
	private int PartyFlag; // 0x98
	private Dictionary<ResponseWaitManager.ResponseFlag, object> responseData; // 0xA0
	private Dictionary<ResponseWaitManager.ResponseMarketFlag, PacketBase> responseMarketData; // 0xA8
	private Dictionary<ResponseWaitManager.ResponseGuildFlag, PacketBase> responseGuildData; // 0xB0
	private Dictionary<ResponseWaitManager.ResponseSignboardFlag, PacketBase> responseSignboardData; // 0xB8
	private Dictionary<ResponseWaitManager.ResponseRoomFlag, PacketBase> responseRoomData; // 0xC0
	private Dictionary<ResponseWaitManager.ResponsePartyFlag, PacketBase> responsePartyData; // 0xC8

	// Methods

	// RVA: 0x213EBEC Offset: 0x213ABEC VA: 0x213EBEC
	public void SetResponseData(ResponseWaitManager.ResponseFlag flag, object data) { }

	// RVA: 0x213EC74 Offset: 0x213AC74 VA: 0x213EC74
	public void SetResponseData(ResponseWaitManager.ResponseMarketFlag flag, PacketBase data) { }

	// RVA: 0x213ECFC Offset: 0x213ACFC VA: 0x213ECFC
	public void SetResponseData(ResponseWaitManager.ResponseGuildFlag flag, PacketBase data) { }

	// RVA: 0x213ED84 Offset: 0x213AD84 VA: 0x213ED84
	public void SetResponseData(ResponseWaitManager.ResponseSignboardFlag flag, PacketBase data) { }

	// RVA: 0x213EE0C Offset: 0x213AE0C VA: 0x213EE0C
	public void SetResponseData(ResponseWaitManager.ResponseRoomFlag flag, PacketBase data) { }

	// RVA: 0x213EE94 Offset: 0x213AE94 VA: 0x213EE94
	public void SetResponseData(ResponseWaitManager.ResponsePartyFlag flag, PacketBase data) { }

	// RVA: -1 Offset: -1
	public T GetResponceData<T>(ResponseWaitManager.ResponseFlag flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E7518 Offset: 0x26E3518 VA: 0x26E7518
	|-ResponseWaitManager.GetResponceData<object>
	*/

	// RVA: 0x213EF1C Offset: 0x213AF1C VA: 0x213EF1C
	public object GetResponceData(ResponseWaitManager.ResponseFlag flag) { }

	// RVA: 0x213EFE0 Offset: 0x213AFE0 VA: 0x213EFE0
	public object GetResponseData(ResponseWaitManager.ResponseMarketFlag flag) { }

	// RVA: 0x213F0A4 Offset: 0x213B0A4 VA: 0x213F0A4
	public object GetResponseData(ResponseWaitManager.ResponseGuildFlag flag) { }

	// RVA: 0x213F168 Offset: 0x213B168 VA: 0x213F168
	public object GetResponseData(ResponseWaitManager.ResponseSignboardFlag flag) { }

	// RVA: 0x213F22C Offset: 0x213B22C VA: 0x213F22C
	public object GetResponseData(ResponseWaitManager.ResponseRoomFlag flag) { }

	// RVA: 0x213F2F0 Offset: 0x213B2F0 VA: 0x213F2F0
	public object GetResponseData(ResponseWaitManager.ResponsePartyFlag flag) { }

	// RVA: 0x213F3B4 Offset: 0x213B3B4 VA: 0x213F3B4
	public void SetFlag(ResponseWaitManager.ResponseFlag _flag) { }

	// RVA: 0x213F3C4 Offset: 0x213B3C4 VA: 0x213F3C4
	public void SetFlag(ResponseWaitManager.ResponseMarketFlag flag) { }

	// RVA: 0x213F3D4 Offset: 0x213B3D4 VA: 0x213F3D4
	public void SetFlag(ResponseWaitManager.ResponseGuildFlag flag) { }

	// RVA: 0x213F3E4 Offset: 0x213B3E4 VA: 0x213F3E4
	public void SetFlag(ResponseWaitManager.ResponseSignboardFlag flag) { }

	// RVA: 0x213F3F4 Offset: 0x213B3F4 VA: 0x213F3F4
	public void SetFlag(ResponseWaitManager.ResponseRoomFlag flag) { }

	// RVA: 0x213F404 Offset: 0x213B404 VA: 0x213F404
	public void SetFlag(ResponseWaitManager.ResponsePartyFlag flag) { }

	// RVA: 0x213F414 Offset: 0x213B414 VA: 0x213F414
	public bool GetFlag(ResponseWaitManager.ResponseFlag _flag) { }

	// RVA: 0x213F424 Offset: 0x213B424 VA: 0x213F424
	public bool GetFlag(ResponseWaitManager.ResponseMarketFlag _flag) { }

	// RVA: 0x213F434 Offset: 0x213B434 VA: 0x213F434
	public bool GetFlag(ResponseWaitManager.ResponseGuildFlag _flag) { }

	// RVA: 0x213F444 Offset: 0x213B444 VA: 0x213F444
	public bool GetFlag(ResponseWaitManager.ResponseSignboardFlag _flag) { }

	// RVA: 0x213F454 Offset: 0x213B454 VA: 0x213F454
	public bool GetFlag(ResponseWaitManager.ResponseRoomFlag _flag) { }

	// RVA: 0x213F464 Offset: 0x213B464 VA: 0x213F464
	public bool GetFlag(ResponseWaitManager.ResponsePartyFlag _flag) { }

	// RVA: 0x213EC64 Offset: 0x213AC64 VA: 0x213EC64
	public void ClearFlag(ResponseWaitManager.ResponseFlag _flag) { }

	// RVA: 0x213ECEC Offset: 0x213ACEC VA: 0x213ECEC
	public void ClearFlag(ResponseWaitManager.ResponseMarketFlag _flag) { }

	// RVA: 0x213ED74 Offset: 0x213AD74 VA: 0x213ED74
	public void ClearFlag(ResponseWaitManager.ResponseGuildFlag _flag) { }

	// RVA: 0x213EDFC Offset: 0x213ADFC VA: 0x213EDFC
	public void ClearFlag(ResponseWaitManager.ResponseSignboardFlag _flag) { }

	// RVA: 0x213EE84 Offset: 0x213AE84 VA: 0x213EE84
	public void ClearFlag(ResponseWaitManager.ResponseRoomFlag _flag) { }

	// RVA: 0x213EF0C Offset: 0x213AF0C VA: 0x213EF0C
	public void ClearFlag(ResponseWaitManager.ResponsePartyFlag _flag) { }

	// RVA: 0x213F474 Offset: 0x213B474 VA: 0x213F474
	public void ClearFlag() { }

	// RVA: 0x213F484 Offset: 0x213B484 VA: 0x213F484
	public void SetOperationFailure(OperationCode code, GameReturnCode returnCode) { }

	// RVA: 0x213F554 Offset: 0x213B554 VA: 0x213F554
	public void SetOperationFailure(MarketOperationCode code, GameReturnCode returnCode) { }

	// RVA: 0x213F624 Offset: 0x213B624 VA: 0x213F624
	public void SetOperationFailure(GuildOperationCode code, GameReturnCode returnCode) { }

	// RVA: 0x213F6F4 Offset: 0x213B6F4 VA: 0x213F6F4
	public void SetOperationFailure(SignboardOperationCode code, GameReturnCode returnCode) { }

	// RVA: 0x213F7C4 Offset: 0x213B7C4 VA: 0x213F7C4
	public void SetOperationFailure(RoomOperationCode code, GameReturnCode returnCode) { }

	// RVA: 0x213F894 Offset: 0x213B894 VA: 0x213F894
	public void SetOperationFailure(PartyOperationCode code, GameReturnCode returnCode) { }

	// RVA: 0x213F964 Offset: 0x213B964 VA: 0x213F964
	public bool IsError(ResponseWaitManager.ResponseFlag flag) { }

	// RVA: 0x213F9DC Offset: 0x213B9DC VA: 0x213F9DC
	public bool IsError(ResponseWaitManager.ResponseMarketFlag flag) { }

	// RVA: 0x213FA54 Offset: 0x213BA54 VA: 0x213FA54
	public bool IsError(ResponseWaitManager.ResponseGuildFlag flag) { }

	// RVA: 0x213FACC Offset: 0x213BACC VA: 0x213FACC
	public bool IsError(ResponseWaitManager.ResponseSignboardFlag flag) { }

	// RVA: 0x213FB44 Offset: 0x213BB44 VA: 0x213FB44
	public bool IsError(ResponseWaitManager.ResponseRoomFlag flag) { }

	// RVA: 0x213FBBC Offset: 0x213BBBC VA: 0x213FBBC
	public bool IsError(ResponseWaitManager.ResponsePartyFlag flag) { }

	// RVA: 0x213FC34 Offset: 0x213BC34 VA: 0x213FC34
	public GameReturnCode GetReturnCode(ResponseWaitManager.ResponseFlag flag) { }

	// RVA: 0x213FCA4 Offset: 0x213BCA4 VA: 0x213FCA4
	public GameReturnCode GetReturnCode(ResponseWaitManager.ResponseMarketFlag flag) { }

	// RVA: 0x213FD14 Offset: 0x213BD14 VA: 0x213FD14
	public GameReturnCode GetReturnCode(ResponseWaitManager.ResponseGuildFlag flag) { }

	// RVA: 0x213FD84 Offset: 0x213BD84 VA: 0x213FD84
	public GameReturnCode GetReturnCode(ResponseWaitManager.ResponseSignboardFlag flag) { }

	// RVA: 0x213FDF4 Offset: 0x213BDF4 VA: 0x213FDF4
	public GameReturnCode GetReturnCode(ResponseWaitManager.ResponseRoomFlag flag) { }

	// RVA: 0x213FE64 Offset: 0x213BE64 VA: 0x213FE64
	public GameReturnCode GetReturnCode(ResponseWaitManager.ResponsePartyFlag flag) { }

	// RVA: 0x213FED4 Offset: 0x213BED4 VA: 0x213FED4
	public void ResetError() { }

	// RVA: 0x2140408 Offset: 0x213C408 VA: 0x2140408
	public void .ctor() { }
}
