// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StormAndUrgeBuf : CountBufferBase // TypeDefIndex: 3325
{
	// Fields
	private int moveSpeed; // 0x28
	private PlayerDataManager playerDataManager; // 0x30
	private const int bufferTakeId = 93004;

	// Properties
	public override SkillId SkillId { get; }
	public override int BufEffectTakeId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x23474E0 Offset: 0x23434E0 VA: 0x23474E0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23474E8 Offset: 0x23434E8 VA: 0x23474E8 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x23474F4 Offset: 0x23434F4 VA: 0x23474F4 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23474FC Offset: 0x23434FC VA: 0x23474FC Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2347514 Offset: 0x2343514 VA: 0x2347514
	public void .ctor(byte lv, int useNum) { }

	// RVA: 0x2347568 Offset: 0x2343568 VA: 0x2347568 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2347610 Offset: 0x2343610 VA: 0x2347610 Slot: 11
	public override void Updata() { }

	// RVA: 0x234785C Offset: 0x234385C VA: 0x234785C Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }
}
