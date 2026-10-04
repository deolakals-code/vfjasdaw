// Assembly: mscorlib.dll
// Namespace: System
internal class TermInfoReader // TypeDefIndex: 9819
{
	// Fields
	private int boolSize; // 0x10
	private int numSize; // 0x14
	private int strOffsets; // 0x18
	private byte[] buffer; // 0x20
	private int booleansOffset; // 0x28
	private int intOffset; // 0x2C

	// Methods

	// RVA: 0x3037364 Offset: 0x3033364 VA: 0x3037364
	public void .ctor(string term, string filename) { }

	// RVA: 0x3037638 Offset: 0x3033638 VA: 0x3037638
	public void .ctor(string term, byte[] buffer) { }

	// RVA: 0x303D4D0 Offset: 0x30394D0 VA: 0x303D4D0
	private void DetermineVersion(short magic) { }

	// RVA: 0x303D3DC Offset: 0x30393DC VA: 0x303D3DC
	private void ReadHeader(byte[] buffer, ref int position) { }

	// RVA: 0x303D49C Offset: 0x303949C VA: 0x303D49C
	private void ReadNames(byte[] buffer, ref int position) { }

	// RVA: 0x303800C Offset: 0x303400C VA: 0x303800C
	public int Get(TermInfoNumbers number) { }

	// RVA: 0x3037F7C Offset: 0x3033F7C VA: 0x3037F7C
	public string Get(TermInfoStrings tstr) { }

	// RVA: 0x303BFB4 Offset: 0x3037FB4 VA: 0x303BFB4
	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	// RVA: 0x303D578 Offset: 0x3039578 VA: 0x303D578
	private short GetInt16(byte[] buffer, int offset) { }

	// RVA: 0x303D5C8 Offset: 0x30395C8 VA: 0x303D5C8
	private string GetString(byte[] buffer, int offset) { }

	// RVA: 0x303D644 Offset: 0x3039644 VA: 0x303D644
	private byte[] GetStringBytes(byte[] buffer, int offset) { }
}
