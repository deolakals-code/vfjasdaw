// Assembly: Toram.Common.dll
// Namespace: 
public class EnterAvatarData2.AvatarPack : PacketBase, IStatusData, IAccountGameData, IItemBagData // TypeDefIndex: 11365
{
	// Fields
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private AvatarGameStatusData <AvatarGameStatus>k__BackingField; // 0x30
	[CompilerGenerated]
	private AvatarEquipData <AvatarEquip>k__BackingField; // 0x38
	[CompilerGenerated]
	private short[] <InventoryCapacity>k__BackingField; // 0x40
	[CompilerGenerated]
	private InventoryPackData <ItemBag>k__BackingField; // 0x48
	[CompilerGenerated]
	private WarrantyItemPackData <WarrantyBag>k__BackingField; // 0x50
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x58
	[CompilerGenerated]
	private SkillComboData[] <SkillCombo>k__BackingField; // 0x60
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x68
	[CompilerGenerated]
	private ProficiencyData <ProficiencyData>k__BackingField; // 0x70
	[CompilerGenerated]
	private byte[] <TrophyData>k__BackingField; // 0x78
	[CompilerGenerated]
	private ScenarioList <ScenarioList>k__BackingField; // 0x80
	[CompilerGenerated]
	private StarGemEquipData[] <StarGemEquips>k__BackingField; // 0x88
	[CompilerGenerated]
	private RegistletData <RegistletData>k__BackingField; // 0x90
	[CompilerGenerated]
	private GemCartData[] <GemCartBag>k__BackingField; // 0x98
	[CompilerGenerated]
	private GemCartEquipData[] <GemCartEquipList>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Dictionary<short, byte[]> <ExSkillConfigList>k__BackingField; // 0xA8
	[CompilerGenerated]
	private RoguelikeRingData[] <RoguelikeRings>k__BackingField; // 0xB0
	[CompilerGenerated]
	private RoguelikeRingEquipData[] <RoguelikeRingEquips>k__BackingField; // 0xB8

