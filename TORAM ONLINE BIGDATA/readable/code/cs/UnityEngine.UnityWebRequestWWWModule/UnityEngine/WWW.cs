// Assembly: UnityEngine.UnityWebRequestWWWModule.dll
// Namespace: UnityEngine
[Obsolete("Use UnityWebRequest, a fully featured replacement which is more efficient and has additional features")]
public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 17823
{
	// Fields
	private UnityWebRequest _uwr; // 0x10
	private AssetBundle _assetBundle; // 0x18
	private Dictionary<string, string> _responseHeaders; // 0x20

	// Properties
	public AssetBundle assetBundle { get; }
	public byte[] bytes { get; }
	public string error { get; }
	public bool isDone { get; }
	public float progress { get; }
	public Dictionary<string, string> responseHeaders { get; }
	public string text { get; }
	public Texture2D texture { get; }
	public string url { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x3829AE8 Offset: 0x3825AE8 VA: 0x3829AE8
	public static WWW LoadFromCacheOrDownload(string url, int version) { }

	// RVA: 0x3829AF0 Offset: 0x3825AF0 VA: 0x3829AF0
	public static WWW LoadFromCacheOrDownload(string url, int version, uint crc) { }

	// RVA: 0x3829B44 Offset: 0x3825B44 VA: 0x3829B44
	public static WWW LoadFromCacheOrDownload(string url, Hash128 hash, uint crc) { }

	// RVA: 0x3829C90 Offset: 0x3825C90 VA: 0x3829C90
	public void .ctor(string url) { }

	// RVA: 0x3829CE0 Offset: 0x3825CE0 VA: 0x3829CE0
	public void .ctor(string url, WWWForm form) { }

	// RVA: 0x3829BDC Offset: 0x3825BDC VA: 0x3829BDC
	internal void .ctor(string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x3829D4C Offset: 0x3825D4C VA: 0x3829D4C
	public AssetBundle get_assetBundle() { }

	// RVA: 0x3829F44 Offset: 0x3825F44 VA: 0x3829F44
	public byte[] get_bytes() { }

	// RVA: 0x3829FD8 Offset: 0x3825FD8 VA: 0x3829FD8
	public string get_error() { }

	// RVA: 0x382A0F4 Offset: 0x38260F4 VA: 0x382A0F4
	public bool get_isDone() { }

	// RVA: 0x382A110 Offset: 0x3826110 VA: 0x382A110
	public float get_progress() { }

	// RVA: 0x382A138 Offset: 0x3826138 VA: 0x382A138
	public Dictionary<string, string> get_responseHeaders() { }

	// RVA: 0x382A300 Offset: 0x3826300 VA: 0x382A300
	public string get_text() { }

	// RVA: 0x382A390 Offset: 0x3826390 VA: 0x382A390
	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable) { }

	// RVA: 0x382A480 Offset: 0x3826480 VA: 0x382A480
	public Texture2D get_texture() { }

	// RVA: 0x382A488 Offset: 0x3826488 VA: 0x382A488
	public string get_url() { }

	// RVA: 0x382A4A4 Offset: 0x38264A4 VA: 0x382A4A4 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x382A4D0 Offset: 0x38264D0 VA: 0x382A4D0 Slot: 9
	public void Dispose() { }

	// RVA: 0x3829E60 Offset: 0x3825E60 VA: 0x3829E60
	private bool WaitUntilDoneIfPossible() { }
}
