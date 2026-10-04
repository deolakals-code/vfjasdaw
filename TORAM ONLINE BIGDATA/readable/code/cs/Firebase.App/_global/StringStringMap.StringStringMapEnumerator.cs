// Assembly: Firebase.App.dll
// Namespace: 
public sealed class StringStringMap.StringStringMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<string, string>>, IDisposable // TypeDefIndex: 17207
{
	// Fields
	private StringStringMap collectionRef; // 0x10
	private IList<string> keyCollection; // 0x18
	private int currentIndex; // 0x20
	private object currentObject; // 0x28
	private int currentSize; // 0x30

	// Properties
	public KeyValuePair<string, string> Current { get; }
	private object global::System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x2654370 Offset: 0x2650370 VA: 0x2654370
	public void .ctor(StringStringMap collection) { }

	// RVA: 0x2653A4C Offset: 0x264FA4C VA: 0x2653A4C Slot: 7
	public KeyValuePair<string, string> get_Current() { }

	// RVA: 0x2654C98 Offset: 0x2650C98 VA: 0x2654C98 Slot: 5
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2653B5C Offset: 0x264FB5C VA: 0x2653B5C Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2654CFC Offset: 0x2650CFC VA: 0x2654CFC Slot: 6
	public void Reset() { }

	// RVA: 0x2654D94 Offset: 0x2650D94 VA: 0x2654D94 Slot: 8
	public void Dispose() { }
}
