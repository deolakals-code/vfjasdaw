// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames
public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile // TypeDefIndex: 16705
{
	// Fields
	internal PlayGamesPlatform mPlatform; // 0x38
	private PlayerStats mStats; // 0x40

	// Properties
	public IUserProfile[] friends { get; }
	public bool authenticated { get; }
	public bool underage { get; }
	public string userName { get; }
	public string id { get; }
	public bool isFriend { get; }
	public UserState state { get; }
	public string AvatarURL { get; }

	// Methods

	// RVA: 0x2E09A30 Offset: 0x2E05A30 VA: 0x2E09A30
	internal void .ctor(PlayGamesPlatform plaf) { }

	// RVA: 0x2E09B30 Offset: 0x2E05B30 VA: 0x2E09B30 Slot: 10
	public void Authenticate(Action<bool> callback) { }

	// RVA: 0x2E09CAC Offset: 0x2E05CAC VA: 0x2E09CAC Slot: 11
	public void Authenticate(Action<bool, string> callback) { }

	// RVA: 0x2E09D80 Offset: 0x2E05D80 VA: 0x2E09D80 Slot: 12
	public void LoadFriends(Action<bool> callback) { }

	// RVA: 0x2E09EC0 Offset: 0x2E05EC0 VA: 0x2E09EC0 Slot: 13
	public IUserProfile[] get_friends() { }

	// RVA: 0x2E09FF0 Offset: 0x2E05FF0 VA: 0x2E09FF0 Slot: 9
	public bool get_authenticated() { }

	// RVA: 0x2E0A0B8 Offset: 0x2E060B8 VA: 0x2E0A0B8 Slot: 14
	public bool get_underage() { }

	// RVA: 0x2E0A0C0 Offset: 0x2E060C0 VA: 0x2E0A0C0 Slot: 15
	public string get_userName() { }

	// RVA: 0x2E0A534 Offset: 0x2E06534 VA: 0x2E0A534 Slot: 16
	public string get_id() { }

	// RVA: 0x2E0A5F8 Offset: 0x2E065F8 VA: 0x2E0A5F8 Slot: 17
	public bool get_isFriend() { }

	// RVA: 0x2E0A600 Offset: 0x2E06600 VA: 0x2E0A600 Slot: 18
	public UserState get_state() { }

	// RVA: 0x2E0A608 Offset: 0x2E06608 VA: 0x2E0A608
	public string get_AvatarURL() { }

	// RVA: 0x2E0A6CC Offset: 0x2E066CC VA: 0x2E0A6CC
	public void GetStats(Action<CommonStatusCodes, PlayerStats> callback) { }
}
