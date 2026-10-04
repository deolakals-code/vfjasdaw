// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobPropertyLifeReduceDamage : MobPropertyBase // TypeDefIndex: 1108
{
	// Fields
	private GuildRaidBossMobActionManager baseMobActionManager; // 0x18
	private GuildRaidBossMobActionManager pairMobActionManager; // 0x20

	// Properties
	public override MonsterPropertyType PropertyType { get; }

	// Methods

	// RVA: 0x1F46770 Offset: 0x1F42770 VA: 0x1F46770
	public void .ctor() { }

	// RVA: 0x1F49154 Offset: 0x1F45154 VA: 0x1F49154 Slot: 4
	public override MonsterPropertyType get_PropertyType() { }

	// RVA: 0x1F4915C Offset: 0x1F4515C VA: 0x1F4915C
	public void SetBaseMonster(GuildRaidBossMobActionManager bossActionManager) { }

	// RVA: 0x1F49164 Offset: 0x1F45164 VA: 0x1F49164
	public void SetPairMonster(GuildRaidBossMobActionManager pairActionManager) { }

	// RVA: 0x1F4916C Offset: 0x1F4516C VA: 0x1F4916C
	public float CalcReduceLastDamageRate() { }

	// RVA: 0x1F492D4 Offset: 0x1F452D4 VA: 0x1F492D4
	public KeyValuePair<int, int> GetPairMobData() { }
}
