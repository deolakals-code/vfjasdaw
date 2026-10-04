// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
[ExtensionOfNativeClass]
[RequiredByNativeCode]
public class MonoBehaviour : Behaviour // TypeDefIndex: 16360
{
	// Fields
	private CancellationTokenSource m_CancellationTokenSource; // 0x18

	// Properties
	public CancellationToken destroyCancellationToken { get; }
	public bool useGUILayout { get; set; }

	// Methods

	// RVA: 0x37ECB90 Offset: 0x37E8B90 VA: 0x37ECB90
	public CancellationToken get_destroyCancellationToken() { }

	[RequiredByNativeCode]
	// RVA: 0x37ECDC8 Offset: 0x37E8DC8 VA: 0x37ECDC8
	private void RaiseCancellation() { }

	// RVA: 0x37ECDDC Offset: 0x37E8DDC VA: 0x37ECDDC
	public bool IsInvoking() { }

	// RVA: 0x37ECE54 Offset: 0x37E8E54 VA: 0x37ECE54
	public void CancelInvoke() { }

	// RVA: 0x37ECECC Offset: 0x37E8ECC VA: 0x37ECECC
	public void Invoke(string methodName, float time) { }

	// RVA: 0x37ECF80 Offset: 0x37E8F80 VA: 0x37ECF80
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x37ED0B0 Offset: 0x37E90B0 VA: 0x37ED0B0
	public void CancelInvoke(string methodName) { }

	// RVA: 0x37ED138 Offset: 0x37E9138 VA: 0x37ED138
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocs]
	// RVA: 0x37ED1C0 Offset: 0x37E91C0 VA: 0x37ED1C0
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x37ED1C8 Offset: 0x37E91C8 VA: 0x37ED1C8
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x37ED364 Offset: 0x37E9364 VA: 0x37ED364
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", False)]
	// RVA: 0x37ED498 Offset: 0x37E9498 VA: 0x37ED498
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x37ED49C Offset: 0x37E949C VA: 0x37ED49C
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x37ED5D0 Offset: 0x37E95D0 VA: 0x37ED5D0
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x37ED704 Offset: 0x37E9704 VA: 0x37ED704
	public void StopCoroutine(string methodName) { }

	// RVA: 0x37ED748 Offset: 0x37E9748 VA: 0x37ED748
	public void StopAllCoroutines() { }

	// RVA: 0x37ED784 Offset: 0x37E9784 VA: 0x37ED784
	public bool get_useGUILayout() { }

	// RVA: 0x37ED7C0 Offset: 0x37E97C0 VA: 0x37ED7C0
	public void set_useGUILayout(bool value) { }

	// RVA: 0x37ED804 Offset: 0x37E9804 VA: 0x37ED804
	public static void print(object message) { }

	[FreeFunction("CancelInvoke")]
	// RVA: 0x37ECE90 Offset: 0x37E8E90 VA: 0x37ECE90
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunction("IsInvoking")]
	// RVA: 0x37ECE18 Offset: 0x37E8E18 VA: 0x37ECE18
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunction]
	// RVA: 0x37ECF24 Offset: 0x37E8F24 VA: 0x37ECF24
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunction]
	// RVA: 0x37ED0F4 Offset: 0x37E90F4 VA: 0x37ED0F4
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	// RVA: 0x37ED17C Offset: 0x37E917C VA: 0x37ED17C
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	// RVA: 0x37ED2D4 Offset: 0x37E92D4 VA: 0x37ED2D4
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x37ED310 Offset: 0x37E9310 VA: 0x37ED310
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x37ED454 Offset: 0x37E9454 VA: 0x37ED454
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x37ED6C0 Offset: 0x37E96C0 VA: 0x37ED6C0
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x37ED58C Offset: 0x37E958C VA: 0x37ED58C
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x37ED85C Offset: 0x37E985C VA: 0x37ED85C
	internal string GetScriptClassName() { }

	// RVA: 0x37ECD8C Offset: 0x37E8D8C VA: 0x37ECD8C
	private void OnCancellationTokenCreated() { }

	// RVA: 0x37ED898 Offset: 0x37E9898 VA: 0x37ED898
	public void .ctor() { }
}
