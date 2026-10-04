// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipPhysicalBarrierBuf : EquipSkillBufferBase // TypeDefIndex: 3151
{
	// Fields
	[CompilerGenerated]
	private float <Timer>k__BackingField; // 0x24
	protected readonly float coolTime; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override bool IsDataStack { get; }
	public float Timer { get; set; }

	// Methods

	// RVA: 0x232C758 Offset: 0x2328758 VA: 0x232C758 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232C760 Offset: 0x2328760 VA: 0x232C760 Slot: 21
	public override bool get_IsDataStack() { }

	[CompilerGenerated]
	// RVA: 0x232C768 Offset: 0x2328768 VA: 0x232C768
	public float get_Timer() { }

	[CompilerGenerated]
	// RVA: 0x232C770 Offset: 0x2328770 VA: 0x232C770
	private void set_Timer(float value) { }

	// RVA: 0x232C778 Offset: 0x2328778 VA: 0x232C778
	public void .ctor(int value) { }

	// RVA: 0x232C7B0 Offset: 0x23287B0 VA: 0x232C7B0 Slot: 11
	public override void Updata() { }

	// RVA: 0x232C7F4 Offset: 0x23287F4 VA: 0x232C7F4 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232C80C Offset: 0x232880C VA: 0x232C80C Slot: 23
	public override int Calc(int value, PlayerActionManagerBase playerAct, MobActionManagerBase mobAct) { }

	// RVA: 0x232CA4C Offset: 0x2328A4C VA: 0x232CA4C Slot: 24
	public override void UpdateBufData(SkillBufferDataBase buf) { }

	// RVA: 0x232CAD0 Offset: 0x2328AD0 VA: 0x232CAD0 Slot: 26
	public override bool CheckTakeOver(PlayerStatusBase playerStatus) { }

	// RVA: 0x232C9A0 Offset: 0x23289A0 VA: 0x232C9A0
	public int GetBarrierValue(PlayerStatusBase status) { }
}
