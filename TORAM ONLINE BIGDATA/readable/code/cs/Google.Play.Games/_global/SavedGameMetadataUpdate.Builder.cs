// Assembly: Google.Play.Games.dll
// Namespace: 
public struct SavedGameMetadataUpdate.Builder // TypeDefIndex: 16843
{
	// Fields
	internal bool mDescriptionUpdated; // 0x0
	internal string mNewDescription; // 0x8
	internal bool mCoverImageUpdated; // 0x10
	internal byte[] mNewPngCoverImage; // 0x18
	internal Nullable<TimeSpan> mNewPlayedTime; // 0x20

	// Methods

	// RVA: 0x2E33A80 Offset: 0x2E2FA80 VA: 0x2E33A80
	public SavedGameMetadataUpdate.Builder WithUpdatedDescription(string description) { }

	// RVA: 0x2E33B04 Offset: 0x2E2FB04 VA: 0x2E33B04
	public SavedGameMetadataUpdate.Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage) { }

	// RVA: 0x2E33B40 Offset: 0x2E2FB40 VA: 0x2E33B40
	public SavedGameMetadataUpdate.Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime) { }

	// RVA: 0x2E33C48 Offset: 0x2E2FC48 VA: 0x2E33C48
	public SavedGameMetadataUpdate Build() { }
}
