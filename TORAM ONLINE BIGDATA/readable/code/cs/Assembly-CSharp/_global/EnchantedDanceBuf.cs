// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnchantedDanceBuf : DancerBufferBase // TypeDefIndex: 3144
{
	// Fields
	private int stableRate; // 0x28
	private int variableValue; // 0x2C

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x232B3E4 Offset: 0x23273E4 VA: 0x232B3E4 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232B3EC Offset: 0x23273EC VA: 0x232B3EC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232B3F4 Offset: 0x23273F4 VA: 0x232B3F4
	public void .ctor(byte lv, bool self, float time, int danceLv) { }

	// RVA: 0x232B4A0 Offset: 0x23274A0 VA: 0x232B4A0 Slot: 11
	public override void Updata() { }

	// RVA: 0x232B4F4 Offset: 0x23274F4 VA: 0x232B4F4 Slot: 12
	public override int GetParam(int id) { }
}
