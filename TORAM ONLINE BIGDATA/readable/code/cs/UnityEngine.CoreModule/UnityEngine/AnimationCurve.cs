// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[DefaultMember("Item")]
[RequiredByNativeCode]
public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 16194
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x37CC3B0 Offset: 0x37C83B0 VA: 0x37CC3B0
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x37CC3EC Offset: 0x37C83EC VA: 0x37CC3EC
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x37CC428 Offset: 0x37C8428 VA: 0x37CC428
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x37CC46C Offset: 0x37C846C VA: 0x37CC46C Slot: 1
	protected override void Finalize() { }

	[ThreadSafe]
	// RVA: 0x37CC528 Offset: 0x37C8528 VA: 0x37CC528
	public float Evaluate(float time) { }

	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x37CC574 Offset: 0x37C8574 VA: 0x37CC574 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37CC5B0 Offset: 0x37C85B0 VA: 0x37CC5B0
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x37CC73C Offset: 0x37C873C VA: 0x37CC73C
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x37CC6EC Offset: 0x37C86EC VA: 0x37CC6EC
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCode]
	// RVA: 0x37CC86C Offset: 0x37C886C VA: 0x37CC86C
	public void .ctor() { }

	// RVA: 0x37CC8B8 Offset: 0x37C88B8 VA: 0x37CC8B8 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x37CC9C4 Offset: 0x37C89C4 VA: 0x37CC9C4 Slot: 4
	public bool Equals(AnimationCurve other) { }
}
