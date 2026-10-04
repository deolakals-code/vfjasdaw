// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GladiateBuf : CountBufferBase // TypeDefIndex: 3177
{
	// Fields
	private readonly int damageReduction; // 0x28
	private readonly PlayerActionManagerBase playerAction; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x232FCD0 Offset: 0x232BCD0 VA: 0x232FCD0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232FCD8 Offset: 0x232BCD8 VA: 0x232FCD8 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232FCE0 Offset: 0x232BCE0 VA: 0x232FCE0 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232FCF8 Offset: 0x232BCF8 VA: 0x232FCF8
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x232FE10 Offset: 0x232BE10 VA: 0x232FE10 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232FE30 Offset: 0x232BE30 VA: 0x232FE30 Slot: 11
	public override void Updata() { }

	// RVA: 0x2330040 Offset: 0x232C040 VA: 0x2330040 Slot: 13
	public override void OnDamage(PlayerActionManagerBase playerAction) { }
}
