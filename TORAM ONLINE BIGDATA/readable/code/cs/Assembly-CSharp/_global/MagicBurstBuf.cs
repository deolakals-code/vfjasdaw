// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicBurstBuf : CountBufferBase // TypeDefIndex: 3233
{
	// Fields
	private const int MaxChargeValue = 8;
	private byte innerCount; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2339E08 Offset: 0x2335E08 VA: 0x2339E08 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2339E10 Offset: 0x2335E10 VA: 0x2339E10 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2339E18 Offset: 0x2335E18 VA: 0x2339E18 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2339E30 Offset: 0x2335E30 VA: 0x2339E30
	public void .ctor(byte lv) { }

	// RVA: 0x2339E40 Offset: 0x2335E40 VA: 0x2339E40 Slot: 11
	public override void Updata() { }

	// RVA: 0x2339E44 Offset: 0x2335E44 VA: 0x2339E44 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2339E6C Offset: 0x2335E6C VA: 0x2339E6C Slot: 23
	public override void Next() { }

	// RVA: 0x2339E84 Offset: 0x2335E84 VA: 0x2339E84 Slot: 24
	public override void NextSkip(int count) { }

	// RVA: 0x2339EA0 Offset: 0x2335EA0 VA: 0x2339EA0
	public void UpdateMaxValue(PlayerStatusBase status) { }

	// RVA: 0x2339F6C Offset: 0x2335F6C VA: 0x2339F6C
	public void UpdateMaxValue(int cspd, PlayerStatusBase status) { }
}
