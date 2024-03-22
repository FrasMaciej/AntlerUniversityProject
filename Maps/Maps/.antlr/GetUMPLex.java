// Generated from d://Studia-2st//Antler//AntlerUniversityProject//Maps//Maps//GetUMPLex.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue", "this-escape"})
public class GetUMPLex extends Lexer {
	static { RuntimeMetaData.checkVersion("4.13.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		SECTstart=1, COMMENT=2, WS=3, EQ=4, NL=5, IntComment=6, SECTend=7, LabI=8, 
		ID=9, NUM=10, V=11;
	public static final int
		SECTION=1, VALUE=2;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE", "SECTION", "VALUE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"SECTstart", "COMMENT", "WS", "EQ", "NL", "IntComment", "SECTend", "LabI", 
			"ID", "NUM", "V"
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


	public GetUMPLex(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "GetUMPLex.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\u0004\u0000\u000b\u0081\u0006\uffff\uffff\u0006\uffff\uffff\u0006\uffff"+
		"\uffff\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002\u0002\u0007"+
		"\u0002\u0002\u0003\u0007\u0003\u0002\u0004\u0007\u0004\u0002\u0005\u0007"+
		"\u0005\u0002\u0006\u0007\u0006\u0002\u0007\u0007\u0007\u0002\b\u0007\b"+
		"\u0002\t\u0007\t\u0002\n\u0007\n\u0001\u0000\u0001\u0000\u0005\u0000\u001c"+
		"\b\u0000\n\u0000\f\u0000\u001f\t\u0000\u0001\u0000\u0001\u0000\u0001\u0000"+
		"\u0001\u0000\u0001\u0001\u0001\u0001\u0005\u0001\'\b\u0001\n\u0001\f\u0001"+
		"*\t\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0002"+
		"\u0004\u00021\b\u0002\u000b\u0002\f\u00022\u0001\u0002\u0001\u0002\u0001"+
		"\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0004\u0004\u0004<\b"+
		"\u0004\u000b\u0004\f\u0004=\u0001\u0004\u0001\u0004\u0001\u0005\u0001"+
		"\u0005\u0005\u0005D\b\u0005\n\u0005\f\u0005G\t\u0005\u0001\u0005\u0001"+
		"\u0005\u0001\u0005\u0001\u0005\u0001\u0006\u0001\u0006\u0001\u0006\u0001"+
		"\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001"+
		"\u0006\u0003\u0006W\b\u0006\u0001\u0006\u0001\u0006\u0005\u0006[\b\u0006"+
		"\n\u0006\f\u0006^\t\u0006\u0003\u0006`\b\u0006\u0001\u0006\u0001\u0006"+
		"\u0001\u0006\u0001\u0006\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007"+
		"\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\b\u0004\bo\b\b"+
		"\u000b\b\f\bp\u0001\t\u0004\tt\b\t\u000b\t\f\tu\u0001\n\u0005\ny\b\n\n"+
		"\n\f\n|\t\n\u0001\n\u0001\n\u0001\n\u0001\n\u0004\u001d(E\\\u0000\u000b"+
		"\u0003\u0001\u0005\u0002\u0007\u0003\t\u0004\u000b\u0005\r\u0006\u000f"+
		"\u0007\u0011\b\u0013\t\u0015\n\u0017\u000b\u0003\u0000\u0001\u0002\u0005"+
		"\u0003\u0000\t\n\r\r  \u0002\u0000\n\n\r\r\u0001\u000023\u0004\u0000:"+
		":AZ__az\u0001\u000009\u008a\u0000\u0003\u0001\u0000\u0000\u0000\u0000"+
		"\u0005\u0001\u0000\u0000\u0000\u0000\u0007\u0001\u0000\u0000\u0000\u0001"+
		"\t\u0001\u0000\u0000\u0000\u0001\u000b\u0001\u0000\u0000\u0000\u0001\r"+
		"\u0001\u0000\u0000\u0000\u0001\u000f\u0001\u0000\u0000\u0000\u0001\u0011"+
		"\u0001\u0000\u0000\u0000\u0001\u0013\u0001\u0000\u0000\u0000\u0001\u0015"+
		"\u0001\u0000\u0000\u0000\u0002\u0017\u0001\u0000\u0000\u0000\u0003\u0019"+
		"\u0001\u0000\u0000\u0000\u0005$\u0001\u0000\u0000\u0000\u00070\u0001\u0000"+
		"\u0000\u0000\t6\u0001\u0000\u0000\u0000\u000b;\u0001\u0000\u0000\u0000"+
		"\rA\u0001\u0000\u0000\u0000\u000fL\u0001\u0000\u0000\u0000\u0011e\u0001"+
		"\u0000\u0000\u0000\u0013n\u0001\u0000\u0000\u0000\u0015s\u0001\u0000\u0000"+
		"\u0000\u0017z\u0001\u0000\u0000\u0000\u0019\u001d\u0005[\u0000\u0000\u001a"+
		"\u001c\t\u0000\u0000\u0000\u001b\u001a\u0001\u0000\u0000\u0000\u001c\u001f"+
		"\u0001\u0000\u0000\u0000\u001d\u001e\u0001\u0000\u0000\u0000\u001d\u001b"+
		"\u0001\u0000\u0000\u0000\u001e \u0001\u0000\u0000\u0000\u001f\u001d\u0001"+
		"\u0000\u0000\u0000 !\u0005]\u0000\u0000!\"\u0001\u0000\u0000\u0000\"#"+
		"\u0006\u0000\u0000\u0000#\u0004\u0001\u0000\u0000\u0000$(\u0005;\u0000"+
		"\u0000%\'\t\u0000\u0000\u0000&%\u0001\u0000\u0000\u0000\'*\u0001\u0000"+
		"\u0000\u0000()\u0001\u0000\u0000\u0000(&\u0001\u0000\u0000\u0000)+\u0001"+
		"\u0000\u0000\u0000*(\u0001\u0000\u0000\u0000+,\u0005\n\u0000\u0000,-\u0001"+
		"\u0000\u0000\u0000-.\u0006\u0001\u0001\u0000.\u0006\u0001\u0000\u0000"+
		"\u0000/1\u0007\u0000\u0000\u00000/\u0001\u0000\u0000\u000012\u0001\u0000"+
		"\u0000\u000020\u0001\u0000\u0000\u000023\u0001\u0000\u0000\u000034\u0001"+
		"\u0000\u0000\u000045\u0006\u0002\u0001\u00005\b\u0001\u0000\u0000\u0000"+
		"67\u0005=\u0000\u000078\u0001\u0000\u0000\u000089\u0006\u0003\u0002\u0000"+
		"9\n\u0001\u0000\u0000\u0000:<\u0007\u0001\u0000\u0000;:\u0001\u0000\u0000"+
		"\u0000<=\u0001\u0000\u0000\u0000=;\u0001\u0000\u0000\u0000=>\u0001\u0000"+
		"\u0000\u0000>?\u0001\u0000\u0000\u0000?@\u0006\u0004\u0001\u0000@\f\u0001"+
		"\u0000\u0000\u0000AE\u0005\"\u0000\u0000BD\t\u0000\u0000\u0000CB\u0001"+
		"\u0000\u0000\u0000DG\u0001\u0000\u0000\u0000EF\u0001\u0000\u0000\u0000"+
		"EC\u0001\u0000\u0000\u0000FH\u0001\u0000\u0000\u0000GE\u0001\u0000\u0000"+
		"\u0000HI\u0005\n\u0000\u0000IJ\u0001\u0000\u0000\u0000JK\u0006\u0005\u0001"+
		"\u0000K\u000e\u0001\u0000\u0000\u0000LV\u0005[\u0000\u0000MN\u0005E\u0000"+
		"\u0000NO\u0005N\u0000\u0000OW\u0005D\u0000\u0000PQ\u0005E\u0000\u0000"+
		"QR\u0005n\u0000\u0000RW\u0005d\u0000\u0000ST\u0005e\u0000\u0000TU\u0005"+
		"n\u0000\u0000UW\u0005d\u0000\u0000VM\u0001\u0000\u0000\u0000VP\u0001\u0000"+
		"\u0000\u0000VS\u0001\u0000\u0000\u0000W_\u0001\u0000\u0000\u0000X\\\u0005"+
		"-\u0000\u0000Y[\t\u0000\u0000\u0000ZY\u0001\u0000\u0000\u0000[^\u0001"+
		"\u0000\u0000\u0000\\]\u0001\u0000\u0000\u0000\\Z\u0001\u0000\u0000\u0000"+
		"]`\u0001\u0000\u0000\u0000^\\\u0001\u0000\u0000\u0000_X\u0001\u0000\u0000"+
		"\u0000_`\u0001\u0000\u0000\u0000`a\u0001\u0000\u0000\u0000ab\u0005]\u0000"+
		"\u0000bc\u0001\u0000\u0000\u0000cd\u0006\u0006\u0003\u0000d\u0010\u0001"+
		"\u0000\u0000\u0000ef\u0005L\u0000\u0000fg\u0005a\u0000\u0000gh\u0005b"+
		"\u0000\u0000hi\u0005e\u0000\u0000ij\u0005l\u0000\u0000jk\u0001\u0000\u0000"+
		"\u0000kl\u0007\u0002\u0000\u0000l\u0012\u0001\u0000\u0000\u0000mo\u0007"+
		"\u0003\u0000\u0000nm\u0001\u0000\u0000\u0000op\u0001\u0000\u0000\u0000"+
		"pn\u0001\u0000\u0000\u0000pq\u0001\u0000\u0000\u0000q\u0014\u0001\u0000"+
		"\u0000\u0000rt\u0007\u0004\u0000\u0000sr\u0001\u0000\u0000\u0000tu\u0001"+
		"\u0000\u0000\u0000us\u0001\u0000\u0000\u0000uv\u0001\u0000\u0000\u0000"+
		"v\u0016\u0001\u0000\u0000\u0000wy\b\u0001\u0000\u0000xw\u0001\u0000\u0000"+
		"\u0000y|\u0001\u0000\u0000\u0000zx\u0001\u0000\u0000\u0000z{\u0001\u0000"+
		"\u0000\u0000{}\u0001\u0000\u0000\u0000|z\u0001\u0000\u0000\u0000}~\u0005"+
		"\n\u0000\u0000~\u007f\u0001\u0000\u0000\u0000\u007f\u0080\u0006\n\u0003"+
		"\u0000\u0080\u0018\u0001\u0000\u0000\u0000\u000e\u0000\u0001\u0002\u001d"+
		"(2=EV\\_puz\u0004\u0005\u0001\u0000\u0006\u0000\u0000\u0005\u0002\u0000"+
		"\u0004\u0000\u0000";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}