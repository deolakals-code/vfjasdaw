// Assembly: Toram.Common.dll
// Namespace: Toram.Common.GameEvents.Xmas
public class XmasEventData : GameEventDataBase // TypeDefIndex: 11183
{
	// Fields
	private GameEventScenarioData scenarioData; // 0x20
	[CompilerGenerated]
	private List<XmasSocks> <Socks>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <PresentBoxCount>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <InnerVersionFlag>k__BackingField; // 0x32

	// Properties
	public override int Version { get; }
	public List<XmasSocks> Socks { get; set; }
	public short PresentBoxCount { get; set; }
	public byte InnerVersionFlag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35D3714 Offset: 0x35CF714 VA: 0x35D3714
	public void .ctor() { }

	// RVA: 0x35D3738 Offset: 0x35CF738 VA: 0x35D3738 Slot: 7
	public override int get_Version() { }

	[CompilerGenerated]
	// RVA: 0x35D3740 Offset: 0x35CF740 VA: 0x35D3740
	public List<XmasSocks> get_Socks() { }

	[CompilerGenerated]
	// RVA: 0x35D3748 Offset: 0x35CF748 VA: 0x35D3748
	protected void set_Socks(List<XmasSocks> value) { }

	[CompilerGenerated]
	// RVA: 0x35D3750 Offset: 0x35CF750 VA: 0x35D3750
	public short get_PresentBoxCount() { }

	[CompilerGenerated]
	// RVA: 0x35D3758 Offset: 0x35CF758 VA: 0x35D3758
	protected void set_PresentBoxCount(short value) { }

	[CompilerGenerated]
	// RVA: 0x35D3760 Offset: 0x35CF760 VA: 0x35D3760
	public byte get_InnerVersionFlag() { }

	[CompilerGenerated]
	// RVA: 0x35D3768 Offset: 0x35CF768 VA: 0x35D3768
	public void set_InnerVersionFlag(byte value) { }

	// RVA: 0x35D3770 Offset: 0x35CF770 VA: 0x35D3770 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35D3778 Offset: 0x35CF778 VA: 0x35D3778 Slot: 8
	protected override bool VersionInitialize() { }

	// RVA: 0x35D3840 Offset: 0x35CF840 VA: 0x35D3840 Slot: 9
	protected override void Serialize(MemoryStream ms) { }

	// RVA: 0x35D3A10 Offset: 0x35CFA10 VA: 0x35D3A10 Slot: 10
	protected override bool Deserialize(MemoryStream ms, bool isInitialize) { }
}
