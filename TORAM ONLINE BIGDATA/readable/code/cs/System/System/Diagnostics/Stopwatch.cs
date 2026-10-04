// Assembly: System.dll
// Namespace: System.Diagnostics
public class Stopwatch // TypeDefIndex: 14106
{
	// Fields
	public static readonly long Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private long elapsed; // 0x10
	private long started; // 0x18
	private bool is_running; // 0x20

	// Properties
	public TimeSpan Elapsed { get; }
	public long ElapsedMilliseconds { get; }
	public long ElapsedTicks { get; }

	// Methods

	// RVA: 0x34895D0 Offset: 0x34855D0 VA: 0x34895D0
	public static long GetTimestamp() { }

	// RVA: 0x34895D4 Offset: 0x34855D4 VA: 0x34895D4
	public void .ctor() { }

	// RVA: 0x34895DC Offset: 0x34855DC VA: 0x34895DC
	public TimeSpan get_Elapsed() { }

	// RVA: 0x3489744 Offset: 0x3485744 VA: 0x3489744
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x34896D4 Offset: 0x34856D4 VA: 0x34896D4
	public long get_ElapsedTicks() { }

	// RVA: 0x3489888 Offset: 0x3485888 VA: 0x3489888
	public void Reset() { }

	// RVA: 0x3489894 Offset: 0x3485894 VA: 0x3489894
	public void Start() { }

	// RVA: 0x34898FC Offset: 0x34858FC VA: 0x34898FC
	public void Stop() { }

	// RVA: 0x3489974 Offset: 0x3485974 VA: 0x3489974
	public void Restart() { }

	// RVA: 0x34899D4 Offset: 0x34859D4 VA: 0x34899D4
	private static void .cctor() { }
}
