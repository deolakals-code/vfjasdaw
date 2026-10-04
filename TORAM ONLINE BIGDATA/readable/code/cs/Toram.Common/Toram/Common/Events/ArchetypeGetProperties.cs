// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ArchetypeGetProperties : PacketBase // TypeDefIndex: 12616
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, object> <NewProperties>k__BackingField; // 0x30
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <EmotionType>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <EmotionId>k__BackingField; // 0x41
	[CompilerGenerated]
	private string <MoodMessage>k__BackingField; // 0x48
	[CompilerGenerated]
	private AdditionalData <AdditionalData>k__BackingField; // 0x50

	// Properties
	public override byte Code { get; }
	public int AvatarUuid { get; set; }
	public byte ArchetypeType { get; set; }
	public int PropertiesRevision { get; set; }
	public Dictionary<byte, object> NewProperties { get; set; }
	public short[] Position { get; set; }
	public byte EmotionType { get; set; }
	public byte EmotionId { get; set; }
	public string MoodMessage { get; set; }
	public AdditionalData AdditionalData { get; set; }

	// Methods

	// RVA: 0x36316C0 Offset: 0x362D6C0 VA: 0x36316C0
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36316C8 Offset: 0x362D6C8 VA: 0x36316C8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36316D0 Offset: 0x362D6D0 VA: 0x36316D0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36316D8 Offset: 0x362D6D8 VA: 0x36316D8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36316E0 Offset: 0x362D6E0 VA: 0x36316E0
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36316E8 Offset: 0x362D6E8 VA: 0x36316E8
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36316F0 Offset: 0x362D6F0 VA: 0x36316F0
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x36316F8 Offset: 0x362D6F8 VA: 0x36316F8
	public void set_PropertiesRevision(int value) { }

	[CompilerGenerated]
	// RVA: 0x3631700 Offset: 0x362D700 VA: 0x3631700
	public Dictionary<byte, object> get_NewProperties() { }

	[CompilerGenerated]
	// RVA: 0x3631708 Offset: 0x362D708 VA: 0x3631708
	public void set_NewProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x3631710 Offset: 0x362D710 VA: 0x3631710
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3631718 Offset: 0x362D718 VA: 0x3631718
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3631720 Offset: 0x362D720 VA: 0x3631720
	public byte get_EmotionType() { }

	[CompilerGenerated]
	// RVA: 0x3631728 Offset: 0x362D728 VA: 0x3631728
	public void set_EmotionType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3631730 Offset: 0x362D730 VA: 0x3631730
	public byte get_EmotionId() { }

	[CompilerGenerated]
	// RVA: 0x3631738 Offset: 0x362D738 VA: 0x3631738
	public void set_EmotionId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3631740 Offset: 0x362D740 VA: 0x3631740
	public string get_MoodMessage() { }

	[CompilerGenerated]
	// RVA: 0x3631748 Offset: 0x362D748 VA: 0x3631748
	public void set_MoodMessage(string value) { }

	[CompilerGenerated]
	// RVA: 0x3631750 Offset: 0x362D750 VA: 0x3631750
	public AdditionalData get_AdditionalData() { }

	[CompilerGenerated]
	// RVA: 0x3631758 Offset: 0x362D758 VA: 0x3631758
	public void set_AdditionalData(AdditionalData value) { }

	// RVA: 0x3631760 Offset: 0x362D760 VA: 0x3631760 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3631C2C Offset: 0x362DC2C VA: 0x3631C2C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
