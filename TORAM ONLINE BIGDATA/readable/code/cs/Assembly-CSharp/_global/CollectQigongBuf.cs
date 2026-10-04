// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CollectQigongBuf : CountBufferBase // TypeDefIndex: 3102
{
	// Fields
	private const float DefaultBufferTime = 180;
	private float startTime; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2322ACC Offset: 0x231EACC VA: 0x2322ACC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2322AD4 Offset: 0x231EAD4 VA: 0x2322AD4 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2322ADC Offset: 0x231EADC VA: 0x2322ADC Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2322AE4 Offset: 0x231EAE4 VA: 0x2322AE4
	public void .ctor(byte lv, int takeNum) { }

	// RVA: 0x2322B30 Offset: 0x231EB30 VA: 0x2322B30 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2322BA8 Offset: 0x231EBA8 VA: 0x2322BA8 Slot: 11
	public override void Updata() { }

	// RVA: 0x2322C00 Offset: 0x231EC00 VA: 0x2322C00
	public void UpdateQigongNum(int nowNum) { }
}
