// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MizukazeBuf : CountBufferBase // TypeDefIndex: 3252
{
	// Fields
	private byte mononofuSkillTreeLv; // 0x28
	private int shortRangeDamageRate; // 0x2C
	private int criticalDamage; // 0x30
	private int hit; // 0x34

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x233E3F0 Offset: 0x233A3F0 VA: 0x233E3F0
	public void .ctor(byte lv) { }

	// RVA: 0x233E418 Offset: 0x233A418 VA: 0x233E418 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233E420 Offset: 0x233A420 VA: 0x233E420 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x233E438 Offset: 0x233A438 VA: 0x233E438 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x233E440 Offset: 0x233A440 VA: 0x233E440 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233E488 Offset: 0x233A488 VA: 0x233E488 Slot: 11
	public override void Updata() { }

	// RVA: 0x233E4DC Offset: 0x233A4DC VA: 0x233E4DC Slot: 23
	public override void Next() { }

	// RVA: 0x233E510 Offset: 0x233A510 VA: 0x233E510
	public void UpdateSkillTreeLevel(byte treeLevel) { }
}
