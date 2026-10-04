// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptLoader // TypeDefIndex: 4687
{
	// Fields
	private PlayerDataManager playerManager; // 0x10
	[CompilerGenerated]
	private int <version>k__BackingField; // 0x18
	private byte[] binaryData; // 0x20
	private int fieldId; // 0x28
	[CompilerGenerated]
	private int <Position>k__BackingField; // 0x2C
	private int[] valData; // 0x30

	// Properties
	private PlayerDataManager playerDataManager { get; }
	public int version { get; set; }
	public int Position { get; set; }

	// Methods

	// RVA: 0x258F768 Offset: 0x258B768 VA: 0x258F768
	private PlayerDataManager get_playerDataManager() { }

	[CompilerGenerated]
	// RVA: 0x258F7EC Offset: 0x258B7EC VA: 0x258F7EC
	private void set_version(int value) { }

	[CompilerGenerated]
	// RVA: 0x258F7F4 Offset: 0x258B7F4 VA: 0x258F7F4
	public int get_version() { }

	// RVA: 0x258F7FC Offset: 0x258B7FC VA: 0x258F7FC
	public bool LoadedCheck(int id) { }

	// RVA: 0x258F81C Offset: 0x258B81C VA: 0x258F81C
	public void Initialize(TextAsset text, int id) { }

	[CompilerGenerated]
	// RVA: 0x258F8CC Offset: 0x258B8CC VA: 0x258F8CC
	public int get_Position() { }

	[CompilerGenerated]
	// RVA: 0x258F8D4 Offset: 0x258B8D4 VA: 0x258F8D4
	public void set_Position(int value) { }

	// RVA: 0x258F8DC Offset: 0x258B8DC VA: 0x258F8DC
	public Vector3 ReadVector3() { }

	// RVA: 0x258F998 Offset: 0x258B998 VA: 0x258F998
	public Vector3 ReadVector3(int valFlag) { }

	// RVA: 0x258F948 Offset: 0x258B948 VA: 0x258F948
	public float ReadFloat16() { }

	// RVA: 0x258FA3C Offset: 0x258BA3C VA: 0x258FA3C
	public float ReadFloat16(bool valFlag) { }

	// RVA: 0x258FB18 Offset: 0x258BB18 VA: 0x258FB18
	public float ReadFloat8() { }

	// RVA: 0x258FBA4 Offset: 0x258BBA4 VA: 0x258FBA4
	public float ReadFloat8(bool valFlag) { }

	// RVA: 0x258FC18 Offset: 0x258BC18 VA: 0x258FC18
	public long ReadLong() { }

	// RVA: 0x258FC54 Offset: 0x258BC54 VA: 0x258FC54
	public int ReadInt() { }

	// RVA: 0x258FA64 Offset: 0x258BA64 VA: 0x258FA64
	public short ReadShort() { }

	// RVA: 0x258FB68 Offset: 0x258BB68 VA: 0x258FB68
	public byte ReadByte() { }

	// RVA: 0x258FC90 Offset: 0x258BC90 VA: 0x258FC90
	public string ReadString() { }

	// RVA: 0x258FD80 Offset: 0x258BD80 VA: 0x258FD80
	public string ReadBString() { }

	// RVA: 0x258FE74 Offset: 0x258BE74 VA: 0x258FE74
	public Color32 ReadColor() { }

	// RVA: 0x258FF18 Offset: 0x258BF18 VA: 0x258FF18
	public int GetVal(int id) { }

	// RVA: 0x2590C38 Offset: 0x258CC38 VA: 0x2590C38
	private int PlayerWeaponMotion() { }

	// RVA: 0x2590D18 Offset: 0x258CD18 VA: 0x2590D18
	private int PlayerWeaponType() { }

	// RVA: 0x2590D88 Offset: 0x258CD88 VA: 0x2590D88
	public void SetVal(int id, int value) { }

	// RVA: 0x2590E1C Offset: 0x258CE1C VA: 0x2590E1C
	public int BitPlusVal(int id, int value) { }

	// RVA: 0x2590EC4 Offset: 0x258CEC4 VA: 0x2590EC4
	public int PlusVal(int id, int value) { }

	// RVA: 0x2590F6C Offset: 0x258CF6C VA: 0x2590F6C
	public int MinusVal(int id, int value) { }

	// RVA: 0x2591014 Offset: 0x258D014 VA: 0x2591014
	public int MultVal(int id, int value) { }

	// RVA: 0x25910BC Offset: 0x258D0BC VA: 0x25910BC
	public int DivVal(int id, int value) { }

	// RVA: 0x259116C Offset: 0x258D16C VA: 0x259116C
	public int AndVal(int id, int value) { }

	// RVA: 0x2591214 Offset: 0x258D214 VA: 0x2591214
	public int NotVal(int id, int value) { }

	// RVA: 0x25912B8 Offset: 0x258D2B8 VA: 0x25912B8
	public int XorVal(int id, int value) { }

	// RVA: 0x2591360 Offset: 0x258D360 VA: 0x2591360
	public int ReadInt(bool val) { }

	// RVA: 0x258FAA0 Offset: 0x258BAA0 VA: 0x258FAA0
	public short ReadShort(bool val) { }

	// RVA: 0x258FBCC Offset: 0x258BBCC VA: 0x258FBCC
	public byte ReadByte(bool val) { }

	// RVA: 0x25913D8 Offset: 0x258D3D8 VA: 0x25913D8
	public bool ReadEventIndex(int eventIndex) { }

	// RVA: 0x259147C Offset: 0x258D47C VA: 0x259147C
	public void .ctor() { }
}
