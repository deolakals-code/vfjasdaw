// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnthusiasticSongBuf : SongBufferBase // TypeDefIndex: 3149
{
	// Fields
	private int elementDamage; // 0x5C

	// Properties
	public override SkillId SkillId { get; }
	protected override EmotionPlayer.EmotionType EmotionType { get; }

	// Methods

	// RVA: 0x232BFF0 Offset: 0x2327FF0 VA: 0x232BFF0
	public static EnthusiasticSongBuf CreateSelfBuf(byte lv, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId, byte sensoryCount) { }

	// RVA: 0x232C110 Offset: 0x2328110 VA: 0x232C110
	public static EnthusiasticSongBuf CreateOtherBuf(byte lv, int archetypeId, byte skillLocalId, bool isSensory) { }

	// RVA: 0x232C0C0 Offset: 0x23280C0 VA: 0x232C0C0
	private void .ctor(byte lv, bool self, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId) { }

	// RVA: 0x232C1E0 Offset: 0x23281E0 VA: 0x232C1E0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232C1E8 Offset: 0x23281E8 VA: 0x232C1E8 Slot: 21
	protected override EmotionPlayer.EmotionType get_EmotionType() { }

	// RVA: 0x232C1F0 Offset: 0x23281F0 VA: 0x232C1F0 Slot: 11
	public override void Updata() { }

	// RVA: 0x232C2C4 Offset: 0x23282C4 VA: 0x232C2C4 Slot: 12
	public override int GetParam(int id) { }
}
