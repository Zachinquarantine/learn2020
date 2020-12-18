      using namespace std;
      extern "C" void yyerror(char *s);
      extern "C" int yyparse();
    %}

    %union{
      int intVal;
      float floatVal;
    }

    %start program

    %token <intVal> INTEGER_LITERAL
    %token <floatVal> FLOAT_LITERAL
    %token SEMI
    %type <floatVal> exp
    %type <floatVal> statement
    %left PLUS MINUS
    %left MULT DIV
