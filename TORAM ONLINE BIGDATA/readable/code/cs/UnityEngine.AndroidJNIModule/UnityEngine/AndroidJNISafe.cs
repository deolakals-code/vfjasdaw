// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
internal class AndroidJNISafe // TypeDefIndex: 17060
{
	// Methods

	// RVA: 0x37BD030 Offset: 0x37B9030 VA: 0x37BD030
	public static void CheckException() { }

	// RVA: 0x37BD380 Offset: 0x37B9380 VA: 0x37BD380
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x37BD3D8 Offset: 0x37B93D8 VA: 0x37BD3D8
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x37BD430 Offset: 0x37B9430 VA: 0x37BD430
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x37BD488 Offset: 0x37B9488 VA: 0x37BD488
	public static IntPtr NewString(string chars) { }

	// RVA: 0x37BD528 Offset: 0x37B9528 VA: 0x37BD528
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x37B7AFC Offset: 0x37B3AFC VA: 0x37B7AFC
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x37B75F0 Offset: 0x37B35F0 VA: 0x37B75F0
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x37B7B9C Offset: 0x37B3B9C VA: 0x37B7B9C
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x37BD5C8 Offset: 0x37B95C8 VA: 0x37BD5C8
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x37BD680 Offset: 0x37B9680 VA: 0x37BD680
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x37BD738 Offset: 0x37B9738 VA: 0x37BD738
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x37B7550 Offset: 0x37B3550 VA: 0x37B7550
	public static IntPtr FindClass(string name) { }

