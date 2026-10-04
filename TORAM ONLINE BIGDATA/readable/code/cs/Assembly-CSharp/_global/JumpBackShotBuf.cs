// Assembly: Assembly-CSharp.dll
// Namespace: 
public class JumpBackShotBuf : SkillBufferDataBase // TypeDefIndex: 3211
{
	// Fields
	private Dictionary<MobActionManagerBase, int> counter; // 0x20
	private readonly int max; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x23362D0 Offset: 0x23322D0 VA: 0x23362D0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23362D8 Offset: 0x23322D8 VA: 0x23362D8 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x23362F0 Offset: 0x23322F0 VA: 0x23362F0
	public void .ctor(byte lv) { }

	// RVA: 0x23363FC Offset: 0x23323FC VA: 0x23363FC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2336404 Offset: 0x2332404 VA: 0x2336404 Slot: 11
	public override void Updata() { }

	// RVA: 0x233686C Offset: 0x233286C VA: 0x233686C
	public bool Resister(MobActionManagerBase mobAction) { }

	// RVA: 0x2336904 Offset: 0x2332904 VA: 0x2336904
	public void Next(MobActionManagerBase mobAction) { }

	// RVA: 0x23369D0 Offset: 0x23329D0 VA: 0x23369D0
	public int GetCount(MobActionManagerBase mobAction) { }

	// RVA: 0x2336A48 Offset: 0x2332A48 VA: 0x2336A48
	public void ReMark(MobActionManagerBase mobAction) { }
}
