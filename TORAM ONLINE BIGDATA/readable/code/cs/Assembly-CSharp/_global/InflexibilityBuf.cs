// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InflexibilityBuf : CountBufferBase // TypeDefIndex: 3208
{
	// Fields
	private int interval; // 0x28
	private readonly int cooldownInterval; // 0x2C
	private int hit; // 0x30
	private int eqAtk; // 0x34
	private int firstAttackRate; // 0x38
	private int motionSpeed; // 0x3C
	private int baseEqAtk; // 0x40
	private bool isCooldown; // 0x44

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x2335DDC Offset: 0x2331DDC VA: 0x2335DDC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2335DE4 Offset: 0x2331DE4 VA: 0x2335DE4 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2335DFC Offset: 0x2331DFC VA: 0x2335DFC Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2335E04 Offset: 0x2331E04 VA: 0x2335E04
	public void .ctor(byte lv, bool isGemCart) { }

	// RVA: 0x2335E58 Offset: 0x2331E58 VA: 0x2335E58 Slot: 11
	public override void Updata() { }

	// RVA: 0x2335F0C Offset: 0x2331F0C VA: 0x2335F0C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2335F70 Offset: 0x2331F70 VA: 0x2335F70 Slot: 25
	public override void Prev() { }

	// RVA: 0x233609C Offset: 0x233209C VA: 0x233609C Slot: 23
	public override void Next() { }

	// RVA: 0x23360B8 Offset: 0x23320B8 VA: 0x23360B8 Slot: 24
	public override void NextSkip(int count) { }

	// RVA: 0x23360D4 Offset: 0x23320D4 VA: 0x23360D4 Slot: 26
	public override void PrevSkip(int count) { }

	// RVA: 0x2336178 Offset: 0x2332178 VA: 0x2336178
	public void StartCooldown(int newCount) { }

	// RVA: 0x233619C Offset: 0x233219C VA: 0x233619C
	public void EndCooldown(bool isGemCart) { }

	// RVA: 0x23361C8 Offset: 0x23321C8 VA: 0x23361C8
	public bool CheckSwordMoveBuffer() { }

	// RVA: 0x23361D8 Offset: 0x23321D8 VA: 0x23361D8
	public bool CheckHeavenlyStarPowerUp() { }

	// RVA: 0x23361E8 Offset: 0x23321E8 VA: 0x23361E8
	public bool CheckMpHalving(PlayerAttackBase skill) { }

	// RVA: 0x2336234 Offset: 0x2332234 VA: 0x2336234
	public bool CheckRefineBonus() { }

	// RVA: 0x2336244 Offset: 0x2332244 VA: 0x2336244
	public bool CheckRemove() { }

	// RVA: 0x2335F8C Offset: 0x2331F8C VA: 0x2335F8C
	private void UpdateBufferEffect() { }
}
