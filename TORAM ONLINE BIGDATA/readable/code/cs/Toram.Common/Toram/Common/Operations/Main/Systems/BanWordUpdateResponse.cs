// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class BanWordUpdateResponse : PacketBase // TypeDefIndex: 11952
{
	// Fields
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x20
	[CompilerGenerated]
	private BanWordData[] <WordDatas>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 172)]
	public DateTime UpdateDate { get; set; }
	[PacketClass(Code = 199, IsOptional = True)]
	public BanWordData[] WordDatas { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376CF14 Offset: 0x3768F14 VA: 0x376CF14
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376CF1C Offset: 0x3768F1C VA: 0x376CF1C
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x376CF24 Offset: 0x3768F24 VA: 0x376CF24
	public void set_UpdateDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x376CF2C Offset: 0x3768F2C VA: 0x376CF2C
	public BanWordData[] get_WordDatas() { }

	[CompilerGenerated]
	// RVA: 0x376CF34 Offset: 0x3768F34 VA: 0x376CF34
	public void set_WordDatas(BanWordData[] value) { }

	// RVA: 0x376CF3C Offset: 0x3768F3C VA: 0x376CF3C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376D03C Offset: 0x376903C VA: 0x376D03C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376D0C8 Offset: 0x37690C8 VA: 0x376D0C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376D0D0 Offset: 0x37690D0 VA: 0x376D0D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376D220 Offset: 0x3769220 VA: 0x376D220 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x376D338 Offset: 0x3769338 VA: 0x376D338 Slot: 3
	public override string ToString() { }
}
