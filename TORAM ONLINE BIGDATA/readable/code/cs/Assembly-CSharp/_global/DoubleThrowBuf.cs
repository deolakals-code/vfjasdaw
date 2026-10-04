// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DoubleThrowBuf : SkillBufferDataBase // TypeDefIndex: 3128
{
	// Fields
	[CompilerGenerated]
	private bool <CoolTime>k__BackingField; // 0x1D

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public bool CoolTime { get; set; }

	// Methods

	// RVA: 0x2329880 Offset: 0x2325880 VA: 0x2329880 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2329888 Offset: 0x2325888 VA: 0x2329888 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x23298A0 Offset: 0x23258A0 VA: 0x23298A0
	public bool get_CoolTime() { }

	[CompilerGenerated]
	// RVA: 0x23298A8 Offset: 0x23258A8 VA: 0x23298A8
	private void set_CoolTime(bool value) { }

	// RVA: 0x23298B4 Offset: 0x23258B4 VA: 0x23298B4
	public void .ctor(byte lv, bool coolTime) { }

	// RVA: 0x2329904 Offset: 0x2325904 VA: 0x2329904 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232990C Offset: 0x232590C VA: 0x232990C Slot: 11
	public override void Updata() { }

	// RVA: 0x2329960 Offset: 0x2325960 VA: 0x2329960
	public void ReductionCoolTime(float time) { }
}
