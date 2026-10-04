// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaDuelAbilityManager // TypeDefIndex: 2115
{
	// Fields
	private const int MaxAbillityNum = 3;
	private readonly Dictionary<AbnormalType, MobaDuelAbilityType> AbnormalValidAbility; // 0x10
	private readonly Dictionary<AbnormalType, MobaDuelAbilityType[]> AbnormalResistAbilityType; // 0x18
	private readonly MobaDuelAbilityBase[] abilitys; // 0x20

	// Methods

	// RVA: 0x21461AC Offset: 0x21421AC VA: 0x21461AC
	public void .ctor() { }

	// RVA: 0x214640C Offset: 0x214240C VA: 0x214640C
	public void Initialize() { }

	// RVA: 0x214646C Offset: 0x214246C VA: 0x214646C
	public void InitializeServerUpdate(int[] server) { }

	// RVA: 0x2146410 Offset: 0x2142410 VA: 0x2146410
	public void Clear() { }

	// RVA: 0x21464DC Offset: 0x21424DC VA: 0x21464DC
	public void SetAbility(byte slotNo, int id) { }

	// RVA: 0x2146570 Offset: 0x2142570 VA: 0x2146570
	public bool TryGetAbility(int type, out MobaDuelAbilityBase slot1, out MobaDuelAbilityBase slot2, out MobaDuelAbilityBase slot3) { }

	// RVA: 0x21466CC Offset: 0x21426CC VA: 0x21466CC
	public int GetAbilityValue(int type) { }

	// RVA: 0x214675C Offset: 0x214275C VA: 0x214675C
	public bool ContaintsAbility(int type) { }

	// RVA: 0x2146838 Offset: 0x2142838 VA: 0x2146838
	public int GetAbnormalResistPercent(AbnormalType type) { }
}
