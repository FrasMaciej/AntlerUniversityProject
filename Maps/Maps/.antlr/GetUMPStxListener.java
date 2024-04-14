// Generated from x:/source/Antlr/FrasMaciej/AntlerUniversityProject/Maps/Maps/GetUMPStx.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link GetUMPStx}.
 */
public interface GetUMPStxListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link GetUMPStx#file}.
	 * @param ctx the parse tree
	 */
	void enterFile(GetUMPStx.FileContext ctx);
	/**
	 * Exit a parse tree produced by {@link GetUMPStx#file}.
	 * @param ctx the parse tree
	 */
	void exitFile(GetUMPStx.FileContext ctx);
	/**
	 * Enter a parse tree produced by {@link GetUMPStx#section}.
	 * @param ctx the parse tree
	 */
	void enterSection(GetUMPStx.SectionContext ctx);
	/**
	 * Exit a parse tree produced by {@link GetUMPStx#section}.
	 * @param ctx the parse tree
	 */
	void exitSection(GetUMPStx.SectionContext ctx);
	/**
	 * Enter a parse tree produced by {@link GetUMPStx#idxEqId}.
	 * @param ctx the parse tree
	 */
	void enterIdxEqId(GetUMPStx.IdxEqIdContext ctx);
	/**
	 * Exit a parse tree produced by {@link GetUMPStx#idxEqId}.
	 * @param ctx the parse tree
	 */
	void exitIdxEqId(GetUMPStx.IdxEqIdContext ctx);
	/**
	 * Enter a parse tree produced by the {@code simpleEq}
	 * labeled alternative in {@link GetUMPStx#kvEq}.
	 * @param ctx the parse tree
	 */
	void enterSimpleEq(GetUMPStx.SimpleEqContext ctx);
	/**
	 * Exit a parse tree produced by the {@code simpleEq}
	 * labeled alternative in {@link GetUMPStx#kvEq}.
	 * @param ctx the parse tree
	 */
	void exitSimpleEq(GetUMPStx.SimpleEqContext ctx);
	/**
	 * Enter a parse tree produced by the {@code idxEq}
	 * labeled alternative in {@link GetUMPStx#kvEq}.
	 * @param ctx the parse tree
	 */
	void enterIdxEq(GetUMPStx.IdxEqContext ctx);
	/**
	 * Exit a parse tree produced by the {@code idxEq}
	 * labeled alternative in {@link GetUMPStx#kvEq}.
	 * @param ctx the parse tree
	 */
	void exitIdxEq(GetUMPStx.IdxEqContext ctx);
}