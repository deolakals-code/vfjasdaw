// Assembly: mscorlib.dll
// Namespace: System.Collections
[Serializable]
public sealed class Comparer : IComparer, ISerializable // TypeDefIndex: 10858
{
	// Fields
	private CompareInfo _compareInfo; // 0x10
	public static readonly Comparer Default; // 0x0
	public static readonly Comparer DefaultInvariant; // 0x8

	// Methods

	// RVA: 0x2FB343C Offset: 0x2FAF43C VA: 0x2FB343C
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x2FB34C8 Offset: 0x2FAF4C8 VA: 0x2FB34C8
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FB3648 Offset: 0x2FAF648 VA: 0x2FB3648 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FB36E8 Offset: 0x2FAF6E8 VA: 0x2FB36E8 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x2FB38F4 Offset: 0x2FAF8F4 VA: 0x2FB38F4
	private static void .cctor() { }
}
