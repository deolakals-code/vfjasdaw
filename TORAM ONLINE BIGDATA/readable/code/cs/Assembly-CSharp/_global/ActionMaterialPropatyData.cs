// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ActionMaterialPropatyData // TypeDefIndex: 1554
{
	// Fields
	private Dictionary<int, MaterialPropatyDataBase> material_data; // 0x10

	// Methods

	// RVA: 0x2089FEC Offset: 0x2085FEC VA: 0x2089FEC
	public void .ctor(int _add_data_count) { }

	// RVA: 0x208A1BC Offset: 0x20861BC VA: 0x208A1BC
	public void .ctor(int _add_data_count, int _min, int _max, int[] _datas) { }

	// RVA: 0x208A344 Offset: 0x2086344 VA: 0x208A344
	public void ResetValue() { }

	// RVA: 0x208A558 Offset: 0x2086558 VA: 0x208A558
	public void AddValue(int _bit_access, int _add_value) { }

	// RVA: 0x208A7AC Offset: 0x20867AC VA: 0x208A7AC
	public void AddValueToUnit(int _access_no, int _add_value) { }

	// RVA: 0x208A86C Offset: 0x208686C VA: 0x208A86C
	public void SetValue(int _bit_access, int _set_value) { }

	// RVA: 0x208A950 Offset: 0x2086950 VA: 0x208A950
	public void SetValueToUnit(int _access_no, int _set_value) { }

	// RVA: 0x208AA08 Offset: 0x2086A08 VA: 0x208AA08
	public int GetOneMaterialData(int _access_bit_request) { }

	// RVA: 0x208AC2C Offset: 0x2086C2C VA: 0x208AC2C
	public int[] GetMultiplyMaterialData(int _access_bit_request) { }

	// RVA: 0x208AA0C Offset: 0x2086A0C VA: 0x208AA0C
	private int effective_first_bit(int _access_bit_request) { }
}
