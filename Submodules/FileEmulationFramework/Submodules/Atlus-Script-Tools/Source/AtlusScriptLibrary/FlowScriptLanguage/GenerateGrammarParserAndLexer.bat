cd "..\..\packages\Antlr4.CodeGenerator.4.6.4\tools"
ikvm.exe -jar antlr4-csharp-4.6.4-complete.jar -lib "..\..\..\AtlusScriptLibrary\FlowScriptLanguage\Compiler\Parser\Grammar" -listener -visitor -package AtlusScriptLibrary.FlowScriptLanguage.Compiler.Parser.Grammar -Dlanguage=CSharp_v4_5 "..\..\..\AtlusScriptLibrary\FlowScriptLanguage\Compiler\Parser\Grammar\FlowScript.g4"
pause