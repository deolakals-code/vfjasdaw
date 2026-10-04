// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
[IsReadOnly]
public struct ContactPairHeader // TypeDefIndex: 17657
{
	// Fields
	internal readonly int m_BodyID; // 0x0
	internal readonly int m_OtherBodyID; // 0x4
	internal readonly IntPtr m_StartPtr; // 0x8
	internal readonly uint m_NbPairs; // 0x10
	internal readonly CollisionPairHeaderFlags m_Flags; // 0x14
	internal readonly Vector3 m_RelativeVelocity; // 0x18

	// Properties
	public Component Body { get; }
	public Component OtherBody { get; }
	internal bool HasRemovedBody { get; }

	// Methods

	// RVA: 0x38185B4 Offset: 0x38145B4 VA: 0x38185B4
	public Component get_Body() { }

	// RVA: 0x381853C Offset: 0x381453C VA: 0x381853C
	public Component get_OtherBody() { }

	// RVA: 0x381B958 Offset: 0x3817958 VA: 0x381B958
	internal bool get_HasRemovedBody() { }

	// RVA: 0x381B968 Offset: 0x3817968 VA: 0x381B968
	public ref ContactPair GetContactPair(int index) { }

	// RVA: 0x381D124 Offset: 0x3819124 VA: 0x381D124
	internal ContactPair* GetContactPair_Internal(int index) { }
}
