// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Internal/Localization")]
public class Localization : MonoBehaviour // TypeDefIndex: 72
{
	// Fields
	private static Localization mInstance; // 0x0
	public string startingLanguage; // 0x20
	public TextAsset[] languages; // 0x28
	private Dictionary<string, string> mDictionary; // 0x30
	private string mLanguage; // 0x38

	// Properties
	public static bool isActive { get; }
	public static Localization instance { get; }
	public string currentLanguage { get; set; }

	// Methods

	// RVA: 0x172B484 Offset: 0x1727484 VA: 0x172B484
	public static bool get_isActive() { }

	// RVA: 0x172B4FC Offset: 0x17274FC VA: 0x172B4FC
	public static Localization get_instance() { }

	// RVA: 0x172B744 Offset: 0x1727744 VA: 0x172B744
	public string get_currentLanguage() { }

	// RVA: 0x172B74C Offset: 0x172774C VA: 0x172B74C
	public void set_currentLanguage(string value) { }

	// RVA: 0x172BABC Offset: 0x1727ABC VA: 0x172BABC
	private void Awake() { }

	// RVA: 0x172BC54 Offset: 0x1727C54 VA: 0x172BC54
	private void OnEnable() { }

	// RVA: 0x172BD08 Offset: 0x1727D08 VA: 0x172BD08
	private void OnDestroy() { }

	// RVA: 0x172B9B0 Offset: 0x17279B0 VA: 0x172B9B0
	private void Load(TextAsset asset) { }

	// RVA: 0x172BDBC Offset: 0x1727DBC VA: 0x172BDBC
	public string Get(string key) { }

	// RVA: 0x172BE80 Offset: 0x1727E80 VA: 0x172BE80
	public static string Localize(string key) { }

	// RVA: 0x172BF10 Offset: 0x1727F10 VA: 0x172BF10
	public void .ctor() { }
}
