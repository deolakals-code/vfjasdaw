// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OtherPlayerManager : TargetableListManagerBase<OtherPlayerManager>, ISceneChangeManager // TypeDefIndex: 1256
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x28
	private Dictionary<ArchetypeUid, OtherPlayer> otherPlayers; // 0x30
	private GameObject otherPlayerObject; // 0x38
	[CompilerGenerated]
	private IUserArchetype <LastTargetPlayerArchetype>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <ShardLastTouchUUID>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <ShardLastTouchName>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <LastClickPlayerUuid>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <LastClickPlayerName>k__BackingField; // 0x60
	[CompilerGenerated]
	private byte <LastClickPlayerRegionCode>k__BackingField; // 0x68
	private OptionsGraphics optionsGraphics; // 0x70
	private int unloadCount; // 0x78
	private float underFPS; // 0x7C
	private float nextEnterTimer; // 0x80
	private int saveLotteryFieldId; // 0x84
	private List<int> lotteryUserList; // 0x88

	// Properties
	public Dictionary<ArchetypeUid, OtherPlayer> _otherPlayerData { get; }
	public IUserArchetype LastTargetPlayerArchetype { get; set; }
	public int ShardLastTouchUUID { get; set; }
	public string ShardLastTouchName { get; set; }
	public int LastClickPlayerUuid { get; set; }
	public string LastClickPlayerName { get; set; }
	public byte LastClickPlayerRegionCode { get; set; }

	// Methods

	// RVA: 0x1FAAAC0 Offset: 0x1FA6AC0 VA: 0x1FAAAC0
	public Dictionary<ArchetypeUid, OtherPlayer> get__otherPlayerData() { }

	[CompilerGenerated]
	// RVA: 0x1FAAAC8 Offset: 0x1FA6AC8 VA: 0x1FAAAC8
	public IUserArchetype get_LastTargetPlayerArchetype() { }

	[CompilerGenerated]
	// RVA: 0x1FAAAD0 Offset: 0x1FA6AD0 VA: 0x1FAAAD0
	private void set_LastTargetPlayerArchetype(IUserArchetype value) { }

	[CompilerGenerated]
	// RVA: 0x1FAAAD8 Offset: 0x1FA6AD8 VA: 0x1FAAAD8
	public int get_ShardLastTouchUUID() { }

	[CompilerGenerated]
	// RVA: 0x1FAAAE0 Offset: 0x1FA6AE0 VA: 0x1FAAAE0
	private void set_ShardLastTouchUUID(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FAAAE8 Offset: 0x1FA6AE8 VA: 0x1FAAAE8
	public string get_ShardLastTouchName() { }

	[CompilerGenerated]
	// RVA: 0x1FAAAF0 Offset: 0x1FA6AF0 VA: 0x1FAAAF0
	private void set_ShardLastTouchName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1FAAAF8 Offset: 0x1FA6AF8 VA: 0x1FAAAF8
	public int get_LastClickPlayerUuid() { }

	[CompilerGenerated]
	// RVA: 0x1FAAB00 Offset: 0x1FA6B00 VA: 0x1FAAB00
	private void set_LastClickPlayerUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FAAB08 Offset: 0x1FA6B08 VA: 0x1FAAB08
	public string get_LastClickPlayerName() { }

	[CompilerGenerated]
	// RVA: 0x1FAAB10 Offset: 0x1FA6B10 VA: 0x1FAAB10
	private void set_LastClickPlayerName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1FAAB18 Offset: 0x1FA6B18 VA: 0x1FAAB18
	public byte get_LastClickPlayerRegionCode() { }

	[CompilerGenerated]
	// RVA: 0x1FAAB20 Offset: 0x1FA6B20 VA: 0x1FAAB20
	private void set_LastClickPlayerRegionCode(byte value) { }

	// RVA: 0x1FAAB28 Offset: 0x1FA6B28 VA: 0x1FAAB28
	private void Awake() { }

	// RVA: 0x1FAAB98 Offset: 0x1FA6B98 VA: 0x1FAAB98
	private void Start() { }

	// RVA: 0x1FAABF4 Offset: 0x1FA6BF4 VA: 0x1FAABF4
	private void Update() { }

	// RVA: 0x1FAABF8 Offset: 0x1FA6BF8 VA: 0x1FAABF8
	private void checkOtherPlayerRender() { }

	// RVA: 0x1FAB2CC Offset: 0x1FA72CC VA: 0x1FAB2CC
	public bool ContainsObject(GameObject obj) { }

	// RVA: 0x1FAB418 Offset: 0x1FA7418 VA: 0x1FAB418
	public bool ContainsOtherPlayer(ArchetypeUid uid) { }

	// RVA: 0x1FAB470 Offset: 0x1FA7470 VA: 0x1FAB470
	public bool ContainsOtherPlayer(byte type, int id) { }

	// RVA: 0x1FAB4A8 Offset: 0x1FA74A8 VA: 0x1FAB4A8
	public void AddOtherPlayer(Game game, Archetype archetype) { }

	// RVA: 0x1FABA6C Offset: 0x1FA7A6C VA: 0x1FABA6C
	private void AddGuildRaidBattleMember(OtherPlayer otherPlayer) { }

	// RVA: 0x1FABCB4 Offset: 0x1FA7CB4 VA: 0x1FABCB4
	public void RemoveOtherPlayer(ArchetypeUid id) { }

	// RVA: 0x1FABF10 Offset: 0x1FA7F10 VA: 0x1FABF10
	public void DestroyOtherPlayer(ArchetypeUid id) { }

	// RVA: 0x1FAC07C Offset: 0x1FA807C VA: 0x1FAC07C
	public void RemoveAllOtherPlayer() { }

	// RVA: 0x1FABEB8 Offset: 0x1FA7EB8 VA: 0x1FABEB8
	public bool IsExistOtherPlayer(ArchetypeUid id) { }

	// RVA: 0x1FAC264 Offset: 0x1FA8264 VA: 0x1FAC264
	public OtherPlayer GetOtherPlayer(ArchetypeUid id) { }

	// RVA: 0x1FAC2D4 Offset: 0x1FA82D4 VA: 0x1FAC2D4
	public OtherPlayer GetOtherPlayer(byte type, int id) { }

	// RVA: 0x1FAC308 Offset: 0x1FA8308 VA: 0x1FAC308
	public bool TryGetOtherPlayer(byte archetypeType, int archetypeId, out OtherPlayer otherPlayer) { }

	// RVA: 0x1FAC348 Offset: 0x1FA8348 VA: 0x1FAC348
	public bool TryGetOtherPlayer(ArchetypeUid archetypeUid, out OtherPlayer otherPlayer) { }

	// RVA: 0x1FAC3B0 Offset: 0x1FA83B0 VA: 0x1FAC3B0
	public OtherPlayer[] GetOtherPlayers() { }

	// RVA: 0x1FAC454 Offset: 0x1FA8454 VA: 0x1FAC454
	public void OnBattleStart(ArchetypeUid id) { }

	// RVA: 0x1FAC4F8 Offset: 0x1FA84F8 VA: 0x1FAC4F8
	public void OnBattleEnd(ArchetypeUid id) { }

	// RVA: 0x1FAC59C Offset: 0x1FA859C VA: 0x1FAC59C
	public void OnActionEventMove(Game game, byte archetypeType, int archetypeId, IMoveData moveEvent) { }

	// RVA: 0x1FAC71C Offset: 0x1FA871C VA: 0x1FAC71C
	public void OnActionEvent(ArchetypeActionEvent actionEvent) { }

	// RVA: 0x1FAC7D8 Offset: 0x1FA87D8 VA: 0x1FAC7D8
	public void OnActionEvent(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x1FAC950 Offset: 0x1FA8950 VA: 0x1FAC950
	public bool TargetOtherPlayer(GameObject obj) { }

	// RVA: 0x1FACAD4 Offset: 0x1FA8AD4 VA: 0x1FACAD4
	public void TargetPartnerMercenary(int id) { }

	// RVA: 0x1FAD240 Offset: 0x1FA9240 VA: 0x1FAD240
	public void ClearTarget() { }

	// RVA: 0x1FAD2D4 Offset: 0x1FA92D4 VA: 0x1FAD2D4
	public void SetClickPlayer(int uuid, string userName, byte regionCode) { }

	// RVA: 0x1FACAC4 Offset: 0x1FA8AC4 VA: 0x1FACAC4
	private void set_uuid_for_select_menu(int _uuid, string _name) { }

	// RVA: 0x1FAD334 Offset: 0x1FA9334 VA: 0x1FAD334
	public void LotteryUserClear() { }

	// RVA: 0x1FAD404 Offset: 0x1FA9404 VA: 0x1FAD404
	public void AddLotteryUser(int archetypeId) { }

	// RVA: 0x1FAD4D0 Offset: 0x1FA94D0 VA: 0x1FAD4D0
	public bool IsLotteryUser(int archetypeId) { }

	// RVA: 0x1FAD528 Offset: 0x1FA9528 VA: 0x1FAD528
	public bool RemoveLotteryUser(int archetypeId) { }

	// RVA: 0x1FAD580 Offset: 0x1FA9580 VA: 0x1FAD580
	public bool LotteryJoin(int archetypeId) { }

	// RVA: 0x1FAD618 Offset: 0x1FA9618 VA: 0x1FAD618 Slot: 9
	public void OnEnter() { }

	// RVA: 0x1FAD678 Offset: 0x1FA9678 VA: 0x1FAD678 Slot: 10
	public void OnLeave() { }

	// RVA: 0x1FAD6F0 Offset: 0x1FA96F0 VA: 0x1FAD6F0
	public void .ctor() { }
}
