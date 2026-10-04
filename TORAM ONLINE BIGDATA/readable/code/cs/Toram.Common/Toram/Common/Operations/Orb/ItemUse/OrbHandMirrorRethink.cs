// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.ItemUse
public class OrbHandMirrorRethink : UnityHashBase // TypeDefIndex: 11850
{
	// Fields
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 69, IsOptional = True)]
	public PrimaryStatusData PrimaryStatus { get; set; }
	[UnityHash(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3756E44 Offset: 0x3752E44 VA: 0x3756E44
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3756E4C Offset: 0x3752E4C VA: 0x3756E4C
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x3756E54 Offset: 0x3752E54 VA: 0x3756E54
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3756E5C Offset: 0x3752E5C VA: 0x3756E5C
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3756E64 Offset: 0x3752E64 VA: 0x3756E64
	public void set_GameStatus(GameStatusData value) { }

	// RVA: 0x3756E6C Offset: 0x3752E6C VA: 0x3756E6C
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x37570B0 Offset: 0x37530B0 VA: 0x37570B0
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x37571BC Offset: 0x37531BC VA: 0x37571BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37571C4 Offset: 0x37531C4 VA: 0x37571C4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x375725C Offset: 0x375325C VA: 0x375725C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
