// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public interface IAccountGameData // TypeDefIndex: 11361
{
	// Properties
	public abstract MaterialData[] MaterialList { get; }
	public abstract byte[] TrophyData { get; }
	public abstract ScenarioList ScenarioList { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MaterialData[] get_MaterialList();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte[] get_TrophyData();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ScenarioList get_ScenarioList();
}
