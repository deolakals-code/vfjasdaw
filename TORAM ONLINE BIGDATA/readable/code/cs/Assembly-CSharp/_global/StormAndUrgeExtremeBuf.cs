// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StormAndUrgeExtremeBuf : NextAttackBufferBase // TypeDefIndex: 3326
{
	// Fields
	private int percent; // 0x2C
	private int powerResistBreaker; // 0x30
	private int avoidStackHeal; // 0x34

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2347974 Offset: 0x2343974 VA: 0x2347974 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x234797C Offset: 0x234397C VA: 0x234797C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2347984 Offset: 0x2343984 VA: 0x2347984 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x234799C Offset: 0x234399C VA: 0x234799C
	public void .ctor(byte lv) { }

	// RVA: 0x23479E8 Offset: 0x23439E8 VA: 0x23479E8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2347A28 Offset: 0x2343A28 VA: 0x2347A28 Slot: 11
	public override void Updata() { }
}
