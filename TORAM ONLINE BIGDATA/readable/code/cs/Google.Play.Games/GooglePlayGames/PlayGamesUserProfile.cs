// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames
public class PlayGamesUserProfile : IUserProfile // TypeDefIndex: 16722
{
	// Fields
	private string mDisplayName; // 0x10
	private string mPlayerId; // 0x18
	private string mAvatarUrl; // 0x20
	private bool mIsFriend; // 0x28
	private bool mImageLoading; // 0x29
	private Texture2D mImage; // 0x30

	// Properties
	public string userName { get; }
	public string id { get; }
	public string gameId { get; }
	public bool isFriend { get; }
	public UserState state { get; }
	public Texture2D image { get; }
	public string AvatarURL { get; }

	// Methods

	// RVA: 0x2E09AC8 Offset: 0x2E05AC8 VA: 0x2E09AC8
	internal void .ctor(string displayName, string playerId, string avatarUrl) { }

	// RVA: 0x2E0F2FC Offset: 0x2E0B2FC VA: 0x2E0F2FC
	internal void .ctor(string displayName, string playerId, string avatarUrl, bool isFriend) { }

	// RVA: 0x2E0A4B4 Offset: 0x2E064B4 VA: 0x2E0A4B4
	protected void ResetIdentity(string displayName, string playerId, string avatarUrl) { }

	// RVA: 0x2E0F370 Offset: 0x2E0B370 VA: 0x2E0F370 Slot: 4
	public string get_userName() { }

	// RVA: 0x2E0F378 Offset: 0x2E0B378 VA: 0x2E0F378 Slot: 5
	public string get_id() { }

	// RVA: 0x2E0F380 Offset: 0x2E0B380 VA: 0x2E0F380
	public string get_gameId() { }

	// RVA: 0x2E0F388 Offset: 0x2E0B388 VA: 0x2E0F388 Slot: 6
	public bool get_isFriend() { }

	// RVA: 0x2E0F390 Offset: 0x2E0B390 VA: 0x2E0F390 Slot: 7
	public UserState get_state() { }

	// RVA: 0x2E0F398 Offset: 0x2E0B398 VA: 0x2E0F398 Slot: 8
	public Texture2D get_image() { }

	// RVA: 0x2E0F674 Offset: 0x2E0B674 VA: 0x2E0F674
	public string get_AvatarURL() { }

	[IteratorStateMachine(typeof(PlayGamesUserProfile.<LoadImage>d__23))]
	// RVA: 0x2E0F4C0 Offset: 0x2E0B4C0 VA: 0x2E0F4C0
	internal IEnumerator LoadImage() { }

	// RVA: 0x2E0F6A4 Offset: 0x2E0B6A4 VA: 0x2E0F6A4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2E0F7C4 Offset: 0x2E0B7C4 VA: 0x2E0F7C4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E0F874 Offset: 0x2E0B874 VA: 0x2E0F874 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E0F20C Offset: 0x2E0B20C VA: 0x2E0F20C
	private void setAvatarUrl(string avatarUrl) { }
}
