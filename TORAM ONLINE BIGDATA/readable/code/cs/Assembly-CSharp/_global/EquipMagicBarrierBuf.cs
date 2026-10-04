// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipMagicBarrierBuf : EquipSkillBufferBase // TypeDefIndex: 3150
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

	// RVA: 0x232C31C Offset: 0x232831C VA: 0x232C31C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232C324 Offset: 0x2328324 VA: 0x232C324 Slot: 21
	public override bool get_IsDataStack() { }

	[CompilerGenerated]
	// RVA: 0x232C32C Offset: 0x232832C VA: 0x232C32C
	public float get_Timer() { }

	[CompilerGenerated]
	// RVA: 0x232C334 Offset: 0x2328334 VA: 0x232C334
	private void set_Timer(float value) { }

	// RVA: 0x232C33C Offset: 0x232833C VA: 0x232C33C
	public void .ctor(int value) { }

	// RVA: 0x232C384 Offset: 0x2328384 VA: 0x232C384 Slot: 11
	public override void Updata() { }

	// RVA: 0x232C3C8 Offset: 0x23283C8 VA: 0x232C3C8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232C3E0 Offset: 0x23283E0 VA: 0x232C3E0 Slot: 23
	public override int Calc(int value, PlayerActionManagerBase playerAct, MobActionManagerBase mobAct) { }

	// RVA: 0x232C620 Offset: 0x2328620 VA: 0x232C620 Slot: 24
	public override void UpdateBufData(SkillBufferDataBase buf) { }

	// RVA: 0x232C6A4 Offset: 0x23286A4 VA: 0x232C6A4 Slot: 26
	public override bool CheckTakeOver(PlayerStatusBase playerStatus) { }

	// RVA: 0x232C574 Offset: 0x2328574 VA: 0x232C574
	public int GetBarrierValue(PlayerStatusBase status) { }
}
