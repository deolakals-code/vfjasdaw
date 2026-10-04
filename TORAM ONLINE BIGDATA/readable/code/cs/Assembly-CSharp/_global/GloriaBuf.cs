// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GloriaBuf : SkillBufferDataBase // TypeDefIndex: 3180
{
	// Fields
	private int defUpRate; // 0x20
	private int guardUp; // 0x24
	private bool isViewSelfIcon; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override bool IsViewSelfIcon { get; }

	// Methods

	// RVA: 0x2330800 Offset: 0x232C800 VA: 0x2330800 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2330808 Offset: 0x232C808 VA: 0x2330808 Slot: 5
	public override bool get_IsViewSelfIcon() { }

	// RVA: 0x2330810 Offset: 0x232C810 VA: 0x2330810
	public void .ctor(byte lv, int guard) { }

	// RVA: 0x2330880 Offset: 0x232C880 VA: 0x2330880 Slot: 11
	public override void Updata() { }

	// RVA: 0x23308D4 Offset: 0x232C8D4 VA: 0x23308D4 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233090C Offset: 0x232C90C VA: 0x233090C
	public void SetViewSelfIcon(bool flag) { }
}
