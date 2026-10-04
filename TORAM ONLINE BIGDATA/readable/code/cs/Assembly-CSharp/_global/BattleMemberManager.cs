// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BattleMemberManager // TypeDefIndex: 1720
{
	// Fields
	private List<BattleMemberData> memberList; // 0x10
	private List<BattleMemberData> petList; // 0x18
	private ArchetypeUid playerArchetypeUid; // 0x20

	// Properties
	public int LoginMemberCount { get; }

	// Methods

	// RVA: 0x20ACC64 Offset: 0x20A8C64 VA: 0x20ACC64
	public int get_LoginMemberCount() { }

	// RVA: 0x20ACE14 Offset: 0x20A8E14 VA: 0x20ACE14
	public void .ctor() { }

	// RVA: 0x20ACEC0 Offset: 0x20A8EC0 VA: 0x20ACEC0
	public void Initialize() { }

	// RVA: 0x20ACEC4 Offset: 0x20A8EC4 VA: 0x20ACEC4
	public void SetPlayerArchetype(ArchetypeUid archetypeUid) { }

	// RVA: 0x20ACECC Offset: 0x20A8ECC VA: 0x20ACECC
	public void UpdateMember(BattleMemberData memberData) { }

	// RVA: 0x20AD278 Offset: 0x20A9278 VA: 0x20AD278
	public void UpdateMemberObject(byte archetypeType, int archetypeId, GameObject actorObject) { }

	// RVA: 0x20AD2B4 Offset: 0x20A92B4 VA: 0x20AD2B4
	public void RemoveMember(ArchetypeUid archetypeUid) { }

	// RVA: 0x20AD2FC Offset: 0x20A92FC VA: 0x20AD2FC
	public void RemoveMember(byte archetypeType, int archetypeId) { }

	// RVA: 0x20AD45C Offset: 0x20A945C VA: 0x20AD45C
	public void Clear() { }

	// RVA: 0x20AD4F8 Offset: 0x20A94F8 VA: 0x20AD4F8
	public bool ContainsBattleMember(ArchetypeUid archetypeUid) { }

	// RVA: 0x20AD544 Offset: 0x20A9544 VA: 0x20AD544
	public bool ContainsBattleMember(byte archetypeType, int archetypeId) { }

	// RVA: 0x20AD660 Offset: 0x20A9660 VA: 0x20AD660
	public BattleMemberData GetBattleMember(ArchetypeUid archetypeUid) { }

	// RVA: 0x20AD6A8 Offset: 0x20A96A8 VA: 0x20AD6A8
	public BattleMemberData GetBattleMember(byte archetypeType, int archetypeId) { }

	// RVA: 0x20AD7EC Offset: 0x20A97EC VA: 0x20AD7EC
	public bool TryGetBattleMember(ArchetypeUid archetypeUid, out BattleMemberData memberData) { }

	// RVA: 0x20ACFF0 Offset: 0x20A8FF0 VA: 0x20ACFF0
	public bool TryGetBattleMember(byte archetypeType, int archetypeId, out BattleMemberData memberData) { }

	// RVA: 0x20AD848 Offset: 0x20A9848 VA: 0x20AD848
	public List<BattleMemberData> GetBattleMemberList() { }

	// RVA: 0x20ADBB8 Offset: 0x20A9BB8 VA: 0x20ADBB8
	public List<BattleMemberData> GetBattleMemberList(UserStateType stateType) { }

	// RVA: 0x20ADF74 Offset: 0x20A9F74 VA: 0x20ADF74
	public List<BattleMemberData> GetOtherPartyBattleMemberList() { }

	// RVA: 0x20AE2E4 Offset: 0x20AA2E4 VA: 0x20AE2E4
	public List<BattleMemberData> GetOtherPartyBattleMemberList(UserStateType stateType) { }

	// RVA: 0x20AE6A0 Offset: 0x20AA6A0 VA: 0x20AE6A0
	public List<BattleMemberData> GetAllBattleMemberList() { }

	// RVA: 0x20AE750 Offset: 0x20AA750 VA: 0x20AE750
	public List<BattleMemberData> GetAllBattleMemberList(UserStateType stateType) { }

	// RVA: 0x20AE8F4 Offset: 0x20AA8F4 VA: 0x20AE8F4
	public void MyAutoMemberSetEventAction(GameObject target) { }

	// RVA: 0x20AEA34 Offset: 0x20AAA34 VA: 0x20AEA34
	public void MyAutoMemberOnVanishingObject(GameObject target) { }

	// RVA: 0x20AEB70 Offset: 0x20AAB70 VA: 0x20AEB70
	public BattleMemberData[] GetMyAutoMembers() { }

	[CompilerGenerated]
	// RVA: 0x20AED58 Offset: 0x20AAD58 VA: 0x20AED58
	private bool <GetMyAutoMembers>b__27_0(BattleMemberData x) { }
}
