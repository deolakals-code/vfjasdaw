// Assembly: Asobimo.Photon.Binary.dll
// Namespace: Asobimo.Photon.Binary
public abstract class BinaryBase // TypeDefIndex: 17867
{
	// Fields
	private string errorMessage; // 0x10
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x18

	// Properties
	public bool IsValid { get; set; }

	// Methods

	// RVA: 0x16FC1E8 Offset: 0x16F81E8 VA: 0x16FC1E8
	public void .ctor() { }

	// RVA: 0x16FC208 Offset: 0x16F8208 VA: 0x16FC208
	public void .ctor(byte[] binary) { }

	// RVA: 0x16FC490 Offset: 0x16F8490 VA: 0x16FC490
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x16FC4D0 Offset: 0x16F84D0 VA: 0x16FC4D0
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x16FC4D8 Offset: 0x16F84D8 VA: 0x16FC4D8
	protected void set_IsValid(bool value) { }

	// RVA: 0x16FC4E4 Offset: 0x16F84E4 VA: 0x16FC4E4
	protected void SetErrorMessage(string errorMessage) { }

	// RVA: 0x16FC4F0 Offset: 0x16F84F0 VA: 0x16FC4F0
	protected void SetErrorMessage(bool valid, string errorMessage) { }

	// RVA: 0x16FC504 Offset: 0x16F8504 VA: 0x16FC504
	public static byte ReadByte(MemoryStream ms) { }

	// RVA: 0x16FC528 Offset: 0x16F8528 VA: 0x16FC528
	public static short ReadShort(MemoryStream ms) { }

	// RVA: 0x16FC5C4 Offset: 0x16F85C4 VA: 0x16FC5C4
	public static int ReadInt(MemoryStream ms) { }

	[CLSCompliant(False)]
	// RVA: 0x16FC684 Offset: 0x16F8684 VA: 0x16FC684
	public static uint ReadUInt(MemoryStream ms) { }

	// RVA: 0x16FC744 Offset: 0x16F8744 VA: 0x16FC744
	public static long ReadLong(MemoryStream ms) { }

	// RVA: 0x16FC844 Offset: 0x16F8844 VA: 0x16FC844
	public static float ReadFloat(MemoryStream ms) { }

	// RVA: 0x16FC908 Offset: 0x16F8908 VA: 0x16FC908
	public static double ReadDouble(MemoryStream ms) { }

	// RVA: 0x16FC9FC Offset: 0x16F89FC VA: 0x16FC9FC
	public static bool ReadBoolean(MemoryStream ms) { }

	// RVA: 0x16FCA28 Offset: 0x16F8A28 VA: 0x16FCA28
	public static string ReadString(MemoryStream ms) { }

	// RVA: 0x16FCB08 Offset: 0x16F8B08 VA: 0x16FCB08
	public static string ReadName(MemoryStream ms) { }

	// RVA: 0x16FCBF4 Offset: 0x16F8BF4 VA: 0x16FCBF4
	public static string ReadByteString(MemoryStream ms) { }

	// RVA: 0x16FCCE0 Offset: 0x16F8CE0 VA: 0x16FCCE0
	public static byte[] ReadBytesOfInt(MemoryStream ms) { }

	// RVA: 0x16FCD74 Offset: 0x16F8D74 VA: 0x16FCD74
	public static byte[] ReadBytes(MemoryStream ms) { }

	// RVA: 0x16FCE1C Offset: 0x16F8E1C VA: 0x16FCE1C
	public static byte[] ReadBytes(MemoryStream ms, int length) { }

	// RVA: 0x16FCEAC Offset: 0x16F8EAC VA: 0x16FCEAC
	public static byte[] ReadBytesOfShort(MemoryStream ms) { }

	// RVA: 0x16FCF48 Offset: 0x16F8F48 VA: 0x16FCF48
	public static DateTime ReadDateTime(MemoryStream ms) { }

	// RVA: 0x16FCF70 Offset: 0x16F8F70 VA: 0x16FCF70
	public static int[] ReadBinaryAsIntArray(MemoryStream ms) { }

	// RVA: 0x16FD034 Offset: 0x16F9034 VA: 0x16FD034
	public static short[] ReadBinaryAsShortArray(MemoryStream ms) { }

	// RVA: 0x16FD0F8 Offset: 0x16F90F8 VA: 0x16FD0F8
	public static void WriteByte(MemoryStream ms, byte wObject) { }

	// RVA: 0x16FD118 Offset: 0x16F9118 VA: 0x16FD118
	public static void WriteShort(MemoryStream ms, short wObject) { }

	// RVA: 0x16FD1B8 Offset: 0x16F91B8 VA: 0x16FD1B8
	public static void WriteInt(MemoryStream ms, int wObject) { }

	[CLSCompliant(False)]
	// RVA: 0x16FD278 Offset: 0x16F9278 VA: 0x16FD278
	public static void WriteUInt(MemoryStream ms, uint wObject) { }

	// RVA: 0x16FD338 Offset: 0x16F9338 VA: 0x16FD338
	public static void WriteLong(MemoryStream ms, long wObject) { }

