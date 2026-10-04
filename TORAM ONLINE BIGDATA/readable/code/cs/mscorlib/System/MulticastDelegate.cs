// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[Serializable]
public abstract class MulticastDelegate : Delegate // TypeDefIndex: 9805
{
	// Fields
	private Delegate[] delegates; // 0x78

	// Methods

	// RVA: 0x3035210 Offset: 0x3031210 VA: 0x3035210 Slot: 8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3035214 Offset: 0x3031214 VA: 0x3035214 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x3035370 Offset: 0x3031370 VA: 0x3035370 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: 0x3035374 Offset: 0x3031374 VA: 0x3035374 Slot: 7
	protected override MethodInfo GetMethodImpl() { }

	// RVA: 0x30353BC Offset: 0x30313BC VA: 0x30353BC Slot: 9
	public sealed override Delegate[] GetInvocationList() { }

	// RVA: 0x3035494 Offset: 0x3031494 VA: 0x3035494 Slot: 10
	protected sealed override Delegate CombineImpl(Delegate follow) { }

	// RVA: 0x3035760 Offset: 0x3031760 VA: 0x3035760
	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	// RVA: 0x303588C Offset: 0x303188C VA: 0x303588C Slot: 11
	protected sealed override Delegate RemoveImpl(Delegate value) { }
}
