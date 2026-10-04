// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class FairySongBuf : SkillSongBufferDataBase // TypeDefIndex: 9127
{
	// Properties
	public override SkillId SkillId { get; }
	protected override float MaxContinueTime { get; }
	protected override EmotionPlayer.EmotionType emotionType { get; }

	// Methods

	// RVA: 0x1EAFAAC Offset: 0x1EABAAC VA: 0x1EAFAAC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x1EAFAB4 Offset: 0x1EABAB4 VA: 0x1EAFAB4 Slot: 30
	protected override float get_MaxContinueTime() { }

	// RVA: 0x1EAFAC0 Offset: 0x1EABAC0 VA: 0x1EAFAC0 Slot: 31
	protected override EmotionPlayer.EmotionType get_emotionType() { }

	// RVA: 0x1EAFAC8 Offset: 0x1EABAC8 VA: 0x1EAFAC8
	public void .ctor(byte lv, bool self, int notice_song_buff_lv) { }

	// RVA: 0x1EAFAEC Offset: 0x1EABAEC VA: 0x1EAFAEC
	public void .ctor(byte _skill_lv, bool _self, int _song_buff_lv, int time) { }

	// RVA: 0x1EAFB4C Offset: 0x1EABB4C VA: 0x1EAFB4C Slot: 12
	public override int GetParam(int id) { }
}
