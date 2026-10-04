// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi
public class PlayerStats // TypeDefIndex: 16830
{
	// Fields
	private static float UNSET_VALUE; // 0x0
	private bool mValid; // 0x10
	private int mNumberOfPurchases; // 0x14
	private float mAvgSessionLength; // 0x18
	private int mDaysSinceLastPlayed; // 0x1C
	private int mNumberOfSessions; // 0x20
	private float mSessPercentile; // 0x24
	private float mSpendPercentile; // 0x28
	private float mSpendProbability; // 0x2C
	private float mChurnProbability; // 0x30
	private float mHighSpenderProbability; // 0x34
	private float mTotalSpendNext28Days; // 0x38

	// Properties
	public bool Valid { get; }
	public int NumberOfPurchases { get; }
	public float AvgSessionLength { get; }
	public int DaysSinceLastPlayed { get; }
	public int NumberOfSessions { get; }
	public float SessPercentile { get; }
	public float SpendPercentile { get; }
	public float SpendProbability { get; }
	public float ChurnProbability { get; }
	public float HighSpenderProbability { get; }
	public float TotalSpendNext28Days { get; }

	// Methods

	// RVA: 0x2E33224 Offset: 0x2E2F224 VA: 0x2E33224
	public void .ctor(int numberOfPurchases, float avgSessionLength, int daysSinceLastPlayed, int numberOfSessions, float sessPercentile, float spendPercentile, float spendProbability, float churnProbability, float highSpenderProbability, float totalSpendNext28Days) { }

	// RVA: 0x2E32854 Offset: 0x2E2E854 VA: 0x2E32854
	public void .ctor() { }

	// RVA: 0x2E332B4 Offset: 0x2E2F2B4 VA: 0x2E332B4
	public bool get_Valid() { }

	// RVA: 0x2E332BC Offset: 0x2E2F2BC VA: 0x2E332BC
	public int get_NumberOfPurchases() { }

	// RVA: 0x2E332C4 Offset: 0x2E2F2C4 VA: 0x2E332C4
	public float get_AvgSessionLength() { }

	// RVA: 0x2E332CC Offset: 0x2E2F2CC VA: 0x2E332CC
	public int get_DaysSinceLastPlayed() { }

	// RVA: 0x2E332D4 Offset: 0x2E2F2D4 VA: 0x2E332D4
	public int get_NumberOfSessions() { }

	// RVA: 0x2E332DC Offset: 0x2E2F2DC VA: 0x2E332DC
	public float get_SessPercentile() { }

	// RVA: 0x2E332E4 Offset: 0x2E2F2E4 VA: 0x2E332E4
	public float get_SpendPercentile() { }

	// RVA: 0x2E332EC Offset: 0x2E2F2EC VA: 0x2E332EC
	public float get_SpendProbability() { }

	// RVA: 0x2E332F4 Offset: 0x2E2F2F4 VA: 0x2E332F4
	public float get_ChurnProbability() { }

	// RVA: 0x2E332FC Offset: 0x2E2F2FC VA: 0x2E332FC
	public float get_HighSpenderProbability() { }

	// RVA: 0x2E33304 Offset: 0x2E2F304 VA: 0x2E33304
	public float get_TotalSpendNext28Days() { }

	// RVA: 0x2E3330C Offset: 0x2E2F30C VA: 0x2E3330C
	public bool HasNumberOfPurchases() { }

	// RVA: 0x2E3338C Offset: 0x2E2F38C VA: 0x2E3338C
	public bool HasAvgSessionLength() { }

	// RVA: 0x2E333FC Offset: 0x2E2F3FC VA: 0x2E333FC
	public bool HasDaysSinceLastPlayed() { }

	// RVA: 0x2E3347C Offset: 0x2E2F47C VA: 0x2E3347C
	public bool HasNumberOfSessions() { }

	// RVA: 0x2E334FC Offset: 0x2E2F4FC VA: 0x2E334FC
	public bool HasSessPercentile() { }

	// RVA: 0x2E3356C Offset: 0x2E2F56C VA: 0x2E3356C
	public bool HasSpendPercentile() { }

	// RVA: 0x2E335DC Offset: 0x2E2F5DC VA: 0x2E335DC
	public bool HasChurnProbability() { }

	// RVA: 0x2E3364C Offset: 0x2E2F64C VA: 0x2E3364C
	public bool HasHighSpenderProbability() { }

	// RVA: 0x2E336BC Offset: 0x2E2F6BC VA: 0x2E336BC
	public bool HasTotalSpendNext28Days() { }

	// RVA: 0x2E3372C Offset: 0x2E2F72C VA: 0x2E3372C
	private static void .cctor() { }
}
