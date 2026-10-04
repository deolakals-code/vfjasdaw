// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Physics/MessageParameters.h")]
public struct ContactPoint // TypeDefIndex: 17655
{
	// Fields
	internal Vector3 m_Point; // 0x0
	internal Vector3 m_Normal; // 0xC
	internal Vector3 m_Impulse; // 0x18
	internal int m_ThisColliderInstanceID; // 0x24
	internal int m_OtherColliderInstanceID; // 0x28
	internal float m_Separation; // 0x2C
}
