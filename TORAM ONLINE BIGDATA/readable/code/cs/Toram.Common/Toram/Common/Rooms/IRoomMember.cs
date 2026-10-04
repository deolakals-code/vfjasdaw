// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public interface IRoomMember // TypeDefIndex: 11286
{
	// Properties
	public abstract byte ArchetypeType { get; }
	public abstract int ArchetypeId { get; }
	public abstract string UserName { get; }
	public abstract byte State { get; }
	public abstract short Level { get; }
	public abstract short WeaponType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte get_ArchetypeType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ArchetypeId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_UserName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract byte get_State();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract short get_Level();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract short get_WeaponType();
}
