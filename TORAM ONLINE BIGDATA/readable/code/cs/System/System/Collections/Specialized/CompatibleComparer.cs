// Assembly: System.dll
// Namespace: System.Collections.Specialized
[Serializable]
internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 14306
{
	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties
	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0x34D5B2C Offset: 0x34D1B2C VA: 0x34D5B2C
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x34D637C Offset: 0x34D237C VA: 0x34D637C Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x34D657C Offset: 0x34D257C VA: 0x34D657C Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x34D6684 Offset: 0x34D2684 VA: 0x34D6684
	public IComparer get_Comparer() { }

	// RVA: 0x34D668C Offset: 0x34D268C VA: 0x34D668C
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x34D52EC Offset: 0x34D12EC VA: 0x34D52EC
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x34D5210 Offset: 0x34D1210 VA: 0x34D5210
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }
}
