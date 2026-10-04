// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Lifetime
internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 10229
{
	// Fields
	private DateTime _leaseExpireTime; // 0x18
	private LeaseState _currentState; // 0x20
	private TimeSpan _initialLeaseTime; // 0x28
	private TimeSpan _renewOnCallTime; // 0x30
	private TimeSpan _sponsorshipTimeout; // 0x38
	private ArrayList _sponsors; // 0x40
	private Queue _renewingSponsors; // 0x48
	private Lease.RenewalDelegate _renewalDelegate; // 0x50

	// Properties
	public TimeSpan CurrentLeaseTime { get; }
	public LeaseState CurrentState { get; }
	public TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: 0x2EDCF38 Offset: 0x2ED8F38 VA: 0x2EDCF38
	public void .ctor() { }

	// RVA: 0x2EE2E30 Offset: 0x2EDEE30 VA: 0x2EE2E30 Slot: 6
	public TimeSpan get_CurrentLeaseTime() { }

	// RVA: 0x2EE2E98 Offset: 0x2EDEE98 VA: 0x2EE2E98 Slot: 7
	public LeaseState get_CurrentState() { }

	// RVA: 0x2EE2EA0 Offset: 0x2EDEEA0 VA: 0x2EE2EA0
	public void Activate() { }

	// RVA: 0x2EE2EAC Offset: 0x2EDEEAC VA: 0x2EE2EAC Slot: 8
	public TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x2EE2EB4 Offset: 0x2EDEEB4 VA: 0x2EE2EB4 Slot: 9
	public TimeSpan Renew(TimeSpan renewalTime) { }

	// RVA: 0x2EE2F40 Offset: 0x2EDEF40 VA: 0x2EE2F40 Slot: 10
	public void Unregister(ISponsor obj) { }

	// RVA: 0x2EE3084 Offset: 0x2EDF084 VA: 0x2EE3084
	internal void UpdateState() { }

	// RVA: 0x2EE3220 Offset: 0x2EDF220 VA: 0x2EE3220
	private void CheckNextSponsor() { }

	// RVA: 0x2EE35B4 Offset: 0x2EDF5B4 VA: 0x2EE35B4
	private void ProcessSponsorResponse(object state, bool timedOut) { }
}
