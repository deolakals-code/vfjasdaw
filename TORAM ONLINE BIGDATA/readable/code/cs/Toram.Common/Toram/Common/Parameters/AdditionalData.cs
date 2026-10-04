// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class AdditionalData : UnityHashBase // TypeDefIndex: 11111
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x19
	[CompilerGenerated]
	private Dictionary<object, object> <OtherData>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 55)]
	public byte ArchetypeType { get; set; }
	[UnityHash(Code = 199, IsOptional = True)]
	public Dictionary<object, object> OtherData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35BD148 Offset: 0x35B9148 VA: 0x35BD148
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35BD150 Offset: 0x35B9150 VA: 0x35BD150
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x35BD158 Offset: 0x35B9158 VA: 0x35BD158
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BD160 Offset: 0x35B9160 VA: 0x35BD160
	public Dictionary<object, object> get_OtherData() { }

	[CompilerGenerated]
	// RVA: 0x35BD168 Offset: 0x35B9168 VA: 0x35BD168
	public void set_OtherData(Dictionary<object, object> value) { }

	// RVA: 0x35BD170 Offset: 0x35B9170 VA: 0x35BD170
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35BD298 Offset: 0x35B9298 VA: 0x35BD298
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35BD330 Offset: 0x35B9330 VA: 0x35BD330 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35BD338 Offset: 0x35B9338 VA: 0x35BD338 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35BD484 Offset: 0x35B9484 VA: 0x35BD484 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
