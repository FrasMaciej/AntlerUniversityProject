// Generated from x:/source/Antlr/FrasMaciej/AntlerUniversityProject/Maps/Maps/GetUMPStx.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue"})
public class GetUMPStx extends Parser {
	static { RuntimeMetaData.checkVersion("4.13.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		SECTstart=1, COMMENT=2, WS=3, EQ=4, NL=5, IntComment=6, SECTend=7, LabI=8, 
		ID=9, NUM=10, V=11;
	public static final int
		RULE_file = 0, RULE_section = 1, RULE_idxEqId = 2, RULE_kvEq = 3;
	private static String[] makeRuleNames() {
		return new String[] {
			"file", "section", "idxEqId", "kvEq"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, null, null, null, "'='"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "SECTstart", "COMMENT", "WS", "EQ", "NL", "IntComment", "SECTend", 
			"LabI", "ID", "NUM", "V"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "GetUMPStx.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public GetUMPStx(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@SuppressWarnings("CheckReturnValue")
	public static class FileContext extends ParserRuleContext {
		public TerminalNode EOF() { return getToken(GetUMPStx.EOF, 0); }
		public List<SectionContext> section() {
			return getRuleContexts(SectionContext.class);
		}
		public SectionContext section(int i) {
			return getRuleContext(SectionContext.class,i);
		}
		public FileContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_file; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GetUMPStxListener ) ((GetUMPStxListener)listener).enterFile(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GetUMPStxListener ) ((GetUMPStxListener)listener).exitFile(this);
		}
	}

	public final FileContext file() throws RecognitionException {
		FileContext _localctx = new FileContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_file);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(11);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==SECTstart) {
				{
				{
				setState(8);
				section();
				}
				}
				setState(13);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(14);
			match(EOF);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class SectionContext extends ParserRuleContext {
		public TerminalNode SECTstart() { return getToken(GetUMPStx.SECTstart, 0); }
		public TerminalNode SECTend() { return getToken(GetUMPStx.SECTend, 0); }
		public List<KvEqContext> kvEq() {
			return getRuleContexts(KvEqContext.class);
		}
		public KvEqContext kvEq(int i) {
			return getRuleContext(KvEqContext.class,i);
		}
		public SectionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_section; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GetUMPStxListener ) ((GetUMPStxListener)listener).enterSection(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GetUMPStxListener ) ((GetUMPStxListener)listener).exitSection(this);
		}
	}

