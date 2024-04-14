// Generated from x:/source/Antlr/FrasMaciej/AntlerUniversityProject/Maps/Maps/GetUMPLex.g4 by ANTLR 4.13.1
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
		"\u0004\u0000\u000b\u0090\u0006\uffff\uffff\u0006\uffff\uffff\u0006\uffff"+
		"\uffff\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002\u0002\u0007"+
		"\u0002\u0002\u0003\u0007\u0003\u0002\u0004\u0007\u0004\u0002\u0005\u0007"+
		"\u0005\u0002\u0006\u0007\u0006\u0002\u0007\u0007\u0007\u0002\b\u0007\b"+
		"\u0002\t\u0007\t\u0002\n\u0007\n\u0001\u0000\u0001\u0000\u0005\u0000\u001c"+
		"\b\u0000\n\u0000\f\u0000\u001f\t\u0000\u0001\u0000\u0001\u0000\u0001\u0000"+
		"\u0001\u0000\u0001\u0001\u0001\u0001\u0005\u0001\'\b\u0001\n\u0001\f\u0001"+
		"*\t\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0002"+
		"\u0004\u00021\b\u0002\u000b\u0002\f\u00022\u0001\u0002\u0001\u0002\u0001"+
		"\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0004\u0004\u0004<\b"+
		"\u0004\u000b\u0004\f\u0004=\u0001\u0004\u0004\u0004A\b\u0004\u000b\u0004"+
		"\f\u0004B\u0001\u0004\u0004\u0004F\b\u0004\u000b\u0004\f\u0004G\u0003"+
		"\u0004J\b\u0004\u0001\u0004\u0001\u0004\u0001\u0005\u0001\u0005\u0005"+
		"\u0005P\b\u0005\n\u0005\f\u0005S\t\u0005\u0001\u0005\u0001\u0005\u0001"+
		"\u0005\u0001\u0005\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001"+
		"\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0003"+
		"\u0006c\b\u0006\u0001\u0006\u0001\u0006\u0005\u0006g\b\u0006\n\u0006\f"+
		"\u0006j\t\u0006\u0003\u0006l\b\u0006\u0001\u0006\u0001\u0006\u0001\u0006"+
		"\u0001\u0006\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007"+
		"\u0001\u0007\u0001\u0007\u0001\u0007\u0001\b\u0004\b{\b\b\u000b\b\f\b"+
		"|\u0001\t\u0004\t\u0080\b\t\u000b\t\f\t\u0081\u0001\n\u0005\n\u0085\b"+
		"\n\n\n\f\n\u0088\t\n\u0001\n\u0001\n\u0001\n\u0003\n\u008d\b\n\u0001\n"+
		"\u0001\n\u0004\u001d(Qh\u0000\u000b\u0003\u0001\u0005\u0002\u0007\u0003"+
		"\t\u0004\u000b\u0005\r\u0006\u000f\u0007\u0011\b\u0013\t\u0015\n\u0017"+
		"\u000b\u0003\u0000\u0001\u0002\u0007\u0003\u0000\t\n\r\r  \u0002\u0000"+
		"\n\n\r\r\u0001\u0000\r\r\u0001\u0000\n\n\u0001\u000023\u0004\u0000::A"+
		"Z__az\u0001\u000009\u009e\u0000\u0003\u0001\u0000\u0000\u0000\u0000\u0005"+
		"\u0001\u0000\u0000\u0000\u0000\u0007\u0001\u0000\u0000\u0000\u0001\t\u0001"+
		"\u0000\u0000\u0000\u0001\u000b\u0001\u0000\u0000\u0000\u0001\r\u0001\u0000"+
		"\u0000\u0000\u0001\u000f\u0001\u0000\u0000\u0000\u0001\u0011\u0001\u0000"+
		"\u0000\u0000\u0001\u0013\u0001\u0000\u0000\u0000\u0001\u0015\u0001\u0000"+
		"\u0000\u0000\u0002\u0017\u0001\u0000\u0000\u0000\u0003\u0019\u0001\u0000"+
		"\u0000\u0000\u0005$\u0001\u0000\u0000\u0000\u00070\u0001\u0000\u0000\u0000"+
		"\t6\u0001\u0000\u0000\u0000\u000bI\u0001\u0000\u0000\u0000\rM\u0001\u0000"+
		"\u0000\u0000\u000fX\u0001\u0000\u0000\u0000\u0011q\u0001\u0000\u0000\u0000"+
		"\u0013z\u0001\u0000\u0000\u0000\u0015\u007f\u0001\u0000\u0000\u0000\u0017"+
		"\u0086\u0001\u0000\u0000\u0000\u0019\u001d\u0005[\u0000\u0000\u001a\u001c"+
		"\t\u0000\u0000\u0000\u001b\u001a\u0001\u0000\u0000\u0000\u001c\u001f\u0001"+
		"\u0000\u0000\u0000\u001d\u001e\u0001\u0000\u0000\u0000\u001d\u001b\u0001"+
		"\u0000\u0000\u0000\u001e \u0001\u0000\u0000\u0000\u001f\u001d\u0001\u0000"+
		"\u0000\u0000 !\u0005]\u0000\u0000!\"\u0001\u0000\u0000\u0000\"#\u0006"+
		"\u0000\u0000\u0000#\u0004\u0001\u0000\u0000\u0000$(\u0005;\u0000\u0000"+
		"%\'\t\u0000\u0000\u0000&%\u0001\u0000\u0000\u0000\'*\u0001\u0000\u0000"+
		"\u0000()\u0001\u0000\u0000\u0000(&\u0001\u0000\u0000\u0000)+\u0001\u0000"+
		"\u0000\u0000*(\u0001\u0000\u0000\u0000+,\u0005\n\u0000\u0000,-\u0001\u0000"+
		"\u0000\u0000-.\u0006\u0001\u0001\u0000.\u0006\u0001\u0000\u0000\u0000"+
		"/1\u0007\u0000\u0000\u00000/\u0001\u0000\u0000\u000012\u0001\u0000\u0000"+
		"\u000020\u0001\u0000\u0000\u000023\u0001\u0000\u0000\u000034\u0001\u0000"+
		"\u0000\u000045\u0006\u0002\u0001\u00005\b\u0001\u0000\u0000\u000067\u0005"+
		"=\u0000\u000078\u0001\u0000\u0000\u000089\u0006\u0003\u0002\u00009\n\u0001"+
		"\u0000\u0000\u0000:<\u0007\u0001\u0000\u0000;:\u0001\u0000\u0000\u0000"+
		"<=\u0001\u0000\u0000\u0000=;\u0001\u0000\u0000\u0000=>\u0001\u0000\u0000"+
		"\u0000>J\u0001\u0000\u0000\u0000?A\u0007\u0002\u0000\u0000@?\u0001\u0000"+
		"\u0000\u0000AB\u0001\u0000\u0000\u0000B@\u0001\u0000\u0000\u0000BC\u0001"+
		"\u0000\u0000\u0000CJ\u0001\u0000\u0000\u0000DF\u0007\u0003\u0000\u0000"+
		"ED\u0001\u0000\u0000\u0000FG\u0001\u0000\u0000\u0000GE\u0001\u0000\u0000"+
		"\u0000GH\u0001\u0000\u0000\u0000HJ\u0001\u0000\u0000\u0000I;\u0001\u0000"+
		"\u0000\u0000I@\u0001\u0000\u0000\u0000IE\u0001\u0000\u0000\u0000JK\u0001"+
		"\u0000\u0000\u0000KL\u0006\u0004\u0001\u0000L\f\u0001\u0000\u0000\u0000"+
		"MQ\u0005\"\u0000\u0000NP\t\u0000\u0000\u0000ON\u0001\u0000\u0000\u0000"+
		"PS\u0001\u0000\u0000\u0000QR\u0001\u0000\u0000\u0000QO\u0001\u0000\u0000"+
		"\u0000RT\u0001\u0000\u0000\u0000SQ\u0001\u0000\u0000\u0000TU\u0005\n\u0000"+
		"\u0000UV\u0001\u0000\u0000\u0000VW\u0006\u0005\u0001\u0000W\u000e\u0001"+
		"\u0000\u0000\u0000Xb\u0005[\u0000\u0000YZ\u0005E\u0000\u0000Z[\u0005N"+
		"\u0000\u0000[c\u0005D\u0000\u0000\\]\u0005E\u0000\u0000]^\u0005n\u0000"+
		"\u0000^c\u0005d\u0000\u0000_`\u0005e\u0000\u0000`a\u0005n\u0000\u0000"+
		"ac\u0005d\u0000\u0000bY\u0001\u0000\u0000\u0000b\\\u0001\u0000\u0000\u0000"+
		"b_\u0001\u0000\u0000\u0000ck\u0001\u0000\u0000\u0000dh\u0005-\u0000\u0000"+
		"eg\t\u0000\u0000\u0000fe\u0001\u0000\u0000\u0000gj\u0001\u0000\u0000\u0000"+
		"hi\u0001\u0000\u0000\u0000hf\u0001\u0000\u0000\u0000il\u0001\u0000\u0000"+
		"\u0000jh\u0001\u0000\u0000\u0000kd\u0001\u0000\u0000\u0000kl\u0001\u0000"+
		"\u0000\u0000lm\u0001\u0000\u0000\u0000mn\u0005]\u0000\u0000no\u0001\u0000"+
		"\u0000\u0000op\u0006\u0006\u0003\u0000p\u0010\u0001\u0000\u0000\u0000"+
		"qr\u0005L\u0000\u0000rs\u0005a\u0000\u0000st\u0005b\u0000\u0000tu\u0005"+
		"e\u0000\u0000uv\u0005l\u0000\u0000vw\u0001\u0000\u0000\u0000wx\u0007\u0004"+
		"\u0000\u0000x\u0012\u0001\u0000\u0000\u0000y{\u0007\u0005\u0000\u0000"+
		"zy\u0001\u0000\u0000\u0000{|\u0001\u0000\u0000\u0000|z\u0001\u0000\u0000"+
		"\u0000|}\u0001\u0000\u0000\u0000}\u0014\u0001\u0000\u0000\u0000~\u0080"+
		"\u0007\u0006\u0000\u0000\u007f~\u0001\u0000\u0000\u0000\u0080\u0081\u0001"+
		"\u0000\u0000\u0000\u0081\u007f\u0001\u0000\u0000\u0000\u0081\u0082\u0001"+
		"\u0000\u0000\u0000\u0082\u0016\u0001\u0000\u0000\u0000\u0083\u0085\b\u0001"+
		"\u0000\u0000\u0084\u0083\u0001\u0000\u0000\u0000\u0085\u0088\u0001\u0000"+
		"\u0000\u0000\u0086\u0084\u0001\u0000\u0000\u0000\u0086\u0087\u0001\u0000"+
		"\u0000\u0000\u0087\u008c\u0001\u0000\u0000\u0000\u0088\u0086\u0001\u0000"+
		"\u0000\u0000\u0089\u008a\u0005\r\u0000\u0000\u008a\u008d\u0005\n\u0000"+
		"\u0000\u008b\u008d\u0007\u0001\u0000\u0000\u008c\u0089\u0001\u0000\u0000"+
		"\u0000\u008c\u008b\u0001\u0000\u0000\u0000\u008d\u008e\u0001\u0000\u0000"+
		"\u0000\u008e\u008f\u0006\n\u0003\u0000\u008f\u0018\u0001\u0000\u0000\u0000"+
		"\u0012\u0000\u0001\u0002\u001d(2=BGIQbhk|\u0081\u0086\u008c\u0004\u0005"+
		"\u0001\u0000\u0006\u0000\u0000\u0005\u0002\u0000\u0004\u0000\u0000";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}