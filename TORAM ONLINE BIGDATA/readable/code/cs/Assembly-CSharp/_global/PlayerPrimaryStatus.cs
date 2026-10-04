// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class PlayerPrimaryStatus // TypeDefIndex: 1460
{
	// Fields
	[SerializeField]
	private int lv; // 0x10
	[SerializeField]
	private int str; // 0x14
	[SerializeField]
	private int int; // 0x18
	[SerializeField]
	private int vit; // 0x1C
	[SerializeField]
	private int agi; // 0x20
	[SerializeField]
	private int dex; // 0x24
	[SerializeField]
	private int crt; // 0x28
	[SerializeField]
	private int luk; // 0x2C
	[SerializeField]
	private int men; // 0x30
	[SerializeField]
	private int tec; // 0x34
	[SerializeField]
	private int statusPoint; // 0x38
	[SerializeField]
	private int skillPoint; // 0x3C
	[SerializeField]
	private int personality; // 0x40
	private int moveSpeed; // 0x44
	private int checkValue; // 0x48

	// Properties
	public int Lv { get; }
	public int Str { get; }
	public int Int { get; }
	public int Vit { get; }
	public int Agi { get; }
	public int Dex { get; }
	public int Crt { get; }
	public int Luk { get; }
	public int Men { get; }
	public int Tec { get; }
	public int StatusPoint { get; }
	public int SkillPoint { get; }
	public int Personality { get; }
	public float MoveSpeed { get; }

	// Methods

	// RVA: 0x203DE44 Offset: 0x2039E44 VA: 0x203DE44
	public static PlayerPrimaryStatus CreateStatus(PrimaryStatusData statusData) { }

	// RVA: 0x203E788 Offset: 0x203A788 VA: 0x203E788
	public static PlayerPrimaryStatus CreateStatus(IPrimaryStatus npcStatus) { }

	// RVA: 0x204ABB8 Offset: 0x2046BB8 VA: 0x204ABB8
	public ClientPrimaryStatusData ToPrimaryStatusData() { }

	// RVA: 0x204AC64 Offset: 0x2046C64 VA: 0x204AC64
	public int get_Lv() { }

	// RVA: 0x204AC6C Offset: 0x2046C6C VA: 0x204AC6C
	public int get_Str() { }

	// RVA: 0x204AC74 Offset: 0x2046C74 VA: 0x204AC74
	public int get_Int() { }

	// RVA: 0x204AC7C Offset: 0x2046C7C VA: 0x204AC7C
	public int get_Vit() { }

	// RVA: 0x204AC84 Offset: 0x2046C84 VA: 0x204AC84
	public int get_Agi() { }

	// RVA: 0x204AC8C Offset: 0x2046C8C VA: 0x204AC8C
	public int get_Dex() { }

	// RVA: 0x204AC94 Offset: 0x2046C94 VA: 0x204AC94
	public int get_Crt() { }

	// RVA: 0x204AC9C Offset: 0x2046C9C VA: 0x204AC9C
	public int get_Luk() { }

	// RVA: 0x204ACA4 Offset: 0x2046CA4 VA: 0x204ACA4
	public int get_Men() { }

	// RVA: 0x204ACAC Offset: 0x2046CAC VA: 0x204ACAC
	public int get_Tec() { }

	// RVA: 0x204ACB4 Offset: 0x2046CB4 VA: 0x204ACB4
	public int get_StatusPoint() { }

	// RVA: 0x204ACBC Offset: 0x2046CBC VA: 0x204ACBC
	public int get_SkillPoint() { }

	// RVA: 0x204ACC4 Offset: 0x2046CC4 VA: 0x204ACC4
	public int get_Personality() { }

	// RVA: 0x204ACCC Offset: 0x2046CCC VA: 0x204ACCC
	public float get_MoveSpeed() { }

	// RVA: 0x204ACD8 Offset: 0x2046CD8 VA: 0x204ACD8
	public void UpdateStatusPoint(int point) { }

	// RVA: 0x204ACE0 Offset: 0x2046CE0 VA: 0x204ACE0
	public void UpdateSkillPoint(int point) { }

	// RVA: 0x204ACE8 Offset: 0x2046CE8 VA: 0x204ACE8
	public int GetCRC32() { }

	// RVA: 0x204B194 Offset: 0x2047194 VA: 0x204B194
	public bool Check() { }

	// RVA: 0x204B64C Offset: 0x204764C VA: 0x204B64C
	public int GetAllStatusPoint() { }

	// RVA: 0x204AB98 Offset: 0x2046B98 VA: 0x204AB98
	public void .ctor() { }
}
