// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.Android
internal class AndroidSnapshotMetadata : ISavedGameMetadata // TypeDefIndex: 16795
{
	// Fields
	private AndroidJavaObject mJavaSnapshot; // 0x10
	private AndroidJavaObject mJavaMetadata; // 0x18
	private AndroidJavaObject mJavaContents; // 0x20

	// Properties
	public AndroidJavaObject JavaSnapshot { get; }
	public AndroidJavaObject JavaMetadata { get; }
	public AndroidJavaObject JavaContents { get; }
	public bool IsOpen { get; }
	public string Filename { get; }
	public string Description { get; }
	public string CoverImageURL { get; }
	public TimeSpan TotalTimePlayed { get; }
	public DateTime LastModifiedTimestamp { get; }

	// Methods

	// RVA: 0x2E2F01C Offset: 0x2E2B01C VA: 0x2E2F01C
	public void .ctor(AndroidJavaObject javaSnapshot) { }

	// RVA: 0x2E235F8 Offset: 0x2E1F5F8 VA: 0x2E235F8
	public void .ctor(AndroidJavaObject javaMetadata, AndroidJavaObject javaContents) { }

	// RVA: 0x2E2F58C Offset: 0x2E2B58C VA: 0x2E2F58C
	public AndroidJavaObject get_JavaSnapshot() { }

	// RVA: 0x2E2F594 Offset: 0x2E2B594 VA: 0x2E2F594
	public AndroidJavaObject get_JavaMetadata() { }

	// RVA: 0x2E2F59C Offset: 0x2E2B59C VA: 0x2E2F59C
	public AndroidJavaObject get_JavaContents() { }

	// RVA: 0x2E2AC24 Offset: 0x2E26C24 VA: 0x2E2AC24 Slot: 4
	public bool get_IsOpen() { }

	// RVA: 0x2E2F5A4 Offset: 0x2E2B5A4 VA: 0x2E2F5A4 Slot: 5
	public string get_Filename() { }

	// RVA: 0x2E2F674 Offset: 0x2E2B674 VA: 0x2E2F674 Slot: 6
	public string get_Description() { }

	// RVA: 0x2E2F744 Offset: 0x2E2B744 VA: 0x2E2F744 Slot: 7
	public string get_CoverImageURL() { }

	// RVA: 0x2E2F814 Offset: 0x2E2B814 VA: 0x2E2F814 Slot: 8
	public TimeSpan get_TotalTimePlayed() { }

	// RVA: 0x2E2F91C Offset: 0x2E2B91C VA: 0x2E2F91C Slot: 9
	public DateTime get_LastModifiedTimestamp() { }
}
