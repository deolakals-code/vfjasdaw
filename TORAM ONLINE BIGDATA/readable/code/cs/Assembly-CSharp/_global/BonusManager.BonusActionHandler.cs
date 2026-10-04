// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class BonusManager.BonusActionHandler : MulticastDelegate // TypeDefIndex: 1730
{
	// Methods

	// RVA: 0x20BCA10 Offset: 0x20B8A10 VA: 0x20BCA10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x20BCB1C Offset: 0x20B8B1C VA: 0x20BCB1C Slot: 12
	public virtual void Invoke(BonusData bonus, ReflectionBonusParameter bonusData) { }

	// RVA: 0x20BCB30 Offset: 0x20B8B30 VA: 0x20BCB30 Slot: 13
	public virtual IAsyncResult BeginInvoke(BonusData bonus, ReflectionBonusParameter bonusData, AsyncCallback callback, object object) { }

	// RVA: 0x20BCB58 Offset: 0x20B8B58 VA: 0x20BCB58 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
