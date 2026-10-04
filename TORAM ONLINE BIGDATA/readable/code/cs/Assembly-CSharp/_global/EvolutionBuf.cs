// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EvolutionBuf : SkillBufferDataBase // TypeDefIndex: 3158
{
	// Fields
	private int flee; // 0x20
	private int fleeRate; // 0x24
	private bool isViewSelfIcon; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override bool IsViewSelfIcon { get; }

	// Methods

	// RVA: 0x232D7D4 Offset: 0x23297D4 VA: 0x232D7D4 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232D7DC Offset: 0x23297DC VA: 0x232D7DC Slot: 5
	public override bool get_IsViewSelfIcon() { }

	// RVA: 0x232D7E4 Offset: 0x23297E4 VA: 0x232D7E4
	public void .ctor(byte lv, bool isSelf, int itemType) { }

	// RVA: 0x232D858 Offset: 0x2329858 VA: 0x232D858 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232D888 Offset: 0x2329888 VA: 0x232D888 Slot: 11
	public override void Updata() { }

	// RVA: 0x232D8DC Offset: 0x23298DC VA: 0x232D8DC
	public void SetViewSelfIcon(bool flag) { }
}
