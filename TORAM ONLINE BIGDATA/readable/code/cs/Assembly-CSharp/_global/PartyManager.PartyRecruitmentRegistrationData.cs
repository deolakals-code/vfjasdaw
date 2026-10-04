// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyManager.PartyRecruitmentRegistrationData // TypeDefIndex: 2191
{
	// Fields
	private bool hasBeenRecruited; // 0x10
	private PartyRecruitmentData minePartyRecruitmentData; // 0x18
	private PartyRecruitmentData partyLeaderRecruitmentData; // 0x20
	private List<PartyRecruitmentData> recruitmentDatas; // 0x28
	private int beforePartyId; // 0x30
	private int beforeApplicationRecruitmentId; // 0x34

	// Properties
	public string PartyName { get; }
	public string PartyComments { get; }
	public byte RecruitmentType { get; }
	public bool HasBeenRecruited { get; }
	public int RecruitmentId { get; }
	public int PartyLeaderRecruitmentId { get; }
	public bool IsPartyLeaderRecruitmentDataExistence { get; }
	public int BeforeKickOutPartyId { get; }
	public int PartyLeaderRecruitmentPartyId { get; }
	public int PartyLeaderRecruitmentPartyLeaderId { get; }
	public int BeforeApplicationRecruitmentId { get; }

	// Methods

	// RVA: 0x21695B8 Offset: 0x21655B8 VA: 0x21695B8
	public string get_PartyName() { }

	// RVA: 0x21695D0 Offset: 0x21655D0 VA: 0x21695D0
	public string get_PartyComments() { }

	// RVA: 0x21695E8 Offset: 0x21655E8 VA: 0x21695E8
	public byte get_RecruitmentType() { }

	// RVA: 0x2169600 Offset: 0x2165600 VA: 0x2169600
	public bool get_HasBeenRecruited() { }

	// RVA: 0x2169608 Offset: 0x2165608 VA: 0x2169608
	public int get_RecruitmentId() { }

	// RVA: 0x2169620 Offset: 0x2165620 VA: 0x2169620
	public int get_PartyLeaderRecruitmentId() { }

	// RVA: 0x2169638 Offset: 0x2165638 VA: 0x2169638
	public bool get_IsPartyLeaderRecruitmentDataExistence() { }

	// RVA: 0x2169648 Offset: 0x2165648 VA: 0x2169648
	public int get_BeforeKickOutPartyId() { }

	// RVA: 0x2169650 Offset: 0x2165650 VA: 0x2169650
	public int get_PartyLeaderRecruitmentPartyId() { }

	// RVA: 0x216966C Offset: 0x216566C VA: 0x216966C
	public int get_PartyLeaderRecruitmentPartyLeaderId() { }

	// RVA: 0x2169688 Offset: 0x2165688 VA: 0x2169688
	public int get_BeforeApplicationRecruitmentId() { }

	// RVA: 0x2169690 Offset: 0x2165690 VA: 0x2169690
	public void .ctor() { }

	// RVA: 0x21696A0 Offset: 0x21656A0 VA: 0x21696A0
	public void SetMinePartyRecruitmentData(PartyRecruitmentData data) { }

	// RVA: 0x21697E8 Offset: 0x21657E8 VA: 0x21697E8
	public void SetPartyName(string partyName) { }

	// RVA: 0x216986C Offset: 0x216586C VA: 0x216986C
	public void SetPartyComments(string partyComments) { }

	// RVA: 0x21698F0 Offset: 0x21658F0 VA: 0x21698F0
	public void SetRecruitmentType(byte recruitmentType) { }

	// RVA: 0x21699F4 Offset: 0x21659F4 VA: 0x21699F4
	public void SetHasBeenRecruitedFlag(bool flag) { }

	// RVA: 0x2169768 Offset: 0x2165768 VA: 0x2169768
	public void SetRecruitmentId(int recruitmentId) { }

	// RVA: 0x2169970 Offset: 0x2165970 VA: 0x2169970
	public void SetMemberFrames(PartyMemberFrameData[] frameDatas) { }

	// RVA: 0x2169A00 Offset: 0x2165A00 VA: 0x2169A00
	public void ChangeMemberFrameFlag(byte frameNo, bool flag, bool isMine = True) { }

	// RVA: 0x2169B18 Offset: 0x2165B18 VA: 0x2169B18
	public void SetPartyRecruitmentData(PartyRecruitmentData[] datas) { }

	// RVA: 0x2169B88 Offset: 0x2165B88 VA: 0x2169B88
	public void UpdatePartyRecruitmentData(PartyRecruitmentData data) { }

	// RVA: 0x2169D68 Offset: 0x2165D68 VA: 0x2169D68
	public void RemovePartyRecruitmentData(int recruitmentId) { }

	// RVA: 0x2169E84 Offset: 0x2165E84 VA: 0x2169E84
	public void SetPartyLeaderRecruitmentData(PartyRecruitmentData data) { }

	// RVA: 0x2169F50 Offset: 0x2165F50 VA: 0x2169F50
	public void SetBeforeApplicationPartyId(int recruitmentId) { }

	// RVA: 0x2169F58 Offset: 0x2165F58 VA: 0x2169F58
	public void SetBeforePartyId(int partyId) { }

	// RVA: 0x2169F60 Offset: 0x2165F60 VA: 0x2169F60
	public bool TryGetPartyRecruitmentData(int recruitmentId, out PartyRecruitmentData data) { }

	// RVA: 0x216A07C Offset: 0x216607C VA: 0x216A07C
	public PartyRecruitmentData GetLeaderPartyRecruitmentData(int partyLeaderId) { }

	// RVA: 0x216A170 Offset: 0x2166170 VA: 0x216A170
	public bool TryGetAllPartyRecruitmentData(out PartyRecruitmentData[] recruitmentDatas) { }

	// RVA: 0x216A1E8 Offset: 0x21661E8 VA: 0x216A1E8
	public bool TryGetMinePartyRecruitmentData(out PartyRecruitmentData data) { }

	// RVA: 0x216A218 Offset: 0x2166218 VA: 0x216A218
	public bool TryGetMinePartyRecruitmentMemberFrameData(out PartyMemberFrameData[] datas) { }

	// RVA: 0x216A270 Offset: 0x2166270 VA: 0x216A270
	public bool TryGetPartyLeaderRecruitmentData(out PartyRecruitmentData data) { }

	// RVA: 0x216A2A0 Offset: 0x21662A0 VA: 0x216A2A0
	public bool TryGetPartyLeaderRecruitmentMemberFrameData(out PartyMemberFrameData[] datas) { }

	// RVA: 0x216A2F8 Offset: 0x21662F8 VA: 0x216A2F8
	public void ClearPartyLeaderRecruitmentData() { }
}
