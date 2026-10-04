// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
public class NetworkSimulationSet // TypeDefIndex: 17006
{
	// Fields
	private bool isSimulationEnabled; // 0x10
	private int outgoingLag; // 0x14
	private int outgoingJitter; // 0x18
	private int outgoingLossPercentage; // 0x1C
	private int incomingLag; // 0x20
	private int incomingJitter; // 0x24
	private int incomingLossPercentage; // 0x28
	internal PeerBase peerBase; // 0x30
	private Thread netSimThread; // 0x38
	public readonly ManualResetEvent NetSimManualResetEvent; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <LostPackagesOut>k__BackingField; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <LostPackagesIn>k__BackingField; // 0x4C

	// Properties
	protected internal bool IsSimulationEnabled { get; set; }
	public int OutgoingLag { get; }
	public int OutgoingJitter { get; }
	public int OutgoingLossPercentage { get; }
	public int IncomingLag { get; }
	public int IncomingJitter { get; }
	public int IncomingLossPercentage { get; }
	public int LostPackagesOut { get; set; }
	public int LostPackagesIn { get; set; }

	// Methods

	// RVA: 0x3103590 Offset: 0x30FF590 VA: 0x3103590
	protected internal bool get_IsSimulationEnabled() { }

	// RVA: 0x310D634 Offset: 0x3109634 VA: 0x310D634
	protected internal void set_IsSimulationEnabled(bool value) { }

	// RVA: 0x310DD28 Offset: 0x3109D28 VA: 0x310DD28
	public int get_OutgoingLag() { }

	// RVA: 0x310DD30 Offset: 0x3109D30 VA: 0x310DD30
	public int get_OutgoingJitter() { }

	// RVA: 0x310DD38 Offset: 0x3109D38 VA: 0x310DD38
	public int get_OutgoingLossPercentage() { }

	// RVA: 0x310DD40 Offset: 0x3109D40 VA: 0x310DD40
	public int get_IncomingLag() { }

	// RVA: 0x310DD48 Offset: 0x3109D48 VA: 0x310DD48
	public int get_IncomingJitter() { }

	// RVA: 0x310DD50 Offset: 0x3109D50 VA: 0x310DD50
	public int get_IncomingLossPercentage() { }

	[CompilerGenerated]
	// RVA: 0x310DD58 Offset: 0x3109D58 VA: 0x310DD58
	public int get_LostPackagesOut() { }

	[CompilerGenerated]
	// RVA: 0x310DD60 Offset: 0x3109D60 VA: 0x310DD60
	internal void set_LostPackagesOut(int value) { }

	[CompilerGenerated]
	// RVA: 0x310DD68 Offset: 0x3109D68 VA: 0x310DD68
	public int get_LostPackagesIn() { }

	[CompilerGenerated]
	// RVA: 0x310DD70 Offset: 0x3109D70 VA: 0x310DD70
	internal void set_LostPackagesIn(int value) { }

	// RVA: 0x310DD78 Offset: 0x3109D78 VA: 0x310DD78 Slot: 3
	public override string ToString() { }

	// RVA: 0x310E04C Offset: 0x310A04C VA: 0x310E04C
	public void .ctor() { }
}
