// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EquipBuffManager // TypeDefIndex: 1807
{
	// Fields
	private Dictionary<byte, List<EquipBuffDataBase>> allBuffList; // 0x10
	private Dictionary<byte, List<EquipBuffDataBase>> randomPropertyBuffList; // 0x18
	private List<EquipBuffDataBase> buffList; // 0x20
	[CompilerGenerated]
	private List<BonusType> <BuffTypeList>k__BackingField; // 0x28

	// Properties
	public List<BonusType> BuffTypeList { get; set; }
	public Dictionary<byte, List<EquipBuffDataBase>> AllBuffList { get; }
	public Dictionary<byte, List<EquipBuffDataBase>> RandomPropertyBuffList { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20E0FC8 Offset: 0x20DCFC8 VA: 0x20E0FC8
	public List<BonusType> get_BuffTypeList() { }

	[CompilerGenerated]
	// RVA: 0x20E0FD0 Offset: 0x20DCFD0 VA: 0x20E0FD0
	private void set_BuffTypeList(List<BonusType> value) { }

	// RVA: 0x20E0FD8 Offset: 0x20DCFD8 VA: 0x20E0FD8
	public Dictionary<byte, List<EquipBuffDataBase>> get_AllBuffList() { }

	// RVA: 0x20E1398 Offset: 0x20DD398 VA: 0x20E1398
	public Dictionary<byte, List<EquipBuffDataBase>> get_RandomPropertyBuffList() { }

	// RVA: 0x20E13A0 Offset: 0x20DD3A0 VA: 0x20E13A0
	public void .ctor() { }

	// RVA: 0x20E14F4 Offset: 0x20DD4F4 VA: 0x20E14F4
	public void Update() { }

	// RVA: 0x20E1728 Offset: 0x20DD728 VA: 0x20E1728
	public void SetBonus(byte type, BonusData bonus) { }

	// RVA: 0x20E19EC Offset: 0x20DD9EC VA: 0x20E19EC
	public void SetRandomPropertyBonus(byte type, BonusData bonus) { }

	// RVA: 0x20E1CB0 Offset: 0x20DDCB0 VA: 0x20E1CB0
	public void ClearRandomPropertyBonus() { }

	// RVA: 0x20E1D00 Offset: 0x20DDD00 VA: 0x20E1D00
	public void CreateBuff() { }

	// RVA: 0x20E2AAC Offset: 0x20DEAAC VA: 0x20E2AAC
	public bool IsEquipBuff(BonusType type) { }

	// RVA: 0x20E2B88 Offset: 0x20DEB88 VA: 0x20E2B88
	public bool IsVilidEquipBuff(BonusType type) { }

	// RVA: 0x20E2C90 Offset: 0x20DEC90 VA: 0x20E2C90
	public int CalcBuff(BonusType type, int value, PlayerActionManagerBase playerAct, MobActionManagerBase mobAct) { }

	// RVA: 0x20DF68C Offset: 0x20DB68C VA: 0x20DF68C
	public int CalcBuff(BonusType type, int value) { }

	// RVA: 0x20E2DBC Offset: 0x20DEDBC VA: 0x20E2DBC
	public bool FunctionBuff(BonusType type) { }

	// RVA: 0x20E2EB8 Offset: 0x20DEEB8 VA: 0x20E2EB8
	public bool FunctionBuff(BonusType type, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x20E2FD0 Offset: 0x20DEFD0 VA: 0x20E2FD0
	public int GetParam(BonusType type) { }

	// RVA: -1 Offset: -1
	public bool TryGetEquipBuffer<T>(BonusType type, out T equipBuffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BF29C Offset: 0x26BB29C VA: 0x26BF29C
	|-EquipBuffManager.TryGetEquipBuffer<object>
	*/

	// RVA: 0x20E30CC Offset: 0x20DF0CC VA: 0x20E30CC
	public void Reset() { }

	// RVA: 0x20E321C Offset: 0x20DF21C VA: 0x20E321C
	public bool IsGrantStopAbnormal(AbnormalType type) { }

	// RVA: 0x20E3238 Offset: 0x20DF238 VA: 0x20E3238
	public static bool IsBuffIcon(BonusType type) { }

	// RVA: 0x20E3240 Offset: 0x20DF240 VA: 0x20E3240
	public void AddEquipBuf(EquipBuffDataBase buff) { }

	// RVA: 0x20E3374 Offset: 0x20DF374 VA: 0x20E3374
	public void RemoveEquipBuf(EquipBuffDataBase buff) { }
}
