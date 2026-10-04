// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.OurUtils
public class PlayGamesHelperObject : MonoBehaviour // TypeDefIndex: 16809
{
	// Fields
	private static PlayGamesHelperObject instance; // 0x0
	private static bool sIsDummy; // 0x8
	private static List<Action> sQueue; // 0x10
	private List<Action> localQueue; // 0x20
	private static bool sQueueEmpty; // 0x18
	private static List<Action<bool>> sPauseCallbackList; // 0x20
	private static List<Action<bool>> sFocusCallbackList; // 0x28

	// Methods

	// RVA: 0x2E0FF58 Offset: 0x2E0BF58 VA: 0x2E0FF58
	public static void CreateObject() { }

	// RVA: 0x2E30B80 Offset: 0x2E2CB80 VA: 0x2E30B80
	public void Awake() { }

	// RVA: 0x2E30BEC Offset: 0x2E2CBEC VA: 0x2E30BEC
	public void OnDisable() { }

	// RVA: 0x2E0F52C Offset: 0x2E0B52C VA: 0x2E0F52C
	public static void RunCoroutine(IEnumerator action) { }

	// RVA: 0x2E13504 Offset: 0x2E0F504 VA: 0x2E13504
	public static void RunOnGameThread(Action action) { }

	// RVA: 0x2E30CC0 Offset: 0x2E2CCC0 VA: 0x2E30CC0
	public void Update() { }

	// RVA: 0x2E30F38 Offset: 0x2E2CF38 VA: 0x2E30F38
	public void OnApplicationFocus(bool focused) { }

	// RVA: 0x2E31210 Offset: 0x2E2D210 VA: 0x2E31210
	public void OnApplicationPause(bool paused) { }

	// RVA: 0x2E314E8 Offset: 0x2E2D4E8 VA: 0x2E314E8
	public static void AddFocusCallback(Action<bool> callback) { }

	// RVA: 0x2E3160C Offset: 0x2E2D60C VA: 0x2E3160C
	public static bool RemoveFocusCallback(Action<bool> callback) { }

	// RVA: 0x2E3168C Offset: 0x2E2D68C VA: 0x2E3168C
	public static void AddPauseCallback(Action<bool> callback) { }

	// RVA: 0x2E317B0 Offset: 0x2E2D7B0 VA: 0x2E317B0
	public static bool RemovePauseCallback(Action<bool> callback) { }

	// RVA: 0x2E30AF8 Offset: 0x2E2CAF8 VA: 0x2E30AF8
	public void .ctor() { }

	// RVA: 0x2E31830 Offset: 0x2E2D830 VA: 0x2E31830
	private static void .cctor() { }
}
