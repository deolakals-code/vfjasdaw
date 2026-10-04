// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class RegionInfo // TypeDefIndex: 10832
{
	// Fields
	private static RegionInfo currentRegion; // 0x0
	private int regionId; // 0x10
	private string iso2Name; // 0x18
	private string iso3Name; // 0x20
	private string win3Name; // 0x28
	private string englishName; // 0x30
	private string nativeName; // 0x38
	private string currencySymbol; // 0x40
	private string isoCurrencySymbol; // 0x48
	private string currencyEnglishName; // 0x50
	private string currencyNativeName; // 0x58

	// Properties
	public static RegionInfo CurrentRegion { get; }
	[ComVisible(False)]
	public virtual string CurrencyEnglishName { get; }
	public virtual string CurrencySymbol { get; }
	[MonoTODO("DisplayName currently only returns the EnglishName")]
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	[ComVisible(False)]
	public virtual int GeoId { get; }
	public virtual bool IsMetric { get; }
	public virtual string ISOCurrencySymbol { get; }
	[ComVisible(False)]
	public virtual string NativeName { get; }
	[ComVisible(False)]
	public virtual string CurrencyNativeName { get; }
	public virtual string Name { get; }
	public virtual string ThreeLetterISORegionName { get; }
	public virtual string ThreeLetterWindowsRegionName { get; }
	public virtual string TwoLetterISORegionName { get; }

	// Methods

	// RVA: 0x2FB0634 Offset: 0x2FAC634 VA: 0x2FB0634
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x2FB08E4 Offset: 0x2FAC8E4 VA: 0x2FB08E4
	public void .ctor(int culture) { }

	// RVA: 0x2FB0A90 Offset: 0x2FACA90 VA: 0x2FB0A90
	public void .ctor(string name) { }

	// RVA: 0x2FB06F4 Offset: 0x2FAC6F4 VA: 0x2FB06F4
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x2FB09E8 Offset: 0x2FAC9E8 VA: 0x2FB09E8
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x2FB0BC4 Offset: 0x2FACBC4 VA: 0x2FB0BC4
	private bool construct_internal_region_from_name(string name) { }

	// RVA: 0x2FB0BC8 Offset: 0x2FACBC8 VA: 0x2FB0BC8 Slot: 4
	public virtual string get_CurrencyEnglishName() { }

	// RVA: 0x2FB0BD0 Offset: 0x2FACBD0 VA: 0x2FB0BD0 Slot: 5
	public virtual string get_CurrencySymbol() { }

	// RVA: 0x2FB0BD8 Offset: 0x2FACBD8 VA: 0x2FB0BD8 Slot: 6
	public virtual string get_DisplayName() { }

	// RVA: 0x2FB0BE0 Offset: 0x2FACBE0 VA: 0x2FB0BE0 Slot: 7
	public virtual string get_EnglishName() { }

	// RVA: 0x2FB0BE8 Offset: 0x2FACBE8 VA: 0x2FB0BE8 Slot: 8
	public virtual int get_GeoId() { }

	// RVA: 0x2FB0BF0 Offset: 0x2FACBF0 VA: 0x2FB0BF0 Slot: 9
	public virtual bool get_IsMetric() { }

	// RVA: 0x2FB0C7C Offset: 0x2FACC7C VA: 0x2FB0C7C Slot: 10
	public virtual string get_ISOCurrencySymbol() { }

	// RVA: 0x2FB0C84 Offset: 0x2FACC84 VA: 0x2FB0C84 Slot: 11
	public virtual string get_NativeName() { }

	// RVA: 0x2FB0C8C Offset: 0x2FACC8C VA: 0x2FB0C8C Slot: 12
	public virtual string get_CurrencyNativeName() { }

	// RVA: 0x2FB0C94 Offset: 0x2FACC94 VA: 0x2FB0C94 Slot: 13
	public virtual string get_Name() { }

	// RVA: 0x2FB0C9C Offset: 0x2FACC9C VA: 0x2FB0C9C Slot: 14
	public virtual string get_ThreeLetterISORegionName() { }

	// RVA: 0x2FB0CA4 Offset: 0x2FACCA4 VA: 0x2FB0CA4 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x2FB0CAC Offset: 0x2FACCAC VA: 0x2FB0CAC Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x2FB0CB4 Offset: 0x2FACCB4 VA: 0x2FB0CB4 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2FB0D7C Offset: 0x2FACD7C VA: 0x2FB0D7C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FB0DA8 Offset: 0x2FACDA8 VA: 0x2FB0DA8 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FB0DB8 Offset: 0x2FACDB8 VA: 0x2FB0DB8
	internal static void ClearCachedData() { }
}
