// Assembly: UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
public class CertificateHandler // TypeDefIndex: 17603
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x3826FF8 Offset: 0x3822FF8 VA: 0x3826FF8
	private void Release() { }

	// RVA: 0x3827034 Offset: 0x3823034 VA: 0x3827034 Slot: 4
	protected virtual bool ValidateCertificate(byte[] certificateData) { }

	[RequiredByNativeCode]
	// RVA: 0x382703C Offset: 0x382303C VA: 0x382703C
	internal bool ValidateCertificateNative(byte[] certificateData) { }

	// RVA: 0x3827048 Offset: 0x3823048 VA: 0x3827048 Slot: 5
	public void Dispose() { }
}
