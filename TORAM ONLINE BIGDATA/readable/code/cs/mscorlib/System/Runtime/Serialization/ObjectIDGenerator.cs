// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Serializable]
public class ObjectIDGenerator // TypeDefIndex: 10352
{
	// Fields
	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0

	// Methods

	// RVA: 0x2EFE858 Offset: 0x2EFA858 VA: 0x2EFE858
	public void .ctor() { }

	// RVA: 0x2EFE944 Offset: 0x2EFA944 VA: 0x2EFE944
	private int FindElement(object obj, out bool found) { }

	// RVA: 0x2EFEA08 Offset: 0x2EFAA08 VA: 0x2EFEA08 Slot: 4
	public virtual long GetId(object obj, out bool firstTime) { }

	// RVA: 0x2EFEE80 Offset: 0x2EFAE80 VA: 0x2EFEE80 Slot: 5
	public virtual long HasId(object obj, out bool firstTime) { }

	// RVA: 0x2EFEB98 Offset: 0x2EFAB98 VA: 0x2EFEB98
	private void Rehash() { }

	// RVA: 0x2EFEF50 Offset: 0x2EFAF50 VA: 0x2EFEF50
	private static void .cctor() { }
}
