// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Loader
public class EnterFieldResponse : PacketBase // TypeDefIndex: 11548
{
	// Fields
	[CompilerGenerated]
	private EnterAvatarData <AvatarData>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <AvatarBinary>k__BackingField; // 0x28
	[CompilerGenerated]
	private EnterAvatarData2 <AvatarData2>k__BackingField; // 0x30

	// Properties
	[Obsolete("Old Version")]
	public EnterAvatarData AvatarData { get; set; }
	public byte[] AvatarBinary { get; set; }
	public EnterAvatarData2 AvatarData2 { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37183A8 Offset: 0x37143A8 VA: 0x37183A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37183B0 Offset: 0x37143B0 VA: 0x37183B0
	public EnterAvatarData get_AvatarData() { }

	[CompilerGenerated]
	// RVA: 0x37183B8 Offset: 0x37143B8 VA: 0x37183B8
	public void set_AvatarData(EnterAvatarData value) { }

	[CompilerGenerated]
	// RVA: 0x37183C0 Offset: 0x37143C0 VA: 0x37183C0
	public byte[] get_AvatarBinary() { }

	[CompilerGenerated]
	// RVA: 0x37183C8 Offset: 0x37143C8 VA: 0x37183C8
	public void set_AvatarBinary(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x37183D0 Offset: 0x37143D0 VA: 0x37183D0
	public EnterAvatarData2 get_AvatarData2() { }

	[CompilerGenerated]
	// RVA: 0x37183D8 Offset: 0x37143D8 VA: 0x37183D8
	public void set_AvatarData2(EnterAvatarData2 value) { }

	// RVA: 0x37183E0 Offset: 0x37143E0 VA: 0x37183E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37183E8 Offset: 0x37143E8 VA: 0x37183E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37186D8 Offset: 0x37146D8 VA: 0x37186D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
