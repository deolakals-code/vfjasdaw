// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class SongOfLifeBuf : SkillSongBufferDataBase // TypeDefIndex: 9133
{
	// Properties
	public override SkillId SkillId { get; }
	protected override EmotionPlayer.EmotionType emotionType { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x1EB0B1C Offset: 0x1EACB1C VA: 0x1EB0B1C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x1EB0B24 Offset: 0x1EACB24 VA: 0x1EB0B24 Slot: 31
	protected override EmotionPlayer.EmotionType get_emotionType() { }

	// RVA: 0x1EB0B2C Offset: 0x1EACB2C VA: 0x1EB0B2C Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x1EB0B34 Offset: 0x1EACB34 VA: 0x1EB0B34
	public void .ctor(byte lv, bool self, int _song_buff_lv) { }

	// RVA: 0x1EB0BE0 Offset: 0x1EACBE0 VA: 0x1EB0BE0
	public void .ctor(byte _skill_lv, bool _self, int _song_buff_lv, int _time) { }

	// RVA: 0x1EB0C38 Offset: 0x1EACC38 VA: 0x1EB0C38 Slot: 12
	public override int GetParam(int id) { }
}
