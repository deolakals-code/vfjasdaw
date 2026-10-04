// Assembly: UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine
public class WWWForm // TypeDefIndex: 17601
{
	// Fields
	private List<byte[]> formData; // 0x10
	private List<string> fieldNames; // 0x18
	private List<string> fileNames; // 0x20
	private List<string> types; // 0x28
	private byte[] boundary; // 0x30
	private bool containsFiles; // 0x38
	private static byte[] dDash; // 0x0
	private static byte[] crlf; // 0x8
	private static byte[] contentTypeHeader; // 0x10
	private static byte[] dispositionHeader; // 0x18
	private static byte[] endQuote; // 0x20
	private static byte[] fileNameField; // 0x28
	private static byte[] ampersand; // 0x30
	private static byte[] equal; // 0x38

	// Properties
	internal static Encoding DefaultEncoding { get; }
	public Dictionary<string, string> headers { get; }
	public byte[] data { get; }

	// Methods

	// RVA: 0x3824AD4 Offset: 0x3820AD4 VA: 0x3824AD4
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x3824ADC Offset: 0x3820ADC VA: 0x3824ADC
	public void .ctor() { }

	// RVA: 0x3824C94 Offset: 0x3820C94 VA: 0x3824C94
	public void AddField(string fieldName, string value) { }

	// RVA: 0x3824CCC Offset: 0x3820CCC VA: 0x3824CCC
	public void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x3824F3C Offset: 0x3820F3C VA: 0x3824F3C
	public void AddField(string fieldName, int i) { }

	// RVA: 0x3824F90 Offset: 0x3820F90 VA: 0x3824F90
	public Dictionary<string, string> get_headers() { }

	// RVA: 0x38250DC Offset: 0x38210DC VA: 0x38250DC
	public byte[] get_data() { }

	// RVA: 0x3826198 Offset: 0x3822198 VA: 0x3826198
	private static void .cctor() { }
}
