// Assembly: Assembly-CSharp.dll
// Namespace: 
public class IllusionarySceneBuf : SkillBufferDataBase // TypeDefIndex: 3203
{
	// Fields
	private int damageCutValue; // 0x20
	private bool parrySuccess; // 0x24
	private bool isSuperArmor; // 0x25

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x23351AC Offset: 0x23311AC VA: 0x23351AC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23351B4 Offset: 0x23311B4 VA: 0x23351B4 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x23351BC Offset: 0x23311BC VA: 0x23351BC
	public void .ctor(byte lv) { }

	// RVA: 0x23351FC Offset: 0x23311FC VA: 0x23351FC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233521C Offset: 0x233121C VA: 0x233521C Slot: 11
	public override void Updata() { }

	// RVA: 0x2335220 Offset: 0x2331220 VA: 0x2335220
	public void ParrySuccess() { }

	// RVA: 0x233522C Offset: 0x233122C VA: 0x233522C
	public bool CheckParry() { }

	// RVA: 0x2335234 Offset: 0x2331234 VA: 0x2335234
	public void EndSuperArmor() { }

	// RVA: 0x233523C Offset: 0x233123C VA: 0x233523C
	public bool CheckSuperArmor() { }
}
