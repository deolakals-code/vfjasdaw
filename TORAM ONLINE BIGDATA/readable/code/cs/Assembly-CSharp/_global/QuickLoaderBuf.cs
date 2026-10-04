// Assembly: Assembly-CSharp.dll
// Namespace: 
public class QuickLoaderBuf : CountBufferBase // TypeDefIndex: 3276
{
	// Fields
	private readonly int motionSpeed; // 0x28
	private bool quickSpeed; // 0x2C

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x23422BC Offset: 0x233E2BC VA: 0x23422BC
	public void .ctor(byte lv, bool isBowgun) { }

	// RVA: 0x2342318 Offset: 0x233E318 VA: 0x2342318 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2342320 Offset: 0x233E320 VA: 0x2342320 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2342328 Offset: 0x233E328 VA: 0x2342328 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2342330 Offset: 0x233E330 VA: 0x2342330 Slot: 11
	public override void Updata() { }

	// RVA: 0x2342378 Offset: 0x233E378 VA: 0x2342378 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23423A4 Offset: 0x233E3A4 VA: 0x23423A4
	public void ValidQuickSpeed() { }

	// RVA: 0x23423B0 Offset: 0x233E3B0 VA: 0x23423B0
	public void InvalidQuickSpeed() { }
}
