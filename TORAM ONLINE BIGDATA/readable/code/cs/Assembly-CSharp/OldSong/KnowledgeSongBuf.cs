// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class KnowledgeSongBuf : SkillSongBufferDataBase // TypeDefIndex: 9130
{
	// Fields
	private readonly int SkillLvInflueceValue; // 0x6C
	private readonly int NonInfluenceValue; // 0x70

	// Properties
	public override SkillId SkillId { get; }
	protected override float MaxContinueTime { get; }
	protected override EmotionPlayer.EmotionType emotionType { get; }

	// Methods

	// RVA: 0x1EAFD84 Offset: 0x1EABD84 VA: 0x1EAFD84 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x1EAFD8C Offset: 0x1EABD8C VA: 0x1EAFD8C Slot: 30
	protected override float get_MaxContinueTime() { }

	// RVA: 0x1EAFD98 Offset: 0x1EABD98 VA: 0x1EAFD98 Slot: 31
	protected override EmotionPlayer.EmotionType get_emotionType() { }

	// RVA: 0x1EAFDA0 Offset: 0x1EABDA0 VA: 0x1EAFDA0
	public void .ctor(byte lv, bool self, int notice_song_buff_lv) { }

	// RVA: 0x1EAFE58 Offset: 0x1EABE58 VA: 0x1EAFE58
	public void .ctor(byte lv, bool self, int _song_buff_lv, int _time) { }

	// RVA: 0x1EAFEBC Offset: 0x1EABEBC VA: 0x1EAFEBC Slot: 12
	public override int GetParam(int id) { }
}
