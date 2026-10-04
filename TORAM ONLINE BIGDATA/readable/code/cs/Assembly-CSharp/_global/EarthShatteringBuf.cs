// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EarthShatteringBuf : CountBufferBase // TypeDefIndex: 3135
{
	// Fields
	private int stable; // 0x28
	private int powerResist; // 0x2C
	private int element; // 0x30
	private int barrier; // 0x34
	private PlayerStatusBase playerStatus; // 0x38
	private bool otherPlayer; // 0x40
	private int bufCondition; // 0x44

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x232A540 Offset: 0x2326540 VA: 0x232A540 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232A548 Offset: 0x2326548 VA: 0x232A548 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232A550 Offset: 0x2326550 VA: 0x232A550 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232A55C Offset: 0x232655C VA: 0x232A55C Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x232A568 Offset: 0x2326568 VA: 0x232A568
	public void .ctor(byte lv, int stack, PlayerStatusBase status) { }

	// RVA: 0x232A738 Offset: 0x2326738 VA: 0x232A738
	public void .ctor(int condition) { }

	// RVA: 0x232A77C Offset: 0x232677C VA: 0x232A77C Slot: 11
	public override void Updata() { }

	// RVA: 0x232A780 Offset: 0x2326780 VA: 0x232A780 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232A7E0 Offset: 0x23267E0 VA: 0x232A7E0 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }
}
