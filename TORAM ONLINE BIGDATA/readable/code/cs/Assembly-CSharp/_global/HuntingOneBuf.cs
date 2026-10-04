// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HuntingOneBuf : CountBufferBase // TypeDefIndex: 3200
{
	// Fields
	private int stack; // 0x28
	private List<SkillIdData> hitSkillList; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x2333DDC Offset: 0x232FDDC VA: 0x2333DDC
	public void .ctor(byte lv) { }

	// RVA: 0x2333E74 Offset: 0x232FE74 VA: 0x2333E74 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2333E7C Offset: 0x232FE7C VA: 0x2333E7C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2333E94 Offset: 0x232FE94 VA: 0x2333E94 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2333E9C Offset: 0x232FE9C VA: 0x2333E9C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2333EA4 Offset: 0x232FEA4 VA: 0x2333EA4 Slot: 11
	public override void Updata() { }

	// RVA: 0x2334030 Offset: 0x2330030 VA: 0x2334030
	public bool Stack(SkillIdData skillIdData) { }

	// RVA: 0x2334130 Offset: 0x2330130 VA: 0x2334130
	public void Clear() { }

	// RVA: 0x2333F00 Offset: 0x232FF00 VA: 0x2333F00
	public void BufferEnd() { }
}
