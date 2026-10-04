// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Lifetime
internal class LeaseManager // TypeDefIndex: 10230
{
	// Fields
	private ArrayList _objects; // 0x10
	private Timer _timer; // 0x18

	// Methods

	// RVA: 0x2EE37E4 Offset: 0x2EDF7E4 VA: 0x2EE37E4
	public void SetPollTime(TimeSpan timeSpan) { }

	// RVA: 0x2EE38D8 Offset: 0x2EDF8D8 VA: 0x2EE38D8
	public void TrackLifetime(ServerIdentity identity) { }

	// RVA: 0x2EE3A08 Offset: 0x2EDFA08 VA: 0x2EE3A08
	public void StartManager() { }

	// RVA: 0x2EE3B64 Offset: 0x2EDFB64 VA: 0x2EE3B64
	public void StopManager() { }

	// RVA: 0x2EE3B94 Offset: 0x2EDFB94 VA: 0x2EE3B94
	public void ManageLeases(object state) { }

	// RVA: 0x2EE3DE0 Offset: 0x2EDFDE0 VA: 0x2EE3DE0
	public void .ctor() { }
}
