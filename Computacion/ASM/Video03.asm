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

    ; CODIGO PROGRAMA.-----------------
    
    ; SUMA
    MOV AL, 5
    ADD AL, 7
        
    ; RESTA
    MOV AL, 5
    SUB AL, 1


; -------------------------------------
    RET
    INICIO ENDP
CODIGO ENDS

END INICIO