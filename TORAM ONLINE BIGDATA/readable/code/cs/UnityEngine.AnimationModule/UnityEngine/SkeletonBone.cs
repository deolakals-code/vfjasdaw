// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeType(1, "MonoSkeletonBone")]
[RequiredByNativeCode]
public struct SkeletonBone // TypeDefIndex: 17680
{
	// Fields
	[NativeName("m_Name")]
	public string name; // 0x0
	[NativeName("m_ParentName")]
	internal string parentName; // 0x8
	[NativeName("m_Position")]
	public Vector3 position; // 0x10
	[NativeName("m_Rotation")]
	public Quaternion rotation; // 0x1C
	[NativeName("m_Scale")]
	public Vector3 scale; // 0x2C
}