	// Properties
	public PrimaryStatusData PrimaryStatus { get; set; }
	public GameStatusData GameStatus { get; set; }
	public AvatarGameStatusData AvatarGameStatus { get; set; }
	public AvatarEquipData AvatarEquip { get; set; }
	public short[] InventoryCapacity { get; set; }
	public InventoryPackData ItemBag { get; set; }
	public WarrantyItemPackData WarrantyBag { get; set; }
	public Dictionary<short, byte> SkillList { get; set; }
	public SkillComboData[] SkillCombo { get; set; }
	public MaterialData[] MaterialList { get; set; }
	public ProficiencyData ProficiencyData { get; set; }
	public byte[] TrophyData { get; set; }
	public ScenarioList ScenarioList { get; set; }
	public StarGemEquipData[] StarGemEquips { get; set; }
	public RegistletData RegistletData { get; set; }
	public GemCartData[] GemCartBag { get; set; }
	public GemCartEquipData[] GemCartEquipList { get; set; }
	public Dictionary<short, byte[]> ExSkillConfigList { get; set; }
	public RoguelikeRingData[] RoguelikeRings { get; set; }
	public RoguelikeRingEquipData[] RoguelikeRingEquips { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36F4430 Offset: 0x36F0430 VA: 0x36F4430
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36F45F0 Offset: 0x36F05F0 VA: 0x36F45F0 Slot: 7
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x36F45F8 Offset: 0x36F05F8 VA: 0x36F45F8
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36F4600 Offset: 0x36F0600 VA: 0x36F4600 Slot: 8
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x36F4608 Offset: 0x36F0608 VA: 0x36F4608
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36F4610 Offset: 0x36F0610 VA: 0x36F4610 Slot: 9
	public AvatarGameStatusData get_AvatarGameStatus() { }

	[CompilerGenerated]
	// RVA: 0x36F4618 Offset: 0x36F0618 VA: 0x36F4618
	public void set_AvatarGameStatus(AvatarGameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36F4620 Offset: 0x36F0620 VA: 0x36F4620 Slot: 21
	public AvatarEquipData get_AvatarEquip() { }

	[CompilerGenerated]
	// RVA: 0x36F4628 Offset: 0x36F0628 VA: 0x36F4628
	public void set_AvatarEquip(AvatarEquipData value) { }

	[CompilerGenerated]
	// RVA: 0x36F4630 Offset: 0x36F0630 VA: 0x36F4630 Slot: 22
	public short[] get_InventoryCapacity() { }

	[CompilerGenerated]
	// RVA: 0x36F4638 Offset: 0x36F0638 VA: 0x36F4638
	public void set_InventoryCapacity(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F4640 Offset: 0x36F0640 VA: 0x36F4640 Slot: 23
	public InventoryPackData get_ItemBag() { }

	[CompilerGenerated]
	// RVA: 0x36F4648 Offset: 0x36F0648 VA: 0x36F4648
	public void set_ItemBag(InventoryPackData value) { }

	[CompilerGenerated]
	// RVA: 0x36F4650 Offset: 0x36F0650 VA: 0x36F4650 Slot: 24
	public WarrantyItemPackData get_WarrantyBag() { }

	[CompilerGenerated]
	// RVA: 0x36F4658 Offset: 0x36F0658 VA: 0x36F4658
	public void set_WarrantyBag(WarrantyItemPackData value) { }

	[CompilerGenerated]
	// RVA: 0x36F4660 Offset: 0x36F0660 VA: 0x36F4660 Slot: 10
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x36F4668 Offset: 0x36F0668 VA: 0x36F4668
	public void set_SkillList(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x36F4670 Offset: 0x36F0670 VA: 0x36F4670 Slot: 11
	public SkillComboData[] get_SkillCombo() { }

	[CompilerGenerated]
	// RVA: 0x36F4678 Offset: 0x36F0678 VA: 0x36F4678
	public void set_SkillCombo(SkillComboData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F4680 Offset: 0x36F0680 VA: 0x36F4680 Slot: 18
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x36F4688 Offset: 0x36F0688 VA: 0x36F4688
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F4690 Offset: 0x36F0690 VA: 0x36F4690 Slot: 12
	public ProficiencyData get_ProficiencyData() { }

	[CompilerGenerated]
	// RVA: 0x36F4698 Offset: 0x36F0698 VA: 0x36F4698
	public void set_ProficiencyData(ProficiencyData value) { }

	[CompilerGenerated]
	// RVA: 0x36F46A0 Offset: 0x36F06A0 VA: 0x36F46A0 Slot: 19
	public byte[] get_TrophyData() { }

	[CompilerGenerated]
	// RVA: 0x36F46A8 Offset: 0x36F06A8 VA: 0x36F46A8
	public void set_TrophyData(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F46B0 Offset: 0x36F06B0 VA: 0x36F46B0 Slot: 20
	public ScenarioList get_ScenarioList() { }

	[CompilerGenerated]
	// RVA: 0x36F46B8 Offset: 0x36F06B8 VA: 0x36F46B8
	public void set_ScenarioList(ScenarioList value) { }

	[CompilerGenerated]
	// RVA: 0x36F46C0 Offset: 0x36F06C0 VA: 0x36F46C0 Slot: 13
	public StarGemEquipData[] get_StarGemEquips() { }

	[CompilerGenerated]
	// RVA: 0x36F46C8 Offset: 0x36F06C8 VA: 0x36F46C8
	public void set_StarGemEquips(StarGemEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F46D0 Offset: 0x36F06D0 VA: 0x36F46D0 Slot: 14
	public RegistletData get_RegistletData() { }

	[CompilerGenerated]
	// RVA: 0x36F46D8 Offset: 0x36F06D8 VA: 0x36F46D8
	public void set_RegistletData(RegistletData value) { }

	[CompilerGenerated]
	// RVA: 0x36F46E0 Offset: 0x36F06E0 VA: 0x36F46E0 Slot: 15
	public GemCartData[] get_GemCartBag() { }

	[CompilerGenerated]
	// RVA: 0x36F46E8 Offset: 0x36F06E8 VA: 0x36F46E8
	public void set_GemCartBag(GemCartData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F46F0 Offset: 0x36F06F0 VA: 0x36F46F0 Slot: 16
	public GemCartEquipData[] get_GemCartEquipList() { }

	[CompilerGenerated]
	// RVA: 0x36F46F8 Offset: 0x36F06F8 VA: 0x36F46F8
	public void set_GemCartEquipList(GemCartEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F4700 Offset: 0x36F0700 VA: 0x36F4700 Slot: 17
	public Dictionary<short, byte[]> get_ExSkillConfigList() { }

	[CompilerGenerated]
	// RVA: 0x36F4708 Offset: 0x36F0708 VA: 0x36F4708
	public void set_ExSkillConfigList(Dictionary<short, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x36F4710 Offset: 0x36F0710 VA: 0x36F4710 Slot: 25
	public RoguelikeRingData[] get_RoguelikeRings() { }

	[CompilerGenerated]
	// RVA: 0x36F4718 Offset: 0x36F0718 VA: 0x36F4718
	public void set_RoguelikeRings(RoguelikeRingData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F4720 Offset: 0x36F0720 VA: 0x36F4720 Slot: 26
	public RoguelikeRingEquipData[] get_RoguelikeRingEquips() { }

	[CompilerGenerated]
	// RVA: 0x36F4728 Offset: 0x36F0728 VA: 0x36F4728
	public void set_RoguelikeRingEquips(RoguelikeRingEquipData[] value) { }

	// RVA: 0x36F4730 Offset: 0x36F0730 VA: 0x36F4730 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36F4738 Offset: 0x36F0738 VA: 0x36F4738 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36F4B64 Offset: 0x36F0B64 VA: 0x36F4B64 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
