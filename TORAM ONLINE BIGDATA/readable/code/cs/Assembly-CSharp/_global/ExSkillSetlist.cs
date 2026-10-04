// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExSkillSetlist : ExSkillDataBase // TypeDefIndex: 1823
{
	// Fields
	public const int NoneSelect = 0;
	private SkillId[] selectSkillIds; // 0x10
	private bool[] selectSkillValids; // 0x18

	// Properties
	public override SkillId SkillId { get; }
	public IReadOnlyList<SkillId> SelectSkillIds { get; }
	public IReadOnlyCollection<bool> SelectSkillValids { get; }

	// Methods

	// RVA: 0x20E5C94 Offset: 0x20E1C94 VA: 0x20E5C94
	public void .ctor() { }

	// RVA: 0x20E5488 Offset: 0x20E1488 VA: 0x20E5488
	public void .ctor(byte[] binary) { }

	// RVA: 0x20E5DF4 Offset: 0x20E1DF4 VA: 0x20E5DF4 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x20E5DFC Offset: 0x20E1DFC VA: 0x20E5DFC
	public IReadOnlyList<SkillId> get_SelectSkillIds() { }

	// RVA: 0x20E5E44 Offset: 0x20E1E44 VA: 0x20E5E44
	public IReadOnlyCollection<bool> get_SelectSkillValids() { }

	// RVA: 0x20E5E8C Offset: 0x20E1E8C VA: 0x20E5E8C Slot: 6
	public override void SetValue(byte[] binary) { }

	// RVA: 0x20E61E8 Offset: 0x20E21E8 VA: 0x20E61E8 Slot: 5
	public override byte[] ToBinary() { }

	// RVA: 0x20E6548 Offset: 0x20E2548 VA: 0x20E6548
	public bool SetSelectSkillId(int index, SkillId skillId) { }

	// RVA: 0x20E6624 Offset: 0x20E2624 VA: 0x20E6624
	public bool SetSelectSkillValid(int index, bool valid) { }

	// RVA: 0x20E666C Offset: 0x20E266C VA: 0x20E666C
	public bool ClearSelectSkillId(int index) { }

	// RVA: 0x20E66D0 Offset: 0x20E26D0 VA: 0x20E66D0
	public ExSkillSetlist DeepCopy() { }

	// RVA: 0x20E6884 Offset: 0x20E2884 VA: 0x20E6884
	public SkillId[] GetValidSongSkillIds() { }

	// RVA: 0x20E6A18 Offset: 0x20E2A18 VA: 0x20E6A18
	public void InitializeSetlist() { }
}
