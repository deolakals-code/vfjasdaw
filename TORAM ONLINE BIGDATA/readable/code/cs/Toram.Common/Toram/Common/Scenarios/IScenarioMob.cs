// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios
public interface IScenarioMob // TypeDefIndex: 11085
{
	// Properties
	public abstract byte No { get; }
	public abstract int FieldId { get; }
	public abstract int MonsterUuid { get; }
	public abstract short Current { get; set; }
	public abstract short SubdueNum { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte get_No();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_FieldId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_MonsterUuid();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract short get_Current();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_Current(short value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract short get_SubdueNum();
}
