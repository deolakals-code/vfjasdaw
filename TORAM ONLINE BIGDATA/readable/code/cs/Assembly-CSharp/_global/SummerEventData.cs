// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummerEventData : GameEventDataBase // TypeDefIndex: 1867
{
	// Fields
	private Action<int> getEventCallBack; // 0x18
	private byte execution_contents; // 0x20
	private SummerEventData eventData; // 0x28
	private GameObject menuButton; // 0x30
	private DateTime staminaReceiveTime; // 0x38
	private TimeSpan staminaWaitingTime; // 0x40
	private DateTime eatReceiveTime; // 0x48
	private TimeSpan eatWaitingTime; // 0x50
	private SummerLobbyData[] lobbyDataList; // 0x58
	private SummerMemberData[] seaMembers; // 0x60
	private DateTime nowServerTimer; // 0x68
	[CompilerGenerated]
	private bool <IsBossBattle>k__BackingField; // 0x70
	[CompilerGenerated]
	private int <BossRewardPoint>k__BackingField; // 0x74
	[CompilerGenerated]
	private int <ExchangeSeaPoint>k__BackingField; // 0x78

	// Properties
	public bool IsBossBattle { get; set; }
	public int BossRewardPoint { get; set; }
	public byte Stamina { get; }
	public TimeSpan StaminaResetTimer { get; }
	public int CurrentEatCount { get; }
	public TimeSpan EatResetTimer { get; }
	public int[] ItemsNum { get; }
	public int HaveSpina { get; }
	public SummerEventData SummerData { get; }
	public int ExchangeSeaPoint { get; set; }
	[Obsolete("旧仕様　使うな危険")]
	public int SeaPoint { get; }
	[Obsolete("旧仕様　使うな危険")]
	public int TotalPoint { get; }
	public int MaxHp { get; }
	public int EnterHp { get; }
	public short EnterHarpoon { get; }
	public short EnterUsedHarpoon { get; }
	public bool IsUsedMermaidFin { get; }
	public bool IsUsedSuperMory { get; }
	public bool IsUsedSeaManDrink { get; }
	public override byte GameEventType { get; }
	public SummerLobbyData[] LobbyDataList { get; }
	public SummerMemberData[] SeaMembers { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20F41CC Offset: 0x20F01CC VA: 0x20F41CC
	public bool get_IsBossBattle() { }

	[CompilerGenerated]
	// RVA: 0x20F41D4 Offset: 0x20F01D4 VA: 0x20F41D4
	private void set_IsBossBattle(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20F41E0 Offset: 0x20F01E0 VA: 0x20F41E0
	public int get_BossRewardPoint() { }

	[CompilerGenerated]
	// RVA: 0x20F41E8 Offset: 0x20F01E8 VA: 0x20F41E8
	private void set_BossRewardPoint(int value) { }

	// RVA: 0x20F41F0 Offset: 0x20F01F0 VA: 0x20F41F0
	public byte get_Stamina() { }

	// RVA: 0x20F4208 Offset: 0x20F0208 VA: 0x20F4208
	public TimeSpan get_StaminaResetTimer() { }

	// RVA: 0x20F4320 Offset: 0x20F0320 VA: 0x20F4320
	public int get_CurrentEatCount() { }

	// RVA: 0x20F4348 Offset: 0x20F0348 VA: 0x20F4348
	public TimeSpan get_EatResetTimer() { }

	// RVA: 0x20F4438 Offset: 0x20F0438 VA: 0x20F4438
	public int[] get_ItemsNum() { }

	// RVA: 0x20F4538 Offset: 0x20F0538 VA: 0x20F4538
	public int get_HaveSpina() { }

	// RVA: 0x20F45E4 Offset: 0x20F05E4 VA: 0x20F45E4
	public SummerEventData get_SummerData() { }

	[CompilerGenerated]
	// RVA: 0x20F45EC Offset: 0x20F05EC VA: 0x20F45EC
	public int get_ExchangeSeaPoint() { }

	[CompilerGenerated]
	// RVA: 0x20F45F4 Offset: 0x20F05F4 VA: 0x20F45F4
	private void set_ExchangeSeaPoint(int value) { }

	// RVA: 0x20F45FC Offset: 0x20F05FC VA: 0x20F45FC
	public int get_SeaPoint() { }

	// RVA: 0x20F4614 Offset: 0x20F0614 VA: 0x20F4614
	public int get_TotalPoint() { }

	// RVA: 0x20F461C Offset: 0x20F061C VA: 0x20F461C
	public int get_MaxHp() { }

	// RVA: 0x20F4634 Offset: 0x20F0634 VA: 0x20F4634
	public int get_EnterHp() { }

	// RVA: 0x20F464C Offset: 0x20F064C VA: 0x20F464C
	public short get_EnterHarpoon() { }

	// RVA: 0x20F4660 Offset: 0x20F0660 VA: 0x20F4660
	public short get_EnterUsedHarpoon() { }

	// RVA: 0x20F4680 Offset: 0x20F0680 VA: 0x20F4680
	public bool get_IsUsedMermaidFin() { }

	// RVA: 0x20F46FC Offset: 0x20F06FC VA: 0x20F46FC
	public bool get_IsUsedSuperMory() { }

	// RVA: 0x20F4704 Offset: 0x20F0704 VA: 0x20F4704
	public bool get_IsUsedSeaManDrink() { }

	// RVA: 0x20F470C Offset: 0x20F070C VA: 0x20F470C Slot: 4
	public override byte get_GameEventType() { }

	// RVA: 0x20F4714 Offset: 0x20F0714 VA: 0x20F4714
	public SummerLobbyData[] get_LobbyDataList() { }

	// RVA: 0x20F471C Offset: 0x20F071C VA: 0x20F471C
	public SummerMemberData[] get_SeaMembers() { }

	// RVA: 0x20F4688 Offset: 0x20F0688 VA: 0x20F4688
	private bool IsUsedResultItem(short item) { }

	// RVA: 0x20F4724 Offset: 0x20F0724 VA: 0x20F4724 Slot: 5
	public override void Initialize(byte[] binary) { }

	// RVA: 0x20F48C4 Offset: 0x20F08C4 VA: 0x20F48C4 Slot: 6
	public override void OnEnter() { }

	// RVA: 0x20F48F8 Offset: 0x20F08F8 VA: 0x20F48F8 Slot: 7
	public override void Clear() { }

	// RVA: 0x20F49D8 Offset: 0x20F09D8 VA: 0x20F49D8 Slot: 9
	public override void GetEvent(Action<int> callBack, byte[] param) { }

	// RVA: 0x20F4D00 Offset: 0x20F0D00 VA: 0x20F4D00
	public void SendExchangeEvent(Action<int> _callBack, int _point, byte[] _params_data) { }

	// RVA: 0x20F4EB8 Offset: 0x20F0EB8 VA: 0x20F4EB8
	public void SendDivingRoomList(Action<int> _callBack, byte recruitType) { }

	// RVA: 0x20F5010 Offset: 0x20F1010 VA: 0x20F5010
	public void SummerGetPoint(Action<int> _callBack) { }

	// RVA: 0x20F5088 Offset: 0x20F1088 VA: 0x20F5088 Slot: 10
	public override void ReceiveGetEvent(GetEventResponse _response, short _returnCode) { }

	// RVA: 0x20F5360 Offset: 0x20F1360 VA: 0x20F5360 Slot: 12
	public override void ReceiveSetEvent(SetEventResponse response, short returnCode) { }

	// RVA: 0x20F5484 Offset: 0x20F1484 VA: 0x20F5484 Slot: 11
	public override void SetEvent(Action<int> callBack, byte[] param) { }

	// RVA: 0x20F54C8 Offset: 0x20F14C8 VA: 0x20F54C8 Slot: 8
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x20F4AE4 Offset: 0x20F0AE4 VA: 0x20F4AE4
	private Dictionary<byte, object> CreateSendData(byte[] _params_data) { }

	// RVA: 0x20F50A8 Offset: 0x20F10A8 VA: 0x20F50A8
	private void CreateRecvData(short _responce_code, Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F67FC Offset: 0x20F27FC VA: 0x20F67FC
	private void recv_point_exchange(short _responce_code, Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F6C50 Offset: 0x20F2C50 VA: 0x20F6C50
	private void recv_point_total_exchange(short _responce_code, Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F561C Offset: 0x20F161C VA: 0x20F561C
	private void recv_purchase_item(short _responce_code, Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F5958 Offset: 0x20F1958 VA: 0x20F5958
	private void recv_eat_action(short _responce_code, Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F5C98 Offset: 0x20F1C98 VA: 0x20F5C98
	private void recv_stamina_info_action(short _responce_code, Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F5F30 Offset: 0x20F1F30 VA: 0x20F5F30
	private void recv_check_result_action(short _responce_code, Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F62E8 Offset: 0x20F22E8 VA: 0x20F62E8
	private void recv_getDivingList_action(short _responce_code, Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F6534 Offset: 0x20F2534 VA: 0x20F6534
	private void recv_getMembers_action(short _responce_code, Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F668C Offset: 0x20F268C VA: 0x20F668C
	private void recv_getPoint_action(short _responce_code, Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F6F90 Offset: 0x20F2F90 VA: 0x20F6F90
	public void ReceiveStaminaUpdate(byte stamina, int timer) { }

	// RVA: 0x20F7030 Offset: 0x20F3030 VA: 0x20F7030
	private void ReceiveEatUpdate(byte count, int timer) { }

	// RVA: 0x20F70D0 Offset: 0x20F30D0 VA: 0x20F70D0
	private bool common_error_cheak(short _responce_code) { }

	// RVA: 0x20F6A24 Offset: 0x20F2A24 VA: 0x20F6A24
	private bool exchange_prize_result(short _responce_code) { }

	// RVA: 0x20F6E34 Offset: 0x20F2E34 VA: 0x20F6E34
	private bool shoping_recv_result(short _responce_code) { }

	// RVA: 0x20F6F08 Offset: 0x20F2F08 VA: 0x20F6F08
	private bool eat_recv_result(short _responce_code) { }

	// RVA: 0x20F710C Offset: 0x20F310C VA: 0x20F710C
	public TimeSpan MathRoomStartElapsedTime(DateTime startTimer) { }

	// RVA: 0x20F6B68 Offset: 0x20F2B68 VA: 0x20F6B68
	private void update_already_excahnge_data(Dictionary<byte, object> _recv_data) { }

	// RVA: 0x20F7178 Offset: 0x20F3178 VA: 0x20F7178
	private void update_already_exchange_list(Dictionary<short, int> _update_data) { }

	// RVA: 0x20EC574 Offset: 0x20E8574 VA: 0x20EC574
	public void .ctor() { }
}
