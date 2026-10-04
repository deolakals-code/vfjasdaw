// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi
public class Achievement // TypeDefIndex: 16810
{
	// Fields
	private static readonly DateTime UnixEpoch; // 0x0
	private string mId; // 0x10
	private bool mIsIncremental; // 0x18
	private bool mIsRevealed; // 0x19
	private bool mIsUnlocked; // 0x1A
	private int mCurrentSteps; // 0x1C
	private int mTotalSteps; // 0x20
	private string mDescription; // 0x28
	private string mName; // 0x30
	private long mLastModifiedTime; // 0x38
	private ulong mPoints; // 0x40
	private string mRevealedImageUrl; // 0x48
	private string mUnlockedImageUrl; // 0x50

	// Properties
	public bool IsIncremental { get; set; }
	public int CurrentSteps { get; set; }
	public int TotalSteps { get; set; }
	public bool IsUnlocked { get; set; }
	public bool IsRevealed { get; set; }
	public string Id { get; set; }
	public string Description { get; set; }
	public string Name { get; set; }
	public DateTime LastModifiedTime { get; set; }
	public ulong Points { get; set; }
	public string RevealedImageUrl { get; set; }
	public string UnlockedImageUrl { get; set; }

	// Methods

	// RVA: 0x2E319E8 Offset: 0x2E2D9E8 VA: 0x2E319E8 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E1FA68 Offset: 0x2E1BA68 VA: 0x2E1FA68
	public void .ctor() { }

	// RVA: 0x2E31CF8 Offset: 0x2E2DCF8 VA: 0x2E31CF8
	public bool get_IsIncremental() { }

	// RVA: 0x2E31D00 Offset: 0x2E2DD00 VA: 0x2E31D00
	public void set_IsIncremental(bool value) { }

	// RVA: 0x2E31D0C Offset: 0x2E2DD0C VA: 0x2E31D0C
	public int get_CurrentSteps() { }

	// RVA: 0x2E31D14 Offset: 0x2E2DD14 VA: 0x2E31D14
	public void set_CurrentSteps(int value) { }

	// RVA: 0x2E31D1C Offset: 0x2E2DD1C VA: 0x2E31D1C
	public int get_TotalSteps() { }

	// RVA: 0x2E31D24 Offset: 0x2E2DD24 VA: 0x2E31D24
	public void set_TotalSteps(int value) { }

	// RVA: 0x2E31D2C Offset: 0x2E2DD2C VA: 0x2E31D2C
	public bool get_IsUnlocked() { }

	// RVA: 0x2E31D34 Offset: 0x2E2DD34 VA: 0x2E31D34
	public void set_IsUnlocked(bool value) { }

	// RVA: 0x2E31D40 Offset: 0x2E2DD40 VA: 0x2E31D40
	public bool get_IsRevealed() { }

	// RVA: 0x2E31D48 Offset: 0x2E2DD48 VA: 0x2E31D48
	public void set_IsRevealed(bool value) { }

	// RVA: 0x2E31D54 Offset: 0x2E2DD54 VA: 0x2E31D54
	public string get_Id() { }

	// RVA: 0x2E31D5C Offset: 0x2E2DD5C VA: 0x2E31D5C
	public void set_Id(string value) { }

	// RVA: 0x2E31D64 Offset: 0x2E2DD64 VA: 0x2E31D64
	public string get_Description() { }

	// RVA: 0x2E31D6C Offset: 0x2E2DD6C VA: 0x2E31D6C
	public void set_Description(string value) { }

	// RVA: 0x2E31D74 Offset: 0x2E2DD74 VA: 0x2E31D74
	public string get_Name() { }

	// RVA: 0x2E31D7C Offset: 0x2E2DD7C VA: 0x2E31D7C
	public void set_Name(string value) { }

	// RVA: 0x2E08AEC Offset: 0x2E04AEC VA: 0x2E08AEC
	public DateTime get_LastModifiedTime() { }

	// RVA: 0x2E1FAF8 Offset: 0x2E1BAF8 VA: 0x2E1FAF8
	public void set_LastModifiedTime(DateTime value) { }

	// RVA: 0x2E31D84 Offset: 0x2E2DD84 VA: 0x2E31D84
	public ulong get_Points() { }

	// RVA: 0x2E31D8C Offset: 0x2E2DD8C VA: 0x2E31D8C
	public void set_Points(ulong value) { }

	// RVA: 0x2E31D94 Offset: 0x2E2DD94 VA: 0x2E31D94
	public string get_RevealedImageUrl() { }

	// RVA: 0x2E31D9C Offset: 0x2E2DD9C VA: 0x2E31D9C
	public void set_RevealedImageUrl(string value) { }

	// RVA: 0x2E31DA4 Offset: 0x2E2DDA4 VA: 0x2E31DA4
	public string get_UnlockedImageUrl() { }

	// RVA: 0x2E31DAC Offset: 0x2E2DDAC VA: 0x2E31DAC
	public void set_UnlockedImageUrl(string value) { }

	// RVA: 0x2E31DB4 Offset: 0x2E2DDB4 VA: 0x2E31DB4
	private static void .cctor() { }
}
