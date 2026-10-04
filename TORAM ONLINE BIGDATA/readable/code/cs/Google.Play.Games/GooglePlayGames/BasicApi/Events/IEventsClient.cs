// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Events
public interface IEventsClient // TypeDefIndex: 16859
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void IncrementEvent(string eventId, uint stepsToIncrement);
}
