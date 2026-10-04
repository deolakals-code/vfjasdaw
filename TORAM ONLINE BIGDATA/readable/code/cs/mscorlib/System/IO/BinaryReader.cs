// Assembly: mscorlib.dll
// Namespace: System.IO
[ComVisible(True)]
public class BinaryReader : IDisposable // TypeDefIndex: 10732
{
	// Fields
	private Stream m_stream; // 0x10
	private byte[] m_buffer; // 0x18
	private Decoder m_decoder; // 0x20
	private byte[] m_charBytes; // 0x28
	private char[] m_singleChar; // 0x30
	private char[] m_charBuffer; // 0x38
	private int m_maxCharsSize; // 0x40
	private bool m_2BytesPerChar; // 0x44
	private bool m_isMemoryStream; // 0x45
	private bool m_leaveOpen; // 0x46

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x2F50A08 Offset: 0x2F4CA08 VA: 0x2F50A08
	public void .ctor(Stream input) { }

	// RVA: 0x2F50D14 Offset: 0x2F4CD14 VA: 0x2F50D14
	public void .ctor(Stream input, Encoding encoding) { }

	// RVA: 0x2F50A78 Offset: 0x2F4CA78 VA: 0x2F50A78
	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x2F50D1C Offset: 0x2F4CD1C VA: 0x2F50D1C Slot: 5
	public virtual Stream get_BaseStream() { }

	// RVA: 0x2F50D24 Offset: 0x2F4CD24 VA: 0x2F50D24 Slot: 6
	public virtual void Close() { }

	// RVA: 0x2F50D34 Offset: 0x2F4CD34 VA: 0x2F50D34 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2F50DE0 Offset: 0x2F4CDE0 VA: 0x2F50DE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F50DF0 Offset: 0x2F4CDF0 VA: 0x2F50DF0 Slot: 8
	public virtual int Read() { }

	// RVA: 0x2F5109C Offset: 0x2F4D09C VA: 0x2F5109C Slot: 9
	public virtual bool ReadBoolean() { }

	// RVA: 0x2F510E4 Offset: 0x2F4D0E4 VA: 0x2F510E4 Slot: 10
	public virtual byte ReadByte() { }

	[CLSCompliant(False)]
	// RVA: 0x2F51118 Offset: 0x2F4D118 VA: 0x2F51118 Slot: 11
	public virtual sbyte ReadSByte() { }

	// RVA: 0x2F51158 Offset: 0x2F4D158 VA: 0x2F51158 Slot: 12
	public virtual char ReadChar() { }

	// RVA: 0x2F5117C Offset: 0x2F4D17C VA: 0x2F5117C Slot: 13
	public virtual short ReadInt16() { }

	[CLSCompliant(False)]
	// RVA: 0x2F511C4 Offset: 0x2F4D1C4 VA: 0x2F511C4 Slot: 14
	public virtual ushort ReadUInt16() { }

	// RVA: 0x2F5120C Offset: 0x2F4D20C VA: 0x2F5120C Slot: 15
	public virtual int ReadInt32() { }

	[CLSCompliant(False)]
	// RVA: 0x2F51300 Offset: 0x2F4D300 VA: 0x2F51300 Slot: 16
	public virtual uint ReadUInt32() { }

	// RVA: 0x2F51370 Offset: 0x2F4D370 VA: 0x2F51370 Slot: 17
	public virtual long ReadInt64() { }

	[CLSCompliant(False)]
	// RVA: 0x2F51420 Offset: 0x2F4D420 VA: 0x2F51420 Slot: 18
	public virtual ulong ReadUInt64() { }

	// RVA: 0x2F514D0 Offset: 0x2F4D4D0 VA: 0x2F514D0 Slot: 19
	public virtual float ReadSingle() { }

	// RVA: 0x2F51500 Offset: 0x2F4D500 VA: 0x2F51500 Slot: 20
	public virtual double ReadDouble() { }

	// RVA: 0x2F51530 Offset: 0x2F4D530 VA: 0x2F51530 Slot: 21
	public virtual Decimal ReadDecimal() { }

	// RVA: 0x2F516C8 Offset: 0x2F4D6C8 VA: 0x2F516C8 Slot: 22
	public virtual string ReadString() { }

	// RVA: 0x2F51A28 Offset: 0x2F4DA28 VA: 0x2F51A28
	private int InternalReadChars(char[] buffer, int index, int count) { }

	// RVA: 0x2F50E08 Offset: 0x2F4CE08 VA: 0x2F50E08
	private int InternalReadOneChar() { }

	// RVA: 0x2F51D2C Offset: 0x2F4DD2C VA: 0x2F51D2C Slot: 23
	public virtual char[] ReadChars(int count) { }

	// RVA: 0x2F51E88 Offset: 0x2F4DE88 VA: 0x2F51E88 Slot: 24
	public virtual int Read(byte[] buffer, int index, int count) { }

	// RVA: 0x2F51FF8 Offset: 0x2F4DFF8 VA: 0x2F51FF8 Slot: 25
	public virtual byte[] ReadBytes(int count) { }

	// RVA: 0x2F52184 Offset: 0x2F4E184 VA: 0x2F52184 Slot: 26
	protected virtual void FillBuffer(int numBytes) { }

	// RVA: 0x2F51988 Offset: 0x2F4D988 VA: 0x2F51988
	protected internal int Read7BitEncodedInt() { }
}
