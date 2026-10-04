// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KnightStanceBuf : CountBufferBase // TypeDefIndex: 3223
{
	// Fields
	private CountBufferBase.CountType countViewType; // 0x28
	private PlayerStatusBase status; // 0x30
	private int damageResist; // 0x38
	private int stack; // 0x3C
	private int maxHp; // 0x40
	private int hateRate; // 0x44

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2338B34 Offset: 0x2334B34 VA: 0x2338B34 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2338B3C Offset: 0x2334B3C VA: 0x2338B3C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2338B44 Offset: 0x2334B44 VA: 0x2338B44 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2338B5C Offset: 0x2334B5C VA: 0x2338B5C
	public void .ctor(byte lv, PlayerStatusBase status) { }

	// RVA: 0x2338CD8 Offset: 0x2334CD8 VA: 0x2338CD8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2338DAC Offset: 0x2334DAC VA: 0x2338DAC Slot: 11
	public override void Updata() { }

	// RVA: 0x2338FC4 Offset: 0x2334FC4 VA: 0x2338FC4
	public int GetFearResistValue(AbnormalType type, PlayerStatusBase status) { }

	// RVA: 0x2339054 Offset: 0x2335054 VA: 0x2339054
	public void SyncDamageStack(int serverStack) { }

	// RVA: 0x2338F54 Offset: 0x2334F54 VA: 0x2338F54
	private void CalcCount() { }
}
