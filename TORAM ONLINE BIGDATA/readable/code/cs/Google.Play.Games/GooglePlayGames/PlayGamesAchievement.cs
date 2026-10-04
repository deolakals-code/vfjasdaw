// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames
internal class PlayGamesAchievement : IAchievement, IAchievementDescription // TypeDefIndex: 16700
{
	// Fields
	private readonly ReportProgress mProgressCallback; // 0x10
	private string mId; // 0x18
	private bool mIsIncremental; // 0x20
	private int mCurrentSteps; // 0x24
	private int mTotalSteps; // 0x28
	private double mPercentComplete; // 0x30
	private bool mCompleted; // 0x38
	private bool mHidden; // 0x39
	private DateTime mLastModifiedTime; // 0x40
	private string mTitle; // 0x48
	private string mRevealedImageUrl; // 0x50
	private string mUnlockedImageUrl; // 0x58
	private UnityWebRequest mImageFetcher; // 0x60
	private Texture2D mImage; // 0x68
	private string mDescription; // 0x70
	private ulong mPoints; // 0x78

	// Properties
	public string id { get; set; }
	public bool isIncremental { get; }
	public int currentSteps { get; }
	public int totalSteps { get; }
	public double percentCompleted { get; set; }
	public bool completed { get; }
	public bool hidden { get; }
	public DateTime lastReportedDate { get; }
	public string title { get; }
	public Texture2D image { get; }
	public string achievedDescription { get; }
	public string unachievedDescription { get; }
	public int points { get; }

	// Methods

	// RVA: 0x2E08770 Offset: 0x2E04770 VA: 0x2E08770
	internal void .ctor() { }

	// RVA: 0x2E088CC Offset: 0x2E048CC VA: 0x2E088CC
	internal void .ctor(ReportProgress progressCallback) { }

	// RVA: 0x2E089E8 Offset: 0x2E049E8 VA: 0x2E089E8
	internal void .ctor(Achievement ach) { }

	// RVA: 0x2E08B74 Offset: 0x2E04B74 VA: 0x2E08B74 Slot: 6
	public void ReportProgress(Action<bool> callback) { }

	// RVA: 0x2E08BA4 Offset: 0x2E04BA4 VA: 0x2E08BA4
	private Texture2D LoadImage() { }

	// RVA: 0x2E08CDC Offset: 0x2E04CDC VA: 0x2E08CDC Slot: 4
	public string get_id() { }

	// RVA: 0x2E08CE4 Offset: 0x2E04CE4 VA: 0x2E08CE4 Slot: 7
	public void set_id(string value) { }

	// RVA: 0x2E08CEC Offset: 0x2E04CEC VA: 0x2E08CEC
	public bool get_isIncremental() { }

	// RVA: 0x2E08CF4 Offset: 0x2E04CF4 VA: 0x2E08CF4
	public int get_currentSteps() { }

	// RVA: 0x2E08CFC Offset: 0x2E04CFC VA: 0x2E08CFC
	public int get_totalSteps() { }

	// RVA: 0x2E08D04 Offset: 0x2E04D04 VA: 0x2E08D04 Slot: 8
	public double get_percentCompleted() { }

	// RVA: 0x2E08D0C Offset: 0x2E04D0C VA: 0x2E08D0C Slot: 9
	public void set_percentCompleted(double value) { }

	// RVA: 0x2E08D14 Offset: 0x2E04D14 VA: 0x2E08D14 Slot: 5
	public bool get_completed() { }

	// RVA: 0x2E08D1C Offset: 0x2E04D1C VA: 0x2E08D1C Slot: 10
	public bool get_hidden() { }

	// RVA: 0x2E08D24 Offset: 0x2E04D24 VA: 0x2E08D24 Slot: 11
	public DateTime get_lastReportedDate() { }

	// RVA: 0x2E08D2C Offset: 0x2E04D2C VA: 0x2E08D2C Slot: 12
	public string get_title() { }

	// RVA: 0x2E08D34 Offset: 0x2E04D34 VA: 0x2E08D34 Slot: 13
	public Texture2D get_image() { }

	// RVA: 0x2E08D38 Offset: 0x2E04D38 VA: 0x2E08D38 Slot: 14
	public string get_achievedDescription() { }

	// RVA: 0x2E08D40 Offset: 0x2E04D40 VA: 0x2E08D40 Slot: 15
	public string get_unachievedDescription() { }

	// RVA: 0x2E08D48 Offset: 0x2E04D48 VA: 0x2E08D48 Slot: 16
	public int get_points() { }
}
