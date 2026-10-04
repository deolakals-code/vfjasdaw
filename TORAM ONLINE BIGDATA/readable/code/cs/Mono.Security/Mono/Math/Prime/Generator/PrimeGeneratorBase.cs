// Assembly: Mono.Security.dll
// Namespace: Mono.Math.Prime.Generator
public abstract class PrimeGeneratorBase // TypeDefIndex: 16935
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x2E63BCC Offset: 0x2E5FBCC VA: 0x2E63BCC Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x2E63BD4 Offset: 0x2E5FBD4 VA: 0x2E63BD4 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x2E63C40 Offset: 0x2E5FC40 VA: 0x2E63C40 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x2E63C48 Offset: 0x2E5FC48 VA: 0x2E63C48
	protected void .ctor() { }
}
