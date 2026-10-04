// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PhantomSongBuf : SongBufferBase // TypeDefIndex: 3268
{
	// Fields
	private const int MaxStack = 9;
	private readonly float intervalTime; // 0x5C
	private int stack; // 0x60
	private float intervalTimer; // 0x64

	// Properties
	public override SkillId SkillId { get; }
	protected override EmotionPlayer.EmotionType EmotionType { get; }

	// Methods

	// RVA: 0x23413DC Offset: 0x233D3DC VA: 0x23413DC
	public static PhantomSongBuf CreateSelfBuf(byte lv, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId, byte sensoryCount) { }

	// RVA: 0x23414D4 Offset: 0x233D4D4 VA: 0x23414D4
	public static PhantomSongBuf CreateOtherBuf(byte lv, int archetypeId, byte skillLocalId, bool isSensory) { }

	// RVA: 0x234149C Offset: 0x233D49C VA: 0x234149C
	private void .ctor(byte lv, bool self, PlayerActionManagerBase actorAction, int archetypeId, byte skillLocalId) { }

	// RVA: 0x2341738 Offset: 0x233D738 VA: 0x2341738 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2341740 Offset: 0x233D740 VA: 0x2341740 Slot: 21
	protected override EmotionPlayer.EmotionType get_EmotionType() { }

	// RVA: 0x2341748 Offset: 0x233D748 VA: 0x2341748 Slot: 11
	public override void Updata() { }

	// RVA: 0x234188C Offset: 0x233D88C VA: 0x234188C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23418AC Offset: 0x233D8AC VA: 0x23418AC
	public void UseStack(int useStack) { }

	// RVA: 0x2341870 Offset: 0x233D870 VA: 0x2341870
	private void Stack() { }

	// RVA: 0x23418D8 Offset: 0x233D8D8 VA: 0x23418D8 Slot: 26
	protected override void OnValid() { }

	// RVA: 0x23418DC Offset: 0x233D8DC VA: 0x23418DC Slot: 27
	protected override void OnInvalid() { }
}
