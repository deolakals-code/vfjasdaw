// Assembly: UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
public sealed class UploadHandlerRaw : UploadHandler // TypeDefIndex: 17612
{
	// Fields
	private NativeArray<byte> m_Payload; // 0x18

	// Methods

	// RVA: 0x3829664 Offset: 0x3825664 VA: 0x3829664
	private static IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength) { }

	// RVA: 0x382940C Offset: 0x382540C VA: 0x382940C
	public void .ctor(byte[] data) { }

	// RVA: 0x38296B8 Offset: 0x38256B8 VA: 0x38296B8
	public void .ctor(NativeArray<byte> data, bool transferOwnership) { }

	// RVA: 0x38297AC Offset: 0x38257AC VA: 0x38297AC Slot: 5
	public override void Dispose() { }
}
