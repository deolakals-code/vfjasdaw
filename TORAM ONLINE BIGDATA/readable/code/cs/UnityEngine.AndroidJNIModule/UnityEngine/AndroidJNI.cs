// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
[StaticAccessor("AndroidJNIBindingsHelpers", 2)]
[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
public static class AndroidJNI // TypeDefIndex: 17059
{
	// Methods

	[StaticAccessor("jni", 2)]
	[ThreadSafe]
	// RVA: 0x37B8470 Offset: 0x37B4470 VA: 0x37B8470
	public static IntPtr GetJavaVM() { }

	[ThreadSafe]
	// RVA: 0x37B8498 Offset: 0x37B4498 VA: 0x37B8498
	public static int AttachCurrentThread() { }

	[ThreadSafe]
	// RVA: 0x37B84C0 Offset: 0x37B44C0 VA: 0x37B84C0
	public static int DetachCurrentThread() { }

	[ThreadSafe]
	// RVA: 0x37B84E8 Offset: 0x37B44E8 VA: 0x37B84E8
	public static int GetVersion() { }

	[ThreadSafe]
	// RVA: 0x37B8510 Offset: 0x37B4510 VA: 0x37B8510
	public static IntPtr FindClass(string name) { }

	[ThreadSafe]
	// RVA: 0x37B854C Offset: 0x37B454C VA: 0x37B854C
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafe]
	// RVA: 0x37B8588 Offset: 0x37B4588 VA: 0x37B8588
	public static IntPtr FromReflectedField(IntPtr refField) { }

	[ThreadSafe]
	// RVA: 0x37B85C4 Offset: 0x37B45C4 VA: 0x37B85C4
	public static IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic) { }

	[ThreadSafe]
	// RVA: 0x37B8618 Offset: 0x37B4618 VA: 0x37B8618
	public static IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic) { }

	[ThreadSafe]
	// RVA: 0x37B866C Offset: 0x37B466C VA: 0x37B866C
	public static IntPtr GetSuperclass(IntPtr clazz) { }

	[ThreadSafe]
	// RVA: 0x37B86A8 Offset: 0x37B46A8 VA: 0x37B86A8
	public static bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2) { }

	[ThreadSafe]
	// RVA: 0x37B86EC Offset: 0x37B46EC VA: 0x37B86EC
	public static int Throw(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37B8728 Offset: 0x37B4728 VA: 0x37B8728
	public static int ThrowNew(IntPtr clazz, string message) { }

	[ThreadSafe]
	// RVA: 0x37B876C Offset: 0x37B476C VA: 0x37B876C
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafe]
	// RVA: 0x37B8794 Offset: 0x37B4794 VA: 0x37B8794
	public static void ExceptionDescribe() { }

	[ThreadSafe]
	// RVA: 0x37B87BC Offset: 0x37B47BC VA: 0x37B87BC
	public static void ExceptionClear() { }

	[ThreadSafe]
	// RVA: 0x37B87E4 Offset: 0x37B47E4 VA: 0x37B87E4
	public static void FatalError(string message) { }

	[ThreadSafe]
	// RVA: 0x37B8820 Offset: 0x37B4820 VA: 0x37B8820
	public static int PushLocalFrame(int capacity) { }

	[ThreadSafe]
	// RVA: 0x37B885C Offset: 0x37B485C VA: 0x37B885C
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	[ThreadSafe]
	// RVA: 0x37B8898 Offset: 0x37B4898 VA: 0x37B8898
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37B88D4 Offset: 0x37B48D4 VA: 0x37B88D4
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37B8910 Offset: 0x37B4910 VA: 0x37B8910
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37B894C Offset: 0x37B494C VA: 0x37B894C
	internal static uint GetQueueGlobalRefsCount() { }

	[ThreadSafe]
	// RVA: 0x37B8974 Offset: 0x37B4974 VA: 0x37B8974
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37B89B0 Offset: 0x37B49B0 VA: 0x37B89B0
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37B89EC Offset: 0x37B49EC VA: 0x37B89EC
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37B8A28 Offset: 0x37B4A28 VA: 0x37B8A28
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37B8A64 Offset: 0x37B4A64 VA: 0x37B8A64
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	[ThreadSafe]
	// RVA: 0x37B8AA8 Offset: 0x37B4AA8 VA: 0x37B8AA8
	public static int EnsureLocalCapacity(int capacity) { }

	[ThreadSafe]
	// RVA: 0x37B8AE4 Offset: 0x37B4AE4 VA: 0x37B8AE4
	public static IntPtr AllocObject(IntPtr clazz) { }

	// RVA: 0x37B8B20 Offset: 0x37B4B20 VA: 0x37B8B20
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B8B88 Offset: 0x37B4B88 VA: 0x37B8B88
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B8C20 Offset: 0x37B4C20 VA: 0x37B8C20
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x37B8C74 Offset: 0x37B4C74 VA: 0x37B8C74
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37B8CB0 Offset: 0x37B4CB0 VA: 0x37B8CB0
	public static bool IsInstanceOf(IntPtr obj, IntPtr clazz) { }

	[ThreadSafe]
	// RVA: 0x37B8CF4 Offset: 0x37B4CF4 VA: 0x37B8CF4
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x37B8D48 Offset: 0x37B4D48 VA: 0x37B8D48
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x37B8D9C Offset: 0x37B4D9C VA: 0x37B8D9C
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x37B8DF0 Offset: 0x37B4DF0 VA: 0x37B8DF0
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x37B8E44 Offset: 0x37B4E44 VA: 0x37B8E44
	public static IntPtr NewString(string chars) { }

	[ThreadSafe]
	// RVA: 0x37B8E80 Offset: 0x37B4E80 VA: 0x37B8E80
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafe]
	// RVA: 0x37B8EBC Offset: 0x37B4EBC VA: 0x37B8EBC
	public static IntPtr NewString(char[] chars) { }

	[ThreadSafe]
	// RVA: 0x37B8EF8 Offset: 0x37B4EF8 VA: 0x37B8EF8
	public static IntPtr NewStringUTF(string bytes) { }

	[ThreadSafe]
	// RVA: 0x37B8F34 Offset: 0x37B4F34 VA: 0x37B8F34
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x37B8F70 Offset: 0x37B4F70 VA: 0x37B8F70
	public static int GetStringLength(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x37B8FAC Offset: 0x37B4FAC VA: 0x37B8FAC
	public static int GetStringUTFLength(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x37B8FE8 Offset: 0x37B4FE8 VA: 0x37B8FE8
	public static string GetStringUTFChars(IntPtr str) { }

	// RVA: 0x37B9024 Offset: 0x37B5024 VA: 0x37B9024
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B908C Offset: 0x37B508C VA: 0x37B908C
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B9124 Offset: 0x37B5124 VA: 0x37B9124
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37B9178 Offset: 0x37B5178 VA: 0x37B9178
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B91E0 Offset: 0x37B51E0 VA: 0x37B91E0
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B9278 Offset: 0x37B5278 VA: 0x37B9278
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37B92CC Offset: 0x37B52CC VA: 0x37B92CC
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B9334 Offset: 0x37B5334 VA: 0x37B9334
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B93CC Offset: 0x37B53CC VA: 0x37B93CC
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37B9420 Offset: 0x37B5420 VA: 0x37B9420
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B9488 Offset: 0x37B5488 VA: 0x37B9488
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B9524 Offset: 0x37B5524 VA: 0x37B9524
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37B9578 Offset: 0x37B5578 VA: 0x37B9578
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B95E0 Offset: 0x37B55E0 VA: 0x37B95E0
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B9678 Offset: 0x37B5678 VA: 0x37B9678
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Obsolete("AndroidJNI.CallByteMethod is obsolete. Use AndroidJNI.CallSByteMethod method instead")]
	// RVA: 0x37B96CC Offset: 0x37B56CC VA: 0x37B96CC
	public static byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B96D0 Offset: 0x37B56D0 VA: 0x37B96D0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B9738 Offset: 0x37B5738 VA: 0x37B9738
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B97D0 Offset: 0x37B57D0 VA: 0x37B97D0
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37B9824 Offset: 0x37B5824 VA: 0x37B9824
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B988C Offset: 0x37B588C VA: 0x37B988C
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B9924 Offset: 0x37B5924 VA: 0x37B9924
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37B9978 Offset: 0x37B5978 VA: 0x37B9978
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B99E0 Offset: 0x37B59E0 VA: 0x37B99E0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B9A78 Offset: 0x37B5A78 VA: 0x37B9A78
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37B9ACC Offset: 0x37B5ACC VA: 0x37B9ACC
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B9B34 Offset: 0x37B5B34 VA: 0x37B9B34
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B9BCC Offset: 0x37B5BCC VA: 0x37B9BCC
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37B9C20 Offset: 0x37B5C20 VA: 0x37B9C20
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B9C88 Offset: 0x37B5C88 VA: 0x37B9C88
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B9D20 Offset: 0x37B5D20 VA: 0x37B9D20
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37B9D74 Offset: 0x37B5D74 VA: 0x37B9D74
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37B9DDC Offset: 0x37B5DDC VA: 0x37B9DDC
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37B9E74 Offset: 0x37B5E74 VA: 0x37B9E74
	public static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x37B9EC8 Offset: 0x37B5EC8 VA: 0x37B9EC8
	public static string GetStringField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37B9F0C Offset: 0x37B5F0C VA: 0x37B9F0C
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37B9F50 Offset: 0x37B5F50 VA: 0x37B9F50
	public static bool GetBooleanField(IntPtr obj, IntPtr fieldID) { }

	[Obsolete("AndroidJNI.GetByteField is obsolete. Use AndroidJNI.GetSByteField method instead")]
	// RVA: 0x37B9F94 Offset: 0x37B5F94 VA: 0x37B9F94
	public static byte GetByteField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37B9FD8 Offset: 0x37B5FD8 VA: 0x37B9FD8
	public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BA01C Offset: 0x37B601C VA: 0x37BA01C
	public static char GetCharField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BA060 Offset: 0x37B6060 VA: 0x37BA060
	public static short GetShortField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BA0A4 Offset: 0x37B60A4 VA: 0x37BA0A4
	public static int GetIntField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BA0E8 Offset: 0x37B60E8 VA: 0x37BA0E8
	public static long GetLongField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BA12C Offset: 0x37B612C VA: 0x37BA12C
	public static float GetFloatField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BA170 Offset: 0x37B6170 VA: 0x37BA170
	public static double GetDoubleField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BA1B4 Offset: 0x37B61B4 VA: 0x37BA1B4
	public static void SetStringField(IntPtr obj, IntPtr fieldID, string val) { }

	[ThreadSafe]
	// RVA: 0x37BA208 Offset: 0x37B6208 VA: 0x37BA208
	public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val) { }

	[ThreadSafe]
	// RVA: 0x37BA25C Offset: 0x37B625C VA: 0x37BA25C
	public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val) { }

	[Obsolete("AndroidJNI.SetByteField is obsolete. Use AndroidJNI.SetSByteField method instead")]
	// RVA: 0x37BA2B0 Offset: 0x37B62B0 VA: 0x37BA2B0
	public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val) { }

	[ThreadSafe]
	// RVA: 0x37BA304 Offset: 0x37B6304 VA: 0x37BA304
	public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x37BA358 Offset: 0x37B6358 VA: 0x37BA358
	public static void SetCharField(IntPtr obj, IntPtr fieldID, char val) { }

	[ThreadSafe]
	// RVA: 0x37BA3AC Offset: 0x37B63AC VA: 0x37BA3AC
	public static void SetShortField(IntPtr obj, IntPtr fieldID, short val) { }

	[ThreadSafe]
	// RVA: 0x37BA400 Offset: 0x37B6400 VA: 0x37BA400
	public static void SetIntField(IntPtr obj, IntPtr fieldID, int val) { }

	[ThreadSafe]
	// RVA: 0x37BA454 Offset: 0x37B6454 VA: 0x37BA454
	public static void SetLongField(IntPtr obj, IntPtr fieldID, long val) { }

	[ThreadSafe]
	// RVA: 0x37BA4A8 Offset: 0x37B64A8 VA: 0x37BA4A8
	public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val) { }

	[ThreadSafe]
	// RVA: 0x37BA4FC Offset: 0x37B64FC VA: 0x37BA4FC
	public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val) { }

	// RVA: 0x37BA550 Offset: 0x37B6550 VA: 0x37BA550
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BA5B8 Offset: 0x37B65B8 VA: 0x37BA5B8
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BA650 Offset: 0x37B6650 VA: 0x37BA650
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37BA6A4 Offset: 0x37B66A4 VA: 0x37BA6A4
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BA70C Offset: 0x37B670C VA: 0x37BA70C
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BA7A4 Offset: 0x37B67A4 VA: 0x37BA7A4
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37BA7F8 Offset: 0x37B67F8 VA: 0x37BA7F8
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BA860 Offset: 0x37B6860 VA: 0x37BA860
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BA8F8 Offset: 0x37B68F8 VA: 0x37BA8F8
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37BA94C Offset: 0x37B694C VA: 0x37BA94C
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BA9B4 Offset: 0x37B69B4 VA: 0x37BA9B4
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BAA50 Offset: 0x37B6A50 VA: 0x37BAA50
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37BAAA4 Offset: 0x37B6AA4 VA: 0x37BAAA4
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BAB0C Offset: 0x37B6B0C VA: 0x37BAB0C
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BABA4 Offset: 0x37B6BA4 VA: 0x37BABA4
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Obsolete("AndroidJNI.CallStaticByteMethod is obsolete. Use AndroidJNI.CallStaticSByteMethod method instead")]
	// RVA: 0x37BABF8 Offset: 0x37B6BF8 VA: 0x37BABF8
	public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BABFC Offset: 0x37B6BFC VA: 0x37BABFC
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BAC64 Offset: 0x37B6C64 VA: 0x37BAC64
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BACFC Offset: 0x37B6CFC VA: 0x37BACFC
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37BAD50 Offset: 0x37B6D50 VA: 0x37BAD50
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BADB8 Offset: 0x37B6DB8 VA: 0x37BADB8
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BAE50 Offset: 0x37B6E50 VA: 0x37BAE50
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37BAEA4 Offset: 0x37B6EA4 VA: 0x37BAEA4
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BAF0C Offset: 0x37B6F0C VA: 0x37BAF0C
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BAFA4 Offset: 0x37B6FA4 VA: 0x37BAFA4
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37BAFF8 Offset: 0x37B6FF8 VA: 0x37BAFF8
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BB060 Offset: 0x37B7060 VA: 0x37BB060
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BB0F8 Offset: 0x37B70F8 VA: 0x37BB0F8
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37BB14C Offset: 0x37B714C VA: 0x37BB14C
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BB1B4 Offset: 0x37B71B4 VA: 0x37BB1B4
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BB24C Offset: 0x37B724C VA: 0x37BB24C
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x37BB2A0 Offset: 0x37B72A0 VA: 0x37BB2A0
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x37BB308 Offset: 0x37B7308 VA: 0x37BB308
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x37BB3A0 Offset: 0x37B73A0 VA: 0x37BB3A0
	public static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x37BB3F4 Offset: 0x37B73F4 VA: 0x37BB3F4
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BB438 Offset: 0x37B7438 VA: 0x37BB438
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BB47C Offset: 0x37B747C VA: 0x37BB47C
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	[Obsolete("AndroidJNI.GetStaticByteField is obsolete. Use AndroidJNI.GetStaticSByteField method instead")]
	// RVA: 0x37BB4C0 Offset: 0x37B74C0 VA: 0x37BB4C0
	public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BB504 Offset: 0x37B7504 VA: 0x37BB504
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BB548 Offset: 0x37B7548 VA: 0x37BB548
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BB58C Offset: 0x37B758C VA: 0x37BB58C
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BB5D0 Offset: 0x37B75D0 VA: 0x37BB5D0
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BB614 Offset: 0x37B7614 VA: 0x37BB614
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BB658 Offset: 0x37B7658 VA: 0x37BB658
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BB69C Offset: 0x37B769C VA: 0x37BB69C
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x37BB6E0 Offset: 0x37B76E0 VA: 0x37BB6E0
	public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val) { }

	[ThreadSafe]
	// RVA: 0x37BB734 Offset: 0x37B7734 VA: 0x37BB734
	public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val) { }

	[ThreadSafe]
	// RVA: 0x37BB788 Offset: 0x37B7788 VA: 0x37BB788
	public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val) { }

	[Obsolete("AndroidJNI.SetStaticByteField is obsolete. Use AndroidJNI.SetStaticSByteField method instead")]
	// RVA: 0x37BB7DC Offset: 0x37B77DC VA: 0x37BB7DC
	public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val) { }

	[ThreadSafe]
	// RVA: 0x37BB830 Offset: 0x37B7830 VA: 0x37BB830
	public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x37BB884 Offset: 0x37B7884 VA: 0x37BB884
	public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val) { }

	[ThreadSafe]
	// RVA: 0x37BB8D8 Offset: 0x37B78D8 VA: 0x37BB8D8
	public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val) { }

	[ThreadSafe]
	// RVA: 0x37BB92C Offset: 0x37B792C VA: 0x37BB92C
	public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val) { }

	[ThreadSafe]
	// RVA: 0x37BB980 Offset: 0x37B7980 VA: 0x37BB980
	public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val) { }

	[ThreadSafe]
	// RVA: 0x37BB9D4 Offset: 0x37B79D4 VA: 0x37BB9D4
	public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val) { }

	[ThreadSafe]
	// RVA: 0x37BBA28 Offset: 0x37B7A28 VA: 0x37BBA28
	public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val) { }

	[ThreadSafe]
	// RVA: 0x37BBA7C Offset: 0x37B7A7C VA: 0x37BBA7C
	private static IntPtr ConvertToBooleanArray(bool[] array) { }

	// RVA: 0x37BBAB8 Offset: 0x37B7AB8 VA: 0x37BBAB8
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafe]
	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	// RVA: 0x37BBAFC Offset: 0x37B7AFC VA: 0x37BBAFC
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x37BBB38 Offset: 0x37B7B38 VA: 0x37BBB38
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafe]
	// RVA: 0x37BBB8C Offset: 0x37B7B8C VA: 0x37BBB8C
	public static IntPtr ToSByteArray(sbyte* array, int length) { }

	// RVA: 0x37BBBD0 Offset: 0x37B7BD0 VA: 0x37BBBD0
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafe]
	// RVA: 0x37BBC24 Offset: 0x37B7C24 VA: 0x37BBC24
	public static IntPtr ToCharArray(char* array, int length) { }

	// RVA: 0x37BBC68 Offset: 0x37B7C68 VA: 0x37BBC68
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafe]
	// RVA: 0x37BBCBC Offset: 0x37B7CBC VA: 0x37BBCBC
	public static IntPtr ToShortArray(short* array, int length) { }

	// RVA: 0x37BBD00 Offset: 0x37B7D00 VA: 0x37BBD00
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafe]
	// RVA: 0x37BBD54 Offset: 0x37B7D54 VA: 0x37BBD54
	public static IntPtr ToIntArray(int* array, int length) { }

	// RVA: 0x37BBD98 Offset: 0x37B7D98 VA: 0x37BBD98
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafe]
	// RVA: 0x37BBDEC Offset: 0x37B7DEC VA: 0x37BBDEC
	public static IntPtr ToLongArray(long* array, int length) { }

	// RVA: 0x37BBE30 Offset: 0x37B7E30 VA: 0x37BBE30
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafe]
	// RVA: 0x37BBE84 Offset: 0x37B7E84 VA: 0x37BBE84
	public static IntPtr ToFloatArray(float* array, int length) { }

	// RVA: 0x37BBEC8 Offset: 0x37B7EC8 VA: 0x37BBEC8
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafe]
	// RVA: 0x37BBF1C Offset: 0x37B7F1C VA: 0x37BBF1C
	public static IntPtr ToDoubleArray(double* array, int length) { }

	[ThreadSafe]
	// RVA: 0x37BBF60 Offset: 0x37B7F60 VA: 0x37BBF60
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x37BBFB4 Offset: 0x37B7FB4 VA: 0x37BBFB4
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	// RVA: 0x37BC018 Offset: 0x37B8018 VA: 0x37BC018
	public static IntPtr ToObjectArray(IntPtr[] array) { }

	[ThreadSafe]
	// RVA: 0x37BC020 Offset: 0x37B8020 VA: 0x37BC020
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ThreadSafe]
	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	// RVA: 0x37BC05C Offset: 0x37B805C VA: 0x37BC05C
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x37BC098 Offset: 0x37B8098 VA: 0x37BC098
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x37BC0D4 Offset: 0x37B80D4 VA: 0x37BC0D4
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x37BC110 Offset: 0x37B8110 VA: 0x37BC110
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x37BC14C Offset: 0x37B814C VA: 0x37BC14C
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x37BC188 Offset: 0x37B8188 VA: 0x37BC188
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x37BC1C4 Offset: 0x37B81C4 VA: 0x37BC1C4
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x37BC200 Offset: 0x37B8200 VA: 0x37BC200
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x37BC23C Offset: 0x37B823C VA: 0x37BC23C
	public static IntPtr[] FromObjectArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x37BC278 Offset: 0x37B8278 VA: 0x37BC278
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x37BC2B4 Offset: 0x37B82B4 VA: 0x37BC2B4
	public static IntPtr NewBooleanArray(int size) { }

	[Obsolete("AndroidJNI.NewByteArray is obsolete. Use AndroidJNI.NewSByteArray method instead")]
	// RVA: 0x37BC2F0 Offset: 0x37B82F0 VA: 0x37BC2F0
	public static IntPtr NewByteArray(int size) { }

	[ThreadSafe]
	// RVA: 0x37BC32C Offset: 0x37B832C VA: 0x37BC32C
	public static IntPtr NewSByteArray(int size) { }

	[ThreadSafe]
	// RVA: 0x37BC368 Offset: 0x37B8368 VA: 0x37BC368
	public static IntPtr NewCharArray(int size) { }

	[ThreadSafe]
	// RVA: 0x37BC3A4 Offset: 0x37B83A4 VA: 0x37BC3A4
	public static IntPtr NewShortArray(int size) { }

	[ThreadSafe]
	// RVA: 0x37BC3E0 Offset: 0x37B83E0 VA: 0x37BC3E0
	public static IntPtr NewIntArray(int size) { }

	[ThreadSafe]
	// RVA: 0x37BC41C Offset: 0x37B841C VA: 0x37BC41C
	public static IntPtr NewLongArray(int size) { }

	[ThreadSafe]
	// RVA: 0x37BC458 Offset: 0x37B8458 VA: 0x37BC458
	public static IntPtr NewFloatArray(int size) { }

	[ThreadSafe]
	// RVA: 0x37BC494 Offset: 0x37B8494 VA: 0x37BC494
	public static IntPtr NewDoubleArray(int size) { }

	[ThreadSafe]
	// RVA: 0x37BC4D0 Offset: 0x37B84D0 VA: 0x37BC4D0
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37BC524 Offset: 0x37B8524 VA: 0x37BC524
	public static bool GetBooleanArrayElement(IntPtr array, int index) { }

	[Obsolete("AndroidJNI.GetByteArrayElement is obsolete. Use AndroidJNI.GetSByteArrayElement method instead")]
	// RVA: 0x37BC568 Offset: 0x37B8568 VA: 0x37BC568
	public static byte GetByteArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x37BC5AC Offset: 0x37B85AC VA: 0x37BC5AC
	public static sbyte GetSByteArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x37BC5F0 Offset: 0x37B85F0 VA: 0x37BC5F0
	public static char GetCharArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x37BC634 Offset: 0x37B8634 VA: 0x37BC634
	public static short GetShortArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x37BC678 Offset: 0x37B8678 VA: 0x37BC678
	public static int GetIntArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x37BC6BC Offset: 0x37B86BC VA: 0x37BC6BC
	public static long GetLongArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x37BC700 Offset: 0x37B8700 VA: 0x37BC700
	public static float GetFloatArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x37BC744 Offset: 0x37B8744 VA: 0x37BC744
	public static double GetDoubleArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x37BC788 Offset: 0x37B8788 VA: 0x37BC788
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[Obsolete("AndroidJNI.SetBooleanArrayElement(IntPtr, int, byte) is obsolete. Use AndroidJNI.SetBooleanArrayElement(IntPtr, int, bool) method instead")]
	// RVA: 0x37BC7CC Offset: 0x37B87CC VA: 0x37BC7CC
	public static void SetBooleanArrayElement(IntPtr array, int index, byte val) { }

	[ThreadSafe]
	// RVA: 0x37BC824 Offset: 0x37B8824 VA: 0x37BC824
	public static void SetBooleanArrayElement(IntPtr array, int index, bool val) { }

	[Obsolete("AndroidJNI.SetByteArrayElement is obsolete. Use AndroidJNI.SetSByteArrayElement method instead")]
	// RVA: 0x37BC878 Offset: 0x37B8878 VA: 0x37BC878
	public static void SetByteArrayElement(IntPtr array, int index, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x37BC8CC Offset: 0x37B88CC VA: 0x37BC8CC
	public static void SetSByteArrayElement(IntPtr array, int index, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x37BC920 Offset: 0x37B8920 VA: 0x37BC920
	public static void SetCharArrayElement(IntPtr array, int index, char val) { }

	[ThreadSafe]
	// RVA: 0x37BC974 Offset: 0x37B8974 VA: 0x37BC974
	public static void SetShortArrayElement(IntPtr array, int index, short val) { }

	[ThreadSafe]
	// RVA: 0x37BC9C8 Offset: 0x37B89C8 VA: 0x37BC9C8
	public static void SetIntArrayElement(IntPtr array, int index, int val) { }

	[ThreadSafe]
	// RVA: 0x37BCA1C Offset: 0x37B8A1C VA: 0x37BCA1C
	public static void SetLongArrayElement(IntPtr array, int index, long val) { }

	[ThreadSafe]
	// RVA: 0x37BCA70 Offset: 0x37B8A70 VA: 0x37BCA70
	public static void SetFloatArrayElement(IntPtr array, int index, float val) { }

	[ThreadSafe]
	// RVA: 0x37BCAC4 Offset: 0x37B8AC4 VA: 0x37BCAC4
	public static void SetDoubleArrayElement(IntPtr array, int index, double val) { }

	[ThreadSafe]
	// RVA: 0x37BCB18 Offset: 0x37B8B18 VA: 0x37BCB18
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x37BCB6C Offset: 0x37B8B6C VA: 0x37BCB6C
	public static IntPtr NewDirectByteBuffer(byte* buffer, long capacity) { }

	// RVA: 0x37BCBB0 Offset: 0x37B8BB0 VA: 0x37BCBB0
	public static IntPtr NewDirectByteBuffer(NativeArray<byte> buffer) { }

	// RVA: 0x37BCC08 Offset: 0x37B8C08 VA: 0x37BCC08
	public static IntPtr NewDirectByteBuffer(NativeArray<sbyte> buffer) { }

	// RVA: -1 Offset: -1
	private static IntPtr NewDirectByteBufferFromNativeArray<T>(NativeArray<T> buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268AAA0 Offset: 0x2686AA0 VA: 0x268AAA0
	|-AndroidJNI.NewDirectByteBufferFromNativeArray<byte>
	|
	|-RVA: 0x268AB10 Offset: 0x2686B10 VA: 0x268AB10
	|-AndroidJNI.NewDirectByteBufferFromNativeArray<sbyte>
	|
	|-RVA: 0x268AB80 Offset: 0x2686B80 VA: 0x268AB80
	|-AndroidJNI.NewDirectByteBufferFromNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	[ThreadSafe]
	// RVA: 0x37BCC60 Offset: 0x37B8C60 VA: 0x37BCC60
	public static sbyte* GetDirectBufferAddress(IntPtr buffer) { }

	[ThreadSafe]
	// RVA: 0x37BCC9C Offset: 0x37B8C9C VA: 0x37BCC9C
	public static long GetDirectBufferCapacity(IntPtr buffer) { }

	// RVA: -1 Offset: -1
	private static NativeArray<T> GetDirectBuffer<T>(IntPtr buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268A724 Offset: 0x2686724 VA: 0x268A724
	|-AndroidJNI.GetDirectBuffer<byte>
	|
	|-RVA: 0x268A84C Offset: 0x268684C VA: 0x268A84C
	|-AndroidJNI.GetDirectBuffer<sbyte>
	|
	|-RVA: 0x268A974 Offset: 0x2686974 VA: 0x268A974
	|-AndroidJNI.GetDirectBuffer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x37BCCD8 Offset: 0x37B8CD8 VA: 0x37BCCD8
	public static NativeArray<byte> GetDirectByteBuffer(IntPtr buffer) { }

	// RVA: 0x37BCD20 Offset: 0x37B8D20 VA: 0x37BCD20
	public static NativeArray<sbyte> GetDirectSByteBuffer(IntPtr buffer) { }

	// RVA: 0x37BCD68 Offset: 0x37B8D68 VA: 0x37BCD68
	public static int RegisterNatives(IntPtr clazz, JNINativeMethod[] methods) { }

	[ThreadSafe]
	// RVA: 0x37BCEF8 Offset: 0x37B8EF8 VA: 0x37BCEF8
	private static IntPtr RegisterNativesAllocate(int length) { }

	[ThreadSafe]
	// RVA: 0x37BCF34 Offset: 0x37B8F34 VA: 0x37BCF34
	private static void RegisterNativesSet(IntPtr natives, int idx, string name, string signature, IntPtr fnPtr) { }

	[ThreadSafe]
	// RVA: 0x37BCFA0 Offset: 0x37B8FA0 VA: 0x37BCFA0
	private static int RegisterNativesAndFree(IntPtr clazz, IntPtr natives, int n) { }

	[ThreadSafe]
	// RVA: 0x37BCFF4 Offset: 0x37B8FF4 VA: 0x37BCFF4
	public static int UnregisterNatives(IntPtr clazz) { }
}
