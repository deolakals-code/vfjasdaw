// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public interface IPartyMemberStatusData // TypeDefIndex: 12997
{
	// Properties
	public abstract int ArchetypeId { get; }
	public abstract byte ArchetypeType { get; }
	public abstract byte HpRate { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ArchetypeId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte get_ArchetypeType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract byte get_HpRate();
}
