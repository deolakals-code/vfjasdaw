// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RampageBuf : CountBufferBase // TypeDefIndex: 3279
{
	// Fields
	private bool isFinish; // 0x28
	private PlayerStatusBase status; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override bool IsAbnormalDamageCancel { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x23424D8 Offset: 0x233E4D8 VA: 0x23424D8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23424E0 Offset: 0x233E4E0 VA: 0x23424E0 Slot: 7
	public override bool get_IsAbnormalDamageCancel() { }

	// RVA: 0x23424E8 Offset: 0x233E4E8 VA: 0x23424E8 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23424F0 Offset: 0x233E4F0 VA: 0x23424F0 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2342510 Offset: 0x233E510 VA: 0x2342510
	public void .ctor(byte lv) { }

	// RVA: 0x234253C Offset: 0x233E53C VA: 0x234253C
	public void .ctor(byte lv, PlayerStatusBase playerStatus) { }

	// RVA: 0x2342580 Offset: 0x233E580 VA: 0x2342580 Slot: 11
	public override void Updata() { }

	// RVA: 0x23425EC Offset: 0x233E5EC VA: 0x23425EC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2342630 Offset: 0x233E630 VA: 0x2342630 Slot: 23
	public override void Next() { }
}
