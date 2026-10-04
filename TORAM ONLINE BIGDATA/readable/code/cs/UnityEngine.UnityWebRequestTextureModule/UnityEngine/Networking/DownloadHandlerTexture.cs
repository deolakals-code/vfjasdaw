// Assembly: UnityEngine.UnityWebRequestTextureModule.dll
// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequestTexture/Public/DownloadHandlerTexture.h")]
public sealed class DownloadHandlerTexture : DownloadHandler // TypeDefIndex: 17874
{
	// Fields
	private NativeArray<byte> m_NativeData; // 0x18
	private bool mNonReadable; // 0x28

	// Properties
	public Texture2D texture { get; }

	// Methods

	// RVA: 0x3829810 Offset: 0x3825810 VA: 0x3829810
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x3829854 Offset: 0x3825854 VA: 0x3829854
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x38298A0 Offset: 0x38258A0 VA: 0x38298A0
	public void .ctor(bool readable) { }

	// RVA: 0x3829900 Offset: 0x3825900 VA: 0x3829900 Slot: 6
	protected override NativeArray<byte> GetNativeData() { }

	// RVA: 0x382990C Offset: 0x382590C VA: 0x382990C Slot: 5
	public override void Dispose() { }

	// RVA: 0x3829930 Offset: 0x3825930 VA: 0x3829930
	public Texture2D get_texture() { }

	[NativeThrows]
	// RVA: 0x382996C Offset: 0x382596C VA: 0x382996C
	private Texture2D InternalGetTextureNative() { }

	// RVA: 0x38299A8 Offset: 0x38259A8 VA: 0x38299A8
	public static Texture2D GetContent(UnityWebRequest www) { }
}
