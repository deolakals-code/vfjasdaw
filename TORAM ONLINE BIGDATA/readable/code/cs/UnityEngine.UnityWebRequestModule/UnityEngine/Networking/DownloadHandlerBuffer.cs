// Assembly: UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
public sealed class DownloadHandlerBuffer : DownloadHandler // TypeDefIndex: 17605
{
	// Fields
	private NativeArray<byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x38277DC Offset: 0x38237DC VA: 0x38277DC
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x3827818 Offset: 0x3823818 VA: 0x3827818
	private void InternalCreateBuffer() { }

	// RVA: 0x382785C Offset: 0x382385C VA: 0x382785C
	public void .ctor() { }

	// RVA: 0x38278A8 Offset: 0x38238A8 VA: 0x38278A8 Slot: 6
	protected override NativeArray<byte> GetNativeData() { }

	// RVA: 0x38278B0 Offset: 0x38238B0 VA: 0x38278B0 Slot: 5
	public override void Dispose() { }
}
