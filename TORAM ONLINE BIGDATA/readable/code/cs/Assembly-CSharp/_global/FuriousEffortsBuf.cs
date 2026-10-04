// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FuriousEffortsBuf : CountBufferBase // TypeDefIndex: 3173
{
	// Fields
	private int normalAttackDamageUpRate; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override int BufEffectTakeId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x232F58C Offset: 0x232B58C VA: 0x232F58C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232F594 Offset: 0x232B594 VA: 0x232F594 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x232F5A0 Offset: 0x232B5A0 VA: 0x232F5A0 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232F5A8 Offset: 0x232B5A8 VA: 0x232F5A8 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232F5C0 Offset: 0x232B5C0 VA: 0x232F5C0
	public void .ctor(byte lv, int useNum, PlayerStatusBase status) { }

	// RVA: 0x232F6AC Offset: 0x232B6AC VA: 0x232F6AC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232F740 Offset: 0x232B740 VA: 0x232F740 Slot: 11
	public override void Updata() { }

	// RVA: 0x232F794 Offset: 0x232B794 VA: 0x232F794 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }
}
