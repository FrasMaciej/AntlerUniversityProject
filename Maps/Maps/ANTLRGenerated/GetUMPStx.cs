//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from x:/source/Antlr/FrasMaciej/AntlerUniversityProject/Maps/Maps/GetUMPStx.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class GetUMPStx : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		POLYGON_SECTstart=1, POLYLINE_SECTstart=2, POI_SECTstart=3, SECTstart=4, 
		COMMENT=5, WS=6, EQ=7, NL=8, IntComment=9, SECTend=10, LabI=11, ID=12, 
		NUM=13, FLOAT=14, POINT=15, POINTS=16, COMMA=17, V=18, V_END=19;
	public const int
		RULE_file = 0, RULE_section = 1, RULE_polygon_section = 2, RULE_polyline_section = 3, 
		RULE_poi_section = 4, RULE_default_section = 5, RULE_idxEqId = 6, RULE_kvEq = 7;
	public static readonly string[] ruleNames = {
		"file", "section", "polygon_section", "polyline_section", "poi_section", 
		"default_section", "idxEqId", "kvEq"
	};

	private static readonly string[] _LiteralNames = {
		null, "'[POLYGON]'", "'[POLYLINE]'", "'[POI]'", null, null, null, "'='", 
		null, null, null, null, null, null, null, null, null, "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "POLYGON_SECTstart", "POLYLINE_SECTstart", "POI_SECTstart", "SECTstart", 
		"COMMENT", "WS", "EQ", "NL", "IntComment", "SECTend", "LabI", "ID", "NUM", 
		"FLOAT", "POINT", "POINTS", "COMMA", "V", "V_END"
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

	public override string GrammarFileName { get { return "GetUMPStx.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static GetUMPStx() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public GetUMPStx(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public GetUMPStx(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class FileContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(GetUMPStx.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SectionContext[] section() {
			return GetRuleContexts<SectionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SectionContext section(int i) {
			return GetRuleContext<SectionContext>(i);
		}
		public FileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_file; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFile(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FileContext file() {
		FileContext _localctx = new FileContext(Context, State);
		EnterRule(_localctx, 0, RULE_file);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 30L) != 0)) {
				{
				{
				State = 16;
				section();
				}
				}
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 22;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Polygon_sectionContext polygon_section() {
			return GetRuleContext<Polygon_sectionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Polyline_sectionContext polyline_section() {
			return GetRuleContext<Polyline_sectionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Poi_sectionContext poi_section() {
			return GetRuleContext<Poi_sectionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Default_sectionContext default_section() {
			return GetRuleContext<Default_sectionContext>(0);
		}
		public SectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_section; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSection(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SectionContext section() {
		SectionContext _localctx = new SectionContext(Context, State);
		EnterRule(_localctx, 2, RULE_section);
		try {
			State = 28;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case POLYGON_SECTstart:
				EnterOuterAlt(_localctx, 1);
				{
				State = 24;
				polygon_section();
				}
				break;
			case POLYLINE_SECTstart:
				EnterOuterAlt(_localctx, 2);
				{
				State = 25;
				polyline_section();
				}
				break;
			case POI_SECTstart:
				EnterOuterAlt(_localctx, 3);
				{
				State = 26;
				poi_section();
				}
				break;
			case SECTstart:
				EnterOuterAlt(_localctx, 4);
				{
				State = 27;
				default_section();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Polygon_sectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode POLYGON_SECTstart() { return GetToken(GetUMPStx.POLYGON_SECTstart, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SECTend() { return GetToken(GetUMPStx.SECTend, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public KvEqContext[] kvEq() {
			return GetRuleContexts<KvEqContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public KvEqContext kvEq(int i) {
			return GetRuleContext<KvEqContext>(i);
		}
		public Polygon_sectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_polygon_section; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPolygon_section(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Polygon_sectionContext polygon_section() {
		Polygon_sectionContext _localctx = new Polygon_sectionContext(Context, State);
		EnterRule(_localctx, 4, RULE_polygon_section);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 30;
			Match(POLYGON_SECTstart);
			State = 34;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==LabI || _la==ID) {
				{
				{
				State = 31;
				kvEq();
				}
				}
				State = 36;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 37;
			Match(SECTend);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Polyline_sectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode POLYLINE_SECTstart() { return GetToken(GetUMPStx.POLYLINE_SECTstart, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SECTend() { return GetToken(GetUMPStx.SECTend, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public KvEqContext[] kvEq() {
			return GetRuleContexts<KvEqContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public KvEqContext kvEq(int i) {
			return GetRuleContext<KvEqContext>(i);
		}
		public Polyline_sectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_polyline_section; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPolyline_section(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Polyline_sectionContext polyline_section() {
		Polyline_sectionContext _localctx = new Polyline_sectionContext(Context, State);
		EnterRule(_localctx, 6, RULE_polyline_section);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 39;
			Match(POLYLINE_SECTstart);
			State = 43;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==LabI || _la==ID) {
				{
				{
				State = 40;
				kvEq();
				}
				}
				State = 45;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 46;
			Match(SECTend);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Poi_sectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode POI_SECTstart() { return GetToken(GetUMPStx.POI_SECTstart, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SECTend() { return GetToken(GetUMPStx.SECTend, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public KvEqContext[] kvEq() {
			return GetRuleContexts<KvEqContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public KvEqContext kvEq(int i) {
			return GetRuleContext<KvEqContext>(i);
		}
		public Poi_sectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_poi_section; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoi_section(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Poi_sectionContext poi_section() {
		Poi_sectionContext _localctx = new Poi_sectionContext(Context, State);
		EnterRule(_localctx, 8, RULE_poi_section);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 48;
			Match(POI_SECTstart);
			State = 52;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==LabI || _la==ID) {
				{
				{
				State = 49;
				kvEq();
				}
				}
				State = 54;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 55;
			Match(SECTend);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Default_sectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SECTstart() { return GetToken(GetUMPStx.SECTstart, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SECTend() { return GetToken(GetUMPStx.SECTend, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public KvEqContext[] kvEq() {
			return GetRuleContexts<KvEqContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public KvEqContext kvEq(int i) {
			return GetRuleContext<KvEqContext>(i);
		}
		public Default_sectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_default_section; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDefault_section(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Default_sectionContext default_section() {
		Default_sectionContext _localctx = new Default_sectionContext(Context, State);
		EnterRule(_localctx, 10, RULE_default_section);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 57;
			Match(SECTstart);
			State = 61;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==LabI || _la==ID) {
				{
				{
				State = 58;
				kvEq();
				}
				}
				State = 63;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 64;
			Match(SECTend);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdxEqIdContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(GetUMPStx.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(GetUMPStx.NUM, 0); }
		public IdxEqIdContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_idxEqId; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdxEqId(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IdxEqIdContext idxEqId() {
		IdxEqIdContext _localctx = new IdxEqIdContext(Context, State);
		EnterRule(_localctx, 12, RULE_idxEqId);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 66;
			Match(ID);
			State = 67;
			Match(NUM);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class KvEqContext : ParserRuleContext {
		public KvEqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_kvEq; } }
	 
		public KvEqContext() { }
		public virtual void CopyFrom(KvEqContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class IdxEqPointsContext : KvEqContext {
		public IdxEqIdContext idx;
		public IToken pointsval;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQ() { return GetToken(GetUMPStx.EQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode V_END() { return GetToken(GetUMPStx.V_END, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdxEqIdContext idxEqId() {
			return GetRuleContext<IdxEqIdContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode POINTS() { return GetToken(GetUMPStx.POINTS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NL() { return GetToken(GetUMPStx.NL, 0); }
		public IdxEqPointsContext(KvEqContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdxEqPoints(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class SimpleEqContext : KvEqContext {
		public IToken key;
		public IToken val;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQ() { return GetToken(GetUMPStx.EQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode V_END() { return GetToken(GetUMPStx.V_END, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(GetUMPStx.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LabI() { return GetToken(GetUMPStx.LabI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NL() { return GetToken(GetUMPStx.NL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode V() { return GetToken(GetUMPStx.V, 0); }
		public SimpleEqContext(KvEqContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSimpleEq(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class SimpleEqPointsContext : KvEqContext {
		public IToken key;
		public IToken pointsval;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQ() { return GetToken(GetUMPStx.EQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode V_END() { return GetToken(GetUMPStx.V_END, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode POINTS() { return GetToken(GetUMPStx.POINTS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(GetUMPStx.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LabI() { return GetToken(GetUMPStx.LabI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NL() { return GetToken(GetUMPStx.NL, 0); }
		public SimpleEqPointsContext(KvEqContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSimpleEqPoints(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IdxEqContext : KvEqContext {
		public IdxEqIdContext idx;
		public IToken val;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQ() { return GetToken(GetUMPStx.EQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode V_END() { return GetToken(GetUMPStx.V_END, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdxEqIdContext idxEqId() {
			return GetRuleContext<IdxEqIdContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NL() { return GetToken(GetUMPStx.NL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode V() { return GetToken(GetUMPStx.V, 0); }
		public IdxEqContext(KvEqContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGetUMPStxVisitor<TResult> typedVisitor = visitor as IGetUMPStxVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdxEq(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public KvEqContext kvEq() {
		KvEqContext _localctx = new KvEqContext(Context, State);
		EnterRule(_localctx, 14, RULE_kvEq);
		int _la;
		try {
			State = 101;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,12,Context) ) {
			case 1:
				_localctx = new SimpleEqPointsContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 69;
				((SimpleEqPointsContext)_localctx).key = TokenStream.LT(1);
				_la = TokenStream.LA(1);
				if ( !(_la==LabI || _la==ID) ) {
					((SimpleEqPointsContext)_localctx).key = ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 70;
				Match(EQ);
				State = 71;
				((SimpleEqPointsContext)_localctx).pointsval = Match(POINTS);
				State = 72;
				Match(V_END);
				State = 74;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==NL) {
					{
					State = 73;
					Match(NL);
					}
				}

				}
				break;
			case 2:
				_localctx = new IdxEqPointsContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 76;
				((IdxEqPointsContext)_localctx).idx = idxEqId();
				State = 77;
				Match(EQ);
				State = 78;
				((IdxEqPointsContext)_localctx).pointsval = Match(POINTS);
				State = 79;
				Match(V_END);
				State = 81;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==NL) {
					{
					State = 80;
					Match(NL);
					}
				}

				}
				break;
			case 3:
				_localctx = new SimpleEqContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 83;
				((SimpleEqContext)_localctx).key = TokenStream.LT(1);
				_la = TokenStream.LA(1);
				if ( !(_la==LabI || _la==ID) ) {
					((SimpleEqContext)_localctx).key = ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 84;
				Match(EQ);
				State = 86;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==V) {
					{
					State = 85;
					((SimpleEqContext)_localctx).val = Match(V);
					}
				}

				State = 88;
				Match(V_END);
				State = 90;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==NL) {
					{
					State = 89;
					Match(NL);
					}
				}

				}
				break;
			case 4:
				_localctx = new IdxEqContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 92;
				((IdxEqContext)_localctx).idx = idxEqId();
				State = 93;
				Match(EQ);
				State = 95;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==V) {
					{
					State = 94;
					((IdxEqContext)_localctx).val = Match(V);
					}
				}

				State = 97;
				Match(V_END);
				State = 99;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==NL) {
					{
					State = 98;
					Match(NL);
					}
				}

				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,19,104,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,1,0,5,0,18,8,0,10,0,12,0,21,9,0,1,0,1,0,1,1,1,1,1,1,1,1,3,1,29,8,1,
		1,2,1,2,5,2,33,8,2,10,2,12,2,36,9,2,1,2,1,2,1,3,1,3,5,3,42,8,3,10,3,12,
		3,45,9,3,1,3,1,3,1,4,1,4,5,4,51,8,4,10,4,12,4,54,9,4,1,4,1,4,1,5,1,5,5,
		5,60,8,5,10,5,12,5,63,9,5,1,5,1,5,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,3,7,
		75,8,7,1,7,1,7,1,7,1,7,1,7,3,7,82,8,7,1,7,1,7,1,7,3,7,87,8,7,1,7,1,7,3,
		7,91,8,7,1,7,1,7,1,7,3,7,96,8,7,1,7,1,7,3,7,100,8,7,3,7,102,8,7,1,7,0,
		0,8,0,2,4,6,8,10,12,14,0,1,1,0,11,12,112,0,19,1,0,0,0,2,28,1,0,0,0,4,30,
		1,0,0,0,6,39,1,0,0,0,8,48,1,0,0,0,10,57,1,0,0,0,12,66,1,0,0,0,14,101,1,
		0,0,0,16,18,3,2,1,0,17,16,1,0,0,0,18,21,1,0,0,0,19,17,1,0,0,0,19,20,1,
		0,0,0,20,22,1,0,0,0,21,19,1,0,0,0,22,23,5,0,0,1,23,1,1,0,0,0,24,29,3,4,
		2,0,25,29,3,6,3,0,26,29,3,8,4,0,27,29,3,10,5,0,28,24,1,0,0,0,28,25,1,0,
		0,0,28,26,1,0,0,0,28,27,1,0,0,0,29,3,1,0,0,0,30,34,5,1,0,0,31,33,3,14,
		7,0,32,31,1,0,0,0,33,36,1,0,0,0,34,32,1,0,0,0,34,35,1,0,0,0,35,37,1,0,
		0,0,36,34,1,0,0,0,37,38,5,10,0,0,38,5,1,0,0,0,39,43,5,2,0,0,40,42,3,14,
		7,0,41,40,1,0,0,0,42,45,1,0,0,0,43,41,1,0,0,0,43,44,1,0,0,0,44,46,1,0,
		0,0,45,43,1,0,0,0,46,47,5,10,0,0,47,7,1,0,0,0,48,52,5,3,0,0,49,51,3,14,
		7,0,50,49,1,0,0,0,51,54,1,0,0,0,52,50,1,0,0,0,52,53,1,0,0,0,53,55,1,0,
		0,0,54,52,1,0,0,0,55,56,5,10,0,0,56,9,1,0,0,0,57,61,5,4,0,0,58,60,3,14,
		7,0,59,58,1,0,0,0,60,63,1,0,0,0,61,59,1,0,0,0,61,62,1,0,0,0,62,64,1,0,
		0,0,63,61,1,0,0,0,64,65,5,10,0,0,65,11,1,0,0,0,66,67,5,12,0,0,67,68,5,
		13,0,0,68,13,1,0,0,0,69,70,7,0,0,0,70,71,5,7,0,0,71,72,5,16,0,0,72,74,
		5,19,0,0,73,75,5,8,0,0,74,73,1,0,0,0,74,75,1,0,0,0,75,102,1,0,0,0,76,77,
		3,12,6,0,77,78,5,7,0,0,78,79,5,16,0,0,79,81,5,19,0,0,80,82,5,8,0,0,81,
		80,1,0,0,0,81,82,1,0,0,0,82,102,1,0,0,0,83,84,7,0,0,0,84,86,5,7,0,0,85,
		87,5,18,0,0,86,85,1,0,0,0,86,87,1,0,0,0,87,88,1,0,0,0,88,90,5,19,0,0,89,
		91,5,8,0,0,90,89,1,0,0,0,90,91,1,0,0,0,91,102,1,0,0,0,92,93,3,12,6,0,93,
		95,5,7,0,0,94,96,5,18,0,0,95,94,1,0,0,0,95,96,1,0,0,0,96,97,1,0,0,0,97,
		99,5,19,0,0,98,100,5,8,0,0,99,98,1,0,0,0,99,100,1,0,0,0,100,102,1,0,0,
		0,101,69,1,0,0,0,101,76,1,0,0,0,101,83,1,0,0,0,101,92,1,0,0,0,102,15,1,
		0,0,0,13,19,28,34,43,52,61,74,81,86,90,95,99,101
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
