// Assembly: Firebase.Platform.dll
// Namespace: Firebase.Unity
[Preserve]
internal class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 17737
{
	// Fields
	private static UnitySynchronizationContext _instance; // 0x0
	private Queue<Tuple<SendOrPostCallback, object>> queue; // 0x18
	private UnitySynchronizationContext.SynchronizationContextBehavoir behavior; // 0x20
	private int mainThreadId; // 0x28
	private static Dictionary<int, ManualResetEvent> signalDictionary; // 0x8

	// Methods

	// RVA: 0x2668D50 Offset: 0x2664D50 VA: 0x2668D50
	private void .ctor(GameObject gameObject) { }

	// RVA: 0x2668E7C Offset: 0x2664E7C VA: 0x2668E7C
	public static void Create(GameObject gameObject) { }

	// RVA: 0x2668F20 Offset: 0x2664F20 VA: 0x2668F20
	public static void Destroy() { }

	// RVA: 0x2668F84 Offset: 0x2664F84 VA: 0x2668F84
	private ManualResetEvent GetThreadEvent() { }

	// RVA: 0x26691BC Offset: 0x26651BC VA: 0x26691BC Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x266930C Offset: 0x266530C VA: 0x266930C Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x26694A8 Offset: 0x26654A8 VA: 0x26694A8
	private static void .cctor() { }
}
