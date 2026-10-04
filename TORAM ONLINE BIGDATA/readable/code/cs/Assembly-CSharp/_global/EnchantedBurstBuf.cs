// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnchantedBurstBuf : CountBufferBase // TypeDefIndex: 3142
{
	// Fields
	private SkillBufferFlag flag; // 0x28
	private int localCount; // 0x2C
	private List<SkillIdData> addStackSkillIdDataList; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x232AD04 Offset: 0x2326D04 VA: 0x232AD04 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232AD0C Offset: 0x2326D0C VA: 0x232AD0C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232AD20 Offset: 0x2326D20 VA: 0x232AD20 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232AD28 Offset: 0x2326D28 VA: 0x232AD28
	public void .ctor(byte lv) { }

	// RVA: 0x232ADE0 Offset: 0x2326DE0 VA: 0x232ADE0 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232AE00 Offset: 0x2326E00 VA: 0x232AE00 Slot: 11
	public override void Updata() { }

	// RVA: 0x232AE04 Offset: 0x2326E04 VA: 0x232AE04 Slot: 23
	public override void Next() { }

	// RVA: 0x232AE50 Offset: 0x2326E50 VA: 0x232AE50
	public void PayStack() { }

	// RVA: 0x232AE74 Offset: 0x2326E74 VA: 0x232AE74
	public int GetPayStack() { }

	// RVA: 0x232AE88 Offset: 0x2326E88 VA: 0x232AE88
	public void LocalNext(int skillId, byte skillLocalId) { }

	// RVA: 0x232B000 Offset: 0x2327000 VA: 0x232B000
	public void LocalNext(SkillIdData skillIdData) { }

	// RVA: 0x232B008 Offset: 0x2327008 VA: 0x232B008
	public void AddStack(int skillId, byte skillLocalId) { }

	// RVA: 0x232B1BC Offset: 0x23271BC VA: 0x232B1BC
	public void AddStack(SkillIdData skillIdData) { }
}
