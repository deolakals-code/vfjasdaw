// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ForceArrowBuf : CountBufferBase // TypeDefIndex: 3170
{
	// Fields
	private int eqAtkRate; // 0x28
	private PlayerStatusBase playerStatus; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x232F0CC Offset: 0x232B0CC VA: 0x232F0CC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232F0D4 Offset: 0x232B0D4 VA: 0x232F0D4 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232F0DC Offset: 0x232B0DC VA: 0x232F0DC Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232F0F4 Offset: 0x232B0F4 VA: 0x232F0F4
	public void .ctor(byte lv, int arrow, PlayerStatusBase status) { }

	// RVA: 0x232F1B0 Offset: 0x232B1B0 VA: 0x232F1B0 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232F49C Offset: 0x232B49C VA: 0x232F49C Slot: 11
	public override void Updata() { }
}
