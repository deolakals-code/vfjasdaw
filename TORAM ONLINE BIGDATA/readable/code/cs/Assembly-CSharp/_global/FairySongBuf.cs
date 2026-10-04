// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FairySongBuf : SongBufferBase // TypeDefIndex: 3161
{
	// Fields
	private int hit; // 0x5C
	private int hitRate; // 0x60
	private int flee; // 0x64
	private int fleeRate; // 0x68

	// Properties
	public override SkillId SkillId { get; }
	protected override EmotionPlayer.EmotionType EmotionType { get; }

	// Methods

	// RVA: 0x232DA68 Offset: 0x2329A68 VA: 0x232DA68
	public static FairySongBuf CreateSelfBuf(byte lv, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId, byte sensoryCount) { }

	// RVA: 0x232DB6C Offset: 0x2329B6C VA: 0x232DB6C
	public static FairySongBuf CreateOtherBuf(byte lv, int archetypeId, byte skillLocalId, bool isSensory) { }

	// RVA: 0x232DB28 Offset: 0x2329B28 VA: 0x232DB28
	private void .ctor(byte lv, bool self, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId) { }

	// RVA: 0x232DC2C Offset: 0x2329C2C VA: 0x232DC2C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232DC34 Offset: 0x2329C34 VA: 0x232DC34 Slot: 21
	protected override EmotionPlayer.EmotionType get_EmotionType() { }

	// RVA: 0x232DC3C Offset: 0x2329C3C VA: 0x232DC3C Slot: 11
	public override void Updata() { }

	// RVA: 0x232DD10 Offset: 0x2329D10 VA: 0x232DD10 Slot: 12
	public override int GetParam(int id) { }
}
