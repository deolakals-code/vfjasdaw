// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TakeQigongBuf : CountBufferBase // TypeDefIndex: 3333
{
	// Fields
	private int takeQigongNum; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public int TakeQigongNum { get; set; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2347F78 Offset: 0x2343F78 VA: 0x2347F78 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2347F80 Offset: 0x2343F80 VA: 0x2347F80 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2347F88 Offset: 0x2343F88 VA: 0x2347F88
	public int get_TakeQigongNum() { }

	// RVA: 0x2347F90 Offset: 0x2343F90 VA: 0x2347F90
	public void set_TakeQigongNum(int value) { }

	// RVA: 0x2347FE0 Offset: 0x2343FE0 VA: 0x2347FE0 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2347FF8 Offset: 0x2343FF8 VA: 0x2347FF8
	public void .ctor(byte lv, int max) { }

	// RVA: 0x2348020 Offset: 0x2344020 VA: 0x2348020 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2348058 Offset: 0x2344058 VA: 0x2348058 Slot: 11
	public override void Updata() { }

	// RVA: 0x2347FB8 Offset: 0x2343FB8 VA: 0x2347FB8
	private void UpdateQigongNum() { }

	// RVA: 0x23480A4 Offset: 0x23440A4 VA: 0x23480A4
	public int GetUseQigongNum() { }
}
