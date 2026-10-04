// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class PhantomSongBuf : SkillSongBufferDataBase // TypeDefIndex: 9131
{
	// Properties
	public override SkillId SkillId { get; }
	protected override float MaxContinueTime { get; }
	protected override float SongBuffLvUpTime { get; }
	protected override EmotionPlayer.EmotionType emotionType { get; }

	// Methods

	// RVA: 0x1EAFEF8 Offset: 0x1EABEF8 VA: 0x1EAFEF8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x1EAFF00 Offset: 0x1EABF00 VA: 0x1EAFF00 Slot: 30
	protected override float get_MaxContinueTime() { }

	// RVA: 0x1EAFF0C Offset: 0x1EABF0C VA: 0x1EAFF0C Slot: 28
	protected override float get_SongBuffLvUpTime() { }

	// RVA: 0x1EAFF28 Offset: 0x1EABF28 VA: 0x1EAFF28 Slot: 31
	protected override EmotionPlayer.EmotionType get_emotionType() { }

	// RVA: 0x1EAFF30 Offset: 0x1EABF30 VA: 0x1EAFF30
	public void .ctor(byte lv, bool self, int notice_song_buff_lv) { }

	// RVA: 0x1EAFF54 Offset: 0x1EABF54 VA: 0x1EAFF54
	public void .ctor(byte _skill_lv, bool _self, int _song_buff_lv, int time) { }

	// RVA: 0x1EAFFAC Offset: 0x1EABFAC VA: 0x1EAFFAC
	public int CheckCanUseBuf(int _use_point) { }

	// RVA: 0x1EAFFC0 Offset: 0x1EABFC0 VA: 0x1EAFFC0
	public void UseSongBuf(int _count) { }

	// RVA: 0x1EAFFD4 Offset: 0x1EABFD4 VA: 0x1EAFFD4 Slot: 12
	public override int GetParam(int id) { }
}
