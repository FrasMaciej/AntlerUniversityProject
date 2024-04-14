/**
 * Lexer for UMP importer
 */
lexer grammar GetUMPLex;

POLYGON_SECTstart : '[POLYGON]' -> pushMode(SECTION);

POLYLINE_SECTstart : '[POLYLINE]' -> pushMode(SECTION);

POI_SECTstart : '[POI]' -> pushMode(SECTION);

SECTstart :  '[' .*? ']' -> pushMode(SECTION); 

COMMENT
:
    ';' .*? '\n' -> skip
;

WS : [ \t\r\n]+ -> skip ; // skip newlines

//ID_d : [A-Za-z]+ ;


mode SECTION;

EQ : '=' ->pushMode(VALUE);

NL : ([\r\n]+|[\r]+|[\n]+) -> skip; // skip newlines

IntComment : '"' .*? '\n' -> skip;

SECTend: '[' ('END'|'End'|'end') ('-' .*?)? ']' -> popMode;

LabI : 'Label' [23] ;

ID : [A-Za-z:_]+ ;

NUM : [0-9]+;

mode VALUE;

V : ~([\r\n]|[\r]|[\n])* ('\r\n'|'\r'|'\n') -> popMode; 
