﻿// Gomme
// https://github.com/Tecate/bitmap-fonts/blob/master/bitmap/gomme/Gomme10x20n.bdf
static class Font {
	public const int FONT_WIDTH = 10;
	public const int FONT_HEIGHT = 20;

	const int START_CODEPOINT = 32;
	const int END_CODEPOINT = 126;

	static ushort[][] _data = null;

	public static void Initialise() {
		_data = new ushort[][] {
			new ushort[] {	// space
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000,
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// !
				0x0000, 0x0000, 0x0000, 0x0000, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800,
				0x0000, 0x0000, 0x0800, 0x0800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// "
				0x0000, 0x0000, 0x0000, 0x0000, 0x2200, 0x2200, 0x2200, 0x2200, 0x0000, 0x0000,
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// #
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x2200, 0x2200, 0x7F00, 0x2200, 0x2200,
				0x2200, 0x7F00, 0x2200, 0x2200, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// $
				0x0000, 0x0000, 0x0000, 0x0800, 0x0800, 0x3E00, 0x4100, 0x4000, 0x4000, 0x3E00,
				0x0100, 0x0100, 0x4100, 0x3E00, 0x0800, 0x0800, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// %
				0x0000, 0x0000, 0x0000, 0x0000, 0x3000, 0x4880, 0x4900, 0x3200, 0x0400, 0x0800,
				0x1300, 0x2480, 0x4480, 0x0300, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// &
				0x0000, 0x0000, 0x0000, 0x0000, 0x3C00, 0x4200, 0x4000, 0x2000, 0x1000, 0x2800,
				0x4500, 0x4200, 0x4500, 0x3880, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// '
				0x0000, 0x0000, 0x0000, 0x0800, 0x0800, 0x0800, 0x0800, 0x0000, 0x0000, 0x0000,
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// (
				0x0000, 0x0000, 0x0400, 0x0800, 0x1000, 0x1000, 0x2000, 0x2000, 0x2000, 0x2000,
				0x2000, 0x2000, 0x2000, 0x2000, 0x1000, 0x1000, 0x0800, 0x0400, 0x0000, 0x0000 },
			new ushort[] {	// )
				0x0000, 0x0000, 0x2000, 0x1000, 0x0800, 0x0800, 0x0400, 0x0400, 0x0400, 0x0400,
				0x0400, 0x0400, 0x0400, 0x0400, 0x0800, 0x0800, 0x1000, 0x2000, 0x0000, 0x0000 },
			new ushort[] {	// *
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0800, 0x4900, 0x2A00, 0x1C00,
				0x2A00, 0x4900, 0x0800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// +
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0800, 0x0800, 0x0800, 0x7F00,
				0x0800, 0x0800, 0x0800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// ,
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000,
				0x0000, 0x0000, 0x1800, 0x1800, 0x0800, 0x0800, 0x1000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// -
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7F00,
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// .
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000,
				0x0000, 0x0000, 0x1800, 0x1800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// /
				0x0000, 0x0000, 0x0000, 0x0100, 0x0100, 0x0200, 0x0200, 0x0400, 0x0400, 0x0800,
				0x0800, 0x1000, 0x1000, 0x2000, 0x2000, 0x4000, 0x4000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// 0
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4300, 0x4500, 0x4900,
				0x5100, 0x6100, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// 1
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0800, 0x1800, 0x2800, 0x4800, 0x0800,
				0x0800, 0x0800, 0x0800, 0x7F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// 2
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x0100, 0x0200, 0x0400,
				0x0800, 0x1000, 0x2000, 0x7F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// 3
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7F00, 0x0200, 0x0400, 0x0C00, 0x0200,
				0x0100, 0x0100, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// 4
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0200, 0x0600, 0x0A00, 0x1200, 0x2200,
				0x4200, 0x7F00, 0x0200, 0x0200, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// 5
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7F00, 0x4000, 0x4000, 0x7E00, 0x0100,
				0x0100, 0x0100, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// 6
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x1E00, 0x2000, 0x4000, 0x7E00, 0x4100,
				0x4100, 0x4100, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// 7
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7F00, 0x0100, 0x0200, 0x0200, 0x0400,
				0x0400, 0x0800, 0x0800, 0x0800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// 8
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4100, 0x4100, 0x3E00,
				0x4100, 0x4100, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// 9
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4100, 0x4100, 0x4100,
				0x3F00, 0x0100, 0x0200, 0x1C00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// :
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x1800, 0x1800, 0x0000, 0x0000,
				0x0000, 0x0000, 0x1800, 0x1800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// ;
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x1800, 0x1800, 0x0000, 0x0000,
				0x0000, 0x0000, 0x1800, 0x1800, 0x0800, 0x0800, 0x1000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// <
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0200, 0x0400, 0x0800, 0x1000, 0x2000,
				0x1000, 0x0800, 0x0400, 0x0200, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// =
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7F00, 0x0000, 0x0000,
				0x0000, 0x7F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// >
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x2000, 0x1000, 0x0800, 0x0400, 0x0200,
				0x0400, 0x0800, 0x1000, 0x2000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// ?
				0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x0100, 0x0200, 0x0400, 0x0800,
				0x0000, 0x0000, 0x0800, 0x0800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// @
				0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4100, 0x4500, 0x4900, 0x5100,
				0x5100, 0x5100, 0x4E00, 0x4000, 0x4000, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// A
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4100, 0x4100, 0x4100,
				0x7F00, 0x4100, 0x4100, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// B
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7E00, 0x4100, 0x4100, 0x4100, 0x7E00,
				0x4100, 0x4100, 0x4100, 0x7E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// C
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x1E00, 0x2100, 0x4000, 0x4000, 0x4000,
				0x4000, 0x4000, 0x2100, 0x1E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// D
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7C00, 0x4200, 0x4100, 0x4100, 0x4100,
				0x4100, 0x4100, 0x4200, 0x7C00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// E
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7F00, 0x4000, 0x4000, 0x4000, 0x7C00,
				0x4000, 0x4000, 0x4000, 0x7F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// F
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7F00, 0x4000, 0x4000, 0x4000, 0x7C00,
				0x4000, 0x4000, 0x4000, 0x4000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// G
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4000, 0x4000, 0x4700,
				0x4100, 0x4100, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// H
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x4100, 0x4100, 0x7F00,
				0x4100, 0x4100, 0x4100, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// I
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7F00, 0x0800, 0x0800, 0x0800, 0x0800,
				0x0800, 0x0800, 0x0800, 0x7F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// J
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x1F00, 0x0100, 0x0100, 0x0100, 0x0100,
				0x0100, 0x0100, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// K
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4200, 0x4400, 0x4800, 0x5000,
				0x6800, 0x4400, 0x4200, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// L
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4000, 0x4000, 0x4000, 0x4000, 0x4000,
				0x4000, 0x4000, 0x4000, 0x7F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// M
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x6300, 0x5500, 0x4900, 0x4900,
				0x4100, 0x4100, 0x4100, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// N
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x6100, 0x5100, 0x4900, 0x4500, 0x4300,
				0x4100, 0x4100, 0x4100, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// O
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4100, 0x4100, 0x4100,
				0x4100, 0x4100, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// P
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7E00, 0x4100, 0x4100, 0x4100, 0x4100,
				0x7E00, 0x4000, 0x4000, 0x4000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// Q
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4100, 0x4100, 0x4100,
				0x4100, 0x4100, 0x4500, 0x3E00, 0x0100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// R
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7E00, 0x4100, 0x4100, 0x4100, 0x7E00,
				0x4200, 0x4200, 0x4100, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// S
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3F00, 0x4000, 0x2000, 0x1000, 0x0800,
				0x0400, 0x0200, 0x0100, 0x7E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// T
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0xFF80, 0x0800, 0x0800, 0x0800, 0x0800,
				0x0800, 0x0800, 0x0800, 0x0800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// U
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x4100, 0x4100, 0x4100,
				0x4100, 0x4100, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// V
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x4100, 0x2200, 0x2200,
				0x2200, 0x1400, 0x1400, 0x0800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// W
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x4100, 0x4100, 0x4100,
				0x4900, 0x4900, 0x5500, 0x6300, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// X
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x2200, 0x1400, 0x0800,
				0x1400, 0x2200, 0x4100, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// Y
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x2200, 0x1400, 0x0800,
				0x0800, 0x0800, 0x0800, 0x0800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {	// Z
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7F00, 0x0100, 0x0200, 0x0400, 0x0800,
				0x1000, 0x2000, 0x4000, 0x7F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x3E00, 0x2000, 0x2000, 0x2000, 0x2000, 0x2000, 0x2000, 0x2000,
				0x2000, 0x2000, 0x2000, 0x2000, 0x2000, 0x2000, 0x2000, 0x3E00, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x4000, 0x4000, 0x2000, 0x2000, 0x1000, 0x1000, 0x0800,
				0x0800, 0x0400, 0x0400, 0x0200, 0x0200, 0x0100, 0x0100, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x3E00, 0x0200, 0x0200, 0x0200, 0x0200, 0x0200, 0x0200, 0x0200,
				0x0200, 0x0200, 0x0200, 0x0200, 0x0200, 0x0200, 0x0200, 0x3E00, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0800, 0x1400, 0x2200, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000,
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000,
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0xFFC0, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x2000, 0x1000, 0x0800, 0x0400, 0x0000, 0x0000, 0x0000, 0x0000,
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x0100, 0x0100,
				0x3F00, 0x4100, 0x4300, 0x3D00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x4000, 0x4000, 0x4000, 0x4E00, 0x5100, 0x6100,
				0x4100, 0x4100, 0x4100, 0x7E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4000,
				0x4000, 0x4000, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0100, 0x0100, 0x0100, 0x3D00, 0x4300, 0x4100,
				0x4100, 0x4100, 0x4300, 0x3D00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4100,
				0x7F00, 0x4000, 0x4000, 0x3F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0F00, 0x1000, 0x1000, 0x1000, 0x7E00, 0x1000,
				0x1000, 0x1000, 0x1000, 0x1000, 0x1000, 0x1000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3D00, 0x4300, 0x4100,
				0x4100, 0x4100, 0x4300, 0x3D00, 0x0100, 0x0100, 0x7E00, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x4000, 0x4000, 0x4000, 0x4E00, 0x5100, 0x6100,
				0x4100, 0x4100, 0x4100, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0800, 0x0800, 0x0000, 0x7800, 0x0800, 0x0800,
				0x0800, 0x0800, 0x0800, 0x7F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0200, 0x0200, 0x0000, 0x1E00, 0x0200, 0x0200,
				0x0200, 0x0200, 0x0200, 0x0200, 0x0200, 0x0200, 0x7C00, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x4000, 0x4000, 0x4000, 0x4100, 0x4200, 0x4400,
				0x4800, 0x5400, 0x6200, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x7800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800,
				0x0800, 0x0800, 0x0800, 0x7F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x5B00, 0x6D00, 0x4900,
				0x4900, 0x4900, 0x4900, 0x4900, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4E00, 0x5100, 0x6100,
				0x4100, 0x4100, 0x4100, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3E00, 0x4100, 0x4100,
				0x4100, 0x4100, 0x4100, 0x3E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x5E00, 0x6100, 0x4100,
				0x4100, 0x4100, 0x6100, 0x5E00, 0x4000, 0x4000, 0x4000, 0x4000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3F00, 0x4100, 0x4100,
				0x4100, 0x4100, 0x4300, 0x3D00, 0x0100, 0x0100, 0x0100, 0x0100, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4E00, 0x5100, 0x6100,
				0x4000, 0x4000, 0x4000, 0x4000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3F00, 0x2000, 0x1000,
				0x0800, 0x0400, 0x0200, 0x7E00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x1000, 0x1000, 0x7F00, 0x1000, 0x1000,
				0x1000, 0x1000, 0x1000, 0x0F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x4100,
				0x4100, 0x4300, 0x4500, 0x3900, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x2200,
				0x2200, 0x1400, 0x1400, 0x0800, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x4100,
				0x4900, 0x4900, 0x5500, 0x6300, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x2200,
				0x1C00, 0x2200, 0x4100, 0x4100, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x4100, 0x4100, 0x4100,
				0x4100, 0x4100, 0x4300, 0x3D00, 0x0100, 0x0100, 0x7E00, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x7F00, 0x0200, 0x0400,
				0x0800, 0x1000, 0x2000, 0x7F00, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0E00, 0x1000, 0x1000, 0x1000, 0x1000, 0x1000, 0x1000, 0x6000,
				0x1000, 0x1000, 0x1000, 0x1000, 0x1000, 0x1000, 0x1000, 0x0E00, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800,
				0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x7000, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0600,
				0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x0800, 0x7000, 0x0000, 0x0000 },
			new ushort[] {
				0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x3000, 0x4900,
				0x0600, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000, 0x0000 }
		};
	}

	public static unsafe void GetGlyphData(char glyph, uint foreground, uint background, ref uint[] glyphData) {
		if (glyph < START_CODEPOINT || glyph > END_CODEPOINT)
			glyph = (char)START_CODEPOINT;

		var idx = glyph - START_CODEPOINT;
		var gd = _data[idx];

		for (int y = 0; y < FONT_HEIGHT; y++) {
			for (int x = 0; x < FONT_WIDTH; x++) {
				if ((gd[y] & (1 << (15 - x))) == 0)
					glyphData[y * FONT_WIDTH + x] = background;
				else
					glyphData[y * FONT_WIDTH + x] = foreground;
			}
		}
	}
}