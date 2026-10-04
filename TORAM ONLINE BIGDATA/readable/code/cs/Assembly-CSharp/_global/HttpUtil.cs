// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HttpUtil : Singleton<HttpUtil> // TypeDefIndex: 5493
{
	// Fields
	[SerializeField]
	private float timeout; // 0x20
	[SerializeField]
	private int maxRetry; // 0x24
	private readonly float retryWait; // 0x28
	private bool isCancel; // 0x2C
	private const string KEY_RESPONSE_HEADER_STATUS = "STATUS";

	// Methods

	[IteratorStateMachine(typeof(HttpUtil.<HttpPost>d__5))]
	// RVA: 0x177996C Offset: 0x177596C VA: 0x177996C
	public IEnumerator HttpPost(string url, WWWForm postData, Action<bool, string> callback, Action retryCallback) { }

	[IteratorStateMachine(typeof(HttpUtil.<HttpPost>d__6))]
	// RVA: 0x1779A60 Offset: 0x1775A60 VA: 0x1779A60
	public IEnumerator HttpPost(string url, float timeOut, WWWForm postData, Action<bool, string> callback, Action retryCallback) { }

	[IteratorStateMachine(typeof(HttpUtil.<HttpPost>d__7))]
	// RVA: 0x1779B64 Offset: 0x1775B64 VA: 0x1779B64
	public IEnumerator HttpPost(string url, WWWForm postData, Action<bool, string, int> callback) { }

	// RVA: 0x1779C44 Offset: 0x1775C44 VA: 0x1779C44
	public static int GetResponseCode(WWW www) { }

	// RVA: 0x1779D10 Offset: 0x1775D10 VA: 0x1779D10
	public static int ParseResponseCode(string responseStatus) { }

	[IteratorStateMachine(typeof(HttpUtil.<downloadCheckTimeOut>d__10))]
	// RVA: 0x1779DDC Offset: 0x1775DDC VA: 0x1779DDC
	private IEnumerator downloadCheckTimeOut(WWW www, float timeout, Action<string> timeoutCallback) { }

	[IteratorStateMachine(typeof(HttpUtil.<downloadCheckTimeOut>d__11))]
	// RVA: 0x1779E90 Offset: 0x1775E90 VA: 0x1779E90
	private IEnumerator downloadCheckTimeOut(UnityWebRequest www, float timeout, Action<string> timeoutCallback) { }

	// RVA: 0x1779F44 Offset: 0x1775F44 VA: 0x1779F44
	public void .ctor() { }
}
