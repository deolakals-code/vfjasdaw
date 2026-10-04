// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Events
internal class Event : IEvent // TypeDefIndex: 16856
{
	// Fields
	private string mId; // 0x10
	private string mName; // 0x18
	private string mDescription; // 0x20
	private string mImageUrl; // 0x28
	private ulong mCurrentCount; // 0x30
	private EventVisibility mVisibility; // 0x38

	// Properties
	public string Id { get; }
	public string Name { get; }
	public string Description { get; }
	public string ImageUrl { get; }
	public ulong CurrentCount { get; }
	public EventVisibility Visibility { get; }

	// Methods

	// RVA: 0x2E349A8 Offset: 0x2E309A8 VA: 0x2E349A8
	internal void .ctor(string id, string name, string description, string imageUrl, ulong currentCount, EventVisibility visibility) { }

	// RVA: 0x2E34A38 Offset: 0x2E30A38 VA: 0x2E34A38 Slot: 4
	public string get_Id() { }

	// RVA: 0x2E34A40 Offset: 0x2E30A40 VA: 0x2E34A40 Slot: 5
	public string get_Name() { }

	// RVA: 0x2E34A48 Offset: 0x2E30A48 VA: 0x2E34A48 Slot: 6
	public string get_Description() { }

	// RVA: 0x2E34A50 Offset: 0x2E30A50 VA: 0x2E34A50 Slot: 7
	public string get_ImageUrl() { }

	// RVA: 0x2E34A58 Offset: 0x2E30A58 VA: 0x2E34A58 Slot: 8
	public ulong get_CurrentCount() { }

	// RVA: 0x2E34A60 Offset: 0x2E30A60 VA: 0x2E34A60 Slot: 9
	public EventVisibility get_Visibility() { }
}
