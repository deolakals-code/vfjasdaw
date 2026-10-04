// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobBuffManager // TypeDefIndex: 860
{
	// Fields
	public static readonly MobBuffId[] DebuffIds; // 0x0
	private Dictionary<MobBuffId, MobBuffBase> buffs; // 0x10
	private List<MobBuffId> addBuff; // 0x18
	[CompilerGenerated]
	private int <UpdateId>k__BackingField; // 0x20

	// Properties
	public int UpdateId { get; set; }
	private List<MobBuffId> addBuffList { get; }

	// Methods

	// RVA: 0x1ECE5FC Offset: 0x1ECA5FC VA: 0x1ECE5FC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1ECE6D8 Offset: 0x1ECA6D8 VA: 0x1ECE6D8
	public int get_UpdateId() { }

	[CompilerGenerated]
	// RVA: 0x1ECE6E0 Offset: 0x1ECA6E0 VA: 0x1ECE6E0
	private void set_UpdateId(int value) { }

	// RVA: 0x1ECE6E8 Offset: 0x1ECA6E8 VA: 0x1ECE6E8
	private List<MobBuffId> get_addBuffList() { }

	// RVA: 0x1ECE720 Offset: 0x1ECA720 VA: 0x1ECE720
	public void Update() { }

	// RVA: 0x1ECEC1C Offset: 0x1ECAC1C VA: 0x1ECEC1C
	public void Clear() { }

	// RVA: 0x1ECED44 Offset: 0x1ECAD44 VA: 0x1ECED44
	public bool Contains(MobBuffId id) { }

	// RVA: 0x1ECED9C Offset: 0x1ECAD9C VA: 0x1ECED9C
	public bool AddBuff(MobBuffBase buff) { }

	// RVA: 0x1ECEAB8 Offset: 0x1ECAAB8 VA: 0x1ECEAB8
	public void RemoveBuff(MobBuffId id) { }

	// RVA: 0x1EC881C Offset: 0x1EC481C VA: 0x1EC881C
	public int GetValue(MobBuffId id) { }

	// RVA: 0x1EC3ED8 Offset: 0x1EBFED8 VA: 0x1EC3ED8
	public bool TryGetBuff(MobBuffId id, out MobBuffBase buff) { }

	// RVA: 0x1ECEFC0 Offset: 0x1ECAFC0 VA: 0x1ECEFC0
	public void ChangeHyperMode() { }

	// RVA: 0x1ECF21C Offset: 0x1ECB21C VA: 0x1ECF21C
	public List<KeyValuePair<MobBuffId, byte>> GetViewBufferList() { }

	// RVA: 0x1ECF414 Offset: 0x1ECB414 VA: 0x1ECF414
	public int GetDebuffCount() { }

	// RVA: 0x1ECF5DC Offset: 0x1ECB5DC VA: 0x1ECF5DC
	public static MobBuffBase CreateBuff(MobActionPattern pattern) { }

	// RVA: 0x1ECF828 Offset: 0x1ECB828 VA: 0x1ECF828
	public static MobBuffBase CreateBuff(MobBuffData buffData) { }

	// RVA: 0x1ECFD5C Offset: 0x1ECBD5C VA: 0x1ECFD5C
	private static void .cctor() { }
}
