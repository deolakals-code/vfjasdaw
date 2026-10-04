// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipRateBarrierBuf : EquipSkillBufferBase // TypeDefIndex: 3152
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

	// RVA: 0x232CB84 Offset: 0x2328B84 VA: 0x232CB84 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232CB8C Offset: 0x2328B8C VA: 0x232CB8C Slot: 21
	public override bool get_IsDataStack() { }

	[CompilerGenerated]
	// RVA: 0x232CB94 Offset: 0x2328B94 VA: 0x232CB94
	public float get_Timer() { }

	[CompilerGenerated]
	// RVA: 0x232CB9C Offset: 0x2328B9C VA: 0x232CB9C
	private void set_Timer(float value) { }

	// RVA: 0x232CBA4 Offset: 0x2328BA4 VA: 0x232CBA4
	public void .ctor(int value) { }

	// RVA: 0x232CBDC Offset: 0x2328BDC VA: 0x232CBDC Slot: 11
	public override void Updata() { }

	// RVA: 0x232CC20 Offset: 0x2328C20 VA: 0x232CC20 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232CC38 Offset: 0x2328C38 VA: 0x232CC38 Slot: 23
	public override int Calc(int value, PlayerActionManagerBase playerAct, MobActionManagerBase mobAct) { }

	// RVA: 0x232CE84 Offset: 0x2328E84 VA: 0x232CE84 Slot: 24
	public override void UpdateBufData(SkillBufferDataBase buf) { }

	// RVA: 0x232CF08 Offset: 0x2328F08 VA: 0x232CF08
	public int GetBarrierValue(PlayerStatusBase status) { }
}
