// Assembly: UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public class Input // TypeDefIndex: 17768
{
	// Fields
	private static Gyroscope s_MainGyro; // 0x0

	// Properties
	[NativeThrows]
	public static bool anyKeyDown { get; }
	[NativeThrows]
	public static string inputString { get; }
	[NativeThrows]
	public static Vector3 mousePosition { get; }
	public static IMECompositionMode imeCompositionMode { set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { set; }
	public static int touchCount { get; }
	public static Vector3 acceleration { get; }
	public static Gyroscope gyro { get; }
	public static Touch[] touches { get; }

	// Methods

	// RVA: 0x38168C4 Offset: 0x38128C4 VA: 0x38168C4
	public static float GetAxis(string axisName) { }

	[NativeThrows]
	// RVA: 0x381693C Offset: 0x381293C VA: 0x381693C
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x3816978 Offset: 0x3812978 VA: 0x3816978
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x38169B4 Offset: 0x38129B4 VA: 0x38169B4
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x38169F0 Offset: 0x38129F0 VA: 0x38169F0
	public static bool GetMouseButton(int button) { }

	[NativeThrows]
	// RVA: 0x3816A2C Offset: 0x3812A2C VA: 0x3816A2C
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrows]
	// RVA: 0x3816A68 Offset: 0x3812A68 VA: 0x3816A68
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrows]
	// RVA: 0x3816AA4 Offset: 0x3812AA4 VA: 0x3816AA4
	public static Touch GetTouch(int index) { }

	// RVA: 0x3816B58 Offset: 0x3812B58 VA: 0x3816B58
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x3816B94 Offset: 0x3812B94 VA: 0x3816B94
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x3816BD0 Offset: 0x3812BD0 VA: 0x3816BD0
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x3816C0C Offset: 0x3812C0C VA: 0x3816C0C
	public static bool get_anyKeyDown() { }

	// RVA: 0x3816C34 Offset: 0x3812C34 VA: 0x3816C34
	public static string get_inputString() { }

	// RVA: 0x3816C5C Offset: 0x3812C5C VA: 0x3816C5C
	public static Vector3 get_mousePosition() { }

	// RVA: 0x3816CE4 Offset: 0x3812CE4 VA: 0x3816CE4
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x3816D20 Offset: 0x3812D20 VA: 0x3816D20
	public static string get_compositionString() { }

	// RVA: 0x3816D48 Offset: 0x3812D48 VA: 0x3816D48
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunction("GetTouchCount")]
	// RVA: 0x3816DC4 Offset: 0x3812DC4 VA: 0x3816DC4
	public static int get_touchCount() { }

	[FreeFunction("GetAcceleration")]
	// RVA: 0x3816DEC Offset: 0x3812DEC VA: 0x3816DEC
	public static Vector3 get_acceleration() { }

	[FreeFunction("GetGyro")]
	// RVA: 0x3816E74 Offset: 0x3812E74 VA: 0x3816E74
	private static int GetGyroInternal() { }

	// RVA: 0x3816E9C Offset: 0x3812E9C VA: 0x3816E9C
	public static Gyroscope get_gyro() { }

	// RVA: 0x3816F68 Offset: 0x3812F68 VA: 0x3816F68
	public static Touch[] get_touches() { }

	// RVA: 0x38170A8 Offset: 0x38130A8 VA: 0x38170A8
	internal static bool CheckDisabled() { }

	// RVA: 0x3816B14 Offset: 0x3812B14 VA: 0x3816B14
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x3816CA8 Offset: 0x3812CA8 VA: 0x3816CA8
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x3816D88 Offset: 0x3812D88 VA: 0x3816D88
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	// RVA: 0x3816E38 Offset: 0x3812E38 VA: 0x3816E38
	private static void get_acceleration_Injected(out Vector3 ret) { }
}
