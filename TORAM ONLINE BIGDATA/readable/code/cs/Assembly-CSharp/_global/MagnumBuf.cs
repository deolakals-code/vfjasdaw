// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagnumBuf : CountBufferBase // TypeDefIndex: 3240
{
	// Fields
	private int hitRate; // 0x28
	private bool isInterval; // 0x2C
	private float intervalTimer; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x233BBAC Offset: 0x2337BAC VA: 0x233BBAC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233BBB4 Offset: 0x2337BB4 VA: 0x233BBB4 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x233BBBC Offset: 0x2337BBC VA: 0x233BBBC Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x233BBD4 Offset: 0x2337BD4 VA: 0x233BBD4
	public void .ctor(byte lv, int count) { }

	// RVA: 0x233BC18 Offset: 0x2337C18 VA: 0x233BC18 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233BC4C Offset: 0x2337C4C VA: 0x233BC4C Slot: 11
	public override void Updata() { }

	// RVA: 0x233BCB0 Offset: 0x2337CB0 VA: 0x233BCB0
	public void ActiveMagnumCount(byte lv) { }

	// RVA: 0x233BCD0 Offset: 0x2337CD0 VA: 0x233BCD0
	public void InactiveMagnumCount() { }

	// RVA: 0x233BCE8 Offset: 0x2337CE8 VA: 0x233BCE8
	public void SetSkillParam(byte lv, PlayerStatusBase status) { }
}
