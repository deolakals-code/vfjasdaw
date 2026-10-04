// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonDemonicBuf : CountBufferBase // TypeDefIndex: 3329
{
	// Fields
	private int maxHpRate; // 0x28
	private int summonMp; // 0x2C

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x2347B80 Offset: 0x2343B80 VA: 0x2347B80 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2347B88 Offset: 0x2343B88 VA: 0x2347B88 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2347BA4 Offset: 0x2343BA4 VA: 0x2347BA4 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x2347BAC Offset: 0x2343BAC VA: 0x2347BAC
	public void .ctor(byte lv, int mp) { }

	// RVA: 0x2347BDC Offset: 0x2343BDC VA: 0x2347BDC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2347C04 Offset: 0x2343C04 VA: 0x2347C04 Slot: 11
	public override void Updata() { }

	// RVA: 0x2347C08 Offset: 0x2343C08 VA: 0x2347C08
	public void BufferEnd() { }

	// RVA: 0x2347D38 Offset: 0x2343D38 VA: 0x2347D38
	public void SetBloodContract() { }

	// RVA: 0x2347D44 Offset: 0x2343D44 VA: 0x2347D44
	public void SetSummonMp(int mp) { }
}
