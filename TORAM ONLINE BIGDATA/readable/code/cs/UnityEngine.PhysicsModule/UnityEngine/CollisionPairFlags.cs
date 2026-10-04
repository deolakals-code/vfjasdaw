// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
internal enum CollisionPairFlags // TypeDefIndex: 17660
{
	// Fields
	public ushort value__; // 0x0
	public const CollisionPairFlags RemovedShape = 1;
	public const CollisionPairFlags RemovedOtherShape = 2;
	public const CollisionPairFlags ActorPairHasFirstTouch = 4;
	public const CollisionPairFlags ActorPairLostTouch = 8;
	public const CollisionPairFlags InternalHasImpulses = 16;
	public const CollisionPairFlags InternalContactsAreFlipped = 32;
}
