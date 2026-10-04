// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class SongBufferBase : SkillBufferDataBase // TypeDefIndex: 3317
{
	// Fields
	[CompilerGenerated]
	private bool <IsSensory>k__BackingField; // 0x1D
	[CompilerGenerated]
	private bool <IsSuspendSong>k__BackingField; // 0x1E
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <SkillLocalId>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsSendSupport>k__BackingField; // 0x25
	protected readonly PlayerActionManagerBase actorAction; // 0x28
	protected readonly TakeController takeController; // 0x30
	protected const int SongStartTakeId = 2011000;
	protected const int SongTakeId = 202012001;
	protected const float SendSupportInterval = 1;
	private float suspendedTimer; // 0x38
	protected float sensoryTimer; // 0x3C
	protected byte sensoryCount; // 0x40
	protected int playTakeUid; // 0x44
	protected bool isChangeSongMotion; // 0x48
	protected bool isHideIcon; // 0x49
	protected float sendSupportTimer; // 0x4C
	private long effectiveStartTime; // 0x50
	protected byte partyMemberNum; // 0x58

	// Properties
	public override SkillBufferFlag Flag { get; }
	public bool IsSensory { get; set; }
	public bool IsSuspendSong { get; set; }
	public int ArchetypeId { get; set; }
	public byte SkillLocalId { get; set; }
	protected abstract EmotionPlayer.EmotionType EmotionType { get; }
	public bool IsSendSupport { get; set; }

	// Methods

	// RVA: 0x23415D0 Offset: 0x233D5D0 VA: 0x23415D0
	protected void .ctor(byte lv, bool self, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId) { }

	// RVA: 0x23460A0 Offset: 0x23420A0 VA: 0x23460A0 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x23460B8 Offset: 0x23420B8 VA: 0x23460B8
	public bool get_IsSensory() { }

	[CompilerGenerated]
	// RVA: 0x23460C0 Offset: 0x23420C0 VA: 0x23460C0
	protected void set_IsSensory(bool value) { }

	[CompilerGenerated]
	// RVA: 0x23460CC Offset: 0x23420CC VA: 0x23460CC
	public bool get_IsSuspendSong() { }

	[CompilerGenerated]
	// RVA: 0x23460D4 Offset: 0x23420D4 VA: 0x23460D4
	private void set_IsSuspendSong(bool value) { }

	[CompilerGenerated]
	// RVA: 0x23460E0 Offset: 0x23420E0 VA: 0x23460E0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x23460E8 Offset: 0x23420E8 VA: 0x23460E8
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x23460F0 Offset: 0x23420F0 VA: 0x23460F0
	public byte get_SkillLocalId() { }

	[CompilerGenerated]
	// RVA: 0x23460F8 Offset: 0x23420F8 VA: 0x23460F8
	private void set_SkillLocalId(byte value) { }

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract EmotionPlayer.EmotionType get_EmotionType();

	[CompilerGenerated]
	// RVA: 0x2346100 Offset: 0x2342100 VA: 0x2346100
	public bool get_IsSendSupport() { }

	[CompilerGenerated]
	// RVA: 0x2346108 Offset: 0x2342108 VA: 0x2346108
	protected void set_IsSendSupport(bool value) { }

	// RVA: 0x2346114 Offset: 0x2342114 VA: 0x2346114 Slot: 11
	public override void Updata() { }

	// RVA: 0x2346118 Offset: 0x2342118 VA: 0x2346118 Slot: 22
	protected virtual void UpdateMotionSwitch() { }

	// RVA: 0x2346358 Offset: 0x2342358 VA: 0x2346358
	private void ChangeSongMotion() { }

	// RVA: 0x23466C4 Offset: 0x23426C4 VA: 0x23466C4
	public void TakeStop(bool sendEmotionCancel = True) { }

	// RVA: 0x23465B4 Offset: 0x23425B4 VA: 0x23465B4
	public bool CheckTake() { }

	// RVA: 0x23467B4 Offset: 0x23427B4 VA: 0x23467B4 Slot: 23
	protected virtual void UpdateSuspended() { }

	// RVA: 0x234682C Offset: 0x234282C VA: 0x234682C Slot: 24
	protected virtual void UpdateSendSupport() { }

	// RVA: 0x2346878 Offset: 0x2342878 VA: 0x2346878 Slot: 25
	protected virtual void UpdateSensory() { }

	// RVA: 0x23415A8 Offset: 0x233D5A8 VA: 0x23415A8
	public void Sensory() { }

	// RVA: 0x23468D4 Offset: 0x23428D4 VA: 0x23468D4
	public void ChangeSensoryCount(byte count) { }

	// RVA: 0x2346910 Offset: 0x2342910 VA: 0x2346910
	public void SendSupport() { }

	// RVA: 0x23466AC Offset: 0x23426AC VA: 0x23466AC
	public void SuspendSong() { }

	// RVA: 0x2346918 Offset: 0x2342918 VA: 0x2346918
	public void ResumeSong(byte skillLocalId) { }

	// RVA: 0x2346060 Offset: 0x2342060 VA: 0x2346060
	public void UpdatePlayTakeUid() { }

	// RVA: 0x2346958 Offset: 0x2342958 VA: 0x2346958
	public void UpdateSuspendTimer() { }

	// RVA: 0x2346820 Offset: 0x2342820 VA: 0x2346820
	public void HiddenBufferIcon() { }

	// RVA: 0x2346950 Offset: 0x2342950 VA: 0x2346950
	public void DisplayBufferIcon() { }

	// RVA: 0x2346964 Offset: 0x2342964 VA: 0x2346964
	public bool CheckOldSong(SongBufferBase compareSongBuf) { }

	// RVA: 0x2346988 Offset: 0x2342988 VA: 0x2346988 Slot: 20
	public override void SetActive(bool active) { }

	// RVA: 0x23469E4 Offset: 0x23429E4 VA: 0x23469E4 Slot: 26
	protected virtual void OnValid() { }

	// RVA: 0x23469E8 Offset: 0x23429E8 VA: 0x23469E8 Slot: 27
	protected virtual void OnInvalid() { }

	// RVA: 0x23469EC Offset: 0x23429EC VA: 0x23469EC
	public void UpdatePartyMember(IEnumerable<PartyMemberData> partyMembers) { }
}
