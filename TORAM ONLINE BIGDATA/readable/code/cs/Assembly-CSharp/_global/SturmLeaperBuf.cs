// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SturmLeaperBuf : NextAttackBufferBase // TypeDefIndex: 3328
{
	// Fields
	private int shortRange; // 0x2C
	private int longRange; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2347AA8 Offset: 0x2343AA8 VA: 0x2347AA8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2347AB0 Offset: 0x2343AB0 VA: 0x2347AB0 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2347AB8 Offset: 0x2343AB8 VA: 0x2347AB8 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2347AC0 Offset: 0x2343AC0 VA: 0x2347AC0
	public void .ctor(byte lv, float rate, bool OrbitReaper) { }

	// RVA: 0x2347B4C Offset: 0x2343B4C VA: 0x2347B4C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2347B7C Offset: 0x2343B7C VA: 0x2347B7C Slot: 11
	public override void Updata() { }
}
