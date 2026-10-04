// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
public abstract class RegexRunner // TypeDefIndex: 14091
{
	// Fields
	protected internal int runtextbeg; // 0x10
	protected internal int runtextend; // 0x14
	protected internal int runtextstart; // 0x18
	protected internal string runtext; // 0x20
	protected internal int runtextpos; // 0x28
	protected internal int[] runtrack; // 0x30
	protected internal int runtrackpos; // 0x38
	protected internal int[] runstack; // 0x40
	protected internal int runstackpos; // 0x48
	protected internal int[] runcrawl; // 0x50
	protected internal int runcrawlpos; // 0x58
	protected internal int runtrackcount; // 0x5C
	protected internal Match runmatch; // 0x60
	protected internal Regex runregex; // 0x68
	private int _timeout; // 0x70
	private bool _ignoreTimeout; // 0x74
	private int _timeoutOccursAt; // 0x78
	private const int TimeoutCheckFrequency = 1000;
	private int _timeoutChecksToSkip; // 0x7C

	// Methods

	// RVA: 0x347A66C Offset: 0x347666C VA: 0x347A66C
	protected internal void .ctor() { }

	// RVA: 0x3484604 Offset: 0x3480604 VA: 0x3484604
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x3484954 Offset: 0x3480954 VA: 0x3484954
	private void StartTimeoutWatch() { }

	// RVA: 0x347C730 Offset: 0x3478730 VA: 0x347C730
	protected void CheckTimeout() { }

	// RVA: 0x3484C04 Offset: 0x3480C04 VA: 0x3484C04
	private void DoCheckTimeout() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Go();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool FindFirstChar();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitTrackCount();

	// RVA: 0x3484988 Offset: 0x3480988 VA: 0x3484988
	private void InitMatch() { }

	// RVA: 0x3484BAC Offset: 0x3480BAC VA: 0x3484BAC
	private Match TidyMatch(bool quick) { }

	// RVA: 0x347A790 Offset: 0x3476790 VA: 0x347A790
	protected void EnsureStorage() { }

	// RVA: 0x347C928 Offset: 0x3478928 VA: 0x347C928
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x347CA28 Offset: 0x3478A28 VA: 0x347CA28
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x3484D7C Offset: 0x3480D7C VA: 0x3484D7C
	protected void DoubleTrack() { }

	// RVA: 0x3484CD0 Offset: 0x3480CD0 VA: 0x3484CD0
	protected void DoubleStack() { }

	// RVA: 0x3484E28 Offset: 0x3480E28 VA: 0x3484E28
	protected void DoubleCrawl() { }

	// RVA: 0x3484ED4 Offset: 0x3480ED4 VA: 0x3484ED4
	protected void Crawl(int i) { }

	// RVA: 0x3484F30 Offset: 0x3480F30 VA: 0x3484F30
	protected int Popcrawl() { }

	// RVA: 0x347C904 Offset: 0x3478904 VA: 0x347C904
	protected int Crawlpos() { }

	// RVA: 0x347C874 Offset: 0x3478874 VA: 0x347C874
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x347C760 Offset: 0x3478760 VA: 0x347C760
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x347C8D4 Offset: 0x34788D4 VA: 0x347C8D4
	protected void Uncapture() { }

	// RVA: 0x347C740 Offset: 0x3478740 VA: 0x347C740
	protected bool IsMatched(int cap) { }

	// RVA: 0x347CB28 Offset: 0x3478B28 VA: 0x347CB28
	protected int MatchIndex(int cap) { }

	// RVA: 0x347CB48 Offset: 0x3478B48 VA: 0x347CB48
	protected int MatchLength(int cap) { }
}
