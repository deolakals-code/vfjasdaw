// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class FriendManager // TypeDefIndex: 1829
{
	// Fields
	private int baseFriendMax; // 0x10
	private Dictionary<int, FriendManager.FriendState> friendListData; // 0x18
	private Dictionary<int, FriendManager.FriendReserveState> friendReserveListData; // 0x20
	[CompilerGenerated]
	private Action ResponseCallback; // 0x28
	private DateTime updateListTimer; // 0x30
	private byte prevNoticeType; // 0x38
	[CompilerGenerated]
	private int <FriendMax>k__BackingField; // 0x3C
	public const int MaxAddFriendSlot = 200;
	private GameManager _gameManager; // 0x40

	// Properties
	public int FriendMax { get; set; }
	public int BaseFriendMax { get; }
	public int FriendCount { get; }
	public int FriendReserveCount { get; }
	public bool IsFriendMax { get; }
	public ReadOnlyCollection<FriendManager.FriendState> FriendListDataList { get; }
	public ReadOnlyCollection<FriendManager.FriendReserveState> FriendReserveDataList { get; }
	private GameManager gameManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20E88F0 Offset: 0x20E48F0 VA: 0x20E88F0
	public void add_ResponseCallback(Action value) { }

	[CompilerGenerated]
	// RVA: 0x20E898C Offset: 0x20E498C VA: 0x20E898C
	public void remove_ResponseCallback(Action value) { }

	[CompilerGenerated]
	// RVA: 0x20E8A28 Offset: 0x20E4A28 VA: 0x20E8A28
	public int get_FriendMax() { }

	[CompilerGenerated]
	// RVA: 0x20E8A30 Offset: 0x20E4A30 VA: 0x20E8A30
	private void set_FriendMax(int value) { }

	// RVA: 0x20E8A38 Offset: 0x20E4A38 VA: 0x20E8A38
	public int get_BaseFriendMax() { }

	// RVA: 0x20E8A40 Offset: 0x20E4A40 VA: 0x20E8A40
	public int get_FriendCount() { }

	// RVA: 0x20E8A90 Offset: 0x20E4A90 VA: 0x20E8A90
	public int get_FriendReserveCount() { }

	// RVA: 0x20E8AE0 Offset: 0x20E4AE0 VA: 0x20E8AE0
	public bool get_IsFriendMax() { }

	// RVA: 0x20E8B70 Offset: 0x20E4B70 VA: 0x20E8B70
	public ReadOnlyCollection<FriendManager.FriendState> get_FriendListDataList() { }

	// RVA: 0x20E8C18 Offset: 0x20E4C18 VA: 0x20E8C18
	public ReadOnlyCollection<FriendManager.FriendReserveState> get_FriendReserveDataList() { }

	// RVA: 0x20E8CA4 Offset: 0x20E4CA4 VA: 0x20E8CA4
	private GameManager get_gameManager() { }

	// RVA: 0x20E8D3C Offset: 0x20E4D3C VA: 0x20E8D3C
	public void Initialize(FriendUpdateResponse friendEventData) { }

	// RVA: 0x20E90B0 Offset: 0x20E50B0 VA: 0x20E90B0
	public void LoginInitialize(FriendLoginData data) { }

	// RVA: 0x20E947C Offset: 0x20E547C VA: 0x20E947C
	private void initializeAnnounce(FriendReserveData[] reserve) { }

	// RVA: 0x20E9A4C Offset: 0x20E5A4C VA: 0x20E9A4C
	public void UpdateFriendState(int archetypeId, byte state, short level, int worldId) { }

	// RVA: 0x20E9DE8 Offset: 0x20E5DE8 VA: 0x20E9DE8
	public bool UpdateFrindList() { }

	// RVA: 0x20E9DF0 Offset: 0x20E5DF0 VA: 0x20E9DF0
	public bool UpdateFrindList(float updateTimer) { }

	// RVA: 0x20E9ED0 Offset: 0x20E5ED0 VA: 0x20E9ED0
	public bool Acceptance(byte targetType, int targetId, Action callback) { }

	// RVA: 0x20E9F74 Offset: 0x20E5F74 VA: 0x20E9F74
	public bool Rejection(byte targetType, int targetId, Action callback) { }

	// RVA: 0x20EA018 Offset: 0x20E6018 VA: 0x20EA018
	public bool Remove(byte targetType, int targetId, Action callback) { }

	// RVA: 0x20EA0BC Offset: 0x20E60BC VA: 0x20EA0BC
	public bool Request(byte targetType, int targetId, string targetName, string message, Action callback) { }

	// RVA: 0x20EA214 Offset: 0x20E6214 VA: 0x20EA214
	public bool RequestCancel(byte targetType, int targetId, Action callback) { }

	// RVA: 0x20EA2F4 Offset: 0x20E62F4 VA: 0x20EA2F4
	public bool ChangeOnlineNotice() { }

	// RVA: 0x20EA37C Offset: 0x20E637C VA: 0x20EA37C
	public void OnRemove(int removeId, string removeName) { }

	// RVA: 0x20EA4BC Offset: 0x20E64BC VA: 0x20EA4BC
	public void OnRequest(FriendReserveData reserve) { }

	// RVA: 0x20EA68C Offset: 0x20E668C VA: 0x20EA68C
	public void OnRequestResponse(FriendData stateData) { }

	// RVA: 0x20EA98C Offset: 0x20E698C VA: 0x20EA98C
	public void OnAcceptance(FriendData stateData) { }

	// RVA: 0x20EAA8C Offset: 0x20E6A8C VA: 0x20EAA8C
	public void OnRejection(int rejectId, string rejectName) { }

	// RVA: 0x20EAB90 Offset: 0x20E6B90 VA: 0x20EAB90
	public void OnRejectionResponse(int rejectId, string rejectName) { }

	// RVA: 0x20EACD8 Offset: 0x20E6CD8 VA: 0x20EACD8
	public void OnRequestCancel(int cancelId, string cancelName) { }

	// RVA: 0x20EAF0C Offset: 0x20E6F0C VA: 0x20EAF0C
	public void OnRequestCancelResponse(int cancelId, string cancelName) { }

	// RVA: 0x20EA774 Offset: 0x20E6774 VA: 0x20EA774
	private void addStateData(FriendData state) { }

	// RVA: 0x20EB028 Offset: 0x20E7028 VA: 0x20EB028
	public void ChangeOnlineNoticeResponse() { }

	// RVA: 0x20EB084 Offset: 0x20E7084 VA: 0x20EB084
	public void ClearCallback() { }

	// RVA: 0x20EA164 Offset: 0x20E6164 VA: 0x20EA164
	public bool ContainsFriend(int id) { }

	// RVA: 0x20EB090 Offset: 0x20E7090 VA: 0x20EB090
	public bool ContainsFriendUser(int id) { }

	// RVA: 0x20EA1BC Offset: 0x20E61BC VA: 0x20EA1BC
	public bool ContainsFriendReserved(int id) { }

	// RVA: 0x20EB11C Offset: 0x20E711C VA: 0x20EB11C
	public void SetOnlineNotice(byte type) { }

	// RVA: 0x20E9808 Offset: 0x20E5808 VA: 0x20E9808
	private bool CheckChatBlock(int archetypeId) { }

	// RVA: 0x20E98F4 Offset: 0x20E58F4 VA: 0x20E98F4
	private bool CheckOptionRejectApply(int archetypeId) { }

	// RVA: 0x20E93B4 Offset: 0x20E53B4 VA: 0x20E93B4
	public void UpdateFriendMax(int max) { }

	// RVA: 0x20EB124 Offset: 0x20E7124 VA: 0x20EB124
	public void .ctor() { }
}
