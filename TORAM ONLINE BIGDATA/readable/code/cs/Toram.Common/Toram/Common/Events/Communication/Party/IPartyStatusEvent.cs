// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public interface IPartyStatusEvent // TypeDefIndex: 12864
{
	// Properties
	public abstract int PartyId { get; }
	public abstract IPartyMemberStatusData[] Members { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_PartyId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IPartyMemberStatusData[] get_Members();
}
