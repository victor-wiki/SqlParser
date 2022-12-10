using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SqliteParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface ISqliteParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParse([NotNull] SqliteParser.ParseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParse([NotNull] SqliteParser.ParseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.sql_stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_stmt_list([NotNull] SqliteParser.Sql_stmt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.sql_stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_stmt_list([NotNull] SqliteParser.Sql_stmt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.sql_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_stmt([NotNull] SqliteParser.Sql_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.sql_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_stmt([NotNull] SqliteParser.Sql_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.alter_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table_stmt([NotNull] SqliteParser.Alter_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.alter_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table_stmt([NotNull] SqliteParser.Alter_table_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.analyze_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnalyze_stmt([NotNull] SqliteParser.Analyze_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.analyze_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnalyze_stmt([NotNull] SqliteParser.Analyze_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.attach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttach_stmt([NotNull] SqliteParser.Attach_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.attach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttach_stmt([NotNull] SqliteParser.Attach_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.begin_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBegin_stmt([NotNull] SqliteParser.Begin_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.begin_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBegin_stmt([NotNull] SqliteParser.Begin_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.commit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommit_stmt([NotNull] SqliteParser.Commit_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.commit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommit_stmt([NotNull] SqliteParser.Commit_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.rollback_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRollback_stmt([NotNull] SqliteParser.Rollback_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.rollback_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRollback_stmt([NotNull] SqliteParser.Rollback_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.savepoint_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSavepoint_stmt([NotNull] SqliteParser.Savepoint_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.savepoint_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSavepoint_stmt([NotNull] SqliteParser.Savepoint_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.release_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelease_stmt([NotNull] SqliteParser.Release_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.release_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelease_stmt([NotNull] SqliteParser.Release_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.create_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_index_stmt([NotNull] SqliteParser.Create_index_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.create_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_index_stmt([NotNull] SqliteParser.Create_index_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.indexed_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexed_column([NotNull] SqliteParser.Indexed_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.indexed_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexed_column([NotNull] SqliteParser.Indexed_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.create_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_table_stmt([NotNull] SqliteParser.Create_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.create_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_table_stmt([NotNull] SqliteParser.Create_table_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.column_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_def([NotNull] SqliteParser.Column_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.column_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_def([NotNull] SqliteParser.Column_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_name([NotNull] SqliteParser.Type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_name([NotNull] SqliteParser.Type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.column_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_constraint([NotNull] SqliteParser.Column_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.column_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_constraint([NotNull] SqliteParser.Column_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSigned_number([NotNull] SqliteParser.Signed_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSigned_number([NotNull] SqliteParser.Signed_numberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_constraint([NotNull] SqliteParser.Table_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_constraint([NotNull] SqliteParser.Table_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.foreign_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeign_key_clause([NotNull] SqliteParser.Foreign_key_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.foreign_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeign_key_clause([NotNull] SqliteParser.Foreign_key_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.conflict_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConflict_clause([NotNull] SqliteParser.Conflict_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.conflict_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConflict_clause([NotNull] SqliteParser.Conflict_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.create_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_trigger_stmt([NotNull] SqliteParser.Create_trigger_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.create_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_trigger_stmt([NotNull] SqliteParser.Create_trigger_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.create_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_view_stmt([NotNull] SqliteParser.Create_view_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.create_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_view_stmt([NotNull] SqliteParser.Create_view_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.create_virtual_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_virtual_table_stmt([NotNull] SqliteParser.Create_virtual_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.create_virtual_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_virtual_table_stmt([NotNull] SqliteParser.Create_virtual_table_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWith_clause([NotNull] SqliteParser.With_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWith_clause([NotNull] SqliteParser.With_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.cte_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCte_table_name([NotNull] SqliteParser.Cte_table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.cte_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCte_table_name([NotNull] SqliteParser.Cte_table_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.recursive_cte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRecursive_cte([NotNull] SqliteParser.Recursive_cteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.recursive_cte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRecursive_cte([NotNull] SqliteParser.Recursive_cteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.common_table_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommon_table_expression([NotNull] SqliteParser.Common_table_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.common_table_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommon_table_expression([NotNull] SqliteParser.Common_table_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.delete_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete_stmt([NotNull] SqliteParser.Delete_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.delete_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete_stmt([NotNull] SqliteParser.Delete_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.delete_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete_stmt_limited([NotNull] SqliteParser.Delete_stmt_limitedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.delete_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete_stmt_limited([NotNull] SqliteParser.Delete_stmt_limitedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.detach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDetach_stmt([NotNull] SqliteParser.Detach_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.detach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDetach_stmt([NotNull] SqliteParser.Detach_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.drop_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_stmt([NotNull] SqliteParser.Drop_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.drop_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_stmt([NotNull] SqliteParser.Drop_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] SqliteParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] SqliteParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.raise_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRaise_function([NotNull] SqliteParser.Raise_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.raise_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRaise_function([NotNull] SqliteParser.Raise_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.literal_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral_value([NotNull] SqliteParser.Literal_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.literal_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral_value([NotNull] SqliteParser.Literal_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.insert_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_stmt([NotNull] SqliteParser.Insert_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.insert_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_stmt([NotNull] SqliteParser.Insert_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.returning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturning_clause([NotNull] SqliteParser.Returning_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.returning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturning_clause([NotNull] SqliteParser.Returning_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.upsert_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpsert_clause([NotNull] SqliteParser.Upsert_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.upsert_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpsert_clause([NotNull] SqliteParser.Upsert_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.pragma_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_stmt([NotNull] SqliteParser.Pragma_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.pragma_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_stmt([NotNull] SqliteParser.Pragma_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.pragma_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_value([NotNull] SqliteParser.Pragma_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.pragma_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_value([NotNull] SqliteParser.Pragma_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.reindex_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReindex_stmt([NotNull] SqliteParser.Reindex_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.reindex_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReindex_stmt([NotNull] SqliteParser.Reindex_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_stmt([NotNull] SqliteParser.Select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_stmt([NotNull] SqliteParser.Select_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_clause([NotNull] SqliteParser.Join_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_clause([NotNull] SqliteParser.Join_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.select_core"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_core([NotNull] SqliteParser.Select_coreContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.select_core"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_core([NotNull] SqliteParser.Select_coreContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.factored_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactored_select_stmt([NotNull] SqliteParser.Factored_select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.factored_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactored_select_stmt([NotNull] SqliteParser.Factored_select_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.simple_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_select_stmt([NotNull] SqliteParser.Simple_select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.simple_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_select_stmt([NotNull] SqliteParser.Simple_select_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.compound_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_select_stmt([NotNull] SqliteParser.Compound_select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.compound_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_select_stmt([NotNull] SqliteParser.Compound_select_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_or_subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_or_subquery([NotNull] SqliteParser.Table_or_subqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_or_subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_or_subquery([NotNull] SqliteParser.Table_or_subqueryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.result_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResult_column([NotNull] SqliteParser.Result_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.result_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResult_column([NotNull] SqliteParser.Result_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.join_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_operator([NotNull] SqliteParser.Join_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.join_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_operator([NotNull] SqliteParser.Join_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.join_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_constraint([NotNull] SqliteParser.Join_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.join_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_constraint([NotNull] SqliteParser.Join_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.compound_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_operator([NotNull] SqliteParser.Compound_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.compound_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_operator([NotNull] SqliteParser.Compound_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.update_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_stmt([NotNull] SqliteParser.Update_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.update_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_stmt([NotNull] SqliteParser.Update_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_name_list([NotNull] SqliteParser.Column_name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_name_list([NotNull] SqliteParser.Column_name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.update_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_stmt_limited([NotNull] SqliteParser.Update_stmt_limitedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.update_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_stmt_limited([NotNull] SqliteParser.Update_stmt_limitedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.qualified_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualified_table_name([NotNull] SqliteParser.Qualified_table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.qualified_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualified_table_name([NotNull] SqliteParser.Qualified_table_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.vacuum_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVacuum_stmt([NotNull] SqliteParser.Vacuum_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.vacuum_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVacuum_stmt([NotNull] SqliteParser.Vacuum_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.filter_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilter_clause([NotNull] SqliteParser.Filter_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.filter_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilter_clause([NotNull] SqliteParser.Filter_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.window_defn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_defn([NotNull] SqliteParser.Window_defnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.window_defn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_defn([NotNull] SqliteParser.Window_defnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOver_clause([NotNull] SqliteParser.Over_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOver_clause([NotNull] SqliteParser.Over_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.frame_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_spec([NotNull] SqliteParser.Frame_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.frame_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_spec([NotNull] SqliteParser.Frame_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.frame_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_clause([NotNull] SqliteParser.Frame_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.frame_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_clause([NotNull] SqliteParser.Frame_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.simple_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_function_invocation([NotNull] SqliteParser.Simple_function_invocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.simple_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_function_invocation([NotNull] SqliteParser.Simple_function_invocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.aggregate_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggregate_function_invocation([NotNull] SqliteParser.Aggregate_function_invocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.aggregate_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggregate_function_invocation([NotNull] SqliteParser.Aggregate_function_invocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.window_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_function_invocation([NotNull] SqliteParser.Window_function_invocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.window_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_function_invocation([NotNull] SqliteParser.Window_function_invocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.common_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommon_table_stmt([NotNull] SqliteParser.Common_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.common_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommon_table_stmt([NotNull] SqliteParser.Common_table_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.order_by_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrder_by_stmt([NotNull] SqliteParser.Order_by_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.order_by_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrder_by_stmt([NotNull] SqliteParser.Order_by_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.limit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimit_stmt([NotNull] SqliteParser.Limit_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.limit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimit_stmt([NotNull] SqliteParser.Limit_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.ordering_term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrdering_term([NotNull] SqliteParser.Ordering_termContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.ordering_term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrdering_term([NotNull] SqliteParser.Ordering_termContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsc_desc([NotNull] SqliteParser.Asc_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsc_desc([NotNull] SqliteParser.Asc_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.frame_left"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_left([NotNull] SqliteParser.Frame_leftContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.frame_left"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_left([NotNull] SqliteParser.Frame_leftContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.frame_right"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_right([NotNull] SqliteParser.Frame_rightContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.frame_right"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_right([NotNull] SqliteParser.Frame_rightContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.frame_single"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_single([NotNull] SqliteParser.Frame_singleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.frame_single"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_single([NotNull] SqliteParser.Frame_singleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.window_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_function([NotNull] SqliteParser.Window_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.window_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_function([NotNull] SqliteParser.Window_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.offset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOffset([NotNull] SqliteParser.OffsetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.offset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOffset([NotNull] SqliteParser.OffsetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.default_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefault_value([NotNull] SqliteParser.Default_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.default_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefault_value([NotNull] SqliteParser.Default_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.partition_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_by([NotNull] SqliteParser.Partition_byContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.partition_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_by([NotNull] SqliteParser.Partition_byContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.order_by_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrder_by_expr([NotNull] SqliteParser.Order_by_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.order_by_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrder_by_expr([NotNull] SqliteParser.Order_by_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.order_by_expr_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrder_by_expr_asc_desc([NotNull] SqliteParser.Order_by_expr_asc_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.order_by_expr_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrder_by_expr_asc_desc([NotNull] SqliteParser.Order_by_expr_asc_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.expr_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr_asc_desc([NotNull] SqliteParser.Expr_asc_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.expr_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr_asc_desc([NotNull] SqliteParser.Expr_asc_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.initial_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitial_select([NotNull] SqliteParser.Initial_selectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.initial_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitial_select([NotNull] SqliteParser.Initial_selectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.recursive_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRecursive_select([NotNull] SqliteParser.Recursive_selectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.recursive_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRecursive_select([NotNull] SqliteParser.Recursive_selectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.unary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_operator([NotNull] SqliteParser.Unary_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.unary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_operator([NotNull] SqliteParser.Unary_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.error_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterError_message([NotNull] SqliteParser.Error_messageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.error_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitError_message([NotNull] SqliteParser.Error_messageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.module_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule_argument([NotNull] SqliteParser.Module_argumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.module_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule_argument([NotNull] SqliteParser.Module_argumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_alias([NotNull] SqliteParser.Column_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_alias([NotNull] SqliteParser.Column_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyword([NotNull] SqliteParser.KeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyword([NotNull] SqliteParser.KeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] SqliteParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] SqliteParser.NameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_name([NotNull] SqliteParser.Function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_name([NotNull] SqliteParser.Function_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.schema_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchema_name([NotNull] SqliteParser.Schema_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.schema_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchema_name([NotNull] SqliteParser.Schema_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_name([NotNull] SqliteParser.Table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_name([NotNull] SqliteParser.Table_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_or_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_or_index_name([NotNull] SqliteParser.Table_or_index_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_or_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_or_index_name([NotNull] SqliteParser.Table_or_index_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_name([NotNull] SqliteParser.Column_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_name([NotNull] SqliteParser.Column_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.collation_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollation_name([NotNull] SqliteParser.Collation_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.collation_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollation_name([NotNull] SqliteParser.Collation_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.foreign_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeign_table([NotNull] SqliteParser.Foreign_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.foreign_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeign_table([NotNull] SqliteParser.Foreign_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_name([NotNull] SqliteParser.Index_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_name([NotNull] SqliteParser.Index_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.trigger_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrigger_name([NotNull] SqliteParser.Trigger_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.trigger_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrigger_name([NotNull] SqliteParser.Trigger_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.view_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterView_name([NotNull] SqliteParser.View_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.view_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitView_name([NotNull] SqliteParser.View_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.module_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule_name([NotNull] SqliteParser.Module_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.module_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule_name([NotNull] SqliteParser.Module_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.pragma_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_name([NotNull] SqliteParser.Pragma_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.pragma_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_name([NotNull] SqliteParser.Pragma_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.savepoint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSavepoint_name([NotNull] SqliteParser.Savepoint_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.savepoint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSavepoint_name([NotNull] SqliteParser.Savepoint_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_alias([NotNull] SqliteParser.Table_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_alias([NotNull] SqliteParser.Table_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.transaction_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransaction_name([NotNull] SqliteParser.Transaction_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.transaction_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransaction_name([NotNull] SqliteParser.Transaction_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_name([NotNull] SqliteParser.Window_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_name([NotNull] SqliteParser.Window_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlias([NotNull] SqliteParser.AliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlias([NotNull] SqliteParser.AliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.filename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilename([NotNull] SqliteParser.FilenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.filename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilename([NotNull] SqliteParser.FilenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.base_window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBase_window_name([NotNull] SqliteParser.Base_window_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.base_window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBase_window_name([NotNull] SqliteParser.Base_window_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.simple_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_func([NotNull] SqliteParser.Simple_funcContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.simple_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_func([NotNull] SqliteParser.Simple_funcContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.aggregate_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggregate_func([NotNull] SqliteParser.Aggregate_funcContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.aggregate_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggregate_func([NotNull] SqliteParser.Aggregate_funcContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.table_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_function_name([NotNull] SqliteParser.Table_function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.table_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_function_name([NotNull] SqliteParser.Table_function_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SqliteParser.any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAny_name([NotNull] SqliteParser.Any_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SqliteParser.any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAny_name([NotNull] SqliteParser.Any_nameContext context);
}
