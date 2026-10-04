// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FinishingTouchBuf : CountBufferBase // TypeDefIndex: 3165
{
	// Fields
	private CountBufferBase.CountType countType; // 0x28
	private int damageCut; // 0x2C
	private int firstAttackRate; // 0x30
	private int atkMpRecovery; // 0x34
	private int lastDamageRate; // 0x38
	private bool isActiveBuffer; // 0x3C

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x232E474 Offset: 0x232A474 VA: 0x232E474 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232E47C Offset: 0x232A47C VA: 0x232E47C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232E484 Offset: 0x232A484 VA: 0x232E484 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232E48C Offset: 0x232A48C VA: 0x232E48C
	public void .ctor(byte lv) { }

	// RVA: 0x232E4BC Offset: 0x232A4BC VA: 0x232E4BC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232E530 Offset: 0x232A530 VA: 0x232E530 Slot: 11
	public override void Updata() { }

	// RVA: 0x232E5AC Offset: 0x232A5AC VA: 0x232E5AC Slot: 23
	public override void Next() { }

	// RVA: 0x232E5D4 Offset: 0x232A5D4 VA: 0x232E5D4 Slot: 24
	public override void NextSkip(int count) { }

	// RVA: 0x232E5FC Offset: 0x232A5FC VA: 0x232E5FC
	public void ActiveFinishingTouch() { }

	// RVA: 0x232E630 Offset: 0x232A630 VA: 0x232E630
	public void ActiveTenjhoTengeMusouSword(PlayerStatusBase status) { }

	// RVA: 0x232E7D0 Offset: 0x232A7D0 VA: 0x232E7D0
	public void ActiveResetIchijhinnokaze() { }

	// RVA: 0x232E57C Offset: 0x232A57C VA: 0x232E57C
	private void OnEnd() { }
}
