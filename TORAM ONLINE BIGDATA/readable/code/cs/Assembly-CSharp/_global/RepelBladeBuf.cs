// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RepelBladeBuf : SkillBufferDataBase // TypeDefIndex: 3285
{
	// Fields
	[CompilerGenerated]
	private bool <IsHolding>k__BackingField; // 0x1D
	[CompilerGenerated]
	private bool <IsReelSuccess>k__BackingField; // 0x1E
	private int hitRate; // 0x20
	private int hpHealRate; // 0x24

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public bool IsHolding { get; set; }
	public bool IsReelSuccess { get; set; }

	// Methods

	// RVA: 0x2342F10 Offset: 0x233EF10 VA: 0x2342F10 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2342F18 Offset: 0x233EF18 VA: 0x2342F18 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x2342F30 Offset: 0x233EF30 VA: 0x2342F30
	public bool get_IsHolding() { }

	[CompilerGenerated]
	// RVA: 0x2342F38 Offset: 0x233EF38 VA: 0x2342F38
	private void set_IsHolding(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2342F44 Offset: 0x233EF44 VA: 0x2342F44
	public bool get_IsReelSuccess() { }

	[CompilerGenerated]
	// RVA: 0x2342F4C Offset: 0x233EF4C VA: 0x2342F4C
	private void set_IsReelSuccess(bool value) { }

	// RVA: 0x2342F58 Offset: 0x233EF58 VA: 0x2342F58
	public void .ctor(byte lv, int eqAtk) { }

	// RVA: 0x2342FD4 Offset: 0x233EFD4 VA: 0x2342FD4 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x234300C Offset: 0x233F00C VA: 0x234300C Slot: 11
	public override void Updata() { }

	// RVA: 0x2343010 Offset: 0x233F010 VA: 0x2343010
	public void Parry(bool succsess) { }
}
