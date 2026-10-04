// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KnightPledgeBuf : CountBufferBase // TypeDefIndex: 3222
{
	// Fields
	private SkillBufferFlag bufferType; // 0x28
	private CountBufferBase.CountType countViewType; // 0x2C
	private int totalReduceValue; // 0x30
	private int effectiveNum; // 0x34
	private int lastDamageRate; // 0x38
	private int knockbackDistReduceRate; // 0x3C
	private bool isEffective; // 0x40
	private KnightPledgeBuf.EffectiveBufData selfBufData; // 0x48
	private KnightPledgeBuf.EffectiveBufData otherBufData; // 0x50

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x23383C0 Offset: 0x23343C0 VA: 0x23383C0
	public void .ctor(byte lv, bool self) { }

	// RVA: 0x2338444 Offset: 0x2334444 VA: 0x2338444 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233844C Offset: 0x233444C VA: 0x233844C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2338454 Offset: 0x2334454 VA: 0x2338454 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x233845C Offset: 0x233445C VA: 0x233845C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x233851C Offset: 0x233451C VA: 0x233851C Slot: 11
	public override void Updata() { }

	// RVA: 0x2338748 Offset: 0x2334748 VA: 0x2338748
	public void ReceiveDamage(int totalReduceValue) { }

	// RVA: 0x2338770 Offset: 0x2334770 VA: 0x2338770
	public bool CheckIsSelf() { }

	// RVA: 0x2338780 Offset: 0x2334780 VA: 0x2338780
	public void UpdateOtherBuf(int targetArchetypeId, byte level, int receiveEncryptionValue, int num) { }

	// RVA: 0x23388E0 Offset: 0x23348E0 VA: 0x23388E0
	public void UpdateSelfBuf(int archetypeId, byte level, int num, int lastDamageRate, int knockbackDistReduceRate, byte skillLocalId, bool inArea) { }

	// RVA: 0x23389F4 Offset: 0x23349F4 VA: 0x23389F4
	public void RemoveSelfBuf() { }

	// RVA: 0x2338A50 Offset: 0x2334A50 VA: 0x2338A50
	public bool CheckInvokeSelfKnightPledge(int skillLocalId) { }

	// RVA: 0x2338678 Offset: 0x2334678 VA: 0x2338678
	private bool CheckEnd() { }

	// RVA: 0x2338698 Offset: 0x2334698 VA: 0x2338698
	public void UpdateEffectiveParameter() { }

	// RVA: 0x2338A70 Offset: 0x2334A70 VA: 0x2338A70
	public int GetEffectiveArchetypeId() { }
}
