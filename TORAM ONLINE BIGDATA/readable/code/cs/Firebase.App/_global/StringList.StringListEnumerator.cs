// Assembly: Firebase.App.dll
// Namespace: 
public sealed class StringList.StringListEnumerator : IEnumerator, IEnumerator<string>, IDisposable // TypeDefIndex: 17209
{
	// Fields
	private StringList collectionRef; // 0x10
	private int currentIndex; // 0x18
	private object currentObject; // 0x20
	private int currentSize; // 0x28

	// Properties
	public string Current { get; }
	private object global::System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x2655740 Offset: 0x2651740 VA: 0x2655740
	public void .ctor(StringList collection) { }

	// RVA: 0x2656430 Offset: 0x2652430 VA: 0x2656430 Slot: 7
	public string get_Current() { }

	// RVA: 0x2656530 Offset: 0x2652530 VA: 0x2656530 Slot: 5
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2656534 Offset: 0x2652534 VA: 0x2656534 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x26565AC Offset: 0x26525AC VA: 0x26565AC Slot: 6
	public void Reset() { }

	// RVA: 0x2656644 Offset: 0x2652644 VA: 0x2656644 Slot: 8
	public void Dispose() { }
}
