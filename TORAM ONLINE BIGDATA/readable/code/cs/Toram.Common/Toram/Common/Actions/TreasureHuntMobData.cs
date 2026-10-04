// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class TreasureHuntMobData : MobData // TypeDefIndex: 13211
{
	// Fields
	[CompilerGenerated]
	private byte <MobType>k__BackingField; // 0x68
	[CompilerGenerated]
	private short <UpdateSecond>k__BackingField; // 0x6A

	// Properties
	[UnityHash(Code = 245, IsOptional = True)]
	public byte MobType { get; set; }
	[UnityHash(Code = 172, IsOptional = True)]
	public short UpdateSecond { get; set; }

	// Methods

	// RVA: 0x36E2634 Offset: 0x36DE634 VA: 0x36E2634
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36E263C Offset: 0x36DE63C VA: 0x36E263C
	public byte get_MobType() { }

	[CompilerGenerated]
	// RVA: 0x36E2644 Offset: 0x36DE644 VA: 0x36E2644
	public void set_MobType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36E264C Offset: 0x36DE64C VA: 0x36E264C
	public short get_UpdateSecond() { }

	[CompilerGenerated]
	// RVA: 0x36E2654 Offset: 0x36DE654 VA: 0x36E2654
	public void set_UpdateSecond(short value) { }

	// RVA: 0x36E265C Offset: 0x36DE65C VA: 0x36E265C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36E28A0 Offset: 0x36DE8A0 VA: 0x36E28A0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
