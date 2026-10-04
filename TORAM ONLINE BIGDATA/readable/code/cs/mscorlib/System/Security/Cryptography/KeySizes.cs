// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class KeySizes // TypeDefIndex: 10106
{
	// Fields
	private int m_minSize; // 0x10
	private int m_maxSize; // 0x14
	private int m_skipSize; // 0x18

	// Properties
	public int MinSize { get; }
	public int MaxSize { get; }
	public int SkipSize { get; }

	// Methods

	// RVA: 0x2EAD784 Offset: 0x2EA9784 VA: 0x2EAD784
	public int get_MinSize() { }

	// RVA: 0x2EAD78C Offset: 0x2EA978C VA: 0x2EAD78C
	public int get_MaxSize() { }

	// RVA: 0x2EAD794 Offset: 0x2EA9794 VA: 0x2EAD794
	public int get_SkipSize() { }

	// RVA: 0x2EAD548 Offset: 0x2EA9548 VA: 0x2EAD548
	public void .ctor(int minSize, int maxSize, int skipSize) { }

	// RVA: 0x2EAD79C Offset: 0x2EA979C VA: 0x2EAD79C
	internal bool IsLegal(int keySize) { }

	// RVA: 0x2EAD7E8 Offset: 0x2EA97E8 VA: 0x2EAD7E8
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }
}
