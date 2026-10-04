// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Trades
public enum TradeOperationCode // TypeDefIndex: 11697
{
	// Fields
	public int value__; // 0x0
	public const TradeOperationCode Nil = 0;
	public const TradeOperationCode Request = 1;
	public const TradeOperationCode Acceptance = 2;
	public const TradeOperationCode RequestCancel = 3;
	public const TradeOperationCode RequestSenderCancel = 4;
	public const TradeOperationCode ReadyOk = 5;
	public const TradeOperationCode Confirm = 6;
	public const TradeOperationCode Cancel = 7;
}
