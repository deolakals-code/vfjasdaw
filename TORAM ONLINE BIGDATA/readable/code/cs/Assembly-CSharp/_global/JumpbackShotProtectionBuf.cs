// Assembly: Assembly-CSharp.dll
// Namespace: 
public class JumpbackShotProtectionBuf : SkillBufferDataBase // TypeDefIndex: 3212
{
	// Fields
	private bool damageCut; // 0x1D

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2336ADC Offset: 0x2332ADC VA: 0x2336ADC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2336AE4 Offset: 0x2332AE4 VA: 0x2336AE4 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2336AEC Offset: 0x2332AEC VA: 0x2336AEC
	public void .ctor(byte lv) { }

	// RVA: 0x2336B00 Offset: 0x2332B00 VA: 0x2336B00 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2336B08 Offset: 0x2332B08 VA: 0x2336B08 Slot: 11
	public override void Updata() { }

	// RVA: 0x2336B0C Offset: 0x2332B0C VA: 0x2336B0C
	public bool CheckDamageInvalid() { }

	// RVA: 0x2336B14 Offset: 0x2332B14 VA: 0x2336B14
	public void Damaged() { }
}
