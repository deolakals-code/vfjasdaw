// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public abstract class SkillSongBufferDataBase : CountBufferBase, ISkillBufferValid // TypeDefIndex: 9132
{
	// Fields
	private readonly float NotificationTime; // 0x28
	protected const int MaxSongBufLevel = 10;
	protected int songBuffLv; // 0x2C
	protected float nowTimeLvUp; // 0x30
	private float notificationTime; // 0x34
	private float limitEffectiveTime; // 0x38
	protected PlayerActionManagerBase actionManager; // 0x40
	protected TakeController takeController; // 0x48
	protected int playLoopTakeUid; // 0x50
	protected float protectedTime; // 0x54
	protected bool isBattleActive; // 0x58
	protected int guitaristSavingTime; // 0x5C
	[CompilerGenerated]
	private bool <ValidSongBuffLvUp>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <NotificationBuffContinued>k__BackingField; // 0x61
	[CompilerGenerated]
	private int <UseArcheTypeId>k__BackingField; // 0x64
	[CompilerGenerated]
	private bool <IsValidBuff>k__BackingField; // 0x68

	// Properties
	protected virtual float SongBuffLvUpTime { get; }
	protected virtual float SongBuffLvProtectedTime { get; }
	public bool ValidSongBuffLvUp { get; set; }
	public bool NotificationBuffContinued { get; set; }
	public int SongBufLv { get; }
	public int UseArcheTypeId { get; set; }
	private int TakeLoopMotionID { get; }
	public override CountBufferBase.CountType BufferType { get; }
	protected virtual float MaxContinueTime { get; }
	public bool IsValidBuff { get; set; }
	public bool IsSongTake { get; }
	public float DisplayLeftTime { get; }
	protected virtual EmotionPlayer.EmotionType emotionType { get; }
	public override SkillBufferFlag Flag { get; }
	public override bool IsPutUpWeapon { get; }

	// Methods

	// RVA: 0x1EAFFDC Offset: 0x1EABFDC VA: 0x1EAFFDC Slot: 28
	protected virtual float get_SongBuffLvUpTime() { }

	// RVA: 0x1EAFFF0 Offset: 0x1EABFF0 VA: 0x1EAFFF0 Slot: 29
	protected virtual float get_SongBuffLvProtectedTime() { }

	[CompilerGenerated]
	// RVA: 0x1EAFFF8 Offset: 0x1EABFF8 VA: 0x1EAFFF8
	public bool get_ValidSongBuffLvUp() { }

	[CompilerGenerated]
	// RVA: 0x1EB0000 Offset: 0x1EAC000 VA: 0x1EB0000
	protected void set_ValidSongBuffLvUp(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1EB000C Offset: 0x1EAC00C VA: 0x1EB000C
	public bool get_NotificationBuffContinued() { }

	[CompilerGenerated]
	// RVA: 0x1EB0014 Offset: 0x1EAC014 VA: 0x1EB0014
	private void set_NotificationBuffContinued(bool value) { }

	// RVA: 0x1EB0020 Offset: 0x1EAC020 VA: 0x1EB0020
	public int get_SongBufLv() { }

	[CompilerGenerated]
	// RVA: 0x1EB0028 Offset: 0x1EAC028 VA: 0x1EB0028
	public int get_UseArcheTypeId() { }

	[CompilerGenerated]
	// RVA: 0x1EB0030 Offset: 0x1EAC030 VA: 0x1EB0030
	public void set_UseArcheTypeId(int value) { }

	// RVA: 0x1EB0038 Offset: 0x1EAC038 VA: 0x1EB0038
	private int get_TakeLoopMotionID() { }

	// RVA: 0x1EB0050 Offset: 0x1EAC050 VA: 0x1EB0050 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x1EB0068 Offset: 0x1EAC068 VA: 0x1EB0068 Slot: 30
	protected virtual float get_MaxContinueTime() { }

	[CompilerGenerated]
	// RVA: 0x1EB0074 Offset: 0x1EAC074 VA: 0x1EB0074 Slot: 27
	public bool get_IsValidBuff() { }

	[CompilerGenerated]
	// RVA: 0x1EB007C Offset: 0x1EAC07C VA: 0x1EB007C
	private void set_IsValidBuff(bool value) { }

	// RVA: 0x1EB0088 Offset: 0x1EAC088 VA: 0x1EB0088
	public bool get_IsSongTake() { }

	// RVA: 0x1EB0098 Offset: 0x1EAC098 VA: 0x1EB0098
	public float get_DisplayLeftTime() { }

	// RVA: 0x1EB00F0 Offset: 0x1EAC0F0 VA: 0x1EB00F0 Slot: 31
	protected virtual EmotionPlayer.EmotionType get_emotionType() { }

	// RVA: 0x1EB00F8 Offset: 0x1EAC0F8 VA: 0x1EB00F8 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x1EB0114 Offset: 0x1EAC114 VA: 0x1EB0114 Slot: 10
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x1EAF86C Offset: 0x1EAB86C VA: 0x1EAF86C
	public void .ctor(byte lv, bool self, int notice_song_buff_lv) { }

	// RVA: 0x1EB01C4 Offset: 0x1EAC1C4 VA: 0x1EB01C4 Slot: 11
	public override void Updata() { }

	// RVA: 0x1EB0604 Offset: 0x1EAC604 VA: 0x1EB0604
	private void self_update(float _elapsed_time) { }

	// RVA: 0x1EB0750 Offset: 0x1EAC750 VA: 0x1EB0750
	private void other_update(float _elapsed_time) { }

	// RVA: 0x1EB08BC Offset: 0x1EAC8BC VA: 0x1EB08BC
	public void OtherSideResetAtImprovisationSong() { }

	// RVA: 0x1EB08D4 Offset: 0x1EAC8D4 VA: 0x1EB08D4 Slot: 32
	protected virtual void songbuff_lvup() { }

	// RVA: 0x1EB086C Offset: 0x1EAC86C VA: 0x1EB086C
	private void notification_state_change() { }

	// RVA: 0x1EB09A4 Offset: 0x1EAC9A4 VA: 0x1EB09A4
	private void adjust_whithin_range() { }

	// RVA: 0x1EB0898 Offset: 0x1EAC898 VA: 0x1EB0898
	private void end_state_change() { }

	// RVA: 0x1EB09C8 Offset: 0x1EAC9C8 VA: 0x1EB09C8
	public void FinishReport() { }

	// RVA: 0x1EB09D0 Offset: 0x1EAC9D0 VA: 0x1EB09D0 Slot: 13
	public override void OnDamage(PlayerActionManagerBase playerAction) { }

	// RVA: 0x1EB07A0 Offset: 0x1EAC7A0 VA: 0x1EB07A0
	public void BuffContinueEnd() { }

	// RVA: 0x1EB09E0 Offset: 0x1EAC9E0 VA: 0x1EB09E0
	public void ActivationBuffEffect() { }

	// RVA: 0x1EB0558 Offset: 0x1EAC558 VA: 0x1EB0558
	public void ShowOffInterruotion() { }

	// RVA: 0x1EB0A50 Offset: 0x1EACA50 VA: 0x1EB0A50 Slot: 33
	public virtual void Interruotion() { }

	// RVA: 0x1EB017C Offset: 0x1EAC17C VA: 0x1EB017C
	protected bool CheckTake() { }

	// RVA: 0x1EB0B00 Offset: 0x1EACB00 VA: 0x1EB0B00 Slot: 18
	public override bool CheckUnableEquipChange() { }
}
