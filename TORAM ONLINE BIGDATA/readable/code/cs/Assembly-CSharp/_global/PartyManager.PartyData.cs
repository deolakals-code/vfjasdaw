// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PartyManager.PartyData // TypeDefIndex: 2185
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <LeaderId>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <LeaderType>k__BackingField; // 0x18
	private Dictionary<PartyManager.PartyData.pair, PartyMemberData> memberData; // 0x20
	private Dictionary<PartyManager.PartyData.pair, PartyMemberData> memberPetData; // 0x28
	private int groupActiveMemberNum; // 0x30
	private int groupAvatarMemberNum; // 0x34
	private int activePartyMemberNum; // 0x38
	private int loginFieldUserPartyMemberNum; // 0x3C
	private IEnumerable<PartyMemberData> loginMemberData; // 0x40

	// Properties
	public int PartyId { get; set; }
	public int LeaderId { get; set; }
	public int LeaderType { get; set; }
	public IList<PartyMemberData> MemberData { get; }
	public int GroupActiveMemberNum { get; }
	public int GroupAvatarMemberNum { get; }
	public int ActivePartyMemberNum { get; }
	public int LoginFieldUserPartyMemberNum { get; }
	public IEnumerable<PartyMemberData> LoginMemberData { get; }
	public int PartyMemberNum { get; }
	public int PartyPetMemberNum { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2164D88 Offset: 0x2160D88 VA: 0x2164D88
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x2164D90 Offset: 0x2160D90 VA: 0x2164D90
	private void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2164D98 Offset: 0x2160D98 VA: 0x2164D98
	public int get_LeaderId() { }

	[CompilerGenerated]
	// RVA: 0x2164DA0 Offset: 0x2160DA0 VA: 0x2164DA0
	public void set_LeaderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2164DA8 Offset: 0x2160DA8 VA: 0x2164DA8
	public int get_LeaderType() { }

	[CompilerGenerated]
	// RVA: 0x2164DB0 Offset: 0x2160DB0 VA: 0x2164DB0
	public void set_LeaderType(int value) { }

	// RVA: 0x2164DB8 Offset: 0x2160DB8 VA: 0x2164DB8
	public IList<PartyMemberData> get_MemberData() { }

	// RVA: 0x216501C Offset: 0x216101C VA: 0x216501C
	public int get_GroupActiveMemberNum() { }

	// RVA: 0x2165398 Offset: 0x2161398 VA: 0x2165398
	public int get_GroupAvatarMemberNum() { }

	// RVA: 0x2165488 Offset: 0x2161488 VA: 0x2165488
	public int get_ActivePartyMemberNum() { }

	// RVA: 0x2165578 Offset: 0x2161578 VA: 0x2165578
	public int get_LoginFieldUserPartyMemberNum() { }

	// RVA: 0x2165668 Offset: 0x2161668 VA: 0x2165668
	public IEnumerable<PartyMemberData> get_LoginMemberData() { }

	// RVA: 0x2165B3C Offset: 0x2161B3C VA: 0x2165B3C
	public int get_PartyMemberNum() { }

	// RVA: 0x2165B8C Offset: 0x2161B8C VA: 0x2165B8C
	public int get_PartyPetMemberNum() { }

	// RVA: 0x2165BDC Offset: 0x2161BDC VA: 0x2165BDC
	public void .ctor() { }

	// RVA: 0x2165CCC Offset: 0x2161CCC VA: 0x2165CCC
	private bool Member_TryGetValue(PartyManager.PartyData.pair key, out PartyMemberData data) { }

	// RVA: 0x2165D4C Offset: 0x2161D4C VA: 0x2165D4C
	private void memberClear(PartyManager.PartyData.pair key, PartyMemberData data) { }

	// RVA: 0x21660F4 Offset: 0x21620F4 VA: 0x21660F4
	public void Clear() { }

	// RVA: 0x2165E50 Offset: 0x2161E50 VA: 0x2165E50
	private void SetMemberLayer(int id, byte type, int layer) { }

	// RVA: 0x2166378 Offset: 0x2162378 VA: 0x2166378
	private void UpdateMemberState(IPartyStateEvent state, Dictionary<PartyManager.PartyData.pair, PartyMemberData> list) { }

	// RVA: 0x2166BD0 Offset: 0x2162BD0 VA: 0x2166BD0
	public void UpdateState(IPartyStateEvent state) { }

	// RVA: 0x2168034 Offset: 0x2164034 VA: 0x2168034
	private bool TrySetOtherPlayer(BattleMemberData battleMember, PartyMemberData mdata, ArchetypeUid archetypeUid) { }

	// RVA: 0x21687A8 Offset: 0x21647A8 VA: 0x21687A8
	public void UpdateStatus(IPartyStatusEvent status) { }

	// RVA: 0x2168A88 Offset: 0x2164A88 VA: 0x2168A88
	public void AddAutoMemberStatus(string name, Archetype archetype, PlayerStatusBase status) { }

	// RVA: 0x2168AAC Offset: 0x2164AAC VA: 0x2168AAC
	public void AddAutoMemberStatus(string name, int archetypeId, byte archetypeType, PlayerStatusBase status) { }

	// RVA: 0x21690D4 Offset: 0x21650D4 VA: 0x21690D4
	public void AddMineStatus() { }

	// RVA: 0x2166958 Offset: 0x2162958 VA: 0x2166958
	public bool RemoveMember(int id, byte type) { }

	// RVA: 0x21692AC Offset: 0x21652AC VA: 0x21692AC
	public bool ContainsMember(int id, byte type) { }

	// RVA: 0x21692F4 Offset: 0x21652F4 VA: 0x21692F4
	public void SetMemberObject(int id, byte type, GameObject obj) { }

	// RVA: 0x2165F1C Offset: 0x2161F1C VA: 0x2165F1C
	public void RemoveMemberObject(int id, byte type) { }

	// RVA: 0x21693E8 Offset: 0x21653E8 VA: 0x21693E8
	public PartyMemberData GetMemberData(int id, byte type) { }

	// RVA: 0x2168794 Offset: 0x2164794 VA: 0x2168794
	public void UpdateProperies() { }

	// RVA: 0x216576C Offset: 0x216176C VA: 0x216576C
	public IEnumerable<PartyMemberData> GetFindMemberList(Func<PartyMemberData, bool> check) { }

	// RVA: 0x216510C Offset: 0x216110C VA: 0x216510C
	public int GetFindMemberCount(Func<PartyMemberData, bool> check) { }
}
