// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AbnormalAnimationBaseData : AbnormalData // TypeDefIndex: 1644
{
	// Fields
	private AnimationBase animation; // 0x28
	[CompilerGenerated]
	private int <MotionId>k__BackingField; // 0x30

	// Properties
	public int MotionId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20A0048 Offset: 0x209C048 VA: 0x20A0048
	public int get_MotionId() { }

	[CompilerGenerated]
	// RVA: 0x20A0050 Offset: 0x209C050 VA: 0x20A0050
	private void set_MotionId(int value) { }

	// RVA: 0x20A0058 Offset: 0x209C058 VA: 0x20A0058
	public void .ctor(AbnormalType type, AnimationBase animation, int motionId, float resistTime, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x20A01D8 Offset: 0x209C1D8 VA: 0x20A01D8 Slot: 4
	public override bool Update(float dtime) { }
}
