// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Player.Option
public class ItemAutoDiscardOptionData : AvatarOptionDataBase // TypeDefIndex: 11110
{
	// Fields
	public const byte MaxStatusDiscard = 100;
	public const byte MaxDuplicateDiscard = 4;
	public const byte NonRPDiscard = 255;
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <SlotDiscard>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <StatusDiscard>k__BackingField; // 0x1B
	[CompilerGenerated]
	private byte <DuplicateDiscard>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <BossDropExclusion>k__BackingField; // 0x1D
	[CompilerGenerated]
	private byte <RandomPropertyTier>k__BackingField; // 0x1E
	[CompilerGenerated]
	private byte <EventDropDiscard>k__BackingField; // 0x1F

	// Properties
	public override byte Type { get; }
	public bool IsActive { get; set; }
	public byte SlotDiscard { get; set; }
	public byte StatusDiscard { get; set; }
	public byte DuplicateDiscard { get; set; }
	public byte BossDropExclusion { get; set; }
	public byte RandomPropertyTier { get; set; }
	public byte EventDropDiscard { get; set; }

	// Methods

	// RVA: 0x35BCB10 Offset: 0x35B8B10 VA: 0x35BCB10
	public void .ctor() { }

	// RVA: 0x35BCB08 Offset: 0x35B8B08 VA: 0x35BCB08
	public void .ctor(byte[] binary) { }

	// RVA: 0x35BCB34 Offset: 0x35B8B34 VA: 0x35BCB34 Slot: 8
	public override byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35BCB3C Offset: 0x35B8B3C VA: 0x35BCB3C
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x35BCB44 Offset: 0x35B8B44 VA: 0x35BCB44
	public void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35BCB50 Offset: 0x35B8B50 VA: 0x35BCB50
	public byte get_SlotDiscard() { }

	[CompilerGenerated]
	// RVA: 0x35BCB58 Offset: 0x35B8B58 VA: 0x35BCB58
	public void set_SlotDiscard(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BCB60 Offset: 0x35B8B60 VA: 0x35BCB60
	public byte get_StatusDiscard() { }

	[CompilerGenerated]
	// RVA: 0x35BCB68 Offset: 0x35B8B68 VA: 0x35BCB68
	public void set_StatusDiscard(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BCB70 Offset: 0x35B8B70 VA: 0x35BCB70
	public byte get_DuplicateDiscard() { }

	[CompilerGenerated]
	// RVA: 0x35BCB78 Offset: 0x35B8B78 VA: 0x35BCB78
	public void set_DuplicateDiscard(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BCB80 Offset: 0x35B8B80 VA: 0x35BCB80
	public byte get_BossDropExclusion() { }

	[CompilerGenerated]
	// RVA: 0x35BCB88 Offset: 0x35B8B88 VA: 0x35BCB88
	public void set_BossDropExclusion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BCB90 Offset: 0x35B8B90 VA: 0x35BCB90
	public byte get_RandomPropertyTier() { }

	[CompilerGenerated]
	// RVA: 0x35BCB98 Offset: 0x35B8B98 VA: 0x35BCB98
	public void set_RandomPropertyTier(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BCBA0 Offset: 0x35B8BA0 VA: 0x35BCBA0
	public byte get_EventDropDiscard() { }

	[CompilerGenerated]
	// RVA: 0x35BCBA8 Offset: 0x35B8BA8 VA: 0x35BCBA8
	public void set_EventDropDiscard(byte value) { }

	// RVA: 0x35BCBB0 Offset: 0x35B8BB0 VA: 0x35BCBB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35BCE98 Offset: 0x35B8E98 VA: 0x35BCE98 Slot: 10
	protected override void Deserialize(MemoryStream ms) { }

	// RVA: 0x35BCFB4 Offset: 0x35B8FB4 VA: 0x35BCFB4 Slot: 9
	protected override void Serialize(MemoryStream ms) { }

	// RVA: 0x35BD040 Offset: 0x35B9040 VA: 0x35BD040 Slot: 11
	public override bool CheckDiff(AvatarOptionDataBase option) { }
}
