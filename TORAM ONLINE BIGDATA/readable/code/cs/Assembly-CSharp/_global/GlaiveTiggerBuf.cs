// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GlaiveTiggerBuf : CountBufferBase // TypeDefIndex: 3179
{
	// Fields
	private SkillActionManager skillActionManager; // 0x28
	private PlayerStatusBase playerStatus; // 0x30
	private CountBufferBase.CountType bufferType; // 0x38

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x2330094 Offset: 0x232C094 VA: 0x2330094 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233009C Offset: 0x232C09C VA: 0x233009C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x23300A4 Offset: 0x232C0A4 VA: 0x23300A4 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23300AC Offset: 0x232C0AC VA: 0x23300AC
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2330224 Offset: 0x232C224 VA: 0x2330224 Slot: 11
	public override void Updata() { }

	// RVA: 0x2330228 Offset: 0x232C228 VA: 0x2330228 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2330470 Offset: 0x232C470 VA: 0x2330470
	public void SetCount(int count) { }

	// RVA: 0x2330544 Offset: 0x232C544 VA: 0x2330544 Slot: 25
	public override void Prev() { }

	// RVA: 0x2330574 Offset: 0x232C574 VA: 0x2330574 Slot: 26
	public override void PrevSkip(int count) { }

	// RVA: 0x23305A4 Offset: 0x232C5A4 VA: 0x23305A4
	public static void SetCountValue(PlayerActionManagerBase playerAction, int value) { }
}
