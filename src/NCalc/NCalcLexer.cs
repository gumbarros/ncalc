//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from NCalc.g by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using System.Globalization;
using NCalc.Domain;

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class NCalcLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, TRUE=29, FALSE=30, AND=31, OR=32, 
		NOT=33, ID=34, INTEGER=35, FLOAT=36, STRING=37, DATETIME=38, NAME=39, 
		EXPONENT=40, WS=41;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "TRUE", "FALSE", "AND", "OR", "NOT", "ID", 
		"INTEGER", "FLOAT", "STRING", "DATETIME", "NAME", "EXPONENT", "LETTER", 
		"DIGIT", "EscapeSequence", "HexDigit", "UnicodeEscape", "WS", "A", "B", 
		"C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", 
		"Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
	};


	public bool UseDecimal = false;

	private const char BS = '\\';
	private static NumberFormatInfo numberFormatInfo = new NumberFormatInfo();

	private string extractString(string text) {
	    
	    StringBuilder sb = new StringBuilder(text);
	    int startIndex = 1; // Skip initial quote
	    int slashIndex = -1;

	    while ((slashIndex = sb.ToString().IndexOf(BS, startIndex)) != -1)
	    {
	        char escapeType = sb[slashIndex + 1];
	        switch (escapeType)
	        {
	            case 'u':
	              string hcode = String.Concat(sb[slashIndex+4], sb[slashIndex+5]);
	              string lcode = String.Concat(sb[slashIndex+2], sb[slashIndex+3]);
	              char unicodeChar = Encoding.Unicode.GetChars(new byte[] { System.Convert.ToByte(hcode, 16), System.Convert.ToByte(lcode, 16)} )[0];
	              sb.Remove(slashIndex, 6).Insert(slashIndex, unicodeChar); 
	              break;
	            case 'n': sb.Remove(slashIndex, 2).Insert(slashIndex, '\n'); break;
	            case 'r': sb.Remove(slashIndex, 2).Insert(slashIndex, '\r'); break;
	            case 't': sb.Remove(slashIndex, 2).Insert(slashIndex, '\t'); break;
	            case '\'': sb.Remove(slashIndex, 2).Insert(slashIndex, '\''); break;
	            case '\\': sb.Remove(slashIndex, 2).Insert(slashIndex, '\\'); break;
	            default: throw new RecognitionException(null, CharStreams.fromString("Invalid escape sequence: \\" + escapeType));
	        }

	        startIndex = slashIndex + 1;

	    }

	    sb.Remove(0, 1);
	    sb.Remove(sb.Length - 1, 1);

	    return sb.ToString();
	}



	public NCalcLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public NCalcLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'?'", "':'", "'||'", "'&&'", "'|'", "'^'", "'&'", "'=='", "'='", 
		"'!='", "'<>'", "'<'", "'<='", "'>'", "'>='", "'<<'", "'>>'", "'+'", "'-'", 
		"'*'", "'/'", "'%'", "'!'", "'~'", "'**'", "'('", "')'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, "TRUE", "FALSE", "AND", "OR", "NOT", "ID", 
		"INTEGER", "FLOAT", "STRING", "DATETIME", "NAME", "EXPONENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "NCalc.g"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static NCalcLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,41,401,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,2,65,7,65,2,66,7,66,2,67,7,67,2,68,7,68,2,69,7,69,2,70,
		7,70,2,71,7,71,1,0,1,0,1,1,1,1,1,2,1,2,1,2,1,3,1,3,1,3,1,4,1,4,1,5,1,5,
		1,6,1,6,1,7,1,7,1,7,1,8,1,8,1,9,1,9,1,9,1,10,1,10,1,10,1,11,1,11,1,12,
		1,12,1,12,1,13,1,13,1,14,1,14,1,14,1,15,1,15,1,15,1,16,1,16,1,16,1,17,
		1,17,1,18,1,18,1,19,1,19,1,20,1,20,1,21,1,21,1,22,1,22,1,23,1,23,1,24,
		1,24,1,24,1,25,1,25,1,26,1,26,1,27,1,27,1,28,1,28,1,28,1,28,1,28,1,29,
		1,29,1,29,1,29,1,29,1,29,1,30,1,30,1,30,1,30,1,31,1,31,1,31,1,32,1,32,
		1,32,1,32,1,33,1,33,1,33,5,33,237,8,33,10,33,12,33,240,9,33,1,34,4,34,
		243,8,34,11,34,12,34,244,1,35,5,35,248,8,35,10,35,12,35,251,9,35,1,35,
		1,35,4,35,255,8,35,11,35,12,35,256,1,35,3,35,260,8,35,1,35,4,35,263,8,
		35,11,35,12,35,264,1,35,1,35,5,35,269,8,35,10,35,12,35,272,9,35,1,35,3,
		35,275,8,35,1,35,4,35,278,8,35,11,35,12,35,279,1,35,1,35,3,35,284,8,35,
		1,36,1,36,1,36,1,36,5,36,290,8,36,10,36,12,36,293,9,36,5,36,295,8,36,10,
		36,12,36,298,9,36,1,36,1,36,1,37,1,37,5,37,304,8,37,10,37,12,37,307,9,
		37,1,37,1,37,1,38,1,38,5,38,313,8,38,10,38,12,38,316,9,38,1,38,1,38,1,
		39,1,39,3,39,322,8,39,1,39,4,39,325,8,39,11,39,12,39,326,1,40,1,40,1,41,
		1,41,1,42,1,42,1,42,3,42,336,8,42,1,43,1,43,1,44,1,44,1,44,1,44,1,44,1,
		44,1,45,1,45,1,45,1,45,1,46,1,46,1,47,1,47,1,48,1,48,1,49,1,49,1,50,1,
		50,1,51,1,51,1,52,1,52,1,53,1,53,1,54,1,54,1,55,1,55,1,56,1,56,1,57,1,
		57,1,58,1,58,1,59,1,59,1,60,1,60,1,61,1,61,1,62,1,62,1,63,1,63,1,64,1,
		64,1,65,1,65,1,66,1,66,1,67,1,67,1,68,1,68,1,69,1,69,1,70,1,70,1,71,1,
		71,1,291,0,72,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,
		25,13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,
		49,25,51,26,53,27,55,28,57,29,59,30,61,31,63,32,65,33,67,34,69,35,71,36,
		73,37,75,38,77,39,79,40,81,0,83,0,85,0,87,0,89,0,91,41,93,0,95,0,97,0,
		99,0,101,0,103,0,105,0,107,0,109,0,111,0,113,0,115,0,117,0,119,0,121,0,
		123,0,125,0,127,0,129,0,131,0,133,0,135,0,137,0,139,0,141,0,143,0,1,0,
		34,3,0,0,31,39,39,92,92,1,0,35,35,1,0,93,93,2,0,69,69,101,101,2,0,43,43,
		45,45,3,0,65,90,95,95,97,122,5,0,39,39,92,92,110,110,114,114,116,116,3,
		0,48,57,65,70,97,102,3,0,9,10,12,13,32,32,2,0,65,65,97,97,2,0,66,66,98,
		98,2,0,67,67,99,99,2,0,68,68,100,100,2,0,70,70,102,102,2,0,71,71,103,103,
		2,0,72,72,104,104,2,0,73,73,105,105,2,0,74,74,106,106,2,0,75,75,107,107,
		2,0,76,76,108,108,2,0,77,77,109,109,2,0,78,78,110,110,2,0,79,79,111,111,
		2,0,80,80,112,112,2,0,81,81,113,113,2,0,82,82,114,114,2,0,83,83,115,115,
		2,0,84,84,116,116,2,0,85,85,117,117,2,0,86,86,118,118,2,0,87,87,119,119,
		2,0,88,88,120,120,2,0,89,89,121,121,2,0,90,90,122,122,389,0,1,1,0,0,0,
		0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,
		0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,
		25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,
		0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,
		0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,
		1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,
		0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,
		1,0,0,0,0,91,1,0,0,0,1,145,1,0,0,0,3,147,1,0,0,0,5,149,1,0,0,0,7,152,1,
		0,0,0,9,155,1,0,0,0,11,157,1,0,0,0,13,159,1,0,0,0,15,161,1,0,0,0,17,164,
		1,0,0,0,19,166,1,0,0,0,21,169,1,0,0,0,23,172,1,0,0,0,25,174,1,0,0,0,27,
		177,1,0,0,0,29,179,1,0,0,0,31,182,1,0,0,0,33,185,1,0,0,0,35,188,1,0,0,
		0,37,190,1,0,0,0,39,192,1,0,0,0,41,194,1,0,0,0,43,196,1,0,0,0,45,198,1,
		0,0,0,47,200,1,0,0,0,49,202,1,0,0,0,51,205,1,0,0,0,53,207,1,0,0,0,55,209,
		1,0,0,0,57,211,1,0,0,0,59,216,1,0,0,0,61,222,1,0,0,0,63,226,1,0,0,0,65,
		229,1,0,0,0,67,233,1,0,0,0,69,242,1,0,0,0,71,283,1,0,0,0,73,285,1,0,0,
		0,75,301,1,0,0,0,77,310,1,0,0,0,79,319,1,0,0,0,81,328,1,0,0,0,83,330,1,
		0,0,0,85,332,1,0,0,0,87,337,1,0,0,0,89,339,1,0,0,0,91,345,1,0,0,0,93,349,
		1,0,0,0,95,351,1,0,0,0,97,353,1,0,0,0,99,355,1,0,0,0,101,357,1,0,0,0,103,
		359,1,0,0,0,105,361,1,0,0,0,107,363,1,0,0,0,109,365,1,0,0,0,111,367,1,
		0,0,0,113,369,1,0,0,0,115,371,1,0,0,0,117,373,1,0,0,0,119,375,1,0,0,0,
		121,377,1,0,0,0,123,379,1,0,0,0,125,381,1,0,0,0,127,383,1,0,0,0,129,385,
		1,0,0,0,131,387,1,0,0,0,133,389,1,0,0,0,135,391,1,0,0,0,137,393,1,0,0,
		0,139,395,1,0,0,0,141,397,1,0,0,0,143,399,1,0,0,0,145,146,5,63,0,0,146,
		2,1,0,0,0,147,148,5,58,0,0,148,4,1,0,0,0,149,150,5,124,0,0,150,151,5,124,
		0,0,151,6,1,0,0,0,152,153,5,38,0,0,153,154,5,38,0,0,154,8,1,0,0,0,155,
		156,5,124,0,0,156,10,1,0,0,0,157,158,5,94,0,0,158,12,1,0,0,0,159,160,5,
		38,0,0,160,14,1,0,0,0,161,162,5,61,0,0,162,163,5,61,0,0,163,16,1,0,0,0,
		164,165,5,61,0,0,165,18,1,0,0,0,166,167,5,33,0,0,167,168,5,61,0,0,168,
		20,1,0,0,0,169,170,5,60,0,0,170,171,5,62,0,0,171,22,1,0,0,0,172,173,5,
		60,0,0,173,24,1,0,0,0,174,175,5,60,0,0,175,176,5,61,0,0,176,26,1,0,0,0,
		177,178,5,62,0,0,178,28,1,0,0,0,179,180,5,62,0,0,180,181,5,61,0,0,181,
		30,1,0,0,0,182,183,5,60,0,0,183,184,5,60,0,0,184,32,1,0,0,0,185,186,5,
		62,0,0,186,187,5,62,0,0,187,34,1,0,0,0,188,189,5,43,0,0,189,36,1,0,0,0,
		190,191,5,45,0,0,191,38,1,0,0,0,192,193,5,42,0,0,193,40,1,0,0,0,194,195,
		5,47,0,0,195,42,1,0,0,0,196,197,5,37,0,0,197,44,1,0,0,0,198,199,5,33,0,
		0,199,46,1,0,0,0,200,201,5,126,0,0,201,48,1,0,0,0,202,203,5,42,0,0,203,
		204,5,42,0,0,204,50,1,0,0,0,205,206,5,40,0,0,206,52,1,0,0,0,207,208,5,
		41,0,0,208,54,1,0,0,0,209,210,5,44,0,0,210,56,1,0,0,0,211,212,3,131,65,
		0,212,213,3,127,63,0,213,214,3,133,66,0,214,215,3,101,50,0,215,58,1,0,
		0,0,216,217,3,103,51,0,217,218,3,93,46,0,218,219,3,115,57,0,219,220,3,
		129,64,0,220,221,3,101,50,0,221,60,1,0,0,0,222,223,3,93,46,0,223,224,3,
		119,59,0,224,225,3,99,49,0,225,62,1,0,0,0,226,227,3,121,60,0,227,228,3,
		127,63,0,228,64,1,0,0,0,229,230,3,119,59,0,230,231,3,121,60,0,231,232,
		3,131,65,0,232,66,1,0,0,0,233,238,3,81,40,0,234,237,3,81,40,0,235,237,
		3,83,41,0,236,234,1,0,0,0,236,235,1,0,0,0,237,240,1,0,0,0,238,236,1,0,
		0,0,238,239,1,0,0,0,239,68,1,0,0,0,240,238,1,0,0,0,241,243,3,83,41,0,242,
		241,1,0,0,0,243,244,1,0,0,0,244,242,1,0,0,0,244,245,1,0,0,0,245,70,1,0,
		0,0,246,248,3,83,41,0,247,246,1,0,0,0,248,251,1,0,0,0,249,247,1,0,0,0,
		249,250,1,0,0,0,250,252,1,0,0,0,251,249,1,0,0,0,252,254,5,46,0,0,253,255,
		3,83,41,0,254,253,1,0,0,0,255,256,1,0,0,0,256,254,1,0,0,0,256,257,1,0,
		0,0,257,259,1,0,0,0,258,260,3,79,39,0,259,258,1,0,0,0,259,260,1,0,0,0,
		260,284,1,0,0,0,261,263,3,83,41,0,262,261,1,0,0,0,263,264,1,0,0,0,264,
		262,1,0,0,0,264,265,1,0,0,0,265,266,1,0,0,0,266,270,5,46,0,0,267,269,3,
		83,41,0,268,267,1,0,0,0,269,272,1,0,0,0,270,268,1,0,0,0,270,271,1,0,0,
		0,271,274,1,0,0,0,272,270,1,0,0,0,273,275,3,79,39,0,274,273,1,0,0,0,274,
		275,1,0,0,0,275,284,1,0,0,0,276,278,3,83,41,0,277,276,1,0,0,0,278,279,
		1,0,0,0,279,277,1,0,0,0,279,280,1,0,0,0,280,281,1,0,0,0,281,282,3,79,39,
		0,282,284,1,0,0,0,283,249,1,0,0,0,283,262,1,0,0,0,283,277,1,0,0,0,284,
		72,1,0,0,0,285,296,5,39,0,0,286,295,3,85,42,0,287,291,8,0,0,0,288,290,
		9,0,0,0,289,288,1,0,0,0,290,293,1,0,0,0,291,292,1,0,0,0,291,289,1,0,0,
		0,292,295,1,0,0,0,293,291,1,0,0,0,294,286,1,0,0,0,294,287,1,0,0,0,295,
		298,1,0,0,0,296,294,1,0,0,0,296,297,1,0,0,0,297,299,1,0,0,0,298,296,1,
		0,0,0,299,300,5,39,0,0,300,74,1,0,0,0,301,305,5,35,0,0,302,304,8,1,0,0,
		303,302,1,0,0,0,304,307,1,0,0,0,305,303,1,0,0,0,305,306,1,0,0,0,306,308,
		1,0,0,0,307,305,1,0,0,0,308,309,5,35,0,0,309,76,1,0,0,0,310,314,5,91,0,
		0,311,313,8,2,0,0,312,311,1,0,0,0,313,316,1,0,0,0,314,312,1,0,0,0,314,
		315,1,0,0,0,315,317,1,0,0,0,316,314,1,0,0,0,317,318,5,93,0,0,318,78,1,
		0,0,0,319,321,7,3,0,0,320,322,7,4,0,0,321,320,1,0,0,0,321,322,1,0,0,0,
		322,324,1,0,0,0,323,325,3,83,41,0,324,323,1,0,0,0,325,326,1,0,0,0,326,
		324,1,0,0,0,326,327,1,0,0,0,327,80,1,0,0,0,328,329,7,5,0,0,329,82,1,0,
		0,0,330,331,2,48,57,0,331,84,1,0,0,0,332,335,5,92,0,0,333,336,7,6,0,0,
		334,336,3,89,44,0,335,333,1,0,0,0,335,334,1,0,0,0,336,86,1,0,0,0,337,338,
		7,7,0,0,338,88,1,0,0,0,339,340,5,117,0,0,340,341,3,87,43,0,341,342,3,87,
		43,0,342,343,3,87,43,0,343,344,3,87,43,0,344,90,1,0,0,0,345,346,7,8,0,
		0,346,347,1,0,0,0,347,348,6,45,0,0,348,92,1,0,0,0,349,350,7,9,0,0,350,
		94,1,0,0,0,351,352,7,10,0,0,352,96,1,0,0,0,353,354,7,11,0,0,354,98,1,0,
		0,0,355,356,7,12,0,0,356,100,1,0,0,0,357,358,7,3,0,0,358,102,1,0,0,0,359,
		360,7,13,0,0,360,104,1,0,0,0,361,362,7,14,0,0,362,106,1,0,0,0,363,364,
		7,15,0,0,364,108,1,0,0,0,365,366,7,16,0,0,366,110,1,0,0,0,367,368,7,17,
		0,0,368,112,1,0,0,0,369,370,7,18,0,0,370,114,1,0,0,0,371,372,7,19,0,0,
		372,116,1,0,0,0,373,374,7,20,0,0,374,118,1,0,0,0,375,376,7,21,0,0,376,
		120,1,0,0,0,377,378,7,22,0,0,378,122,1,0,0,0,379,380,7,23,0,0,380,124,
		1,0,0,0,381,382,7,24,0,0,382,126,1,0,0,0,383,384,7,25,0,0,384,128,1,0,
		0,0,385,386,7,26,0,0,386,130,1,0,0,0,387,388,7,27,0,0,388,132,1,0,0,0,
		389,390,7,28,0,0,390,134,1,0,0,0,391,392,7,29,0,0,392,136,1,0,0,0,393,
		394,7,30,0,0,394,138,1,0,0,0,395,396,7,31,0,0,396,140,1,0,0,0,397,398,
		7,32,0,0,398,142,1,0,0,0,399,400,7,33,0,0,400,144,1,0,0,0,20,0,236,238,
		244,249,256,259,264,270,274,279,283,291,294,296,305,314,321,326,335,1,
		6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
