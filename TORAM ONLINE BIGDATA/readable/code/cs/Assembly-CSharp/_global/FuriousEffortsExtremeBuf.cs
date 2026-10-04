// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FuriousEffortsExtremeBuf : CountBufferBase // TypeDefIndex: 3174
{
	// Fields
	private int lastDamageRate; // 0x28

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x232F8A8 Offset: 0x232B8A8 VA: 0x232F8A8 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232F8B0 Offset: 0x232B8B0 VA: 0x232F8B0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232F8B8 Offset: 0x232B8B8 VA: 0x232F8B8 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232F8D0 Offset: 0x232B8D0 VA: 0x232F8D0
	public void .ctor(byte lv) { }

	// RVA: 0x232F920 Offset: 0x232B920 VA: 0x232F920 Slot: 11
	public override void Updata() { }

	// RVA: 0x232F924 Offset: 0x232B924 VA: 0x232F924 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232F944 Offset: 0x232B944 VA: 0x232F944
	public int CalcLastDamageRate() { }
}
