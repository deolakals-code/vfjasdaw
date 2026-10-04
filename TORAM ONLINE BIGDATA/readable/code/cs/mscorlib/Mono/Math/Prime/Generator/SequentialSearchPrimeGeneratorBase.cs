// Assembly: mscorlib.dll
// Namespace: Mono.Math.Prime.Generator
internal class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 9492
{
	// Methods

	// RVA: 0x2E7F5A4 Offset: 0x2E7B5A4 VA: 0x2E7F5A4 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x2E7F618 Offset: 0x2E7B618 VA: 0x2E7F618 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x2E7F628 Offset: 0x2E7B628 VA: 0x2E7F628 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x2E7F90C Offset: 0x2E7B90C VA: 0x2E7F90C Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x2E7E080 Offset: 0x2E7A080 VA: 0x2E7E080
	public void .ctor() { }
}
