// Assembly: System.dll
// Namespace: 
[Serializable]
private sealed class CaptureCollection.Enumerator : IEnumerator<Capture>, IDisposable, IEnumerator // TypeDefIndex: 14061
{
	// Fields
	private readonly CaptureCollection _collection; // 0x10
	private int _index; // 0x18

	// Properties
	public Capture Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x3469A48 Offset: 0x3465A48 VA: 0x3469A48
	internal void .ctor(CaptureCollection collection) { }

	// RVA: 0x346A5D4 Offset: 0x34665D4 VA: 0x346A5D4 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x346A614 Offset: 0x3466614 VA: 0x346A614 Slot: 4
	public Capture get_Current() { }

	// RVA: 0x346A688 Offset: 0x3466688 VA: 0x346A688 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x346A68C Offset: 0x346668C VA: 0x346A68C Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x346A698 Offset: 0x3466698 VA: 0x346A698 Slot: 5
	private void System.IDisposable.Dispose() { }
}
