// Assembly: mscorlib.dll
// Namespace: System.Collections
[Obsolete("Please use StringComparer instead.")]
[Serializable]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider // TypeDefIndex: 10878
{
	// Fields
	private readonly CompareInfo _compareInfo; // 0x10

	// Methods

	// RVA: 0x2FB559C Offset: 0x2FB159C VA: 0x2FB559C
	public void .ctor() { }

	// RVA: 0x2FB561C Offset: 0x2FB161C VA: 0x2FB561C
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x2FB56A8 Offset: 0x2FB16A8 VA: 0x2FB56A8 Slot: 4
	public int GetHashCode(object obj) { }
}
