// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MaintainingTheFrontBuf : SkillBufferDataBase // TypeDefIndex: 3242
{
	// Fields
	private int physicalBarrier; // 0x20
	private int magicBarrier; // 0x24
	private int hateRate; // 0x28
	private int noTargetMemberNum; // 0x2C
	private PlayerStatusBase playerStatus; // 0x30

	// Properties
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x233BDB4 Offset: 0x2337DB4 VA: 0x233BDB4 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233BDBC Offset: 0x2337DBC VA: 0x233BDBC
	public void .ctor(byte lv, int num, PlayerStatusBase status) { }

	// RVA: 0x233BE54 Offset: 0x2337E54 VA: 0x233BE54 Slot: 11
	public override void Updata() { }

	// RVA: 0x233C008 Offset: 0x2338008 VA: 0x233C008 Slot: 12
	public override int GetParam(int id) { }
}
