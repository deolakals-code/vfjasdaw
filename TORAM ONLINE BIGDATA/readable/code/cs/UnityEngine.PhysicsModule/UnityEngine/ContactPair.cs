// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
[IsReadOnly]
[UsedByNativeCode]
public struct ContactPair // TypeDefIndex: 17658
{
	// Fields
	internal readonly int m_ColliderID; // 0x0
	internal readonly int m_OtherColliderID; // 0x4
	internal readonly IntPtr m_StartPtr; // 0x8
	internal readonly uint m_NbPoints; // 0x10
	internal readonly CollisionPairFlags m_Flags; // 0x14
	internal readonly CollisionPairEventFlags m_Events; // 0x16
	internal readonly Vector3 m_ImpulseSum; // 0x18

	// Properties
	public Collider Collider { get; }
	public Collider OtherCollider { get; }
	public bool IsCollisionEnter { get; }
	public bool IsCollisionExit { get; }
	public bool IsCollisionStay { get; }
	internal bool HasRemovedCollider { get; }

	// Methods

	// RVA: 0x38186CC Offset: 0x38146CC VA: 0x38186CC
	public Collider get_Collider() { }

	// RVA: 0x3818640 Offset: 0x3814640 VA: 0x3818640
	public Collider get_OtherCollider() { }

	// RVA: 0x381B97C Offset: 0x381797C VA: 0x381B97C
	public bool get_IsCollisionEnter() { }

	// RVA: 0x381BAC4 Offset: 0x3817AC4 VA: 0x381BAC4
	public bool get_IsCollisionExit() { }

	// RVA: 0x381BAB8 Offset: 0x3817AB8 VA: 0x381BAB8
	public bool get_IsCollisionStay() { }

	// RVA: 0x381B96C Offset: 0x381796C VA: 0x381B96C
	internal bool get_HasRemovedCollider() { }

	// RVA: 0x3818948 Offset: 0x3814948 VA: 0x3818948
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x381D1A4 Offset: 0x38191A4 VA: 0x381D1A4
	private static int ExtractContactsArray_Injected(ref ContactPair _unity_self, ContactPoint[] managedContainer, bool flipped) { }
}