	// RVA: 0x16FD3E8 Offset: 0x16F93E8 VA: 0x16FD3E8
	public static void WriteFloat(MemoryStream ms, float wObject) { }

	// RVA: 0x16FD464 Offset: 0x16F9464 VA: 0x16FD464
	public static void WriteDouble(MemoryStream ms, double wObject) { }

	// RVA: 0x16FD510 Offset: 0x16F9510 VA: 0x16FD510
	public static void WriteBoolean(MemoryStream ms, bool wObject) { }

	// RVA: 0x16FD550 Offset: 0x16F9550 VA: 0x16FD550
	public static void WriteString(MemoryStream ms, string wObject) { }

	// RVA: 0x16FD5E8 Offset: 0x16F95E8 VA: 0x16FD5E8
	public static void WriteName(MemoryStream ms, string wObject) { }

	// RVA: 0x16FD69C Offset: 0x16F969C VA: 0x16FD69C
	public static void WriteByteString(MemoryStream ms, string wObject) { }

	// RVA: 0x16FD750 Offset: 0x16F9750 VA: 0x16FD750
	public static void WriteBytesOfInt(MemoryStream ms, byte[] array) { }

	// RVA: 0x16FD7B0 Offset: 0x16F97B0 VA: 0x16FD7B0
	public static void WriteBytes(MemoryStream ms, byte[] array) { }

	// RVA: 0x16FD830 Offset: 0x16F9830 VA: 0x16FD830
	public static void WriteBytesOfShort(MemoryStream ms, byte[] array) { }

	// RVA: 0x16FD890 Offset: 0x16F9890 VA: 0x16FD890
	public static void WriteDateTime(MemoryStream ms, DateTime datetime) { }

	// RVA: 0x16FD904 Offset: 0x16F9904 VA: 0x16FD904
	public static void WriteIntArrayAsBinary(MemoryStream ms, int[] intArray) { }

	// RVA: 0x16FD9B4 Offset: 0x16F99B4 VA: 0x16FD9B4
	public static void WriteShortArrayAsBinary(MemoryStream ms, short[] shortArray) { }

	// RVA: 0x16FC23C Offset: 0x16F823C VA: 0x16FC23C
	public bool SetValue(byte[] binary) { }

	// RVA: 0x16FDA64 Offset: 0x16F9A64 VA: 0x16FDA64
	public bool SetValue(MemoryStream ms) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract bool SetValue(MemoryStream ms, bool isThrow);

	// RVA: 0x16FDA74 Offset: 0x16F9A74 VA: 0x16FDA74 Slot: 5
	public virtual byte[] GetBinary() { }

	// RVA: 0x16FDCF8 Offset: 0x16F9CF8 VA: 0x16FDCF8 Slot: 6
	public virtual void GetBinary(MemoryStream ms) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void GetBinary(MemoryStream ms, bool isThrow);

	// RVA: -1 Offset: -1
	public static byte[] GetBinary<T>(IEnumerable<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DC764 Offset: 0x27D8764 VA: 0x27DC764
	|-BinaryBase.GetBinary<object>
	*/

	// RVA: -1 Offset: -1
	public static void GetBinary<T>(MemoryStream ms, IEnumerable<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DCC3C Offset: 0x27D8C3C VA: 0x27DCC3C
	|-BinaryBase.GetBinary<object>
	*/

	// RVA: -1 Offset: -1
	public static byte[] GetBinaryByteMax<T>(IEnumerable<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DCF88 Offset: 0x27D8F88 VA: 0x27DCF88
	|-BinaryBase.GetBinaryByteMax<object>
	*/

	// RVA: -1 Offset: -1
	public static byte[] GetBinaryShort<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DD494 Offset: 0x27D9494 VA: 0x27DD494
	|-BinaryBase.GetBinaryShort<object>
	*/

	// RVA: 0x16FDD08 Offset: 0x16F9D08 VA: 0x16FDD08
	public static byte[] GetBinaryAsIntArray(int[] array) { }

	// RVA: -1 Offset: -1
	public static T[] GetArray<T>(byte[] binary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DC074 Offset: 0x27D8074 VA: 0x27DC074
	|-BinaryBase.GetArray<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] GetArray<T>(MemoryStream ms) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DC364 Offset: 0x27D8364 VA: 0x27DC364
	|-BinaryBase.GetArray<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] GetArrayShort<T>(byte[] binary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DC490 Offset: 0x27D8490 VA: 0x27DC490
	|-BinaryBase.GetArrayShort<object>
	*/

	// RVA: 0x16FDF24 Offset: 0x16F9F24 VA: 0x16FDF24
	public static int[] GetIntArrayAsBinary(byte[] binary) { }

	// RVA: 0x16FE144 Offset: 0x16FA144 VA: 0x16FE144
	public static object ReadTypeValue(MemoryStream ms) { }

	// RVA: 0x16FE374 Offset: 0x16FA374 VA: 0x16FE374
	public static void WriteTypeValue(MemoryStream ms, byte type, byte typeCode, object value, ref int count) { }
}
