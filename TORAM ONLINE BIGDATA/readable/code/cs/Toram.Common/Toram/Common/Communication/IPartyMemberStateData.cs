// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public interface IPartyMemberStateData // TypeDefIndex: 12996
{
	// Properties
	public abstract byte ArchetypeType { get; }
	public abstract int ArchetypeId { get; }
	public abstract string UserName { get; }
	public abstract int FieldId { get; }
	public abstract byte FieldType { get; }
	public abstract int RoomId { get; }
	public abstract short Level { get; }
	public abstract byte Weapon { get; }
	public abstract byte SubWeapon { get; }
	public abstract byte State { get; }
	public abstract int AdditionalId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte get_ArchetypeType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ArchetypeId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_UserName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_FieldId();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_FieldType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_RoomId();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract short get_Level();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract byte get_Weapon();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract byte get_SubWeapon();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract byte get_State();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_AdditionalId();
}
