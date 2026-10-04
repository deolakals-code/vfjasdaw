// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class ItemUseResponseData : UnityHashBase // TypeDefIndex: 13186
{
	// Fields
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private ItemDatav2 <ItemData>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <AddItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private WarrantyItemDatav2[] <AddWarrantyList>k__BackingField; // 0x30
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x38
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte[] <RemoveAbnormalState>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte[] <RemoveAbnormalStateLocalId>k__BackingField; // 0x50
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x58
	[CompilerGenerated]
	private byte <ReturnCode>k__BackingField; // 0x60
	[CompilerGenerated]
	private Dictionary<byte, int> <Variables>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsSavingTechnique>k__BackingField; // 0x70

	// Properties
	public int ItemUuid { get; set; }
	public ItemDatav2 ItemData { get; set; }
	public ItemDatav2[] AddItemList { get; set; }
	public WarrantyItemDatav2[] AddWarrantyList { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public byte[] RemoveAbnormalState { get; set; }
	public byte[] RemoveAbnormalStateLocalId { get; set; }
	public Dictionary<short, byte> SkillList { get; set; }
	public byte ReturnCode { get; set; }
	public Dictionary<byte, int> Variables { get; set; }
	public bool IsSavingTechnique { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C2214 Offset: 0x36BE214 VA: 0x36C2214
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36C221C Offset: 0x36BE21C VA: 0x36C221C
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x36C2224 Offset: 0x36BE224 VA: 0x36C2224
	public void set_ItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C222C Offset: 0x36BE22C VA: 0x36C222C
	public ItemDatav2 get_ItemData() { }

	[CompilerGenerated]
	// RVA: 0x36C2234 Offset: 0x36BE234 VA: 0x36C2234
	public void set_ItemData(ItemDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x36C223C Offset: 0x36BE23C VA: 0x36C223C
	public ItemDatav2[] get_AddItemList() { }

	[CompilerGenerated]
	// RVA: 0x36C2244 Offset: 0x36BE244 VA: 0x36C2244
	public void set_AddItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C224C Offset: 0x36BE24C VA: 0x36C224C
	public WarrantyItemDatav2[] get_AddWarrantyList() { }

	[CompilerGenerated]
	// RVA: 0x36C2254 Offset: 0x36BE254 VA: 0x36C2254
	public void set_AddWarrantyList(WarrantyItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C225C Offset: 0x36BE25C VA: 0x36C225C
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x36C2264 Offset: 0x36BE264 VA: 0x36C2264
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x36C226C Offset: 0x36BE26C VA: 0x36C226C
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36C2274 Offset: 0x36BE274 VA: 0x36C2274
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36C227C Offset: 0x36BE27C VA: 0x36C227C
	public byte[] get_RemoveAbnormalState() { }

	[CompilerGenerated]
	// RVA: 0x36C2284 Offset: 0x36BE284 VA: 0x36C2284
	public void set_RemoveAbnormalState(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C228C Offset: 0x36BE28C VA: 0x36C228C
	public byte[] get_RemoveAbnormalStateLocalId() { }

	[CompilerGenerated]
	// RVA: 0x36C2294 Offset: 0x36BE294 VA: 0x36C2294
	public void set_RemoveAbnormalStateLocalId(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C229C Offset: 0x36BE29C VA: 0x36C229C
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x36C22A4 Offset: 0x36BE2A4 VA: 0x36C22A4
	public void set_SkillList(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x36C22AC Offset: 0x36BE2AC VA: 0x36C22AC
	public byte get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x36C22B4 Offset: 0x36BE2B4 VA: 0x36C22B4
	public void set_ReturnCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C22BC Offset: 0x36BE2BC VA: 0x36C22BC
	public Dictionary<byte, int> get_Variables() { }

	[CompilerGenerated]
	// RVA: 0x36C22C4 Offset: 0x36BE2C4 VA: 0x36C22C4
	public void set_Variables(Dictionary<byte, int> value) { }

	[CompilerGenerated]
	// RVA: 0x36C22CC Offset: 0x36BE2CC VA: 0x36C22CC
	public bool get_IsSavingTechnique() { }

	[CompilerGenerated]
	// RVA: 0x36C22D4 Offset: 0x36BE2D4 VA: 0x36C22D4
	public void set_IsSavingTechnique(bool value) { }

	// RVA: 0x36C22E0 Offset: 0x36BE2E0 VA: 0x36C22E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C22E8 Offset: 0x36BE2E8 VA: 0x36C22E8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C2C40 Offset: 0x36BEC40 VA: 0x36C2C40 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
