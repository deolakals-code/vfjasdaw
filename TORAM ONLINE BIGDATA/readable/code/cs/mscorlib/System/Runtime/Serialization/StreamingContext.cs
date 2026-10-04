// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[IsReadOnly]
[ComVisible(True)]
[Serializable]
public struct StreamingContext // TypeDefIndex: 10371
{
	// Fields
	internal readonly object m_additionalContext; // 0x0
	internal readonly StreamingContextStates m_state; // 0x8

	// Properties
	public object Context { get; }
	public StreamingContextStates State { get; }

	// Methods

	// RVA: 0x2F05BC4 Offset: 0x2F01BC4 VA: 0x2F05BC4
	public void .ctor(StreamingContextStates state) { }

	// RVA: 0x2F05BD4 Offset: 0x2F01BD4 VA: 0x2F05BD4
	public void .ctor(StreamingContextStates state, object additional) { }

	// RVA: 0x2F05BE4 Offset: 0x2F01BE4 VA: 0x2F05BE4
	public object get_Context() { }

	// RVA: 0x2F05BEC Offset: 0x2F01BEC VA: 0x2F05BEC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F05C9C Offset: 0x2F01C9C VA: 0x2F05C9C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F05CA4 Offset: 0x2F01CA4 VA: 0x2F05CA4
	public StreamingContextStates get_State() { }
}
