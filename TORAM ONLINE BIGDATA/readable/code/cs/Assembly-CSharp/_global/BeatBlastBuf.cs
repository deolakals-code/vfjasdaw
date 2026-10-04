// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BeatBlastBuf : CountBufferBase // TypeDefIndex: 3076
{
	// Fields
	private const int MaxPayStackValue = 6;

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x231EA78 Offset: 0x231AA78 VA: 0x231EA78
	public void .ctor() { }

	// RVA: 0x231EA8C Offset: 0x231AA8C VA: 0x231EA8C Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x231EA94 Offset: 0x231AA94 VA: 0x231EA94 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x231EA9C Offset: 0x231AA9C VA: 0x231EA9C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x231EABC Offset: 0x231AABC VA: 0x231EABC Slot: 11
	public override void Updata() { }

	// RVA: 0x231EAC0 Offset: 0x231AAC0 VA: 0x231EAC0
	public int PayStack() { }

	// RVA: 0x231EAE4 Offset: 0x231AAE4 VA: 0x231EAE4
	public void SetStack(int stack) { }
}
