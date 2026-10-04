// Assembly: Assembly-CSharp.dll
// Namespace: 
private abstract class UIPartyApplicantManager.BaseApplicantData // TypeDefIndex: 7671
{
	// Properties
	public abstract string LocalizeKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_LocalizeKey();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool GameServerOperation(int targetId);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool IsConnect();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool TryGetErr(out short returnCode);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Clear(int userId);

	// RVA: 0x1BE0940 Offset: 0x1BDC940 VA: 0x1BE0940
	protected void .ctor() { }
}
