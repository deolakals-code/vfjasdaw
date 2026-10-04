// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ResonanceBuf : SkillBufferDataBase // TypeDefIndex: 3287
{
	// Fields
	private int atk; // 0x20
	private int matk; // 0x24
	private int aspd; // 0x28
	private int cspd; // 0x2C
	private int hit; // 0x30
	private int critical; // 0x34

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2343020 Offset: 0x233F020 VA: 0x2343020 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2343028 Offset: 0x233F028 VA: 0x2343028 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2343030 Offset: 0x233F030 VA: 0x2343030
	public void .ctor(byte lv, int type, int refine, float resist) { }

	// RVA: 0x2343154 Offset: 0x233F154 VA: 0x2343154 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23431CC Offset: 0x233F1CC VA: 0x23431CC Slot: 11
	public override void Updata() { }
}
