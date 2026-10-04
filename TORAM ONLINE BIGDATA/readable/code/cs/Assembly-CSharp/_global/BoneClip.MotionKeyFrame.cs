// Assembly: Assembly-CSharp.dll
// Namespace: 
public struct BoneClip.MotionKeyFrame // TypeDefIndex: 5302
{
	// Fields
	public readonly short Frame; // 0x0
	public readonly float Value; // 0x4
	public readonly byte Mode; // 0x8
	private float[] tangent; // 0x10

	// Properties
	public float InTangent { get; }
	public float OutTangent { get; }

	// Methods

	// RVA: 0x262A074 Offset: 0x2626074 VA: 0x262A074
	public float get_InTangent() { }

	// RVA: 0x262A094 Offset: 0x2626094 VA: 0x262A094
	public float get_OutTangent() { }

	// RVA: 0x2629D74 Offset: 0x2625D74 VA: 0x2629D74
	public void .ctor(short frame, float value, byte mode) { }

	// RVA: 0x2629D8C Offset: 0x2625D8C VA: 0x2629D8C
	public void .ctor(short frame, float value, byte mode, float inTangent, float outTangent) { }
}
