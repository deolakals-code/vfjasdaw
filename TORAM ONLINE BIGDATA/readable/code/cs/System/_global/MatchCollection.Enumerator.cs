// Assembly: System.dll
// Namespace: 
[Serializable]
private sealed class MatchCollection.Enumerator : IEnumerator<Match>, IDisposable, IEnumerator // TypeDefIndex: 14069
{
	// Fields
	private readonly MatchCollection _collection; // 0x10
	private int _index; // 0x18

	// Properties
	public Match Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x346CC64 Offset: 0x3468C64 VA: 0x346CC64
	internal void .ctor(MatchCollection collection) { }

	// RVA: 0x346D514 Offset: 0x3469514 VA: 0x346D514 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x346D564 Offset: 0x3469564 VA: 0x346D564 Slot: 4
	public Match get_Current() { }

	// RVA: 0x346D5CC Offset: 0x34695CC VA: 0x346D5CC Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x346D5D0 Offset: 0x34695D0 VA: 0x346D5D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x346D5DC Offset: 0x34695DC VA: 0x346D5DC Slot: 5
	private void System.IDisposable.Dispose() { }
}
