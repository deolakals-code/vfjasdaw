// Assembly: Assembly-CSharp.dll
// Namespace: 
[Extension]
public static class Vector3Ex // TypeDefIndex: 5293
{
	// Methods

	[Extension]
	// RVA: 0x26256F8 Offset: 0x26216F8 VA: 0x26256F8
	public static float[] ToFloatArray(Vector3 vec) { }

	[Extension]
	// RVA: 0x262578C Offset: 0x262178C VA: 0x262578C
	public static short[] GetServerPosition(Vector3 vec) { }

	// RVA: 0x26258F8 Offset: 0x26218F8 VA: 0x26258F8
	public static Vector3 SetServerPosition(float[] serverPos) { }

	// RVA: 0x2625960 Offset: 0x2621960 VA: 0x2625960
	public static Vector3 SetServerPosition(short[] serverPos) { }

	// RVA: 0x2625A54 Offset: 0x2621A54 VA: 0x2625A54
	public static Vector3 SetServerPosition(byte roomType, short[] serverPos) { }
}
