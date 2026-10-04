// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems
public static class BinaryPack // TypeDefIndex: 11239
{
	// Methods

	// RVA: -1 Offset: -1
	public static void CompressBinaryPack<T>(byte code, T[] array, Dictionary<byte, object> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DD6C4 Offset: 0x27D96C4 VA: 0x27DD6C4
	|-BinaryPack.CompressBinaryPack<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] DecompressBinaryPack<T>(byte code, Dictionary<byte, object> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DD960 Offset: 0x27D9960 VA: 0x27DD960
	|-BinaryPack.DecompressBinaryPack<object>
	*/

	// RVA: -1 Offset: -1
	public static void CompressBinaryPack<T>(byte code, byte compressCode, T[] array, Dictionary<byte, object> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DD810 Offset: 0x27D9810 VA: 0x27DD810
	|-BinaryPack.CompressBinaryPack<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] DecompressBinaryPack<T>(byte code, byte compressCode, Dictionary<byte, object> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DDAD8 Offset: 0x27D9AD8 VA: 0x27DDAD8
	|-BinaryPack.DecompressBinaryPack<object>
	*/

	// RVA: 0x36CDD8C Offset: 0x36C9D8C VA: 0x36CDD8C
	public static void CompressBinaryPack(byte code, byte compressCode, byte[] binary, Dictionary<byte, object> parameters) { }

	// RVA: 0x36CE37C Offset: 0x36CA37C VA: 0x36CE37C
	public static byte[] DecompressBinaryPack(byte code, byte compressCode, Dictionary<byte, object> parameters) { }
}
