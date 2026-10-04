// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ArkSaberBuf : SkillBufferDataBase // TypeDefIndex: 3064
{
	// Fields
	private int count; // 0x20
	private int critical; // 0x24
	private int barrierValue; // 0x28
	private int atkMpRecovery; // 0x2C

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x231D04C Offset: 0x231904C VA: 0x231D04C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x231D054 Offset: 0x2319054 VA: 0x231D054 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x231D05C Offset: 0x231905C VA: 0x231D05C Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x231D068 Offset: 0x2319068 VA: 0x231D068
	public void .ctor(byte lv, int count) { }

	// RVA: 0x231D0CC Offset: 0x23190CC VA: 0x231D0CC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x231D124 Offset: 0x2319124 VA: 0x231D124 Slot: 11
	public override void Updata() { }

	// RVA: 0x231D180 Offset: 0x2319180 VA: 0x231D180
	public void BufferEnd() { }
}
