// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public interface IRoomMemberStatus // TypeDefIndex: 11287
{
	// Properties
	public abstract byte ArchetypeType { get; }
	public abstract int ArchetypeId { get; }
	public abstract byte HpRate { get; }
	public abstract byte State { get; }
	public abstract int TeamId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte get_ArchetypeType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ArchetypeId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract byte get_HpRate();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract byte get_State();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_TeamId();
}
