// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WarCryBuf : SkillBufferDataBase // TypeDefIndex: 3344
{
	// Fields
	private byte equip; // 0x1D
	private bool isViewSelfIcon; // 0x1E

	// Properties
	public override SkillId SkillId { get; }
	public override bool IsViewSelfIcon { get; }

	// Methods

	// RVA: 0x2349798 Offset: 0x2345798 VA: 0x2349798 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23497A0 Offset: 0x23457A0 VA: 0x23497A0 Slot: 5
	public override bool get_IsViewSelfIcon() { }

	// RVA: 0x23497A8 Offset: 0x23457A8 VA: 0x23497A8
	public void .ctor(byte lv, byte val) { }

	// RVA: 0x2349820 Offset: 0x2345820 VA: 0x2349820 Slot: 11
	public override void Updata() { }

	// RVA: 0x2349868 Offset: 0x2345868 VA: 0x2349868 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x234989C Offset: 0x234589C VA: 0x234989C
	public void SetViewSelfIcon(bool flag) { }
}
