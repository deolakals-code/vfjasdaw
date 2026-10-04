// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RapidChargeBuf : SkillBufferDataBase // TypeDefIndex: 3280
{
	// Fields
	private int matk; // 0x20
	private int magicResistBreaker; // 0x24

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x234268C Offset: 0x233E68C VA: 0x234268C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2342694 Offset: 0x233E694 VA: 0x2342694 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x234269C Offset: 0x233E69C VA: 0x234269C
	public void .ctor(byte lv, int heal, PlayerStatusBase status) { }

	// RVA: 0x23427E4 Offset: 0x233E7E4 VA: 0x23427E4 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x234280C Offset: 0x233E80C VA: 0x234280C Slot: 11
	public override void Updata() { }
}
