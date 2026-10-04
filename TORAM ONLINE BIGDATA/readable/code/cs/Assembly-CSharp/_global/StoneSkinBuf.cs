// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StoneSkinBuf : CountBufferBase // TypeDefIndex: 3324
{
	// Fields
	private int barrier; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x2347314 Offset: 0x2343314 VA: 0x2347314 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x234731C Offset: 0x234331C VA: 0x234731C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2347324 Offset: 0x2343324 VA: 0x2347324 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x2347330 Offset: 0x2343330 VA: 0x2347330
	public void .ctor(byte lv, float time, int mVit) { }

	// RVA: 0x2347380 Offset: 0x2343380 VA: 0x2347380 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23473A0 Offset: 0x23433A0 VA: 0x23473A0 Slot: 11
	public override void Updata() { }

	// RVA: 0x23473E8 Offset: 0x23433E8 VA: 0x23473E8
	public int DamageCut(int damage) { }

	// RVA: 0x23474A8 Offset: 0x23434A8 VA: 0x23474A8
	public int CalcCutDamageValue(int damage) { }
}
