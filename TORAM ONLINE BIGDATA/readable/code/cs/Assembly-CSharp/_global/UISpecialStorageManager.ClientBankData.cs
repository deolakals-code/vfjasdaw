// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UISpecialStorageManager.ClientBankData // TypeDefIndex: 7959
{
	// Fields
	public readonly int OneSetPoint; // 0x10
	public readonly long MaxPoint; // 0x18
	private readonly int updateDays; // 0x20
	private readonly int maxDeposit; // 0x24
	public BankDepositType[] BankTypes; // 0x28
	private BankData bankData; // 0x30

	// Properties
	public int UpdateDayTimer { get; }
	public int UseDepositCount { get; }
	public int FreeFee { get; }

	// Methods

	// RVA: 0x1C86228 Offset: 0x1C82228 VA: 0x1C86228
	public int get_UpdateDayTimer() { }

	// RVA: 0x1C86184 Offset: 0x1C82184 VA: 0x1C86184
	public int get_UseDepositCount() { }

	// RVA: 0x1C862F8 Offset: 0x1C822F8 VA: 0x1C862F8
	public int get_FreeFee() { }

	// RVA: 0x1C857E0 Offset: 0x1C817E0 VA: 0x1C857E0
	public void .ctor(int updateDays, int maxDeposit, long maxPoint, int oneSetPoint, BankDepositType[] bankTypes) { }

	// RVA: 0x1C8677C Offset: 0x1C8277C VA: 0x1C8677C
	public void UpdateBankData(BankData updateData) { }
}
