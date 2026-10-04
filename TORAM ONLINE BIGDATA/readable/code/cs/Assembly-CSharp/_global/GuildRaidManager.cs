// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildRaidManager // TypeDefIndex: 1927
{
	// Fields
	public static readonly int[] ItemIds; // 0x0
	[CompilerGenerated]
	private int <ActiveRaidId>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsPractice>k__BackingField; // 0x14
	[CompilerGenerated]
	private ElementType <ActiveRaidElementType>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <ActiveAllianceRaidId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private ElementType <ActiveAllianceRaidElementType>k__BackingField; // 0x20
	private Dictionary<byte, GuildRaidManager.RaidHeldData> heldData; // 0x28
	private Dictionary<int, int> raidItem; // 0x30
	private bool isInit; // 0x38
	private DateTime heldDataLastUpdateTime; // 0x40
	private Dictionary<int, byte> raidElementList; // 0x48

	// Properties
	public int ActiveRaidId { get; set; }
	public bool IsPractice { get; set; }
	public ElementType ActiveRaidElementType { get; set; }
	public int ActiveAllianceRaidId { get; set; }
	public ElementType ActiveAllianceRaidElementType { get; set; }

	// Methods

	// RVA: 0x2108510 Offset: 0x2104510 VA: 0x2108510
	public static int[] SeparationItemData(int num) { }

	// RVA: 0x21085D8 Offset: 0x21045D8 VA: 0x21085D8
	public static bool IsReleaseElement(ElementType type) { }

	// RVA: 0x21085E8 Offset: 0x21045E8 VA: 0x21085E8
	public static bool TryGetItemElement(int itemId, out ElementType type) { }

	[CompilerGenerated]
	// RVA: 0x2108608 Offset: 0x2104608 VA: 0x2108608
	private void set_ActiveRaidId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2108610 Offset: 0x2104610 VA: 0x2108610
	public int get_ActiveRaidId() { }

	[CompilerGenerated]
	// RVA: 0x2108618 Offset: 0x2104618 VA: 0x2108618
	private void set_IsPractice(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2108624 Offset: 0x2104624 VA: 0x2108624
	public bool get_IsPractice() { }

	[CompilerGenerated]
	// RVA: 0x210862C Offset: 0x210462C VA: 0x210862C
	private void set_ActiveRaidElementType(ElementType value) { }

	[CompilerGenerated]
	// RVA: 0x2108634 Offset: 0x2104634 VA: 0x2108634
	public ElementType get_ActiveRaidElementType() { }

	[CompilerGenerated]
	// RVA: 0x210863C Offset: 0x210463C VA: 0x210863C
	private void set_ActiveAllianceRaidId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2108644 Offset: 0x2104644 VA: 0x2108644
	public int get_ActiveAllianceRaidId() { }

	[CompilerGenerated]
	// RVA: 0x210864C Offset: 0x210464C VA: 0x210864C
	private void set_ActiveAllianceRaidElementType(ElementType value) { }

	[CompilerGenerated]
	// RVA: 0x2108654 Offset: 0x2104654 VA: 0x2108654
	public ElementType get_ActiveAllianceRaidElementType() { }

	// RVA: 0x20FE800 Offset: 0x20FA800 VA: 0x20FE800
	public void Initialize(GuildRaidData data, GuildItemData[] itemData) { }

	// RVA: 0x20FE488 Offset: 0x20FA488 VA: 0x20FE488
	public void Clear() { }

	// RVA: 0x210889C Offset: 0x210489C VA: 0x210889C
	public void GetServerHeldData() { }

	// RVA: 0x210865C Offset: 0x210465C VA: 0x210865C
	public void UpdateHeldData(GuildRaidData data) { }

	// RVA: 0x2108978 Offset: 0x2104978 VA: 0x2108978
	public void ReceiveGuildGetHeldRaidData(GuildRaidHeldData[] helds) { }

	// RVA: 0x2108B30 Offset: 0x2104B30 VA: 0x2108B30
	public void UpdateActiveHeldData(int raidId, GuildRaidHeldData held) { }

	// RVA: 0x2107A54 Offset: 0x2103A54 VA: 0x2107A54
	public void UpdateAllianceActiveHeldData(int raidId, byte elemet) { }

	// RVA: 0x21087E0 Offset: 0x21047E0 VA: 0x21087E0
	public bool TryGetRaidIdRaidHeldData(int id, out GuildRaidManager.RaidHeldData data) { }

	// RVA: 0x2108B98 Offset: 0x2104B98 VA: 0x2108B98
	public bool CheckSummonPlayElement(byte element) { }

	// RVA: 0x2108E64 Offset: 0x2104E64 VA: 0x2108E64
	public int GetItemNum(int itemId) { }

	// RVA: 0x2108EDC Offset: 0x2104EDC VA: 0x2108EDC
	public int GetElementItemNum(ElementType type) { }

	// RVA: 0x21086D8 Offset: 0x21046D8 VA: 0x21086D8
	public void UpdateItemData(GuildItemData[] items) { }

	// RVA: 0x2108A4C Offset: 0x2104A4C VA: 0x2108A4C
	private void UpdateHeldData(GuildRaidHeldData held) { }

	// RVA: 0x21072C8 Offset: 0x21032C8 VA: 0x21072C8
	public void .ctor() { }

	// RVA: 0x2109088 Offset: 0x2105088 VA: 0x2109088
	private static void .cctor() { }
}
