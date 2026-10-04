// Assembly: mscorlib.dll
// Namespace: 
internal sealed class BigInteger.ModulusRing // TypeDefIndex: 9485
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x2E7DE30 Offset: 0x2E79E30 VA: 0x2E7DE30
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x2E7E1B0 Offset: 0x2E7A1B0 VA: 0x2E7E1B0
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x2E7E804 Offset: 0x2E7A804 VA: 0x2E7E804
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x2E7E980 Offset: 0x2E7A980 VA: 0x2E7E980
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x2E7DF30 Offset: 0x2E79F30 VA: 0x2E7DF30
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0x2E7EB34 Offset: 0x2E7AB34 VA: 0x2E7EB34
	public BigInteger Pow(uint b, BigInteger exp) { }
}
