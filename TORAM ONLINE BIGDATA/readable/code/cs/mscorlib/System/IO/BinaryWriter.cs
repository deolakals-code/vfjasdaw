// Assembly: mscorlib.dll
// Namespace: System.IO
[ComVisible(True)]
[Serializable]
public class BinaryWriter : IDisposable // TypeDefIndex: 10733
{
	// Fields
	public static readonly BinaryWriter Null; // 0x0
	protected Stream OutStream; // 0x10
	private byte[] _buffer; // 0x18
	private Encoding _encoding; // 0x20
	private Encoder _encoder; // 0x28
	[OptionalField]
	private bool _leaveOpen; // 0x30
	private byte[] _largeByteBuffer; // 0x38
	private int _maxChars; // 0x40

	// Methods

	// RVA: 0x2F522A0 Offset: 0x2F4E2A0 VA: 0x2F522A0
	protected void .ctor() { }

	// RVA: 0x2F523B8 Offset: 0x2F4E3B8 VA: 0x2F523B8
	public void .ctor(Stream output) { }

	// RVA: 0x2F525D8 Offset: 0x2F4E5D8 VA: 0x2F525D8
	public void .ctor(Stream output, Encoding encoding) { }

	// RVA: 0x2F52430 Offset: 0x2F4E430 VA: 0x2F52430
	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x2F525E0 Offset: 0x2F4E5E0 VA: 0x2F525E0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2F52628 Offset: 0x2F4E628 VA: 0x2F52628 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F52638 Offset: 0x2F4E638 VA: 0x2F52638 Slot: 6
	public virtual void Flush() { }

	// RVA: 0x2F5265C Offset: 0x2F4E65C VA: 0x2F5265C Slot: 7
	public virtual void Write(bool value) { }

	// RVA: 0x2F526AC Offset: 0x2F4E6AC VA: 0x2F526AC Slot: 8
	public virtual void Write(byte value) { }

	// RVA: 0x2F526D0 Offset: 0x2F4E6D0 VA: 0x2F526D0 Slot: 9
	public virtual void Write(byte[] buffer) { }

	// RVA: 0x2F52748 Offset: 0x2F4E748 VA: 0x2F52748 Slot: 10
	public virtual void Write(byte[] buffer, int index, int count) { }

	// RVA: 0x2F5276C Offset: 0x2F4E76C VA: 0x2F5276C Slot: 11
	public virtual void Write(char ch) { }

	// RVA: 0x2F52890 Offset: 0x2F4E890 VA: 0x2F52890 Slot: 12
	public virtual void Write(char[] chars) { }

	// RVA: 0x2F52934 Offset: 0x2F4E934 VA: 0x2F52934 Slot: 13
	public virtual void Write(double value) { }

	// RVA: 0x2F52970 Offset: 0x2F4E970 VA: 0x2F52970 Slot: 14
	public virtual void Write(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F529D8 Offset: 0x2F4E9D8 VA: 0x2F529D8 Slot: 15
	public virtual void Write(ushort value) { }

	// RVA: 0x2F52A40 Offset: 0x2F4EA40 VA: 0x2F52A40 Slot: 16
	public virtual void Write(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F52AE0 Offset: 0x2F4EAE0 VA: 0x2F52AE0 Slot: 17
	public virtual void Write(uint value) { }

	// RVA: 0x2F52B80 Offset: 0x2F4EB80 VA: 0x2F52B80 Slot: 18
	public virtual void Write(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F52C90 Offset: 0x2F4EC90 VA: 0x2F52C90 Slot: 19
	public virtual void Write(ulong value) { }

	// RVA: 0x2F52DA0 Offset: 0x2F4EDA0 VA: 0x2F52DA0 Slot: 20
	public virtual void Write(float value) { }

	// RVA: 0x2F52DDC Offset: 0x2F4EDDC VA: 0x2F52DDC Slot: 21
	public virtual void Write(string value) { }

	// RVA: 0x2F530A0 Offset: 0x2F4F0A0 VA: 0x2F530A0
	protected void Write7BitEncodedInt(int value) { }

	// RVA: 0x2F53100 Offset: 0x2F4F100 VA: 0x2F53100
	private static void .cctor() { }
}
