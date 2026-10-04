// Assembly: Assembly-CSharp.dll
// Namespace: 
public struct DefencePoint2 : IEquatable<DefencePoint2> // TypeDefIndex: 3879
{
	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Properties
	public static DefencePoint2 zero { get; }

	// Methods

	// RVA: 0x2405300 Offset: 0x2401300 VA: 0x2405300
	public static DefencePoint2 get_zero() { }

	// RVA: 0x2405308 Offset: 0x2401308 VA: 0x2405308
	public void .ctor(DefencePoint2 p2) { }

	// RVA: 0x2402CCC Offset: 0x23FECCC VA: 0x2402CCC
	public void .ctor(int x, int y) { }

	// RVA: 0x2405310 Offset: 0x2401310 VA: 0x2405310 Slot: 4
	public bool Equals(DefencePoint2 obj) { }

	// RVA: 0x2405338 Offset: 0x2401338 VA: 0x2405338 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2405340 Offset: 0x2401340 VA: 0x2405340
	public static double Distance(DefencePoint2 c1, DefencePoint2 c2) { }

	// RVA: 0x24053BC Offset: 0x24013BC VA: 0x24053BC
	public static DefencePoint2 op_Addition(DefencePoint2 c1, DefencePoint2 c2) { }

	// RVA: 0x24053D4 Offset: 0x24013D4 VA: 0x24053D4
	public static DefencePoint2 op_Subtraction(DefencePoint2 c1, DefencePoint2 c2) { }
}
