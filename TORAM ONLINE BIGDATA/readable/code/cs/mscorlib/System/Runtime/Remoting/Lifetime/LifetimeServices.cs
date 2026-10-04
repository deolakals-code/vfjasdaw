// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
public sealed class LifetimeServices // TypeDefIndex: 10233
{
	// Fields
	private static TimeSpan _leaseManagerPollTime; // 0x0
	private static TimeSpan _leaseTime; // 0x8
	private static TimeSpan _renewOnCallTime; // 0x10
	private static TimeSpan _sponsorshipTimeout; // 0x18
	private static LeaseManager _leaseManager; // 0x20

	// Properties
	public static TimeSpan LeaseManagerPollTime { get; set; }
	public static TimeSpan LeaseTime { get; set; }
	public static TimeSpan RenewOnCallTime { get; set; }
	public static TimeSpan SponsorshipTimeout { get; set; }

	// Methods

	// RVA: 0x2EE427C Offset: 0x2EE027C VA: 0x2EE427C
	private static void .cctor() { }

	// RVA: 0x2EE437C Offset: 0x2EE037C VA: 0x2EE437C
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x2ED6C78 Offset: 0x2ED2C78 VA: 0x2ED6C78
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x2EE43D4 Offset: 0x2EE03D4 VA: 0x2EE43D4
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x2EE442C Offset: 0x2EE042C VA: 0x2EE442C
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x2EE4488 Offset: 0x2EE0488 VA: 0x2EE4488
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x2EE44E0 Offset: 0x2EE04E0 VA: 0x2EE44E0
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x2EE453C Offset: 0x2EE053C VA: 0x2EE453C
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x2EE4594 Offset: 0x2EE0594 VA: 0x2EE4594
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x2EDD090 Offset: 0x2ED9090 VA: 0x2EDD090
	internal static void TrackLifetime(ServerIdentity identity) { }
}
