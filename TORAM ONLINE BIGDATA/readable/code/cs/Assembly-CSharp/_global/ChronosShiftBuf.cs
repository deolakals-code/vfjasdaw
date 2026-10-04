// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChronosShiftBuf : CountBufferBase // TypeDefIndex: 3098
{
	// Fields
	[CompilerGenerated]
	private bool <IsCoolDown>k__BackingField; // 0x28
	private SkillActionBase saveSkill; // 0x30
	private CountBufferBase.CountType viewType; // 0x38

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }
	public bool IsCoolDown { get; set; }

	// Methods

	// RVA: 0x2322304 Offset: 0x231E304 VA: 0x2322304 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232230C Offset: 0x231E30C VA: 0x232230C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2322314 Offset: 0x231E314 VA: 0x2322314 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x232231C Offset: 0x231E31C VA: 0x232231C
	public bool get_IsCoolDown() { }

	[CompilerGenerated]
	// RVA: 0x2322324 Offset: 0x231E324 VA: 0x2322324
	private void set_IsCoolDown(bool value) { }

	// RVA: 0x2322330 Offset: 0x231E330 VA: 0x2322330
	public void .ctor(byte lv) { }

	// RVA: 0x2322364 Offset: 0x231E364 VA: 0x2322364 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232236C Offset: 0x231E36C VA: 0x232236C Slot: 11
	public override void Updata() { }

	// RVA: 0x23223BC Offset: 0x231E3BC VA: 0x23223BC
	public void SaveMagicSkill(SkillActionBase skill) { }

	// RVA: 0x232241C Offset: 0x231E41C VA: 0x232241C
	public bool TryGetSaveMagicSkill(out SkillActionBase saveSkill) { }

	// RVA: 0x232246C Offset: 0x231E46C VA: 0x232246C
	public void StartCoolDown() { }

	// RVA: 0x2322494 Offset: 0x231E494 VA: 0x2322494
	public SkillTargetType GetLastUsedSkillTargetType() { }
}
