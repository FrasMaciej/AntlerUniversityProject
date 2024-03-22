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
	key=(ID|LabI) EQ val=V #simpleEq
|	idx=idxEqId EQ val=V #idxEq
//|	ID NUM EQ val=V #idxEq
;
