// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ThieshankaiBuf : CountBufferBase // TypeDefIndex: 3334
{
	// Fields
	private const int MAX_SKILL_RATE = 500;
	private int triggerRate; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x23480B8 Offset: 0x23440B8 VA: 0x23480B8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23480C0 Offset: 0x23440C0 VA: 0x23480C0 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23480C8 Offset: 0x23440C8 VA: 0x23480C8 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x23480E0 Offset: 0x23440E0 VA: 0x23480E0
	public void .ctor(byte lv, bool self, float second, bool isMainKnuckle) { }

	// RVA: 0x23481A8 Offset: 0x23441A8 VA: 0x23481A8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23481FC Offset: 0x23441FC VA: 0x23481FC Slot: 11
	public override void Updata() { }
}
