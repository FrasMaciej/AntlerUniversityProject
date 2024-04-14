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
	polygon_section |
	polyline_section |
 	poi_section | 
	default_section
;

polygon_section :
	POLYGON_SECTstart
	kvEq*
	SECTend
;

polyline_section:
	POLYLINE_SECTstart
	kvEq*
	SECTend
;

poi_section:
	POI_SECTstart
	kvEq*
	SECTend
;

default_section:
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
