// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class SkillBufferManager // TypeDefIndex: 3574
{
	// Fields
	private static SkillId[] NotRemoveSelfBuffer; // 0x0
	private static SkillId[] NotRemoveClearBuffer; // 0x8
	public static Dictionary<BonusType, SkillId> EquipBufList; // 0x10
	public const int TARGET_MAX = 4;
	private readonly Transform actorTransform; // 0x10
	private readonly ArchetypeUid archetypeUid; // 0x18
	private PlayerStatusBase playerStatus; // 0x20
	private readonly BufferEffectManager bufferEffectManager; // 0x28
	private readonly EffectPlayer effectPlayer; // 0x30
	private readonly bool isPlayer; // 0x38
	private Dictionary<SkillId, SkillBufferDataBase> selfSkillBufList; // 0x40
	private List<CircleBufferBase> selfCircleBufList; // 0x48
	private Dictionary<SkillId, SkillBufferDataBase> skillBufList; // 0x50
	private Dictionary<SkillId, ArchetypeUid> otherSkillBufList; // 0x58
	private Dictionary<SkillId, List<ArchetypeUid>> targetSkillBufList; // 0x60
	private Dictionary<SkillComboType, SkillComboBufferBase> comboBufList; // 0x68
	private Dictionary<SkillId, SkillBufferDataBase> temporaryEvacuationBufList; // 0x70
	[CompilerGenerated]
	private bool <IsTimeUpdate>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <IsInvincible>k__BackingField; // 0x79
	private List<SongBufferBase> SensoryBufList; // 0x80
	private Dictionary<SkillId, SongBufferBase> selfSongBufList; // 0x88
	private SongBufferBase mainSongBuf; // 0x90
	private SongBufferBase improvisationSongBuf; // 0x98
	private Dictionary<SkillId, SongBufferBase> otherSongBufList; // 0xA0

	// Properties
	public Dictionary<SkillId, SkillBufferDataBase> SelfSkillBufferList { get; }
	public Dictionary<SkillId, SkillBufferDataBase> SkillBufferList { get; }
	public Dictionary<SkillComboType, SkillComboBufferBase> ComboBufList { get; }
	public bool IsTimeUpdate { get; set; }
	public bool IsInvincible { get; set; }

	// Methods

	// RVA: 0x2369BF8 Offset: 0x2365BF8 VA: 0x2369BF8
	public Dictionary<SkillId, SkillBufferDataBase> get_SelfSkillBufferList() { }

	// RVA: 0x2369C00 Offset: 0x2365C00 VA: 0x2369C00
	public Dictionary<SkillId, SkillBufferDataBase> get_SkillBufferList() { }

	// RVA: 0x2369C08 Offset: 0x2365C08 VA: 0x2369C08
	public Dictionary<SkillComboType, SkillComboBufferBase> get_ComboBufList() { }

	[CompilerGenerated]
	// RVA: 0x2369C10 Offset: 0x2365C10 VA: 0x2369C10
	public bool get_IsTimeUpdate() { }

	[CompilerGenerated]
	// RVA: 0x2369C18 Offset: 0x2365C18 VA: 0x2369C18
	public void set_IsTimeUpdate(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2369C24 Offset: 0x2365C24 VA: 0x2369C24
	public bool get_IsInvincible() { }

	[CompilerGenerated]
	// RVA: 0x2369C2C Offset: 0x2365C2C VA: 0x2369C2C
	private void set_IsInvincible(bool value) { }

	// RVA: 0x2369C38 Offset: 0x2365C38 VA: 0x2369C38
	public void .ctor(Transform actor, ArchetypeUid archetype, BufferEffectManager bufferEffectManager, EffectPlayer effectPlayer, bool isPlayer) { }

	// RVA: 0x2369F64 Offset: 0x2365F64 VA: 0x2369F64
	public void SetPlayerStatus(PlayerStatusBase status) { }

	// RVA: 0x2369F6C Offset: 0x2365F6C VA: 0x2369F6C
	public void OnLeave() { }

	[IteratorStateMachine(typeof(SkillBufferManager.<GetParam>d__35))]
	// RVA: 0x236A0D0 Offset: 0x23660D0 VA: 0x236A0D0
	public IEnumerable<string> GetParam() { }

	[IteratorStateMachine(typeof(SkillBufferManager.<GetLimitParam>d__36))]
	// RVA: 0x236A128 Offset: 0x2366128 VA: 0x236A128
	public IEnumerable<string> GetLimitParam() { }

	[IteratorStateMachine(typeof(SkillBufferManager.<GetSongBufferParam>d__37))]
	// RVA: 0x236A180 Offset: 0x2366180 VA: 0x236A180
	public IEnumerable<string> GetSongBufferParam() { }

	// RVA: 0x236A1D8 Offset: 0x23661D8 VA: 0x236A1D8
	public bool ContainsBuffer(SkillId id) { }

	// RVA: 0x236A230 Offset: 0x2366230 VA: 0x236A230
	public SkillBufferDataBase GetSkillBuffer(SkillId id) { }

	// RVA: 0x236A288 Offset: 0x2366288 VA: 0x236A288
	public IList<SkillBufferDataBase> GetSkillBufferFlagMachBuffer(SkillBufferFlag flag) { }

	// RVA: 0x23660F0 Offset: 0x23620F0 VA: 0x23660F0
	public bool TryGetBuf(SkillId id, out SkillBufferDataBase buf) { }

	// RVA: -1 Offset: -1
	public bool TryGetBuf<T>(SkillId id, out T buf) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EE7D8 Offset: 0x26EA7D8 VA: 0x26EE7D8
	|-SkillBufferManager.TryGetBuf<object>
	*/

	// RVA: 0x236A530 Offset: 0x2366530 VA: 0x236A530
	public void ReceiveSkillActionEnd(PlayerStatusData playerStatusData, int skillParamFlag) { }

	// RVA: 0x236A5C4 Offset: 0x23665C4 VA: 0x236A5C4
	public int GetSkillBufferLevel(SkillId id) { }

	// RVA: 0x236A65C Offset: 0x236665C VA: 0x236A65C
	public int GetSkillBufferParam(SkillBufferId bufferId) { }

	// RVA: 0x236A7E8 Offset: 0x23667E8 VA: 0x236A7E8
	public int GetSkillBufferParam(int bufferId) { }

	// RVA: 0x236A7EC Offset: 0x23667EC VA: 0x236A7EC
	public int GetSkillBufferParam(SkillBufferId id, out int plusValue, out int minusValue) { }

	// RVA: 0x236A7F0 Offset: 0x23667F0 VA: 0x236A7F0
	public int GetSkillBufferParam(int id, out int plusValue, out int minusValue) { }

	// RVA: 0x236A9A8 Offset: 0x23669A8 VA: 0x236A9A8
	public void Clear() { }

	// RVA: 0x236BAA8 Offset: 0x2367AA8 VA: 0x236BAA8
	public void ClearSelfBuffer() { }

	// RVA: 0x236CB10 Offset: 0x2368B10 VA: 0x236CB10
	public void DuelAbilityRestart() { }

	// RVA: 0x236D754 Offset: 0x2369754 VA: 0x236D754
	public void Update() { }

	// RVA: 0x236F06C Offset: 0x236B06C VA: 0x236F06C
	private void UpdateCircleBuf(IEnumerable<PartyMemberData> partyMembers) { }

	// RVA: 0x236F43C Offset: 0x236B43C VA: 0x236F43C
	private void UpdateCircleOtherBuf(IEnumerable<PartyMemberData> partyMembers) { }

	// RVA: 0x236F8CC Offset: 0x236B8CC VA: 0x236F8CC
	private void UpdateCircleSelfBuf(IEnumerable<PartyMemberData> partyMembers) { }

	// RVA: 0x236F0B4 Offset: 0x236B0B4 VA: 0x236F0B4
	private void UpdateSkillCombo() { }

	// RVA: 0x2370E94 Offset: 0x236CE94 VA: 0x2370E94
	private void DrawCircleBufferLine(PartyMemberData member, CircleBufferBase buf) { }

	// RVA: 0x2370DD4 Offset: 0x236CDD4 VA: 0x2370DD4
	private void RemoveCircleBufferLine(PartyMemberData member, CircleBufferBase buf) { }

	// RVA: 0x2370F58 Offset: 0x236CF58 VA: 0x2370F58
	public void OnDamaged(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2371454 Offset: 0x236D454 VA: 0x2371454
	public void OnAbnormalDamaged() { }

	// RVA: 0x23717A8 Offset: 0x236D7A8 VA: 0x23717A8
	public SkillBufferDataBase AddSelfBuffer(SkillId id, byte lv, byte localId) { }

	// RVA: 0x2371D44 Offset: 0x236DD44 VA: 0x2371D44
	public SkillBufferDataBase AddSelfBuffer(SkillId id, byte lv, float time, int val, byte localId) { }

	// RVA: 0x2371800 Offset: 0x236D800 VA: 0x2371800
	public SkillBufferDataBase AddSelfBuffer(SkillBufferDataBase data, byte localId) { }

	// RVA: 0x23722AC Offset: 0x236E2AC VA: 0x23722AC
	public void ChangeEquipDeleteBuf(ItemDBData.EquipType equipType, ItemData equipItem) { }

	// RVA: 0x2372FDC Offset: 0x236EFDC VA: 0x2372FDC
	private bool CheckEquipCanSkillUse(SkillId skillId) { }

	// RVA: 0x236C2CC Offset: 0x23682CC VA: 0x236C2CC
	public void RemoveSelfBuffer(SkillId id) { }

	// RVA: 0x2373338 Offset: 0x236F338 VA: 0x2373338
	public void RemoveOtherBuffer(SkillId skillId) { }

	// RVA: 0x236831C Offset: 0x236431C VA: 0x236831C
	public void AddBuffer(SkillId id, byte lv, float time, int val, int targetId = 0) { }

	// RVA: 0x23735E8 Offset: 0x236F5E8 VA: 0x23735E8
	public void AddBuffer(SkillBufferDataBase buf, int targetId = 0) { }

	// RVA: 0x236D368 Offset: 0x2369368 VA: 0x236D368
	public void RemoveBuffer(SkillId id) { }

	// RVA: 0x2373C58 Offset: 0x236FC58 VA: 0x2373C58
	public int UpdateBuffer(SkillBufferDataBase buffer, bool delete) { }

	// RVA: 0x2373C80 Offset: 0x236FC80 VA: 0x2373C80
	public bool CheckBattle() { }

	// RVA: 0x2373E34 Offset: 0x236FE34 VA: 0x2373E34
	public bool CheckFishing() { }

	// RVA: 0x2373F18 Offset: 0x236FF18 VA: 0x2373F18
	public bool CheckPutWeapon() { }

	// RVA: 0x2371D94 Offset: 0x236DD94 VA: 0x2371D94
	private SkillBufferManager.AddBufReturnCode checkBuffer(SkillBufferDataBase data) { }

	// RVA: 0x23740CC Offset: 0x23700CC VA: 0x23740CC
	public void CreateBonusBuf() { }

	// RVA: 0x2375290 Offset: 0x2371290 VA: 0x2375290
	public void AlignLearningSkillBuffer() { }

	// RVA: 0x23758FC Offset: 0x23718FC VA: 0x23758FC
	public int GetSensoryBufCount() { }

	// RVA: 0x2375944 Offset: 0x2371944 VA: 0x2375944
	public bool AddSelfSongBuf(SongBufferBase buf) { }

	// RVA: 0x2376A2C Offset: 0x2372A2C VA: 0x2376A2C
	public bool AddOtherSongBuf(SongBufferBase buf, int otherArchetypeId) { }

	// RVA: 0x2376B00 Offset: 0x2372B00 VA: 0x2376B00
	public void ReceiveOtherSongBuf(SongBufferBase receiveSongBuf, int otherArchetypeId) { }

	// RVA: 0x2376C24 Offset: 0x2372C24 VA: 0x2376C24
	public void RemoveOtherSongBuf(ArchetypeUid archetypeUid, int skillId) { }

	// RVA: 0x2376CE8 Offset: 0x2372CE8 VA: 0x2376CE8
	public void RemoveOtherSongBuf(ArchetypeUid archetypeUid) { }

	// RVA: 0x2376E34 Offset: 0x2372E34 VA: 0x2376E34
	public void ClearOtherSongBuf() { }

	// RVA: 0x2376EC4 Offset: 0x2372EC4 VA: 0x2376EC4
	public void NextWaveClearSensoryBuf() { }

	// RVA: 0x23779D0 Offset: 0x23739D0 VA: 0x23779D0
	public bool CheckSong() { }

	// RVA: 0x2377A44 Offset: 0x2373A44 VA: 0x2377A44
	public bool CheckSensorySong(SkillId skillId) { }

	// RVA: 0x2377B44 Offset: 0x2373B44 VA: 0x2377B44
	public void SuspendedSong() { }

	// RVA: 0x2377B58 Offset: 0x2373B58 VA: 0x2377B58
	public bool ResumeSong(SkillActionBase skill) { }

	// RVA: 0x2377C00 Offset: 0x2373C00 VA: 0x2377C00
	public bool CheckResumeSong(SkillId skillId) { }

	// RVA: 0x2377C2C Offset: 0x2373C2C VA: 0x2377C2C
	public bool TryGetImprovisationSongBuf(out SongBufferBase songBuf) { }

	// RVA: -1 Offset: -1
	public bool TryGetSelfSongBuf<T>(SkillId skillId, out T songBuf) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EE970 Offset: 0x26EA970 VA: 0x26EE970
	|-SkillBufferManager.TryGetSelfSongBuf<object>
	*/

	// RVA: 0x236F094 Offset: 0x236B094 VA: 0x236F094
	private void UpdateAllSong(IEnumerable<PartyMemberData> partyMembers) { }

	// RVA: 0x2377C78 Offset: 0x2373C78 VA: 0x2377C78
	private void UpdateSelfSongBuf(IEnumerable<PartyMemberData> partyMembers) { }

	// RVA: 0x2378AEC Offset: 0x2374AEC VA: 0x2378AEC
	private void UpdateOtherSongBuf() { }

	// RVA: 0x2375B20 Offset: 0x2371B20 VA: 0x2375B20
	private void UpdateValidSongBuf() { }

	// RVA: 0x2378E00 Offset: 0x2374E00 VA: 0x2378E00
	public void UpdateSelfKnightPledgeBuf(int archetypeId, byte level, int num, int lastDamageRate, int knockbackDistReduceRate, byte skillLocalId, bool inArea) { }

	// RVA: 0x2378FB0 Offset: 0x2374FB0 VA: 0x2378FB0
	public void AddOtherKnightPledgeBuf(int targetArchetypeId, byte level, int receiveEncryptionValue, int num) { }

	// RVA: 0x23790C0 Offset: 0x23750C0 VA: 0x23790C0
	public bool RemoveSelfKnightPledgeBuf(int skillLocalId = -1) { }

	// RVA: 0x236EA58 Offset: 0x236AA58 VA: 0x236EA58
	private void UpdateKnightPledgeBuf() { }

	// RVA: 0x2378F38 Offset: 0x2374F38 VA: 0x2378F38
	private void EffectiveKnightPledgeBuf() { }

	// RVA: 0x236EAF0 Offset: 0x236AAF0 VA: 0x236EAF0
	private void UpdateIndividualBuf() { }

	// RVA: 0x2369088 Offset: 0x2365088 VA: 0x2369088
	public void UpdateFirstAidBuffer() { }

	// RVA: 0x2379180 Offset: 0x2375180 VA: 0x2379180
	public void ClearFirstAidBuffer() { }

	// RVA: 0x23791E8 Offset: 0x23751E8 VA: 0x23791E8
	public void AddSelfDanceBuf(SkillId id, byte level) { }

	// RVA: 0x2379358 Offset: 0x2375358 VA: 0x2379358
	public void AddOtherDanceBuf(SkillId id, byte level, int danceLevel, float time) { }

	// RVA: 0x236EC50 Offset: 0x236AC50 VA: 0x236EC50
	private void ChangeDanceBufLevel() { }

	// RVA: 0x2379408 Offset: 0x2375408 VA: 0x2379408
	public void SetBufferEffectActive(SkillId skillId, bool active) { }

	// RVA: 0x2379498 Offset: 0x2375498 VA: 0x2379498
	public bool AddSkillComboBuf(SkillComboType type) { }

	// RVA: 0x2379590 Offset: 0x2375590 VA: 0x2379590
	public bool RemocveSkillComboBuf(SkillComboType type) { }

	// RVA: 0x2379624 Offset: 0x2375624 VA: 0x2379624
	public bool ContainsSkillComboBuf(SkillComboType type) { }

	// RVA: 0x237967C Offset: 0x237567C VA: 0x237967C
	public void SwapApplyBuffer(SkillId skillId, SkillBufferDataBase temporaryBuf) { }

	// RVA: 0x2379794 Offset: 0x2375794 VA: 0x2379794
	public void RestoreBuf(SkillId skillId, bool isTemporaryBuf) { }

	// RVA: 0x236EB94 Offset: 0x236AB94 VA: 0x236EB94
	private void RemoveBufferChangeGuardAvoidStatus(SkillId skillId) { }

	// RVA: 0x237987C Offset: 0x237587C VA: 0x237987C
	public void UpdateBoomerangBuf(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2379CD0 Offset: 0x2375CD0 VA: 0x2379CD0
	private static void .cctor() { }
}
