// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EarthStyleBuf : CountBufferBase // TypeDefIndex: 3137
{
	// Fields
	private PlayerActionManagerBase actarAction; // 0x28
	private byte localId; // 0x30

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x232A9A0 Offset: 0x23269A0 VA: 0x232A9A0 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232A9A8 Offset: 0x23269A8 VA: 0x232A9A8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232A9B0 Offset: 0x23269B0 VA: 0x232A9B0
	public void .ctor(byte lv, PlayerActionManagerBase actarAction, byte skillLocalId) { }

	// RVA: 0x232AA08 Offset: 0x2326A08 VA: 0x232AA08 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232AA80 Offset: 0x2326A80 VA: 0x232AA80 Slot: 11
	public override void Updata() { }

	// RVA: 0x232ABD8 Offset: 0x2326BD8 VA: 0x232ABD8
	public void Damage() { }
}
