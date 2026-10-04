// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Nearby
public struct AdvertisingResult // TypeDefIndex: 16845
{
	// Fields
	private readonly ResponseStatus mStatus; // 0x0
	private readonly string mLocalEndpointName; // 0x8

	// Properties
	public bool Succeeded { get; }
	public ResponseStatus Status { get; }
	public string LocalEndpointName { get; }

	// Methods

	// RVA: 0x2E33C84 Offset: 0x2E2FC84 VA: 0x2E33C84
	public void .ctor(ResponseStatus status, string localEndpointName) { }

	// RVA: 0x2E33CF0 Offset: 0x2E2FCF0 VA: 0x2E33CF0
	public bool get_Succeeded() { }

	// RVA: 0x2E33D00 Offset: 0x2E2FD00 VA: 0x2E33D00
	public ResponseStatus get_Status() { }

	// RVA: 0x2E33D08 Offset: 0x2E2FD08 VA: 0x2E33D08
	public string get_LocalEndpointName() { }
}
