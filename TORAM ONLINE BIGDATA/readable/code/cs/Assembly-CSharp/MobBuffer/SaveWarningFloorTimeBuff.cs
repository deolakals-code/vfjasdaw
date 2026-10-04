// Assembly: Assembly-CSharp.dll
// Namespace: MobBuffer
public class SaveWarningFloorTimeBuff : MobBuffBase // TypeDefIndex: 9308
{
	// Properties
	public override MobBuffId Id { get; }

	// Methods

	// RVA: 0x1EBAB40 Offset: 0x1EB6B40 VA: 0x1EBAB40
	public void .ctor(MobActionPattern pattern) { }

	// RVA: 0x1EBAB44 Offset: 0x1EB6B44 VA: 0x1EBAB44
	public void .ctor(MobBuffData buffData) { }

	// RVA: 0x1EBAB48 Offset: 0x1EB6B48 VA: 0x1EBAB48 Slot: 4
	public override MobBuffId get_Id() { }

	// RVA: 0x1EBAB50 Offset: 0x1EB6B50 VA: 0x1EBAB50
	public bool HasFlag(SaveWarningFloorTimeBuff.FlagId id) { }

	// RVA: 0x1EBAB90 Offset: 0x1EB6B90 VA: 0x1EBAB90 Slot: 7
	public override int GetValue() { }

	// RVA: 0x1EBABB8 Offset: 0x1EB6BB8 VA: 0x1EBABB8
	public static bool TryGetTime(EnemyMobActionManagerBase actionManager, SaveWarningFloorTimeBuff.FlagId type, out float time) { }
}
