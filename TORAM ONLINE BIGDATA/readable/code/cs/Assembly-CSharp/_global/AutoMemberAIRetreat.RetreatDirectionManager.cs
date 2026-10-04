// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AutoMemberAIRetreat.RetreatDirectionManager // TypeDefIndex: 402
{
	// Fields
	[CompilerGenerated]
	private AutoMemberAIRetreat <Parent>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <amplitude>k__BackingField; // 0x18

	// Properties
	public AutoMemberAIRetreat Parent { get; set; }
	public float amplitude { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x173A66C Offset: 0x173666C VA: 0x173A66C
	public AutoMemberAIRetreat get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x173A674 Offset: 0x1736674 VA: 0x173A674
	public void set_Parent(AutoMemberAIRetreat value) { }

	[CompilerGenerated]
	// RVA: 0x173A67C Offset: 0x173667C VA: 0x173A67C
	public float get_amplitude() { }

	[CompilerGenerated]
	// RVA: 0x173A684 Offset: 0x1736684 VA: 0x173A684
	public void set_amplitude(float value) { }

	// RVA: 0x173A68C Offset: 0x173668C VA: 0x173A68C Slot: 4
	protected virtual Vector3 onGetRetreatDirectionCircle(MobPatternBase target, Transform pos, Vector3 actPos) { }

	// RVA: 0x173A920 Offset: 0x1736920 VA: 0x173A920 Slot: 5
	protected virtual Vector3 onGetRetreatDirectionLine(MobPatternBase target, Transform pos, Transform actPos) { }

	// RVA: 0x173AB28 Offset: 0x1736B28 VA: 0x173AB28
	public Vector3 GetRetreatDirection() { }

	// RVA: 0x173AFD8 Offset: 0x1736FD8 VA: 0x173AFD8
	public void .ctor() { }
}
