// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public interface IAccountUserData // TypeDefIndex: 11362
{
	// Properties
	public abstract int AvatarUuid { get; }
	public abstract string Name { get; }
	public abstract short AccountLevel { get; }
	public abstract short ServerFPS { get; }
	public abstract LoginTermFlag LoginTermFlag { get; }
	public abstract bool IsAsobiMarket { get; }
	public abstract OffenderData[] OffenderList { get; }
	public abstract DateTime BanWordDate { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_AvatarUuid();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract short get_AccountLevel();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract short get_ServerFPS();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract LoginTermFlag get_LoginTermFlag();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAsobiMarket();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract OffenderData[] get_OffenderList();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract DateTime get_BanWordDate();
}
