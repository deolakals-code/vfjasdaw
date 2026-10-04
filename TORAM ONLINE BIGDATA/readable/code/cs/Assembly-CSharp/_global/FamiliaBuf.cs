// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FamiliaBuf : SkillBufferDataBase // TypeDefIndex: 3162
{
	// Fields
	private readonly PlayerStatusBase status; // 0x20
	private int maxMp; // 0x28
	private int matkUpRate; // 0x2C
	private int magicPursuitAttackRate; // 0x30

	// Properties
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x232DDC0 Offset: 0x2329DC0 VA: 0x232DDC0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232DDC8 Offset: 0x2329DC8 VA: 0x232DDC8
	public void .ctor(byte lv, PlayerStatusBase status) { }

	// RVA: 0x232DEA8 Offset: 0x2329EA8 VA: 0x232DEA8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232DFBC Offset: 0x2329FBC VA: 0x232DFBC Slot: 11
	public override void Updata() { }

	// RVA: 0x232E018 Offset: 0x232A018 VA: 0x232E018
	public void BufferEnd() { }
}
