// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Game
public class MahjongDiscard : OperationRequestBase // TypeDefIndex: 12341
{
	// Fields
	[CompilerGenerated]
	private int <Uid>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsRiichi>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsKyushukyuhai>k__BackingField; // 0x25
	[CompilerGenerated]
	private int <DestinyDrawId>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsWhiteMagic>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <IsKakukan>k__BackingField; // 0x2D
	[CompilerGenerated]
	private int <SFPickUpUid>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <SFDiscardUid>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <GraffitiId>k__BackingField; // 0x38

	// Properties
	public int Uid { get; set; }
	public bool IsRiichi { get; set; }
	public bool IsKyushukyuhai { get; set; }
	public int DestinyDrawId { get; set; }
	public bool IsWhiteMagic { get; set; }
	public bool IsKakukan { get; set; }
	public int SFPickUpUid { get; set; }
	public int SFDiscardUid { get; set; }
	public int GraffitiId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35F749C Offset: 0x35F349C VA: 0x35F749C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F74A4 Offset: 0x35F34A4 VA: 0x35F74A4
	public int get_Uid() { }

	[CompilerGenerated]
	// RVA: 0x35F74AC Offset: 0x35F34AC VA: 0x35F74AC
	public void set_Uid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F74B4 Offset: 0x35F34B4 VA: 0x35F74B4
	public bool get_IsRiichi() { }

	[CompilerGenerated]
	// RVA: 0x35F74BC Offset: 0x35F34BC VA: 0x35F74BC
	public void set_IsRiichi(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35F74C8 Offset: 0x35F34C8 VA: 0x35F74C8
	public bool get_IsKyushukyuhai() { }

	[CompilerGenerated]
	// RVA: 0x35F74D0 Offset: 0x35F34D0 VA: 0x35F74D0
	public void set_IsKyushukyuhai(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35F74DC Offset: 0x35F34DC VA: 0x35F74DC
	public int get_DestinyDrawId() { }

	[CompilerGenerated]
	// RVA: 0x35F74E4 Offset: 0x35F34E4 VA: 0x35F74E4
	public void set_DestinyDrawId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F74EC Offset: 0x35F34EC VA: 0x35F74EC
	public bool get_IsWhiteMagic() { }

	[CompilerGenerated]
	// RVA: 0x35F74F4 Offset: 0x35F34F4 VA: 0x35F74F4
	public void set_IsWhiteMagic(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35F7500 Offset: 0x35F3500 VA: 0x35F7500
	public bool get_IsKakukan() { }

	[CompilerGenerated]
	// RVA: 0x35F7508 Offset: 0x35F3508 VA: 0x35F7508
	public void set_IsKakukan(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35F7514 Offset: 0x35F3514 VA: 0x35F7514
	public int get_SFPickUpUid() { }

	[CompilerGenerated]
	// RVA: 0x35F751C Offset: 0x35F351C VA: 0x35F751C
	public void set_SFPickUpUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F7524 Offset: 0x35F3524 VA: 0x35F7524
	public int get_SFDiscardUid() { }

	[CompilerGenerated]
	// RVA: 0x35F752C Offset: 0x35F352C VA: 0x35F752C
	public void set_SFDiscardUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F7534 Offset: 0x35F3534 VA: 0x35F7534
	public int get_GraffitiId() { }

	[CompilerGenerated]
	// RVA: 0x35F753C Offset: 0x35F353C VA: 0x35F753C
	public void set_GraffitiId(int value) { }

	// RVA: 0x35F7544 Offset: 0x35F3544 VA: 0x35F7544 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F754C Offset: 0x35F354C VA: 0x35F754C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F7554 Offset: 0x35F3554 VA: 0x35F7554 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F7764 Offset: 0x35F3764 VA: 0x35F7764 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
