// Assembly: mscorlib.dll
// Namespace: System.Collections
[Serializable]
internal sealed class CompatibleComparer : IEqualityComparer // TypeDefIndex: 10876
{
	// Fields
	private readonly IHashCodeProvider _hcp; // 0x10
	private readonly IComparer _comparer; // 0x18

	// Properties
	internal IHashCodeProvider HashCodeProvider { get; }
	internal IComparer Comparer { get; }

	// Methods

	// RVA: 0x2FB5070 Offset: 0x2FB1070 VA: 0x2FB5070
	internal void .ctor(IHashCodeProvider hashCodeProvider, IComparer comparer) { }

	// RVA: 0x2FB50B4 Offset: 0x2FB10B4 VA: 0x2FB50B4
	internal IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x2FB50BC Offset: 0x2FB10BC VA: 0x2FB50BC
	internal IComparer get_Comparer() { }

	// RVA: 0x2FB50C4 Offset: 0x2FB10C4 VA: 0x2FB50C4 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x2FB50DC Offset: 0x2FB10DC VA: 0x2FB50DC
	public int Compare(object a, object b) { }

	// RVA: 0x2FB529C Offset: 0x2FB129C VA: 0x2FB529C Slot: 5
	public int GetHashCode(object obj) { }
}
