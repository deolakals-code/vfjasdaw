// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HealingSongBuf : SongBufferBase // TypeDefIndex: 3189
{
	// Fields
	private int naturalHpRecoveryRate; // 0x5C
	private int naturalMpRecoveryRate; // 0x60
	private int expBonus; // 0x64

	// Properties
	public override SkillId SkillId { get; }
	protected override EmotionPlayer.EmotionType EmotionType { get; }

	// Methods

	// RVA: 0x23324DC Offset: 0x232E4DC VA: 0x23324DC
	public static HealingSongBuf CreateSelfBuf(byte lv, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId, byte sensoryCount) { }

	// RVA: 0x23326C4 Offset: 0x232E6C4 VA: 0x23326C4
	public static HealingSongBuf CreateOtherBuf(byte lv, int archetypeId, byte skillLocalId, bool isSensory, int mLv) { }

	// RVA: 0x2332660 Offset: 0x232E660 VA: 0x2332660
	private void .ctor(byte lv, bool self, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId, int mLv) { }

	// RVA: 0x23327A4 Offset: 0x232E7A4 VA: 0x23327A4 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23327AC Offset: 0x232E7AC VA: 0x23327AC Slot: 21
	protected override EmotionPlayer.EmotionType get_EmotionType() { }

	// RVA: 0x23327B4 Offset: 0x232E7B4 VA: 0x23327B4 Slot: 11
	public override void Updata() { }

	// RVA: 0x2332888 Offset: 0x232E888 VA: 0x2332888 Slot: 12
	public override int GetParam(int id) { }
}
