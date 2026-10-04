// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceCreateMapData // TypeDefIndex: 3860
{
	// Fields
	private DefenceMapNode[,] map; // 0x10
	private List<DefenceMapChip> mapList; // 0x18
	private int mapWidth; // 0x20
	private int mapHeight; // 0x24
	private const int roomMax = 9;
	private DefenceCreateMapData.MathDelegate MapVX; // 0x28
	private DefenceCreateMapData.MathDelegate MapVY; // 0x30

	// Methods

	// RVA: 0x23F7C48 Offset: 0x23F3C48 VA: 0x23F7C48
	private void .ctor(int width, int height) { }

	// RVA: 0x23F7E84 Offset: 0x23F3E84 VA: 0x23F7E84
	private void Init() { }

	// RVA: 0x23F7F54 Offset: 0x23F3F54 VA: 0x23F7F54
	private void InitMap() { }

	// RVA: 0x23F8088 Offset: 0x23F4088 VA: 0x23F8088
	public static List<DefenceMapChip> Create(int width, int height) { }

	// RVA: 0x23F8128 Offset: 0x23F4128 VA: 0x23F8128
	private void SetRoom() { }

	// RVA: 0x23F86B8 Offset: 0x23F46B8 VA: 0x23F86B8
	private void SetRoad() { }

	// RVA: 0x23F9198 Offset: 0x23F5198 VA: 0x23F9198
	private void AllocationRoom() { }

	// RVA: 0x23F9570 Offset: 0x23F5570 VA: 0x23F9570
	private void AllocationRoad() { }

	// RVA: 0x23FA5DC Offset: 0x23F65DC VA: 0x23FA5DC
	private int BigCross(int x, int y, int roomCount) { }

	// RVA: 0x23FA948 Offset: 0x23F6948 VA: 0x23FA948
	private int BigTSpin(int x, int y, int roomCount) { }

	// RVA: 0x23FB0E4 Offset: 0x23F70E4 VA: 0x23FB0E4
	private int BigL(int x, int y, int roomCount) { }

	// RVA: 0x23FB660 Offset: 0x23F7660 VA: 0x23FB660
	private int SmallCross(int x, int y, int roomCount) { }

	// RVA: 0x23FB800 Offset: 0x23F7800 VA: 0x23FB800
	private int SmallTSpin(int x, int y, int roomCount) { }

	// RVA: 0x23FBC50 Offset: 0x23F7C50 VA: 0x23FBC50
	private int SmallL(int x, int y, int roomCount) { }

	// RVA: 0x23FBFF0 Offset: 0x23F7FF0 VA: 0x23FBFF0
	private int SmallRoom(int x, int y, int roomCount) { }

	// RVA: 0x23FA3D4 Offset: 0x23F63D4 VA: 0x23FA3D4
	private void SetMapKind(int x, int y, DefenceMapKind mapKind) { }

	// RVA: 0x23FB04C Offset: 0x23F704C VA: 0x23FB04C
	private void CheckPattern(int x, int y, ref int patternCount, ref int count) { }

	// RVA: 0x23FA214 Offset: 0x23F6214 VA: 0x23FA214
	private void ConnectRoad(DefencePoint2 start, DefencePoint2 goal) { }

	// RVA: 0x23F99C0 Offset: 0x23F59C0 VA: 0x23F99C0
	private void CreateGuide() { }

	// RVA: 0x23FA810 Offset: 0x23F6810 VA: 0x23FA810
	private bool IsAroundRoom(int x, int y) { }

	// RVA: 0x23FA7CC Offset: 0x23F67CC VA: 0x23FA7CC
	private bool IsOutRenge(int x, int y, int vx, int vy) { }

	// RVA: 0x23FA1E0 Offset: 0x23F61E0 VA: 0x23FA1E0
	private bool IsInMap(int x, int y) { }

	// RVA: 0x23FA39C Offset: 0x23F639C VA: 0x23FA39C
	private bool IsInMapX(int x) { }

	// RVA: 0x23FA3B8 Offset: 0x23F63B8 VA: 0x23FA3B8
	private bool IsInMapY(int y) { }

	// RVA: 0x23FA8C8 Offset: 0x23F68C8 VA: 0x23FA8C8
	private bool IsRoom(int x, int y) { }

	// RVA: 0x23FA31C Offset: 0x23F631C VA: 0x23FA31C
	private bool IsRoad(int x, int y) { }
}
