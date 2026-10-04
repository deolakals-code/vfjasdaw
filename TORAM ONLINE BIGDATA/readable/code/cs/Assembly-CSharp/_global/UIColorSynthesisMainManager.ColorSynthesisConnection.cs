// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIColorSynthesisMainManager.ColorSynthesisConnection : ColorSynthesisExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6725
{
	// Fields
	private readonly UIColorSynthesisMainManager manager; // 0x38

	// Methods

	// RVA: 0x19CC4CC Offset: 0x19C84CC VA: 0x19CC4CC
	public void .ctor(ColorSynthesisType type, int mainGemId, int[] subGemIds, short magic, short super, short ultra, bool specifyColorPosition, byte colorPosition, UIColorSynthesisMainManager manager) { }

	// RVA: 0x19CC474 Offset: 0x19C8474 VA: 0x19CC474
	public void .ctor(short equipType, int mainGemId, int[] subGemIds, short magic, short super, short ultra, bool specifyColorPosition, byte colorPosition, UIColorSynthesisMainManager manager) { }

	// RVA: 0x19CC444 Offset: 0x19C8444 VA: 0x19CC444
	public void .ctor(int metalPoint, UIColorSynthesisMainManager manager) { }

	// RVA: 0x19CD0C0 Offset: 0x19C90C0 VA: 0x19CD0C0 Slot: 10
	protected override void OnSuccess(ColorSynthesisResponse response) { }

	// RVA: 0x19CD0D8 Offset: 0x19C90D8 VA: 0x19CD0D8 Slot: 11
	protected override void OnValueWrong() { }

	// RVA: 0x19CD130 Offset: 0x19C9130 VA: 0x19CD130 Slot: 12
	protected override void OnTypeWrong() { }

	// RVA: 0x19CD188 Offset: 0x19C9188 VA: 0x19CD188 Slot: 13
	protected override void OnGoldLimit() { }

	// RVA: 0x19CD1E0 Offset: 0x19C91E0 VA: 0x19CD1E0 Slot: 14
	protected override void OnFailure(short returnCode) { }
}
