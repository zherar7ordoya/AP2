TITLE ESTRUCTURA_BASICA

DATOS SEGMENT
; DECLARAR VARIABLES.------------------
; -------------------------------------
DATOS ENDS    

PILA SEGMENT
    DB 64 DUP(0)
PILA ENDS

CODIGO SEGMENT
    INICIO PROC FAR
    ASSUME DS:DATOS, CS:CODIGO, SS:PILA
    PUSH DS
    MOV  AX, 0
    PUSH AX
    MOV  AX, DATOS
    MOV  DS, AX
    MOV  ES, AX
; CODIGO PROGRAMA.---------------------

;8086 CPU has 8 general purpose registers,
;each register has its own name:

;AX - the accumulator register (divided into AH / AL).
;BX - the base address register (divided into BH / BL).
;CX - the count register (divided into CH / CL).
;DX - the data register (divided into DH / DL).

;SI - source index register.
;DI - destination index register.
;BP - base pointer.
;SP - stack pointer.

; -------------------------------------
    RET
    INICIO ENDP
CODIGO ENDS

END INICIO