/**
 * Syntax of MP format
 */
parser grammar GetUMPStx;

options {
  tokenVocab=GetUMPLex;
}


file :
 	section*
 	EOF
 ;
 
section:
 	SECTstart
 	kvEq*
 	SECTend
;

kvEq:
	key=(ID|LabI) EQ V #simpleEq
|	ID NUM EQ V #idxEq
;
