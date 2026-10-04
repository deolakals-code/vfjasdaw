// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SongOfLifeBuf : SongBufferBase // TypeDefIndex: 3318
{
	// Fields
	private const float IntervalTime = 4;
	private int stack; // 0x5C
	private float intervalTimer; // 0x60
	private bool targeted; // 0x64

	// Properties
	public override SkillId SkillId { get; }
	protected override EmotionPlayer.EmotionType EmotionType { get; }

	// Methods

	// RVA: 0x2346C3C Offset: 0x2342C3C VA: 0x2346C3C
	public static SongOfLifeBuf CreateSelfBuf(byte lv, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId, byte sensoryCount) { }

	// RVA: 0x2346CF4 Offset: 0x2342CF4 VA: 0x2346CF4
	public static SongOfLifeBuf CreateOtherBuf(byte lv, int archetypeId, byte skillLocalId, bool isSensory) { }

	// RVA: 0x2346CE4 Offset: 0x2342CE4 VA: 0x2346CE4
	private void .ctor(byte lv, bool self, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId) { }

	// RVA: 0x2346DB0 Offset: 0x2342DB0 VA: 0x2346DB0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2346DB8 Offset: 0x2342DB8 VA: 0x2346DB8 Slot: 21
	protected override EmotionPlayer.EmotionType get_EmotionType() { }

	// RVA: 0x2346DC0 Offset: 0x2342DC0 VA: 0x2346DC0 Slot: 11
	public override void Updata() { }

	// RVA: 0x2346F08 Offset: 0x2342F08 VA: 0x2346F08 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2346F28 Offset: 0x2342F28 VA: 0x2346F28
	public bool Targeted() { }

	// RVA: 0x2346F44 Offset: 0x2342F44 VA: 0x2346F44
	public bool NotTargeted() { }

	// RVA: 0x2346F54 Offset: 0x2342F54 VA: 0x2346F54
	public int GetHealHp(int maxHp) { }

	// RVA: 0x2346EEC Offset: 0x2342EEC VA: 0x2346EEC
	private void Stack() { }

	// RVA: 0x2346F98 Offset: 0x2342F98 VA: 0x2346F98 Slot: 26
	protected override void OnValid() { }

	// RVA: 0x2346F9C Offset: 0x2342F9C VA: 0x2346F9C Slot: 27
	protected override void OnInvalid() { }
}
