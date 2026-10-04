// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlitzPikeBuf : CountBufferBase // TypeDefIndex: 3085
{
	// Fields
	private const int maxCount = 4;
	private const float interval = 1;
	private const int effectTakeId = 300327000;
	private readonly Vector3[] effectPosList; // 0x28
	private PlayerActionManagerBase playerAction; // 0x30
	private float intervalTimer; // 0x38
	private List<BlitzPikeBuf.EffectData> effectDataList; // 0x40
	private TakeController takeController; // 0x48
	private bool isFirstHit; // 0x50

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x231F018 Offset: 0x231B018 VA: 0x231F018 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x231F020 Offset: 0x231B020 VA: 0x231F020 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x231F028 Offset: 0x231B028 VA: 0x231F028 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x231F038 Offset: 0x231B038 VA: 0x231F038
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x231F208 Offset: 0x231B208 VA: 0x231F208
	public void UpdateParam() { }

	// RVA: 0x231F4B0 Offset: 0x231B4B0 VA: 0x231F4B0
	public void ClearEffect() { }

	// RVA: 0x231F648 Offset: 0x231B648 VA: 0x231F648 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x231F6AC Offset: 0x231B6AC VA: 0x231F6AC Slot: 11
	public override void Updata() { }

	// RVA: 0x231FECC Offset: 0x231BECC VA: 0x231FECC Slot: 25
	public override void Prev() { }

	// RVA: 0x2320050 Offset: 0x231C050 VA: 0x2320050
	private void TakeEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x231FA2C Offset: 0x231BA2C VA: 0x231FA2C
	private void EffectUpdate() { }

	// RVA: 0x2320348 Offset: 0x231C348 VA: 0x2320348 Slot: 17
	public override void OnLeave() { }

	[CompilerGenerated]
	// RVA: 0x232034C Offset: 0x231C34C VA: 0x232034C
	private bool <Updata>b__20_0(BlitzPikeBuf.EffectData x) { }

	[CompilerGenerated]
	// RVA: 0x2320374 Offset: 0x231C374 VA: 0x2320374
	private bool <Prev>b__21_0(BlitzPikeBuf.EffectData x) { }
}
