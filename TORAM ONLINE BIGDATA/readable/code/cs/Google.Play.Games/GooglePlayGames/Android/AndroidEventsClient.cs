// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.Android
internal class AndroidEventsClient : IEventsClient // TypeDefIndex: 16759
{
	// Fields
	private AndroidJavaObject mEventsClient; // 0x10

	// Methods

	// RVA: 0x2E1BBB4 Offset: 0x2E17BB4 VA: 0x2E1BBB4
	public void .ctor() { }

	// RVA: 0x2E20D48 Offset: 0x2E1CD48 VA: 0x2E20D48 Slot: 4
	public void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback) { }

	// RVA: 0x2E210CC Offset: 0x2E1D0CC VA: 0x2E210CC Slot: 5
	public void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback) { }

	// RVA: 0x2E214BC Offset: 0x2E1D4BC VA: 0x2E214BC Slot: 6
	public void IncrementEvent(string eventId, uint stepsToIncrement) { }

	// RVA: -1 Offset: -1
	private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268A5E4 Offset: 0x26865E4 VA: 0x268A5E4
	|-AndroidEventsClient.ToOnGameThread<Int32Enum, object>
	|
	|-RVA: 0x268A680 Offset: 0x2686680 VA: 0x268A680
	|-AndroidEventsClient.ToOnGameThread<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E215FC Offset: 0x2E1D5FC VA: 0x2E215FC
	private static Event CreateEvent(AndroidJavaObject eventJava) { }
}
