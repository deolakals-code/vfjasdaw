// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Events
public interface IEvent // TypeDefIndex: 16858
{
	// Properties
	public abstract string Id { get; }
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract string ImageUrl { get; }
	public abstract ulong CurrentCount { get; }
	public abstract EventVisibility Visibility { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Id();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Description();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_ImageUrl();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ulong get_CurrentCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract EventVisibility get_Visibility();
}
