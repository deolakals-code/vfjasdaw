// Assembly: Assembly-CSharp.dll
// Namespace: PseudoRandom
public class MersenneTwister // TypeDefIndex: 9085
{
	// Fields
	private const int N = 624;
	private const int M = 397;
	private const ulong MATRIX_A = 2567483615;
	private const ulong UPPER_MASK = 2147483648;
	private const ulong LOWER_MASK = 2147483647;
	private ulong[] mt; // 0x10
	private int mti; // 0x18

	// Methods

	// RVA: 0x1EAAC5C Offset: 0x1EA6C5C VA: 0x1EAAC5C
	public void .ctor() { }

	// RVA: 0x1EAAEA8 Offset: 0x1EA6EA8 VA: 0x1EAAEA8
	public void .ctor(ulong s) { }

	// RVA: 0x1EAAFB0 Offset: 0x1EA6FB0 VA: 0x1EAAFB0
	public void .ctor(ulong[] init_key) { }

	// RVA: 0x1EAAF2C Offset: 0x1EA6F2C VA: 0x1EAAF2C
	public void init_genrand(ulong s) { }

	// RVA: 0x1EAAD0C Offset: 0x1EA6D0C VA: 0x1EAAD0C
	public void init_by_array(ulong[] init_key) { }

	// RVA: 0x1EAB034 Offset: 0x1EA7034 VA: 0x1EAB034
	public ulong genrand_uint32() { }

	// RVA: 0x1EAB270 Offset: 0x1EA7270 VA: 0x1EAB270
	public double genrand_real1() { }

	// RVA: 0x1EAB290 Offset: 0x1EA7290 VA: 0x1EAB290
	public double genrand_real2() { }

	// RVA: 0x1EAB2B0 Offset: 0x1EA72B0 VA: 0x1EAB2B0
	public int genrand_N(int iN) { }
}
