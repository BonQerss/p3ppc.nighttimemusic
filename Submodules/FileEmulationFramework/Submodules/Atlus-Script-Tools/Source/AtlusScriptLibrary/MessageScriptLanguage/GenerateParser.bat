cd "..\..\packages\Antlr4.CodeGenerator.4.6.4\tools"
ikvm.exe -jar antlr4-csharp-4.6.4-complete.jar -lib "..\..\..\AtlusScriptLibrary\MessageScriptLanguage\Compiler\Parser" -listener -visitor -package AtlusScriptLibrary.FlowScriptLanguage.Compiler.Parser -Dlanguage=CSharp_v4_5 "..\..\..\AtlusScriptLibrary\MessageScriptLanguage\Compiler\Parser\MessageScriptParser.g4"