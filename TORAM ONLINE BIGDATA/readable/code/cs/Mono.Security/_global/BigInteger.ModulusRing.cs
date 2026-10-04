// Assembly: Mono.Security.dll
// Namespace: 
public sealed class BigInteger.ModulusRing // TypeDefIndex: 16929
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x2E62700 Offset: 0x2E5E700 VA: 0x2E62700
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x2E62A34 Offset: 0x2E5EA34 VA: 0x2E62A34
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x2E63088 Offset: 0x2E5F088 VA: 0x2E63088
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x2E63204 Offset: 0x2E5F204 VA: 0x2E63204
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x2E62800 Offset: 0x2E5E800 VA: 0x2E62800
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliant(False)]
	// RVA: 0x2E633B8 Offset: 0x2E5F3B8 VA: 0x2E633B8
	public BigInteger Pow(uint b, BigInteger exp) { }
}
