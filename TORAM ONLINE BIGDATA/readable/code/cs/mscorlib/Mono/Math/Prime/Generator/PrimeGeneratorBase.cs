// Assembly: mscorlib.dll
// Namespace: Mono.Math.Prime.Generator
internal abstract class PrimeGeneratorBase // TypeDefIndex: 9491
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x2E7F520 Offset: 0x2E7B520 VA: 0x2E7F520 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x2E7F528 Offset: 0x2E7B528 VA: 0x2E7F528 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x2E7F594 Offset: 0x2E7B594 VA: 0x2E7F594 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x2E7F59C Offset: 0x2E7B59C VA: 0x2E7F59C
	protected void .ctor() { }
}
