using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISqliteParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class SqliteParserBaseListener : ISqliteParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.parse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParse([NotNull] SqliteParser.ParseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.parse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParse([NotNull] SqliteParser.ParseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.sql_stmt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_stmt_list([NotNull] SqliteParser.Sql_stmt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.sql_stmt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_stmt_list([NotNull] SqliteParser.Sql_stmt_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.sql_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_stmt([NotNull] SqliteParser.Sql_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.sql_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_stmt([NotNull] SqliteParser.Sql_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.alter_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table_stmt([NotNull] SqliteParser.Alter_table_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.alter_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table_stmt([NotNull] SqliteParser.Alter_table_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.analyze_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnalyze_stmt([NotNull] SqliteParser.Analyze_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.analyze_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnalyze_stmt([NotNull] SqliteParser.Analyze_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.attach_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttach_stmt([NotNull] SqliteParser.Attach_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.attach_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttach_stmt([NotNull] SqliteParser.Attach_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.begin_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBegin_stmt([NotNull] SqliteParser.Begin_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.begin_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBegin_stmt([NotNull] SqliteParser.Begin_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.commit_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommit_stmt([NotNull] SqliteParser.Commit_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.commit_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommit_stmt([NotNull] SqliteParser.Commit_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.rollback_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRollback_stmt([NotNull] SqliteParser.Rollback_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.rollback_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRollback_stmt([NotNull] SqliteParser.Rollback_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.savepoint_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSavepoint_stmt([NotNull] SqliteParser.Savepoint_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.savepoint_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSavepoint_stmt([NotNull] SqliteParser.Savepoint_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.release_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelease_stmt([NotNull] SqliteParser.Release_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.release_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelease_stmt([NotNull] SqliteParser.Release_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.create_index_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_index_stmt([NotNull] SqliteParser.Create_index_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.create_index_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_index_stmt([NotNull] SqliteParser.Create_index_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.indexed_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexed_column([NotNull] SqliteParser.Indexed_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.indexed_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexed_column([NotNull] SqliteParser.Indexed_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.create_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_table_stmt([NotNull] SqliteParser.Create_table_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.create_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_table_stmt([NotNull] SqliteParser.Create_table_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.column_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_def([NotNull] SqliteParser.Column_defContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.column_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_def([NotNull] SqliteParser.Column_defContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_name([NotNull] SqliteParser.Type_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_name([NotNull] SqliteParser.Type_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.column_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_constraint([NotNull] SqliteParser.Column_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.column_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_constraint([NotNull] SqliteParser.Column_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.signed_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSigned_number([NotNull] SqliteParser.Signed_numberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.signed_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSigned_number([NotNull] SqliteParser.Signed_numberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_constraint([NotNull] SqliteParser.Table_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_constraint([NotNull] SqliteParser.Table_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.foreign_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeign_key_clause([NotNull] SqliteParser.Foreign_key_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.foreign_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeign_key_clause([NotNull] SqliteParser.Foreign_key_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.conflict_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConflict_clause([NotNull] SqliteParser.Conflict_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.conflict_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConflict_clause([NotNull] SqliteParser.Conflict_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.create_trigger_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_trigger_stmt([NotNull] SqliteParser.Create_trigger_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.create_trigger_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_trigger_stmt([NotNull] SqliteParser.Create_trigger_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.create_view_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_view_stmt([NotNull] SqliteParser.Create_view_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.create_view_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_view_stmt([NotNull] SqliteParser.Create_view_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.create_virtual_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_virtual_table_stmt([NotNull] SqliteParser.Create_virtual_table_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.create_virtual_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_virtual_table_stmt([NotNull] SqliteParser.Create_virtual_table_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.with_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWith_clause([NotNull] SqliteParser.With_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.with_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWith_clause([NotNull] SqliteParser.With_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.cte_table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCte_table_name([NotNull] SqliteParser.Cte_table_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.cte_table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCte_table_name([NotNull] SqliteParser.Cte_table_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.recursive_cte"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRecursive_cte([NotNull] SqliteParser.Recursive_cteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.recursive_cte"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRecursive_cte([NotNull] SqliteParser.Recursive_cteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.common_table_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommon_table_expression([NotNull] SqliteParser.Common_table_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.common_table_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommon_table_expression([NotNull] SqliteParser.Common_table_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.delete_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDelete_stmt([NotNull] SqliteParser.Delete_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.delete_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDelete_stmt([NotNull] SqliteParser.Delete_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.delete_stmt_limited"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDelete_stmt_limited([NotNull] SqliteParser.Delete_stmt_limitedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.delete_stmt_limited"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDelete_stmt_limited([NotNull] SqliteParser.Delete_stmt_limitedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.detach_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDetach_stmt([NotNull] SqliteParser.Detach_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.detach_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDetach_stmt([NotNull] SqliteParser.Detach_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.drop_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_stmt([NotNull] SqliteParser.Drop_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.drop_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_stmt([NotNull] SqliteParser.Drop_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] SqliteParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] SqliteParser.ExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.raise_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRaise_function([NotNull] SqliteParser.Raise_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.raise_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRaise_function([NotNull] SqliteParser.Raise_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.literal_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral_value([NotNull] SqliteParser.Literal_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.literal_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral_value([NotNull] SqliteParser.Literal_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.insert_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_stmt([NotNull] SqliteParser.Insert_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.insert_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_stmt([NotNull] SqliteParser.Insert_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.returning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturning_clause([NotNull] SqliteParser.Returning_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.returning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturning_clause([NotNull] SqliteParser.Returning_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.upsert_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpsert_clause([NotNull] SqliteParser.Upsert_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.upsert_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpsert_clause([NotNull] SqliteParser.Upsert_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.pragma_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPragma_stmt([NotNull] SqliteParser.Pragma_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.pragma_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPragma_stmt([NotNull] SqliteParser.Pragma_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.pragma_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPragma_value([NotNull] SqliteParser.Pragma_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.pragma_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPragma_value([NotNull] SqliteParser.Pragma_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.reindex_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReindex_stmt([NotNull] SqliteParser.Reindex_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.reindex_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReindex_stmt([NotNull] SqliteParser.Reindex_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_stmt([NotNull] SqliteParser.Select_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_stmt([NotNull] SqliteParser.Select_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.join_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_clause([NotNull] SqliteParser.Join_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.join_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_clause([NotNull] SqliteParser.Join_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.select_core"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_core([NotNull] SqliteParser.Select_coreContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.select_core"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_core([NotNull] SqliteParser.Select_coreContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.factored_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactored_select_stmt([NotNull] SqliteParser.Factored_select_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.factored_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactored_select_stmt([NotNull] SqliteParser.Factored_select_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.simple_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_select_stmt([NotNull] SqliteParser.Simple_select_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.simple_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_select_stmt([NotNull] SqliteParser.Simple_select_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.compound_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompound_select_stmt([NotNull] SqliteParser.Compound_select_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.compound_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompound_select_stmt([NotNull] SqliteParser.Compound_select_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_or_subquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_or_subquery([NotNull] SqliteParser.Table_or_subqueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_or_subquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_or_subquery([NotNull] SqliteParser.Table_or_subqueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.result_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResult_column([NotNull] SqliteParser.Result_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.result_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResult_column([NotNull] SqliteParser.Result_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.join_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_operator([NotNull] SqliteParser.Join_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.join_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_operator([NotNull] SqliteParser.Join_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.join_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_constraint([NotNull] SqliteParser.Join_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.join_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_constraint([NotNull] SqliteParser.Join_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.compound_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompound_operator([NotNull] SqliteParser.Compound_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.compound_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompound_operator([NotNull] SqliteParser.Compound_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.update_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_stmt([NotNull] SqliteParser.Update_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.update_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_stmt([NotNull] SqliteParser.Update_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.column_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_name_list([NotNull] SqliteParser.Column_name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.column_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_name_list([NotNull] SqliteParser.Column_name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.update_stmt_limited"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_stmt_limited([NotNull] SqliteParser.Update_stmt_limitedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.update_stmt_limited"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_stmt_limited([NotNull] SqliteParser.Update_stmt_limitedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.qualified_table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualified_table_name([NotNull] SqliteParser.Qualified_table_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.qualified_table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualified_table_name([NotNull] SqliteParser.Qualified_table_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.vacuum_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVacuum_stmt([NotNull] SqliteParser.Vacuum_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.vacuum_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVacuum_stmt([NotNull] SqliteParser.Vacuum_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.filter_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilter_clause([NotNull] SqliteParser.Filter_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.filter_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilter_clause([NotNull] SqliteParser.Filter_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.window_defn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_defn([NotNull] SqliteParser.Window_defnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.window_defn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_defn([NotNull] SqliteParser.Window_defnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.over_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOver_clause([NotNull] SqliteParser.Over_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.over_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOver_clause([NotNull] SqliteParser.Over_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.frame_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_spec([NotNull] SqliteParser.Frame_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.frame_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_spec([NotNull] SqliteParser.Frame_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.frame_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_clause([NotNull] SqliteParser.Frame_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.frame_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_clause([NotNull] SqliteParser.Frame_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.simple_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_function_invocation([NotNull] SqliteParser.Simple_function_invocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.simple_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_function_invocation([NotNull] SqliteParser.Simple_function_invocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.aggregate_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggregate_function_invocation([NotNull] SqliteParser.Aggregate_function_invocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.aggregate_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggregate_function_invocation([NotNull] SqliteParser.Aggregate_function_invocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.window_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_function_invocation([NotNull] SqliteParser.Window_function_invocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.window_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_function_invocation([NotNull] SqliteParser.Window_function_invocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.common_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommon_table_stmt([NotNull] SqliteParser.Common_table_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.common_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommon_table_stmt([NotNull] SqliteParser.Common_table_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.order_by_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrder_by_stmt([NotNull] SqliteParser.Order_by_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.order_by_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrder_by_stmt([NotNull] SqliteParser.Order_by_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.limit_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLimit_stmt([NotNull] SqliteParser.Limit_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.limit_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLimit_stmt([NotNull] SqliteParser.Limit_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.ordering_term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrdering_term([NotNull] SqliteParser.Ordering_termContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.ordering_term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrdering_term([NotNull] SqliteParser.Ordering_termContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsc_desc([NotNull] SqliteParser.Asc_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsc_desc([NotNull] SqliteParser.Asc_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.frame_left"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_left([NotNull] SqliteParser.Frame_leftContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.frame_left"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_left([NotNull] SqliteParser.Frame_leftContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.frame_right"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_right([NotNull] SqliteParser.Frame_rightContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.frame_right"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_right([NotNull] SqliteParser.Frame_rightContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.frame_single"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_single([NotNull] SqliteParser.Frame_singleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.frame_single"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_single([NotNull] SqliteParser.Frame_singleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.window_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_function([NotNull] SqliteParser.Window_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.window_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_function([NotNull] SqliteParser.Window_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.offset"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOffset([NotNull] SqliteParser.OffsetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.offset"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOffset([NotNull] SqliteParser.OffsetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.default_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefault_value([NotNull] SqliteParser.Default_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.default_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefault_value([NotNull] SqliteParser.Default_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.partition_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_by([NotNull] SqliteParser.Partition_byContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.partition_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_by([NotNull] SqliteParser.Partition_byContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.order_by_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrder_by_expr([NotNull] SqliteParser.Order_by_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.order_by_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrder_by_expr([NotNull] SqliteParser.Order_by_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.order_by_expr_asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrder_by_expr_asc_desc([NotNull] SqliteParser.Order_by_expr_asc_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.order_by_expr_asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrder_by_expr_asc_desc([NotNull] SqliteParser.Order_by_expr_asc_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.expr_asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr_asc_desc([NotNull] SqliteParser.Expr_asc_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.expr_asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr_asc_desc([NotNull] SqliteParser.Expr_asc_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.initial_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitial_select([NotNull] SqliteParser.Initial_selectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.initial_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitial_select([NotNull] SqliteParser.Initial_selectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.recursive_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRecursive_select([NotNull] SqliteParser.Recursive_selectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.recursive_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRecursive_select([NotNull] SqliteParser.Recursive_selectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.unary_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_operator([NotNull] SqliteParser.Unary_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.unary_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_operator([NotNull] SqliteParser.Unary_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.error_message"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterError_message([NotNull] SqliteParser.Error_messageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.error_message"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitError_message([NotNull] SqliteParser.Error_messageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.module_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModule_argument([NotNull] SqliteParser.Module_argumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.module_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModule_argument([NotNull] SqliteParser.Module_argumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.column_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_alias([NotNull] SqliteParser.Column_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.column_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_alias([NotNull] SqliteParser.Column_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyword([NotNull] SqliteParser.KeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyword([NotNull] SqliteParser.KeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterName([NotNull] SqliteParser.NameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitName([NotNull] SqliteParser.NameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_name([NotNull] SqliteParser.Function_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_name([NotNull] SqliteParser.Function_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.schema_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchema_name([NotNull] SqliteParser.Schema_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.schema_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchema_name([NotNull] SqliteParser.Schema_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_name([NotNull] SqliteParser.Table_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_name([NotNull] SqliteParser.Table_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_or_index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_or_index_name([NotNull] SqliteParser.Table_or_index_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_or_index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_or_index_name([NotNull] SqliteParser.Table_or_index_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_name([NotNull] SqliteParser.Column_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_name([NotNull] SqliteParser.Column_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.collation_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollation_name([NotNull] SqliteParser.Collation_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.collation_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollation_name([NotNull] SqliteParser.Collation_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.foreign_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeign_table([NotNull] SqliteParser.Foreign_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.foreign_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeign_table([NotNull] SqliteParser.Foreign_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_name([NotNull] SqliteParser.Index_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_name([NotNull] SqliteParser.Index_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.trigger_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrigger_name([NotNull] SqliteParser.Trigger_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.trigger_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrigger_name([NotNull] SqliteParser.Trigger_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.view_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterView_name([NotNull] SqliteParser.View_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.view_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitView_name([NotNull] SqliteParser.View_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.module_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModule_name([NotNull] SqliteParser.Module_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.module_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModule_name([NotNull] SqliteParser.Module_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.pragma_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPragma_name([NotNull] SqliteParser.Pragma_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.pragma_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPragma_name([NotNull] SqliteParser.Pragma_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.savepoint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSavepoint_name([NotNull] SqliteParser.Savepoint_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.savepoint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSavepoint_name([NotNull] SqliteParser.Savepoint_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_alias([NotNull] SqliteParser.Table_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_alias([NotNull] SqliteParser.Table_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.transaction_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransaction_name([NotNull] SqliteParser.Transaction_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.transaction_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransaction_name([NotNull] SqliteParser.Transaction_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.window_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_name([NotNull] SqliteParser.Window_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.window_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_name([NotNull] SqliteParser.Window_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlias([NotNull] SqliteParser.AliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlias([NotNull] SqliteParser.AliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.filename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilename([NotNull] SqliteParser.FilenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.filename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilename([NotNull] SqliteParser.FilenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.base_window_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBase_window_name([NotNull] SqliteParser.Base_window_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.base_window_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBase_window_name([NotNull] SqliteParser.Base_window_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.simple_func"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_func([NotNull] SqliteParser.Simple_funcContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.simple_func"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_func([NotNull] SqliteParser.Simple_funcContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.aggregate_func"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggregate_func([NotNull] SqliteParser.Aggregate_funcContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.aggregate_func"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggregate_func([NotNull] SqliteParser.Aggregate_funcContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_function_name([NotNull] SqliteParser.Table_function_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_function_name([NotNull] SqliteParser.Table_function_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.any_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAny_name([NotNull] SqliteParser.Any_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.any_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAny_name([NotNull] SqliteParser.Any_nameContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
