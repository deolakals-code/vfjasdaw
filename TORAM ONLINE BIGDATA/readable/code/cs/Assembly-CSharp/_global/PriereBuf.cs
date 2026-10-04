// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PriereBuf : SkillBufferDataBase // TypeDefIndex: 3271
{
	// Fields
	private int mAtkUpRate; // 0x20
	private bool isViewSelfIcon; // 0x24

	// Properties
	public override SkillId SkillId { get; }
	public override bool IsViewSelfIcon { get; }

	// Methods

	// RVA: 0x2341A58 Offset: 0x233DA58 VA: 0x2341A58 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2341A60 Offset: 0x233DA60 VA: 0x2341A60 Slot: 5
	public override bool get_IsViewSelfIcon() { }

	// RVA: 0x2341A68 Offset: 0x233DA68 VA: 0x2341A68
	public void .ctor(byte lv, PlayerStatusBase status) { }

	// RVA: 0x2341C14 Offset: 0x233DC14 VA: 0x2341C14
	public void .ctor(byte lv, float time, int val) { }

	// RVA: 0x2341C6C Offset: 0x233DC6C VA: 0x2341C6C Slot: 11
	public override void Updata() { }

	// RVA: 0x2341CB4 Offset: 0x233DCB4 VA: 0x2341CB4 Slot: 12
	public override int GetParam(int id) { }
}
