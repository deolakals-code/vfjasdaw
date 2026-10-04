// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: Asobimo.Plugin
public abstract class ClientStateBase : MonoBehaviour // TypeDefIndex: 17139
{
	// Fields
	protected readonly BatteryInfo batteryInfo; // 0x20
	protected readonly NetworkInfo networkInfo; // 0x28
	protected IClientStateListener clientStateListener; // 0x30

	// Methods

	// RVA: 0x1710B9C Offset: 0x170CB9C VA: 0x1710B9C Slot: 4
	public virtual void StartBatteryMonitoring() { }

	// RVA: 0x1710BA0 Offset: 0x170CBA0 VA: 0x1710BA0 Slot: 5
	public virtual void StartNetworkMonitoring() { }

	// RVA: 0x1710BA4 Offset: 0x170CBA4 VA: 0x1710BA4 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x1710BA8 Offset: 0x170CBA8 VA: 0x1710BA8
	public void SetListener(IClientStateListener listener) { }

	// RVA: 0x170A434 Offset: 0x1706434 VA: 0x170A434
	protected void .ctor() { }
}
