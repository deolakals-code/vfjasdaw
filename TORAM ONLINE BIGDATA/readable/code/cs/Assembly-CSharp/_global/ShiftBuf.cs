// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShiftBuf : CountBufferBase // TypeDefIndex: 3304
{
	// Fields
	[CompilerGenerated]
	private bool <EnableDistFade>k__BackingField; // 0x28
	private PlayerActionManagerBase actionManager; // 0x30

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public bool EnableDistFade { get; set; }

	// Methods

	// RVA: 0x2344DE8 Offset: 0x2340DE8 VA: 0x2344DE8 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2344DF0 Offset: 0x2340DF0 VA: 0x2344DF0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2344DF8 Offset: 0x2340DF8 VA: 0x2344DF8 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x2344E14 Offset: 0x2340E14 VA: 0x2344E14
	public void set_EnableDistFade(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2344E20 Offset: 0x2340E20 VA: 0x2344E20
	public bool get_EnableDistFade() { }

	// RVA: 0x2344E28 Offset: 0x2340E28 VA: 0x2344E28
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2344E60 Offset: 0x2340E60 VA: 0x2344E60 Slot: 11
	public override void Updata() { }

	// RVA: 0x2344E64 Offset: 0x2340E64 VA: 0x2344E64
	public void BufferEnd() { }
}
