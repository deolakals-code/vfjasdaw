// Assembly: Assembly-CSharp.dll
// Namespace: 
private sealed class SoundPlayer.VolumeAction : MulticastDelegate // TypeDefIndex: 5212
{
	// Methods

	// RVA: 0x260E1FC Offset: 0x260A1FC VA: 0x260E1FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x260E5C8 Offset: 0x260A5C8 VA: 0x260E5C8 Slot: 12
	public virtual float Invoke(float sqrDist) { }

	// RVA: 0x260E5DC Offset: 0x260A5DC VA: 0x260E5DC Slot: 13
	public virtual IAsyncResult BeginInvoke(float sqrDist, AsyncCallback callback, object object) { }

	// RVA: 0x260E660 Offset: 0x260A660 VA: 0x260E660 Slot: 14
	public virtual float EndInvoke(IAsyncResult result) { }
}
