// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class TornadoLanceBuf : CountBufferBase // TypeDefIndex: 3337
{
	// Fields
	private float securityHit; // 0x28
	private float crtDamageUp; // 0x2C
	private float pursuitPercent; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public int CorrectHit { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x234840C Offset: 0x234440C VA: 0x234840C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2348414 Offset: 0x2344414 VA: 0x2348414 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x234841C Offset: 0x234441C VA: 0x234841C
	public int get_CorrectHit() { }

	// RVA: 0x2348448 Offset: 0x2344448 VA: 0x2348448 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2348460 Offset: 0x2344460 VA: 0x2348460
	public void .ctor(byte lv, int count) { }

	// RVA: 0x23484B8 Offset: 0x23444B8 VA: 0x23484B8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2348540 Offset: 0x2344540 VA: 0x2348540 Slot: 11
	public override void Updata() { }

	// RVA: 0x2348588 Offset: 0x2344588 VA: 0x2348588 Slot: 23
	public override void Next() { }

	// RVA: 0x23485A8 Offset: 0x23445A8 VA: 0x23485A8
	public void CheckHitMobAttack() { }

	// RVA: 0x23485C0 Offset: 0x23445C0 VA: 0x23485C0
	public static void NextStack(PlayerActionManagerBase playerAction, byte lv) { }
}
