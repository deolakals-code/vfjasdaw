// Assembly: Mono.Security.dll
// Namespace: Mono.Math.Prime.Generator
public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 16936
{
	// Methods

	// RVA: 0x2E63C50 Offset: 0x2E5FC50 VA: 0x2E63C50 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x2E63CC4 Offset: 0x2E5FCC4 VA: 0x2E63CC4 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x2E63CD4 Offset: 0x2E5FCD4 VA: 0x2E63CD4 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x2E63FB8 Offset: 0x2E5FFB8 VA: 0x2E63FB8 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x2E62904 Offset: 0x2E5E904 VA: 0x2E62904
	public void .ctor() { }
}
