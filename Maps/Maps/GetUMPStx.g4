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

idxEqId: ID NUM 
;

kvEq:
	key=(ID|LabI) EQ val=V (NL)? #simpleEq
|	idx=idxEqId EQ val=V (NL)? #idxEq
//|	ID NUM EQ val=V #idxEq
;
