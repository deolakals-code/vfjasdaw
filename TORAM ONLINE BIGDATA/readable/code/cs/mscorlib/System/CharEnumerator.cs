// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public sealed class CharEnumerator : IEnumerator, IEnumerator<char>, IDisposable, ICloneable // TypeDefIndex: 9562
{
	// Fields
	private string _str; // 0x10
	private int _index; // 0x18
	private char _currentElement; // 0x1C

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public char Current { get; }

	// Methods

	// RVA: 0x2F791C0 Offset: 0x2F751C0 VA: 0x2F791C0
	internal void .ctor(string str) { }

	// RVA: 0x2F791FC Offset: 0x2F751FC VA: 0x2F791FC Slot: 9
	public object Clone() { }

	// RVA: 0x2F79204 Offset: 0x2F75204 VA: 0x2F79204 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2F79260 Offset: 0x2F75260 VA: 0x2F79260 Slot: 8
	public void Dispose() { }

	// RVA: 0x2F79280 Offset: 0x2F75280 VA: 0x2F79280 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2F792E4 Offset: 0x2F752E4 VA: 0x2F792E4 Slot: 7
	public char get_Current() { }

	// RVA: 0x2F79380 Offset: 0x2F75380 VA: 0x2F79380 Slot: 6
	public void Reset() { }

	// RVA: 0x2F79390 Offset: 0x2F75390 VA: 0x2F79390
	internal void .ctor() { }
}
