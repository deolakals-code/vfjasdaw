// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public interface IPartyStateEvent // TypeDefIndex: 12862
{
	// Properties
	public abstract int PartyId { get; }
	public abstract int LeaderId { get; }
	public abstract IPartyMemberStateData[] Members { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_PartyId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LeaderId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IPartyMemberStateData[] get_Members();
}
