// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HighFamiliaBuf : SkillBufferDataBase // TypeDefIndex: 3194
{
	// Fields
	private readonly PlayerStatusBase status; // 0x20
	private int maxMp; // 0x28
	private int matkUpRate; // 0x2C
	private int magicPursuitAttackRate; // 0x30

	// Properties
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x23335F4 Offset: 0x232F5F4 VA: 0x23335F4 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23335FC Offset: 0x232F5FC VA: 0x23335FC
	public void .ctor(byte lv, PlayerStatusBase status) { }

	// RVA: 0x23336DC Offset: 0x232F6DC VA: 0x23336DC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23337F0 Offset: 0x232F7F0 VA: 0x23337F0 Slot: 11
	public override void Updata() { }

	// RVA: 0x233384C Offset: 0x232F84C VA: 0x233384C
	public void BufferEnd() { }
}
