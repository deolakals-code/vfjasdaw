// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIHighRaidPointShopManager.GetHighRaidTrophys : GetHighRaidTrophysExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 5808
{
	// Fields
	private UIHighRaidPointShopManager manager; // 0x18

	// Methods

	// RVA: 0x17FB6B8 Offset: 0x17F76B8 VA: 0x17FB6B8
	public void .ctor(UIHighRaidPointShopManager manager, byte highRaidNo) { }

	// RVA: 0x17FB6EC Offset: 0x17F76EC VA: 0x17FB6EC Slot: 13
	protected override void OnDataNull() { }

	// RVA: 0x17FB6F0 Offset: 0x17F76F0 VA: 0x17FB6F0 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x17FB6F4 Offset: 0x17F76F4 VA: 0x17FB6F4 Slot: 12
	protected override void OnInvalidOperationParameter() { }

	// RVA: 0x17FB6F8 Offset: 0x17F76F8 VA: 0x17FB6F8 Slot: 14
	protected override void OnNotBeHeld() { }

	// RVA: 0x17FB6FC Offset: 0x17F76FC VA: 0x17FB6FC Slot: 15
	protected override void OnSqlError() { }

	// RVA: 0x17FB700 Offset: 0x17F7700 VA: 0x17FB700 Slot: 10
	protected override void OnSuccess(byte highRaidNo, Dictionary<byte, byte> trophys) { }
}
