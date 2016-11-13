﻿namespace TSBridge.Ast
{
    public enum SyntaxKind
    {
        Unknown = 0,
        EndOfFileToken = 1,
        SingleLineCommentTrivia = 2,
        MultiLineCommentTrivia = 3,
        NewLineTrivia = 4,
        WhitespaceTrivia = 5,
        ShebangTrivia = 6,
        ConflictMarkerTrivia = 7,
        NumericLiteral = 8,
        StringLiteral = 9,
        JsxText = 10,
        RegularExpressionLiteral = 11,
        NoSubstitutionTemplateLiteral = 12,
        TemplateHead = 13,
        TemplateMiddle = 14,
        TemplateTail = 15,
        OpenBraceToken = 16,
        CloseBraceToken = 17,
        OpenParenToken = 18,
        CloseParenToken = 19,
        OpenBracketToken = 20,
        CloseBracketToken = 21,
        DotToken = 22,
        DotDotDotToken = 23,
        SemicolonToken = 24,
        CommaToken = 25,
        LessThanToken = 26,
        LessThanSlashToken = 27,
        GreaterThanToken = 28,
        LessThanEqualsToken = 29,
        GreaterThanEqualsToken = 30,
        EqualsEqualsToken = 31,
        ExclamationEqualsToken = 32,
        EqualsEqualsEqualsToken = 33,
        ExclamationEqualsEqualsToken = 34,
        EqualsGreaterThanToken = 35,
        PlusToken = 36,
        MinusToken = 37,
        AsteriskToken = 38,
        AsteriskAsteriskToken = 39,
        SlashToken = 40,
        PercentToken = 41,
        PlusPlusToken = 42,
        MinusMinusToken = 43,
        LessThanLessThanToken = 44,
        GreaterThanGreaterThanToken = 45,
        GreaterThanGreaterThanGreaterThanToken = 46,
        AmpersandToken = 47,
        BarToken = 48,
        CaretToken = 49,
        ExclamationToken = 50,
        TildeToken = 51,
        AmpersandAmpersandToken = 52,
        BarBarToken = 53,
        QuestionToken = 54,
        ColonToken = 55,
        AtToken = 56,
        EqualsToken = 57,
        PlusEqualsToken = 58,
        MinusEqualsToken = 59,
        AsteriskEqualsToken = 60,
        AsteriskAsteriskEqualsToken = 61,
        SlashEqualsToken = 62,
        PercentEqualsToken = 63,
        LessThanLessThanEqualsToken = 64,
        GreaterThanGreaterThanEqualsToken = 65,
        GreaterThanGreaterThanGreaterThanEqualsToken = 66,
        AmpersandEqualsToken = 67,
        BarEqualsToken = 68,
        CaretEqualsToken = 69,
        Identifier = 70,
        BreakKeyword = 71,
        CaseKeyword = 72,
        CatchKeyword = 73,
        ClassKeyword = 74,
        ConstKeyword = 75,
        ContinueKeyword = 76,
        DebuggerKeyword = 77,
        DefaultKeyword = 78,
        DeleteKeyword = 79,
        DoKeyword = 80,
        ElseKeyword = 81,
        EnumKeyword = 82,
        ExportKeyword = 83,
        ExtendsKeyword = 84,
        FalseKeyword = 85,
        FinallyKeyword = 86,
        ForKeyword = 87,
        FunctionKeyword = 88,
        IfKeyword = 89,
        ImportKeyword = 90,
        InKeyword = 91,
        InstanceOfKeyword = 92,
        NewKeyword = 93,
        NullKeyword = 94,
        ReturnKeyword = 95,
        SuperKeyword = 96,
        SwitchKeyword = 97,
        ThisKeyword = 98,
        ThrowKeyword = 99,
        TrueKeyword = 100,
        TryKeyword = 101,
        TypeOfKeyword = 102,
        VarKeyword = 103,
        VoidKeyword = 104,
        WhileKeyword = 105,
        WithKeyword = 106,
        ImplementsKeyword = 107,
        InterfaceKeyword = 108,
        LetKeyword = 109,
        PackageKeyword = 110,
        PrivateKeyword = 111,
        ProtectedKeyword = 112,
        PublicKeyword = 113,
        StaticKeyword = 114,
        YieldKeyword = 115,
        AbstractKeyword = 116,
        AsKeyword = 117,
        AnyKeyword = 118,
        AsyncKeyword = 119,
        AwaitKeyword = 120,
        BooleanKeyword = 121,
        ConstructorKeyword = 122,
        DeclareKeyword = 123,
        GetKeyword = 124,
        IsKeyword = 125,
        ModuleKeyword = 126,
        NamespaceKeyword = 127,
        NeverKeyword = 128,
        ReadonlyKeyword = 129,
        RequireKeyword = 130,
        NumberKeyword = 131,
        SetKeyword = 132,
        StringKeyword = 133,
        SymbolKeyword = 134,
        TypeKeyword = 135,
        UndefinedKeyword = 136,
        FromKeyword = 137,
        GlobalKeyword = 138,
        OfKeyword = 139,
        QualifiedName = 140,
        ComputedPropertyName = 141,
        TypeParameter = 142,
        Parameter = 143,
        Decorator = 144,
        PropertySignature = 145,
        PropertyDeclaration = 146,
        MethodSignature = 147,
        MethodDeclaration = 148,
        Constructor = 149,
        GetAccessor = 150,
        SetAccessor = 151,
        CallSignature = 152,
        ConstructSignature = 153,
        IndexSignature = 154,
        TypePredicate = 155,
        TypeReference = 156,
        FunctionType = 157,
        ConstructorType = 158,
        TypeQuery = 159,
        TypeLiteral = 160,
        ArrayType = 161,
        TupleType = 162,
        UnionType = 163,
        IntersectionType = 164,
        ParenthesizedType = 165,
        ThisType = 166,
        LiteralType = 167,
        ObjectBindingPattern = 168,
        ArrayBindingPattern = 169,
        BindingElement = 170,
        ArrayLiteralExpression = 171,
        ObjectLiteralExpression = 172,
        PropertyAccessExpression = 173,
        ElementAccessExpression = 174,
        CallExpression = 175,
        NewExpression = 176,
        TaggedTemplateExpression = 177,
        TypeAssertionExpression = 178,
        ParenthesizedExpression = 179,
        FunctionExpression = 180,
        ArrowFunction = 181,
        DeleteExpression = 182,
        TypeOfExpression = 183,
        VoidExpression = 184,
        AwaitExpression = 185,
        PrefixUnaryExpression = 186,
        PostfixUnaryExpression = 187,
        BinaryExpression = 188,
        ConditionalExpression = 189,
        TemplateExpression = 190,
        YieldExpression = 191,
        SpreadElementExpression = 192,
        ClassExpression = 193,
        OmittedExpression = 194,
        ExpressionWithTypeArguments = 195,
        AsExpression = 196,
        NonNullExpression = 197,
        TemplateSpan = 198,
        SemicolonClassElement = 199,
        Block = 200,
        VariableStatement = 201,
        EmptyStatement = 202,
        ExpressionStatement = 203,
        IfStatement = 204,
        DoStatement = 205,
        WhileStatement = 206,
        ForStatement = 207,
        ForInStatement = 208,
        ForOfStatement = 209,
        ContinueStatement = 210,
        BreakStatement = 211,
        ReturnStatement = 212,
        WithStatement = 213,
        SwitchStatement = 214,
        LabeledStatement = 215,
        ThrowStatement = 216,
        TryStatement = 217,
        DebuggerStatement = 218,
        VariableDeclaration = 219,
        VariableDeclarationList = 220,
        FunctionDeclaration = 221,
        ClassDeclaration = 222,
        InterfaceDeclaration = 223,
        TypeAliasDeclaration = 224,
        EnumDeclaration = 225,
        ModuleDeclaration = 226,
        ModuleBlock = 227,
        CaseBlock = 228,
        NamespaceExportDeclaration = 229,
        ImportEqualsDeclaration = 230,
        ImportDeclaration = 231,
        ImportClause = 232,
        NamespaceImport = 233,
        NamedImports = 234,
        ImportSpecifier = 235,
        ExportAssignment = 236,
        ExportDeclaration = 237,
        NamedExports = 238,
        ExportSpecifier = 239,
        MissingDeclaration = 240,
        ExternalModuleReference = 241,
        JsxElement = 242,
        JsxSelfClosingElement = 243,
        JsxOpeningElement = 244,
        JsxClosingElement = 245,
        JsxAttribute = 246,
        JsxSpreadAttribute = 247,
        JsxExpression = 248,
        CaseClause = 249,
        DefaultClause = 250,
        HeritageClause = 251,
        CatchClause = 252,
        PropertyAssignment = 253,
        ShorthandPropertyAssignment = 254,
        EnumMember = 255,
        SourceFile = 256,
        JSDocTypeExpression = 257,
        JSDocAllType = 258,
        JSDocUnknownType = 259,
        JSDocArrayType = 260,
        JSDocUnionType = 261,
        JSDocTupleType = 262,
        JSDocNullableType = 263,
        JSDocNonNullableType = 264,
        JSDocRecordType = 265,
        JSDocRecordMember = 266,
        JSDocTypeReference = 267,
        JSDocOptionalType = 268,
        JSDocFunctionType = 269,
        JSDocVariadicType = 270,
        JSDocConstructorType = 271,
        JSDocThisType = 272,
        JSDocComment = 273,
        JSDocTag = 274,
        JSDocParameterTag = 275,
        JSDocReturnTag = 276,
        JSDocTypeTag = 277,
        JSDocTemplateTag = 278,
        JSDocTypedefTag = 279,
        JSDocPropertyTag = 280,
        JSDocTypeLiteral = 281,
        JSDocLiteralType = 282,
        JSDocNullKeyword = 283,
        JSDocUndefinedKeyword = 284,
        JSDocNeverKeyword = 285,
        SyntaxList = 286,
        NotEmittedStatement = 287,
        PartiallyEmittedExpression = 288,
        Count = 289,
        FirstAssignment = 57,
        LastAssignment = 69,
        FirstCompoundAssignment = 58,
        LastCompoundAssignment = 69,
        FirstReservedWord = 71,
        LastReservedWord = 106,
        FirstKeyword = 71,
        LastKeyword = 139,
        FirstFutureReservedWord = 107,
        LastFutureReservedWord = 115,
        FirstTypeNode = 155,
        LastTypeNode = 167,
        FirstPunctuation = 16,
        LastPunctuation = 69,
        FirstToken = 0,
        LastToken = 139,
        FirstTriviaToken = 2,
        LastTriviaToken = 7,
        FirstLiteralToken = 8,
        LastLiteralToken = 12,
        FirstTemplateToken = 12,
        LastTemplateToken = 15,
        FirstBinaryOperator = 26,
        LastBinaryOperator = 69,
        FirstNode = 140,
        FirstJSDocNode = 257,
        LastJSDocNode = 282,
        FirstJSDocTagNode = 273,
        LastJSDocTagNode = 285,
    }

    public enum NodeFlags
    {
        None = 0,
        Let = 1,
        Const = 2,
        NestedNamespace = 4,
        Synthesized = 8,
        Namespace = 16,
        ExportContext = 32,
        ContainsThis = 64,
        HasImplicitReturn = 128,
        HasExplicitReturn = 256,
        GlobalAugmentation = 512,
        HasClassExtends = 1024,
        HasDecorators = 2048,
        HasParamDecorators = 4096,
        HasAsyncFunctions = 8192,
        HasJsxSpreadAttributes = 16384,
        DisallowInContext = 32768,
        YieldContext = 65536,
        DecoratorContext = 131072,
        AwaitContext = 262144,
        ThisNodeHasError = 524288,
        JavaScriptFile = 1048576,
        ThisNodeOrAnySubNodesHasError = 2097152,
        HasAggregatedChildData = 4194304,
        BlockScoped = 3,
        ReachabilityCheckFlags = 384,
        EmitHelperFlags = 31744,
        ReachabilityAndEmitFlags = 32128,
        ContextFlags = 1540096,
        TypeExcludesFlags = 327680,
    }

    public enum ModifierFlags
    {
        None = 0,
        Export = 1,
        Ambient = 2,
        Public = 4,
        Private = 8,
        Protected = 16,
        Static = 32,
        Readonly = 64,
        Abstract = 128,
        Async = 256,
        Default = 512,
        Const = 2048,
        HasComputedFlags = 536870912,
        AccessibilityModifier = 28,
        ParameterPropertyModifier = 92,
        NonPublicAccessibilityModifier = 24,
        TypeScriptModifier = 2270,
    }

    public enum JsxFlags
    {
        None = 0,
        /** An element from a named property of the JSX.IntrinsicElements interface */
        IntrinsicNamedElement = 1,
        /** An element inferred from the string index signature of the JSX.IntrinsicElements interface */
        IntrinsicIndexedElement = 2,
        IntrinsicElement = 3,
    }

    public enum ModuleKind
    {
        None = 0,
        CommonJS = 1,
        AMD = 2,
        UMD = 3,
        System = 4,
        ES2015 = 5,
    }

    public enum JsxEmit
    {
        None = 0,
        Preserve = 1,
        React = 2,
    }

    public enum NewLineKind
    {
        CarriageReturnLineFeed = 0,
        LineFeed = 1,
    }

    public enum ScriptKind
    {
        Unknown = 0,
        JS = 1,
        JSX = 2,
        TS = 3,
        TSX = 4,
    }

    public enum ScriptTarget
    {
        ES3 = 0,
        ES5 = 1,
        ES2015 = 2,
        ES2016 = 3,
        ES2017 = 4,
        Latest = 4,
    }

    public enum LanguageVariant
    {
        Standard = 0,
        JSX = 1,
    }
}