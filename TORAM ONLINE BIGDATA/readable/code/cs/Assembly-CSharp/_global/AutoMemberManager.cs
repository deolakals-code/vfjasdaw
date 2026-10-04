// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class AutoMemberManager // TypeDefIndex: 452
{
	// Fields
	private List<AutoMember> createdAutoMember; // 0x10
	private Dictionary<ArchetypeUid, INPCPartyMemberReserve> reservedAutoMember; // 0x18
	private PlayerDataManager playerDataManager; // 0x20
	private MobRangeAttackCollection mobRangeAttackList; // 0x28

	// Properties
	public IList<AutoMember> AutoMemberList { get; }

	// Methods

	// RVA: 0x174C7FC Offset: 0x17487FC VA: 0x174C7FC
	public IList<AutoMember> get_AutoMemberList() { }

	// RVA: 0x174C804 Offset: 0x1748804 VA: 0x174C804
	public void .ctor(PlayerDataManager dataManager, MobRangeAttackCollection mobRangeAttack) { }

	// RVA: 0x174C910 Offset: 0x1748910 VA: 0x174C910
	public void RejoinMember(Game engine, RoomArchetypeManagedEvent response) { }

	[Obsolete]
	// RVA: 0x174CF90 Offset: 0x1748F90 VA: 0x174CF90
	public void Create(GameObject obj) { }

	// RVA: 0x174D64C Offset: 0x174964C VA: 0x174D64C
	public void Create(Archetype archetype, GameObject obj, AutoMemberSettingBase setting) { }

	// RVA: 0x174DA90 Offset: 0x1749A90 VA: 0x174DA90
	public void CreateMercenary(Archetype archetype, GameObject obj, MercenarySetting setting) { }

	// RVA: 0x174DE40 Offset: 0x1749E40 VA: 0x174DE40
	public void CreatePet(Archetype archetype, GameObject obj, PetMemberSettingBase setting) { }

	// RVA: 0x174E1D4 Offset: 0x174A1D4 VA: 0x174E1D4
	public void CreateFamilia(Archetype archetype, GameObject obj, FamiliaMemberSettingBase setting) { }

	// RVA: 0x174E630 Offset: 0x174A630 VA: 0x174E630
	public void CreateHuntingOne(Archetype archetype, GameObject obj, HuntingOneMemberSettingBase setting) { }

	// RVA: 0x174EA8C Offset: 0x174AA8C VA: 0x174EA8C
	public void CreateSummonDemonic(Archetype archetype, GameObject obj, SummonDemonicMemberSettingBase setting) { }

	// RVA: 0x174EEE8 Offset: 0x174AEE8 VA: 0x174EEE8
	public void CreateCallGolem(Archetype archetype, GameObject obj, CallGolemMemberSettingBase setting) { }

	// RVA: 0x174D7E4 Offset: 0x17497E4 VA: 0x174D7E4
	private void attachParty(AutoMember newMember) { }

	// RVA: 0x174F344 Offset: 0x174B344 VA: 0x174F344
	public bool Remove(AutoMember obj, bool DestroyObj) { }

	// RVA: 0x174CB7C Offset: 0x1748B7C VA: 0x174CB7C
	public void RemoveAll() { }

	// RVA: 0x174F490 Offset: 0x174B490 VA: 0x174F490
	public bool Contains(GameObject obj) { }

	// RVA: 0x174F7D4 Offset: 0x174B7D4 VA: 0x174F7D4
	public bool TryGetAutoMember(GameObject obj, out AutoMember automember) { }

	// RVA: 0x174FB88 Offset: 0x174BB88 VA: 0x174FB88
	public bool TryGetAutoMember(byte archetypeType, int archetypeId, out AutoMember automember) { }

	// RVA: 0x174FDC4 Offset: 0x174BDC4 VA: 0x174FDC4
	public bool TryGetPet(long petuuid, out PetMember pet) { }

	// RVA: 0x1750010 Offset: 0x174C010 VA: 0x1750010
	public void OnPetStatusUp(Game game, HousePetStatusUpResponse response) { }

	// RVA: 0x1750058 Offset: 0x174C058 VA: 0x1750058
	public void OnPetUpdateEvent(Game game, PetUpdateEvent updateEvent) { }

	// RVA: 0x17500A0 Offset: 0x174C0A0 VA: 0x17500A0
	public void SetEventAction(GameObject gameObject) { }

	// RVA: 0x1750480 Offset: 0x174C480 VA: 0x1750480
	public void SetEmotion(EmotionPlayer.EmotionType emotionId) { }

	// RVA: 0x17506DC Offset: 0x174C6DC VA: 0x17506DC
	public void RoomEnterStart() { }

	// RVA: 0x1750A98 Offset: 0x174CA98 VA: 0x1750A98
	public ValueTuple<GameObject, float> GetNearInCameraTarget(Vector3 pos, float rad, float height, GameObject exclusions) { }

	// RVA: 0x1750E68 Offset: 0x174CE68 VA: 0x1750E68
	public ValueTuple<GameObject, float> GetFarInCameraTarget(Vector3 pos, float rad, float height, GameObject exclusions) { }

	// RVA: 0x1751238 Offset: 0x174D238 VA: 0x1751238
	public void ReserveAutoMember(ArchetypeUid archetypeId, AutoMemberSettingBase setting) { }

	// RVA: 0x17512D0 Offset: 0x174D2D0 VA: 0x17512D0
	public void ReserveMercenaryMember(ArchetypeUid archetypeId, MercenarySetting setting) { }

	// RVA: 0x1751440 Offset: 0x174D440 VA: 0x1751440
	public void ReservePartyPet(ArchetypeUid archetypeId, PetMemberSettingBase setting) { }

	// RVA: 0x17515B0 Offset: 0x174D5B0 VA: 0x17515B0
	public void ReserveServant(ArchetypeUid archetypeUid, NPCPartySettingBase setting) { }

	// RVA: 0x175192C Offset: 0x174D92C VA: 0x175192C
	public bool TryGetReservedData(ArchetypeUid archetypeId, out INPCPartyMemberReserve setting) { }

	// RVA: 0x174DDE8 Offset: 0x1749DE8 VA: 0x174DDE8
	public bool RemoveReservedData(ArchetypeUid archetypeId) { }

	// RVA: 0x1751994 Offset: 0x174D994 VA: 0x1751994
	public void RemoveAllReservedData() { }

	// RVA: 0x17519E4 Offset: 0x174D9E4 VA: 0x17519E4
	public void OnVanishingObject(GameObject obj) { }
}
