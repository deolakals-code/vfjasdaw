// Assembly: Google.Play.Games.dll
// Namespace: 
private class AndroidSavedGameClient.AndroidConflictResolver : IConflictResolver // TypeDefIndex: 16785
{
	// Fields
	private readonly AndroidJavaObject mSnapshotsClient; // 0x10
	private readonly AndroidJavaObject mConflict; // 0x18
	private readonly AndroidSnapshotMetadata mOriginal; // 0x20
	private readonly AndroidSnapshotMetadata mUnmerged; // 0x28
	private readonly Action<SavedGameRequestStatus, ISavedGameMetadata> mCompleteCallback; // 0x30
	private readonly Action mRetryFileOpen; // 0x38
	private readonly AndroidSavedGameClient mAndroidSavedGameClient; // 0x40

	// Methods

	// RVA: 0x2E2C7C4 Offset: 0x2E287C4 VA: 0x2E2C7C4
	internal void .ctor(AndroidSavedGameClient androidSavedGameClient, AndroidJavaObject snapshotClient, AndroidJavaObject conflict, AndroidSnapshotMetadata original, AndroidSnapshotMetadata unmerged, Action<SavedGameRequestStatus, ISavedGameMetadata> completeCallback, Action retryOpen) { }

	// RVA: 0x2E2C93C Offset: 0x2E2893C VA: 0x2E2C93C Slot: 5
	public void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData) { }

	// RVA: 0x2E2D360 Offset: 0x2E29360 VA: 0x2E2D360 Slot: 4
	public void ChooseMetadata(ISavedGameMetadata chosenMetadata) { }

	[CompilerGenerated]
	// RVA: 0x2E2D7E0 Offset: 0x2E297E0 VA: 0x2E2D7E0
	private void <ResolveConflict>b__8_0(AndroidJavaObject dataOrConflict) { }

	[CompilerGenerated]
	// RVA: 0x2E2D804 Offset: 0x2E29804 VA: 0x2E2D804
	private void <ResolveConflict>b__8_1(AndroidJavaObject exception) { }

	[CompilerGenerated]
	// RVA: 0x2E2D980 Offset: 0x2E29980 VA: 0x2E2D980
	private void <ChooseMetadata>b__9_0(AndroidJavaObject dataOrConflict) { }

	[CompilerGenerated]
	// RVA: 0x2E2D9A4 Offset: 0x2E299A4 VA: 0x2E2D9A4
	private void <ChooseMetadata>b__9_1(AndroidJavaObject exception) { }
}
