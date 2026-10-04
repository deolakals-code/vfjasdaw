// Assembly: System.dll
// Namespace: 
private sealed class GroupCollection.Enumerator : IEnumerator<Group>, IDisposable, IEnumerator // TypeDefIndex: 14065
{
	// Fields
	private readonly GroupCollection _collection; // 0x10
	private int _index; // 0x18

	// Properties
	public Group Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x346AA98 Offset: 0x3466A98 VA: 0x346AA98
	internal void .ctor(GroupCollection collection) { }

	// RVA: 0x346B7EC Offset: 0x34677EC VA: 0x346B7EC Slot: 6
	public bool MoveNext() { }

	// RVA: 0x346B830 Offset: 0x3467830 VA: 0x346B830 Slot: 4
	public Group get_Current() { }

	// RVA: 0x346B8BC Offset: 0x34678BC VA: 0x346B8BC Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x346B8C0 Offset: 0x34678C0 VA: 0x346B8C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x346B8CC Offset: 0x34678CC VA: 0x346B8CC Slot: 5
	private void System.IDisposable.Dispose() { }
}
