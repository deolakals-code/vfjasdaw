// Assembly: mscorlib.dll
// Namespace: System.Globalization
internal class Bootstring // TypeDefIndex: 10830
{
	// Fields
	private readonly char delimiter; // 0x10
	private readonly int base_num; // 0x14
	private readonly int tmin; // 0x18
	private readonly int tmax; // 0x1C
	private readonly int skew; // 0x20
	private readonly int damp; // 0x24
	private readonly int initial_bias; // 0x28
	private readonly int initial_n; // 0x2C

	// Methods

	// RVA: 0x2FB04F8 Offset: 0x2FAC4F8 VA: 0x2FB04F8
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x2FAFAB4 Offset: 0x2FABAB4 VA: 0x2FAFAB4
	public string Encode(string s, int offset) { }

	// RVA: 0x2FB0564 Offset: 0x2FAC564 VA: 0x2FB0564
	private char EncodeDigit(int d) { }

	// RVA: 0x2FB05F4 Offset: 0x2FAC5F4 VA: 0x2FB05F4
	private int DecodeDigit(char c) { }

	// RVA: 0x2FB057C Offset: 0x2FAC57C VA: 0x2FB057C
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x2FB0220 Offset: 0x2FAC220 VA: 0x2FB0220
	public string Decode(string s, int offset) { }
}
