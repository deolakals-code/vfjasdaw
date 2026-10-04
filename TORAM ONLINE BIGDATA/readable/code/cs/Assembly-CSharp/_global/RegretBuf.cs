// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RegretBuf : SkillBufferDataBase // TypeDefIndex: 3284
{
	// Fields
	private const int MAX_STACK = 10;
	private int stack; // 0x20
	private int atk; // 0x24
	private int matk; // 0x28
	private int physics; // 0x2C
	private int magic; // 0x30
	private int maxMp; // 0x34
	private int maxHp; // 0x38
	private int atkMpHeal; // 0x3C

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2342C88 Offset: 0x233EC88 VA: 0x2342C88 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2342C90 Offset: 0x233EC90 VA: 0x2342C90 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2342C98 Offset: 0x233EC98 VA: 0x2342C98
	public void .ctor(byte lv) { }

	// RVA: 0x2342DCC Offset: 0x233EDCC VA: 0x2342DCC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2342EA0 Offset: 0x233EEA0 VA: 0x2342EA0 Slot: 11
	public override void Updata() { }

	// RVA: 0x2342EE8 Offset: 0x233EEE8 VA: 0x2342EE8
	public void Stack(byte lv) { }

	// RVA: 0x2342CE4 Offset: 0x233ECE4 VA: 0x2342CE4
	private void calc(byte lv) { }
}
