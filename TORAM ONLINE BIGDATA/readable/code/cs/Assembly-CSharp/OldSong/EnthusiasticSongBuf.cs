// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class EnthusiasticSongBuf : SkillSongBufferDataBase // TypeDefIndex: 9126
{
	// Fields
	private readonly float SkillLvInflueceValue; // 0x6C
	private readonly float NonInfluenceValue; // 0x70

	// Properties
	public override SkillId SkillId { get; }
	protected override float MaxContinueTime { get; }
	public override int BufEffectTakeId { get; }
	protected override EmotionPlayer.EmotionType emotionType { get; }

	// Methods

	// RVA: 0x1EAF818 Offset: 0x1EAB818 VA: 0x1EAF818 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x1EAF820 Offset: 0x1EAB820 VA: 0x1EAF820 Slot: 30
	protected override float get_MaxContinueTime() { }

	// RVA: 0x1EAF82C Offset: 0x1EAB82C VA: 0x1EAF82C Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x1EAF834 Offset: 0x1EAB834 VA: 0x1EAF834 Slot: 31
	protected override EmotionPlayer.EmotionType get_emotionType() { }

	// RVA: 0x1EAF83C Offset: 0x1EAB83C VA: 0x1EAF83C
	public void .ctor(byte lv, bool self, int notice_song_buff_lv) { }

	// RVA: 0x1EAF9DC Offset: 0x1EAB9DC VA: 0x1EAF9DC
	public void .ctor(byte _skill_lv, bool _self, int _song_buff_lv, int _time) { }

	// RVA: 0x1EAFA40 Offset: 0x1EABA40 VA: 0x1EAFA40 Slot: 12
	public override int GetParam(int id) { }
}
