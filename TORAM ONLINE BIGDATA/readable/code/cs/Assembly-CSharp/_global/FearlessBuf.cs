// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FearlessBuf : CountBufferBase // TypeDefIndex: 3164
{
	// Fields
	private int baseAspdUp; // 0x28
	private int baseResist; // 0x2C
	private int baseNormalAtkUpRate; // 0x30
	private float baseRateDmgDownRate; // 0x34
	private PlayerStatusBase playerStatus; // 0x38

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x232E160 Offset: 0x232A160 VA: 0x232E160 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232E168 Offset: 0x232A168 VA: 0x232E168 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232E170 Offset: 0x232A170 VA: 0x232E170 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232E178 Offset: 0x232A178 VA: 0x232E178
	public void .ctor(byte lv, PlayerActionManagerBase playerAct) { }

	// RVA: 0x232E348 Offset: 0x232A348 VA: 0x232E348 Slot: 11
	public override void Updata() { }

	// RVA: 0x232E39C Offset: 0x232A39C VA: 0x232E39C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232E46C Offset: 0x232A46C VA: 0x232E46C
	public void SetBufCount(int count) { }
}
