// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TradeManager // TypeDefIndex: 3799
{
	// Fields
	[CompilerGenerated]
	private TradeManager.TradeState <NowTradeState>k__BackingField; // 0x10
	private PlayerDataManager playerDataManager; // 0x18

	// Properties
	public TradeManager.TradeState NowTradeState { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23E7B88 Offset: 0x23E3B88 VA: 0x23E7B88
	public TradeManager.TradeState get_NowTradeState() { }

	[CompilerGenerated]
	// RVA: 0x23E7B90 Offset: 0x23E3B90 VA: 0x23E7B90
	private void set_NowTradeState(TradeManager.TradeState value) { }

	// RVA: 0x23E7B98 Offset: 0x23E3B98 VA: 0x23E7B98
	public void .ctor() { }

	// RVA: 0x23E7BCC Offset: 0x23E3BCC VA: 0x23E7BCC
	public void Request(int targetId) { }

	// RVA: 0x23E7C64 Offset: 0x23E3C64 VA: 0x23E7C64
	public void RequestCancel(int senderId) { }

	// RVA: 0x23E7CFC Offset: 0x23E3CFC VA: 0x23E7CFC
	public void RequestSenderCancel() { }

	// RVA: 0x23E7D84 Offset: 0x23E3D84 VA: 0x23E7D84
	public void RequestAcceptance(int senderId) { }

	// RVA: 0x23E7E1C Offset: 0x23E3E1C VA: 0x23E7E1C
	public void ReadyOk(ItemSelectData[] selectItems, long[] selectStarGemIds, int gold) { }

	// RVA: 0x23E7FAC Offset: 0x23E3FAC VA: 0x23E7FAC
	public void Cancel() { }

	// RVA: 0x23E8044 Offset: 0x23E4044 VA: 0x23E8044
	public void Confirm() { }

	// RVA: 0x23E80CC Offset: 0x23E40CC VA: 0x23E80CC
	public void ReceiveEventTradeRequest(TradeRequestEvent_ tradeEvent) { }

	// RVA: 0x23E8198 Offset: 0x23E4198 VA: 0x23E8198
	public void ReceiveEventTradeRequestCancel(TradeRequestSenderCancelEvent_ tradeEvent) { }

	// RVA: 0x23E82B4 Offset: 0x23E42B4 VA: 0x23E82B4
	public void ReceiveEventTradeStart(TradeStartEvent_ start) { }

	// RVA: 0x23E83A8 Offset: 0x23E43A8 VA: 0x23E83A8
	public void ReceiveEventTradeState(TradeStateEvent_ tradeEvent) { }

	// RVA: 0x23E83AC Offset: 0x23E43AC VA: 0x23E83AC
	public void ReceiveEventTradeApprovalStart(TradeApprovalStartEvent_ tradeEvent) { }

	// RVA: 0x23E847C Offset: 0x23E447C VA: 0x23E847C
	public void ReceiveEventTradeResult(TradeResultEvent_ result) { }

	// RVA: 0x23E85EC Offset: 0x23E45EC VA: 0x23E85EC
	public void ReceiveEventAbnormal() { }

	// RVA: 0x23E83A0 Offset: 0x23E43A0 VA: 0x23E83A0
	public void SetTradeState(TradeManager.TradeState state) { }

	// RVA: 0x23E8718 Offset: 0x23E4718 VA: 0x23E8718
	public void CancelPanel() { }
}
