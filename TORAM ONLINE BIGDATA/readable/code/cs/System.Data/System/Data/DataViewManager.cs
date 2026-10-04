// Assembly: System.Data.dll
// Namespace: System.Data
public class DataViewManager : MarshalByValueComponent // TypeDefIndex: 14716
{
	// Fields
	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	internal int _nViews; // 0x28
	private static NotSupportedException s_notSupported; // 0x0

	// Properties
	[DesignerSerializationVisibility(2)]
	public DataViewSettingCollection DataViewSettings { get; }

	// Methods

	// RVA: 0x31F63E4 Offset: 0x31F23E4 VA: 0x31F63E4
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0x31F63EC Offset: 0x31F23EC VA: 0x31F63EC
	private static void .cctor() { }
}
