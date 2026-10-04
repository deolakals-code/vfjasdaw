// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AbnormalMotionData : AbnormalData // TypeDefIndex: 1643
{
	// Fields
	private Animation animation; // 0x28
	private string motionId; // 0x30
	[CompilerGenerated]
	private int <MotionId>k__BackingField; // 0x38

	// Properties
	public int MotionId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x209FDE8 Offset: 0x209BDE8 VA: 0x209FDE8
	public int get_MotionId() { }

	[CompilerGenerated]
	// RVA: 0x209FDF0 Offset: 0x209BDF0 VA: 0x209FDF0
	private void set_MotionId(int value) { }

	// RVA: 0x209FDF8 Offset: 0x209BDF8 VA: 0x209FDF8
	public void .ctor(AbnormalType type, Animation animation, int motionId, float resistTime, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x209FF7C Offset: 0x209BF7C VA: 0x209FF7C Slot: 4
	public override bool Update(float dtime) { }
}
