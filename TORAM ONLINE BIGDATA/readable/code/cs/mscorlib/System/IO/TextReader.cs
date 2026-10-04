// Assembly: mscorlib.dll
// Namespace: System.IO
[Serializable]
public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 10704
{
	// Fields
	public static readonly TextReader Null; // 0x0

	// Methods

	// RVA: 0x2F438B8 Offset: 0x2F3F8B8 VA: 0x2F438B8
	protected void .ctor() { }

	// RVA: 0x2F46760 Offset: 0x2F42760 VA: 0x2F46760 Slot: 7
	public virtual void Close() { }

	// RVA: 0x2F467CC Offset: 0x2F427CC VA: 0x2F467CC Slot: 6
	public void Dispose() { }

	// RVA: 0x2F46838 Offset: 0x2F42838 VA: 0x2F46838 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2F4683C Offset: 0x2F4283C VA: 0x2F4683C Slot: 9
	public virtual int Peek() { }

	// RVA: 0x2F46844 Offset: 0x2F42844 VA: 0x2F46844 Slot: 10
	public virtual int Read() { }

	// RVA: 0x2F4684C Offset: 0x2F4284C VA: 0x2F4684C Slot: 11
	public virtual int Read(char[] buffer, int index, int count) { }

	// RVA: 0x2F469FC Offset: 0x2F429FC VA: 0x2F469FC Slot: 12
	public virtual string ReadToEnd() { }

	// RVA: 0x2F46AF8 Offset: 0x2F42AF8 VA: 0x2F46AF8 Slot: 13
	public virtual string ReadLine() { }

	// RVA: 0x2F46BF0 Offset: 0x2F42BF0 VA: 0x2F46BF0
	public static TextReader Synchronized(TextReader reader) { }

	// RVA: 0x2F46D18 Offset: 0x2F42D18 VA: 0x2F46D18
	private static void .cctor() { }
}
