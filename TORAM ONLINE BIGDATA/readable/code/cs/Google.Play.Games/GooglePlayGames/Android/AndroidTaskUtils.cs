// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.Android
internal class AndroidTaskUtils // TypeDefIndex: 16799
{
	// Methods

	// RVA: 0x2E2F9F0 Offset: 0x2E2B9F0 VA: 0x2E2F9F0
	private void .ctor() { }

	// RVA: -1 Offset: -1
	public static void AddOnSuccessListener<T>(AndroidJavaObject task, Action<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A6BB4 Offset: 0x26A2BB4 VA: 0x26A6BB4
	|-AndroidTaskUtils.AddOnSuccessListener<int>
	|
	|-RVA: 0x26A6D5C Offset: 0x26A2D5C VA: 0x26A6D5C
	|-AndroidTaskUtils.AddOnSuccessListener<object>
	|
	|-RVA: 0x26A6F04 Offset: 0x26A2F04 VA: 0x26A6F04
	|-AndroidTaskUtils.AddOnSuccessListener<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void AddOnSuccessListener<T>(AndroidJavaObject task, bool disposeResult, Action<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A70B0 Offset: 0x26A30B0 VA: 0x26A70B0
	|-AndroidTaskUtils.AddOnSuccessListener<object>
	|
	|-RVA: 0x26A725C Offset: 0x26A325C VA: 0x26A725C
	|-AndroidTaskUtils.AddOnSuccessListener<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E10CA0 Offset: 0x2E0CCA0 VA: 0x2E10CA0
	public static void AddOnFailureListener(AndroidJavaObject task, Action<AndroidJavaObject> callback) { }

	// RVA: -1 Offset: -1
	public static void AddOnCompleteListener<T>(AndroidJavaObject task, Action<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A6868 Offset: 0x26A2868 VA: 0x26A6868
	|-AndroidTaskUtils.AddOnCompleteListener<object>
	|
	|-RVA: 0x26A6A0C Offset: 0x26A2A0C VA: 0x26A6A0C
	|-AndroidTaskUtils.AddOnCompleteListener<__Il2CppFullySharedGenericType>
	*/
}