	public final SectionContext section() throws RecognitionException {
		SectionContext _localctx = new SectionContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_section);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(16);
			match(SECTstart);
			setState(20);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==LabI || _la==ID) {
				{
				{
				setState(17);
				kvEq();
				}
				}
				setState(22);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(23);
			match(SECTend);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class IdxEqIdContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(GetUMPStx.ID, 0); }
		public TerminalNode NUM() { return getToken(GetUMPStx.NUM, 0); }
		public IdxEqIdContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_idxEqId; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GetUMPStxListener ) ((GetUMPStxListener)listener).enterIdxEqId(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GetUMPStxListener ) ((GetUMPStxListener)listener).exitIdxEqId(this);
		}
	}

	public final IdxEqIdContext idxEqId() throws RecognitionException {
		IdxEqIdContext _localctx = new IdxEqIdContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_idxEqId);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(25);
			match(ID);
			setState(26);
			match(NUM);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class KvEqContext extends ParserRuleContext {
		public KvEqContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_kvEq; }
	 
		public KvEqContext() { }
		public void copyFrom(KvEqContext ctx) {
			super.copyFrom(ctx);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class SimpleEqContext extends KvEqContext {
		public Token key;
		public Token val;
		public TerminalNode EQ() { return getToken(GetUMPStx.EQ, 0); }
		public TerminalNode V() { return getToken(GetUMPStx.V, 0); }
		public TerminalNode ID() { return getToken(GetUMPStx.ID, 0); }
		public TerminalNode LabI() { return getToken(GetUMPStx.LabI, 0); }
		public TerminalNode NL() { return getToken(GetUMPStx.NL, 0); }
		public SimpleEqContext(KvEqContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GetUMPStxListener ) ((GetUMPStxListener)listener).enterSimpleEq(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GetUMPStxListener ) ((GetUMPStxListener)listener).exitSimpleEq(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class IdxEqContext extends KvEqContext {
		public IdxEqIdContext idx;
		public Token val;
		public TerminalNode EQ() { return getToken(GetUMPStx.EQ, 0); }
		public IdxEqIdContext idxEqId() {
			return getRuleContext(IdxEqIdContext.class,0);
		}
		public TerminalNode V() { return getToken(GetUMPStx.V, 0); }
		public TerminalNode NL() { return getToken(GetUMPStx.NL, 0); }
		public IdxEqContext(KvEqContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof GetUMPStxListener ) ((GetUMPStxListener)listener).enterIdxEq(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof GetUMPStxListener ) ((GetUMPStxListener)listener).exitIdxEq(this);
		}
	}

	public final KvEqContext kvEq() throws RecognitionException {
		KvEqContext _localctx = new KvEqContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_kvEq);
		int _la;
		try {
			setState(40);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				_localctx = new SimpleEqContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(28);
				((SimpleEqContext)_localctx).key = _input.LT(1);
				_la = _input.LA(1);
				if ( !(_la==LabI || _la==ID) ) {
					((SimpleEqContext)_localctx).key = (Token)_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				setState(29);
				match(EQ);
				setState(30);
				((SimpleEqContext)_localctx).val = match(V);
				setState(32);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==NL) {
					{
					setState(31);
					match(NL);
					}
				}

				}
				break;
			case 2:
				_localctx = new IdxEqContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(34);
				((IdxEqContext)_localctx).idx = idxEqId();
				setState(35);
				match(EQ);
				setState(36);
				((IdxEqContext)_localctx).val = match(V);
				setState(38);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==NL) {
					{
					setState(37);
					match(NL);
					}
				}

				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\u0004\u0001\u000b+\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002"+
		"\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0001\u0000\u0005\u0000\n\b"+
		"\u0000\n\u0000\f\u0000\r\t\u0000\u0001\u0000\u0001\u0000\u0001\u0001\u0001"+
		"\u0001\u0005\u0001\u0013\b\u0001\n\u0001\f\u0001\u0016\t\u0001\u0001\u0001"+
		"\u0001\u0001\u0001\u0002\u0001\u0002\u0001\u0002\u0001\u0003\u0001\u0003"+
		"\u0001\u0003\u0001\u0003\u0003\u0003!\b\u0003\u0001\u0003\u0001\u0003"+
		"\u0001\u0003\u0001\u0003\u0003\u0003\'\b\u0003\u0003\u0003)\b\u0003\u0001"+
		"\u0003\u0000\u0000\u0004\u0000\u0002\u0004\u0006\u0000\u0001\u0001\u0000"+
		"\b\t+\u0000\u000b\u0001\u0000\u0000\u0000\u0002\u0010\u0001\u0000\u0000"+
		"\u0000\u0004\u0019\u0001\u0000\u0000\u0000\u0006(\u0001\u0000\u0000\u0000"+
		"\b\n\u0003\u0002\u0001\u0000\t\b\u0001\u0000\u0000\u0000\n\r\u0001\u0000"+
		"\u0000\u0000\u000b\t\u0001\u0000\u0000\u0000\u000b\f\u0001\u0000\u0000"+
		"\u0000\f\u000e\u0001\u0000\u0000\u0000\r\u000b\u0001\u0000\u0000\u0000"+
		"\u000e\u000f\u0005\u0000\u0000\u0001\u000f\u0001\u0001\u0000\u0000\u0000"+
		"\u0010\u0014\u0005\u0001\u0000\u0000\u0011\u0013\u0003\u0006\u0003\u0000"+
		"\u0012\u0011\u0001\u0000\u0000\u0000\u0013\u0016\u0001\u0000\u0000\u0000"+
		"\u0014\u0012\u0001\u0000\u0000\u0000\u0014\u0015\u0001\u0000\u0000\u0000"+
		"\u0015\u0017\u0001\u0000\u0000\u0000\u0016\u0014\u0001\u0000\u0000\u0000"+
		"\u0017\u0018\u0005\u0007\u0000\u0000\u0018\u0003\u0001\u0000\u0000\u0000"+
		"\u0019\u001a\u0005\t\u0000\u0000\u001a\u001b\u0005\n\u0000\u0000\u001b"+
		"\u0005\u0001\u0000\u0000\u0000\u001c\u001d\u0007\u0000\u0000\u0000\u001d"+
		"\u001e\u0005\u0004\u0000\u0000\u001e \u0005\u000b\u0000\u0000\u001f!\u0005"+
		"\u0005\u0000\u0000 \u001f\u0001\u0000\u0000\u0000 !\u0001\u0000\u0000"+
		"\u0000!)\u0001\u0000\u0000\u0000\"#\u0003\u0004\u0002\u0000#$\u0005\u0004"+
		"\u0000\u0000$&\u0005\u000b\u0000\u0000%\'\u0005\u0005\u0000\u0000&%\u0001"+
		"\u0000\u0000\u0000&\'\u0001\u0000\u0000\u0000\')\u0001\u0000\u0000\u0000"+
		"(\u001c\u0001\u0000\u0000\u0000(\"\u0001\u0000\u0000\u0000)\u0007\u0001"+
		"\u0000\u0000\u0000\u0005\u000b\u0014 &(";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}