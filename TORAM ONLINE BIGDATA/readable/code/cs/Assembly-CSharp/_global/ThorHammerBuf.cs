// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ThorHammerBuf : SkillBufferDataBase // TypeDefIndex: 3335
{
	// Fields
	private PlayerStatusBase status; // 0x20

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x2348244 Offset: 0x2344244 VA: 0x2348244 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x234824C Offset: 0x234424C VA: 0x234824C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2348254 Offset: 0x2344254 VA: 0x2348254 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x2348260 Offset: 0x2344260 VA: 0x2348260
	public void .ctor(byte lv, PlayerStatusBase playerStatus) { }

	// RVA: 0x23482C4 Offset: 0x23442C4 VA: 0x23482C4 Slot: 11
	public override void Updata() { }

	// RVA: 0x2348300 Offset: 0x2344300 VA: 0x2348300 Slot: 12
	public override int GetParam(int id) { }
}
