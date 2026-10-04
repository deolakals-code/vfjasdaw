// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IUserArchetype // TypeDefIndex: 1543
{
	// Properties
	public abstract bool IsAvatarArchetype { get; }
	public abstract ArchetypeUid ArchetypeUid { get; }
	public abstract string UserName { get; }
	public abstract bool IsGMEventPlayer { get; }
	public abstract byte RegionCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsAvatarArchetype();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ArchetypeUid get_ArchetypeUid();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_UserName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsGMEventPlayer();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_RegionCode();
}
