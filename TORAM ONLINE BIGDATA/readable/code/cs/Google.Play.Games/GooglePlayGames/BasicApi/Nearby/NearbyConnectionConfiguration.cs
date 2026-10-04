// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Nearby
public struct NearbyConnectionConfiguration // TypeDefIndex: 16855
{
	// Fields
	public const int MaxUnreliableMessagePayloadLength = 1168;
	public const int MaxReliableMessagePayloadLength = 4096;
	private readonly Action<InitializationStatus> mInitializationCallback; // 0x0
	private readonly long mLocalClientId; // 0x8

	// Properties
	public long LocalClientId { get; }
	public Action<InitializationStatus> InitializationCallback { get; }

	// Methods

	// RVA: 0x2E34928 Offset: 0x2E30928 VA: 0x2E34928
	public void .ctor(Action<InitializationStatus> callback, long localClientId) { }

	// RVA: 0x2E34998 Offset: 0x2E30998 VA: 0x2E34998
	public long get_LocalClientId() { }

	// RVA: 0x2E349A0 Offset: 0x2E309A0 VA: 0x2E349A0
	public Action<InitializationStatus> get_InitializationCallback() { }
}
