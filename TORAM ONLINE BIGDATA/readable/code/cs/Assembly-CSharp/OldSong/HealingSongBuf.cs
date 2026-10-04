// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class HealingSongBuf : SkillSongBufferDataBase // TypeDefIndex: 9128
{
	// Properties
	public override SkillId SkillId { get; }
	protected override float MaxContinueTime { get; }

	// Methods

	// RVA: 0x1EAFBA0 Offset: 0x1EABBA0 VA: 0x1EAFBA0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x1EAFBA8 Offset: 0x1EABBA8 VA: 0x1EAFBA8 Slot: 30
	protected override float get_MaxContinueTime() { }

	// RVA: 0x1EAFBB4 Offset: 0x1EABBB4 VA: 0x1EAFBB4
	public void .ctor(byte _skill_lv, bool _self, int _song_buff_lv) { }

	// RVA: 0x1EAFBEC Offset: 0x1EABBEC VA: 0x1EAFBEC
	public void .ctor(byte _skill_lv, bool _self, int _song_buff_lv, int time) { }

	// RVA: 0x1EAFC4C Offset: 0x1EABC4C VA: 0x1EAFC4C Slot: 12
	public override int GetParam(int id) { }
}
