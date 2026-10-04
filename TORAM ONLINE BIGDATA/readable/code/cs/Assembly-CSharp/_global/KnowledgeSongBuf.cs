// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KnowledgeSongBuf : SongBufferBase // TypeDefIndex: 3224
{
	// Fields
	private int reduceDamageRate; // 0x5C
	private int knockbackReduceValue; // 0x60

	// Properties
	public override SkillId SkillId { get; }
	protected override EmotionPlayer.EmotionType EmotionType { get; }

	// Methods

	// RVA: 0x233905C Offset: 0x233505C VA: 0x233905C
	public static KnowledgeSongBuf CreateSelfBuf(byte lv, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId, byte sensoryCount) { }

	// RVA: 0x2339190 Offset: 0x2335190 VA: 0x2339190
	public static KnowledgeSongBuf CreateOtherBuf(byte lv, int archetypeId, byte skillLocalId, bool isSensory) { }

	// RVA: 0x2339134 Offset: 0x2335134 VA: 0x2339134
	private void .ctor(byte lv, bool self, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId) { }

	// RVA: 0x2339268 Offset: 0x2335268 VA: 0x2339268 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2339270 Offset: 0x2335270 VA: 0x2339270 Slot: 21
	protected override EmotionPlayer.EmotionType get_EmotionType() { }

	// RVA: 0x2339278 Offset: 0x2335278 VA: 0x2339278 Slot: 11
	public override void Updata() { }

	// RVA: 0x233934C Offset: 0x233534C VA: 0x233934C Slot: 12
	public override int GetParam(int id) { }
}
