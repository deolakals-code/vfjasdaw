// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.SavedGame
public struct SavedGameMetadataUpdate // TypeDefIndex: 16844
{
	// Fields
	private readonly bool mDescriptionUpdated; // 0x0
	private readonly string mNewDescription; // 0x8
	private readonly bool mCoverImageUpdated; // 0x10
	private readonly byte[] mNewPngCoverImage; // 0x18
	private readonly Nullable<TimeSpan> mNewPlayedTime; // 0x20

	// Properties
	public bool IsDescriptionUpdated { get; }
	public string UpdatedDescription { get; }
	public bool IsCoverImageUpdated { get; }
	public byte[] UpdatedPngCoverImage { get; }
	public bool IsPlayedTimeUpdated { get; }
	public Nullable<TimeSpan> UpdatedPlayedTime { get; }

	// Methods

	// RVA: 0x2E339A8 Offset: 0x2E2F9A8 VA: 0x2E339A8
	private void .ctor(SavedGameMetadataUpdate.Builder builder) { }

	// RVA: 0x2E33A18 Offset: 0x2E2FA18 VA: 0x2E33A18
	public bool get_IsDescriptionUpdated() { }

	// RVA: 0x2E33A20 Offset: 0x2E2FA20 VA: 0x2E33A20
	public string get_UpdatedDescription() { }

	// RVA: 0x2E33A28 Offset: 0x2E2FA28 VA: 0x2E33A28
	public bool get_IsCoverImageUpdated() { }

	// RVA: 0x2E33A30 Offset: 0x2E2FA30 VA: 0x2E33A30
	public byte[] get_UpdatedPngCoverImage() { }

	// RVA: 0x2E33A38 Offset: 0x2E2FA38 VA: 0x2E33A38
	public bool get_IsPlayedTimeUpdated() { }

	// RVA: 0x2E33A74 Offset: 0x2E2FA74 VA: 0x2E33A74
	public Nullable<TimeSpan> get_UpdatedPlayedTime() { }
}
