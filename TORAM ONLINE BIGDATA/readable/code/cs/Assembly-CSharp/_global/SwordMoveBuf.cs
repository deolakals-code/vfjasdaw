// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SwordMoveBuf : SkillBufferDataBase // TypeDefIndex: 3332
{
	// Fields
	private bool damageInvalid; // 0x1D

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2347EEC Offset: 0x2343EEC VA: 0x2347EEC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2347EF4 Offset: 0x2343EF4 VA: 0x2347EF4 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2347EFC Offset: 0x2343EFC VA: 0x2347EFC
	public void .ctor(bool damageInvalid) { }

	// RVA: 0x2347F3C Offset: 0x2343F3C VA: 0x2347F3C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2347F5C Offset: 0x2343F5C VA: 0x2347F5C Slot: 11
	public override void Updata() { }

	// RVA: 0x2347F60 Offset: 0x2343F60 VA: 0x2347F60
	public bool CheckDamageInvalid() { }

	// RVA: 0x2347F68 Offset: 0x2343F68 VA: 0x2347F68
	public void DamageInvalid() { }

	// RVA: 0x2347F70 Offset: 0x2343F70 VA: 0x2347F70
	public void EndSwordMove() { }
}
