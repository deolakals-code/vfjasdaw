// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ByteReader // TypeDefIndex: 69
{
	// Fields
	private byte[] mBuffer; // 0x10
	private int mOffset; // 0x18

	// Properties
	public bool canRead { get; }

	// Methods

	// RVA: 0x172A2F0 Offset: 0x17262F0 VA: 0x172A2F0
	public void .ctor(byte[] bytes) { }

	// RVA: 0x172A320 Offset: 0x1726320 VA: 0x172A320
	public void .ctor(TextAsset asset) { }

	// RVA: 0x172A364 Offset: 0x1726364 VA: 0x172A364
	public bool get_canRead() { }

	// RVA: 0x172A388 Offset: 0x1726388 VA: 0x172A388
	private static string ReadLine(byte[] buffer, int start, int count) { }

	// RVA: 0x172A3D0 Offset: 0x17263D0 VA: 0x172A3D0
	public string ReadLine() { }

	// RVA: 0x172A48C Offset: 0x172648C VA: 0x172A48C
	public Dictionary<string, string> ReadDictionary() { }
}
