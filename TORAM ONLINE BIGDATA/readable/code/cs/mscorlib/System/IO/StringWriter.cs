// Assembly: mscorlib.dll
// Namespace: System.IO
[ComVisible(True)]
[Serializable]
public class StringWriter : TextWriter // TypeDefIndex: 10735
{
	// Fields
	private static UnicodeEncoding m_encoding; // 0x0
	private StringBuilder _sb; // 0x30
	private bool _isOpen; // 0x38

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x2F535E8 Offset: 0x2F4F5E8 VA: 0x2F535E8
	public void .ctor() { }

	// RVA: 0x2F5376C Offset: 0x2F4F76C VA: 0x2F5376C
	public void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x2F537D8 Offset: 0x2F4F7D8 VA: 0x2F537D8
	public void .ctor(StringBuilder sb) { }

	// RVA: 0x2F5367C Offset: 0x2F4F67C VA: 0x2F5367C
	public void .ctor(StringBuilder sb, IFormatProvider formatProvider) { }

	// RVA: 0x2F53848 Offset: 0x2F4F848 VA: 0x2F53848 Slot: 8
	public override void Close() { }

	// RVA: 0x2F53858 Offset: 0x2F4F858 VA: 0x2F53858 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F53868 Offset: 0x2F4F868 VA: 0x2F53868 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x2F5391C Offset: 0x2F4F91C VA: 0x2F5391C Slot: 13
	public override void Write(char value) { }

	// RVA: 0x2F53944 Offset: 0x2F4F944 VA: 0x2F53944 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x2F53AB8 Offset: 0x2F4FAB8 VA: 0x2F53AB8 Slot: 16
	public override void Write(string value) { }

	// RVA: 0x2F53AEC Offset: 0x2F4FAEC VA: 0x2F53AEC Slot: 3
	public override string ToString() { }
}
