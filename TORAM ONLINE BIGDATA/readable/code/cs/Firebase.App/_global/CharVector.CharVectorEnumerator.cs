// Assembly: Firebase.App.dll
// Namespace: 
public sealed class CharVector.CharVectorEnumerator : IEnumerator, IEnumerator<byte>, IDisposable // TypeDefIndex: 17211
{
	// Fields
	private CharVector collectionRef; // 0x10
	private int currentIndex; // 0x18
	private object currentObject; // 0x20
	private int currentSize; // 0x28

	// Properties
	public byte Current { get; }
	private object global::System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x2657068 Offset: 0x2653068 VA: 0x2657068
	public void .ctor(CharVector collection) { }

	// RVA: 0x2657CA0 Offset: 0x2653CA0 VA: 0x2657CA0 Slot: 7
	public byte get_Current() { }

	// RVA: 0x2657DB0 Offset: 0x2653DB0 VA: 0x2657DB0 Slot: 5
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2657E14 Offset: 0x2653E14 VA: 0x2657E14 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2657ED0 Offset: 0x2653ED0 VA: 0x2657ED0 Slot: 6
	public void Reset() { }

	// RVA: 0x2657F68 Offset: 0x2653F68 VA: 0x2657F68 Slot: 8
	public void Dispose() { }
}