	// RVA: 0x37BD7D8 Offset: 0x37B97D8 VA: 0x37BD7D8
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BD850 Offset: 0x37B9850 VA: 0x37BD850
	public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val) { }

	// RVA: 0x37BD90C Offset: 0x37B990C VA: 0x37BD90C
	public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val) { }

	// RVA: 0x37BD9C8 Offset: 0x37B99C8 VA: 0x37BD9C8
	public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val) { }

	// RVA: 0x37BDA84 Offset: 0x37B9A84 VA: 0x37BDA84
	public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val) { }

	// RVA: 0x37BDB40 Offset: 0x37B9B40 VA: 0x37BDB40
	public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val) { }

	// RVA: 0x37BDBFC Offset: 0x37B9BFC VA: 0x37BDBFC
	public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val) { }

	// RVA: 0x37BDCB8 Offset: 0x37B9CB8 VA: 0x37BDCB8
	public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val) { }

	// RVA: 0x37BDD74 Offset: 0x37B9D74 VA: 0x37BDD74
	public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val) { }

	// RVA: 0x37BDE30 Offset: 0x37B9E30 VA: 0x37BDE30
	public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val) { }

	// RVA: 0x37BDEEC Offset: 0x37B9EEC VA: 0x37BDEEC
	public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val) { }

	// RVA: 0x37BDFA8 Offset: 0x37B9FA8 VA: 0x37BDFA8
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x37BE050 Offset: 0x37BA050 VA: 0x37BE050
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x37BE0F8 Offset: 0x37BA0F8 VA: 0x37BE0F8
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x37BE1A0 Offset: 0x37BA1A0 VA: 0x37BE1A0
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x37BE254 Offset: 0x37BA254 VA: 0x37BE254
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x37BE308 Offset: 0x37BA308 VA: 0x37BE308
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x37BE3B0 Offset: 0x37BA3B0 VA: 0x37BE3B0
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x37BE458 Offset: 0x37BA458 VA: 0x37BE458
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x37BE500 Offset: 0x37BA500 VA: 0x37BE500
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x37BE5A8 Offset: 0x37BA5A8 VA: 0x37BE5A8
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x37BE650 Offset: 0x37BA650 VA: 0x37BE650
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BE6C8 Offset: 0x37BA6C8 VA: 0x37BE6C8
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B76A8 Offset: 0x37B36A8 VA: 0x37B76A8
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BE730 Offset: 0x37BA730 VA: 0x37BE730
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BE798 Offset: 0x37BA798 VA: 0x37BE798
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BE810 Offset: 0x37BA810 VA: 0x37BE810
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BE888 Offset: 0x37BA888 VA: 0x37BE888
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BE90C Offset: 0x37BA90C VA: 0x37BE90C
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BE990 Offset: 0x37BA990 VA: 0x37BE990
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BEA08 Offset: 0x37BAA08 VA: 0x37BEA08
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BEA80 Offset: 0x37BAA80 VA: 0x37BEA80
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BEAF8 Offset: 0x37BAAF8 VA: 0x37BEAF8
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BEB70 Offset: 0x37BAB70 VA: 0x37BEB70
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BEBE8 Offset: 0x37BABE8 VA: 0x37BEBE8
	public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val) { }

	// RVA: 0x37BECA4 Offset: 0x37BACA4 VA: 0x37BECA4
	public static void SetStringField(IntPtr obj, IntPtr fieldID, string val) { }

	// RVA: 0x37BED60 Offset: 0x37BAD60 VA: 0x37BED60
	public static void SetCharField(IntPtr obj, IntPtr fieldID, char val) { }

	// RVA: 0x37BEE1C Offset: 0x37BAE1C VA: 0x37BEE1C
	public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val) { }

	// RVA: 0x37BEED8 Offset: 0x37BAED8 VA: 0x37BEED8
	public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val) { }

	// RVA: 0x37BEF94 Offset: 0x37BAF94 VA: 0x37BEF94
	public static void SetLongField(IntPtr obj, IntPtr fieldID, long val) { }

	// RVA: 0x37BF050 Offset: 0x37BB050 VA: 0x37BF050
	public static void SetShortField(IntPtr obj, IntPtr fieldID, short val) { }

	// RVA: 0x37BF10C Offset: 0x37BB10C VA: 0x37BF10C
	public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val) { }

	// RVA: 0x37BF1C8 Offset: 0x37BB1C8 VA: 0x37BF1C8
	public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val) { }

	// RVA: 0x37BF284 Offset: 0x37BB284 VA: 0x37BF284
	public static void SetIntField(IntPtr obj, IntPtr fieldID, int val) { }

	// RVA: 0x37BF340 Offset: 0x37BB340 VA: 0x37BF340
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x37BF3E8 Offset: 0x37BB3E8 VA: 0x37BF3E8
	public static string GetStringField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x37BF490 Offset: 0x37BB490 VA: 0x37BF490
	public static char GetCharField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x37BF538 Offset: 0x37BB538 VA: 0x37BF538
	public static double GetDoubleField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x37BF5EC Offset: 0x37BB5EC VA: 0x37BF5EC
	public static float GetFloatField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x37BF6A0 Offset: 0x37BB6A0 VA: 0x37BF6A0
	public static long GetLongField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x37BF748 Offset: 0x37BB748 VA: 0x37BF748
	public static short GetShortField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x37BF7F0 Offset: 0x37BB7F0 VA: 0x37BF7F0
	public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x37BF898 Offset: 0x37BB898 VA: 0x37BF898
	public static bool GetBooleanField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x37BF940 Offset: 0x37BB940 VA: 0x37BF940
	public static int GetIntField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x37BF9E8 Offset: 0x37BB9E8 VA: 0x37BF9E8
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BFA60 Offset: 0x37BBA60 VA: 0x37BFA60
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BFAC8 Offset: 0x37BBAC8 VA: 0x37BFAC8
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BFB40 Offset: 0x37BBB40 VA: 0x37BFB40
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37B82F4 Offset: 0x37B42F4 VA: 0x37B82F4
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37B81E8 Offset: 0x37B41E8 VA: 0x37B81E8
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37B80DC Offset: 0x37B40DC VA: 0x37B80DC
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37B7FDC Offset: 0x37B3FDC VA: 0x37B7FDC
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37B7DDC Offset: 0x37B3DDC VA: 0x37B7DDC
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37B7CDC Offset: 0x37B3CDC VA: 0x37B7CDC
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37B83F8 Offset: 0x37B43F8 VA: 0x37B83F8
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37B7EDC Offset: 0x37B3EDC VA: 0x37B7EDC
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x37BFBB8 Offset: 0x37BBBB8 VA: 0x37BFBB8
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x37BFC58 Offset: 0x37BBC58 VA: 0x37BFC58
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x37BFCF8 Offset: 0x37BBCF8 VA: 0x37BFCF8
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x37BFD98 Offset: 0x37BBD98 VA: 0x37BFD98
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x37BFE38 Offset: 0x37BBE38 VA: 0x37BFE38
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x37BFED8 Offset: 0x37BBED8 VA: 0x37BFED8
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x37BFF78 Offset: 0x37BBF78 VA: 0x37BFF78
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x37C0018 Offset: 0x37BC018 VA: 0x37C0018
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x37C00B8 Offset: 0x37BC0B8 VA: 0x37C00B8
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x37C0158 Offset: 0x37BC158 VA: 0x37C0158
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x37C01D0 Offset: 0x37BC1D0 VA: 0x37C01D0
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x37C0248 Offset: 0x37BC248 VA: 0x37C0248
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x37C02C0 Offset: 0x37BC2C0 VA: 0x37C02C0
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x37C0338 Offset: 0x37BC338 VA: 0x37C0338
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x37C03B0 Offset: 0x37BC3B0 VA: 0x37C03B0
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x37C0428 Offset: 0x37BC428 VA: 0x37C0428
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x37C04C8 Offset: 0x37BC4C8 VA: 0x37C04C8
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x37C0540 Offset: 0x37BC540 VA: 0x37C0540
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x37C05E4 Offset: 0x37BC5E4 VA: 0x37C05E4
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x37C065C Offset: 0x37BC65C VA: 0x37C065C
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x37C0704 Offset: 0x37BC704 VA: 0x37C0704
	public static int GetArrayLength(IntPtr array) { }
}
